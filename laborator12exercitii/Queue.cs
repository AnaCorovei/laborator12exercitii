using System;
using System.Collections.Generic;
using System.Text;

namespace laborator12exercitii
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
    class Queue<T>
    {
        private T[] elements;
    
        public int Count { get; private set; } = 0;
        public Queue()
        {
            elements = new T[4];
        }

        public Queue(int capacity)
        {
          
            elements = new T[capacity];
        }

        public void Enqueue(T elementToEnqueue)
        {
            if (Count == elements.Length)
            {
                var newVec = new T[2 * elements.Length];
                for (int i = 0; i < elements.Length; i++)
                {
                    newVec[i] = elements[i];
                }
                elements = newVec;
            }
            elements[Count] = elementToEnqueue;
            Count++;
        }

        public T Dequeue()
        {
            if (Count ==0)
            {
                return default;
            }
            T result = elements[0];

            for (int i = 0; i < Count-1; i++)
            {
                elements[i] = elements[i + 1];
            }
            Count--;
            return result;
        }

        public void Afisare()
        {
            for (var i = 0; i < Count; i++) 
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}
