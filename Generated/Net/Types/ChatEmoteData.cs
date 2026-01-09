namespace ACBindings;

// ChatEmoteData
public unsafe struct ChatEmoteData : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // ChatEmoteData_vtbl
    public unsafe struct ChatEmoteData_vtbl
    {
        // Members
        public System.IntPtr ChatEmoteData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte myEmote;
    public ACBindings.AC1Legacy.PStringBase__sbyte otherEmote;

    // Generated Constructor
    public ChatEmoteData() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ChatEmoteData::~ChatEmoteData(ChatEmoteData*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatEmoteData, void>)0x004FD9D0)(ref this);
    // unsigned int __thiscall ChatEmoteData::Pack(ChatEmoteData*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatEmoteData, void**, uint, uint>)0x004FDA20)(ref this, addr, size);
    // int __thiscall ChatEmoteData::UnPack(ChatEmoteData*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatEmoteData, void**, uint, int>)0x004FDBE0)(ref this, addr, size);
    // void __thiscall ChatEmoteData::ChatEmoteData(ChatEmoteData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatEmoteData, void>)0x004FE2A0)(ref this);
}

