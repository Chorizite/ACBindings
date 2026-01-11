namespace ACBindings.Internal;

// WaveformType
public enum WaveformType : byte
{
    WAVEFORM_INVALID = 0x0,
    WAVEFORM_NONE = 0x1,
    WAVEFORM_SPEED = 0x2,
    WAVEFORM_NOISE = 0x3,
    WAVEFORM_SINE = 0x4,
    WAVEFORM_SQUARE = 0x5,
    WAVEFORM_BOUNCE = 0x6,
    WAVEFORM_PERLIN = 0x7,
    WAVEFORM_FRACTAL = 0x8,
    WAVEFORM_FRAMELOOP = 0x9,
    NUM_WAVEFORMS = 0xA
}

