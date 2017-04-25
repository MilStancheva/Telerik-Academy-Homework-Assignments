using System;
using System.Collections.Generic;

namespace Problem_1___Implement_Tree
{
    public class TreeNode<T>
    {
        private string valueCannotBeNullExceptionMessage = "Value cannot be null";

        public TreeNode()
        {
            this.Children = new List<TreeNode<T>>();
        }

        public TreeNode(T value) 
            : this()
        {
            if (value == null)
            {
                throw new ArgumentException(valueCannotBeNullExceptionMessage);
            }

            this.Value = value;
        }

        public T Value { get; set; }

        public List<TreeNode<T>> Children { get; set; }

        public bool HasParent { get; set; }
    }
}