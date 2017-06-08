using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyConcertDataAccess;
namespace NEGOCIOS
{
    public class N_Pais
    {
        public clasePrueba _clasePrueba = new clasePrueba();
        public int registrar(string data) {
            var result = _clasePrueba.registra(data);
            return result;
        }
        public int getPaisAll()
        {
            return 1;
        }
    }
}
