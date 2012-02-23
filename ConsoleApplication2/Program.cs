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

            var o = new { Title = "Ghostbusters", Rating = "PG" };


            // uncomment below for working solution based on answer from Stackoverflow 
            // http://stackoverflow.com/questions/9416095/dynamic-does-not-contain-a-definition-for-a-property-from-a-project-reference
            /*  
            
            dynamic o = new ExpandoObject();
            o.Title = "Ghostbusters";
            o.Rating = "PG";
            */



            Console.WriteLine(m.PrintMovie(o));
        }
    }
}
