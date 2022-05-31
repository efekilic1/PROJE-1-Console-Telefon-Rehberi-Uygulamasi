using System;
namespace ProjectTelephoneDirectory
{
    public class contactCard
    {

        public string name;
        public string surname;
        public string number;
        
        public string Name { get => name; set => name = value; }
        public string Surname { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }

        public contactCard(string Name, string Surname, String Number)
        {
            this.name = Name;
            this.surname = Surname;
            this.number = Number;
        }

        public contactCard()
        {

        }


    }
}
