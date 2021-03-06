using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace_2022.Shared {
    public class HardCodedMenuService : IMenuService {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu {
                Pizzas = new List<Pizza> {
                    //new Pizza(1, "Pepperoni", 8.99M, Spiciness.Spicy),
                    //new Pizza(2, "Margarita", 7.99M, Spiciness.None),
                    //new Pizza(3, "Diabolo", 9.99M, Spiciness.Hot)
                    new Pizza(4, "Bear", 45, Spiciness.Nuoc1),
                     new Pizza(4, "Nước Cam", 55, Spiciness.Nuoc2),
                      new Pizza(4, "Nước lọc", 65, Spiciness.Nuoc3),
                }
             });
    }
}

