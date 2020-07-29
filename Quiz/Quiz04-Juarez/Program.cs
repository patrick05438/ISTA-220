using System;

namespace Quiz04_Juarez
{
    class Firearm
    {
        public void fire(string name, string noise)
        {
            Console.WriteLine($"I am a {name} and I go {noise}.");
        }
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("This is Quiz 04");
                Firearm Shotgun = new Firearm();
                Shotgun.fire("Shotgun", "Boom");
                Firearm Rifle = new Firearm();
                Rifle.fire("Rifle", "Bang");
                Firearm Pistol = new Firearm();
                Pistol.fire("Pistol", "Pop");
                Console.WriteLine("                  ");
                Console.WriteLine("This is Quiz 04");
                Firearm Howitzer = new Firearm();
                Howitzer.fire("Howitzer", "Boom");
                Firearm BigGuns = new Firearm();
                BigGuns.fire("Big Guns", "Boom Boom");
                Firearm LilGuns = new Firearm();
                LilGuns.fire("Lil Guns", "To the 82nd");

            }
        }
    }
}
