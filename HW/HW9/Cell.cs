using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net18MarfitinLesson2
{
    class Cell<T>
    {
        public Cell(Cell<T> nextCell, T value)
        {
            NextCell = nextCell;
            Value = value;
        }

        public Cell<T> NextCell { get; set; }
        public T Value { get; set; }
    }
}
