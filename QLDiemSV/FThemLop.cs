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
        public FThemLop()
        {
            InitializeComponent();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            bool kqTen = kiemTraTen();
            if (kqTen == false)
            {
                MessageBox.Show("Tên lớp học không hợp lệ!", "Thông báo");
            }
            else
            {
                bool kqPhong = kiemTraPhong();
                if (kqPhong == false)
                {
                    MessageBox.Show("Phòng học không đủ sức chứa!", "Thông báo");
                }
                else
                {
                    bool kqBuoi = kiemTraBuoi();
                    if(kqBuoi == false)
                    {
                        MessageBox.Show("Phòng học đã tồn lại lớp học khác!", "Thông báo");
                    }
                    else
                    {
                        bool kqGV = kiemTraGV();
                        if (kqBuoi == false)
                        {
                            MessageBox.Show("Giảng viên đã có lịch dạy trước đó!", "Thông báo");
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Bạn có muốn thêm lớp không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                Lop lop = new Lop(txtTenLop.Text, cmbLoaiLop.ToString(),Convert.ToInt32(cmbSL.ToString()), Convert.ToInt32(cmbHK.ToString()), Convert.ToInt32(cmbNamHoc.ToString()), Convert.ToInt32(cmbGV.SelectedItem.ToString()), Convert.ToInt32(cmbMH.SelectedItem.ToString()));
                                lopDAO.Them(lop);
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
            cmbGV.SelectedIndex = -1;
            cmbMH.SelectedIndex = -1;
            cmbPhongHoc.SelectedIndex = 0;
            cmbThu.SelectedIndex = 0;
            cmbCaHoc.SelectedIndex = 0;
        }

        private bool kiemTraGV()
        {
            throw new NotImplementedException();
        }

        private bool kiemTraBuoi()
        {
        
                return false;
        }

        private bool kiemTraPhong()
        {
            if(Convert.ToInt32(cmbSL.Text) < Convert.ToInt32(cmbPhongHoc.SelectedItem.ToString()))
            {
                return true;
            }
            return false;
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
            reset();
            txtTenLop.Focus();
        }


    }
}
