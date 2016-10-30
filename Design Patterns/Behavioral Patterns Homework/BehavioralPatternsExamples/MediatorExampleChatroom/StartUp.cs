using System;
using System.Linq;
using MediatorExampleChatroom.Models;

namespace MediatorExampleChatroom
{
    public class StartUp
    {
        public static void Main()
        {
            var pesho = new User("Pesho");
            var gosho = new User("Gosho");

            var chatroom = new Chatroom();

            chatroom.Register(pesho);
            chatroom.Register(gosho);

            var firstMessage = "Hi Gosho, how are you doing?";
            chatroom.Send(pesho, gosho, firstMessage);

            var secondMessage = "Hello Pesho! Great, thanks! And you?";
            chatroom.Send(gosho, pesho, secondMessage);

            foreach (var message in gosho.Messages)
            {
                Console.WriteLine(message);
            }

            foreach (var message in pesho.Messages)
            {
                Console.WriteLine(message);
            }
        }
    }
}
