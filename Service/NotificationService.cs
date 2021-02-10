using ProjectLibri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectLibri.Service
{
    public class NotificationService
    {
        internal List<Notification> getAll()
        {
            List<Notification> notifications = new List<Notification>();

            for (int i = 0; i < 10; i++)
            {
                Notification notification = new Notification();
                notification.title = "Title" + i;
                notifications.Add(notification);
            }

            return notifications;
        }
    }
}
