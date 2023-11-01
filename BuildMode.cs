using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class BuildMode
    {
        public House House { get; private set; }
        public BuildMode()
        {
            
        }
        public void buildHouse()
        {
            Console.WriteLine("Let's build a house. What's the name of the street? Type the name and press enter:");
            string streetName = Console.ReadLine();
            Console.WriteLine("What is the housenumber? Type the number and press enter");
            int streetNr = Convert.ToInt32(Console.ReadLine());
            House = new House(streetName, streetNr);
            Console.WriteLine("Your standardhouse is one floor and comes with 5 rooms: " ) ;
            House.printList();
            Console.WriteLine("Do you want to add more rooms, or another floor?, type yes or no and press enter");
            string answer = Console.ReadLine();
            if ( answer.ToLower() == "yes")
            {
                House.createRooms();
                House.RoomsToFloor();
            }
            else
            {

            }
            Console.WriteLine("You're now ready to furnish your house.");
        }

    }

}
