using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Algorithms.ArraySamples;
using Xunit;

namespace AlgorithmTests.ArraySamples
{
    public class MaxSubArrayTests
    {
        [Fact]
        public void GetMaxSubArrayCountTest(){
            var array = new int[]{-2,1,-3,4,-1,2,1,-5,4};
            var actual = new MaxSubArray().GetMaxSubArrayCount(array);
            Assert.Equal(6, actual);
        }
    }
}
