using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegMayor
{

    class Class1
    {
        DataClasses1DataContext db;
        string connectionString = @"Server=.\sqlexpress;Database=SeguridadMayor;Trusted_Connection=True;";
        SqlConnection con;

        public bool analizarFeriado(DateTime fechaTurno)
        {
            List<DateTime> feriados;
            feriados = new List<DateTime>();
            string sql = "SELECT * FROM DIASFERIADOS";
            con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
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

            
            Boolean feriado = false;

            for (int i=0; i < feriados.Count; i++)
            {
                Console.WriteLine(fechaTurno.ToString());

                Console.WriteLine(feriados[i].ToString());
                if (fechaTurno.Date == feriados[i].Date)
                {
                    feriado = true;
                    Console.WriteLine("feriado detected" + fechaTurno.ToString("dd-MM"));
                }
            }
            return feriado;
        }


        public bool topeHorario(DateTime hora1, DateTime hora2)
        {
            Boolean tope=false;
            if((hora1.Hour-hora2.Hour)>0)
            {
                tope = true;
            }
            return tope;
        }
    }
}
