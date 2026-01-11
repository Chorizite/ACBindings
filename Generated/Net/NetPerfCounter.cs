namespace ACBindings.Internal;

// NetPerfCounter
public enum NetPerfCounter : byte
{
    BytesSentCounter = 0x0,
    BytesReceivedCounter = 0x1,
    BadPacketsReceivedCounter = 0x2,
    OptionalHeadersOnlyPacketsReceivedCounter = 0x3,
    OptionalHeadersAndDataPacketsReceivedCounter = 0x4,
    DataOnlyPacketsReceivedCounter = 0x5,
    AcksReceivedCounter = 0x6,
    NaksReceivedCounter = 0x7,
    PaksReceivedCounter = 0x8,
    PacketsSentCounter = 0x9,
    RetransmitsSentCounter = 0xA,
    MiscPacketsCounter = 0xB
}

