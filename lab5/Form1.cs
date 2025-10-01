namespace lab5
{
    public partial class Form1 : Form
    {
        private CircularMotionDetector detector;
        public Form1()
        {
            InitializeComponent();
            InitializeDetector();


        }

        private void InitializeDetector()
        {
            detector = new CircularMotionDetector();
            detector.CircularMotionDetected += OnCircularMotionDetected;

            this.MouseMove += Form1_MouseMove;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                detector.AddPoint(e.Location);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnCircularMotionDetected(object sender, CircularMotionEventArgs e)
        {
            MessageBox.Show($"Круговое движение обнаружено!\nЦентр: ({e.Center.X}, {e.Center.Y})\nРадиус: {e.Radius}");
        }
    }
}
