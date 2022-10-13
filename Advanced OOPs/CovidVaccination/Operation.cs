using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccination
{
    public class Operation
    {
        public static BeneficiaryClass currentBeneficiary=null;
        public static List<BeneficiaryClass> beneficiaryList=new List<BeneficiaryClass>();
        public static VaccinationClass currentVaccination=null;
        public static List<VaccinationClass>  vaccinationList=new List<VaccinationClass>();
        public static VaccineClass currentVaccine=null;
        public static List<VaccineClass> vaccineList=new List<VaccineClass>();

        //MainMenu
        public static void MainMenu()
        {
             string choice="yes";
            do
            {
                Console.WriteLine("Select Option\n1.Beneficiary Registration\n2.Login\n3.GetVaccineInfo\n4.Exit");
                int option=int.Parse(Console.ReadLine());
                switch (option)
               {
                case 1:
                
                    System.Console.WriteLine("Beneficiary Registration");
                    BeneficiaryRegistration();
                    break;
                
                case 2:
                
                    System.Console.WriteLine("Login");
                    Login();
                    
                    break;

                case 3:
                    System.Console.WriteLine("Get Vaccine Information");
                    GetVaccineInfo();
                    break;
                   
                case 4:
                
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
              
                default:
                
                    break;
                
                }
                
        }while(choice=="yes");
            

        }
        //Beneficiary Registration
        public static void BeneficiaryRegistration()
        {
            System.Console.WriteLine("Enter the name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter the age:");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter the mobile number:");
            long mobileNo=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the city:");
            string city=Console.ReadLine();
            BeneficiaryClass beneficiary=new BeneficiaryClass(name,gender,mobileNo,city,age);
            beneficiaryList.Add(beneficiary);
            System.Console.WriteLine("Your registration Number:"+beneficiary.RegisterNumber);
        }
        //Login
        public static void Login()
        {
            System.Console.WriteLine("Enter the register number:");
            string registerNo=Console.ReadLine();
            foreach(var regNo in beneficiaryList)
            {
                if(registerNo==regNo.RegisterNumber)
                {
                    System.Console.WriteLine("Login successfully!!");
                    currentBeneficiary=regNo;
                    SubMenu();
                }
               
            }
            
        }
        //Get vaccine information
        public static void GetVaccineInfo()
        {
             foreach(var vaccine in vaccineList)
            {
            System.Console.WriteLine($"Vaccine Id:{vaccine.VaccineID} Vaccine Name:{vaccine.VaccineName}  Number of dose available:{vaccine.NumberOfDoseAvailable}");
            }
        }
        //Submenu
        public static void SubMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("SubMenu\n1.Show My Details\n2.Take Vaccination\n3. My Vaccination History\n4. Next Due Date\n5.Exit");
                int option=int.Parse(Console.ReadLine());
                switch (option)
                { 
                    case 1:
                    {
                        System.Console.WriteLine("Show My Details");

                        MyDetail();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Show My Details");
                        
                        break;
                    }    
                    case 3:
                    { 
                        VaccinationHistory();
                        break;       
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Vaccination history");
                        VaccinationHistory();
                        break;
                    }
                                   
                    case 5:
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
        //Show My details
        public static void MyDetail()
        {
            
            System.Console.WriteLine($"Register number:{currentBeneficiary.RegisterNumber}\nName is:{currentBeneficiary.Name}\nAge:{currentBeneficiary.Age}\nGender:{currentBeneficiary.Gender}\nMobile Number:{currentBeneficiary.MobileNumber}\nCity:{currentBeneficiary.City}"); 
            
        }
        
        //Take vaccination
        public static void TakeVaccination()
        {

        }
        //Vaccination history
        public static void VaccinationHistory()
        {
            foreach (var tempVaccine in vaccinationList)
            {
                if(tempVaccine.RegisterNumber==currentBeneficiary.RegisterNumber)
                {
                System.Console.WriteLine($"Vaccination ID:{tempVaccine.VaccinationID}\nRegister Number:{tempVaccine.RegisterNumber}\nVaccine ID:{tempVaccine.VaccineID}\nDose Number:{tempVaccine.DoseNumber}\nVaccinated Date:{tempVaccine.VaccinationDate}");
                }
            }
        }
        //Next due date
        public static void NextDueDate()
        {

        }
        //Beneficiary default values
       /* public static void BeneficiaryData()
        {
            beneficiaryList.Add(new BeneficiaryClass("Ravichandran",Gender.Male,9798367343,"Chennai",21));
            beneficiaryList.Add(new BeneficiaryClass("Baskaran",Gender.Male,9798367836,"Chennai",24));
            
        }
        //Vaccine default values
        public static void VaccineData()
        {
            vaccineList.Add(new VaccineClass(VaccineName.Covidshield,50));
            vaccineList.Add(new VaccineClass(VaccineName.Covaccine,50));
        }
        //Vaccination default values
        public static void VaccinationData()
        {
            vaccinationList.Add(new VaccinationClass("BID1001","CID1001",DoseNumber.One,new DateTime(11/11/2021)));
            vaccinationList.Add(new VaccinationClass("BID1001","CID1001",DoseNumber.Two,new DateTime(11/03/2022)));
            vaccinationList.Add(new VaccinationClass("BID1002","CID1002",DoseNumber.One,new DateTime(04/04/2022)));
        }*/
    }
}