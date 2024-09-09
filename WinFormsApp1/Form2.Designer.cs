namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_giai = new Button();
            btn_lam_moi = new Button();
            btn_thoat = new Button();
            he_so_a = new TextBox();
            he_so_b = new TextBox();
            he_so_c = new TextBox();
            thong_bao = new TextBox();
            nghiem_x1 = new TextBox();
            nghiem_x2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Hê số A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(30, 86);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Hê số B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(30, 134);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Hê số C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(30, 180);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "Thông báo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(30, 223);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 4;
            label5.Text = "Nghiệm X1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(30, 267);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 5;
            label6.Text = "Nghiệm X2";
            // 
            // btn_giai
            // 
            btn_giai.ForeColor = SystemColors.ActiveCaptionText;
            btn_giai.Location = new Point(30, 325);
            btn_giai.Name = "btn_giai";
            btn_giai.Size = new Size(94, 29);
            btn_giai.TabIndex = 6;
            btn_giai.Text = "Giải";
            btn_giai.UseVisualStyleBackColor = true;
            btn_giai.Click += btn_giai_Click;
            // 
            // btn_lam_moi
            // 
            btn_lam_moi.ForeColor = SystemColors.ActiveCaptionText;
            btn_lam_moi.Location = new Point(167, 325);
            btn_lam_moi.Name = "btn_lam_moi";
            btn_lam_moi.Size = new Size(94, 29);
            btn_lam_moi.TabIndex = 7;
            btn_lam_moi.Text = "Làm mới";
            btn_lam_moi.UseVisualStyleBackColor = true;
            btn_lam_moi.Click += btn_lam_moi_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.ForeColor = SystemColors.ActiveCaptionText;
            btn_thoat.Location = new Point(298, 325);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(94, 29);
            btn_thoat.TabIndex = 8;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // he_so_a
            // 
            he_so_a.Location = new Point(167, 35);
            he_so_a.Name = "he_so_a";
            he_so_a.Size = new Size(225, 27);
            he_so_a.TabIndex = 9;
            he_so_a.TextChanged += he_so_a_TextChanged;
            // 
            // he_so_b
            // 
            he_so_b.Location = new Point(167, 86);
            he_so_b.Name = "he_so_b";
            he_so_b.Size = new Size(225, 27);
            he_so_b.TabIndex = 10;
            // 
            // he_so_c
            // 
            he_so_c.Location = new Point(167, 134);
            he_so_c.Name = "he_so_c";
            he_so_c.Size = new Size(225, 27);
            he_so_c.TabIndex = 11;
            // 
            // thong_bao
            // 
            thong_bao.Enabled = false;
            thong_bao.ForeColor = Color.Red;
            thong_bao.Location = new Point(167, 180);
            thong_bao.Name = "thong_bao";
            thong_bao.Size = new Size(225, 27);
            thong_bao.TabIndex = 12;
            thong_bao.TextChanged += thong_bao_TextChanged;
            // 
            // nghiem_x1
            // 
            nghiem_x1.Enabled = false;
            nghiem_x1.ForeColor = SystemColors.InfoText;
            nghiem_x1.Location = new Point(167, 223);
            nghiem_x1.Name = "nghiem_x1";
            nghiem_x1.Size = new Size(225, 27);
            nghiem_x1.TabIndex = 13;
            // 
            // nghiem_x2
            // 
            nghiem_x2.Enabled = false;
            nghiem_x2.ForeColor = SystemColors.InfoText;
            nghiem_x2.Location = new Point(167, 267);
            nghiem_x2.Name = "nghiem_x2";
            nghiem_x2.Size = new Size(225, 27);
            nghiem_x2.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 380);
            Controls.Add(nghiem_x2);
            Controls.Add(nghiem_x1);
            Controls.Add(thong_bao);
            Controls.Add(he_so_c);
            Controls.Add(he_so_b);
            Controls.Add(he_so_a);
            Controls.Add(btn_thoat);
            Controls.Add(btn_lam_moi);
            Controls.Add(btn_giai);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            Name = "Form2";
            Text = "Giải phương trình bậc 2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_giai;
        private Button btn_lam_moi;
        private Button btn_thoat;
        private TextBox he_so_a;
        private TextBox he_so_b;
        private TextBox he_so_c;
        private TextBox thong_bao;
        private TextBox nghiem_x1;
        private TextBox nghiem_x2;
    }
}