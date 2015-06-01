using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using DevExpress.Xpf.Bars;
using MatchResults.Helpers;

namespace MatchResults.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {

        #region Properties

        private ObservableCollection<ViewModelBase> _viewModels;
        public ObservableCollection<ViewModelBase> ViewModels
        {
            get { return _viewModels ?? (_viewModels = new ObservableCollection<ViewModelBase>()); }
        }

        private RelayCommand _closeCommand;
        public RelayCommand CloseCommand
        {
            get { return _closeCommand ?? (_closeCommand = new RelayCommand(Close)); }
        }

        private RelayCommand _userMatchesCommand;
        public RelayCommand UserMatchesCommand
        {
            get { return _userMatchesCommand ?? (_userMatchesCommand = new RelayCommand(UserMatches)); }
        }

        private RelayCommand _leagueTableCommand;
        public RelayCommand LeagueTableCommand
        {
            get { return _leagueTableCommand ?? (_leagueTableCommand = new RelayCommand(LeagueTables)); }
        }

        private RelayCommand _liveMatchesCommand;
        public RelayCommand LiveMatchesCommand
        {
            get { return _liveMatchesCommand ?? (_liveMatchesCommand = new RelayCommand(LiveMatches)); }
        }

        private RelayCommand _addLeaguCommand;
        public RelayCommand AddLeaguCommand
        {
            get { return _addLeaguCommand ?? (_addLeaguCommand = new RelayCommand(AddLeague)); }
        }

        #endregion

        #region Constructors

        public MainWindowViewModel()
        {
        }

        #endregion

        #region Event

        private static void Close(object _)
        {
            Application.Current.Shutdown();
        }

        private void LiveMatches(object _)
        {
            ViewModels.Clear();
            ViewModels.Add(new LiveMatchesViewModel());
        }

        private void UserMatches(object _)
        {
            ViewModels.Clear();
            ViewModels.Add(new UserMatchesViewModel());
        }

        private void LeagueTables(object _)
        {
            ViewModels.Clear();
            ViewModels.Add(new LeagueTableViewModel());
        }

        private void AddLeague(object _)
        {
            ViewModels.Clear();
            ViewModels.Add(new AddLeagueViewModel());
        }

        #endregion

    }
}
