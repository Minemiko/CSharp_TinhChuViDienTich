namespace CSharp_TinhChuViDienTich
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
            label1 = new Label();
            txtCD = new TextBox();
            label2 = new Label();
            txtCR = new TextBox();
            label3 = new Label();
            txtKQ = new TextBox();
            btnTinh = new Button();
            btnCV = new Button();
            btnDT = new Button();
            btnThoat = new Button();
            btnR = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 33);
            label1.TabIndex = 0;
            label1.Text = "Chiều dài";
            // 
            // txtCD
            // 
            txtCD.Location = new Point(194, 6);
            txtCD.Name = "txtCD";
            txtCD.Size = new Size(195, 40);
            txtCD.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(144, 33);
            label2.TabIndex = 0;
            label2.Text = "Chiều rộng";
            // 
            // txtCR
            // 
            txtCR.Location = new Point(194, 52);
            txtCR.Name = "txtCR";
            txtCR.Size = new Size(195, 40);
            txtCR.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(106, 33);
            label3.TabIndex = 0;
            label3.Text = "Kết quả";
            // 
            // txtKQ
            // 
            txtKQ.BackColor = SystemColors.Window;
            txtKQ.Location = new Point(194, 98);
            txtKQ.Multiline = true;
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(257, 70);
            txtKQ.TabIndex = 3;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(20, 205);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(114, 41);
            btnTinh.TabIndex = 4;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnCV
            // 
            btnCV.Location = new Point(20, 252);
            btnCV.Name = "btnCV";
            btnCV.Size = new Size(135, 41);
            btnCV.TabIndex = 5;
            btnCV.Text = "Chu vi";
            btnCV.UseVisualStyleBackColor = true;
            btnCV.Click += btnCV_Click;
            // 
            // btnDT
            // 
            btnDT.Location = new Point(161, 252);
            btnDT.Name = "btnDT";
            btnDT.Size = new Size(135, 41);
            btnDT.TabIndex = 6;
            btnDT.Text = "Diện tích";
            btnDT.UseVisualStyleBackColor = true;
            btnDT.Click += btnDT_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(337, 252);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 41);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnR
            // 
            btnR.Location = new Point(337, 205);
            btnR.Name = "btnR";
            btnR.Size = new Size(114, 41);
            btnR.TabIndex = 8;
            btnR.Text = "Reset";
            btnR.UseVisualStyleBackColor = true;
            btnR.Click += btnR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 457);
            Controls.Add(btnR);
            Controls.Add(btnThoat);
            Controls.Add(btnDT);
            Controls.Add(btnCV);
            Controls.Add(btnTinh);
            Controls.Add(txtKQ);
            Controls.Add(txtCR);
            Controls.Add(txtCD);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính Chu Vi Diện Tích";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCD;
        private Label label2;
        private TextBox txtCR;
        private Label label3;
        private TextBox txtKQ;
        private Button btnTinh;
        private Button btnCV;
        private Button btnDT;
        private Button btnThoat;
        private Button btnR;
    }
}
