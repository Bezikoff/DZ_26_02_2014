namespace DZ_26_02_2014
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
            LB1 = new ListBox();
            TB1 = new TextBox();
            TB2 = new TextBox();
            TB3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // LB1
            // 
            LB1.FormattingEnabled = true;
            LB1.ItemHeight = 15;
            LB1.Location = new Point(40, 148);
            LB1.Name = "LB1";
            LB1.Size = new Size(671, 184);
            LB1.TabIndex = 0;
            LB1.SelectedIndexChanged += LB1_SelectedIndexChanged;
            // 
            // TB1
            // 
            TB1.Location = new Point(71, 32);
            TB1.Name = "TB1";
            TB1.Size = new Size(100, 23);
            TB1.TabIndex = 1;
            TB1.TextChanged += textBox1_TextChanged_1;
            // 
            // TB2
            // 
            TB2.Location = new Point(71, 61);
            TB2.Name = "TB2";
            TB2.Size = new Size(100, 23);
            TB2.TabIndex = 2;
            TB2.TextChanged += TB2_TextChanged;
            // 
            // TB3
            // 
            TB3.Location = new Point(71, 90);
            TB3.Name = "TB3";
            TB3.Size = new Size(100, 23);
            TB3.TabIndex = 3;
            TB3.TextChanged += TB3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 35);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 5;
            label1.Text = "X =";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 64);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 6;
            label2.Text = "Y =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 93);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 7;
            label3.Text = "Z =";
            // 
            // button1
            // 
            button1.Location = new Point(71, 119);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 9;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TB3);
            Controls.Add(TB2);
            Controls.Add(TB1);
            Controls.Add(LB1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LB1;
        private TextBox TB1;
        private TextBox TB2;
        private TextBox TB3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}