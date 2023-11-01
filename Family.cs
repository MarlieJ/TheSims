using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class Family
    {
        public List<Character> FamilyCharacters { get; private set; }
        public string LastName { get; private set; }

        public Family(string lastName)
        {
            FamilyCharacters = new List<Character>();
            LastName = lastName;
        }
        public void addFamilyMember(Character character)
        {
            FamilyCharacters.Add(character);
            Console.WriteLine($"You now added {character.Name} to the {LastName} family");
        }



        //new family? Burde jeg newe en familie her? Hvordan vet jeg hvem som er i hvilken familie?
    }
}
