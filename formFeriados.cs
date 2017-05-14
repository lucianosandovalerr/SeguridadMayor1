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
        datosEnRam datos = new datosEnRam();

        public formFeriados()
        {
            InitializeComponent();
            for (int i = 0; i < datos.dias.Count; i++)
            {
                listaFeriados.Items.Add(datos.dias[i].ToString("dd-MM-yyyy"));
            }
        }

        private void AgregarFeriado_Click(object sender, EventArgs e)
        {
            String fecha = pickerFeriado.Value.ToString("dd-MM-yyyy");
            listaFeriados.Items.Add(fecha);           

        }

        private void bt_guardarFeriados_Click(object sender, EventArgs e)
        {
            int c = listaFeriados.Items.Count;
            datos.dias.Clear();
            for (int i = 0; i < c; i++)
            {
                datos.dias.Add(Convert.ToDateTime(listaFeriados.SelectedItems[i]));
     }
        }
    }
}
