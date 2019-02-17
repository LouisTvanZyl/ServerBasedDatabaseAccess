using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    [Serializable]
    public class Person
    {
       
        public Person(int id, string initials, string name, string surname, string email, string number)
        {
            this.clientId = id;
            this.initials = initials;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.number = number;

        }
        public Person( string initials, string name, string surname, string email, string number)
        {
            
            this.initials = initials;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.number = number;

        }

        public Person()
        {

        }

        private int clientId;

        public int ClientID
        {
            get { return clientId; }
            set { clientId = value; }
        }

        private string initials;

        public string Initials
        {
            get { return initials; }
            set { initials = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }












    }
}
