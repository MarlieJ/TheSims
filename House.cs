using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class House
    {
        public string StreetName { get; private set; }
        public int StreetNr { get; private set; }
        public Floor Floor { get; private set; }
        public List<Room> Rooms { get; private set; }
        public BuildMode BuildMode { get; private set; }
        //Marlenes tanke: så lenge jeg deklarer properties i klassen, så må jeg sende de inn i ctor. 
        //Marie avkrefter hvorfor det ikke er sånn/hvordand det fungerer: 
        //Properties definerer alt som skal være tilgjengelig innenfor klassen på et eller annet tidspunkt. 
        //      !!!!    Det eneste man trenger å sende i ctor er det man definerer på utsiden av klassen.   !!!!!!!
        //I dette tilfellet er det streetName og Number som man spør om utenfor klassen. Alt det andre kan lages underveis.
        // Man kan også bruke ctor til å legge inn startverdier, som kan endre seg underveis i metoder. Da kommer de ikke utenfra klassen. 

        public House(string streetName, int streetNr) //ctor er en metode, så her implementerer jeg allerede parameterne til house, så derfor trenger jeg ikke denne #1
        {
            StreetName = streetName;
            StreetNr = streetNr;
            Rooms = new List<Room>
            {
                new Room("Kjøkken"),
                new Room("Bad"),
                new Room("Stue"),
                new Room("Vaskerom"),
                new Room("Soverom")
            };
            //Room = new Room[] { new Room("Kitchen"), new Room("Livingroom") };
            
        }
        //public void createStreetNameAndNum(string streetname, int streetNr)        #1
        //{
        //    StreetName = streetname;
        //    StreetNr = streetNr;
        //    createRoomsInHouse();
        //}
        public void printList()
        {
            int counter = 0;
            foreach (Room room in Rooms)
            {
                Console.WriteLine($"{room.Name}  {counter}");
            }
        }
        public void createRooms()
        {
            Console.WriteLine("Add rooms. Type the name and press enter. When you're done adding rooms, type x.");
            bool addRooms = true;
            while (addRooms) {
                Console.WriteLine("Add room  /  X   :");
                string roomToAdd = Console.ReadLine();
                if (roomToAdd.ToLower() != "x")
                {
                    Room newRoom = new Room(roomToAdd);
                    Rooms.Add(newRoom);
                }
                else { addRooms = false; }
            }
            createFloor();

        }

        public void createFloor()
        {
                List<Floor> floorList = new List<Floor>();
                Console.WriteLine("How many floors do you want in total? Type a number and press enter:");
                int floorToAdd = Convert.ToInt32(Console.ReadLine());//input = 4
                for (int i = 0; i < floorToAdd; i++) {
                int tall = i;
                Floor floor = new Floor(i);
                floorList.Add(floor);
                }
            RoomsOrganizedToFloor(floorList);
            
        }
        public void RoomsOrganizedToFloor(List<Floor> floorlist)
        {
            Console.WriteLine($"You have {floorlist} floors. Lets organize the rooms to the floors.");
            for (int i = 0; i < Floor.FloorNumber; i++)
            {

               // Console.WriteLine($"You're on floor {i}, what rooms do you want to add? Choose one room and press enter");
               ////tips : while.
               // printList();
               // int answer = Convert.ToInt32(Console.ReadLine());
               // Rooms.RemoveAt(answer);
            }
            //RoomsToFloor: Hva skal den gjøre? Sortere rom til de ulike etasjene.
            //Printe etasje 1. "HVilke rom vil du ha her"?
            //Printe rommene jeg kan velge mellom i etasje 1.
            //Velge rom i etasje 1.
            //Minusere rommene som er valgt fra listen, brukeren trenger ikke se det.
            //(Gi oppdatering til brukeren om hvilke rom som er valgt i etasjen.)
            //Printe etasje 2.
            //Printe gjenværende rom på en liste. 
            //Velge rom til etasje 2. 
            //repeat.
            //Når den sist etasjen er valgt, må resten av rommene bli brukt opp? Hvis det ikke er flere rom skal rommet være uinnredet?
            //Når jeg har gått gjennom alle etasjene skal jeg møblere.


            //Printe etasje med rom. Velge rom.
            //Velge møbler til rom. Velge funksjoner her?? Standardfunksjoner??
        }
    }
}
