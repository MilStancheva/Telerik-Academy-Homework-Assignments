namespace FriendsOfPesho
{
    public class Connection
    {
        public Connection(Node node, long distance)
        {
            this.ToNode = node;
            this.Distance = distance;
        }

        public Node ToNode { get; set; }

        public long Distance { get; set; }
    }
}