namespace ACBindings.Internal;

public unsafe struct ChannelSystem
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x005D0190
    /// int __cdecl ChannelSystem::GetChannelID(CLogonHeader::HandshakeWireData)</code>
    /// </summary>
    public static int GetChannelID(ACBindings.Internal.CLogonHeader.HandshakeWireData a1) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CLogonHeader.HandshakeWireData, int>)0x005D0190)(a1);

    /// <summary>
    /// <code>Offset: 0x005D0C10
    /// int __cdecl ChannelSystem::GetGlobalChannelName(int,int*)</code>
    /// </summary>
    public static int GetGlobalChannelName(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005D0C10)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005D0D20
    /// int __cdecl ChannelSystem::GetChannelName(unsigned int,int*)</code>
    /// </summary>
    public static int GetChannelName(uint a1, int* a2) => ((delegate* unmanaged[Cdecl]<uint, int*, int>)0x005D0D20)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005D0F70
    /// int __cdecl ChannelSystem::GetGlobalChannelName_1(int,int*)</code>
    /// </summary>
    public static int GetGlobalChannelName_1(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005D0F70)(a1, a2);
}

