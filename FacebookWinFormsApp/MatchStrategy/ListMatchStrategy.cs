using System;
using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.Strategy;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.MatchStrategy
{
     public class ListMatchStrategy<T> : IMatchStrategy where T : class
    {
        private IEnumerable<T> selectedItems;
        private Func<User, IEnumerable<T>> userProperty;

        public ListMatchStrategy(IEnumerable<T> selectedItems, Func<User, IEnumerable<T>> userProperty)
        {
            this.selectedItems = selectedItems;
            this.userProperty = userProperty;
        }

        public bool Match(User friend)
        {
            var friendItems = userProperty(friend);
            return !selectedItems.Any() || friendItems.Intersect(selectedItems).Any();
        }
    }
}
