using System.Collections.Generic;

namespace Tema8
{
    class MyStack
    {
        public MyStack()
        {
            Lista = new List<int>();
        }
        public List<int> Lista { get; set; }

        public void Pop()
        {

            if (Lista.Count == 0)
            {
                return;

            }
            RemoveLastElem();
        }

        private void RemoveLastElem()
        {
            List<int> listTemp = new List<int>();
            for (int i = 0; i < Lista.Count-1; i++)
            {
                listTemp.Add(Lista[i]);
            }

            Lista = listTemp;
        }

        public void Push(int element)
        {
            Lista.Add(element);
        }

        private void FindElem(int x)
        {
            bool gasit = false;
            for (int i = 0; i < Lista.Count - 1; i++)
            {
                if (Lista[i] != x)
                    continue;
                else
                    gasit = true;
            }
            if(gasit==true)
                System.Console.WriteLine("Elementul se afla in stiva");
            else
                System.Console.WriteLine("Elementul nu se afla in stiva");

        }

        public void Contain(int element)
        {
            if (Lista.Count == 0)
            {
                return;

            }
            FindElem(element);
        }
    }
}
