namespace SimpleCalculator
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
            screenCALC = new TextBox();
            groupBox1 = new GroupBox();
            dot = new Button();
            button11 = new Button();
            num0 = new Button();
            num9 = new Button();
            num8 = new Button();
            nm7 = new Button();
            num6 = new Button();
            num5 = new Button();
            num4 = new Button();
            num3 = new Button();
            num2 = new Button();
            num1 = new Button();
            groupBox2 = new GroupBox();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // screenCALC
            // 
            screenCALC.Location = new Point(8, 12);
            screenCALC.Name = "screenCALC";
            screenCALC.Size = new Size(497, 27);
            screenCALC.TabIndex = 0;
            screenCALC.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dot);
            groupBox1.Controls.Add(button11);
            groupBox1.Controls.Add(num0);
            groupBox1.Controls.Add(num9);
            groupBox1.Controls.Add(num8);
            groupBox1.Controls.Add(nm7);
            groupBox1.Controls.Add(num6);
            groupBox1.Controls.Add(num5);
            groupBox1.Controls.Add(num4);
            groupBox1.Controls.Add(num3);
            groupBox1.Controls.Add(num2);
            groupBox1.Controls.Add(num1);
            groupBox1.Location = new Point(13, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 268);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Numerical";
            // 
            // dot
            // 
            dot.Location = new Point(224, 214);
            dot.Name = "dot";
            dot.Size = new Size(85, 29);
            dot.TabIndex = 11;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += dot_Click;
            // 
            // button11
            // 
            button11.Location = new Point(118, 214);
            button11.Name = "button11";
            button11.Size = new Size(85, 29);
            button11.TabIndex = 10;
            button11.Text = "+/-";
            button11.UseVisualStyleBackColor = true;
            // 
            // num0
            // 
            num0.Location = new Point(13, 214);
            num0.Name = "num0";
            num0.Size = new Size(85, 29);
            num0.TabIndex = 9;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += num0_Click;
            // 
            // num9
            // 
            num9.Location = new Point(224, 155);
            num9.Name = "num9";
            num9.Size = new Size(85, 29);
            num9.TabIndex = 8;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += num9_Click;
            // 
            // num8
            // 
            num8.Location = new Point(118, 155);
            num8.Name = "num8";
            num8.Size = new Size(85, 29);
            num8.TabIndex = 7;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += num8_Click;
            // 
            // nm7
            // 
            nm7.Location = new Point(13, 155);
            nm7.Name = "nm7";
            nm7.Size = new Size(85, 29);
            nm7.TabIndex = 6;
            nm7.Text = "7";
            nm7.UseVisualStyleBackColor = true;
            nm7.Click += nm7_Click;
            // 
            // num6
            // 
            num6.Location = new Point(224, 95);
            num6.Name = "num6";
            num6.Size = new Size(85, 29);
            num6.TabIndex = 5;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += num6_Click;
            // 
            // num5
            // 
            num5.Location = new Point(118, 95);
            num5.Name = "num5";
            num5.Size = new Size(85, 29);
            num5.TabIndex = 4;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += num5_Click;
            // 
            // num4
            // 
            num4.Location = new Point(13, 95);
            num4.Name = "num4";
            num4.Size = new Size(85, 29);
            num4.TabIndex = 3;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += num4_Click;
            // 
            // num3
            // 
            num3.Location = new Point(224, 36);
            num3.Name = "num3";
            num3.Size = new Size(85, 29);
            num3.TabIndex = 2;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += num3_Click;
            // 
            // num2
            // 
            num2.Location = new Point(118, 36);
            num2.Name = "num2";
            num2.Size = new Size(85, 29);
            num2.TabIndex = 1;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += num2_Click;
            // 
            // num1
            // 
            num1.Location = new Point(13, 36);
            num1.Name = "num1";
            num1.Size = new Size(85, 29);
            num1.TabIndex = 0;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += num1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button18);
            groupBox2.Controls.Add(button17);
            groupBox2.Controls.Add(button16);
            groupBox2.Controls.Add(button15);
            groupBox2.Controls.Add(button14);
            groupBox2.Controls.Add(button13);
            groupBox2.Location = new Point(352, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(153, 305);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operator";
            // 
            // button18
            // 
            button18.Location = new Point(15, 244);
            button18.Name = "button18";
            button18.Size = new Size(123, 36);
            button18.TabIndex = 5;
            button18.Text = "C";
            button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(15, 202);
            button17.Name = "button17";
            button17.Size = new Size(123, 36);
            button17.TabIndex = 4;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button16
            // 
            button16.Location = new Point(15, 160);
            button16.Name = "button16";
            button16.Size = new Size(123, 36);
            button16.TabIndex = 3;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.Location = new Point(15, 118);
            button15.Name = "button15";
            button15.Size = new Size(123, 36);
            button15.TabIndex = 2;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button14
            // 
            button14.Location = new Point(15, 76);
            button14.Name = "button14";
            button14.Size = new Size(123, 36);
            button14.TabIndex = 1;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.Location = new Point(15, 34);
            button13.Name = "button13";
            button13.Size = new Size(123, 36);
            button13.TabIndex = 0;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 369);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(screenCALC);
            Name = "Form1";
            Text = "Simple Calculator";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox screenCALC;
        private GroupBox groupBox1;
        private Button dot;
        private Button button11;
        private Button num0;
        private Button num9;
        private Button num8;
        private Button nm7;
        private Button num6;
        private Button num5;
        private Button num4;
        private Button num3;
        private Button num2;
        private Button num1;
        private GroupBox groupBox2;
        private Button button13;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
    }
}
