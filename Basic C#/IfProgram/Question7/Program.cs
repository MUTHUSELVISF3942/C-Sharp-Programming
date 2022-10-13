using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        int id;
        string name;
        System.Console.WriteLine("Enter the customer id:");
        id=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the customer name:");
        name=Console.ReadLine();
        System.Console.WriteLine("Enter the unit consumed:");
        int unit=int.Parse(Console.ReadLine());
        if(unit<100)
        {
            System.Console.WriteLine($"Customer id:{id}");
            System.Console.WriteLine($"Customer name:{name}");
            System.Console.WriteLine($"Unit consumed:{unit}");
            System.Console.WriteLine($"Amount charges:100");
        }
        else if(unit<200)
        {
            System.Console.WriteLine($"Customer id:{id}");
            System.Console.WriteLine($"Customer name:{name}");
            System.Console.WriteLine($"Unit consumed:{unit}");
            double total=unit*1.20;
            System.Console.WriteLine($"Amount charges @Rs. 1.20 per unit:{total}");
             if(total>=400)
            {
                double surcharge=total*0.15;
                System.Console.WriteLine($"Surcharge amount:{surcharge}");
                System.Console.WriteLine($"Net amount paid by the customer:{total+surcharge}");
            }
            else
            {
                System.Console.WriteLine($"Net amount paid by the customer:{total}");
            }
        }
        else if(unit>=200 && unit<400)
        {
            System.Console.WriteLine($"Customer id:{id}");
            System.Console.WriteLine($"Customer name:{name}");
            System.Console.WriteLine($"Unit consumed:{unit}");
            double total=unit*1.50;
            System.Console.WriteLine($"Amount charges @Rs. 1.50 per unit:{total}");
             if(total>=400)
            {
                double surcharge=total*0.15;
                System.Console.WriteLine($"Surcharge amount:{surcharge}");
                System.Console.WriteLine($"Net amount paid by the customer:{total+surcharge}");
            }
            else
            {
                System.Console.WriteLine($"Net amount paid by the customer:{total}");
            }
        }
        else if(unit>=400 && unit<600)
        {
            System.Console.WriteLine($"Customer id:{id}");
            System.Console.WriteLine($"Customer name:{name}");
            System.Console.WriteLine($"Unit consumed:{unit}");
            double total=unit*1.80;
            System.Console.WriteLine($"Amount charges @Rs. 1.80 per unit:{total}");
            if(total>=400)
            {
                double surcharge=total*0.15;
                System.Console.WriteLine($"Surcharge amount:{surcharge}");
                System.Console.WriteLine($"Net amount paid by the customer:{total+surcharge}");
            }
            else
            {
                System.Console.WriteLine($"Net amount paid by the customer:{total}");
            }
        }
        else if(unit>=600)
        {
            System.Console.WriteLine($"Customer id:{id}");
            System.Console.WriteLine($"Customer name:{name}");
            System.Console.WriteLine($"Unit consumed:{unit}");
            double total=unit*2.00;
            System.Console.WriteLine($"Amount charges @Rs. 2.00 per unit:{total}");
             if(total>=400)
            {
                double surcharge=total*0.15;
                System.Console.WriteLine($"Surcharge amount:{surcharge}");
                System.Console.WriteLine($"Net amount paid by the customer:{total+surcharge}");
            }
            else
            {
                System.Console.WriteLine($"Net amount paid by the customer:{total}");
            }
        }
        
    }
}
