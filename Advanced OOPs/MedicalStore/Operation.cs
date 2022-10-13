using System;

using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public delegate void EventManager();
    public class Operation
    {
        public static event EventManager eventlink=null;
        static UserDetail currentUser=null;
        public static List<UserDetail> userList=new List<UserDetail>();
        static MedicineDetail currentMedicine=null;
        public static List<MedicineDetail> medicineList=new List<MedicineDetail>();
        static OrderDetails currentOrder=null;
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        public static void Subscribe()
        {
            eventlink+=new EventManager(Files.Create);
            eventlink+=new EventManager(Files.ReadFile);
            eventlink+=new EventManager(Operation.MainMenu);
            eventlink+=new EventManager(Files.WriteToFile);
        }
        public static void StartEvent()
        {
            Subscribe();
            eventlink();
        }
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select Option\n1.User Registration\n2.User Login\n3.Order History\n4.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("User Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("User Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Order History");
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }while(choice=="yes");
        }
        public static void Registration()
        {
            System.Console.WriteLine("Enter the user name:");
            string userName=Console.ReadLine();
            System.Console.WriteLine("Enter the age:");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the city:");
            string city=Console.ReadLine();
            System.Console.WriteLine("Enter the phone number:");
            long mobileNumber=long.Parse(Console.ReadLine());
            
            UserDetail userDetail=new UserDetail(userName,age,city,mobileNumber);
            userList.AddElement(userDetail);
            System.Console.WriteLine("User Id:"+userDetail.UserId);

        }
        public static void Login()
        {
            System.Console.WriteLine("Enter the user id:");
            string user=Console.ReadLine();
            foreach(UserDetail user1 in userList)
            {
                if(user1.UserId==user)
                {
                    System.Console.WriteLine("Login successfully");
                    currentUser=user1;
                    SubMenu();
                }
            }
        }

        public static void SubMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select Option\n1.Show Medicine List\n2.Purchase Medicine\n3.Cancel Purchase\n4.Show Purchase History\n5.Recharge\n6.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("***********Show Medicine List***********");
                        ShowMedicine();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("************Purchase Medicine***********");
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("************Cancel Pruchase************");
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("************Show Purchase History***********");
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("************Recharge************");
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Exit Submenu");
                        choice="no";
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }while(choice=="yes");
        }

        public static void ShowMedicine()
        {
            foreach(MedicineDetail medicine in medicineList)
            {
            System.Console.WriteLine("Medicine Id:"+medicine.MedicineId+"\nMedicine Name:"+medicine.MedicineName+"\nAvailable Count:"+medicine.AvailableCount+"\nPrice:"+medicine.Price+"\nDate of expiry:"+medicine.DateOfExpiry);
            }
        }
    }
}