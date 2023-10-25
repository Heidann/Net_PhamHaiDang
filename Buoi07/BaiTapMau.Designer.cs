namespace Buoi07
{
    partial class BaiTapMau
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_addall = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_removeall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 356);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(482, 49);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(254, 356);
            this.listBox2.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(316, 145);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(117, 41);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = ">";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_addall
            // 
            this.btn_addall.Location = new System.Drawing.Point(316, 192);
            this.btn_addall.Name = "btn_addall";
            this.btn_addall.Size = new System.Drawing.Size(117, 41);
            this.btn_addall.TabIndex = 1;
            this.btn_addall.Text = ">>";
            this.btn_addall.UseVisualStyleBackColor = true;
            this.btn_addall.Click += new System.EventHandler(this.btn_addall_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(316, 239);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(117, 41);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "<";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_removeall
            // 
            this.btn_removeall.Location = new System.Drawing.Point(316, 286);
            this.btn_removeall.Name = "btn_removeall";
            this.btn_removeall.Size = new System.Drawing.Size(117, 41);
            this.btn_removeall.TabIndex = 1;
            this.btn_removeall.Text = "<<";
            this.btn_removeall.UseVisualStyleBackColor = true;
            this.btn_removeall.Click += new System.EventHandler(this.btn_removeall_Click);
            // 
            // BaiTapMau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 510);
            this.Controls.Add(this.btn_removeall);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_addall);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "BaiTapMau";
            this.Text = "BaiTapMau";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_addall;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_removeall;
    }
}