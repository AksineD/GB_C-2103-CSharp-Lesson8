// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AmazingConApp
{
    #region

    using System;

    using AmazingConApp.Properties;

    #endregion

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            if (string.IsNullOrWhiteSpace(Settings.Default.IsKnown))
            {
                Console.WriteLine(Settings.Default.GreetingsUnknow);

                if (string.IsNullOrWhiteSpace(Settings.Default.Name))
                {
                    Console.WriteLine(Settings.Default.GetName);
                    Settings.Default.Name = Console.ReadLine();
                }

                if (string.IsNullOrWhiteSpace(Settings.Default.Age))
                {
                    Console.WriteLine(Settings.Default.GetAge);
                    Settings.Default.Age = Console.ReadLine();
                }

                if (string.IsNullOrWhiteSpace(Settings.Default.Occupation))
                {
                    Console.WriteLine(Settings.Default.GetOccupation);
                    Settings.Default.Occupation = Console.ReadLine();
                }

                Settings.Default.IsKnown = "yes";
                Settings.Default.Save();
            }

            Console.WriteLine($"{Settings.Default.Greetings} {Settings.Default.Name}!");

            Console.WriteLine("press any key to exit");
            Console.ReadLine();
        }
    }
}