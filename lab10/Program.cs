using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Corner corner = new Corner(30,20,5);
            corner.Minutes = -70;
            Console.ReadKey();
        }

    }
    class Corner
    {
        public double Grade { get; set;  }
        double minutes;
        public double Seconds { get; set; }

        public double Minutes
        {
            set
            {
                if (value > 0)
                {
                    minutes = value;
                }
                else
                {
                    Console.WriteLine("Минуты не могут быть отрицательными");
                }
            }
                get
                {
                return minutes;
                }
            }
        
    
        public Corner(double grade, double minutes, double seconds)
        {
            Grade = grade;
            Minutes = minutes;
            Seconds = seconds;

            var Radians = (Grade + Minutes / 60 + Seconds / 3600) * (Math.PI) / 180;

            if (Grade < 0)
                Radians = -Radians;
            {
                Console.WriteLine("Значение данного угла в радианах=" + Radians);
            }
            {
                Console.ReadKey();
            }
        }
    }
}

