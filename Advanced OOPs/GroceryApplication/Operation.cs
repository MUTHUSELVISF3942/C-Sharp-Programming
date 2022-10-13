using System;
using System.Collections.Generic;
namespace GroceryApplication;
class Operation
{
       static CustomerDetail currentCustomer=null;
       public static List<CustomerDetail> CustomerList=new List<CustomerDetail>();
       public static List<ProductDetail> ProductList=new List<ProductDetail>();
       public static List<BookingDetail> BookingList=new List<BookingDetail>();
       public static List<OrderDetail> OrderList=new List<OrderDetail>();
   
    public static void MainMenu()
    {
    
         string choice="yes";
         do
         {  
            
            System.Console.WriteLine("Select option\n1.Customer Registration\n2.Customer Login\n3.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                //Select the customer registration
                case 1:
                {
                    System.Console.WriteLine("*************Customer Registration*************");
                    CustomerRegistration();
                    break;
                }
                //Select the Customer Login
                case 2:
                {
                    System.Console.WriteLine("****************Customer Login**************");
                    CustomerLogin();
                    break;
                }
                //Select the exit
                case 3:
                {
                    System.Console.WriteLine("********Exit Mainmenu*********");
                    choice="no";
                    break;
                }
            }

         }while(choice=="yes");
    
    }

    //Customer Registration
    public static void CustomerRegistration()
    {
        System.Console.WriteLine("Customer Registration");
        System.Console.WriteLine("Enter the name:");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter the father name:");
        string fatherName=Console.ReadLine();
        System.Console.WriteLine("Enter the gender:");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine("Enter the mobile number:");
        long mobileNumber=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the date of birth:");
        DateTime dateOfBirth=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter the mail id:");
        string mailId=Console.ReadLine();
        CustomerDetail customer=new CustomerDetail(name,fatherName,gender,mobileNumber,dateOfBirth,mailId);
        CustomerList.Add(customer);
        System.Console.WriteLine("Registration successfully");
        System.Console.WriteLine("Customer Id:"+customer.CustomerId);
        
    }
    //Customer Login
    public static void CustomerLogin()
    {
        System.Console.WriteLine("Enter the customer id:");
        string customerId=Console.ReadLine().ToUpper();
        bool flag=true;
        foreach(CustomerDetail customera in CustomerList)
        {
            if(customerId==customera.CustomerId)
            {
                System.Console.WriteLine("Login sucessfully");
                currentCustomer=customera;
                SubMenu();
                flag=false;
            }
            
        }
        if(flag==true)
        {
        System.Console.WriteLine("Invalid id");
        }
        
    }

