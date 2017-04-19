using System;
using System.Collections.Generic;

namespace Problem_1___Implement_Tree
{
    public class StartUp
    {
        public static void Main()
        {
            /* Write a program to read the tree and find:
               7
               2 4
               3 2
               5 0
               3 5
               5 6
               5 1
           */

            Console.WriteLine("Please, enter N:");
            int n = int.Parse(Console.ReadLine());
            var nodes = new TreeNode<int>[n];

            for (int i = 0; i < n; i++)
            {
                nodes[i] = new TreeNode<int>(i);
            }

            for (int i = 1; i <= n - 1; i++)
            {
                var edgeAsString = Console.ReadLine();
                var edgeParts = edgeAsString.Split(' ');

                int parentId = int.Parse(edgeParts[0].Trim());
                int childId = int.Parse(edgeParts[1].Trim());
                nodes[parentId].Children.Add(nodes[childId]);
                nodes[childId].HasParent = true;
            }          

            // a) Find the root node
            var root = FindRoot(nodes);
            Console.WriteLine("The root of the tree is: {0}", root.Value);

            // b) Find all leaf nodes
            var leaves = FindAllLeaves(nodes);
            Console.Write("Leaves: ");
            foreach (var leaf in leaves)
            {
                Console.Write("{0} ", leaf.Value);
            }
            Console.WriteLine();

            // c) Find all middle nodes
            var middleNodes = FindAllMiddleNodes(nodes);
            Console.Write("Middle nodes: ");
            foreach (var node in middleNodes)
            {
                Console.Write("{0} ", node.Value);
            }
            Console.WriteLine();

            // d) Find the longest path from the root
            var longestPath = FindLongestPath(root);
            Console.WriteLine("The longest path from the root is: {0}", longestPath);
            Console.WriteLine("The number of levels is: {0}", longestPath + 1);
        }

        private static int FindLongestPath(TreeNode<int> root)
        {
            var longestPath = 0;

            if (root.Children.Count == 0)
            {
                return 0;
            }

            foreach (var node in root.Children)
            {
                longestPath = Math.Max(longestPath, FindLongestPath(node));
            }

            longestPath++;

            return longestPath;
        }

        private static List<TreeNode<int>> FindAllMiddleNodes(TreeNode<int>[] nodes)
        {
            var middleNodes = new List<TreeNode<int>>();

            foreach (var node in nodes)
            {
                if (node.HasParent && node.Children.Count > 0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        private static List<TreeNode<int>> FindAllLeaves(TreeNode<int>[] nodes)
        {
            var leaves = new List<TreeNode<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leaves.Add(node);
                }
            }

            return leaves;
        }

        static TreeNode<int> FindRoot(TreeNode<int>[] nodes)
        {
            var hasParent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParent[child.Value] = true;
                }
            }

            for (int i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return nodes[i];
                }
            }

            throw new ArgumentException("nodes", "The input data is not valid and the tree does not have a root");
        }       
    }
}