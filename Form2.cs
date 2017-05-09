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

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //lb_nombre.Text = "hola".ToString();
                    lb_nombre.Text = (reader[2].ToString() + "-" + reader[3].ToString());
                    lb_nombre.Visible = true;
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            DateTime horaEntrada, horaSalida;
            int horasColacion, rol;
            String horadeEntrada=mtb_hentrada.Text;
            String horadeSalida = mtb_hsalida.Text;
            horaEntrada = DateTime.Parse(horadeEntrada, System.Globalization.CultureInfo.CurrentCulture);

            horaSalida = DateTime.Parse(horadeSalida, System.Globalization.CultureInfo.CurrentCulture);

            TimeSpan diferencia = horaSalida - horaEntrada;

            MessageBox.Show(diferencia.ToString());


           // horasColacion = int.Parse(mtb_colacion.Text);
            rol = int.Parse(tb_rol.Text);
            
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
    }
}
