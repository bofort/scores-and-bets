using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using AutoMapper;

namespace ScoresService.Helpers
{
    /// <summary>
    /// Metody mapujące obiekty DTO do obiektow DB i na odwrót
    /// </summary>
    public static class ExtensionsMethod
    {

        #region Method

        public static MATCH ToDB(this Common.DataContracts.MATCH match)
        {
            return Mapper.Map<MATCH>(match);
        }

        public static Common.DataContracts.MATCH ToCommon(this MATCH match)
        {
            return Mapper.Map<Common.DataContracts.MATCH>(match);
        }

        public static USER_MATCH ToDB(this Common.DataContracts.USER_MATCH match)
        {
            return Mapper.Map<USER_MATCH>(match);
        }

        public static Common.DataContracts.USER_MATCH ToCommon(this USER_MATCH match)
        {
            return Mapper.Map<Common.DataContracts.USER_MATCH>(match);
        }

        public static BETS ToDB(this Common.DataContracts.BET bet)
        {
            return Mapper.Map<BETS>(bet);
        }

        public static Common.DataContracts.BET ToCommon(this BETS bet)
        {
            return Mapper.Map<Common.DataContracts.BET>(bet);
        }

        public static BETS_MATCHES ToDB(this Common.DataContracts.BETS_MATCHES bet)
        {
            return Mapper.Map<BETS_MATCHES>(bet);
        }

        public static Common.DataContracts.BETS_MATCHES ToCommon(this BETS_MATCHES bet)
        {
            return Mapper.Map<Common.DataContracts.BETS_MATCHES>(bet);
        }

        public static LEAGUE ToDB(this Common.DataContracts.LEAGUE league)
        {
            return Mapper.Map<LEAGUE>(league);
        }

        public static Common.DataContracts.LEAGUE ToCommon(this LEAGUE league)
        {
            return Mapper.Map<Common.DataContracts.LEAGUE>(league);
        }

        public static TEAM ToDB(this Common.DataContracts.TEAM team)
        {
            return Mapper.Map<TEAM>(team);
        }

        public static Common.DataContracts.TEAM ToCommon(this TEAM team)
        {
            return Mapper.Map<Common.DataContracts.TEAM>(team);
        }

        #endregion

    }
}