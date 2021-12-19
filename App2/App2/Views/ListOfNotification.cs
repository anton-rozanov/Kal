using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Views
{
    class ListOfNotification
    {
        public List<Notification> Notification = new List<Notification>();
        public bool checkNotification(Notification notificationToCheck)
        {
            for(int i = 0; i > 0; i++)
            {
                if(Notification[i].name == notificationToCheck.name && Notification[i].time.isog(notificationToCheck.time))
                {
                    return true;
                }
            }
            return false;
        }
        public void addNotification(Notification newNotification)
        {
            if(checkNotification(newNotification) == false)
            {
                Notification.Add(newNotification);
            }

        }




    }
}
