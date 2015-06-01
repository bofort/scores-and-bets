using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Windows;
using System.Windows.Controls.Ribbon;
using MatchResults.ScoresService;
using MatchResults.ViewModels;


namespace MatchResults
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            DataContext = new MainWindowViewModel();
        }

    }
}
