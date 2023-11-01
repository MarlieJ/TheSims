using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class simsWorld
    {
        public BuildMode BuildMode { get; private set; }
        public FamilyMode FamilyMode { get; private set; }
        public PlayMode PlayMode { get; private set; }
        public simsWorld()
        {
            Console.WriteLine("Welcome to the Sims OP-edition! :D");
            mainMenu();
        }
        public void mainMenu()
        {
            bool runProgram = true;
            while (true) { 
            Console.WriteLine(" \nMAIN MENU: Type the number of the mode you want to play, and press enter:  \n1: Familymode, \n2: Buildmode, \n3: Playmode");
            string chosenMode = Console.ReadLine();//liten bokstav ved lokale variabler og private
            if (chosenMode == "1")
            {
                FamilyMode = new FamilyMode();
                FamilyMode.createFamily();
            }

            else if (chosenMode == "2")
            {
                BuildMode = new BuildMode();
                BuildMode.buildHouse();
            }
            else if (chosenMode == "3")
            {
                PlayMode = new PlayMode();

            }
            }
        }

    }


}
