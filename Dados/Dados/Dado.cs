using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Dado
    {
        Random rn = new Random();
       
        public int Lanzar()
        {
            int tiro = rn.Next(1, 7);
            return tiro;
        }
    }
}
