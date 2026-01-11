namespace ACBindings.Internal;

public unsafe struct ChatRoomTracker
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ChatRoomTracker_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatRoomTracker*, void> ChatRoomTracker_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatRoomTracker*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatRoomTracker*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatRoomTracker*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004F8DA0
    /// unsigned int __thiscall ChatRoomTracker::GetGlobalTradeRoomID(ChatRoomTracker*)</code>
    /// </summary>
    public uint GetGlobalTradeRoomID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatRoomTracker, uint>)0x004F8DA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527AE0
    /// unsigned int __thiscall ChatRoomTracker::GetPackSize(ChatRoomTracker*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatRoomTracker, uint>)0x00527AE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CE520
    /// void __thiscall ChatRoomTracker::ChatRoomTracker(ChatRoomTracker*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatRoomTracker, void>)0x005CE520)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CE5A0
    /// unsigned int __thiscall ChatRoomTracker::Pack(ChatRoomTracker*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatRoomTracker, void**, uint, uint>)0x005CE5A0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CE640
    /// int __thiscall ChatRoomTracker::UnPack(ChatRoomTracker*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatRoomTracker, void**, uint, int>)0x005CE640)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CE730
    /// int* __thiscall ChatRoomTracker::GetChatFormat(_DWORD*,int*,int,int,int)</code>
    /// </summary>
    public int* GetChatFormat(int* a2, int a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatRoomTracker, int*, int, int, int, int*>)0x005CE730)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x006BD100
    /// unsigned int __thiscall ChatRoomTracker::GetGlobalSocietyRoomID(ChatRoomTracker*)</code>
    /// </summary>
    public uint GetGlobalSocietyRoomID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatRoomTracker, uint>)0x006BD100)(ref this);
}

