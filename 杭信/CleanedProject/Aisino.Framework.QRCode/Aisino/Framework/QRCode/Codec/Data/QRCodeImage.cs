﻿namespace Aisino.Framework.QRCode.Codec.Data
{
    using System;

    public interface QRCodeImage
    {
        int getPixel(int x, int y);

        int Height { get; }

        int Width { get; }
    }
}

