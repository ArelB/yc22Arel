using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Car
    {
        private string carName;
        private int carDoors;
        public string Model {
            get
            {
                return carName;
            }
            set
            {
                if (value.Length == 0)
                {
                    carName = "fiat";
                }
                else
                {
                    carName = value;
                }
            }
        }
        public int doors
        {
            get
            {
                return carDoors;
            }
            set
            {
                if (value == 0)
                {
                    carDoors = 3;
                }
                else
                {
                    carDoors = value;
                }
            }
        }

        public string Brand { get; set; }

        public bool hasEngine { get; set; }


    } 

    public class Singleton
    {
        private static Singleton Instance;
        private Singleton()
        {

        }

        public static Singleton getInstance()
        {
           if (Instance == null)
            {
                Console.WriteLine("Local instance is null");
                Instance = new Singleton();
            }
            Console.WriteLine("Returning instance");
            return Instance;
        }
    }
}
