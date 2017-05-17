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

        analisis excepcion = new analisis();

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
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            analisisDatos();
        }
        

        private void analisisDatos()
        {
            Boolean descanso = false, feriado = false, domingo = false;
            //analizar tipo de Turno y devuelve codigo, ej 4y1
            String codigoTurno = excepcion.verificarTurno(comboBox1.SelectedIndex, checkBox1.Checked);
            descanso = checkBox1.Checked; //T o F

            //analizar si dia de turno es feriado
            feriado = excepcion.analizarFeriado(dt_fechaTurno.Value);

            //analizar si dia de turno es domingo
            domingo = excepcion.esDomingo(dt_fechaTurno.Value); //T o F

            //contador de excepciones encontradas
            int count = 0;
            if (descanso) count++;
            if (feriado) count++;
            if (domingo) count++;

            //obtener horas del turno
            String THorasE = mskEntrada.Text.Substring(0, 2) + ":" + mskEntrada.Text.Substring(3, 2);
            String THoraS = mskSalida.Text.Substring(0, 2) + ":" + mskSalida.Text.Substring(3, 2);
            String THorasC = mskTiempo.Text.Substring(0, 2) + ":" + mskTiempo.Text.Substring(3, 2);            
            TimeSpan result = excepcion.duracionTurno(THorasE, THoraS, THorasC);

            //obtener diferencias con horas que corresponden al turno
            //si es descanso o feriado no hay diferencia, son todas HE
            TimeSpan horasExtras = TimeSpan.Parse("00:00"), horasTurno = TimeSpan.Parse("00:00");
            if (!descanso)
            {
                if (!feriado)
                {
                    if (cb_horasTurno.SelectedItem.ToString() == "8")
                    {
                        horasTurno = TimeSpan.Parse("08:00");
                    }
                    horasExtras = result - horasTurno;
                }
                else
                {
                    horasExtras = result ;
                }
            }
            else
            {
                horasExtras = result;
            }

            //representar datos
            lbHorasExtras.Text = ("Horas Extras del Turno: "+horasExtras.ToString());
            lbCantRestricciones.Text = ("Cantidad de Restricciones: " + count);
            lbCodTurno.Text = ("Código del Turno: "+codigoTurno);

            String detalle = "Detalle de las Restricciones: \n";
            if (descanso) detalle = detalle + "Día de Descanso \n";
            if (feriado) detalle = detalle + "Día Feriado \n";
            if (domingo) detalle = detalle + "Día Festivo \n";

            lb_detallesRestricciones.Text = (detalle);

        }
            


    }
}
