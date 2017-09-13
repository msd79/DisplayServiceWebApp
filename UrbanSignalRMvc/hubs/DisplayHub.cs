using System;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace UrbanSignalRMvc
{
    public class DisplayHub : Hub
    {
        public void Send(string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(message);
            //Clients.Others.refreshBrowser();
        }
        public void RefreshBrowser()
        {
            // Call the addNewMessageToPage method to update clients.
            //Clients.All.addNewMessageToPage(name, message);
            Clients.Others.refreshBrowser();
        }

        //  public override Task OnConnected()
        //  {
        // Add your own code here.
        // For example: in a chat application, record the association between
        // the current connection ID and user name, and mark the user as online.
        // After the code in this method completes, the client is informed that
        // the connection is established; for example, in a JavaScript client,
        // the start().done callback is executed.
        //    return base.OnConnected();
        //   }


        //    public override Task OnReconnected()
        //   {
        // Add your own code here.
        // For example: in a chat application, you might have marked the
        // user as offline after a period of inactivity; in that case 
        // mark the user as online again.
        //   return base.OnReconnected();
        //  }
    }
}