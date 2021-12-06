using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonDataManagement
{
    public class DataManagement
    {
        public void AddRecords(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("173012021", "Naveen", "Krishna, Andhra Pradesh", 21));
            listPersonsInCity.Add(new Person("173022021", "Kishore", "Gudivada, Andhra Pradesh", 20));
            listPersonsInCity.Add(new Person("173032021", "Surya", "Uyyuru, Andhra Pradesh", 65));
            listPersonsInCity.Add(new Person("173042021", "Narayan", "Vizag, Andhra Pradesh", 27));
            listPersonsInCity.Add(new Person("173052021", "Durga", "Uyyuru, Andhra Pradesh", 80));
            listPersonsInCity.Add(new Person("173062021", "Rambabu", "Vijayawada, Andhra Pradesh", 40));
            listPersonsInCity.Add(new Person("173072021", "Johnson", "Guntur, Andhra Pradesh", 21));
            listPersonsInCity.Add(new Person("173082021", "Praveen", "Vijayawada, Andhra Pradesh", 69));
            listPersonsInCity.Add(new Person("173092021", "Madhu", "Gannavaram, Andhra Pradesh", 24));
            listPersonsInCity.Add(new Person("173102021", "Anudeep", "Gudivada, Andhra Pradesh", 44));
        }
        public void RetreivingTopTwoRecords_ForAgeIs_LessThanSixty(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(x => (x.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
    }
}