using System.Runtime.Intrinsics;

namespace VectorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SummButton_Click(object sender, EventArgs e)
        {

            try
            {
                double v1x = Convert.ToDouble(V1x.Text);
                double v1y = Convert.ToDouble(V1y.Text);
                double v1z = Convert.ToDouble(V1z.Text);

                double v2x = Convert.ToDouble(V2x.Text);
                double v2y = Convert.ToDouble(V2y.Text);
                double v2z = Convert.ToDouble(V2z.Text);

                MyApp.Vector3d vector1 = new MyApp.Vector3d(v1x, v1y, v1z);
                MyApp.Vector3d vector2 = new MyApp.Vector3d(v2x, v2y, v2z);



                OutputTextbox.Text = Convert.ToString(MyApp.Vector3d.Add(vector1, vector2));

            }
            catch (Exception ex)
            {
                OutputTextbox.Text = Convert.ToString(ex);
            }
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            try
            {
                double v1x = Convert.ToDouble(V1x.Text);
                double v1y = Convert.ToDouble(V1y.Text);
                double v1z = Convert.ToDouble(V1z.Text);

                double v2x = Convert.ToDouble(V2x.Text);
                double v2y = Convert.ToDouble(V2y.Text);
                double v2z = Convert.ToDouble(V2z.Text);

                MyApp.Vector3d vector1 = new MyApp.Vector3d(v1x, v1y, v1z);
                MyApp.Vector3d vector2 = new MyApp.Vector3d(v2x, v2y, v2z);



                OutputTextbox.Text = Convert.ToString(MyApp.Vector3d.Sub(vector1, vector2));

            }
            catch (Exception ex)
            {
                OutputTextbox.Text = Convert.ToString(ex);
            }
        }

        private void MultButton_Click(object sender, EventArgs e)
        {

            if (Vector1Radio.Checked)
            {
                try
                {
                    double v1x = Convert.ToDouble(V1x.Text);
                    double v1y = Convert.ToDouble(V1y.Text);
                    double v1z = Convert.ToDouble(V1z.Text);

                    MyApp.Vector3d vector1 = new MyApp.Vector3d(v1x, v1y, v1z);
                    OutputTextbox.Text = Convert.ToString(vector1.Multiply(Convert.ToDouble(MuliplierTextbox.Text)));
                }
                catch (Exception ex)
                {
                    OutputTextbox.Text = Convert.ToString(ex);
                }
            }

            else if (Vector2Radio.Checked)
            {
                try
                {
                    double v2x = Convert.ToDouble(V2x.Text);
                    double v2y = Convert.ToDouble(V2y.Text);
                    double v2z = Convert.ToDouble(V2z.Text);

                    MyApp.Vector3d vector2 = new MyApp.Vector3d(v2x, v2y, v2z);
                    OutputTextbox.Text = Convert.ToString(vector2.Multiply(Convert.ToDouble(MuliplierTextbox.Text)));
                }
                catch (Exception ex)
                {
                    OutputTextbox.Text = Convert.ToString(ex);
                }
            }
        }

        private void Vector1Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (Vector1Radio.Checked)
            {
                MultButton.Enabled = true;
            }
            else
            {
                MultButton.Enabled = false;
            }
        }

        private void Vector2Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (Vector2Radio.Checked)
            {
                MultButton.Enabled = true;
            }
            else
            {
                MultButton.Enabled = false;
            }
        }
    }
}
