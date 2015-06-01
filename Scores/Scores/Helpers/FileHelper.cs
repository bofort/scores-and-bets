using System;
using System.Configuration;
using System.IO;
using Scores.Models;

namespace Scores.Helpers
{
    /// <summary>
    /// Klasa odpowiedzialna za zapis danych do pliku
    /// </summary>
    public static class FileHelper
    {
        /// <summary>
        /// Metoda zapisująca strukture z ligami do pliku.
        /// </summary>
        /// <param name="mainStruct"></param>
        public static void SaveToFile(sMain mainStruct)
        {
            try
            {
                foreach (var league in mainStruct.League)
                {
                    using (var file = new StreamWriter(string.Format("{0}{1}.csv", ConfigurationManager.AppSettings["FilePath"], league.Name)))
                    {
                        foreach (var round in league.Rounds)
                        {
                            file.WriteLine(round.Name);

                            foreach (var match in round.Matches)
                            {
                                file.WriteLine(match.Date + "\t" + match.Status + "\t" + match.Home.Name + "\t" + match.HomeGoal + " - " + match.GuestGoal + "\t" + match.Guest.Name);
                            }

                            file.WriteLine("\n\n");
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Błąd zapisu do pliku. Błąd:{0}\nStack trace:{1}\n", exception.Message, exception.StackTrace);
            }
        }

    }
}
