using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastrcture.Notification.SignalR
{
    public interface INotificationService
    {
        void NotifyNewEvent(string GroupName, object Message);
    }
}
