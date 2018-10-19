using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net18MarfitinLesson2
{
    class MyList<T>
    {
        public int Size { get; private set; }
        public Cell<T> FirstElement { get; private set; }
        public Cell<T> LastElement { get; private set; }

        public int Capacity { get; private set; }

        public MyList(T firstElement, int _size = 100)
        {
            Size = _size;
            Cell<T> temp = InnerAdd(firstElement);
            FirstElement = temp;
            FirstElement.NextCell = LastElement ;
            LastElement = temp;
        }
        private Cell<T> GetCell(int index)
        {
            if (index < 0 || Capacity < index)
            {
                throw new NullReferenceException();
            }
            Cell<T> value = FirstElement;
            for (int i = 0; i < index-1; i++)
            {
                value = value.NextCell;
            }

            return value;
        }

        private Cell<T> InnerAdd(T newValue)
        {
            if (Capacity+1 > Size)
            {
                throw new ListIsFullExeption("Sorry list is full");
            }
            Cell<T> nextCell = new Cell<T>(null, newValue);
            Capacity++;
            return nextCell;
        }

        public void Add(T newValue)
        {
            Cell<T> temp = InnerAdd(newValue);
            LastElement.NextCell = temp;
            LastElement = temp;
        }
        public void Add(T newValue, int index)
        {
            Cell<T> value = GetCell(index);
            Cell<T> tmp = value.NextCell;
            value = InnerAdd(newValue);
            value.NextCell = tmp;
        }
        public T GetValue(int index)
        {
            return GetCell(index).Value;
        }
        public void Remove(int index)
        {
            GetCell(index-1).NextCell = GetCell(index +1).NextCell;
            Capacity--;
        }
        public void RemoveAll(int index)
        {
            FirstElement.NextCell = null;
            Size = 0;
        }
        public void SwapElements(int index)
        {
            if (index>Capacity)
            {
                throw new NullReferenceException();
            }
            if (index == Capacity)
            {
                InnerSwap(LastElement, GetCell(Capacity-1));
            }
            else
            {
                InnerSwap(GetCell(index), GetCell(index+1));
            }
        }

        private void InnerSwap(Cell<T> cell1, Cell<T> cell2)
        {
            Cell<T> temp = cell1;
            cell1 = cell2;
            cell2 = temp;
        }
    }
}
