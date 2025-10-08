namespace lab6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            potentiometr1 = new Potentiometr();
            SuspendLayout();
            // 
            // potentiometr1
            // 
            potentiometr1.Dock = DockStyle.Fill;
            potentiometr1.Location = new Point(0, 0);
            potentiometr1.Name = "potentiometr1";
            potentiometr1.Size = new Size(800, 450);
            potentiometr1.TabIndex = 0;
            potentiometr1.Value = 100D;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(potentiometr1);
            Name = "Form1";
            Text = "НЕНАВИЖУ МАТЕМАТИКУ УАОУАОАОУОАОУО";
            ResumeLayout(false);
        }

        #endregion

        private Potentiometr potentiometr1;
    }
}
