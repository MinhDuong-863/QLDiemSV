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
    }
}
