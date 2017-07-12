using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendsOfPesho
{
    public class StartUp
    {
        public static void Main()
        {
            string[] inputNumbers = Console.ReadLine().Split(' ').ToArray();
            int pointsNumber = int.Parse(inputNumbers[0]);
            int streetsNumber = int.Parse(inputNumbers[1]);
            int hospitalsNumber = int.Parse(inputNumbers[2]);

            Dictionary<Node, List<Connection>> graph = new Dictionary<Node, List<Connection>>();
            Dictionary<int, Node> allNodes = new Dictionary<int, Node>();

            string[] allHospitals = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < streetsNumber; i++)
            {
                string[] currentStreet = Console.ReadLine().Split(' ');
                int firstNode = int.Parse(currentStreet[0]);
                int secondNode = int.Parse(currentStreet[1]);
                int distance = int.Parse(currentStreet[2]);

                if (!allNodes.ContainsKey(firstNode))
                {
                    allNodes.Add(firstNode, new Node(firstNode));
                }

                if (!allNodes.ContainsKey(secondNode))
                {
                    allNodes.Add(secondNode, new Node(secondNode));
                }

                Node firstNodeObject = allNodes[firstNode];
                Node secondNodeObject = allNodes[secondNode];

                if (!graph.ContainsKey(firstNodeObject))
                {
                    graph.Add(firstNodeObject, new List<Connection>());
                }

                if (!graph.ContainsKey(secondNodeObject))
                {
                    graph.Add(secondNodeObject, new List<Connection>());
                }

                graph[firstNodeObject].Add(new Connection(secondNodeObject, distance));
                graph[secondNodeObject].Add(new Connection(firstNodeObject, distance));
            }

            for (int i = 0; i < allHospitals.Length; i++)
            {
                int currentHospitalId = int.Parse(allHospitals[i]);
                allNodes[currentHospitalId].IsHospital = true;
            }

            long result = long.MaxValue;

            for (int i = 0; i < allHospitals.Length; i++)
            {
                int currentHospitalId = int.Parse(allHospitals[i]);
                DijkstraAlgorithm(graph, allNodes[currentHospitalId]);

                long tempSum = 0;
                foreach (var node in allNodes)
                {
                    if (!node.Value.IsHospital)
                    {
                        tempSum += node.Value.DijkstraDistance;
                    }
                }

                if (tempSum < result)
                {
                    result = tempSum;
                }
            }

            Console.WriteLine(result);
        }

        public static void DijkstraAlgorithm(Dictionary<Node, List<Connection>> graph, Node startNode)
        {
            PriorityQueue<Node> queue = new PriorityQueue<Node>();

            foreach (var node in graph)
            {
                node.Key.DijkstraDistance = long.MaxValue;
            }

            startNode.DijkstraDistance = 0;
            queue.Enqueue(startNode);

            while (queue.Count != 0)
            {
                Node minCurrentNode = queue.Dequeue();

                if (minCurrentNode.DijkstraDistance == long.MaxValue)
                {
                    break;
                }

                foreach (var connection in graph[minCurrentNode])
                {
                    var potentialDistance = minCurrentNode.DijkstraDistance + connection.Distance;
                    if (potentialDistance < connection.ToNode.DijkstraDistance)
                    {
                        connection.ToNode.DijkstraDistance = potentialDistance;
                        queue.Enqueue(connection.ToNode);
                    }
                }
            }
        }
    }
}