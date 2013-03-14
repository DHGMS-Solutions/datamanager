// -----------------------------------------------------------------------
// <copyright file="TreeNode.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Collections.Generic
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    /// <summary>
    /// Represents a node in a SimpleTree structure, with a parent node and zero or more child nodes.
    /// </summary>
    /// <typeparam name="TDataType">
    /// The data type for the value.
    /// </typeparam>
    public class TreeNode<TDataType> : Tree<TDataType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeNode{T}"/> class.
        /// </summary>
        /// <param name="parent">
        /// The parent.
        /// </param>
        public TreeNode(TreeNode<TDataType> parent)
        {
            this.Parent = parent;
        }

        /// <summary>
        /// Gets the parent node
        /// </summary>
        public TreeNode<TDataType> Parent
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the root node
        /// </summary>
        public Tree<TDataType> Root
        {
            get
            {
                var node = this;
                while (node.Parent != null)
                {
                    node = node.Parent;
                }

                return node;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is the root node.
        /// </summary>
        public bool IsRoot
        {
            get
            {
                return this.Parent == null;
            }
        }
    }
}
