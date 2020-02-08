﻿using System.IO;
using System.Linq;
using Nova3diLab.Tests;
using Xunit;

namespace Nova3diLab.Model.Lod.Tests
{
    public class SubObjectTests
    {
        [Fact]
        public void SerializeTest()
        {
            var subObject = new SubObject
            {
                VertexCount = 8,
                FacesCount = 12,
                NormalsCount = 12,
                CollisionVolumesCount = 1,
                XMaximum = 1,
                YMaximum = 1,
                ZMaximum = 1,
                XMedian = .5,
                YMedian = .5,
                ZMedian = .5,
                BoundingSphereRadius = 1.73205080756888
            };

            var expected = File.ReadAllBytes("Resources/sub-object.3di");
            Assert.True(expected.SequenceEqual(TestUtils.SerializeToBytes(subObject)));
        }

        [Fact]
        public void DeserializeTest()
        {
        }
    }
}