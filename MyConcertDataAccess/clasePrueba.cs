using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyConcertDataAccess.MyConcertDBDataSetTableAdapters;

namespace MyConcertDataAccess
{
    public class clasePrueba
    {
        public int registra(string data) {
            bool? b = false;
            MyConcertDBDataSet.P_V_FanaticoDataTable ftabla = new MyConcertDBDataSet.P_V_FanaticoDataTable();
            MyConcertDBDataSetTableAdapters.P_V_FanaticoTableAdapter pvFanatico = new MyConcertDBDataSetTableAdapters.P_V_FanaticoTableAdapter();
            QueriesTableAdapter querry = new MyConcertDBDataSetTableAdapters.QueriesTableAdapter();

            var n = querry.P_RegistrarPais("Guatemala", ref b);
            System.Diagnostics.Debug.WriteLine(n);


            var w = pvFanatico.Fill(ftabla, 1);
            System.Diagnostics.Debug.WriteLine(w);

            var j = pvFanatico.GetData(1).ToList();

            foreach (MyConcertDBDataSet.P_V_FanaticoRow fn in j)
            {
                System.Diagnostics.Debug.WriteLine(fn.Correo);
                System.Diagnostics.Debug.WriteLine(fn.Contrasena);
            }
            return 1;
        }
    }
}
