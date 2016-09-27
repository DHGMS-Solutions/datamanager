using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dhgms.DataManager.Model.Helper
{
    public static class ComparableHelper
    {
        public static int CompareReferenceType<T>(T item1, T item2) where T : class, IComparable<T>
        {
            if (item1 == null)
            {
                return item2 == null ? 0 : -1;
            }

            if (item2 == null)
            {
                return 1;
            }

            return ReferenceEquals(item1, item2) ? 0 : item1.CompareTo(item2);
        }
    }
}
