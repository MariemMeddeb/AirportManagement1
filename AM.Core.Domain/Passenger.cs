using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public  class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public IList<Flight> Flights { get; set; }
        //public int Age { get; set; }
        //Question 14
        //l'attribut age doit etre privé
        int age;
       
        
        public int Age 
        {
            get
            {
                age = DateTime.Now.Year - BirthDate.Year;
                if (BirthDate.Month > DateTime.Now.Month)
                {
                    age -= 1;
                }
                else if (BirthDate.Month == DateTime.Now.Month && BirthDate.Day > DateTime.Now.Day)
                {
                    age--;
                }
                    return age;
            }
        }
//TP1.question 11.a.b
//       public bool CheckProfile(string nom, string prenom)
//        {
//            return FirstName== prenom && LastName == nom;
//        }
//
//        public bool CheckProfile(string email, string nom, string prenom)
//        {
//            return EmailAddress == email && LastName== nom && FirstName == prenom;
//        }



//TP1.question 11.c

        public bool CheckProfile(string nom, string prenom, string email=null)
        {
            return EmailAddress == email && LastName == nom && FirstName == prenom;
        }
p
 //TP1.question 12.a
 //virtual maaneha ynajem ybadel feha f l classe fille 
        public virtual string GetPassengerType()
        {
            return "Im a Passenger";
        } 

        //tp1.Q13
        public void GetAge(DateTime birthDate, ref int calculateAge)
        {
            calculateAge = DateTime.Now.Year - birthDate.Year;
            if (birthDate.Month > DateTime.Now.Month)
            {
                calculateAge = calculateAge - 1;
            }
            else if (birthDate.Month == DateTime.Now.Month && birthDate.Day > DateTime.Now.Day)
            {
                calculateAge = calculateAge - 1;
            }
         
        }

   //    public void GetAge(Passenger aPassenger)
   //    {
   //            aPassenger.Age = DateTime.Now.Year - aPassenger.BirthDate.Year;
   //            if (aPassenger.BirthDate.Month > DateTime.Now.Month)
   //            {
   //                aPassenger.Age -= 1;
   //            }
   //            else if (aPassenger.BirthDate.Month == DateTime.Now.Month && aPassenger.BirthDate.Day > DateTime.Now.Day)
   //            {
   //                aPassenger.Age--;
   //            }
   //        }
   //    public int getAge()
    //    {
    //        return Age;
    //    }
    //

        public override string ToString()
        {
            return "BirthDate:" + BirthDate + ";PassportNumber:" + PassportNumber + ";EmailAddress:" + EmailAddress + ";FirstName:" + FirstName + ";LastName:" + LastName + ";TelNumber:" + TelNumber;
        }

    }
}
