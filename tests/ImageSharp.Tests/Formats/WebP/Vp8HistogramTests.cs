// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

using System.Collections.Generic;
using SixLabors.ImageSharp.Formats.Webp.Lossy;
using Xunit;

namespace SixLabors.ImageSharp.Tests.Formats.Webp
{
    [Trait("Format", "Webp")]
    public class Vp8HistogramTests
    {
        public static IEnumerable<object[]> Data
        {
            get
            {
                var result = new List<object[]>();
                result.Add(new object[]
                {
                    new byte[]
                    {
                        16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 19, 16, 128, 128, 128, 128, 128, 128,
                        128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16,
                        16, 16, 16, 19, 16, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128,
                        128, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 19, 16, 128, 128, 128, 128, 128,
                        128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16,
                        16, 16, 16, 16, 19, 16, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128,
                        128, 128, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 19, 16, 128, 128, 128, 128,
                        128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 16, 16, 16, 16, 16, 16, 16, 16, 16,
                        16, 16, 16, 16, 16, 19, 16, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128,
                        128, 128, 128, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 19, 16, 128, 128, 128,
                        128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 16, 16, 16, 16, 16, 16, 16, 16,
                        16, 16, 16, 16, 16, 16, 19, 16, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128,
                        128, 128, 128, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 19, 16, 204, 204, 204,
                        204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 16, 16, 16, 16, 16, 16, 16, 16,
                        16, 16, 16, 16, 16, 16, 19, 16, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204,
                        204, 204, 204, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 19, 16, 204, 204, 204,
                        204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 16, 16, 16, 16, 16, 16, 16, 16,
                        16, 16, 16, 16, 16, 16, 19, 16, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204,
                        204, 204, 204, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 19, 16, 204, 204, 204,
                        204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 16, 16, 16, 16, 16, 16, 16, 16,
                        16, 16, 16, 16, 16, 16, 19, 16, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204,
                        204, 204, 204, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 24, 16, 204, 204, 204,
                        204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 16, 16, 16, 16, 16, 16, 16, 16,
                        16, 16, 16, 16, 16, 16, 16, 16, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204,
                        204, 204, 204
                    },
                    new byte[]
                    {
                        128, 128, 128, 128, 129, 129, 129, 129, 127, 127, 127, 127, 129, 129, 129, 129, 128, 127, 127,
                        127, 127, 127, 127, 127, 127, 127, 127, 127, 127, 127, 127, 127, 128, 128, 128, 128, 129, 129,
                        129, 129, 127, 127, 127, 127, 129, 129, 129, 129, 129, 128, 127, 127, 128, 127, 127, 127, 127,
                        127, 127, 127, 127, 127, 127, 127, 128, 128, 128, 128, 129, 129, 129, 129, 127, 127, 127, 127,
                        129, 129, 129, 129, 129, 129, 128, 127, 129, 127, 127, 127, 127, 127, 127, 127, 127, 127, 127,
                        127, 128, 128, 128, 128, 129, 129, 129, 129, 127, 127, 127, 127, 129, 129, 129, 129, 129, 129,
                        129, 128, 129, 128, 127, 127, 127, 127, 127, 127, 127, 127, 127, 127, 128, 128, 127, 127, 129,
                        129, 129, 129, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204,
                        204, 204, 204, 204, 204, 204, 204, 204, 129, 129, 128, 128, 129, 129, 129, 129, 204, 204, 204,
                        204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204,
                        204, 204, 129, 129, 129, 129, 129, 129, 129, 129, 204, 204, 204, 204, 204, 204, 204, 204, 204,
                        204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 129, 129, 129, 129,
                        129, 129, 129, 129, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204, 204,
                        204, 204, 204, 204, 204, 204, 204, 204, 204
                    }
                });
                return result;
            }
        }

        [Fact]
        public void GetAlpha_WithEmptyHistogram_Works()
        {
            // arrange
            var histogram = new Vp8Histogram();

            // act
            int alpha = histogram.GetAlpha();

            // assert
            Assert.Equal(0, alpha);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void GetAlpha_Works(byte[] reference, byte[] pred)
        {
            // arrange
            var histogram = new Vp8Histogram();
            histogram.CollectHistogram(reference, pred, 0, 1);

            // act
            int alpha = histogram.GetAlpha();

            // assert
            Assert.Equal(1054, alpha);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void Merge_Works(byte[] reference, byte[] pred)
        {
            // arrange
            var histogram1 = new Vp8Histogram();
            histogram1.CollectHistogram(reference, pred, 0, 1);
            var histogram2 = new Vp8Histogram();
            histogram1.Merge(histogram2);

            // act
            int alpha = histogram2.GetAlpha();

            // assert
            Assert.Equal(1054, alpha);
        }
    }
}
