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
    public partial class PruebaIngreso : Form
    {
        public PruebaIngreso()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formFeriados ingresar = new formFeriados();
            ingresar.Show();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            cbJustificacion.Enabled = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            cbJustificacion.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                cbJustificacion.Enabled = false;
            } else
            {
                if (!radioButton1.Checked)
                {
                    cbJustificacion.Enabled = true;
                }
            }
            verificarTurno();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificarTurno();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void codTurno_Click(object sender, EventArgs e)
        {

        }

        private void verificarTurno()
        {
            int seleccionado = comboBox1.SelectedIndex;

            switch (seleccionado)
            {

                case 1:
                    if (checkBox1.Checked)
                    {
                        codTurno.Text = "4y1";
                    }
                    else
                    {
                        codTurno.Text = "1";
                    }
                    break;
                case 2:
                    if (checkBox1.Checked)
                    {
                        codTurno.Text = "4y2";
                    }
                    else
                    {
                        codTurno.Text = "2";
                    }
                    break;
                case 3:
                    if (checkBox1.Checked)
                    {
                        codTurno.Text = "4y3";
                    }
                    else
                    {
                        codTurno.Text = "3";
                    }
                    break;
                case 0:
                    if (checkBox1.Checked)
                    {
                        codTurno.Text = "4";
                    }
                    break;

            }
        }
    }
}
