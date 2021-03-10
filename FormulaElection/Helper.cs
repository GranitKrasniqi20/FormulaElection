using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaElection
{
    class Helper
    {

        public static double maxElement(List<double> lista)
        {
            double max = 0;
            double s = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if ((lista[i] - (int)lista[i]) > max)
                {
                    max = lista[i] - (int)lista[i];
                    s = lista[i];
                }
            }
            return s;
        }
    }
}
