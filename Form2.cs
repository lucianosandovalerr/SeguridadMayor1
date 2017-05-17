using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegMayor
{
    public partial class menuAsistencia : Form
    {
        public menuAsistencia()
        {
            InitializeComponent();
        }
        string connectionString = @"Server=.\sqlexpress;Database=SeguridadMayor;Trusted_Connection=True;";

        private void seguridadMayorDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void menuAsistencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'seguridadMayorDataSet.Asistencia' Puede moverla o quitarla según sea necesario.
            this.asistenciaTableAdapter.Fill(this.seguridadMayorDataSet.Asistencia);


        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM TRABAJADOR WHERE ROL=" + tb_rol.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            {

                if (string.IsNullOrEmpty(tb_rol.Text))
                {

                    MessageBox.Show("Debe completar la informacion");

                    return;

                }

                try
                {
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        //lb_nombre.Text = "hola".ToString();
                        lb_nombre.Text = (reader[2].ToString() + " " + reader[3].ToString());
                        lb_nombre.Visible = true;
                        lb_zona.Text = reader[4].ToString();
                        lb_zona.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error en el rol ingresado !");
                        tb_rol.Text = "";
                        lb_nombre.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
                finally
                {
                    // Cierro la Conexión.
                    con.Close();
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
           /*
            SOBRA? TimeSpan horaEntrada, horaSalida, horaColacion;
            int horasColacion, rol;

            String horadeEntrada = mtb_hentrada.Text;
            String horadeSalida = mtb_hsalida.Text;
            String horadeColacion = mtb_colacion.Text;
            */
           /* horaEntrada = DateTime.Parse(horadeEntrada, System.Globalization.CultureInfo.CurrentCulture);

            horaSalida = DateTime.Parse(horadeSalida, System.Globalization.CultureInfo.CurrentCulture);

            horaColacion = DateTime.Parse(horadeColacion, System.Globalization.CultureInfo.CurrentCulture);
            */


            //TimeSpan diferencia = horaEntrada - horaSalida;
            int vt2;
            double v2;

            String HEntrada = (mtb_hentrada.Text.ToString());
            String HSalida = (mtb_hsalida.Text.ToString());
            String HComida = (mtb_colacion.Text.ToString()); 
            
           String THorasE = HEntrada.Substring(0, 2) + ":" + HEntrada.Substring(3, 2);
            String THoraS = HSalida.Substring(0, 2) + ":" + HSalida.Substring(3, 2);
            String THorasC = HComida.Substring(0, 2) + ":" + HComida.Substring(3, 2);
           TimeSpan valor1 = TimeSpan.Parse(THorasE); //08:00
            TimeSpan valor2 = TimeSpan.Parse(THoraS); //10:00
            TimeSpan valor3 = TimeSpan.Parse(THorasC); //00:30


            v2 = (valor2 - valor1).TotalMinutes - valor3.TotalMinutes;
            vt2 = (valor2 - valor1).Hours;
            TimeSpan result = TimeSpan.FromMinutes(v2);
            TimeSpan result1 = TimeSpan.FromHours(vt2);

            MessageBox.Show(result.ToString());


            // horasColacion = int.Parse(mtb_colacion.Text);
            //rol = int.Parse(tb_rol.Text);

            //  string sql = "insert into Asistencia (rol, fecha, horaEntrada, HorasColacion, HoraSalida, Turno) values ("+rol+", "+fecha+", "+HoraEntrada+", "+HorasColacion+", "+HoraSalida+", "+Turno+")";
            /*
              SqlConnection con = new SqlConnection(connectionString);
              SqlCommand cmd = new SqlCommand(sql, con);
              cmd.CommandType = CommandType.Text;
              con.Open();
              try
              {
                  int i = cmd.ExecuteNonQuery();
                  if (i > 0)
                          MessageBox.Show("Registro ingresado correctamente !");
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error: " + ex.ToString());
              }
              finally
              {
                  // Cierro la Conexión.
                  con.Close();
              }



      */

        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            lb_nombre.Visible = false;
            lb_zona.Visible = false;
            tb_rol.Text = "";
        }

        private void rb_no_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_no.Checked)
            {
                cb_just.Enabled = true;
                mtb_colacion.Enabled = false;
                mtb_hentrada.Enabled = false;
                mtb_hsalida.Enabled = false;
                cb_tipoturno.Enabled = false;
            }
            else
            {
                cb_just.Enabled = false;
                mtb_colacion.Enabled = true;
                mtb_hentrada.Enabled = true;
                mtb_hsalida.Enabled = true;
                cb_tipoturno.Enabled = true;
            }
        }
    }
    }
   
        

        