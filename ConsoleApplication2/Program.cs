using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using ConsoleApplication1;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie m = new Movie();
            //var o = new { Title = "Ghostbusters", Rating = "PG" };

            dynamic o = new ExpandoObject();
            o.Title = "Ghostbusters";
            o.Rating = "PG";
            
            Console.WriteLine(m.PrintMovie(o));
        }
    }
}
