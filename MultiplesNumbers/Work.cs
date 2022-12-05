using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesNumbers
{
    public class Work
    {
        public void SearchMultiples(int number)
        {
            int summ = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    summ += i;
                }
            }
            Console.WriteLine($"Сумма чисел кратных 3 или 5: {summ}");
        }

    }
}
