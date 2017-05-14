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
    public partial class menuPagos : Form
    {
        String rol;
        public menuPagos(String parametro)
        {
            InitializeComponent();
            if (parametro != null)
            {
                rol = parametro;
                tb_rolPagos.Text = parametro;
                lb_nombreHE.Text = "Luciano Sandoval";
                lb_rutHE.Text = "18807705-6";
                lb_zonaHE.Text = "Concepcion";
            }
            
           
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nroTotalHoras.Visible = true;
            totHorasExtras.Visible = true;
            label4.Visible = true;
            label9.Visible = true;
        }
    }
}
