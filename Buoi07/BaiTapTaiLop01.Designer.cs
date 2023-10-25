namespace Buoi07
{
    partial class BaiTapTaiLop01
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
            this.btnThemSo = new System.Windows.Forms.Button();
            this.cboNhapso = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhapso = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnListchan = new System.Windows.Forms.Button();
            this.btnListNT = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemSo
            // 
            this.btnThemSo.Location = new System.Drawing.Point(234, 33);
            this.btnThemSo.Name = "btnThemSo";
            this.btnThemSo.Size = new System.Drawing.Size(78, 23);
            this.btnThemSo.TabIndex = 1;
            this.btnThemSo.Text = "Thêm";
            this.btnThemSo.UseVisualStyleBackColor = true;
            this.btnThemSo.Click += new System.EventHandler(this.btnThemSo_Click);
            // 
            // cboNhapso
            // 
            this.cboNhapso.FormattingEnabled = true;
            this.cboNhapso.Location = new System.Drawing.Point(15, 73);
            this.cboNhapso.Name = "cboNhapso";
            this.cboNhapso.Size = new System.Drawing.Size(297, 24);
            this.cboNhapso.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhapso);
            this.groupBox1.Controls.Add(this.btnThemSo);
            this.groupBox1.Controls.Add(this.cboNhapso);
            this.groupBox1.Location = new System.Drawing.Point(23, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // txtNhapso
            // 
            this.txtNhapso.Location = new System.Drawing.Point(15, 33);
            this.txtNhapso.Name = "txtNhapso";
            this.txtNhapso.Size = new System.Drawing.Size(203, 22);
            this.txtNhapso.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(403, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 245);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(18, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(287, 132);
            this.listBox1.TabIndex = 4;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(403, 313);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(329, 43);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "Tổng các ước số";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnListchan
            // 
            this.btnListchan.Location = new System.Drawing.Point(403, 362);
            this.btnListchan.Name = "btnListchan";
            this.btnListchan.Size = new System.Drawing.Size(329, 43);
            this.btnListchan.TabIndex = 1;
            this.btnListchan.Text = "Số Lượng các ước số chẳn";
            this.btnListchan.UseVisualStyleBackColor = true;
            this.btnListchan.Click += new System.EventHandler(this.btnListchan_Click);
            // 
            // btnListNT
            // 
            this.btnListNT.Location = new System.Drawing.Point(403, 411);
            this.btnListNT.Name = "btnListNT";
            this.btnListNT.Size = new System.Drawing.Size(329, 43);
            this.btnListNT.TabIndex = 1;
            this.btnListNT.Text = "Số lượng các ước số nguyên tố";
            this.btnListNT.UseVisualStyleBackColor = true;
            this.btnListNT.Click += new System.EventHandler(this.btnListNT_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(68, 411);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(329, 43);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // BaiTapTaiLop01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnListNT);
            this.Controls.Add(this.btnListchan);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.groupBox1);
            this.Name = "BaiTapTaiLop01";
            this.Text = "BaiTapTaiLop01";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemSo;
        private System.Windows.Forms.ComboBox cboNhapso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhapso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnListchan;
        private System.Windows.Forms.Button btnListNT;
        private System.Windows.Forms.Button btnThoat;
    }
}