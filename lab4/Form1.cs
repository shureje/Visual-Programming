namespace lab4
{
    public partial class Form1 : Form
    {
        private GenericsDescSortedList<string> list = new GenericsDescSortedList<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddByIndexButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text.Length > 0)
            {
                list.Add(InputTextBox.Text);
            }
        }

        private void AllElementsButton_Click(object sender, EventArgs e)
        {
            OutputBox.Text = list.ToString();
        }

        private void DeleteByIndexButton_Click(object sender, EventArgs e)
        {

        }

        private void MaxElementButton_Click(object sender, EventArgs e)
        {
            try
            {
                OutputBox.Text = list.Max();
            }
            catch (Exception ex)
            {
                OutputBox.Text += ex.ToString();
            }
        }

        private void MinElementButton_Click(object sender, EventArgs e)
        {
            try
            {
                OutputBox.Text = list.Min();
            }
            catch (Exception ex)
            {
                OutputBox.Text += ex.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void GetElemButton_Click(object sender, EventArgs e)
        {
            var index = (int)GetIndexNumUpDownToGet.Value - 1;
            if (index > 0 && index < list.Count)
            {
                try
                {
                    OutputBox.Text = list.Get(index).ToString();
                }
                catch (Exception ex)
                {
                    OutputBox.Text += ex.ToString();
                }
            }
        }
    }
}
