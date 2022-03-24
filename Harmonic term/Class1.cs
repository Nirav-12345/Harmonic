using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonic_term
{
    public class Class1
    {
        public void Harmonic()
        {
            Console.WriteLine("Enter The Number");
            int n = Convert.ToInt32(Console.ReadLine());

            double harmonic = 1;

            for (float i=1;i<=n; i++)
            {
                harmonic = harmonic + 1 / i;
                Console.WriteLine("Harmonic of given number:" + harmonic);
            }
        }


    }
}
