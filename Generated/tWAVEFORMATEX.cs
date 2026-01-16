namespace ACBindings.Internal;


/// <summary>Describes the basic properties of an audio stream’s waveform format—codec tag, channel count, sample rate, average bytes per second, block alignment, and bit depth—for use by Windows multimedia APIs.</summary>
public unsafe struct tWAVEFORMATEX
{
    // Members
    public ushort wFormatTag;
    public ushort nChannels;
    public uint nSamplesPerSec;
    public uint nAvgBytesPerSec;
    public ushort nBlockAlign;
    public ushort wBitsPerSample;
    public ushort cbSize;

    // Methods
}

