using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegMayor
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();

        }

        private void bt_asis_Click(object sender, EventArgs e)
        {
            menuAsistencia frm = new menuAsistencia();
            frm.Show();
        }

        private void bt_he_Click(object sender, EventArgs e)
        {
            menuHExtras frm = new menuHExtras();
            frm.Show();
        }

        private void bt_pagos_Click(object sender, EventArgs e)
        {
            menuPagos frm = new menuPagos();
            frm.Show();
        }

        
    }
}
