using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiemSV
{
    public partial class UCQuanTriLop : UserControl
    {
        LopDAO lopDAO = new LopDAO();
        public UCQuanTriLop()
        {
            InitializeComponent();
        }

        private void pbThem_Click(object sender, EventArgs e)
        {
            FThemLop form = new FThemLop();
            form.ShowDialog();
            UCQuanTriLop_Load(sender, e);
            ClearControl();
        }
        private void ClearControl()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtMonHoc.Clear();
            txtLoaiLop.Clear();
            txtSSV.Clear();
            txtHK.Clear();
            txtNamHoc.Clear();
            txtGiangVien.Clear();
        }

        private void UCQuanTriLop_Load(object sender, EventArgs e)
        {
            this.gvLop.DataSource = lopDAO.LayDanhSachLop();
            gvLop.ScrollBars = ScrollBars.Both;
        }

        private void gvLop_DoubleClick_1(object sender, EventArgs e)
        {
            txtMaLop.Text = gvLop.CurrentRow.Cells[0].Value.ToString();
            txtTenLop.Text = gvLop.CurrentRow.Cells[1].Value.ToString();
            txtMonHoc.Text = gvLop.CurrentRow.Cells[2].Value.ToString();
            txtLoaiLop.Text = gvLop.CurrentRow.Cells[3].Value.ToString();
            txtSSV.Text = gvLop.CurrentRow.Cells[4].Value.ToString();
            txtHK.Text = gvLop.CurrentRow.Cells[5].Value.ToString();
            txtNamHoc.Text = gvLop.CurrentRow.Cells[6].Value.ToString();
            txtGiangVien.Text = gvLop.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
