namespace ACBindings;

// ChatPoseTable
public unsafe struct ChatPoseTable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // ChatPoseTable_vtbl
    public unsafe struct ChatPoseTable_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBObj_dtor_18; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr InitLoad; // function pointer
        public System.IntPtr GetSubObjects; // function pointer
        public System.IntPtr ReleaseSubObjects; // function pointer
        public System.IntPtr NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr Destroy; // function pointer
        public System.IntPtr FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public System.IntPtr GetDBOType; // function pointer
        public System.IntPtr Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public System.IntPtr ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PackableHashTable__AC1Legacy_CaseInsensitiveStringBase__AC1Legacy_PStringBase__sbyte__AC1Legacy_PStringBase__sbyte _chatPoseHash;
    public ACBindings.PackableHashTable__AC1Legacy_PStringBase__sbyte__ChatEmoteData _chatEmoteHash;

    // Generated Constructor
    public ChatPoseTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods
    // DBObj* __cdecl ChatPoseTable::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7C20)();
    // int __thiscall ChatPoseTable::UnPack(ChatPoseTable*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatPoseTable, void**, uint, int>)0x004FD950)(ref this, addr, size);
    // int __thiscall ChatPoseTable::ChatPoseTable(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatPoseTable, void**, int>)0x004FE5A0)(ref this, a2);
    // int __thiscall ChatPoseTable::InqChatPoseCommand(_DWORD*,void (__thiscall****a2)(_DWORD, _DWORD),int*,int*,int*)
    public int InqChatPoseCommand(delegate* unmanaged[Thiscall]<int, int, void>*** a2, int* a3, int* a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatPoseTable, delegate* unmanaged[Thiscall]<int, int, void>***, int*, int*, int*, int>)0x005718A0)(ref this, a2, a3, a4, a5);
}

