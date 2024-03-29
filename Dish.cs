﻿using System.Text;

namespace QA_Task;

public class Dish : IComparable
{
    public Dish()
    {
        ListProduct = new List<Product>();
    }

    public Dish(string name, double price, uint weight)
    {
        Name = name;
        Price = price;
        Weight = weight;
    }

    public Dish(List<Product> listProduct, string name, double price, uint weight)
    {
        ListProduct = listProduct;
        Name = name;
        Price = price;
        Weight = weight;
    }

    public List<Product> ListProduct { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public uint Weight { get; set; }

    public override string ToString()
    {
        return Name;
    }

    public string listProductsToString()
    {
        StringBuilder res = new StringBuilder("[");
        for (var index = 0; index < ListProduct.Count; index++)
        {
            var prod = ListProduct[index];
            res.Append(index + 1 + ". " + prod + ", ");
        }

        res[res.Length - 2] = ']';
        res[res.Length - 1] = '.';

        return res.ToString();
    }

    public int CompareTo(object? obj)
    {
        if (obj is Dish dish)
        {
            if (Price < dish.Price)
            {
                return -1;
            }
            else if (Math.Abs(Price - dish.Price) < 0.001)
            {
                return 0;
            }
            else
                return 1;
        }
        else throw new ArgumentException("Incorrect value");
    }
}