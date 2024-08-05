using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_RestricaoGenerics.Services
{
    internal class CalculationService
    {

                                     //Restrição da Class generica.    
        public T Max<T>(List<T> list) where T: IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list cn not empty");
            }
            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max)>0)
                {
                    max = list[i];
                    
                }

            }
            return max;
        }
    }
}
