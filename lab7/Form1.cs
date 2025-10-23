using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VectorApp
{
    public partial class Form1 : Form
    {
        private List<MyApp.Vector3d> vectorsInput = new List<MyApp.Vector3d>();
        private List<MyApp.Vector3d> vectorsResult = new List<MyApp.Vector3d>();

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
                
                if (!vectorsInput.Any(v => v.GetProjection('x') == vector1.GetProjection('x') && v.GetProjection('y') == vector1.GetProjection('y') && v.GetProjection('z') == vector1.GetProjection('z')))
                    vectorsInput.Add(vector1);
                if (!vectorsInput.Any(v => v.GetProjection('x') == vector2.GetProjection('x') && v.GetProjection('y') == vector2.GetProjection('y') && v.GetProjection('z') == vector2.GetProjection('z')))
                    vectorsInput.Add(vector2);
                
                var result = MyApp.Vector3d.Add(vector1, vector2);
                vectorsResult.Add(result);
                OutputTextbox.Text = Convert.ToString(result);
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
                
                if (!vectorsInput.Any(v => v.GetProjection('x') == vector1.GetProjection('x') && v.GetProjection('y') == vector1.GetProjection('y') && v.GetProjection('z') == vector1.GetProjection('z')))
                    vectorsInput.Add(vector1);
                if (!vectorsInput.Any(v => v.GetProjection('x') == vector2.GetProjection('x') && v.GetProjection('y') == vector2.GetProjection('y') && v.GetProjection('z') == vector2.GetProjection('z')))
                    vectorsInput.Add(vector2);
                
                var result = MyApp.Vector3d.Sub(vector1, vector2);
                vectorsResult.Add(result);
                OutputTextbox.Text = Convert.ToString(result);
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
                    if (!vectorsInput.Any(v => v.GetProjection('x') == vector1.GetProjection('x') && v.GetProjection('y') == vector1.GetProjection('y') && v.GetProjection('z') == vector1.GetProjection('z')))
                        vectorsInput.Add(vector1);
                    
                    var result = new MyApp.Vector3d(v1x, v1y, v1z).Multiply(Convert.ToDouble(MuliplierTextbox.Text));
                    vectorsResult.Add(result);
                    OutputTextbox.Text = Convert.ToString(result);
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
                    if (!vectorsInput.Any(v => v.GetProjection('x') == vector2.GetProjection('x') && v.GetProjection('y') == vector2.GetProjection('y') && v.GetProjection('z') == vector2.GetProjection('z')))
                        vectorsInput.Add(vector2);
                    
                    var result = new MyApp.Vector3d(v2x, v2y, v2z).Multiply(Convert.ToDouble(MuliplierTextbox.Text));
                    vectorsResult.Add(result);
                    OutputTextbox.Text = Convert.ToString(result);
                }
                catch (Exception ex)
                {
                    OutputTextbox.Text = Convert.ToString(ex);
                }
            }
        }

        private void Vector1Radio_CheckedChanged(object sender, EventArgs e)
        {
            MultButton.Enabled = Vector1Radio.Checked;
        }

        private void Vector2Radio_CheckedChanged(object sender, EventArgs e)
        {
            MultButton.Enabled = Vector2Radio.Checked;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var allVectors = vectorsInput.Concat(vectorsResult).ToList();
            var filtered = allVectors.Where(v => v.GetModule() > 5).ToList();
            
            string result = "Векторы с модулем > 5:" + Environment.NewLine;
            foreach (var vector in filtered)
            {
                result += $"{vector} (module: {vector.GetModule():F2})" + Environment.NewLine;
            }
            OutputTextbox.Text = result;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            var allVectors = vectorsInput.Concat(vectorsResult).ToList();
            var sorted = allVectors.OrderBy(v => v.GetModule()).ToList();
            
            string result = "Векторы отсортированные по модулю:" + Environment.NewLine;
            for (int i = 0; i < sorted.Count; i++)
            {
                var vector = sorted[i];
                result += $"{i + 1}. {vector} (module: {vector.GetModule():F2})" + Environment.NewLine;
            }
            OutputTextbox.Text = result;
        }

        private void GroupButton_Click(object sender, EventArgs e)
        {
            var allVectors = vectorsInput.Concat(vectorsResult).ToList();
            var grouped = allVectors.GroupBy(v => v.GetModule() < 5 ? "Small" : "Large").ToList();
            
            string result = "Векторы сортированные по размеру модуля:" + Environment.NewLine;
            foreach (var group in grouped)
            {
                result += Environment.NewLine + $"{group.Key} векторы (module {(group.Key == "Small" ? "< 5" : ">= 5")}):" + Environment.NewLine;
                int count = 1;
                foreach (var vector in group)
                {
                    result += $"  {count}. {vector} (module: {vector.GetModule():F2})" + Environment.NewLine;
                    count++;
                }
            }
            OutputTextbox.Text = result;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            vectorsInput.Clear();
            vectorsResult.Clear();
            OutputTextbox.Text = "Vector lists cleared";
        }
    }
}