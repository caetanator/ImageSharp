﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Collections.Generic;
using System.IO;
using SixLabors.ImageSharp.PixelFormats;

namespace SixLabors.ImageSharp.Formats.Bmp
{
    /// <summary>
    /// Configuration options for use during BMP encoding
    /// </summary>
    /// <remarks>The encoder can currently only write 24-bit RGB images to streams.</remarks>
    internal interface IBmpEncoderOptions
    {
        /// <summary>
        /// Gets the number of bits per pixel.
        /// </summary>
        BmpBitsPerPixel BitsPerPixel { get; }
    }
}
