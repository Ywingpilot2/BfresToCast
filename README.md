# BfresToCast
Simple program to extract Nintendo BFRES models to [Cast](https://github.com/dtzxporter/cast) and textures to PNG (or DDS if HDR)

Usage:
Drag and drop BFRES files onto the executable or set up a file association.

## Support
- ✔️ Uncompressed files
- ✔️ Zstd compressed files (.bfres.zs)
- ❌ SARC or Yaz0 packed files (.pack, .szs, .sbfres), these must have the bfres extracted first before the tool can be used.

## Tested with:
- Splatoon 2 (.bfres extracted from .szs container, works)
- Splatoon 3 (.bfres.zs, works)
- Paper Mario TTYD (.bfres.zst, works)
- Mario Wonder (.bfres.zs, works)
- Tears of the Kingdom (does not work, requires external strings file, may not support)

## BfresToCast makes use of the following:
- [ZstdNet](https://github.com/skbkontur/ZstdNet)
- [Cast.NET](github.com/Scobalula/Cast.NET)
- [BCnEncoder.Net](https://github.com/Nominom/BCnEncoder.NET)
- [SixLabors ImageSharp](https://github.com/SixLabors/ImageSharp)
- [BfresLibrary](https://github.com/KillzXGaming/BfresLibrary)
- ImageLibrary KillzXGaming(Unpublished)
- [Syroot BinaryData](https://gitlab.com/Syroot/BinaryData)
- [Syroot Maths](https://gitlab.com/Syroot/Maths)
- [Syroot NintenTools NSW Bntx](https://github.com/KillzXGaming/LegacySwitchLibraries)

## Special thanks:
- KillzXGaming for easy to use libraries and being super helpful overall during this project and others :)

