namespace ACBindings.Internal;


/// <summary>Tracks unique identifiers for in‑game chat rooms—allegiance, general, trade, LFG, roleplay, Olthoi, society and specific society channels—to route messages correctly within the client.</summary>
/// <remarks>The structure contains a PackObj member used for serialization; all room IDs are 32‑bit unsigned integers assigned by the server. It is aligned on a 4‑byte boundary for efficient memory layout. No inheritance is involved—baseclass_0 is a data member rather than a base class.</remarks>
public unsafe struct ChatRoomTracker
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ChatRoomTracker_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatRoomTracker*, void> ChatRoomTracker_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatRoomTracker*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatRoomTracker*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatRoomTracker*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_allegianceRoomID;
    public uint mGeneralChatRoomID;
    public uint mTradeChatRoomID;
    public uint mLFGChatRoomID;
    public uint mRoleplayChatRoomID;
    public uint mOlthoiChatRoomID;
    public uint mSocietyChatRoomID;
    public uint mSocietyCelHanChatRoomID;
    public uint mSocietyEldWebChatRoomID;
    public uint mSocietyRadBloChatRoomID;

    // Generated Constructor
    public ChatRoomTracker() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Retrieves the global trade chat room ID stored in this tracker.
    /// <code>Offset: 0x004F8DA0
    /// unsigned int __thiscall ChatRoomTracker::GetGlobalTradeRoomID(ChatRoomTracker*)</code>
    /// </summary>
    /// <returns>The unique identifier for the global trade chat room as an unsigned integer.</returns>
    public uint GetGlobalTradeRoomID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatRoomTracker, uint>)0x004F8DA0)(ref this);

    /// <summary>Retrieves the byte size of the ChatRoomTracker pack for networking or serialization purposes.
    /// <code>Offset: 0x00527AE0
    /// unsigned int __thiscall ChatRoomTracker::GetPackSize(ChatRoomTracker*)</code>
    /// </summary>
    /// <returns>The fixed size, 40 bytes, representing the packed data length.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatRoomTracker, uint>)0x00527AE0)(ref this);

    /// <summary>Initializes a new ChatRoomTracker, setting all chat room identifiers to zero and configuring the virtual function table.
    /// <code>Offset: 0x005CE520
    /// void __thiscall ChatRoomTracker::ChatRoomTracker(ChatRoomTracker*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatRoomTracker, void>)0x005CE520)(ref this);

    /// <summary>Packs chat room identifiers into the supplied buffer when sufficient space is available, writing each ID sequentially and advancing the buffer pointer one slot past the last field.
    /// <code>Offset: 0x005CE5A0
    /// unsigned int __thiscall ChatRoomTracker::Pack(ChatRoomTracker*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a memory location where packed data will be written; after execution it points four bytes beyond the final identifier (one slot past the packed data).</param>
    /// <param name="size">Number of bytes available in the target buffer. If this is less than the required pack size, no data is written.</param>
    /// <returns>Size, in bytes, needed to store all chat room identifiers for this object.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatRoomTracker, void**, uint, uint>)0x005CE5A0)(ref this, addr, size);

    /// <summary>Deserializes chat room identifiers from a packed data block into the ChatRoomTracker instance, updating the read pointer and validating the buffer size.
    /// <code>Offset: 0x005CE640
    /// int __thiscall ChatRoomTracker::UnPack(ChatRoomTracker*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of the current position within the input buffer; will be advanced past the unpacked data.</param>
    /// <param name="size">Number of bytes remaining in the input buffer to validate against the expected pack size.</param>
    /// <returns>Non‑zero if the unpack succeeded; zero if the provided size is insufficient.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatRoomTracker, void**, uint, int>)0x005CE640)(ref this, addr, size);

    /// <summary>Generates a formatted chat message for the specified channel using the sender and content strings, then stores format code, string pointer, and success flag in an integer buffer supplied by the caller.
    /// <code>Offset: 0x005CE730
    /// int* __thiscall ChatRoomTracker::GetChatFormat(_DWORD*,int*,int,int,int)</code>
    /// </summary>
    /// <param name="a2">Output array where the function writes the format identifier (index 0), a pointer to the newly created formatted text (index 1), and a status flag indicating whether formatting succeeded (index 2).</param>
    /// <param name="a3">Identifier of the chat channel whose predefined name will prefix the message.</param>
    /// <param name="a4">Pointer to the sender’s name string used in the format.</param>
    /// <param name="a5">Pointer to the actual message content that will be embedded in the formatted output.</param>
    /// <returns>Returns the same pointer as a2, now containing the populated result array.</returns>
    public int* GetChatFormat(int* a2, int a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatRoomTracker, int*, int, int, int, int*>)0x005CE730)(ref this, a2, a3, a4, a5);

    /// <summary>Retrieves the global society chat room identifier stored within the tracker.
    /// <code>Offset: 0x006BD100
    /// unsigned int __thiscall ChatRoomTracker::GetGlobalSocietyRoomID(ChatRoomTracker*)</code>
    /// </summary>
    /// <returns>The unsigned integer representing the global society chat room ID.</returns>
    public uint GetGlobalSocietyRoomID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatRoomTracker, uint>)0x006BD100)(ref this);
}

