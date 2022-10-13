using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public class MedicineDetail
    {
        public static int s_medicineId=100;
        public string MedicineId{get;}
        public string MedicineName{get;set;}
        public int AvailableCount{get;set;}
        public int Price{get;set;}
        public DateTime DateOfExpiry{get;set;}

         public MedicineDetail( string medicineName, int availableCount, int price, DateTime dateOfExpiry)
        {
            s_medicineId++;
            MedicineId ="MD"+ s_medicineId;
            MedicineName = medicineName;
            AvailableCount = availableCount;
            Price = price;
            DateOfExpiry = dateOfExpiry;
        }
        public MedicineDetail(string data)
        {
            string[] value=data.Split(",");
            s_medicineId=int.Parse(value[0].Remove(0,2));
            MedicineId=value[0];
            MedicineName=value[1];
            AvailableCount=int.Parse(value[2]);
            
            Price=int.Parse(value[3]);
            DateOfExpiry=DateTime.ParseExact(value[4],"dd/MM/yyyy",null);
        }

    }
}