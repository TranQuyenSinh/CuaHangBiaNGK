namespace QL_BIA_NGK
{
    partial class frmChiTietTonKho
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboDonViTinh = new System.Windows.Forms.ComboBox();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuyDoi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(24, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn vị tính";
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.Location = new System.Drawing.Point(105, 54);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(245, 24);
            this.cboDonViTinh.TabIndex = 0;
            // 
            // txtTonKho
            // 
            this.txtTonKho.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTonKho.Location = new System.Drawing.Point(105, 120);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.Size = new System.Drawing.Size(245, 24);
            this.txtTonKho.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(40, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tồn kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(2, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "* Thêm: thêm vào tồn kho hiện tại, Sửa: thay đổi tồn kho ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Image = global::QL_BIA_NGK.Properties.Resources.plus;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(116, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.Red;
            this.btnDong.Image = global::QL_BIA_NGK.Properties.Resources.close;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(276, 158);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(74, 30);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Thoát";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Image = global::QL_BIA_NGK.Properties.Resources.circular;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(196, 158);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(74, 30);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Sửa";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(40, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Quy đổi";
            // 
            // txtQuyDoi
            // 
            this.txtQuyDoi.Enabled = false;
            this.txtQuyDoi.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtQuyDoi.Location = new System.Drawing.Point(105, 87);
            this.txtQuyDoi.Name = "txtQuyDoi";
            this.txtQuyDoi.Size = new System.Drawing.Size(245, 24);
            this.txtQuyDoi.TabIndex = 34;
            // 
            // txtTen
            // 
            this.txtTen.AutoSize = true;
            this.txtTen.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtTen.Location = new System.Drawing.Point(24, 18);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(103, 17);
            this.txtTen.TabIndex = 36;
            this.txtTen.Text = "Tên hàng hóa";
            // 
            // frmChiTietTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 252);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuyDoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTonKho);
            this.Controls.Add(this.cboDonViTinh);
            this.Controls.Add(this.label1);
            this.Name = "frmChiTietTonKho";
            this.Text = "Thay đổi tồn kho";
            this.Load += new System.EventHandler(this.frmChiTietTonKho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDonViTinh;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuyDoi;
        private System.Windows.Forms.Label txtTen;
    }
}