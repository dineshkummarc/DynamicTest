using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;

namespace ConsoleApplication1
{
    public class Movie : DynamicObject
    {
        public string PrintMovie(dynamic o)
        {
            return string.Format("Title={0} Rating={1}", o.Title, o.Rating);
        }
    }
}
