using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Common.DataContracts;
using AutoMapper;
using MatchResults.Models;

namespace MatchResults.Helpers
{
    /// <summary>
    /// Klasa odpowiedzialna za extensions method
    /// </summary>
    public static class ExtensionsMethod
    {

        #region Method

        public static string ToLine(this Team team)
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}",team.Name,team.Points,team.Win,team.Draw,team.Lose);
        }

        public static Match ToModel(this MATCH match)
        {
            return Mapper.Map<Match>(match);
        }

        public static MATCH ToDTO(this Match match)
        {
            return Mapper.Map<MATCH>(match);
        }

        public static League ToModel(this LEAGUE match)
        {
            return Mapper.Map<League>(match);
        }

        public static LEAGUE ToDTO(this League match)
        {
            return Mapper.Map<LEAGUE>(match);
        }

        public static Team ToModel(this TEAM match)
        {
            return Mapper.Map<Team>(match);
        }

        public static TEAM ToDTO(this Team match)
        {
            return Mapper.Map<TEAM>(match);
        }

        #endregion

    }
}
