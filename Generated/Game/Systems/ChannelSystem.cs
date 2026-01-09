namespace ACBindings;

// ChannelSystem
public unsafe struct ChannelSystem
{
    // Statics
    public static ACBindings.AC1Legacy.PStringBase__ushort* Allegiance_GlobalChannelName = (ACBindings.AC1Legacy.PStringBase__ushort*)0x008F0F00;
    public static ACBindings.AC1Legacy.PStringBase__ushort* General_GlobalChannelName = (ACBindings.AC1Legacy.PStringBase__ushort*)0x008F0F04;
    public static ACBindings.AC1Legacy.PStringBase__ushort* Trade_GlobalChannelName = (ACBindings.AC1Legacy.PStringBase__ushort*)0x008F0F08;
    public static ACBindings.AC1Legacy.PStringBase__ushort* LFG_GlobalChannelName = (ACBindings.AC1Legacy.PStringBase__ushort*)0x008F0F0C;
    public static ACBindings.AC1Legacy.PStringBase__ushort* Roleplay_GlobalChannelName = (ACBindings.AC1Legacy.PStringBase__ushort*)0x008F0F10;
    public static ACBindings.AC1Legacy.PStringBase__ushort* Society_GlobalChannelName = (ACBindings.AC1Legacy.PStringBase__ushort*)0x008F0F14;
    public static ACBindings.AC1Legacy.PStringBase__ushort* SocietyCelHan_GlobalChannelName = (ACBindings.AC1Legacy.PStringBase__ushort*)0x008F0F18;
    public static ACBindings.AC1Legacy.PStringBase__ushort* SocietyEldWeb_GlobalChannelName = (ACBindings.AC1Legacy.PStringBase__ushort*)0x008F0F1C;
    public static ACBindings.AC1Legacy.PStringBase__ushort* SocietyRadBlo_GlobalChannelName = (ACBindings.AC1Legacy.PStringBase__ushort*)0x008F0F20;
    public static ACBindings.AC1Legacy.PStringBase__ushort* Olthoi_GlobalChannelName = (ACBindings.AC1Legacy.PStringBase__ushort*)0x008F0F24;

    // Methods
    // int __cdecl ChannelSystem::GetChannelID(CLogonHeader::HandshakeWireData)
    public static int GetChannelID(ACBindings.CLogonHeader.HandshakeWireData a1) => ((delegate* unmanaged[Cdecl]<ACBindings.CLogonHeader.HandshakeWireData, int>)0x005D0190)(a1);
    // int __cdecl ChannelSystem::GetGlobalChannelName(int,int*)
    public static int GetGlobalChannelName(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005D0C10)(a1, a2);
    // int __cdecl ChannelSystem::GetChannelName(unsigned int,int*)
    public static int GetChannelName(uint a1, int* a2) => ((delegate* unmanaged[Cdecl]<uint, int*, int>)0x005D0D20)(a1, a2);
}

