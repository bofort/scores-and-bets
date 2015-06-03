using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Scores.Helpers;
using Scores.Models;
using Scores.Parsers;

namespace Scores
{
    /// <summary>
    /// Aplikacja pobierająca wyniki meczów z internetu (Konsolowa)
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {

            var urls = DbHelper.GetUrls();

            var workerList = urls.Select(url => Task.Run(() => { TaskMethod(url); })).ToList();

            while (true)
            {
                var newUrls = DbHelper.GetUrls();
                if (urls.Count < newUrls.Count)
                {
                    workerList.AddRange(newUrls.Except(urls).Select(url => Task.Run(() => { TaskMethod(url); })));
                }
            }

        }

        /// <summary>
        /// Metoda, którą wykonuje każdy task danej ligi.
        /// </summary>
        /// <param name="url"></param>
        public static void TaskMethod(string url)
        {
            while (true)
            {
                try
                {
                    Task.Delay(30000).Wait();

                    var webClient = new WebClient {Encoding = Encoding.UTF8};

                    var content = webClient.DownloadString(url);

                    var mainStruct = new sMain
                    {
                        League = new List<sLeague> { HtmlParser.ParseHtmlText(content) }
                    };

                    Task.Run(() => { DbHelper.SaveToDataBase(mainStruct); });

                    Task.Run(() => { FileHelper.SaveToFile(mainStruct); });

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Udało się pobrać wyniki. League: {0} \n", mainStruct.League[0].Name);
                }
                catch (Exception exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nie udało się pobrać wyników. Błąd:{0}\nStack trace:{1}\n", exception.Message, exception.StackTrace);
                }
            }
        }

    }

}
