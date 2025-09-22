namespace lab4
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
            OutputBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            InputDeleteValue = new TextBox();
            DeleteByIndexButton = new Button();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            InputTextBox = new TextBox();
            AddByIndexButton = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label2 = new Label();
            MaxElementButton = new Button();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label4 = new Label();
            MinElementButton = new Button();
            flowLayoutPanel7 = new FlowLayoutPanel();
            label3 = new Label();
            label5 = new Label();
            GetElemButton = new Button();
            groupBox3 = new GroupBox();
            AllElementsButton = new Button();
            GetIndexNumUpDownToGet = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GetIndexNumUpDownToGet).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(OutputBox, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 67.23017F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.7698326F));
            tableLayoutPanel1.Size = new Size(1041, 769);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // OutputBox
            // 
            OutputBox.Dock = DockStyle.Fill;
            OutputBox.Location = new Point(20, 537);
            OutputBox.Margin = new Padding(20);
            OutputBox.Multiline = true;
            OutputBox.Name = "OutputBox";
            OutputBox.Size = new Size(1001, 212);
            OutputBox.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox3, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1035, 511);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(520, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(512, 249);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Удалить элемент";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(InputDeleteValue);
            flowLayoutPanel2.Controls.Add(DeleteByIndexButton);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 23);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(506, 223);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            flowLayoutPanel2.SetFlowBreak(label1, true);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 33);
            label1.TabIndex = 3;
            label1.Text = "Значение:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // InputDeleteValue
            // 
            InputDeleteValue.Dock = DockStyle.Top;
            flowLayoutPanel2.SetFlowBreak(InputDeleteValue, true);
            InputDeleteValue.Location = new Point(3, 36);
            InputDeleteValue.Name = "InputDeleteValue";
            InputDeleteValue.Size = new Size(408, 27);
            InputDeleteValue.TabIndex = 4;
            // 
            // DeleteByIndexButton
            // 
            DeleteByIndexButton.AutoSize = true;
            DeleteByIndexButton.Dock = DockStyle.Top;
            DeleteByIndexButton.Location = new Point(3, 69);
            DeleteByIndexButton.Name = "DeleteByIndexButton";
            DeleteByIndexButton.Size = new Size(94, 30);
            DeleteByIndexButton.TabIndex = 1;
            DeleteByIndexButton.Text = "Удалить";
            DeleteByIndexButton.UseVisualStyleBackColor = true;
            DeleteByIndexButton.Click += DeleteByIndexButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 249);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить элемент";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(InputTextBox);
            flowLayoutPanel1.Controls.Add(AddByIndexButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 23);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(505, 223);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // InputTextBox
            // 
            InputTextBox.Dock = DockStyle.Top;
            flowLayoutPanel1.SetFlowBreak(InputTextBox, true);
            InputTextBox.Location = new Point(3, 3);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(408, 27);
            InputTextBox.TabIndex = 0;
            InputTextBox.TextChanged += InputTextBox_TextChanged;
            // 
            // AddByIndexButton
            // 
            AddByIndexButton.AutoSize = true;
            AddByIndexButton.Dock = DockStyle.Right;
            AddByIndexButton.Location = new Point(3, 36);
            AddByIndexButton.Name = "AddByIndexButton";
            AddByIndexButton.Size = new Size(94, 30);
            AddByIndexButton.TabIndex = 1;
            AddByIndexButton.Text = "Добавить";
            AddByIndexButton.UseVisualStyleBackColor = true;
            AddByIndexButton.Click += AddByIndexButton_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 258);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(511, 250);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(label2);
            flowLayoutPanel5.Controls.Add(MaxElementButton);
            flowLayoutPanel3.SetFlowBreak(flowLayoutPanel5, true);
            flowLayoutPanel5.Location = new Point(3, 10);
            flowLayoutPanel5.Margin = new Padding(3, 10, 3, 10);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(284, 36);
            flowLayoutPanel5.TabIndex = 3;
            flowLayoutPanel5.Paint += flowLayoutPanel5_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 36);
            label2.TabIndex = 4;
            label2.Text = "Максимальный элемент";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MaxElementButton
            // 
            MaxElementButton.AutoSize = true;
            MaxElementButton.Dock = DockStyle.Right;
            MaxElementButton.Location = new Point(187, 3);
            MaxElementButton.Name = "MaxElementButton";
            MaxElementButton.Size = new Size(94, 30);
            MaxElementButton.TabIndex = 5;
            MaxElementButton.Text = "Получить";
            MaxElementButton.UseVisualStyleBackColor = true;
            MaxElementButton.Click += MaxElementButton_Click;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.Controls.Add(label4);
            flowLayoutPanel6.Controls.Add(MinElementButton);
            flowLayoutPanel6.Dock = DockStyle.Top;
            flowLayoutPanel3.SetFlowBreak(flowLayoutPanel6, true);
            flowLayoutPanel6.Location = new Point(3, 66);
            flowLayoutPanel6.Margin = new Padding(3, 10, 3, 10);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(280, 36);
            flowLayoutPanel6.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(174, 36);
            label4.TabIndex = 4;
            label4.Text = "Минимальный элемент";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MinElementButton
            // 
            MinElementButton.AutoSize = true;
            MinElementButton.Dock = DockStyle.Right;
            MinElementButton.Location = new Point(183, 3);
            MinElementButton.Name = "MinElementButton";
            MinElementButton.Size = new Size(94, 30);
            MinElementButton.TabIndex = 5;
            MinElementButton.Text = "Получить";
            MinElementButton.UseVisualStyleBackColor = true;
            MinElementButton.Click += MinElementButton_Click;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.Controls.Add(label3);
            flowLayoutPanel7.Controls.Add(label5);
            flowLayoutPanel7.Controls.Add(GetIndexNumUpDownToGet);
            flowLayoutPanel7.Controls.Add(GetElemButton);
            flowLayoutPanel7.Dock = DockStyle.Fill;
            flowLayoutPanel3.SetFlowBreak(flowLayoutPanel7, true);
            flowLayoutPanel7.Location = new Point(3, 122);
            flowLayoutPanel7.Margin = new Padding(3, 10, 3, 10);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(251, 89);
            flowLayoutPanel7.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            flowLayoutPanel7.SetFlowBreak(label3, true);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(177, 20);
            label3.TabIndex = 7;
            label3.Text = "Произвольный элемент";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 20);
            label5.Name = "label5";
            label5.Size = new Size(62, 33);
            label5.TabIndex = 4;
            label5.Text = "Индекс:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // GetElemButton
            // 
            GetElemButton.AutoSize = true;
            GetElemButton.Dock = DockStyle.Top;
            GetElemButton.Location = new Point(3, 56);
            GetElemButton.Name = "GetElemButton";
            GetElemButton.Size = new Size(94, 30);
            GetElemButton.TabIndex = 5;
            GetElemButton.Text = "Получить";
            GetElemButton.UseVisualStyleBackColor = true;
            GetElemButton.Click += GetElemButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(AllElementsButton);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(520, 258);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(512, 250);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Все элементы списка";
            // 
            // AllElementsButton
            // 
            AllElementsButton.AutoSize = true;
            AllElementsButton.Location = new Point(163, 65);
            AllElementsButton.Name = "AllElementsButton";
            AllElementsButton.Size = new Size(94, 30);
            AllElementsButton.TabIndex = 6;
            AllElementsButton.Text = "Получить";
            AllElementsButton.UseVisualStyleBackColor = true;
            AllElementsButton.Click += AllElementsButton_Click;
            // 
            // GetIndexNumUpDownToGet
            // 
            GetIndexNumUpDownToGet.Dock = DockStyle.Top;
            flowLayoutPanel7.SetFlowBreak(GetIndexNumUpDownToGet, true);
            GetIndexNumUpDownToGet.Location = new Point(71, 23);
            GetIndexNumUpDownToGet.Name = "GetIndexNumUpDownToGet";
            GetIndexNumUpDownToGet.Size = new Size(150, 27);
            GetIndexNumUpDownToGet.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1041, 769);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GetIndexNumUpDownToGet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox OutputBox;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox InputTextBox;
        private Button AddByIndexButton;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button DeleteByIndexButton;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label2;
        private Button MaxElementButton;
        private GroupBox groupBox3;
        private Button AllElementsButton;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label4;
        private Button MinElementButton;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label5;
        private Button GetElemButton;
        private TextBox InputDeleteValue;
        private Label label3;
        private NumericUpDown GetIndexNumUpDownToGet;
    }
}
