using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using NavbarSearchDemo.Model;
using NavbarSearchDemo.Service;
using Xamarin.Forms;

namespace NavbarSearchDemo.ViewModel
{
    public class SearchPageViewModel : INotifyPropertyChanged
    {
        #region Properties
        private string _searchText;
        private IEnumerable<Friend> _listViewData;
        private readonly FriendsDataService _friendsDataService;
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public SearchPageViewModel()
        {
            _friendsDataService= new FriendsDataService();
            ListViewData = _friendsDataService.GetDummyFriends();
        }




        #region PublicMethods
        

        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged(nameof(ListViewData));
            }
        }


        public IEnumerable<Friend> ListViewData
        {
            get
            {
                return _listViewData = _friendsDataService.GetDummyFriends(_searchText);
            }
            set
            {
                _listViewData = value;
                OnPropertyChanged();
            }

        }

        #endregion

        #region PrivateMethods

        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        

        #endregion



    }
}
