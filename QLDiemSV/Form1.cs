﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            UCQuanTriLop uc = new UCQuanTriLop();
            pnlNoiDung.Controls.Add(uc);
        }
    }
}
