using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccination
{
    public enum DoseNumber{Default,One,Two,Three}   
    public class VaccinationClass
    {
        public static int s_vaccinationId=1000;
        public string VaccinationID{get;}
        public string RegisterNumber{get;}
        public string VaccineID{get;}
        public DoseNumber DoseNumber{get;set;}
        public DateTime VaccinationDate{get;set;}
        public VaccinationClass(string registerNumber,string vaccineId,DoseNumber doseNumber,DateTime vaccinationDate)
        {
            s_vaccinationId++;
            VaccinationID="VID"+s_vaccinationId;
            RegisterNumber=registerNumber;
            VaccineID=vaccineId;
            DoseNumber=doseNumber;
            VaccinationDate=vaccinationDate;
        }
    }
}