using Core.Infrastrcture.Notification.SignalR;
using Infrastructure.Notification.SignalR.Hubs;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Notification.SignalR.Service
{
    public class NotificationCenterService : INotificationService
    {
        private IHubContext<NotificationCenter> notificationContext;
        public NotificationCenterService(IHubContext<NotificationCenter> notificationContext_)
        {
            notificationContext = notificationContext_;
        }
        public void NotifyNewEvent(string GroupName, object Message)
        {
            notificationContext.Clients.Group(GroupName).SendAsync("newMessage", Message);
        }
    }
}