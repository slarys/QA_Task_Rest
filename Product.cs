﻿namespace QA_Task;

public class Product : IComparable
{
    public Product(string name, double price, ProductType type, uint weight)
    {
        Name = name;
        Price = price;
        Weight = weight;
        this.type = type;
    }

    public string Name { get; set; }
    public double  Price { get; set; }
    public ProductType type  { get; set; }
    public uint Weight { get; set; }

    public override string ToString()
    {
        return Name + " (" + Weight + "g.)";
    }

    public int CompareTo(object? obj)
    {
        if (obj is Product product)
        {
            if (Weight < product.Weight)
            {
                return -1;
            }
            else if (Math.Abs(Price - product.Weight) < 0.001)
            {
                return 0;
            }
            else
                return 1;
        }
        else throw new ArgumentException("Incorrect value");
    }
}