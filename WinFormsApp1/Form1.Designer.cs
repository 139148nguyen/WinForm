namespace WinFormsApp1
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
            txt1 = new Label();
            txt2 = new Label();
            tbox1 = new TextBox();
            tbox2 = new TextBox();
            txt3 = new Label();
            tbox3 = new TextBox();
            btn_sum = new Button();
            btn_refesh = new Button();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.Font = new Font("Segoe UI", 12F);
            txt1.Location = new Point(21, 29);
            txt1.Name = "txt1";
            txt1.Size = new Size(114, 28);
            txt1.TabIndex = 0;
            txt1.Text = "Số thứ nhất";
            txt1.Click += label1_Click;
            // 
            // txt2
            // 
            txt2.AutoSize = true;
            txt2.Font = new Font("Segoe UI", 12F);
            txt2.Location = new Point(21, 65);
            txt2.Name = "txt2";
            txt2.Size = new Size(101, 28);
            txt2.TabIndex = 1;
            txt2.Text = "Số thứ hai";
            txt2.Click += label2_Click;
            // 
            // tbox1
            // 
            tbox1.Location = new Point(165, 26);
            tbox1.Name = "tbox1";
            tbox1.Size = new Size(125, 27);
            tbox1.TabIndex = 2;
            // 
            // tbox2
            // 
            tbox2.Location = new Point(165, 65);
            tbox2.Name = "tbox2";
            tbox2.Size = new Size(125, 27);
            tbox2.TabIndex = 3;
            // 
            // txt3
            // 
            txt3.AutoSize = true;
            txt3.Font = new Font("Segoe UI", 12F);
            txt3.Location = new Point(21, 108);
            txt3.Name = "txt3";
            txt3.Size = new Size(98, 28);
            txt3.TabIndex = 4;
            txt3.Text = "Tổng 2 số";
            txt3.Click += label3_Click;
            // 
            // tbox3
            // 
            tbox3.Location = new Point(165, 108);
            tbox3.Name = "tbox3";
            tbox3.Size = new Size(125, 27);
            tbox3.TabIndex = 5;
            tbox3.TextChanged += textBox3_TextChanged;
            // 
            // btn_sum
            // 
            btn_sum.Location = new Point(21, 208);
            btn_sum.Name = "btn_sum";
            btn_sum.Size = new Size(94, 29);
            btn_sum.TabIndex = 6;
            btn_sum.Text = "Tính tổng";
            btn_sum.UseVisualStyleBackColor = true;
            btn_sum.Click += btn_sum_Click;
            // 
            // btn_refesh
            // 
            btn_refesh.Location = new Point(165, 208);
            btn_refesh.Name = "btn_refesh";
            btn_refesh.Size = new Size(94, 29);
            btn_refesh.TabIndex = 7;
            btn_refesh.Text = "Làm mới";
            btn_refesh.UseVisualStyleBackColor = true;
            btn_refesh.Click += button2_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(334, 208);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 29);
            btn_cancel.TabIndex = 8;
            btn_cancel.Text = "Thoát";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 273);
            Controls.Add(btn_cancel);
            Controls.Add(btn_refesh);
            Controls.Add(btn_sum);
            Controls.Add(tbox3);
            Controls.Add(txt3);
            Controls.Add(tbox2);
            Controls.Add(tbox1);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Name = "Form1";
            Text = "Chương trình đầu tiên";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt1;
        private Label txt2;
        private TextBox tbox1;
        private TextBox tbox2;
        private Label txt3;
        private TextBox tbox3;
        private Button btn_sum;
        private Button btn_refesh;
        private Button btn_cancel;
    }
}
