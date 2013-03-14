// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Permutation.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Represents a set of permutations
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Info
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a set of permutations
    /// </summary>
    public class PermutationSet
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PermutationSet"/> class. 
        /// Constructor
        /// </summary>
        public PermutationSet()
        {
            this.Items = new List<string>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// List of items to this set of permutations
        /// </summary>
        public IList<string> Items { get; private set; }
        #endregion
    }
}

namespace Dhgms.DataManager.Model.Helper
{
    using System;
    using System.Collections.Generic;

    using Dhgms.DataManager.Model.Info;

    /// <summary>
    /// Helper for working out permutations
    /// </summary>
    public static class Permutation
    {
        #region Public Methods and Operators

        /// <summary>
        /// Gets the permutations of a list of items
        /// </summary>
        /// <param name="items">
        /// List
        /// </param>
        /// <returns>
        /// The permutations
        /// </returns>
        public static IList<PermutationSet> GetPermutations(this IList<string> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException("items");
            }

            var results = new List<PermutationSet>();

            // do multiple permutations
            // a, b, c, d
            // a+b, a+c, a+d, b+c, b+d, c+d
            // a+b+c, a+b+d, b+c+d
            // a+b+c+d
            int maxPermutationSize = items.Count;
            for (int permutationSize = 1; permutationSize <= maxPermutationSize; permutationSize++)
            {
                int lastStartPosition = maxPermutationSize - permutationSize;

                // start position
                for (int startPositionCounter = 0; startPositionCounter <= lastStartPosition; startPositionCounter++)
                {
                    var innerList = new PermutationSet();
                    innerList.Items.Add(items[startPositionCounter]);
                    for (int latterLetterPosition = startPositionCounter + 1;
                         latterLetterPosition < maxPermutationSize;
                         latterLetterPosition++)
                    {
                        innerList.Items.Add(items[latterLetterPosition]);
                    }

                    results.Add(innerList);
                }
            }

            return results;
        }

        #endregion
    }
}