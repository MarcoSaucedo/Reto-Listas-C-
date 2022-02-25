using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.LinkedList
{
    internal class ArrayListIterator
    {
        

            private ArrayList arrayList;
            private int currentItem;

            public ArrayListIterator(ArrayList arrayList)
            {
                this.arrayList = arrayList;
            }

            public bool hasNext()
            {
                return currentItem < arrayList.GetSize();
            }

            public string next()
            {
                string data = arrayList.GetAt(currentItem);

                currentItem++;

                return data;
            }
    }
}
