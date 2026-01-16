namespace ACBindings.Internal;


/// <summary>
/// Manages chat channel identification and provides mappings between channel identifiers and their human‑readable names, including handling global channel name retrieval.
/// </summary>
public unsafe struct ChannelSystem
{
    // Statics
    public static ACBindings.Internal.AC1Legacy.PStringBase__ushort* Allegiance_GlobalChannelName = (ACBindings.Internal.AC1Legacy.PStringBase__ushort*)0x008F0F00;
    public static ACBindings.Internal.AC1Legacy.PStringBase__ushort* General_GlobalChannelName = (ACBindings.Internal.AC1Legacy.PStringBase__ushort*)0x008F0F04;
    public static ACBindings.Internal.AC1Legacy.PStringBase__ushort* Trade_GlobalChannelName = (ACBindings.Internal.AC1Legacy.PStringBase__ushort*)0x008F0F08;
    public static ACBindings.Internal.AC1Legacy.PStringBase__ushort* LFG_GlobalChannelName = (ACBindings.Internal.AC1Legacy.PStringBase__ushort*)0x008F0F0C;
    public static ACBindings.Internal.AC1Legacy.PStringBase__ushort* Roleplay_GlobalChannelName = (ACBindings.Internal.AC1Legacy.PStringBase__ushort*)0x008F0F10;
    public static ACBindings.Internal.AC1Legacy.PStringBase__ushort* Society_GlobalChannelName = (ACBindings.Internal.AC1Legacy.PStringBase__ushort*)0x008F0F14;
    public static ACBindings.Internal.AC1Legacy.PStringBase__ushort* SocietyCelHan_GlobalChannelName = (ACBindings.Internal.AC1Legacy.PStringBase__ushort*)0x008F0F18;
    public static ACBindings.Internal.AC1Legacy.PStringBase__ushort* SocietyEldWeb_GlobalChannelName = (ACBindings.Internal.AC1Legacy.PStringBase__ushort*)0x008F0F1C;
    public static ACBindings.Internal.AC1Legacy.PStringBase__ushort* SocietyRadBlo_GlobalChannelName = (ACBindings.Internal.AC1Legacy.PStringBase__ushort*)0x008F0F20;
    public static ACBindings.Internal.AC1Legacy.PStringBase__ushort* Olthoi_GlobalChannelName = (ACBindings.Internal.AC1Legacy.PStringBase__ushort*)0x008F0F24;

    // Methods

    /// <summary>Returns the channel identifier derived from the client's handshake data.
    /// <code>Offset: 0x005D0190
    /// int __cdecl ChannelSystem::GetChannelID(CLogonHeader::HandshakeWireData)</code>
    /// </summary>
    /// <param name="a1">Handshake information that includes a client version string used to determine the channel.</param>
    /// <returns>An integer bitmask representing the channel ID, or zero when no match is found or the data is invalid.</returns>
    public static int GetChannelID(ACBindings.Internal.CLogonHeader.HandshakeWireData a1) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CLogonHeader.HandshakeWireData, int>)0x005D0190)(a1);

    /// <summary>Retrieves the name of a global chat channel identified by its type and writes it into the supplied string buffer.
    /// <code>Offset: 0x005D0C10
    /// int __cdecl ChannelSystem::GetGlobalChannelName(int,int*)</code>
    /// </summary>
    /// <param name="a1">Identifier for the desired global channel (e.g., 1=Allegiance, 2=General, etc.).</param>
    /// <param name="a2">Pointer to a string object where the channel name will be stored.</param>
    /// <returns>Non‑zero if the channel exists and its name was copied; zero otherwise.</returns>
    public static int GetGlobalChannelName(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005D0C10)(a1, a2);

    /// <summary>Retrieves the human‑readable name for a given channel ID and writes it into the supplied string object.
    /// <code>Offset: 0x005D0D20
    /// int __cdecl ChannelSystem::GetChannelName(unsigned int,int*)</code>
    /// </summary>
    /// <param name="a1">Channel identifier to query.</param>
    /// <param name="a2">Pointer to an object that will receive the channel name.</param>
    /// <returns>Non‑zero if a matching channel name was found; zero otherwise.</returns>
    public static int GetChannelName(uint a1, int* a2) => ((delegate* unmanaged[Cdecl]<uint, int*, int>)0x005D0D20)(a1, a2);

    /// <summary>Retrieves the global channel name for the specified channel index, assigning it to *a2 and returning an integer identifier.
    /// <code>Offset: 0x005D0F70
    /// int __cdecl ChannelSystem::GetGlobalChannelName_1(int,int*)</code>
    /// </summary>
    /// <param name="a1">The channel index or identifier whose global name is requested.</param>
    /// <param name="a2">Pointer to a location where the resulting string reference will be stored; updated with reference count management.</param>
    /// <returns>An integer representing the retrieved global channel name identifier.</returns>
    public static int GetGlobalChannelName_1(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005D0F70)(a1, a2);
}

