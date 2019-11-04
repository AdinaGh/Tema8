using System.Collections.Generic;

namespace Tema8
{
    class MyQueue
    {
        public MyQueue()
        {
            Lista = new List<int>();
        }
       public List<int> Lista { get; set; }

       public void Dequeue()
        {

            if (Lista.Count == 0)
            {
                return;
                
            }
           RemoveFirstElem();
        }

        private void RemoveFirstElem()
        {
            List<int> listTemp = new List<int>();
            for (int i = 1; i < Lista.Count; i++)
            {
                listTemp.Add(Lista[i]);
            }

            Lista = listTemp;
        }
        
        public void Enqueue(int element)
        {
             Lista.Add(element);
        }
        private void NrElem()
        {
            int nr = 0;

            for (int i = 0; i < Lista.Count; i++)
            {
                nr++;
            }
            System.Console.WriteLine("Coada are " + nr + " elemente");

        }
        public void Counts()
        {
            if (Lista.Count == 0)
            {
                return;

            }
            NrElem();
        }

    }
}
