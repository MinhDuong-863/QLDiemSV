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
    public partial class MessageBox : Form
    {
        public MessageBox(string noiDung, string tieuDe)
        {
            InitializeComponent();
            lblTitle.Text = tieuDe;
            lblNd.Text = noiDung;
            if (tieuDe == "ANNOUNCEMENT")
                pbIcon.Image = Properties.Resources.information;
            else if (tieuDe == "CONFIRM")
                pbIcon.Image = Properties.Resources.information;
            else
                pbIcon.Image = Properties.Resources.warning;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }
        public static DialogResult Show(string noiDung, string tieuDe)
        {
            using (MessageBox msgBox = new MessageBox(noiDung, tieuDe))
            {
                return msgBox.ShowDialog();
            }
        }
    }
}
