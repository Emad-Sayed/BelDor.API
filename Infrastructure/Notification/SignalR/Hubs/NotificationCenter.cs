using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Notification.SignalR.Hubs
{
    public class NotificationCenter : Hub
    {
        public void CreateNotificationGroup(string GroupName)
        {
            Groups.AddToGroupAsync(Context.ConnectionId, GroupName);
        }
    }
}

//Employee E_BranchDepartementId
//Visitor V_BranchDepartementId
