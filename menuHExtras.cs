using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegMayor
{
    public partial class menuHExtras : Form
    {
        public menuHExtras()
        {
            InitializeComponent();
        }

        private void menuHExtras_Load(object sender, EventArgs e)
        {
            DateTime dateValue = DateTime.Now;
           
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            DateTime date1 = DateTime.Now;
            Calendar cal = dfi.Calendar;


            Console.WriteLine("{0:d}: Week {1} ({2})", date1,
                    cal.GetWeekOfYear(date1, dfi.CalendarWeekRule,
                                      dfi.FirstDayOfWeek),
                    cal.ToString().Substring(cal.ToString().LastIndexOf(".") + 1));
        
       
        }
        string connectionString = @"Server=.\sqlexpress;Database=SeguridadMayor;Trusted_Connection=True;";

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            
            lb_nombreHE.Text = "Luciano Sandoval";
            lb_rutHE.Text = "18807705-6";
            lb_zonaHE.Text = "Concepcion";
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            nroTotalHoras.Visible = true;
            totHorasExtras.Visible = true;
            /*int año = int.Parse(cb_añoInforme.SelectedItem.ToString());
            int mes = cb_mesInforme.SelectedIndex + 1;
            int dia = 1;
            DateTime Fecha = new DateTime(año, mes, dia);

            DayOfWeek firstDayOfWeek = CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
            DateTime startDate = Fecha;
            DateTime firstDay = startDate.Date;
            while (firstDayOfWeek != startDate.DayOfWeek)
            {
                startDate = startDate.AddDays(-1);
            }
            DateTime lastDay = startDate.AddDays(6);
            for (int j=0;j<5;j++)
            {
                
                
                Console.WriteLine(dia+" "+firstDay.ToString("dd/MM") + " - " + lastDay.ToString("dd/MM"));
                firstDay.Date.AddDays(7);
                lastDay = startDate.AddDays(6);


            }*/
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String rol=tb_rol.Text;
            menuPagos toPagos = new menuPagos(rol);
            toPagos.Show();
        }
    }
}
