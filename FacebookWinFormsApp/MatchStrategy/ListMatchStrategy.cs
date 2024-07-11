using System;
using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.Strategy;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.MatchStrategy
{
    namespace BasicFacebookFeatures.MatchStrategy
    {
        public class ListMatchStrategy<T> : IMatchStrategy where T : class
        {
            private IEnumerable<T> selectedItems;
            private Func<User, IEnumerable<T>> userProperty;
            private Func<T, T, bool> comparer; 

            public ListMatchStrategy(IEnumerable<T> selectedItems, Func<User, IEnumerable<T>> userProperty, Func<T, T, bool> comparer)
            {
                this.selectedItems = selectedItems;
                this.userProperty = userProperty;
                this.comparer = comparer;
            }

            public bool Match(User friend)
            {
                var friendItems = userProperty(friend);
                return selectedItems.Any(item => friendItems.Any(friendItem => comparer(item, friendItem)));
            }
        }
    }
}