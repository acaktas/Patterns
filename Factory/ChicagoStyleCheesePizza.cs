using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            this.Name = "Chicago Style Deep Dish Cheese Pizza";
            this.Dough = "Extra Thick Crust Dough";
            this.Sauce = "Plum Tomato Sauce";
            this.Toppings.Add("Shredded Mozzarella Cheese");
        }
        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
