namespace VectorApp
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            MultButton = new Button();
            SubButton = new Button();
            SummButton = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            V2z = new TextBox();
            V2y = new TextBox();
            V2x = new TextBox();
            Vector2Label = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel3 = new Panel();
            MuliplierTextbox = new TextBox();
            label1 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            Vector2Radio = new RadioButton();
            Vector1Radio = new RadioButton();
            panel1 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            V1z = new TextBox();
            V1y = new TextBox();
            V1x = new TextBox();
            Vector1Lable = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            FilterButton = new Button();
            SortButton = new Button();
            GroupButton = new Button();
            ClearButton = new Button();
            OutputTextbox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(OutputTextbox, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(724, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 238F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel9, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(720, 226);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(MultButton, 0, 2);
            tableLayoutPanel3.Controls.Add(SubButton, 0, 1);
            tableLayoutPanel3.Controls.Add(SummButton, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(243, 2);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(237, 222);
            tableLayoutPanel3.TabIndex = 0;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // MultButton
            // 
            MultButton.Anchor = AnchorStyles.None;
            MultButton.AutoSize = true;
            MultButton.Enabled = false;
            MultButton.Location = new Point(45, 169);
            MultButton.Margin = new Padding(6);
            MultButton.Name = "MultButton";
            MultButton.Size = new Size(147, 30);
            MultButton.TabIndex = 2;
            MultButton.Text = "Multiply by a scalar";
            MultButton.UseVisualStyleBackColor = true;
            MultButton.Click += MultButton_Click;
            // 
            // SubButton
            // 
            SubButton.Anchor = AnchorStyles.None;
            SubButton.AutoSize = true;
            SubButton.Location = new Point(72, 94);
            SubButton.Margin = new Padding(6);
            SubButton.Name = "SubButton";
            SubButton.Size = new Size(92, 30);
            SubButton.TabIndex = 1;
            SubButton.Text = "Substract";
            SubButton.UseVisualStyleBackColor = true;
            SubButton.Click += SubButton_Click;
            // 
            // SummButton
            // 
            SummButton.Anchor = AnchorStyles.None;
            SummButton.AutoSize = true;
            SummButton.Location = new Point(72, 21);
            SummButton.Margin = new Padding(6);
            SummButton.Name = "SummButton";
            SummButton.Size = new Size(92, 30);
            SummButton.TabIndex = 0;
            SummButton.Text = "Summ";
            SummButton.UseVisualStyleBackColor = true;
            SummButton.Click += SummButton_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panel2, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel4.Controls.Add(panel1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(2, 2);
            tableLayoutPanel4.Margin = new Padding(2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Size = new Size(237, 222);
            tableLayoutPanel4.TabIndex = 1;
            tableLayoutPanel4.Paint += tableLayoutPanel4_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel7);
            panel2.Controls.Add(Vector2Label);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(2, 75);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 69);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.Controls.Add(V2z, 2, 0);
            tableLayoutPanel7.Controls.Add(V2y, 1, 0);
            tableLayoutPanel7.Controls.Add(V2x, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 20);
            tableLayoutPanel7.Margin = new Padding(2);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(233, 49);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // V2z
            // 
            V2z.Anchor = AnchorStyles.None;
            V2z.Location = new Point(166, 12);
            V2z.Margin = new Padding(12);
            V2z.Name = "V2z";
            V2z.Size = new Size(55, 27);
            V2z.TabIndex = 2;
            // 
            // V2y
            // 
            V2y.Anchor = AnchorStyles.None;
            V2y.Location = new Point(89, 12);
            V2y.Margin = new Padding(12);
            V2y.Name = "V2y";
            V2y.Size = new Size(53, 27);
            V2y.TabIndex = 1;
            // 
            // V2x
            // 
            V2x.Anchor = AnchorStyles.None;
            V2x.Location = new Point(12, 12);
            V2x.Margin = new Padding(12);
            V2x.Name = "V2x";
            V2x.Size = new Size(53, 27);
            V2x.TabIndex = 0;
            // 
            // Vector2Label
            // 
            Vector2Label.Dock = DockStyle.Top;
            Vector2Label.Location = new Point(0, 0);
            Vector2Label.Margin = new Padding(2, 0, 2, 0);
            Vector2Label.Name = "Vector2Label";
            Vector2Label.Size = new Size(233, 20);
            Vector2Label.TabIndex = 0;
            Vector2Label.Text = "Vector2 координаты";
            Vector2Label.Click += label1_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel3, 1, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(2, 148);
            tableLayoutPanel5.Margin = new Padding(2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(233, 72);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(MuliplierTextbox);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(118, 2);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(113, 68);
            panel3.TabIndex = 0;
            // 
            // MuliplierTextbox
            // 
            MuliplierTextbox.Anchor = AnchorStyles.None;
            MuliplierTextbox.Location = new Point(9, 29);
            MuliplierTextbox.Margin = new Padding(12);
            MuliplierTextbox.Name = "MuliplierTextbox";
            MuliplierTextbox.Size = new Size(94, 27);
            MuliplierTextbox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Multiplier";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(Vector2Radio, 0, 1);
            tableLayoutPanel8.Controls.Add(Vector1Radio, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(2, 2);
            tableLayoutPanel8.Margin = new Padding(2);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(112, 68);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // Vector2Radio
            // 
            Vector2Radio.AutoSize = true;
            Vector2Radio.Dock = DockStyle.Fill;
            Vector2Radio.Location = new Point(2, 36);
            Vector2Radio.Margin = new Padding(2);
            Vector2Radio.Name = "Vector2Radio";
            Vector2Radio.Size = new Size(108, 30);
            Vector2Radio.TabIndex = 1;
            Vector2Radio.TabStop = true;
            Vector2Radio.Text = "Vector 2";
            Vector2Radio.UseVisualStyleBackColor = true;
            Vector2Radio.CheckedChanged += Vector2Radio_CheckedChanged;
            // 
            // Vector1Radio
            // 
            Vector1Radio.AutoSize = true;
            Vector1Radio.Dock = DockStyle.Fill;
            Vector1Radio.Location = new Point(2, 2);
            Vector1Radio.Margin = new Padding(2);
            Vector1Radio.Name = "Vector1Radio";
            Vector1Radio.Size = new Size(108, 30);
            Vector1Radio.TabIndex = 0;
            Vector1Radio.TabStop = true;
            Vector1Radio.Text = "Vector 1";
            Vector1Radio.UseVisualStyleBackColor = true;
            Vector1Radio.CheckedChanged += Vector1Radio_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel6);
            panel1.Controls.Add(Vector1Lable);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 69);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Controls.Add(V1z, 2, 0);
            tableLayoutPanel6.Controls.Add(V1y, 1, 0);
            tableLayoutPanel6.Controls.Add(V1x, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 20);
            tableLayoutPanel6.Margin = new Padding(2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(233, 49);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // V1z
            // 
            V1z.Anchor = AnchorStyles.None;
            V1z.Location = new Point(166, 12);
            V1z.Margin = new Padding(12);
            V1z.Name = "V1z";
            V1z.Size = new Size(55, 27);
            V1z.TabIndex = 2;
            // 
            // V1y
            // 
            V1y.Anchor = AnchorStyles.None;
            V1y.Location = new Point(89, 12);
            V1y.Margin = new Padding(12);
            V1y.Name = "V1y";
            V1y.Size = new Size(53, 27);
            V1y.TabIndex = 1;
            // 
            // V1x
            // 
            V1x.Anchor = AnchorStyles.None;
            V1x.Location = new Point(12, 12);
            V1x.Margin = new Padding(12);
            V1x.Name = "V1x";
            V1x.Size = new Size(53, 27);
            V1x.TabIndex = 0;
            // 
            // Vector1Lable
            // 
            Vector1Lable.Dock = DockStyle.Top;
            Vector1Lable.Location = new Point(0, 0);
            Vector1Lable.Margin = new Padding(2, 0, 2, 0);
            Vector1Lable.Name = "Vector1Lable";
            Vector1Lable.Size = new Size(233, 20);
            Vector1Lable.TabIndex = 0;
            Vector1Lable.Text = "Vector1 координаты";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(FilterButton, 0, 0);
            tableLayoutPanel9.Controls.Add(SortButton, 0, 1);
            tableLayoutPanel9.Controls.Add(GroupButton, 0, 2);
            tableLayoutPanel9.Controls.Add(ClearButton, 0, 3);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(484, 2);
            tableLayoutPanel9.Margin = new Padding(2);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 4;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.Size = new Size(234, 222);
            tableLayoutPanel9.TabIndex = 2;
            // 
            // FilterButton
            // 
            FilterButton.Anchor = AnchorStyles.None;
            FilterButton.AutoSize = true;
            FilterButton.Location = new Point(49, 12);
            FilterButton.Margin = new Padding(6);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(136, 30);
            FilterButton.TabIndex = 0;
            FilterButton.Text = "Фильтрация (>5)";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += FilterButton_Click;
            // 
            // SortButton
            // 
            SortButton.Anchor = AnchorStyles.None;
            SortButton.AutoSize = true;
            SortButton.Location = new Point(25, 67);
            SortButton.Margin = new Padding(6);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(183, 30);
            SortButton.TabIndex = 1;
            SortButton.Text = "Сортировка по модулю";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // GroupButton
            // 
            GroupButton.Anchor = AnchorStyles.None;
            GroupButton.AutoSize = true;
            GroupButton.Location = new Point(62, 122);
            GroupButton.Margin = new Padding(6);
            GroupButton.Name = "GroupButton";
            GroupButton.Size = new Size(110, 30);
            GroupButton.TabIndex = 2;
            GroupButton.Text = "Группировка";
            GroupButton.UseVisualStyleBackColor = true;
            GroupButton.Click += GroupButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.None;
            ClearButton.AutoSize = true;
            ClearButton.Location = new Point(75, 178);
            ClearButton.Margin = new Padding(6);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(83, 30);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // OutputTextbox
            // 
            OutputTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OutputTextbox.Location = new Point(12, 242);
            OutputTextbox.Margin = new Padding(12);
            OutputTextbox.Multiline = true;
            OutputTextbox.Name = "OutputTextbox";
            OutputTextbox.ScrollBars = ScrollBars.Vertical;
            OutputTextbox.Size = new Size(700, 207);
            OutputTextbox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 461);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            MinimumSize = new Size(499, 393);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button SummButton;
        private Button MultButton;
        private Button SubButton;
        private TextBox OutputTextbox;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel1;
        private Label Vector1Lable;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox V1z;
        private TextBox V1y;
        private TextBox V1x;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox V2z;
        private TextBox V2y;
        private TextBox V2x;
        private Label Vector2Label;
        private Panel panel3;
        private TextBox MuliplierTextbox;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel8;
        private RadioButton Vector2Radio;
        private RadioButton Vector1Radio;
        private TableLayoutPanel tableLayoutPanel9;
        private Button FilterButton;
        private Button SortButton;
        private Button GroupButton;
        private Button ClearButton;
    }
}
