using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.ScoresService;

namespace Tests
{
    /// <summary>
    /// Klasa odpowiedzialna za metody dla testów WCFa (Testy są bardzo banalne)
    /// </summary>
    [TestClass]
    public class WcfTest
    {
        /// <summary>
        /// Sprawdza czy metoda zwraca zawsze to samo
        /// </summary>
        [TestMethod]
        public void MatchTest()
        {
            var client = new ScoresServiceClient();

            var expected = client.GetLiveMatches().ToList();

            var actual = client.GetLiveMatches().ToList();

            Assert.AreEqual(expected.Count, actual.Count);
        }

        /// <summary>
        /// Sprawdza czy lista lig nie jest nullem
        /// </summary>
        [TestMethod]
        public void LeagueTest()
        {
            var client = new ScoresServiceClient();

            var expected = client.GetAllLeagues();

            Assert.IsNotNull(expected);
        }

        /// <summary>
        /// Sprawdza czy w liscie zespołów jest liga ktorej nie ma w tabeli z ligami
        /// </summary>
        [TestMethod]
        public void CheckDbLeagueTest()
        {
            var client = new ScoresServiceClient();

            var teams = client.GetAllTeams().ToList();

            var leagues = client.GetAllLeagues().ToList();

            var notInDbLeague = leagues.Where(l => !teams.Any(t => t.ID_LEAGUE == l.ID));

            Assert.AreEqual(0,notInDbLeague.Count());
        }


    }
}
