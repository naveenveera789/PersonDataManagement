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
            listPersonsInCity.Add(new Person("173062021", "Rambabu", "Vijayawada, Andhra Pradesh", 17));
            listPersonsInCity.Add(new Person("173072021", "Johnson", "Guntur, Andhra Pradesh", 21));
            listPersonsInCity.Add(new Person("173082021", "Praveen", "Vijayawada, Andhra Pradesh", 69));
            listPersonsInCity.Add(new Person("173092021", "Madhu", "Gannavaram, Andhra Pradesh", 14));
            listPersonsInCity.Add(new Person("173102021", "Anudeep", "Gudivada, Andhra Pradesh", 44));
        }
        public void RetreivingTopTwoRecords_ForAgeIs_LessThanSixty(List<Person> listPersonsInCity)
        {
            Console.WriteLine("The Top 2 persons whose age less than 60 are : ");
            foreach (Person person in listPersonsInCity.FindAll(x => (x.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        public void CheckingForTeenagerPerson(List<Person> listPersonsInCity)
        {
            Console.WriteLine("The Teenagers Persons in the list are : ");
            foreach(Person person in listPersonsInCity.FindAll(x => (x.Age >= 13 && x.Age < 19)).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        public void RetrieveAverageAge(List<Person> listPersonsInCity)
        {
            double averageAge = listPersonsInCity.Average(x => x.Age);
            Console.WriteLine("The Average age of all Persons in the list are : " + averageAge);
        }
        public void CheckingForSpecificName(List<Person> listPersonsInCity)
        {
            Console.WriteLine("Enter the name you want to check in the list : ");
            string search = Console.ReadLine();
            if(listPersonsInCity.Exists(e => e.Name == search))
            {
                Console.WriteLine("Yes, The Name {0} is Present in the list",search);
            }
            else
            {
                Console.WriteLine("No, The Name {0} is not Present in the list",search);
            }
        }
        public void SkipRecord_ForAge_LessThanSixty(List<Person> listPersonsInCity)
        {
            Console.WriteLine("The List after Skipping record for age less than 60 : ");
            foreach(Person person in listPersonsInCity.Where(x => x.Age > 60))
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
    }
}