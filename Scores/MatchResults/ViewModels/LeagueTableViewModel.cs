using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;
using MatchResults.DataAccess;
using MatchResults.Helpers;
using MatchResults.Models;

namespace MatchResults.ViewModels
{
    public class LeagueTableViewModel : ViewModelBase
    {

        #region Properties

        private bool _isLoading;
        public bool IsLoading
        {
            get { return _isLoading; }
            set { _isLoading = value; RaisePropertyChanged("IsLoading"); }
        }

        private League _selectedItem;
        public League SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                GetLeagueTable(_selectedItem.Id);
                RaisePropertyChanged("SelectedItem");
            }
        }

        private LeagueDataAccess _leaguDataAccess;
        public LeagueDataAccess LeagueDataAccess
        {
            get { return _leaguDataAccess ?? (_leaguDataAccess = new LeagueDataAccess()); }
        }

        private ObservableCollection<Team> _leagueTable;
        public ObservableCollection<Team> LeagueTable
        {
            get { return _leagueTable; }
            set { if (_leagueTable != value) { _leagueTable = value; } RaisePropertyChanged("LeagueTable"); }
        }

        private ObservableCollection<League> _leagueList;
        public ObservableCollection<League> LeagueList
        {
            get { return _leagueList; }
            set { if (_leagueList != value) { _leagueList = value; } RaisePropertyChanged("LeagueList"); }
        }

        private RelayCommand _toFileCommand;
        public RelayCommand ToFileCommand
        {
            get { return _toFileCommand ?? (_toFileCommand = new RelayCommand(ToFile)); }
        }

        #endregion

        #region Constructors

        public LeagueTableViewModel()
        {
            try
            {
                IsLoading = true;
                Task<List<League>>.Factory.StartNew(
                    () => LeagueDataAccess.GetLeaguesList(),
                    TaskCreationOptions.LongRunning)
                .ContinueWith(
                    task =>
                    {
                        LeagueList = new ObservableCollection<League>(task.Result.OrderBy(l => l.Name));
                        IsLoading = false;
                    }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Błąd: {0}", exception.Message), "Wystąpił błąd !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #endregion

        #region Method

        private void GetLeagueTable(int idLeague)
        {
            try
            {
                IsLoading = true;
                Task<List<Team>>.Factory.StartNew(
                    () => LeagueDataAccess.GetLeagueTable(idLeague),
                    TaskCreationOptions.LongRunning)
                .ContinueWith(
                    task =>
                    {
                        LeagueTable = new ObservableCollection<Team>(task.Result.OrderByDescending(t => t.Points));
                        IsLoading = false;
                    }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Błąd: {0}", exception.Message), "Wystąpił błąd !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #endregion

        #region Event

        private void ToFile(object _)
        {
            try
            {
                using (var file = new StreamWriter(ConfigurationManager.AppSettings["FilePathTxt"]))
                {
                    foreach (var item in LeagueTable)
                    {
                        file.WriteLine(item.ToLine());
                    }
                    file.Close();
                }
                //var xs = new XmlSerializer(typeof(ObservableCollection<Team>));
                //using (var wr = new StreamWriter(ConfigurationManager.AppSettings["FilePathXml"]))
                //{
                //    xs.Serialize(wr, LeagueTable);
                //}

            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Błąd: {0}", exception.Message), "Wystąpił błąd !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #endregion

    }
}
