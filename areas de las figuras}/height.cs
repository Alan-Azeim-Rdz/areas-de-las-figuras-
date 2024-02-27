using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areas_de_las_figuras_
{
    internal class height: basee
    {
        protected double heig;

        public double H1
        {
            get { return heig; }
            set { heig = value; }
        }

        //constructors
        public height() : base()
        {
            H1 = 0;
        }

        public height(double H1, double Bas) : base(Bas)
        {
            this.H1 = H1;
        }

        public override string ToString()
        {
            return "" + base.ToString() + "" + "," + H1;
        }
        public double Getarea(height s)
        {
            return ((s.H1 * s.B1)/2);
        }
        public static void PrintMessage()
        {
            Console.WriteLine("this is the area of the triangle");
        }

        ~height()
        {
            Console.WriteLine("Destructor de height llamado.");
            Console.ReadKey();
        }
    }
  

}
