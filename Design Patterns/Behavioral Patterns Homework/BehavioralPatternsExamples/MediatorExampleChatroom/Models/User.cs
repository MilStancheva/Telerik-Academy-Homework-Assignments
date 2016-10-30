using System;
using System.Collections.Generic;
using System.Linq;
using MediatorExampleChatroom.Contracts;

namespace MediatorExampleChatroom.Models
{
    public class User : IUser
    {
        public User(string name)
        {
            this.Name = name;
            this.Messages = new List<string>();
        }
        public string Name { get; set; }

        public IChatroom Chatroom { get; set; }

        public ICollection<string> Messages { get; private set; }

        public void Send(IUser toUser, string message)
        {
            Chatroom.Send(this, toUser, message);
        }

        public void Receive(IUser fromUser, string message)
        {
            Messages.Add(string.Format("{0} says {1}", fromUser.Name, message));
        }        
    }
}
