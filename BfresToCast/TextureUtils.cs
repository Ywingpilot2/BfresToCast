using BfresLibrary.Switch;
using ImageLibrary;
using Syroot.NintenTools.NSW.Bntx.GFX;

namespace BfresToCast;

public static class TextureUtils
{
    public static Dictionary<int, ImageEncoder> FormatList = new Dictionary<int, ImageEncoder>()
    {
        { (int)SurfaceFormat.R8_G8_B8_A8_UNORM, ImageFormats.Rgba8() },
        { (int)SurfaceFormat.R8_G8_B8_A8_SRGB, ImageFormats.Rgba8(true) },
        { (int)SurfaceFormat.R8_G8_UNORM, ImageFormats.Rg8() },
        { (int)SurfaceFormat.R8_G8_SNORM, ImageFormats.Rg8Signed()},
        { (int)SurfaceFormat.R8_UNORM, ImageFormats.R8() },
        { (int)SurfaceFormat.R16_UNORM, ImageFormats.R16() },
        { (int)SurfaceFormat.R16_UINT, ImageFormats.R16() },
        { (int)SurfaceFormat.R32_UNORM, ImageFormats.R32() },
        { (int)SurfaceFormat.R32_G32_B32_A32_UNORM, ImageFormats.Rgba32() },

        { (int)SurfaceFormat.D32_FLOAT_S8X24_UINT, ImageFormats.Rgba8() },

        { (int)SurfaceFormat.R11_G11_B10_UNORM,  ImageFormats.R11g11b10() },
        { (int)SurfaceFormat.R5_G5_B5_A1_UNORM,  ImageFormats.Rgba5551() },
        { (int)SurfaceFormat.R5_G6_B5_UNORM, ImageFormats.Rgba565() },
        { (int)SurfaceFormat.R4_G4_UNORM, ImageFormats.Rg4() },
        { (int)SurfaceFormat.R4_G4_B4_A4_UNORM, ImageFormats.Rgba4() },

        { (int)SurfaceFormat.B8_G8_R8_A8_UNORM, ImageFormats.Bgra8() },
        { (int)SurfaceFormat.B8_G8_R8_A8_SRGB,  ImageFormats.Bgra8(true) },

        { (int)SurfaceFormat.BC1_UNORM, ImageFormats.Bc1() },
        { (int)SurfaceFormat.BC1_SRGB,  ImageFormats.Bc1(true) },
        { (int)SurfaceFormat.BC2_UNORM, ImageFormats.Bc2() },
        { (int)SurfaceFormat.BC2_SRGB,  ImageFormats.Bc2(true) },
        { (int)SurfaceFormat.BC3_UNORM, ImageFormats.Bc3()  },
        { (int)SurfaceFormat.BC3_SRGB,  ImageFormats.Bc3(true) },
        { (int)SurfaceFormat.BC4_UNORM, ImageFormats.Bc4() },
        { (int)SurfaceFormat.BC4_SNORM, ImageFormats.Bc4(true) },
        { (int)SurfaceFormat.BC5_UNORM, ImageFormats.Bc5() },
        { (int)SurfaceFormat.BC5_SNORM, ImageFormats.Bc5(true) },
        { (int)SurfaceFormat.BC6_UFLOAT, ImageFormats.Bc6() },
        { (int)SurfaceFormat.BC6_FLOAT, ImageFormats.Bc6(true) },
        { (int)SurfaceFormat.BC7_UNORM, ImageFormats.Bc7() },
        { (int)SurfaceFormat.BC7_SRGB, ImageFormats.Bc7(true) },

        { (int)SurfaceFormat.ASTC_4x4_UNORM, ImageFormats.Astc4x4() },
        { (int)SurfaceFormat.ASTC_4x4_SRGB,  ImageFormats.Astc4x4(true) },
        { (int)SurfaceFormat.ASTC_5x4_UNORM, ImageFormats.Astc5x4() },
        { (int)SurfaceFormat.ASTC_5x4_SRGB,  ImageFormats.Astc5x4(true) },
        { (int)SurfaceFormat.ASTC_5x5_UNORM, ImageFormats.Astc5x5() },
        { (int)SurfaceFormat.ASTC_5x5_SRGB,  ImageFormats.Astc5x5(true) },
        { (int)SurfaceFormat.ASTC_6x5_UNORM, ImageFormats.Astc6x5() },
        { (int)SurfaceFormat.ASTC_6x5_SRGB,  ImageFormats.Astc6x5(true) },
        { (int)SurfaceFormat.ASTC_6x6_UNORM, ImageFormats.Astc6x6() },
        { (int)SurfaceFormat.ASTC_6x6_SRGB,  ImageFormats.Astc6x6(true) },
        { (int)SurfaceFormat.ASTC_8x5_UNORM, ImageFormats.Astc8x5() },
        { (int)SurfaceFormat.ASTC_8x5_SRGB,  ImageFormats.Astc8x5(true) },
        { (int)SurfaceFormat.ASTC_8x6_UNORM, ImageFormats.Astc8x6() },
        { (int)SurfaceFormat.ASTC_8x6_SRGB,  ImageFormats.Astc8x6(true) },
        { (int)SurfaceFormat.ASTC_8x8_UNORM, ImageFormats.Astc8x8() },
        { (int)SurfaceFormat.ASTC_8x8_SRGB,  ImageFormats.Astc8x8(true) },
        { (int)SurfaceFormat.ASTC_10x5_UNORM, ImageFormats.Astc10x5() },
        { (int)SurfaceFormat.ASTC_10x5_SRGB,  ImageFormats.Astc10x5(true) },
        { (int)SurfaceFormat.ASTC_10x6_UNORM, ImageFormats.Astc10x6() },
        { (int)SurfaceFormat.ASTC_10x6_SRGB,  ImageFormats.Astc10x6(true) },
        { (int)SurfaceFormat.ASTC_10x8_UNORM, ImageFormats.Astc10x8() },
        { (int)SurfaceFormat.ASTC_10x8_SRGB,  ImageFormats.Astc10x8(true) },
        { (int)SurfaceFormat.ASTC_10x10_UNORM, ImageFormats.Astc10x10() },
        { (int)SurfaceFormat.ASTC_10x10_SRGB,  ImageFormats.Astc10x10(true) },
        { (int)SurfaceFormat.ASTC_12x10_UNORM, ImageFormats.Astc12x10() },
        { (int)SurfaceFormat.ASTC_12x10_SRGB,  ImageFormats.Astc12x10(true) },
        { (int)SurfaceFormat.ASTC_12x12_UNORM, ImageFormats.Astc12x12() },
        { (int)SurfaceFormat.ASTC_12x12_SRGB,  ImageFormats.Astc12x12(true) },
    };

