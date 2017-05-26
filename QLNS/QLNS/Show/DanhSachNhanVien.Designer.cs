namespace QLNS.Them
{
    partial class DanhSachNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgrDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDanhSachNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgrDanhSachNhanVien);
            this.panel1.Location = new System.Drawing.Point(8, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 357);
            this.panel1.TabIndex = 0;
            // 
            // dtgrDanhSachNhanVien
            // 
            this.dtgrDanhSachNhanVien.AllowUserToAddRows = false;
            this.dtgrDanhSachNhanVien.AllowUserToDeleteRows = false;
            this.dtgrDanhSachNhanVien.AllowUserToResizeRows = false;
            this.dtgrDanhSachNhanVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgrDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrDanhSachNhanVien.GridColor = System.Drawing.SystemColors.Control;
            this.dtgrDanhSachNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dtgrDanhSachNhanVien.Name = "dtgrDanhSachNhanVien";
            this.dtgrDanhSachNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrDanhSachNhanVien.Size = new System.Drawing.Size(724, 357);
            this.dtgrDanhSachNhanVien.TabIndex = 0;
            // 
            // DanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "DanhSachNhanVien";
            this.Size = new System.Drawing.Size(744, 438);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDanhSachNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgrDanhSachNhanVien;
    }
}
