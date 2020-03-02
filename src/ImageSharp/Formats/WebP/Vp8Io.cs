// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;

namespace SixLabors.ImageSharp.Formats.WebP
{
    internal ref struct Vp8Io
    {
        /// <summary>
        /// Gets or sets the picture width in pixels (invariable).
        /// Original, uncropped dimensions.
        /// The actual area passed to put() is stored in <see cref="MbW"/> /> field.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the picture height in pixels (invariable).
        /// Original, uncropped dimensions.
        /// The actual area passed to put() is stored in <see cref="MbH"/> /> field.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the y-position of the current macroblock.
        /// </summary>
        public int MbY { get; set; }

        /// <summary>
        /// Gets or sets the macroblock width.
        /// </summary>
        public int MbW { get; set; }

        /// <summary>
        /// Gets or sets the macroblock height.
        /// </summary>
        public int MbH { get; set; }

        /// <summary>
        /// Rows to copy (in YUV format).
        /// </summary>
        public Span<byte> Y { get; set; }

        /// <summary>
        /// Rows to copy (in YUV format).
        /// </summary>
        public Span<byte> U { get; set; }

        /// <summary>
        /// Rows to copy (in YUV format).
        /// </summary>
        public Span<byte> V { get; set; }

        /// <summary>
        /// Gets or sets the row stride for luma.
        /// </summary>
        public int YStride { get; set; }

        /// <summary>
        /// Gets or sets the row stride for chroma.
        /// </summary>
        public int UvStride { get; set; }

        public bool UseCropping { get; set; }

        public int CropLeft { get; set; }

        public int CropRight { get; set; }

        public int CropTop { get; set; }

        public int CropBottom { get; set; }

        public bool UseScaling { get; set; }

        public int ScaledWidth { get; set; }

        public int ScaledHeight { get; set; }

        /// <summary>
        /// User data
        /// </summary>
        private object Opaque { get; set; }
    }
}
