// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;

namespace QA_Task;

class Program
{
    private static List<Product> products = new List<Product>()
    {
        new Product("Cutlet", 10, ProductType.Meat, 100),
        new Product("Peperoni", 20, ProductType.Meat, 50),
        new Product("Salad", 1, ProductType.Vegetable, 90),
        new Product("Avocado", 10, ProductType.Fruit, 215)
    };

    private static List<Product> products2 = new List<Product>()
    {
        new Product("Cutlet", 10, ProductType.Meat, 300),
        new Product("Salad", 15, ProductType.Vegetable, 90),
        new Product("Gold", 500, ProductType.Spices, 15),
        new Product("Ketchup", 3, ProductType.Spices, 30),
    };

    private static List<Product> products3 = new List<Product>()
    {
        new Product("Apple", 5, ProductType.Fruit, 200)
    };

    private static List<Dish> dishes = new List<Dish>() { new Dish(products, "Pizza Half-Vegan", 3000, 350) };

    private static List<Dish> dishes2 = new List<Dish>()
    {
        new Dish(products2, "Golden Burger", 20000, 500),
        new Dish(products, "Pizza Half-Vegan", 6000, 350)
    };

    private static List<Dish> dishes3 = new List<Dish>()
    {
        new Dish(products, "Pizza Half-Vegan", 6000, 350),
        new Dish(products3, "Apple Slices", 300, 350)
    };

    private static List<Restaurant> restaurants = new List<Restaurant>()
    {
        new Restaurant("Ivlev", "Rest Ivleva", 0.1, dishes),
        new Restaurant("Prigojin", "Putin Kitchen", 0.01, dishes3),
        new Restaurant("Nusret", "Nusret", 0.2, dishes2)
    };

    private static void viewIngredients(Dish chosenDish)
    {
        
    }

    private static void viewMenu(Restaurant chosenRest)
    {
        var topIngredients = new Dictionary<Product, uint>();
        var basedDishes = new Dictionary<Dish, double>();
        chosenRest.listDishes.Sort();
        foreach (var dish in chosenRest.listDishes)
        {
            dish.ListProduct.Sort();
            Console.WriteLine(dish.Name + ", " + dish.Weight + "g, Ingredients: [" +
                              String.Join(", ", dish.ListProduct) + "]. Price: " + dish.Price +
                              ", Price with service: " + dish.Price * (1 + chosenRest.Fee));
            
            double primeCost = 0;
            foreach (var ing in dish.ListProduct)
            {
                primeCost += ing.Price * ing.Weight;
                if (!topIngredients.ContainsKey(ing))
                    topIngredients.Add(ing, ing.Weight);
                else
                    topIngredients[ing] += ing.Weight;
            }


            if (!basedDishes.ContainsKey(dish))
                basedDishes.Add(dish, dish.Price / primeCost);
        }

        var maxValue = topIngredients.Values.Max(); // 4
        var keyOfMaxValue =
            topIngredients.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        Console.WriteLine("The most used ingredient is " + keyOfMaxValue);
        var sortedDict = from entry in basedDishes orderby entry.Value ascending select entry;
        Console.WriteLine("\nTop dishes by price/prime cost ration");
        foreach (var item in sortedDict)
        {
            Console.WriteLine(item.Key + ", " + Math.Round(item.Value, 3));
        }
    }

    private static void viewRest(int id)
    {
        Restaurant chosenRest = restaurants[id];
        Console.WriteLine("You chose: " + chosenRest.Name + " - Chef: " + chosenRest.ChefName);
        Console.Write("Actions:" +
                      "\n1. View Menu" +
                      "\n2. Add to Menu");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            viewMenu(chosenRest);
        }
        else
        {
            Dish newDish = new Dish();
            Console.WriteLine("Type name of the dish: ");
            newDish.Name = Console.ReadLine();
            Console.WriteLine("Type price of the dish: ");
            newDish.Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type weight of the dish: ");
            newDish.Weight = Convert.ToUInt32(Console.ReadLine());
            chosenRest.listDishes.Add(newDish);
        }
    }

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose restaurant: ");
            int index;
            for (index = 0; index < restaurants.Count; index++)
            {
                var rest = restaurants[index];
                Console.WriteLine((index + 1) + ". " + rest.Name + " - Chef: " + rest.ChefName);
            }

            Console.WriteLine(index + 1 + ". Add a restaurant");
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index > choice)
            {
                viewRest(choice);
            }
            else
            {
                Restaurant newRest = new Restaurant();
                Console.WriteLine("Type name of the restaurant: ");
                newRest.Name = Console.ReadLine();
                Console.WriteLine("Type name of the Chef: ");
                newRest.ChefName = Console.ReadLine();
                Console.WriteLine("Type service fee: ");
                newRest.Fee = Convert.ToDouble(Console.ReadLine());
                restaurants.Add(newRest);
            }

            Console.WriteLine("\nContinue?(y/n)");
            char inp = Convert.ToChar(Console.ReadLine());
            if (!inp.Equals('y'))
                break;
        }
    }
}