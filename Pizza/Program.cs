using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaFact = new PizzaFactory();
            pizzaFact.createPizza("NY", "cheese");
            pizzaFact.createPizza("NY", "veggie");
            pizzaFact.createPizza("Chicago", "cheese");
            pizzaFact.createPizza("Chicago", "pepperoni");
            pizzaFact.createPizza("Chicago", "veggie");
            pizzaFact.createPizza("NY", "clam");
            Console.ReadLine();
        }
    }

    public class PizzaFactory : PizzaStore
    {
        public override Pizza createPizza(string style, string type)
        {
            Pizza pizza = null;

            if (style == "NY")
            {
                switch (type)
                {
                    case "cheese":
                        pizza = new NYStyleCheesePizza();
                        break;
                    case "veggie":
                        pizza = new NYStyleVeggiePizza();
                        break;
                    case "clam":
                        pizza = new NYStyleClamPizza();
                        break;
                    case "pepperoni":
                        pizza = new NYStylePepperoniPizza();
                        break;
                }
            }
            else if (style == "Chicago")
            {
                switch (type)
                {
                    case "cheese":
                        pizza = new ChicagoStyleCheesePizza();
                        break;
                    case "veggie":
                        pizza = new ChicagoStyleVeggiePizza();
                        break;
                    case "clam":
                        pizza = new ChicagoStyleClamPizza();
                        break;
                    case "pepperoni":
                        pizza = new ChicagoStylePepperoniPizza();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: invalid store");
                return null;
            }
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        /*public override Pizza createPizza(string item, string type)
        {
            throw new NotImplementedException();
        }*/
    }
    

    public class Pizza
    {
        public string name;

        public List<string> toppings = new List<string>();

        public string getName()
        {
            return name;
        }

        public void prepare()
        {
            Console.WriteLine("... ");
            Console.WriteLine("Preparing " + name);
        }

        public void bake()
        {
            Console.WriteLine("... ");
            Console.WriteLine("Baking " + name);
        }

        public void cut()
        {
            Console.WriteLine("... ");
            Console.WriteLine("Cutting " + name);
        }

        public void box()
        {
            Console.WriteLine("... ");
            Console.WriteLine("Boxing " + name);
            Console.WriteLine("... ");
        }

        public string toString()
        {
            StringBuilder display = new StringBuilder();
            Console.WriteLine("Pizza Toppings: ");
            foreach (String topping in toppings)
            {
                display.Append(topping + "\n");
            }
            return display.ToString();
        }
    }
    public abstract class PizzaStore
    {

        public abstract Pizza createPizza(string item, string type);

        public Pizza orderPizza(string type, string item)
        {
            Pizza pizza = createPizza(type, item);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }
    }
    public class NYStyleCheesePizza : Pizza
    {

    public NYStyleCheesePizza()
    {
        name = "NYStyleCheesePizza";
        toppings.Add("Mozzarella");
    }

    }
    public class NYStyleClamPizza : Pizza
    {

    public NYStyleClamPizza()
    {
        name = "NYStyleClamPizza";
        toppings.Add("Clam");
    }

    }
    public class NYStyleVeggiePizza : Pizza
    {

    public NYStyleVeggiePizza()
    {
        name = "NYStyleVeggiePizza";
        toppings.Add("Tomatoes");
        toppings.Add("Letuce");
    }

    }
    public class NYStylePepperoniPizza : Pizza
    {

    public NYStylePepperoniPizza()
    {
        name = "NYStylePepperoniPizza";
        toppings.Add("Pepperoni");
    }

    }
    public class ChicagoStyleVeggiePizza : Pizza
    {

    public ChicagoStyleVeggiePizza()
    {
        name = "ChicagoStyleVeggiePizza";
        toppings.Add("Tomatoes");
        toppings.Add("Letuce");
    }

    }
    public class ChicagoStylePepperoniPizza : Pizza
    {

    public ChicagoStylePepperoniPizza()
    {
        name = "ChicagoStylePepperoniPizza";
        toppings.Add("Pepperoni");
    }

    }
    public class ChicagoStyleClamPizza : Pizza
    {

    public ChicagoStyleClamPizza()
    {
        name = "ChicagoStyleClamPizza";
        toppings.Add("Clam");
    }

    }
    public class ChicagoStyleCheesePizza : Pizza
    {

    public ChicagoStyleCheesePizza()
    {
        name = "ChicagoStyleCheesePizza";
        toppings.Add("Mozzarella");
    }

}
}
