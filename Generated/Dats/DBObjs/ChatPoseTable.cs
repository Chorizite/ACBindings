namespace ACBindings.Internal;


/// <summary>Maintains mappings between chat pose commands and their corresponding pose strings and emote data for the game’s chat system, providing efficient lookup and serialization support via PackableHashTable and SerializeUsingPackDBObj.</summary>
public unsafe struct ChatPoseTable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct ChatPoseTable_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable___AC1Legacy_CaseInsensitiveStringBase___AC1Legacy_PStringBase__sbyte___AC1Legacy_PStringBase__sbyte _chatPoseHash;
    public ACBindings.Internal.PackableHashTable___AC1Legacy_PStringBase__sbyte___ChatEmoteData _chatEmoteHash;

    // Generated Constructor
    public ChatPoseTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>
    /// Allocates memory for a new ChatPoseTable object, constructs it, and returns a pointer to its DBObj base.
    /// If allocation fails, returns null.
    /// 
    /// <code>Offset: 0x004F7C20
    /// DBObj* __cdecl ChatPoseTable::Allocator()</code>
    /// </summary>
    /// <returns>Pointer to the newly allocated ChatPoseTable as a DBObj; nullptr if memory allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7C20)();

    /// <summary>Unpacks serialized data for a ChatPoseTable instance from the supplied buffer, advancing the buffer pointer past the consumed bytes.
    /// <code>Offset: 0x004FD950
    /// int __thiscall ChatPoseTable::UnPack(ChatPoseTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the binary buffer; updated to point after the unpacked data.</param>
    /// <param name="size">Number of bytes available in the buffer that may be read during unpacking.</param>
    /// <returns>Returns 1 when all required data is successfully extracted, otherwise returns 0 (e.g., insufficient size or unpacking failure).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatPoseTable, void**, uint, int>)0x004FD950)(ref this, addr, size);

    /// <summary>Initializes a ChatPoseTable by constructing its base database object and setting up hash tables for chat poses and emotes.
    /// <code>Offset: 0x004FE5A0
    /// int __thiscall ChatPoseTable::ChatPoseTable(int,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer to initialization data passed to the base DBObj constructor.</param>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatPoseTable, void**, int>)0x004FE5A0)(ref this, a2);

    /// <summary>Retrieves emote data for the specified chat pose key and updates output parameters. Returns 1 on success, 0 if not found.
    /// <code>Offset: 0x005718A0
    /// int __thiscall ChatPoseTable::InqChatPoseCommand(_DWORD*,void (__thiscall****a2)(_DWORD, _DWORD),int*,int*,int*)</code>
    /// </summary>
    /// <param name="a2">Reference to a case‑insensitive string that identifies the desired chat pose command.</param>
    /// <param name="a3">Pointer to the current pose string; will be updated with the new value when a different command is located.</param>
    /// <param name="a4">Output pointer where the retrieved pose command string will be stored.</param>
    /// <param name="a5">Output pointer where supplementary emote data (e.g., animation or sound) will be stored.</param>
    /// <returns>1 if the key exists in the table; 0 otherwise.</returns>
    public int InqChatPoseCommand(delegate* unmanaged[Thiscall]<int, int, void>*** a2, int* a3, int* a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatPoseTable, delegate* unmanaged[Thiscall]<int, int, void>***, int*, int*, int*, int>)0x005718A0)(ref this, a2, a3, a4, a5);
}

