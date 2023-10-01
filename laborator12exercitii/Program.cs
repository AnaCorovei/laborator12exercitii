using System;

namespace laborator12exercitii
{
    class Program
    {

        /*
        Scrieti o clasa care va implementa o structura de date generica de tipul coada. (queue)
        Coada va functiona pe principiul FIFO (first in first out) si va avea urmatoarele metode si proprietati:
        • Enqueue – va adauga un element la capatul cozii
        • Dequeue – va extrage primul element din coada si il va returna ca rezultat
        • Count – va returna numarul de elemente din coada.
        La initializarea cozii va fi stabilita capacitatea maxima a cozii. 
        In interiorul clasei, folositi o structura de tip vector pentru a stoca datele.
        Initializati mai multe cozi (intregi, obiecte), adaugati elemente, extrageti elemente, afisati-le
        */
        static void Main(string[] args)
        {
            
            var queue = new Queue<int>(2);
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(1);
            queue.Enqueue(5);
            queue.Enqueue(8);
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(4);
            queue.Enqueue(5);

            var x = queue.Dequeue();
            Console.WriteLine("Dequed: "+  x);

            queue.Afisare();
            Console.WriteLine("count: " +queue.Count);

            var queue2 = new Queue<float>(100);
            var result = queue2.Dequeue();

            Console.WriteLine("Dequed: " + result);

            /*
             suma numerelor pare de la 1 pana la n.
            1. Testam cazul general
            2. Testam situatii exceptionale
            */

            //Console.WriteLine(CalculatorAvansat.Suma1N(5));
            //Console.WriteLine(CalculatorAvansat.Suma1N(1));
            //Console.WriteLine(CalculatorAvansat.Suma1N(-30));

        }
    }
}
