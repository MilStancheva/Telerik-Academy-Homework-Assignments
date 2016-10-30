namespace MediatorExampleChatroom.Contracts
{
    public interface IChatroom
    {
        void Register(IUser user);
        void Send(IUser fromUser, IUser toUser, string message);
    }
}