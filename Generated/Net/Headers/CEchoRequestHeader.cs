namespace ACBindings;

// CEchoRequestHeader
public unsafe struct CEchoRequestHeader
{
    // Base Classes
    public ACBindings.COptionalHeader BaseClass_COptionalHeader; // ACBindings.COptionalHeader

    // Child Types
    // CEchoRequestHeader_vtbl
    public unsafe struct CEchoRequestHeader_vtbl
    {
        // Members
        public System.IntPtr CEchoRequestHeader_dtor_0; // function pointer
        public System.IntPtr UpdateTimeSensitivePayload; // function pointer

        // Methods
    }

    // Members
    public float m_LocalTime;

    // Methods
    // int __thiscall CEchoRequestHeader::UpdateTimeSensitivePayload(CEchoRequestHeader*)
    public int UpdateTimeSensitivePayload() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEchoRequestHeader, int>)0x00547E60)(ref this);
    // COptionalHeader* __cdecl CEchoRequestHeader::CreateFromData()
    public static ACBindings.COptionalHeader* CreateFromData() => ((delegate* unmanaged[Cdecl]<ACBindings.COptionalHeader*>)0x005481E0)();
    // COptionalHeader* __cdecl CEchoRequestHeader::CreateFromStream(CBufferIterator*)
    public static ACBindings.COptionalHeader* CreateFromStream(ACBindings.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.CBufferIterator*, ACBindings.COptionalHeader*>)0x005ABB50)(Buf);
}

