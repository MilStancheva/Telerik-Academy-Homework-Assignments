using System;

namespace FriendsOfPesho
{
    public class Node : IComparable<Node>
    {
        public Node(int id)
        {
            this.Id = id;
            this.IsHospital = false;
        }

        public int Id { get; set; }

        public long DijkstraDistance { get; set; }

        public bool IsHospital { get; set; }

        public int CompareTo(Node other)
        {
            return this.DijkstraDistance.CompareTo(other.DijkstraDistance);
        }
    }
}