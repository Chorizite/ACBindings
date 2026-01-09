namespace ACBindings;

// ChatRoomTracker
public unsafe struct ChatRoomTracker
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // ChatRoomTracker_vtbl
    public unsafe struct ChatRoomTracker_vtbl
    {
        // Members
        public System.IntPtr ChatRoomTracker_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

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
    // unsigned int __thiscall ChatRoomTracker::GetGlobalTradeRoomID(ChatRoomTracker*)
    public uint GetGlobalTradeRoomID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatRoomTracker, uint>)0x004F8DA0)(ref this);
    // unsigned int __thiscall ChatRoomTracker::GetPackSize(ChatRoomTracker*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatRoomTracker, uint>)0x00527AE0)(ref this);
    // void __thiscall ChatRoomTracker::ChatRoomTracker(ChatRoomTracker*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatRoomTracker, void>)0x005CE520)(ref this);
    // unsigned int __thiscall ChatRoomTracker::Pack(ChatRoomTracker*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatRoomTracker, void**, uint, uint>)0x005CE5A0)(ref this, addr, size);
    // int __thiscall ChatRoomTracker::UnPack(ChatRoomTracker*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatRoomTracker, void**, uint, int>)0x005CE640)(ref this, addr, size);
    // int* __thiscall ChatRoomTracker::GetChatFormat(_DWORD*,int*,int,int,int)
    public int* GetChatFormat(int* a2, int a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatRoomTracker, int*, int, int, int, int*>)0x005CE730)(ref this, a2, a3, a4, a5);
    // unsigned int __thiscall ChatRoomTracker::GetGlobalSocietyRoomID(ChatRoomTracker*)
    public uint GetGlobalSocietyRoomID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatRoomTracker, uint>)0x006BD100)(ref this);
}

