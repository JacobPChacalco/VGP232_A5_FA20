using System;

// Main class of Assignment05
namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure of Assignment 5!");

            // Create a new character
            Character hero = new Character("Bob", RaceCategory.Human, 100);

            // Display hero enetering forest message
            Console.WriteLine("{0} has entered the forest", hero.mName );

            // Monster name and damage
            string monster = "goblin";
            int damage = 10;

            // Monster attacks hero message
            Console.WriteLine("A {0} appeared and attacks {1}", monster, hero.mName);

            // Hero takes damage message
            Console.WriteLine("{0} takes {1} damage", hero.mName, damage);

            // Take damage and write stats
            hero.TakeDamage(damage);
            Console.WriteLine(hero);

            // Hero combat fleeing message
            Console.WriteLine("{0} flees from the enemy", hero.mName);

            // Potion name and healing amount
            string item = "small health potion";
            int restoreAmount = 10;

            // Hero drinking potion message
            Console.WriteLine("{0} find a {1} and drinks it", hero.mName, item);

            // Hero restoring health message
            Console.WriteLine("{0} restores {1} health", hero.mName, restoreAmount);

            // Restore hero health
            hero.RestoreHealth(restoreAmount);

            // Write hero stats
            Console.WriteLine(hero);

            // If the hero is alive, display survived message
            if (hero.isAlive)
            {
                Console.WriteLine("Congratulations! {0} survived.", hero.mName);
            }
            // Else display hero dead message
            else
            {
                Console.WriteLine("{0} has died.", hero.mName);
            }
        }
    }
}
