﻿// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Numerics;

namespace SixLabors.ImageSharp.Formats.Jpeg.Components.Decoder.ColorConverters
{
    internal abstract partial class JpegColorConverter
    {
        internal abstract class VectorizedJpegColorConverter : JpegColorConverter
        {
            private readonly int vectorSize;

            protected VectorizedJpegColorConverter(JpegColorSpace colorSpace, int precision, int vectorSize)
                : base(colorSpace, precision)
            {
                this.vectorSize = vectorSize;
            }

            public override void ConvertToRgbInplace(in ComponentValues values)
            {
                int length = values.Component0.Length;
                int remainder = values.Component0.Length % this.vectorSize;
                int simdCount = length - remainder;
                if (simdCount > 0)
                {
                    // This implementation is actually AVX specific.
                    // An AVX register is capable of storing 8 float-s.
                    if (!this.IsAvailable)
                    {
                        throw new InvalidOperationException(
                            "This converter can be used only on architecture having 256 byte floating point SIMD registers!");
                    }

                    this.ConvertCoreVectorizedInplace(values.Slice(0, simdCount));
                }

                this.ConvertCoreInplace(values.Slice(simdCount, remainder));
            }

            protected virtual void ConvertCoreVectorizedInplace(in ComponentValues values) => throw new NotImplementedException();

            protected virtual void ConvertCoreInplace(in ComponentValues values) => throw new NotImplementedException();
        }
    }
}
