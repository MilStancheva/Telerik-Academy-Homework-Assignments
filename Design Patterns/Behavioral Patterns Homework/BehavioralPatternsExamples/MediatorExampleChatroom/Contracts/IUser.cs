using System;
using System.Collections.Generic;
using System.Linq;

namespace MediatorExampleChatroom.Contracts
{
    public interface IUser
    {
        string Name { get; set; }

        IChatroom Chatroom { get; set; }

        ICollection<string> Messages { get; }

        void Send(IUser toUser, string message);

        void Receive(IUser fromUser, string message);
    }
}
