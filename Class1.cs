using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegMayor
{

    class Class1
    {

        public bool analizarFeriado(DateTime fechaTurno)
        {
         
            DateTime[] diasFeriados = new DateTime[] {
                //idealmente obtener días feriados por mes desde bbdd
                new DateTime(2017, 03, 02),
                new DateTime(2010, 03, 14),
            };
            Boolean feriado = false;

            for (int i=0; i < diasFeriados.Length; i++)
            {
                if (fechaTurno.Day == diasFeriados[i].Day)
                {
                    feriado = true;
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
