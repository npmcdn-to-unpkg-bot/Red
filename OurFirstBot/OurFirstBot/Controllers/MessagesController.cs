using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.Bot.Connector;
using Newtonsoft.Json;

namespace OurFirstBot
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        private readonly Random _random = new Random(DateTime.Now.Second); 

        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        public async Task<HttpResponseMessage> Post([FromBody]Activity activity)
        {
            if (activity.Type == ActivityTypes.Message)
            {
                ConnectorClient connector = new ConnectorClient(new Uri(activity.ServiceUrl));
                // calculate something for us to return
                int length = (activity.Text ?? string.Empty).Length;


                Activity reply;

                if (activity.Text.ToLower() != "where is my meerkat")
                {
                    reply = activity.CreateReply("I don't understand");
                }
                else
                {
                    var randomNumber = _random.Next(3);
                    if (randomNumber == 0)
                    {
                        reply = activity.CreateReply("Your Meerkat is dead.");
                    }
                    else if (randomNumber == 1)
                    {
                        reply = activity.CreateReply("Your Meerkat is not on Alex's haed");
                    }
                    else if (randomNumber == 2)
                    {
                        reply = activity.CreateReply("Your Meerkat is with Gonzalo - god rest its sole");
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                }

                //Activity reply = activity.CreateReply($"You sent {activity.Text} which was {length} characters");
                await connector.Conversations.ReplyToActivityAsync(reply);
            }
            else
            {
                HandleSystemMessage(activity);
            }
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        private Activity HandleSystemMessage(Activity message)
        {
            if (message.Type == ActivityTypes.DeleteUserData)
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == ActivityTypes.ConversationUpdate)
            {
                // Handle conversation state changes, like members being added and removed
                // Use Activity.MembersAdded and Activity.MembersRemoved and Activity.Action for info
                // Not available in all channels
            }
            else if (message.Type == ActivityTypes.ContactRelationUpdate)
            {
                // Handle add/remove from contact lists
                // Activity.From + Activity.Action represent what happened
            }
            else if (message.Type == ActivityTypes.Typing)
            {
                // Handle knowing tha the user is typing
            }
            else if (message.Type == ActivityTypes.Ping)
            {
            }

            return null;
        }
    }
}