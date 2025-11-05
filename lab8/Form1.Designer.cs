namespace lab8
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.loadButton = new Button();
            this.progressBar = new ProgressBar();
            this.statusLabel = new Label();
            this.contentTextBox = new RichTextBox();
            this.SuspendLayout();

            // loadButton
            this.loadButton.Location = new Point(10, 10);
            this.loadButton.Size = new Size(120, 30);
            this.loadButton.Text = "Загрузить RSS";
            this.loadButton.Click += LoadButton_Click;

            // progressBar
            this.progressBar.Location = new Point(140, 15);
            this.progressBar.Size = new Size(200, 20);
            this.progressBar.Style = ProgressBarStyle.Marquee;
            this.progressBar.Visible = false;

            // statusLabel
            this.statusLabel.Location = new Point(350, 15);
            this.statusLabel.Size = new Size(300, 20);
            this.statusLabel.Text = "Готов к загрузке";

            // contentTextBox
            this.contentTextBox.Location = new Point(10, 50);
            this.contentTextBox.Size = new Size(860, 600);
            this.contentTextBox.ReadOnly = true;
            this.contentTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;

            // Form1
            this.ClientSize = new Size(900, 700);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.contentTextBox);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "RSS Reader - Lenta.ru";
            this.ResumeLayout(false);
        }
    }
}
