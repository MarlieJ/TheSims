using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class FamilyMode
    {
        public List<Family> Families { get; private set; }
       // public simsWorld World { get; private set; }//#1er det riktig at jeg la inn denne her? Fordi benytter ikke allerede FamilyMode klassen seg av simsWorld? Hvorfor må jeg da refere til den på nytt?
        public FamilyMode()
        {
            Families = new List<Family>();
           // World = world;//jeg peker til en referanse av et objekt som allerede finnes

        }
        public void createFamily()
        {
            Console.WriteLine("Familymode chosen. Create a Family. What is the lastname of the family? Type the lastname and press enter:");
            string lastName = Console.ReadLine();
            var Family = new Family(lastName);
            Families.Add(Family);
            bool newChar = true;
            do
            {
                newChar = createCharacter(Family);

            }
            while (newChar == true);
            //leavFamilyMode();
        }
        public bool createCharacter(Family Family)
        {
            Console.WriteLine("Create one or more characters. We'll start with the first. Type the name of the player and press enter:");
            string name = Console.ReadLine();
            Console.WriteLine("What age is the player? Insert and press enter:");
            int age = Convert.ToInt32(Console.ReadLine());
            Character character = new Character(name, age);
            Family.addFamilyMember(character);
            Console.WriteLine("Do you wanna add another character? Press enter, if not type X:");
            string answer = Console.ReadLine();
            if (answer == string.Empty)
            { return true; }
            else { return false; }
        }
        //public void leavFamilyMode()
        //{
        //    World.mainMenu();//#1
        //}



    }
}
