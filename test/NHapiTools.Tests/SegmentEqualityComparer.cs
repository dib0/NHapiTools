using System.Collections.Generic;
using NHapi.Base.Model;
using NHapiTools.Base;

namespace NHapiTools.Tests
{
    internal class SegmentEqualityComparer : IEqualityComparer<ISegment>
    {
        public bool Equals(ISegment x, ISegment y)
        {
            return x.IsEqual(y);
        }

        public int GetHashCode(ISegment obj)
        {
            return obj.GetHashCode();
        }
    }
}