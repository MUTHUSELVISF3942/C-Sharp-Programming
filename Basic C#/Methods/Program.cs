using System;
namespace Methods;
class Program{
    public static void Main(string[] args)
    {
        int firstNo,secondNo,choice;
        string condition="";
        do
        {
        System.Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\nEnter the choice:");
        choice=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the first number:");
        firstNo=int.Parse(Console.ReadLine());
        System.Console.WriteLine(("Enter the second number"));
        secondNo=int.Parse(Console.ReadLine());
        
        switch(choice)
        {
            case 1:
            {
                
                int sum=Addition(firstNo,secondNo);
                System.Console.WriteLine(("The sum is:"+sum));
                break;
            }
             case 2:
            {
               
                int difference=Subtraction(firstNo,secondNo);
                System.Console.WriteLine(("The difference is:"+difference));
                break;
            }
             case 3:
            {
                
                int product=Multiplication(firstNo,secondNo);
                System.Console.WriteLine(("The product is:"+product));
                break;
            }
             case 4:
            {
               int quotient=Division(firstNo,secondNo);
                System.Console.WriteLine(("The quotient is:"+quotient));
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid choice");
                break;
            }
            
        }
        
            System.Console.WriteLine("Do you want to continue again:");
            condition=(Console.ReadLine().ToLower());    
        }while(condition=="yes");
        int Addition(int value1,int value2)
        {
            int sum;
            sum=value1+value2;
            return sum;
        }
        int Subtraction(int value1,int value2)
        {
            int difference;
            difference=value1-value2;
            return difference;
        }
        int Multiplication(int value1,int value2)
        {
            int product;
            product=value1*value2;
            return product;
        }
        int Division(int value1,int value2)
        {
            int quotient;
            quotient=value1/value2;
            return quotient;
        }

    }
}
