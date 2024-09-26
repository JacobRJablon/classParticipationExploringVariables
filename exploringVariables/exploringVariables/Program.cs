namespace exploringVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string heroFirstName = "Jacob";
            string heroLastName = "Jablon";
            string heroFullName;
            string villianTitle = "World's Greatest Thief";
            string minionTitle = "Helpful Sidekick";
            string villianName;
            string minion1Name;
            string minion2Name;

            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;

            //Begin Code Instructions
            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold the legendary hero of programming, whose name is: " + heroFullName);

            villianName = "Gru";
            minion1Name = "Bob";
            minion2Name = "Kevin";

            Console.WriteLine(heroFullName + " must stop " + villianName + ", the " + villianTitle + ", from stealing the Moon!");

            //Don't forget about the minions
            Console.WriteLine(villianName + " is getting help from his trusty minions, " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name + ".");

            //Are you prepared to fight!?
            Console.WriteLine("The fighters enter the room!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            Console.WriteLine("Minion 1's health: " + minion1Health);
            Console.WriteLine("Minion 2's health: " + minion2Health);

            //Time to fight

            //Baddies attack our hero! Oh no!
            //Boss attacks first
            Console.WriteLine(villianName + ", the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + ", the " + villianTitle + " deals " + bossStrength + " damage!");
            //Take the current health, subtract the damage then store the new value back into health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            //Minions attack
            Console.WriteLine("The evil minions attack!");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage!");
            //Take the current health, subtract the damage then store the new value back into health
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage!");
            //Take the current health, subtract the damage then store the new value back into health
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Hero turn to attack
            Console.WriteLine(heroFullName + " attacks each villian for " + heroStrength + " damage!");
            //do math
            //Take the current health, subtract the damage then store the new value back into health
            //but this time lets use the combination assignment and arithemtic operator
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;

            //Display results in console
            Console.WriteLine(villianName + ", the " + villianTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " health!");

            //The minions have been defeated!
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated!");

            //End of round buff!
            Console.WriteLine(heroFullName + " has " + heroHealth + " health!");
            Console.WriteLine(heroFullName + " eats a banana to restore health!");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //final round of fight
            Console.WriteLine("The remaining fighters continue the fight!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            //Boss attacks first
            Console.WriteLine(villianName + ", the " + villianName + " attaks " + heroFullName);
            Console.WriteLine(villianName + ", the " + villianName + " deals " + bossStrength + " damage!");
            //Take the current health, subtract the damage then store the new value back into health
            heroHealth -= bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            //Hero turn to attack!
            Console.WriteLine(heroFullName + " attacks " + villianName + " the " + villianTitle + " for " + heroStrength + " damage!");
            //do math
            bossHealth = bossHealth - heroStrength;
            //Display results in the console
            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossHealth + " health!");

            //Results
            Console.WriteLine(heroFullName + " is victorious!");
            Console.WriteLine("Wealth, glory, and straight A+'s to the winner!");
        }
    }
}
