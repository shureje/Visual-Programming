using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Potentiometr : UserControl
    {
        public event EventHandler ValueChanged;

        public double MinRes;
        public double MaxRes;
        public double Value { get; set; }

        private Point knobCenter;
        private int knobBackRadius;
        private int knobRadius;
        private float currentAngle;
        private bool isDragging;
        private int scaleWidth;
        private int scaleHeight;
        private float previousAngle = -90;
        public double DefaultRes { get { return MaxRes - MinRes / 2; }}
        public Potentiometr()
        {
            InitializeComponent();
            MinRes = 0;
            MaxRes = 100;
            knobBackRadius = 100;
            knobRadius = 20;
            Value = DefaultRes;
            currentAngle = -90;
            scaleWidth = 300;
            scaleHeight = 25;

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //Рисование подложки ручки
            g.FillRectangle(Brushes.SaddleBrown, new Rectangle
               (
               knobCenter.X - knobBackRadius + knobBackRadius / 5,
               knobCenter.Y + knobBackRadius / 4,
               knobBackRadius * 2 - knobBackRadius / 5 * 2,
               knobBackRadius
               )
            );

            g.FillEllipse(Brushes.SandyBrown, new Rectangle
                (
                knobCenter.X - knobBackRadius, 
                knobCenter.Y - knobBackRadius,
                knobBackRadius * 2,
                knobBackRadius * 2
                )
            );
           

            g.FillRectangle(Brushes.LightGray, new Rectangle
               (
               knobCenter.X - knobBackRadius,
               knobCenter.Y - knobBackRadius/4,
               knobBackRadius * 2,
               knobBackRadius / 2
               )
            );

            Point[] octagonPoints = new Point[8];
            for (int i = 0; i < 8; i++)
            {
                double angle = i * Math.PI / 4;
                octagonPoints[i] = new Point (
                    knobCenter.X + (int)(Math.Cos(angle) * knobRadius * 2),
                    knobCenter.Y + (int)(Math.Sin(angle) * knobRadius * 2)
                );
            }
            g.FillPolygon(Brushes.DimGray, octagonPoints);

            g.DrawEllipse(Pens.Black, new Rectangle
               (
               knobCenter.X - knobBackRadius,
               knobCenter.Y - knobBackRadius,
               knobBackRadius * 2,
               knobBackRadius * 2
               )
           );

            //Рисование ножек потенциометра

            g.FillRectangle(Brushes.Gray, new Rectangle
                (
                knobCenter.X - knobBackRadius * 3/5, 
                knobCenter.Y + (5 / 4 * knobBackRadius) + knobBackRadius/10,
                knobBackRadius / 5, 
                knobBackRadius / 2
                )
            );

            g.FillRectangle(Brushes.Gray, new Rectangle
               (
               knobCenter.X + knobBackRadius * 2 / 5,
               knobCenter.Y + (5 / 4 * knobBackRadius) + knobBackRadius / 10,
               knobBackRadius / 5,
               knobBackRadius / 2
               )
            );

            g.FillRectangle(Brushes.Gray, new Rectangle
               (
               knobCenter.X - knobBackRadius / 10,
               knobCenter.Y + (5 / 4 * knobBackRadius) + knobBackRadius / 10,
               knobBackRadius / 5,
               knobBackRadius / 2
               )
            );



            //Рисование ручки потенциометра
            
            g.FillEllipse(Brushes.DarkGray, new Rectangle
                (
                    knobCenter.X - knobRadius, knobCenter.Y - knobRadius,
                    knobRadius*2, knobRadius*2
                )
            );

            float angleRad = (float)(currentAngle * Math.PI / 180);
            int pointerLength = knobRadius;
            Point pointerEnd = new Point(
                knobCenter.X + (int)(Math.Cos(angleRad) * pointerLength),
                knobCenter.Y + (int)(Math.Sin(angleRad) * pointerLength)
            );
            g.DrawLine(new Pen(Color.Black, 3), knobCenter, pointerEnd);

            //рисование шкалы 

            g.DrawRectangle(Pens.Black, new Rectangle
                (
                ClientRectangle.Width / 2 - scaleWidth/2, ClientRectangle.Height * 1/8,
                scaleWidth, scaleHeight
                )
            );

            //заполнение шкалы
            int divisions = 10;
            for (int i = 0; i <= divisions; i++)
            {
                int x = ClientRectangle.Width / 2 - scaleWidth / 2 + (scaleWidth * i / divisions);
                g.DrawLine(Pens.Black, x, ClientRectangle.Height * 1 / 8,
                           x, ClientRectangle.Height * 1 / 8 + scaleHeight);
            }

            g.DrawString(MinRes.ToString(), Font, Brushes.Black,
             ClientRectangle.Width / 2 - scaleWidth / 2, ClientRectangle.Height * 1 / 8 - 20);
            g.DrawString(MaxRes.ToString(), Font, Brushes.Black,
                         ClientRectangle.Width / 2 + scaleWidth / 2 - 30, ClientRectangle.Height * 1 / 8 - 20);

            double valuePosition = (Value - MinRes) / (MaxRes - MinRes);
            int indicatorX = (int)(ClientRectangle.Width / 2 - scaleWidth / 2 + scaleWidth * valuePosition);
            g.FillRectangle(Brushes.Red, indicatorX - 2, ClientRectangle.Height * 1 / 8 - 5, 4, scaleHeight + 10);

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            knobCenter = new Point(ClientRectangle.Width / 2,  ClientRectangle.Height / 2 );
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            double distance = Math.Sqrt(Math.Pow(e.X - knobCenter.X, 2) + Math.Pow(e.Y - knobCenter.Y, 2));
            if (distance <= knobRadius)
            {
                isDragging = true;
            }

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (isDragging)
            {
                float angle = (float)(Math.Atan2(e.Y - knobCenter.Y, e.X - knobCenter.X) * 180 / Math.PI);
                float diff = angle - previousAngle;
                if (diff > 180) angle -= 360;
                if (diff < -180) angle += 360;

                float minAngle = -90 - 150; 
                float maxAngle = -90 + 150;

                if (angle < minAngle) angle = minAngle;
                if (angle > maxAngle) angle = maxAngle;

                currentAngle = angle;
                previousAngle = angle;


                Value = MinRes + (currentAngle + 240) / 300.0 * (MaxRes - MinRes);

                ValueChanged?.Invoke(this, EventArgs.Empty);
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
