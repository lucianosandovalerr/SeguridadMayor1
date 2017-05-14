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
    public partial class formFeriados : Form
    {
        
        DataClasses1DataContext db;
        string connectionString = @"Server=.\sqlexpress;Database=SeguridadMayor;Trusted_Connection=True;";
        List<DateTime> feriados;
        List<DateTime> feriadosInsertar = new List<DateTime> ();
        SqlConnection con;

        public formFeriados()
        {
            InitializeComponent();
            db = new DataClasses1DataContext();
            feriados = new List<DateTime>();
                //= (from p in db.diasFeriados
            //select p).ToList();
            string sql = "SELECT * FROM DIASFERIADOS";

            con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            
                try {
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            feriados.Add(Convert.ToDateTime(reader[0].ToString()));
                        }
                    }
                    else
                        MessageBox.Show("Error al obtener datos");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            
            for (int i = 0; i < feriados.Count; i++)
            {
                listaFeriados.Items.Add(feriados[i].ToString("dd-MM-yyyy"));
            }
        }

        private void AgregarFeriado_Click(object sender, EventArgs e)
        {
            String fecha = pickerFeriado.Value.ToString("dd-MM-yyyy");
            listaFeriados.Items.Add(fecha);
            feriadosInsertar.Add(Convert.ToDateTime(fecha));           

        }
        private void insertarFeriado(DateTime d)
        {
            SqlConnection con2 = new SqlConnection(connectionString);
            SqlCommand cmd2 = new SqlCommand("INSERT INTO DIASFERIADOS VALUES (@value)", con2);

            cmd2.CommandType = CommandType.Text;
            con2.Open();
            cmd2.Parameters.AddWithValue("@value", d);

            try { cmd2.ExecuteNonQuery(); }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally { con2.Close(); }

        
    }
        private void bt_guardarFeriados_Click(object sender, EventArgs e)
        {
            int c = feriadosInsertar.Count;
            feriadosInsertar.ForEach(delegate (DateTime d)
            {
                insertarFeriado(d);
            });
            MessageBox.Show("Datos Ingresados");
            this.Close();
        }
    }
}
