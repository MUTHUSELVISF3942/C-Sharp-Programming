using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccination
{
    public enum VaccineName{Default,Covidshield,Covaccine}
    public class VaccineClass
    {
        public static int s_vaccineId=10;
        public string VaccineID{get;}
        public VaccineName VaccineName{get;set;}
        public int NumberOfDoseAvailable{get;set;}
        public VaccineClass(VaccineName vaccineName,int numberOfDoseAvailable)
        {
            s_vaccineId++;
            VaccineID="CID"+s_vaccineId;
            VaccineName=vaccineName;
            NumberOfDoseAvailable=numberOfDoseAvailable;
        }
    }
}