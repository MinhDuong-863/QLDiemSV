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
    public partial class FThemLop : Form
    {
        LopDAO lopDAO = new LopDAO();
        GiangVienDAO gvDAO = new GiangVienDAO();
        MonHocDAO monDAO = new MonHocDAO();
        BuoiHocDAO bhDAO = new BuoiHocDAO();
        DataTable dt = new DataTable();
        public FThemLop()
        {
            InitializeComponent();
            DataColumn colMaPhong = new DataColumn("MaPhong", typeof(int)); dt.Columns.Add(colMaPhong); DataColumn colSL = new DataColumn("SL", typeof(int)); dt.Columns.Add(colSL); dt.Rows.Add(1, 50); dt.Rows.Add(2, 80); dt.Rows.Add(3, 50); dt.Rows.Add(4, 100);dt.Rows.Add(5, 50);dt.Rows.Add(6, 50);dt.Rows.Add(7, 80);dt.Rows.Add(8, 100);dt.Rows.Add(9, 50);dt.Rows.Add(10, 80);cmbPhongHoc.DataSource = dt;cmbPhongHoc.DisplayMember = "MaPhong";cmbPhongHoc.ValueMember = "SL";cmbPhongHoc.StartIndex = 0;
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            bool kqTen = kiemTraTen();
            if (kqTen == false)
            {
                DialogResult result = MessageBox.Show("Tên lớp học không hợp lệ!", "ANNOUNCEMENT");
            }
            else
            {
                bool kqPhong = kiemTraPhong();
                if (kqPhong == false)
                {
                    DialogResult result = MessageBox.Show("Phòng học không đủ sức chứa!", "ANNOUNCEMENT");
                }
                else
                {
                    bool kqBuoi = kiemTraBuoi();
                    if(kqBuoi == false)
                    {
                        DialogResult result = MessageBox.Show("Phòng học đã tồn lại lớp học khác!", "ANNOUNCEMENT");
                    }
                    else
                    {
                        bool kqGV = kiemTraGV();
                        if (kqBuoi == false)
                        {
                            DialogResult result = MessageBox.Show("Giảng viên đã có lịch dạy trước đó!", "ANNOUNCEMENT");
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Bạn có muốn thêm lớp không?", "ANNOUNCEMENT");
                            if (result == DialogResult.OK)
                            {
                                Lop lop = new Lop(txtTenLop.Text, cmbLoaiLop.SelectedItem.ToString(),Convert.ToInt32(cmbSL.SelectedItem.ToString()), Convert.ToInt32(cmbHK.SelectedItem.ToString()), Convert.ToInt32(cmbNamHoc.SelectedItem.ToString()), (int)cmbGV.SelectedValue, (int)cmbMH.SelectedValue);
                                lopDAO.Them(lop,Convert.ToInt32(cmbPhongHoc.Text), Convert.ToInt32(cmbThu.SelectedItem.ToString()), Convert.ToInt32(cmbCaHoc.SelectedItem.ToString()));
                            }
                            else
                            {
                                reset();
                                FThemLop_Load(sender, e);
                            }

                        }
                    }
                }
            }

        }

        private void reset()
        {
            txtTenLop.Clear();
            cmbLoaiLop.SelectedIndex = 0;
            cmbSL.SelectedIndex = 0;
            cmbHK.SelectedIndex = 0;
            cmbNamHoc.SelectedIndex = 0;
            cmbGV.SelectedIndex = 0;
            cmbMH.SelectedIndex = 0;
            cmbPhongHoc.SelectedIndex = 0;
            cmbThu.SelectedIndex = 0;
            cmbCaHoc.SelectedIndex = 0;
        }

        private bool kiemTraGV()
        {
          
            foreach (DataRow row in gvDAO.LayDanhSachLichDayGV((int)cmbGV.SelectedValue).Rows)
            {
                int maLop = Convert.ToInt32(row["MaLop"]);
                int thu = Convert.ToInt32(row["Thu"]);
                int ca = Convert.ToInt32(row["Ca"]);
                int maPhong = Convert.ToInt32(row["PhongHoc"]);
                if (Convert.ToInt32(cmbThu.SelectedItem.ToString()) == thu && Convert.ToInt32(cmbCaHoc.SelectedItem.ToString()) == ca)
                    return false;
            }
            return true;
        }

        private bool kiemTraBuoi()
        {
            DataTable ld = bhDAO.LayDanhSachBuoi();
            if(ld!= null)
            {
                //Console.WriteLine(int.Parse(cmbThu.SelectedItem.ToString()));
                foreach (DataRow row in ld.Rows)
                {
                    int maLop = Convert.ToInt32(row["MaLop"]);
                    int thu = Convert.ToInt32(row["Thu"]);
                    int ca = Convert.ToInt32(row["Ca"]);
                    int maPhong = Convert.ToInt32(row["PhongHoc"]);
                    if (int.Parse(cmbThu.SelectedItem.ToString()) == thu && int.Parse(cmbCaHoc.SelectedItem.ToString()) == ca && int.Parse(cmbPhongHoc.Text) == maPhong)

                        return false;
                }
            }
            return true;
        }

        private bool kiemTraPhong()
        {
            if (Convert.ToInt32(cmbSL.Text) > (int)cmbPhongHoc.SelectedValue)
            {
                return false;
            }
            return true;
        }

        private bool kiemTraTen()
        {
            bool kqTen1 = true, kqTen2 = true;
            foreach (char c in txtTenLop.Text)
            {
                kqTen1 = char.IsLetterOrDigit(c);
            }
            kqTen2 = !String.IsNullOrEmpty(txtTenLop.Text);

            return kqTen1 && kqTen2;
        }

        private void FThemLop_Load(object sender, EventArgs e)
        {
            gvDiemLop.DataSource = lopDAO.LayDanhSachLop();
            gvDiemLop.ScrollBars = ScrollBars.Both;
            lopDAO.LayDanhSachLop();
            cmbMH.DataSource = monDAO.LayDanhSachMon();
            cmbMH.ValueMember = "MaMon";
            cmbMH.DisplayMember = "TenMon";
            cmbMH.StartIndex = 0;
 
            cmbGV.DataSource =  gvDAO.LayDanhSachGV();
            cmbGV.ValueMember = "MaGV";
            cmbGV.DisplayMember = "HoTen";
            cmbMH.StartIndex = 0;

            reset();
        }

        private void cmbPhongHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
