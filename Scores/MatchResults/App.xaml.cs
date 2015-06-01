using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AutoMapper;
using Common.DataContracts;
using MatchResults.Helpers;
using MatchResults.Models;
using MatchResults.ScoresService;
using MatchResults.ViewModels;

namespace MatchResults
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            Globals.CreatMap();
            Globals.ScoresClient = new ScoresServiceClient();
        }


    }
}
