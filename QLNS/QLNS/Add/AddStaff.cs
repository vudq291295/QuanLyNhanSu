using ConsoleApplication1.Entity;
using Controller;
using QLNS.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.Add
{
    public partial class AddStaff : winform
    {
        private NhanVienController contr = new NhanVienController();
        public AddStaff()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);

            this.TitleCol = new List<string>() { { "Mã nhân viên" }, { "Tên nhân viên" }, { "Ngày Sinh" }, { "Giới Tính" }, { "Quê quán" } };
            DataGridView dt = this.CreateGrid<NhanVien>(contr.GetAll());
            this.TitleCol = new List<string>(){{"Mã nhân viên"}, {"Tên nhân viên"},{"Ngày Sinh"},{"Giới Tính"}, {"Quê quán"}};
            this.Controls.Add(dt);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 232, 250), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }
    }
}
