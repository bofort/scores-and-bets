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
    public class UserMatchesViewModel : ViewModelBase
    {

        #region Properties

        private bool _isLoading;
        public bool IsLoading
        {
            get { return _isLoading; }
            set { if (_isLoading != value) { _isLoading = value; } RaisePropertyChanged("IsLoading"); }
        }

        private bool _isUserMatch;
        public bool IsUserMatch
        {
            get { return _isUserMatch; }
            set { if (_isUserMatch != value) { _isUserMatch = value; } RaisePropertyChanged("IsUserMatch"); }
        }

        private RelayCommand _deleteFromMyMatchesCommand;
        public RelayCommand DeleteFromMyMatchesCommand
        {
            get { return _deleteFromMyMatchesCommand ?? (_deleteFromMyMatchesCommand = new RelayCommand(DeleteFromMyMatches)); }
        }

        private MatchesDataAccess _matchesDataAccess;
        public MatchesDataAccess MatchesDataAccess
        {
            get { return _matchesDataAccess ?? (_matchesDataAccess = new MatchesDataAccess()); }
        }


        private ObservableCollection<Match> _userMatches;
        public ObservableCollection<Match> UserMatches
        {
            get { return _userMatches; }
            set { if (_userMatches != value) { _userMatches = value; } RaisePropertyChanged("UserMatches"); }
        }

        #endregion

        #region Constructors

        public UserMatchesViewModel()
        {
            try
            {
                GetMyMatches();
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Błąd: {0}", exception.Message), "Wystąpił błąd !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #endregion

        #region Event

        private void DeleteFromMyMatches(object _)
        {
            try
            {
                IsLoading = true;
                Task.Factory.StartNew(
                    () => MatchesDataAccess.DeleteFromMyMatches(UserMatches.Where(x => x.IsUserMatch).ToList()),
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
                        GetMyMatches();
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

        private void GetMyMatches()
        {
            IsLoading = true;
            Task<List<Match>>.Factory.StartNew(
                () => MatchesDataAccess.GetUserMatches(),
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
                    UserMatches = new ObservableCollection<Match>(task.Result.OrderByDescending(m => m.Status));
                    IsLoading = false;
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        #endregion

    }
}
