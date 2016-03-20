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


        public override int CompareTo(CompareCollectionMethod other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(CompareCollectionMethod other)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        protected override void OnDisposing()
        {
            throw new NotImplementedException();
        }
    }
}
