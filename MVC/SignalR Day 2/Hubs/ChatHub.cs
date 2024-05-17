using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;
using SignalR_Day_2.Data;
using SignalR_Day_2.Entity;

namespace SignalR_Day_2.Hubs
{
    public class ChatHub : Hub
    {
        ChatContext context;
        public ChatHub(ChatContext context)
        {
            this.context = context;
        }

        [HubMethodName("sendmessage")]
        public void sendmessage(ChatMessage message)
        {
            //Context.ChatMessages.Add(message);
            context.ChatMessages.Add(message);
            context.SaveChanges();

            Clients.All.SendAsync("newMessage", message);
        }

        [HubMethodName("typing")]
        public void typing(string message)
        {
            Clients.All.SendAsync("newMessage", message);
        }

        public void joingroup(string groubname, string name)
        {
            Groups.AddToGroupAsync(Context.ConnectionId, groubname);//adding a person to a groub
            Clients.GroupExcept(groubname,Context.ConnectionId);//will send to all the groub except this one
            Clients.OthersInGroup(groubname).SendAsync("newmember",name,groubname);//will send to all execpt the sender
        }

        public void sendToGroub(string name, string message, string groub)
        {
            Clients.Group(groub).SendAsync("groubmessage", name, message, groub);
        }

        public override Task OnConnectedAsync()
        {
            //add the connectionId in the table "usercon"
            string conid= Context.ConnectionId;
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            //remove the connectionId in the table "usercon"
            return base.OnDisconnectedAsync(exception);
        }
        
    }
}
