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
    public partial class formFeriados : Form
    {
        public formFeriados()
        {
            InitializeComponent();
        }

        private void AgregarFeriado_Click(object sender, EventArgs e)
        {
            String fecha = pickerFeriado.Value.ToString("dd-MM-yyyy");
            listaFeriados.Items.Add(fecha);

        }
    }
}
