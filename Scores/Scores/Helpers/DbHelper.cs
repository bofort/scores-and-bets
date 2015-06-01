using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using Scores.Models;

namespace Scores.Helpers
{
    /// <summary>
    /// Klasa odpowiedzialna za zapis do bazy danych
    /// </summary>
    public static class DbHelper
    {
        /// <summary>
        /// Metoda zapisuje strukture do bazy
        /// </summary>
        /// <param name="mainStruct"></param>
        public static void SaveToDataBase(sMain mainStruct)
        {

            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ScoresDB"].ToString());

            try
            {

                connection.Open();

                var cmd = new SqlCommand(@"UPDATE dbo.MATCH SET HOME_GOAL = @HOMEG, GUEST_GOAL = @GUESTG, STATUS = @STATUS, DATE = @DATE WHERE
                                                            HOME_TEAM = @HOMET and GUEST_TEAM = @GUESTT and ID_ROUND = @ID_ROUND and ID_LEAGUE = 
                                                                (SELECT ID FROM dbo.LEAGUE WHERE NAME  = @LEAGUE_NAME)", connection);

                foreach (var league in mainStruct.League)
                {
                    foreach (var round in league.Rounds)
                    {
                        var roundRegex = new Regex(@"[0-9]+");
                        var idRound = Convert.ToInt32(roundRegex.Match(round.Name).Value);

                        foreach (var match in round.Matches)
                        {
                            cmd.Parameters.Clear();

                            cmd.Parameters.AddWithValue("@HOMET", match.Home.Name);
                            cmd.Parameters.AddWithValue("@HOMEG", match.HomeGoal);
                            cmd.Parameters.AddWithValue("@GUESTT", match.Guest.Name);
                            cmd.Parameters.AddWithValue("@GUESTG", match.GuestGoal);
                            cmd.Parameters.AddWithValue("@STATUS", match.Status);
                            cmd.Parameters.AddWithValue("@DATE", match.Date);
                            cmd.Parameters.AddWithValue("@ID_ROUND", idRound);
                            cmd.Parameters.AddWithValue("@LEAGUE_NAME", league.Name);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Błąd zapisu do bazy. Błąd:{0}\nStack trace:{1}\n", exception.Message, exception.StackTrace);
            }
            finally
            {
                connection.Close();
            }


        }

        /// <summary>
        /// Metoda pobiera linki do lig z bazy danych
        /// </summary>
        /// <returns></returns>
        public static List<string> GetUrls()
        {
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ScoresDB"].ToString());
            var urls = new List<string>();

            try
            {

                connection.Open();

                var cmd = new SqlCommand(@"SELECT LINK FROM dbo.LEAGUE", connection);

                cmd.Parameters.Clear();

                using (var reader = cmd.ExecuteReader())
                {
                    urls = reader.Cast<IDataRecord>().Select(link => link.GetString(0)).ToList();
                }


            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Błąd podczas pobierania z bazy danych. Błąd:{0}\nStack trace:{1}\n", exception.Message, exception.StackTrace);
            }
            finally
            {
                connection.Close();
            }

            return urls;

        }


    }
}
