﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

namespace SixLabors.ImageSharp.Formats.Bmp
{
    /// <summary>
    /// Stores general information about the Bitmap file.
    /// <seealso href="https://en.wikipedia.org/wiki/BMP_file_format">See this Wikipedia link for more information.</seealso>
    /// </summary>
    /// <remarks>
    /// The first two bytes of the Bitmap file format
    /// (thus the Bitmap header) are stored in big-endian order.
    /// All of the other integer values are stored in little-endian format
    /// (i.e. least-significant byte first).
    /// </remarks>
    internal sealed class BmpFileHeader
    {
        /// <summary>
        /// Defines of the data structure in the bitmap file.
        /// </summary>
        public const int Size = 14;

        /// <summary>
        /// Gets or sets the Bitmap identifier.
        /// The field used to identify the bitmap file: 0x42 0x4D
        /// (Hex code points for B and M)
        /// </summary>
        public ushort Type { get; set; }

        /// <summary>
        /// Gets or sets the size of the bitmap file in bytes.
        /// </summary>
        public uint FileSize { get; set; }

        /// <summary>
        /// Gets or sets any reserved data; actual value depends on the application
        /// that creates the image.
        /// </summary>
        public ushort Reserved1 { get; set; }

        /// <summary>
        /// Gets or sets any reserved data; actual value depends on the application
        /// that creates the image.
        /// </summary>
        public ushort Reserved2 { get; set; }

        /// <summary>
        /// Gets or sets the offset, i.e. starting address, of the byte where
        /// the bitmap data can be found.
        /// </summary>
        public uint Offset { get; set; }
    }
}
