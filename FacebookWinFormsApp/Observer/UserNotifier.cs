using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Observer
{
    public class UserNotifier
    {
        private List<IObserver> observers = new List<IObserver>();
        private User user;

        public User User
        {
            get { return user; }
            set
            {
                user = value;
                NotifyObservers();
            }
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(user);
            }
        }
    }
}
