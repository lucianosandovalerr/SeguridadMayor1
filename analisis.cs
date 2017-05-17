using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegMayor
{

    class analisis
    {
        DataClasses1DataContext db;
        string connectionString = @"Server=.\sqlexpress;Database=SeguridadMayor;Trusted_Connection=True;";
        SqlConnection con;

        public bool analizarFeriado(DateTime fechaTurno)
        {
            Boolean diaFeriado= false;
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
            
            for (int i=0; i < feriados.Count; i++)
            {
                if (fechaTurno.Date == feriados[i].Date)
                {
                    diaFeriado = true;
                    Console.WriteLine("feriado detected class" + fechaTurno.ToString("dd-MM"));
                }
            }
            return diaFeriado;
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

        public String verificarTurno(int idTurno, bool descanso)
        {
            String resultadoTurno = "";
            //Console.WriteLine("Incoming: " + idTurno + " / " + descanso);
            switch (idTurno)
            {

                case 1:
                    if (descanso)
                    {
                        resultadoTurno = "4y1";
                    }
                    else
                    {
                        resultadoTurno = "1";
                    }
                    break;
                case 2:
                    if (descanso)
                    {
                        resultadoTurno = "4y2";
                    }
                    else
                    {
                        resultadoTurno = "2";
                    }
                    break;
                case 3:
                    if (descanso)
                    {
                        resultadoTurno = "4y3";
                    }
                    else
                    {
                        resultadoTurno = "3";
                    }
                    break;
                case 0:
                    if (descanso)
                    {
                        resultadoTurno = "4";
                    }
                    break;

            }
            //Console.WriteLine("Outcoming: " + resultadoTurno);
            return resultadoTurno;
        }

        public bool esDomingo(DateTime turno)
        {
            bool domingo;
            String diaSemana = (turno.ToString("dddd",
                              new CultureInfo("es-ES")));
            if (diaSemana=="domingo")
            {
                domingo =  true;
            } else
                {
                domingo =  false;
            }
            return domingo;
        }

        public TimeSpan duracionTurno (String a, String b, String c)
        {

            TimeSpan result;

            
            TimeSpan valor1 = TimeSpan.Parse(a);
            TimeSpan valor2 = TimeSpan.Parse(b);
            TimeSpan valor3 = TimeSpan.Parse(c);

            double v2 = (valor2 - valor1).TotalMinutes - valor3.TotalMinutes;
            result = TimeSpan.FromMinutes(v2);

            return result;
        }
    }
}
