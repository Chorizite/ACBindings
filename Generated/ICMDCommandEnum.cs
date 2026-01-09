namespace ACBindings;

// ICMDCommandEnum
public enum ICMDCommandEnum : uint
{
    cmdNOP = 0x1,
    cmdEchoReply = 0x6C705245,
    cmdEchoRequest = 0x71655245,
    ICMDCommandEnum_Force32Bit = 0x7FFFFFFF
}

