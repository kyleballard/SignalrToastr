using Microsoft.AspNet.SignalR;

namespace SignalrToastr.Hubs
{
    public class ContactHub : Hub
    {
        public void ContactFormSubmitted(string name, string message)
        {
            // Calls the 'notifyUsers' method on the client side.
            //  Note:  You can change 'All' to target only certain clients.
            //  Note:  Code after 'All' is dynamic, and you can specify whatever name you wish.
            Clients.All.notifyUsers(name);
        }
    }
}