using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet horacethehippo = new VirtualPet();
            Random random = new Random();
            int points = random.Next(1, 101);
            int action;
            bool alive = true;
            horacethehippo.Hunger = random.Next(1, 101);
            horacethehippo.Thirst = random.Next(1, 101);
            horacethehippo.Boredom = random.Next(1, 101);
            horacethehippo.Tiredness = random.Next(1, 101);

            Console.WriteLine(horacethehippo.Name);
            horacethehippo.Status();
            while (alive)
            {
                Console.WriteLine("\nWhat do you want to do?");
                Console.WriteLine("Press 1 to feed\nPress 2 to water\nPress 3 to play\nPress 4 to put to sleep\nPress 5 to do nothing");
                action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        Console.WriteLine("You fed Horace.");
                        horacethehippo.Feed();
                        break;
                    case 2:
                        Console.WriteLine("You watered Horace.");
                        horacethehippo.Water();
                        break;
                    case 3:
                        Console.WriteLine("You played with Horrace");
                        horacethehippo.Play();
                        break;
                    case 4:
                        Console.WriteLine("You put Horace to sleep");
                        horacethehippo.PutToSleep();
                        break;
                    default:
                        Console.WriteLine("You didn't do anything.");
                        horacethehippo.Status();
                        break;


                }
                Console.WriteLine();
                if (horacethehippo.Health != 0)
                {
                    Console.WriteLine("Some time later...");
                }
                horacethehippo.Tick();
                    
            }
        }
    }
}
