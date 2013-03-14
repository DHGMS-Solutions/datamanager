// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tree.cs" company="DHGMS Solutions">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Represents a tree data structure
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Collections.Generic
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a tree data structure
    /// </summary>
    /// <typeparam name="TDataType">
    /// The data type for the node
    /// </typeparam>
    public class Tree<TDataType> : IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tree{TDataType}"/> class.
        /// </summary>
        public Tree()
        {
            this.Children = new LinkedList<TreeNode<TDataType>>();
        }

        /// <summary>
        /// Gets a value indicating whether the node has children.
        /// </summary>
        public bool HasChildren
        {
            get
            {
                return this.Children != null && this.Children.Count > 0;
            }
        }

        /// <summary>
        /// Gets the child nodes collection
        /// </summary>
        public LinkedList<TreeNode<TDataType>> Children
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the value of the node
        /// </summary>
        public TDataType Value
        {
            get;
            set;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public virtual void Dispose()
        {
        }
    }
}