    //SubMenu
    public static void SubMenu()
    {
        string choice="yes";
        do{
            
            System.Console.WriteLine("Select option\n1.Show Customer Details\n2.Show Product Details\n3.Wallet Recharge\n4.Take Order\n5.Modify Order Quantity\n6.Cancel Order\n7.Exit");
            int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                System.Console.WriteLine("***********Show Customer Details**************");
                currentCustomer.ShowCustomerDetails();
                break;
            }
            case 2:
            {
                System.Console.WriteLine("*********Show Product Details*************");
                ShowProductDetail();
                break;
            }
            case 3:
            {
                System.Console.WriteLine("*************Wallet Recharge*************");
                currentCustomer.WalletRecharge();
                break;
            }
            case 4:
            {
                System.Console.WriteLine("*************Take Order**************");
                TakeOrder();
                break;
            }
            case 5:
            {
                System.Console.WriteLine("*************Modify Order Quantity**********");
                ModifyOrderQuantity();
                break;
            }
            case 6:
            {
                System.Console.WriteLine("*************Cancel Order***********");
                CancelOrder();
                break;
            }
            case 7:
            {
                System.Console.WriteLine("***********Exit Submenu***********");
                choice="no";
                break;
            }
        }
        }while(choice=="yes");
    }
    public static void AddDefaultData()
    {
        //Customer details data
        CustomerDetail customer=new CustomerDetail("Ravi","Ettaparajan",Gender.Male,974964962,new DateTime(1996,04,12),"ravi@gmail.com");
        CustomerDetail customer1=new CustomerDetail("Baskaran","Sethurajan",Gender.Male,847575775,new DateTime(1999,11,11),"baskaran@gmail.com");
        CustomerList.Add(customer);
        CustomerList.Add(customer1);
            
       //Product details data
        ProductDetail product=new ProductDetail("Sugar",20,40.0);
        ProductDetail product1=new ProductDetail("Rice",100,50);
        ProductDetail product2=new ProductDetail("Milk",10,40);
        ProductDetail product3=new ProductDetail("Coffee",10,10);
        ProductDetail product4=new ProductDetail("Tea",10,10);
        ProductDetail product5=new ProductDetail("Masala Powder",10,20);
        ProductDetail product6=new ProductDetail("Salt",10,10);
        ProductDetail product7=new ProductDetail("Chilli Powder",10,25);
        ProductList.Add(product);
        ProductList.Add(product1);
        ProductList.Add(product2);
        ProductList.Add(product3);
        ProductList.Add(product4);
        ProductList.Add(product5);
        ProductList.Add(product6);
        ProductList.Add(product7);
        

        //Booking details data
        BookingDetail book=new BookingDetail("CID3001",220,new DateTime(2022,07,26),BookingStatus.Booked);
        BookingDetail book1=new BookingDetail("CID3002",400,new DateTime(2022,07,26),BookingStatus.Booked);
        BookingDetail book2=new BookingDetail("CID3001",280,new DateTime(2022,07,26),BookingStatus.Cancelled);
        BookingDetail book3=new BookingDetail("CID3002",0,new DateTime(2022,07,26),BookingStatus.Initiated);
        BookingList.Add(book);
        BookingList.Add(book1);
        BookingList.Add(book2);
        BookingList.Add(book3);


        //Order details data
        OrderDetail booking1=new OrderDetail("BID3001","PID101",2,80);
        OrderDetail booking2=new OrderDetail("BID3001","PID102",2,100);
        OrderDetail booking3=new OrderDetail("BID3001","PID103",1,40 );
        OrderDetail booking4=new OrderDetail("BID3002","PID101",1,40 );
        OrderDetail booking5=new OrderDetail("BID3002","PID102",4,200);
        OrderDetail booking6=new OrderDetail("BID3002","PID110",1,140);
        OrderDetail booking7=new OrderDetail("BID3002","PID109",1,20 );
        OrderDetail booking8=new OrderDetail("BID3003","PID102",2,100);
        OrderDetail booking9=new OrderDetail("BID3003","PID108",4,100);
        OrderDetail booking10=new OrderDetail("BID3003","PID101",2,80 );
        OrderList.Add(booking1);
        OrderList.Add(booking2);
        OrderList.Add(booking3);
        OrderList.Add(booking4);
        OrderList.Add(booking5);
        OrderList.Add(booking6);
        OrderList.Add(booking7);
        OrderList.Add(booking8);
        OrderList.Add(booking9);
        OrderList.Add(booking10);
    }
    //Show product details
    public static void ShowProductDetail()
    {
        foreach(ProductDetail product in ProductList)
        {
            product.ShowProduct();
        }
    }
    public static void TakeOrder()
    {
        //Creating booking object
        BookingDetail booking=new BookingDetail(currentCustomer.CustomerId,0,DateTime.Now,BookingStatus.Initiated);
        List<OrderDetail> tempOrderList=new List<OrderDetail>();
        string choice="yes";
        do
        {

        //Show product details list
            ShowProductDetail();

        //Select product id and check product availability
        bool flag=true;
        System.Console.WriteLine("Enter the product id:");
        string productId=Console.ReadLine().ToUpper();
        foreach(ProductDetail product in ProductList)
        {
                if(productId==product.ProductId)
                {

                    //Get the quantity & check for availability
                    System.Console.WriteLine("Enter the quantity:");
                    int quantity=int.Parse(Console.ReadLine());

                    if(quantity<=product.Quantity)
                    {
                        
                        //Calculate price and compare with wallet 
                        double orderPrice=product.Price*quantity;
                        product.Quantity--;
                        OrderDetail order=new OrderDetail(booking.BookId,productId,quantity,orderPrice);
                        System.Console.WriteLine("Order successfully");
                        flag=false;
                    }
                }
                
            }
            System.Console.WriteLine("Do you want to another product:");
            choice=Console.ReadLine().ToLower();

        }while(choice=="yes");

        double totalAmount=0.0;
        foreach(OrderDetail order in tempOrderList)
        {
            totalAmount+=order.OrderPrice;
        }
        string wantToContinue="";
        System.Console.WriteLine("Do you want to continue the order:");
        wantToContinue=Console.ReadLine();
        if(wantToContinue=="yes")
        {
            while(true)
            {
               if(totalAmount<=currentCustomer.Balance)
               {
                currentCustomer.Balance-=totalAmount;
                booking.BookingStatus=BookingStatus.Booked;
                booking.TotalPrice=totalAmount;
                System.Console.WriteLine("Order successfully");
               }
               else if(totalAmount>currentCustomer.Balance)
               {
                    currentCustomer.WalletRecharge();
               }
            }
        }
        else
        {
            foreach(ProductDetail product in ProductList)
            {
                product.Quantity++;
            }
        }
    }
    public static void ModifyOrderQuantity()
    {
        System.Console.WriteLine("Modify order quantity");
    }
    public static void CancelOrder()
    {
        System.Console.WriteLine("Cancel order");
    }
}

