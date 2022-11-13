namespace WinFormsCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResultButtom = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButtom = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.ModuloButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(525, 31);
            this.textBox1.TabIndex = 0;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.ResultButtom, 3, 4);
            this.ButtonsPanel.Controls.Add(this.DotButton, 2, 4);
            this.ButtonsPanel.Controls.Add(this.ZeroButton, 1, 4);
            this.ButtonsPanel.Controls.Add(this.AddButton, 3, 3);
            this.ButtonsPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonsPanel.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonsPanel.Controls.Add(this.OneButton, 0, 3);
            this.ButtonsPanel.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonsPanel.Controls.Add(this.SixButton, 2, 2);
            this.ButtonsPanel.Controls.Add(this.FiveButtom, 1, 2);
            this.ButtonsPanel.Controls.Add(this.FourButton, 0, 2);
            this.ButtonsPanel.Controls.Add(this.MultiplicationButton, 3, 1);
            this.ButtonsPanel.Controls.Add(this.NineButton, 2, 1);
            this.ButtonsPanel.Controls.Add(this.EightButton, 1, 1);
            this.ButtonsPanel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonsPanel.Controls.Add(this.DivideButton, 3, 0);
            this.ButtonsPanel.Controls.Add(this.ModuloButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPanel.Controls.Add(this.CButton, 1, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(12, 59);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(535, 534);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // ResultButtom
            // 
            this.ResultButtom.BackColor = System.Drawing.Color.Black;
            this.ResultButtom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResultButtom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultButtom.ForeColor = System.Drawing.Color.White;
            this.ResultButtom.Location = new System.Drawing.Point(402, 427);
            this.ResultButtom.Name = "ResultButtom";
            this.ResultButtom.Size = new System.Drawing.Size(130, 104);
            this.ResultButtom.TabIndex = 19;
            this.ResultButtom.Text = "=";
            this.ResultButtom.UseVisualStyleBackColor = false;
            // 
            // DotButton
            // 
            this.DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotButton.Location = new System.Drawing.Point(269, 427);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(127, 104);
            this.DotButton.TabIndex = 18;
            this.DotButton.Text = "0";
            this.DotButton.UseVisualStyleBackColor = true;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Location = new System.Drawing.Point(136, 427);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(127, 104);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Black;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(402, 321);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(130, 100);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Location = new System.Drawing.Point(269, 321);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(127, 100);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Location = new System.Drawing.Point(136, 321);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(127, 100);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Location = new System.Drawing.Point(3, 321);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(127, 100);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.Black;
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.ForeColor = System.Drawing.Color.White;
            this.MinusButton.Location = new System.Drawing.Point(402, 215);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(130, 100);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Location = new System.Drawing.Point(269, 215);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(127, 100);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "C";
            this.SixButton.UseVisualStyleBackColor = true;
            // 
            // FiveButtom
            // 
            this.FiveButtom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButtom.Location = new System.Drawing.Point(136, 215);
            this.FiveButtom.Name = "FiveButtom";
            this.FiveButtom.Size = new System.Drawing.Size(127, 100);
            this.FiveButtom.TabIndex = 9;
            this.FiveButtom.Text = "5";
            this.FiveButtom.UseVisualStyleBackColor = true;
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Location = new System.Drawing.Point(3, 215);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(127, 100);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.BackColor = System.Drawing.Color.Black;
            this.MultiplicationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplicationButton.ForeColor = System.Drawing.Color.White;
            this.MultiplicationButton.Location = new System.Drawing.Point(402, 109);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(130, 100);
            this.MultiplicationButton.TabIndex = 7;
            this.MultiplicationButton.Text = "x";
            this.MultiplicationButton.UseVisualStyleBackColor = false;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Location = new System.Drawing.Point(269, 109);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(127, 100);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Location = new System.Drawing.Point(136, 109);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(127, 100);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.White;
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.ForeColor = System.Drawing.Color.Black;
            this.SevenButton.Location = new System.Drawing.Point(3, 109);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(127, 100);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.BackColor = System.Drawing.Color.Black;
            this.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivideButton.ForeColor = System.Drawing.Color.White;
            this.DivideButton.Location = new System.Drawing.Point(402, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(130, 100);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = false;
            this.DivideButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModuloButton
            // 
            this.ModuloButton.BackColor = System.Drawing.Color.Black;
            this.ModuloButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModuloButton.ForeColor = System.Drawing.Color.White;
            this.ModuloButton.Location = new System.Drawing.Point(269, 3);
            this.ModuloButton.Name = "ModuloButton";
            this.ModuloButton.Size = new System.Drawing.Size(127, 100);
            this.ModuloButton.TabIndex = 2;
            this.ModuloButton.Text = "%";
            this.ModuloButton.UseVisualStyleBackColor = false;
            this.ModuloButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // CEButton
            // 
            this.CEButton.BackColor = System.Drawing.Color.Black;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.ForeColor = System.Drawing.Color.White;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(127, 100);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = false;
            this.CEButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.Color.Black;
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.ForeColor = System.Drawing.Color.White;
            this.CButton.Location = new System.Drawing.Point(136, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(127, 100);
            this.CButton.TabIndex = 1;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 607);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TableLayoutPanel ButtonsPanel;
        private Button CEButton;
        private Button CButton;
        private Button ResultButtom;
        private Button DotButton;
        private Button ZeroButton;
        private Button AddButton;
        private Button ThreeButton;
        private Button TwoButton;
        private Button OneButton;
        private Button MinusButton;
        private Button SixButton;
        private Button FiveButtom;
        private Button FourButton;
        private Button MultiplicationButton;
        private Button NineButton;
        private Button EightButton;
        private Button SevenButton;
        private Button DivideButton;
        private Button ModuloButton;
    }
}