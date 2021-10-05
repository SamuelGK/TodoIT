using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIT.Models
{
    public class Person
    {
        readonly int personId;

        string firstName;
        string lastName;
        
        public int Personid
        {
            get { return personId; }
        }

        public string Firstname
        {
            get { return firstName; } 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                firstName = value;


            }
        }

        public string Lastname
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                lastName = value;
            }

        } 

        public string Fullname
        {
            get
            {
                return firstName + " " + lastName;
            }

        } 

        public Person(int id, string firstName, string lastName  ) 
        {
            personId = id;
            Firstname = firstName;
            Lastname = lastName;
        }

    } // end of person 
}
