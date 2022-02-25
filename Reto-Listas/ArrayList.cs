using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.LinkedList
{
    internal class ArrayList
    {
       
            public static int DEFAULT_SIZE = 2;
            public string[] array;
            public int size;

            public static string getName()
            {
                return "ArrayList";
            }

            public ArrayList()
            {
                array = new string[DEFAULT_SIZE];
            }

            public ArrayList(int size)
            {
                array = new string[size];
            }

            public void AddAtTail(string data)
            {

                if (size == array.Length)
                {
                    IncreaseArraySize();
                }

                array[size] = data;
                size++;
            }

            public void addAtFront(string data)
            {

                if (size == array.Length)
                {
                    IncreaseArraySize();
                }

                if (size >= 0)
                {
                    System.Array.Copy(array, 0, array, 1, size);
                }
                array[0] = data;
                size++;
            }

            public void remove(int index)
            {

                if (index < 0 || index >= size)
                {
                    return;
                }

                if (size - 1 - index >= 0)
                {
                    System.Array.Copy(array, index + 1, array, index, size - 1 - index);
                }

                array[size - 1] = null;
                size--;
            }

            public void removeAll()
            {
                for (int i = 0; i < size; i++)
                {
                    array[i] = null;
                }
                size = 0;
            }

            public void SetAt(int index, string data)
            {
                if (index >= 0 && index < size)
                {
                    array[index] = data;
                }
            }

            /**
             * @param index 0-index
             * @return element at position index
             *
             *
             * Big(O)
             *
             * O(1)
             *
             */
            public string? GetAt(int index)
            {
                return index >= 0 && index < size ? array[index] : null;
            }

            public ArrayListIterator getIterator()
            {
                return new ArrayListIterator(this);
            }

            public int GetSize()
            {
                return size;
            }

            private void IncreaseArraySize()
            {
                string[] newArray = new string[array.Length * 2];

                for (int i = 0; i < size; i++)
                {
                    newArray[i] = array[i];
                }

                array = newArray;
            }

        
    }
}
