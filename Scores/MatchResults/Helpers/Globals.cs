using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Common.DataContracts;
using MatchResults.Models;
using MatchResults.ScoresService;

namespace MatchResults.Helpers
{
    public static class Globals
    {

        #region Properties

        /// <summary>
        /// Połaczenie do serwisu WCF
        /// </summary>
        public static ScoresServiceClient ScoresClient;

        #endregion

        #region Method
        
        /// <summary>
        /// Metoda odpowiedzialna za stworzenie mapowań obiektów DTO na modele oraz w drugą stronę
        /// </summary>
        public static void CreatMap()
        {
            CreatMapForMatch();
            CreatMapForLeague();
            CreatMapForTeam();
        }

        private static void CreatMapForMatch()
        {
            Mapper.CreateMap<Match, MATCH>()
                .ForMember(dest => dest.STATUS, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.DATE, opt => opt.MapFrom(src => src.Date))
                .ForMember(dest => dest.GUEST_GOAL, opt => opt.MapFrom(src => src.GuestGoal))
                .ForMember(dest => dest.GUEST_TEAM, opt => opt.MapFrom(src => src.GuestTeam))
                .ForMember(dest => dest.HOME_GOAL, opt => opt.MapFrom(src => src.HomeGoal))
                .ForMember(dest => dest.HOME_TEAM, opt => opt.MapFrom(src => src.HomeTeam))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ID_LEAGUE, opt => opt.MapFrom(src => src.IdLeague))
                .ForMember(dest => dest.ID_ROUND, opt => opt.MapFrom(src => src.IdRound));
            Mapper.CreateMap<MATCH, Match>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.STATUS))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.DATE))
                .ForMember(dest => dest.GuestGoal, opt => opt.MapFrom(src => src.GUEST_GOAL))
                .ForMember(dest => dest.GuestTeam, opt => opt.MapFrom(src => src.GUEST_TEAM))
                .ForMember(dest => dest.HomeGoal, opt => opt.MapFrom(src => src.HOME_GOAL))
                .ForMember(dest => dest.HomeTeam, opt => opt.MapFrom(src => src.HOME_TEAM))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.IdLeague, opt => opt.MapFrom(src => src.ID_LEAGUE))
                .ForMember(dest => dest.IdRound, opt => opt.MapFrom(src => src.ID_ROUND));
        }

        private static void CreatMapForLeague()
        {
            Mapper.CreateMap<League, LEAGUE>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.LINK, opt => opt.MapFrom(src => src.Link))
                .ForMember(dest => dest.NAME, opt => opt.MapFrom(src => src.Name));
            Mapper.CreateMap<LEAGUE, League>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Link, opt => opt.MapFrom(src => src.LINK))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.NAME));
        }

        private static void CreatMapForTeam()
        {
            Mapper.CreateMap<Team, TEAM>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.DRAW, opt => opt.MapFrom(src => src.Draw))
                .ForMember(dest => dest.GOAL_CONCEDED, opt => opt.MapFrom(src => src.GoalConceded))
                .ForMember(dest => dest.GOAL_SCORED, opt => opt.MapFrom(src => src.GoalScored))
                .ForMember(dest => dest.ID_LEAGUE, opt => opt.MapFrom(src => src.IdLeague))
                .ForMember(dest => dest.LOSE, opt => opt.MapFrom(src => src.Lose))
                .ForMember(dest => dest.NAME, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.POINTS, opt => opt.MapFrom(src => src.Points))
                .ForMember(dest => dest.WIN, opt => opt.MapFrom(src => src.Win));
            Mapper.CreateMap<TEAM, Team>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Draw, opt => opt.MapFrom(src => src.DRAW))
                .ForMember(dest => dest.GoalConceded, opt => opt.MapFrom(src => src.GOAL_CONCEDED))
                .ForMember(dest => dest.GoalScored, opt => opt.MapFrom(src => src.GOAL_SCORED))
                .ForMember(dest => dest.IdLeague, opt => opt.MapFrom(src => src.ID_LEAGUE))
                .ForMember(dest => dest.Lose, opt => opt.MapFrom(src => src.LOSE))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.NAME))
                .ForMember(dest => dest.Points, opt => opt.MapFrom(src => src.POINTS))
                .ForMember(dest => dest.Points, opt => opt.MapFrom(src => src.WIN));
        }

        #endregion

    }
}
