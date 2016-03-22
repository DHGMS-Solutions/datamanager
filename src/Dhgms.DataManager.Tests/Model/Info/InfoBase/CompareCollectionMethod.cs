using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.DataManager.Tests.Model.Info.InfoBase
{
    using System.Xml;

    using Xunit;

    public class CompareCollectionMethod : global::Dhgms.DataManager.Model.Info.InfoBase<CompareCollectionMethod>
    {
        [Fact]
        public void BothArgumentsAreNull()
        {
            var result = CompareCollection<string>(null, null);
            Assert.Equal(0, result);
        }


        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">
        /// The other.
        /// </param>
        /// <return>
        /// 0 if equal, otherwise non zero
        /// </return>
        /// <exception cref="NotImplementedException">Method not implemented</exception>
        /// <returns>
        /// The compare to.
        /// </returns>
        public override int CompareTo(CompareCollectionMethod other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks if the values of two objects are the same
        /// </summary>
        /// <param name="other">
        /// The other object to compare
        /// </param>
        /// <exception cref="NotImplementedException">Method not implemented</exception>
        /// <returns>
        /// True if they match, otherwise false
        /// </returns>
        public override bool Equals(CompareCollectionMethod other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the hash code for the object
        /// </summary>
        /// <exception cref="NotImplementedException">Method not implemented</exception>
        /// <returns>
        /// hash code
        /// </returns>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The on disposing event
        /// </summary>
        /// <exception cref="NotImplementedException">Method not implemented</exception>
        protected override void OnDisposing()
        {
            throw new NotImplementedException();
        }
    }
}
