using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    // Race enum
    public enum RaceCategory 
    {
        Elf, 
        Orc, 
        Human 
    }

    public class Character
    {
        public string mName { get; set; }
        public RaceCategory mRace { get; set; }
        public int mHealth { get; set; }
        public int mMaxHealth { get; set; }
        public bool isAlive { get; set; }


        // Default constructor
        public Character() {}

        // Parameters Constructor
        public Character(string name, RaceCategory race, int hp)
        {
            mName = name;
            mMaxHealth = hp;
            mHealth = mMaxHealth;
            mRace = race;
            isAlive = true;
        }

        // Reduce the health by the damage specified to character
        // If the damage taken is more than the health then the IsAlive is set to false.
        public void TakeDamage(int damage)
        {
            // If the character is alive, reduce his health by the damage amount
            if (isAlive == true)
            {
                mHealth -= damage;
            }

            // If the character health is smaller than 0, set our isAlive bool to false
            if (mHealth < 0)
            {
                isAlive = false;
            }          
        }

        // Restore the health of the player by the amount specified up to the max health.
        public void RestoreHealth(int amount)
        {
            // If the player health is equal to the maxHealth or if the player us dead, dont do anything
            if (mHealth == mMaxHealth || isAlive == false)
            {
                return;
            }

            // Else if the health + amount recovered equals or is bigger than maxHealth, set player health to maxHealth
            else if(mHealth + amount >= mMaxHealth)
            {
                mHealth = mMaxHealth;
            }

            // Else increase health by amount given
            else
            {
                mHealth += amount;
            }
        }

        // Display the character name, race and health in a string format
        public override string ToString()
        {
            return string.Format("{0} : {1} - HP {2}/{3} ", mName, mRace, mHealth, mMaxHealth);
        }
    }
}
