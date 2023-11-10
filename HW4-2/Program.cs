using System.Text;
namespace Lesson
{
    public class Program
    {
        enum PizzaTypes
        {
            Margarita = 0,
            Peperoni = 1,
            Proshuto = 2,
            Ananas = 3
        }

        enum DrinkTypes
        {
            Cola = 0,
            Fanta = 1,
            Sprite = 3
            
        }
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            double firstPizzaPrice = 12.4;
            double secondPizzaPrice = 20.4;
            double thirdPizzaPrice = 30.4;
            double forthPizzaPrice = 15;

            double firstDrinkPrice = 2;
            double secondDrinkPrice = 3;
            double thirdDrinkPrice = 4;
            int pizzaNum = Convert.ToInt32(Console.ReadLine());
            DrinkTypes limonad = (DrinkTypes)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select pizza:  First. Second. Third. Forth ");
            Console.WriteLine("Enter pizza count:");
            int pizzaCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select drink: \n1. First\n2. Second\n3. Third");
            int drinkNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter drink count:");
            int drinkCount = Convert.ToInt32(Console.ReadLine());
            int  PizzaTypes = Convert.ToInt32(Console.ReadLine());
            int pizzaSum = Convert.ToInt32(Console.ReadLine());

            switch ((PizzaTypes)pizzaNum)
            {
                case PizzaTypes.First:
                    Console.WriteLine(pizzaSum += pizzaCount * firstPizzaPrice);
                    break;

                    case PizzaTypes.Second:
                    Console.WriteLine(pizzaSum += pizzaCount * secondPizzaPrice);
                    break;

                    case PizzaTypes.Third:
                    Console.WriteLine(pizzaSum += pizzaCount * thirdPizzaPrice);
                    break;

                    case PizzaTypes.Forth:
                    Console.WriteLine(pizzaSum += pizzaCount * forthPizzaPrice);
                    break;
                default:
                    throw new Exception("Incorrect pizza type!");
                    break;



            }
            switch ((DrinkTypes)drinkNum)
            {
                case DrinkTypes.First:
                    Console.WriteLine(drinkSum += drinkCount * firstDrinkPrice);
                    break;
                case DrinkTypes.Second: 
                    Console.WriteLine(drinkSum += drinkCount * secondDrinkPrice);
                    break;
                case DrinkTypes.Third:
                    Console.WriteLine(drinkSum += drinkCount * thirdDrinkPrice);
                    break;
            }
            Console.ReadLine();






        }
    }
}