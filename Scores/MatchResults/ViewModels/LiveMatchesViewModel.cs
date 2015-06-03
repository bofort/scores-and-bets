using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using MatchResults.DataAccess;
using MatchResults.Helpers;
using MatchResults.Models;

namespace MatchResults.ViewModels
{
    public class LiveMatchesViewModel : ViewModelBase
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

        private MatchesDataAccess _matchesDataAccess;
        public MatchesDataAccess MatchesDataAccess
        {
            get { return _matchesDataAccess ?? (_matchesDataAccess = new MatchesDataAccess()); }
        }

        private ObservableCollection<Match> _liveMatches;

        public ObservableCollection<Match> LiveMatches
        {
            get { return _liveMatches; }
            set { if (_liveMatches != value) { _liveMatches = value; } RaisePropertyChanged("LiveMatches"); }
        }

        private RelayCommand _addToMyMatchesCommand;
        public RelayCommand AddToMyMatchesCommand
        {
            get { return _addToMyMatchesCommand ?? (_addToMyMatchesCommand = new RelayCommand(AddToMyMatches)); }
        }

        #endregion

        #region Constructors

        public LiveMatchesViewModel()
        {
            try
            {
                IsLoading = true;
                Task<List<Match>>.Factory.StartNew(
                    () => MatchesDataAccess.GetLiveMatches(),
                    TaskCreationOptions.LongRunning)
                    .ContinueWith(
                        task =>
                        {
                            LiveMatches = new ObservableCollection<Match>(task.Result.OrderByDescending(m => m.Status));
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

        private void AddToMyMatches(object _)
        {
            try
            {
                IsLoading = true;
                Task.Factory.StartNew(
                    () => MatchesDataAccess.AddToMyMatches(LiveMatches.Where(x => x.IsUserMatch).ToList()),
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
                        IsLoading = false;
                    }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Błąd: {0}", exception.Message), "Wystąpił błąd !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #endregion

    }
}
