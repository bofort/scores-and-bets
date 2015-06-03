using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MatchResults.DataAccess;
using MatchResults.Helpers;
using MatchResults.Models;

namespace MatchResults.ViewModels
{
    public class AddLeagueViewModel : ViewModelBase
    {

        #region Properties

        private bool _isLoading;
        public bool IsLoading
        {
            get { return _isLoading; }
            set { _isLoading = value; RaisePropertyChanged("IsLoading"); }
        }

        private bool _isDeleteLeague;
        public bool IsDeleteLeague
        {
            get { return _isDeleteLeague; }
            set { if (_isDeleteLeague != value) { _isDeleteLeague = value; } RaisePropertyChanged("DeleteLeague"); }
        }

        private RelayCommand _addLeagueCommand;
        public RelayCommand AddLeagueCommand
        {
            get { return _addLeagueCommand ?? (_addLeagueCommand = new RelayCommand(AddLeague)); }
        }

        private RelayCommand _deleteLeagueCommand;
        public RelayCommand DeleteLeagueCommand
        {
            get { return _deleteLeagueCommand ?? (_deleteLeagueCommand = new RelayCommand(DeleteLeague)); }
        }

        private LeagueDataAccess _leagueDataAccess;

        public LeagueDataAccess LeagueDataAccess
        {
            get { return _leagueDataAccess ?? (_leagueDataAccess = new LeagueDataAccess()); }
        }

        private ObservableCollection<League> _leagueList;
        public ObservableCollection<League> LeagueList
        {
            get { return _leagueList; }
            set { if (_leagueList != value) { _leagueList = value; } RaisePropertyChanged("LeagueList"); }
        }

        private string _link;
        public string Link
        {
            get { return _link; }
            set
            {
                _link = value;
                RaisePropertyChanged("Link");
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        #endregion

        #region Constructors

        public AddLeagueViewModel()
        {
            try
            {
               GetLeagueList();
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Błąd: {0}", exception.Message), "Wystąpił błąd !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #endregion

        #region Event

        private void AddLeague(object _)
        {
            try
            {
                LeagueDataAccess.AddLeague(new League{Name = Name, Link = Link});
                GetLeagueList();
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Błąd: {0}", exception.Message), "Wystąpił błąd !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteLeague(object _)
        {
            try
            {
                IsLoading = true;
                Task.Factory.StartNew(
                    () => LeagueDataAccess.DeleteLeague(LeagueList.Where(x => x.IsDeleteLeague).ToList()),
                    TaskCreationOptions.LongRunning)
                .ContinueWith(
                    task =>
                    {
                        if (task.Exception != null)
                        {
                            task.Exception.Handle(x =>
                            {
                                Console.WriteLine(x.Message);
                                return false;
                            });
                        }
                        GetLeagueList();
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

        private void GetLeagueList()
        {
            IsLoading = true;
            Task<List<League>>.Factory.StartNew(
                () => LeagueDataAccess.GetLeaguesList(),
                TaskCreationOptions.LongRunning)
            .ContinueWith(
                task =>
                {
                    if (task.Exception != null)
                    {
                        task.Exception.Handle(x =>
                        {
                            Console.WriteLine(x.Message);
                            return false;
                        });
                    }
                    LeagueList = new ObservableCollection<League>(task.Result.OrderBy(l => l.Name));
                    IsLoading = false;
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        #endregion

    }
}
