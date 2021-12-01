using System;

namespace OOPPet
{
    class Program
    {
        class Pet
        {
            string name;
            int age;
            double weight;


            public Pet(string _name, int _age)
            {
                name = _name;
                age = 0;
                weight = 0;
                Console.WriteLine($"Yoo, you adopted {name}.");
            }
            public void ShowPetinfo()
            {
                Console.WriteLine($"Name: {name}.");
                Console.WriteLine($"Age: {age}.");
                Console.WriteLine($"Weight: {weight}.");
            }
            public double Weight
            {
                get { return Weight; }
            }
            public void Eat()
            {
                Console.WriteLine("yum-yum");
                weight += 0.2;
            }
            public void Run()
            {
                Console.WriteLine("I'm fast as fuck boy, runs.");
                weight -= 0.1;
            }
        }
            
        
        static void Main(string[] args)
        {
            Pet myPet = new Pet($"Hamster", 0);
            myPet.ShowPetinfo();
            for(int i = 0; i > 11; i++)
            {
                myPet.Eat();
                Console.WriteLine($"Your current weight; {myPet.Weight}");
                if(myPet.Weight > 0.7) 
                {
                    myPet.Run();
                }
            }
            myPet.ShowPetinfo();

        }
    }
}
