using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            this.Name = "NY Style Sauce and Cheese Pizza";
            this.Dough = "Thin Crust Dough";
            this.Sauce = "Marinara Sauce";
            this.Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
