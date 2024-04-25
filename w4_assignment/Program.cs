using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w4_assignment {
    class Program {
        static void Main (string[] args) { 

            //create a person structure and display the stored data
            Person person = new Person()
            {
                FirstName = "John",
                MiddleName = "John",
                LastName = "John",
                Street1 = "123 John St",
                Street2 = "Apt 1",
                City = "Cool town",
                State = "YippieVille",
                Zip = "54643",
                Phone = "401-777-7777",
                Email = "johnIsCool@gmail.com"
            };

            //output
            Console.WriteLine("Person Information:");
            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Middle Name: {person.MiddleName}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine($"Street 1: {person.Street1}");
            Console.WriteLine($"Street 2: {person.Street2}");
            Console.WriteLine($"City: {person.City}");
            Console.WriteLine($"State: {person.State}");
            Console.WriteLine($"Zip: {person.Zip}");
            Console.WriteLine($"Phone: {person.Phone}");
            Console.WriteLine($"Email: {person.Email}");

            //convert the structure to a class with public properties woooooooooooooo
            PersonClass personClass = new PersonClass()
            {
                FirstName = "John",
                MiddleName = "Doe",
                LastName = "Smith",
                Street1 = "123 Main St",
                Street2 = "Apt 101",
                City = "Cityville",
                State = "Stateville",
                Zip = "12345",
                Phone = "555-123-4567",
                Email = "john@example.com"
            };

            //display first name
            Console.WriteLine("\nOriginal First Name:");
            Console.WriteLine($"First Name: {personClass.FirstName}");

            //change first name (weakness)
            personClass.FirstName = "caca " + personClass.FirstName;

            //displaying modified first name
            Console.WriteLine("\nModified First Name (with weakness of public properties):");
            Console.WriteLine($"First Name: {personClass.FirstName}");

            //convert public properties to private 
            personClass.SetFirstName("John");
            Console.WriteLine("\nPrivate Properties with Accessors and Mutators:");
            Console.WriteLine($"First Name: {personClass.GetFirstName()}");
        }
    }

    //person structure
    struct Person
    {
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string Street1;
        public string Street2;
        public string City;
        public string State;
        public string Zip;
        public string Phone;
        public string Email;
    }

    //person class with private properties 
    class PersonClass
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string email;

        //lifetime amount of getter setter (please help)
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Street1
        {
            get { return street1; }
            set { street1 = value; }
        }

        public string Street2
        {
            get { return street2; }
            set { street2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //private properties getter setter
        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }
         
        
    }
}