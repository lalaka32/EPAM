using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net18MarfitinLesson2
{
    [Serializable]
    public class ListIsFullExeption : ApplicationException
    {
        public ListIsFullExeption() { }
        public ListIsFullExeption(string message) : base(message) { }
        public ListIsFullExeption(string message, Exception inner) : base(message, inner) { }
        protected ListIsFullExeption(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
