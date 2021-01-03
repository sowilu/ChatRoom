using System;
using System.Collections.Generic;
using System.Text;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Server
{
    class Dsicord:WebSocketBehavior
    {
        List<string> users = new List<string>() {"iDubz", "Ineta_Petrovic" };

        protected override void OnOpen()
        {
            if(!Context.QueryString.Contains("name"))
            {
                Send("ERROR|You must have a name to connect");
                Sessions.CloseSession(ID);
                return;
            }

            var name = Context.QueryString["name"];

            if(string.IsNullOrEmpty(name) || users.Contains(name))
            {
                Send("ERROR|Change name");
                Sessions.CloseSession(ID);
                return;
            }

            Send($"USERS|{UsersToString()}");

            Sessions.Broadcast($"USERS|{name}");

            users.Add(name);
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            Sessions.Broadcast($"MESSAGE|{e.Data}");
        }
        private string UsersToString()
        {
            var text = "";
            foreach (var user in users)
            {
                text += user + " ";
            }
            return text;
        }

        protected override void OnClose(CloseEventArgs e)
        {
            Console.WriteLine($"{DateTime.Now.ToString("t")} server stoped: {e.Reason}");
        }
    }
}
