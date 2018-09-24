using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    class VirtualPet
    {

        //fields
        private string name = "Horace the Hippo";
        private int hunger;
        private int thirst;
        private int boredom;
        private int tiredness;
        private int health = 100;

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }
        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }
        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }
        public int Tiredness
        {
            get { return this.tiredness; }
            set { this.tiredness = value; }
        }
        public int Health
        {
            get { return this.health; }
            set { this.tiredness = health; }
        }

        //constructors
        public VirtualPet()
        {

        }

        //methods
        public void Feed()
        {
            if (hunger > 50)
            {
                hunger = hunger - 50;
            }
            else
            {
                hunger = hunger / 2;
            }

            Status(); 
        }

        public void Water()
        {
            if (thirst > 50)
            {
                thirst = thirst - 50;
            }
            else
            {
                thirst = thirst / 2;
            }
            Status();
        }

        public void Play()
        {
            if (boredom > 50)
            {
                boredom = boredom - 50;
            }
            else
            {
                boredom = boredom / 2;
            }
            Status();
        }
        public void PutToSleep()
        {
            if (tiredness > 50)
            {
                tiredness = tiredness - 50;
            }
            else
            {
                tiredness = tiredness / 2;
            }
            Status();
        }
        public void Tick()
        {
            Random random = new Random();
            int notFed = random.Next(1, 15);
            int notWatered = random.Next(1, 15);
            int notPlayed = random.Next(1, 15);
            int notPutToSleep = random.Next(1, 15);

            hunger = hunger + notFed;
            if ( hunger > 100 )
            {
                hunger = 100;
            }
            thirst = thirst + notWatered;
            if (thirst > 100)
            {
                thirst = 100;
            }
            boredom = boredom + notPlayed;
            if (boredom > 100)
            {
                boredom = 100;
            }
            tiredness = tiredness + notPutToSleep;
            if (tiredness > 100)
            {
                tiredness = 100;
            }
            if ((hunger == 100)||(thirst == 100))
            {
                health = health - 10;
                if (health < 0)
                {
                    health = 0;
                    //Status();
                    Console.WriteLine("The Hippo is dead. You shouldn't have any pets.");
                    Environment.Exit(0);
                }
            }

        }
        public void Status()
        {
            Console.WriteLine("Hunger: {0}, Thirst: {1}, Boredom: {2}, Tiredness: {3}, Health: {4}", Hunger, Thirst, Boredom, Tiredness, Health);
        }
    }
}
