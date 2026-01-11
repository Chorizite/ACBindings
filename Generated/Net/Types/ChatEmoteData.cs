namespace ACBindings.Internal;

public unsafe struct ChatEmoteData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ChatEmoteData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatEmoteData*, void> ChatEmoteData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatEmoteData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatEmoteData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatEmoteData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte myEmote;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte otherEmote;

    // Generated Constructor
    public ChatEmoteData() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004FD9D0
    /// void __thiscall ChatEmoteData::~ChatEmoteData(ChatEmoteData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatEmoteData, void>)0x004FD9D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FDA20
    /// unsigned int __thiscall ChatEmoteData::Pack(ChatEmoteData*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatEmoteData, void**, uint, uint>)0x004FDA20)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x004FDBE0
    /// int __thiscall ChatEmoteData::UnPack(ChatEmoteData*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatEmoteData, void**, uint, int>)0x004FDBE0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x004FE2A0
    /// void __thiscall ChatEmoteData::ChatEmoteData(ChatEmoteData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatEmoteData, void>)0x004FE2A0)(ref this);
}