    public static bool IsFloat(SurfaceFormat fmt)
    {
        switch (fmt)
        {
            case SurfaceFormat.BC6_FLOAT: return true;
            case SurfaceFormat.BC6_UFLOAT: return true;
            default: return false;
        }
    }

    public static byte[] ConvertChannels(byte[] data, SwitchTexture tex)
    {
        byte[] rgba = new byte[data.Length];

        int offset = 0;

        byte GetChannel(ChannelType type)
        {
            if (type == ChannelType.One) return 255;
            else if (type == ChannelType.Zero) return 0;
            else if (type == ChannelType.Red) return data[offset + 0];
            else if (type == ChannelType.Green) return data[offset + 1];
            else if (type == ChannelType.Blue) return data[offset + 2];
            else if (type == ChannelType.Alpha) return data[offset + 3];

            return 255;
        }

        for (int x = 0; x < tex.Texture.Width; x++)
        {
            for (int y = 0; y < tex.Texture.Height; y++)
            {
                rgba[offset + 0] = GetChannel(tex.Texture.ChannelRed);
                rgba[offset + 1] = GetChannel(tex.Texture.ChannelGreen);
                rgba[offset + 2] = GetChannel(tex.Texture.ChannelBlue);
                rgba[offset + 3] = GetChannel(tex.Texture.ChannelAlpha);
                offset += 4;
            }
        }
        return rgba;
    }

    //public static float[] DecodeHdr(byte[] input, uint width, uint height)
    //{
    //    BcDecoder decoder = new BcDecoder();
    //    CompressionFormat compressionFormat = CompressionFormat.Bc6U;

    //    var colors = decoder.DecodeRawHdr(new MemoryStream(input), (int)width, (int)height, compressionFormat);

    //    float[] output = new float[colors.Length * 3];
    //    for (int i = 0; i < colors.Length; i++)
    //    {
    //        int offset = i * 3;

    //        output[offset + 0] = colors[i].r;
    //        output[offset + 1] = colors[i].g;
    //        output[offset + 2] = colors[i].b;
    //    }
    //    return output;
    //}

    public static void ToDDS(SwitchTexture tex, ImageEncoder encoder, byte[] data, string path)
    {
        var dds = new DDS();
        dds.MainHeader.Width = tex.Width;
        dds.MainHeader.Height = tex.Height;
        dds.MainHeader.Depth = tex.Depth;
        dds.MainHeader.MipCount = tex.MipCount;

        dds.ImageData = data;
        dds.MainHeader.PitchOrLinearSize = (uint)dds.ImageData.Length / tex.ArrayLength;

        int CalculateMipDimension(uint baseLevelDimension, int mipLevel)
        {
            return Math.Max((int)Math.Ceiling(baseLevelDimension / Math.Pow(2, mipLevel)), 1);
        }

        DDS.DXGI_FORMAT format = DDS.DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM;
        if (encoder is Bcn)
            format = ((Bcn)encoder).GetDxgiFormat();

        bool isCubemap = tex.Texture.SurfaceDim == SurfaceDim.DimCube ||
                         tex.Texture.SurfaceDim == SurfaceDim.DimCubeArray;

        if (tex.ArrayLength > 1) //Use DX10 format for array surfaces as it can do custom amounts
            dds.SetFlags(format, true, isCubemap);
        else
            dds.SetFlags(format, false, isCubemap);

        if (dds.IsDX10)
        {
            dds.Dx10Header = new DDS.DX10Header();
            dds.Dx10Header.ResourceDim = 3;
            if (isCubemap)
                dds.Dx10Header.ArrayCount = (uint)(tex.ArrayLength / 6);
            else
                dds.Dx10Header.ArrayCount = (uint)tex.ArrayLength;
            dds.Dx10Header.DxgiFormat = (uint)format;
        }
        dds.Save(path);
    }
}