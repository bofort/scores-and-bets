using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Scores.Models;

namespace Scores.Parsers
{
    /// <summary>
    /// Klasa, która parsuje html do obiektów (struktur)
    /// </summary>
    public static class HtmlParser
    {
        /// <summary>
        /// Metoda główna pobierająca nazwe ligi.
        /// </summary>
        /// <param name="htmlText"></param>
        /// <returns></returns>
        public static sLeague ParseHtmlText(string htmlText)
        {
            var leagueStruct = new sLeague();

            try
            {

                var nameRegex = new Regex(@"<title>.*<\/title>");

                var name = Regex.Split(nameRegex.Match(htmlText).Value, "wyniki");

                leagueStruct.Name = name[0].Substring(7);

                leagueStruct.Rounds = new List<sRound>();

                var leagueRegex = new Regex(@"<div class=" + '"' + "league_box" + '"' + @">.*");

                if (leagueRegex.IsMatch(htmlText))
                {

                    var tmp = Regex.Split(leagueRegex.Match(htmlText).Value,
                        "<div class=" + '"' + "league_box" + '"' + @">");

                    for (var i = 1; i < tmp.Length; i++)
                    {
                        sRound rounds;

                        GetRoundParameter(out rounds, tmp[i]);

                        leagueStruct.Rounds.Add(rounds);
                    }

                }

            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wystąpił błąd. Błąd:{0}\nStack trace:{1}\n", exception.Message, exception.StackTrace);
            }

            return leagueStruct;
        }

        /// <summary>
        /// Metoda pobiera parametry każdej z rund dla danej ligi
        /// </summary>
        /// <param name="round"></param>
        /// <param name="htmlText"></param>
        private static void GetRoundParameter(out sRound round, string htmlText)
        {
            round = new sRound();

            try
            {
                var roundRegex = new Regex(@"Kolejka [0-9]+");

                round.Name = roundRegex.Match(htmlText).Value;

                round.Matches = new List<sMatch>();

                var matchRegex = new Regex(@"<div id=" + '"' + "[0-9]+" + '"' + ".*");

                if (!matchRegex.IsMatch(htmlText)) { return; }
                var tmp = Regex.Split(matchRegex.Match(htmlText).Value, "class=" + '"' + "g ");

                for (var i = 1; i < tmp.Length; i++)
                {
                    sMatch match;

                    GetMatchesParameter(out match, tmp[i]);

                    round.Matches.Add(match);
                }
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wystąpił błąd. Błąd:{0}\nStack trace:{1}\n", exception.Message, exception.StackTrace);
            }

        }

        /// <summary>
        /// Metoda pobiera parametry danego meczu dla danej rundy
        /// </summary>
        /// <param name="match"></param>
        /// <param name="htmlText"></param>
        private static void GetMatchesParameter(out sMatch match, string htmlText)
        {
            match = new sMatch();

            try
            {
                var dateRegex = new Regex(@">[0-9\-:\s]+<");

                match.Date = dateRegex.Match(htmlText).Value.TrimStart('>').TrimEnd('<');


                var resultRegex = new Regex(@"<b>[0-9\-\s]+<\/b>");

                var result = Regex.Split(resultRegex.Match(htmlText).Value, "-");

                if (result.Length >= 2)
                {
                    match.HomeGoal = Convert.ToString(result[0].ToCharArray(0, result[0].Length)[result[0].Length - 1]);
                    match.GuestGoal = Convert.ToString(result[1].ToCharArray(0, 1)[0]);
                }
                else
                {
                    match.HomeGoal = "";
                    match.GuestGoal = "";
                }

                var teamRegex = new Regex(@">[a-zółśćńąęŁŚA-Z\s\.0-9]+<");

                var matches = teamRegex.Matches(htmlText);

                var czyLiczby = new Regex(@"[0-9]+");

                if (matches.Count >= 3 &&
                    (matches[0].Value.Contains("Koniec") || matches[0].Value.Contains("Przerwa") ||
                     czyLiczby.IsMatch(matches[0].Value)))
                {
                    match.Status = matches[0].Value.TrimStart('>').TrimEnd('<');

                    match.Home = new sTeam { Name = matches[1].Value.TrimStart('>').TrimEnd('<') };

                    match.Guest = new sTeam { Name = matches[2].Value.TrimStart('>').TrimEnd('<') };
                }
                else
                {
                    match.Status = "";

                    match.Home = new sTeam { Name = matches[0].Value.TrimStart('>').TrimEnd('<') };

                    match.Guest = new sTeam { Name = matches[1].Value.TrimStart('>').TrimEnd('<') };
                }
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wystąpił błąd. Błąd:{0}\nStack trace:{1}\n", exception.Message, exception.StackTrace);
            }

        }



    }
}
