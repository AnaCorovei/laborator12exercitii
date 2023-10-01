using System;
using System.Collections.Generic;
using System.Text;

namespace laborator12exercitii
{

    /*Exercitiu
     Scrieti o functie care va calcula suma numerelor pare de la 1 pana la n.
    Algoritm
    1. Testam cazul general
    2. Testam situatii exceptionale

     */
    public  class CalculatorAvansat
    {
       public int Suma1N(int n)
        {
            int result = 0;
            for (var i = 1; i <= n; i++)
            {
                result += i;
            }
                return result;
            
        }

        public int Suma(int x, int y)
        {
            return x + y;
        }

        public bool EstePar(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else return false;
        }

        public int Factorial (int n)
        {
            if (n< 0)
            {
                return 0;
            }
            int result = 1;
            for (int i =1; i<=n; i++)
            {
                result *= i;   // result = result * i;
            }
            return result;
        }
    }
}
