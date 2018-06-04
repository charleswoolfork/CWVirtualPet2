using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        // DECLARING FIELDS

        string ownersName;
        string petsName;
        int hunger;
        int thirst;
        int bathroomNeed;
        int energy;
        int affection;

        //DECLARING CONSTRUCTORS

        public VirtualPet()//DEFAULT CONSTRUCTOR
        {

        }
        public VirtualPet(string ownersName, string petsName)//LOADED CONSTRUCTOR 1
        {
            this.ownersName = ownersName;
            this.petsName = petsName;
        }
        public VirtualPet(int hunger, int thirst, int bathroom, int energy, int affection)//LOADED CONSTRUCTOR 2
        {
            this.hunger = hunger;
            this.thirst = thirst;
            this.bathroomNeed = bathroom;
            this.energy = energy;
            this.affection = affection;
        }


        // DECLARING PROPERTIES
        public string OwnersName
        {
            get { return this.ownersName; }
            set { this.ownersName = value; }
        }


        public string PetsName
        {
            get { return this.petsName; }
            set { this.petsName = value; }
        }

        public int Hunger
        {
            get
            {
                return this.hunger;

            }
            set
            {
                this.hunger = value;
                if (this.hunger < 0)
                {
                    this.hunger = 0;
                }
                if (this.hunger > 100)
                {
                    this.hunger = 100;
                }
            }

        }
        public int Thirst
        {
            get { return this.thirst; }

            set
            {
                this.thirst = value;
                if (this.thirst < 0)
                {
                    this.thirst = 0;
                }
                if (this.thirst > 100)
                {
                    this.thirst = 100;
                }
            }
        }

        public int BathroomNeed
        {
            get { return this.bathroomNeed; }

            set
            {
                this.bathroomNeed = value;
                if (this.bathroomNeed < 0)
                {
                    this.bathroomNeed = 0;
                }
                if (this.bathroomNeed > 100)
                {
                    this.bathroomNeed = 100;
                }
            }
        }

        public int Energy
        {
            get { return this.energy; }

            set
            {
                this.energy = value;
                if (this.energy < 0)
                {
                    this.energy = 0;
                }
                if (this.energy > 100)
                {
                    this.energy = 100;
                }
            }
        }
        public int Affection
        {
            get { return this.affection; }

            set
            {
                this.affection = value;
                if (this.affection < 0)
                {
                    this.affection = 0;
                }
                if (this.affection > 100)
                {
                    this.affection = 100;
                }
            }
        }

        public double PetHappiness //this property takes the average of the virtual puppy's needs and subtracts it from 100 to get the pet's level of happiness. It will be used in main to determine the end of the game. 
        {
            get { return 100 - ((this.Hunger + this.Thirst + this.BathroomNeed + this.Affection + this.Energy) / 5); }

        }





        public void GetStatus()
        {
            Console.WriteLine("{0}  the virtual puppy:", this.PetsName);
            Console.WriteLine("\tis {0}% hungry.", this.Hunger);
            Console.WriteLine("\tis {0}% thirsty.", this.Thirst);
            Console.WriteLine("\thas a {0}% need to go to the bathroom.", this.BathroomNeed);
            Console.WriteLine("\tis {0}% energetic.", this.Energy);
            Console.WriteLine("\tis {0}% lonely.", this.Affection);
            Console.WriteLine();
        }


        //DECLARING METHODS

        public void FeedPuppy()
        {
            this.Hunger -= 50;
            this.BathroomNeed += 20;
            this.Energy += 10;
            this.Thirst += 30;

            Console.WriteLine("{0} says, \"Bacon! Nom Nom Nom!\"", this.PetsName);
        }

        public void WaterPuppy()
        {
            this.Thirst -= 80;
            this.BathroomNeed += 20;

            Console.WriteLine("{0} says, \"Bark! Bark! Bark!\"", this.PetsName);
        }

        public void Bathroom()
        {
            this.BathroomNeed -= 90;
            this.Energy -= 10;

            Console.WriteLine("{0} says, \"Puppy pees on tree!\"", this.PetsName);
        }

        public void RubPuppy()
        {
            this.Energy -= 30;
            this.Affection -= 40;
            this.BathroomNeed += 10;

            Console.WriteLine("{0} says, \"Puppy licks your face!\"", this.PetsName);
        }

        public void PlayWithPuppy()
        {
            this.Energy -= 60;
            this.Affection -= 60;

            Console.WriteLine("{0} says, \"Bark! Bark! Bark!\"", this.PetsName);
        }

    }//CLASS
}//NAMESPACE
