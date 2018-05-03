using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9List
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();
            Names.Add("Charizard");
            Names.Add("Pikachu");
            Names.Add("Blastoise");
            Names.Add("Articuno");
            Names.Add("Alakazam");
            Names.Add("Pidgey");

            List<string> Country = new List<string>();
            Country.Add("Bangladesh");
            Country.Add("India");
            Country.Add("Sri Lanka");
            Country.Add("Pakistan");
            Country.Add("United States");
            Country.Add("China");

            List<string> Food = new List<string>();
            Food.Add("Biryani");
            Food.Add("Fried Chicken");
            Food.Add("Boar Ragu");
            Food.Add("Pralines and Cream - Ice Cream");
            Food.Add("Lasagna");
            Food.Add("Pizza");

            List<string> BasketballPlayer = new List<string>();
            BasketballPlayer.Add("Lebron James");
            BasketballPlayer.Add("Kyrie Irving");
            BasketballPlayer.Add("Anthony Davis");
            BasketballPlayer.Add("James Harden");
            BasketballPlayer.Add("Kobe Bryant");
            BasketballPlayer.Add("Allen Iverson");

            Greet();
            bool go = true;
            while (go)
            {
                try
                {
                    bool goagain = true;
                    while (goagain)
                    {
                        string input = "";

                        Console.WriteLine($"Please enter a number from 1-{Names.Count} to learn about a Pokemon or type \"p\" to enter in new Pokemon data or type \"quit\" to exit.");
                        input = Console.ReadLine();
                        bool statement = int.TryParse(input, out int index);
                        index--;

                        if ( index > -1 && index < Names.Count)
                        {
                            Console.WriteLine($"Pokemon {input} is {Names[index]}.\nWould you like to learn {Names[index]}'s Country(c), favorite Food(f), favorite Basketball Player(b) or everything(e)?");

                            string input2 = Console.ReadLine().ToLower();
                            if (input2 == "c" || input2 == "country")
                            {
                                Console.WriteLine($"{Names[index]} is from {Country[index]}./nWould you like to know {Names[index]}'s favorite food(f) or favorite Basketball Player(b)?");
                            }
                            else if (input2 == "f" || input2 == "food")
                            {
                                Console.WriteLine($"{Names[index]}'s favorite food is {Food[index]}. /nWant to know more?(yes or no");
                            }
                            else if (input2 == "b" || input2 == "basketball")
                            {
                                Console.WriteLine($"{Names[index]}'s favorite basketball player is {BasketballPlayer[index]}");
                            }
                            else if (input2 == "e" || input2 == "everything")
                            {
                                Console.WriteLine($"{Names[index]} is from {Country[index]}, his/her favorite food is {Food[index]}, and his/her favorite basketball player is {BasketballPlayer[index]}!");
                            }
                            else
                            {
                                Console.WriteLine("You have entered invalid information!");
                            }
                        }
                        else if (input == "p")
                        {
                            Console.WriteLine("Please add a new Pokemon to the index.");
                            Console.Write("Name:"); Names.Add(Console.ReadLine());
                            Console.Write("Country:"); Country.Add(Console.ReadLine());
                            Console.Write("Favorite Food:"); Food.Add(Console.ReadLine());
                            Console.Write("Favorite Basketball Player:"); BasketballPlayer.Add(Console.ReadLine());
                            goagain = false;
                        }
                        else if (input == "quit")
                        {
                            goagain = false;
                            go = false;
                            Console.WriteLine("Have a great day!");

                        } 
                    }
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Input out of range!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please try again!");
                }
            }
        }
        static void Greet()
        {
        Console.WriteLine("Welcome to the Pokemon Index! Look up or add specific Pokemon information!");
        }
    }
}
