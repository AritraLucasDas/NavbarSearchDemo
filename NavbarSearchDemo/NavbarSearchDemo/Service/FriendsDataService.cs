using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using NavbarSearchDemo.Model;

namespace NavbarSearchDemo.Service
{
    class FriendsDataService
    {
        private static readonly List<Friend> _friends = new List<Friend>
        {
            new Friend{Name = "Archie", DoB = "12-Jul", Image = "http://lorempixel.com/100/100/people/2"},
            new Friend{Name = "Devlin", DoB = "12-Jul", Image = "http://lorempixel.com/100/100/people/3"},
            new Friend{Name = "Ruby", DoB = "14-Apr", Image = "http://lorempixel.com/100/100/people/1"},
            new Friend{Name = "Jena", DoB = "12-Jul", Image = "http://lorempixel.com/100/100/people/4"},
            new Friend{Name = "Fin", DoB = "14-Apr", Image = "http://lorempixel.com/100/100/people/6"},
            new Friend{Name = "Gukachata", DoB = "14-Apr", Image = "http://lorempixel.com/100/100/people/8"},
            new Friend{Name = "Falum", DoB = "12-Jul", Image = "http://lorempixel.com/100/100/people/7"},
            new Friend{Name = "Christina", DoB = "14-Apr", Image = "http://lorempixel.com/100/100/people/9"},
            new Friend{Name = "Leo", DoB = "12-Jul", Image = "http://lorempixel.com/100/100/people/5"},
        };

        public List<Friend> Friends {
            get => _friends;
        }


        #region PublicMethods
        public IEnumerable<Friend> GetDummyFriends(string searchString = null)
        {
            IEnumerable<Friend> result = string.IsNullOrEmpty(searchString)
                ? Friends
                : Friends.Where(c => c.Name.ToLower().StartsWith(searchString?.ToLower()));
            return result;
        }
        #endregion



    }
}
