using MediatorExampleChatroom.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorExampleChatroom.Models
{
    public class Chatroom : IChatroom
    {
        private readonly ICollection<IUser> users = new List<IUser>();

        public void Register(IUser user)
        {
            if (!users.Contains(user))
            {
                users.Add(user);
            }

            user.Chatroom = this;
        }

        public void Send(IUser fromUser, IUser toUser, string message)
        {
            var user = users.FirstOrDefault(x => x == toUser);

            if (user != null)
            {
                user.Receive(fromUser, message);
            }                
        }
    }
}
