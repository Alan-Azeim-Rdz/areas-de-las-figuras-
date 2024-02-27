using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areas_de_las_figuras_
{


    internal class basee
    {
        protected double Bas;

        public double B1
        {
            get { return Bas; }
            set { Bas = value; }
        }

        //constructors
        public basee()
        {
            Bas = 0;
        }
        public basee(double Bas)
        {
            this.Bas = Bas;
        }

        public override string ToString()
        {
            return "" + Bas;
        }
        public double Getarea(basee s)
        {
            return s.Bas * s.Bas ;
        }
        public static void PrintMessage()
        {
            Console.WriteLine("this is the area of the square  ");
        }

        // Destructor (finalizador)
        ~basee()
        {
            Console.WriteLine("Destructor de side1 llamado.");
            Console.ReadKey();
        }
    }
}


