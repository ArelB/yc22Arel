using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    public interface Coffee
    {
        public double GetPrice();

    }

    public class SimpleCoffee : Coffee
    {
        public double GetPrice()
        {
            return 1.20;
        }
    }

    public class MilkDecorator : Coffee
    {
        public Coffee coffee { get; set; }

        public MilkDecorator(Coffee cofee)
        {
            this.coffee = cofee;
        }

        public double GetPrice()
        {
            return 0.50 + this.coffee.GetPrice();
        }
    }

    public class SugarDecorator : Coffee
    {
        public Coffee coffee { get; set; }

        public SugarDecorator(Coffee coffee)
        {
            this.coffee = coffee;
        }

        public double GetPrice()
        {
            return 0.30 + coffee.GetPrice();
        }
    }


}

