using System;
using System.Collections.Generic;

namespace Inventory
{
    public class Pack
    {
        public int CarryAmount { get; }
        
        public int CurrentAmount
        {
            get => PackContents.Count;
        }
        
        public float CarryWeight { get; }
        
        public double CurrentWeight
        {
            get
            {
                double x = 0;
                foreach (var item in PackContents) { x += item.Weight; }
                return x;
            }
        }
        public float CarryVolume { get; }
        
        public double CurrentVolume
        {
            get
            {
                double x = 0;
                foreach (var item in PackContents) { x += item.Volume; }
                return x;
            }
        }
        public List<InventoryItem> PackContents { get; } = new();

        public Pack(int carryAmount, float carryWeight, float carryVolume)
        {
            CarryAmount = carryAmount;
            CarryWeight = carryWeight;
            CarryVolume = carryVolume;
        }

        public bool Add(InventoryItem item)
        {
            if (PackContents.Count >= CarryAmount)
            {
                Console.WriteLine($"Can't add {item.Name}, you're carrying too much stuff!");
                return false;
            }
            
            if (CurrentWeight >= CarryWeight)
            {
                Console.WriteLine($"Can't add {item.Name}, your pack is too heavy!");
                return false;
            }
            
            if (CurrentVolume >= CarryVolume)
            {
                Console.WriteLine($"Can't add {item.Name}, there's no space!");
                return false;
            }
            
            Console.WriteLine($"You added an {item.Name}.");
            PackContents.Add(item);
            return true;
        }

        public void ShowContents()
        {
            Console.WriteLine("----- Your Inventory -----");
            
            foreach (var item in PackContents)
            {
                Console.WriteLine($" - {item.Name} | {item.Weight}w | {item.Volume}v - ");
            }
            
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Amount Used: {CurrentAmount}/{CarryAmount}");
            Console.WriteLine($"Weight Used: {CurrentWeight}/{CarryWeight}");
            Console.WriteLine($"Volume Used: {CurrentVolume}/{CarryVolume}");
            Console.WriteLine("-------------------------");
            
        }
        
        public void ShowMenu()
        {
            Console.WriteLine("1: Check your inventory.");
            Console.WriteLine("2: Add an arrow."); 
            Console.WriteLine("3: Add a bow."); 
            Console.WriteLine("4: Add some rope.");
            Console.WriteLine("5: Add some water.");
            Console.WriteLine("6: Add some Food.");
            Console.WriteLine("7: Add a sword.");
        }
    }

    public class InventoryItem
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }

        public InventoryItem(string name, double weight, double volume)
        {
            Name = name;
            Weight = weight;
            Volume = volume;
        }
    }

    public class Arrow : InventoryItem
    {
        public Arrow() : base("Arrow",0.1, 0.05)
        {
        }
    }
    
    public class Bow : InventoryItem
    {
        public Bow() : base("Bow", 1, 4)
        {
        }
    }
    
    public class Rope : InventoryItem
    {
        public Rope() : base("Rope", 1, 1.5)
        {
        }
    }
   
    public class Water : InventoryItem
    {
        public Water() : base("Water", 2, 3)
        {
        }
    }
    
    public class Food : InventoryItem
    {
        public Food() : base("Food", 1, 0.5)
        {
        }
    }
    
    public class Sword : InventoryItem
    {
        public Sword() : base("Sword", 5, 3)
        {
        }
    }
}