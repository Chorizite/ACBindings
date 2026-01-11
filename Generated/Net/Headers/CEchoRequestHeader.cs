namespace ACBindings.Internal;

public unsafe struct CEchoRequestHeader
{
    // Base Classes
    public ACBindings.Internal.COptionalHeader BaseClass_COptionalHeader; // ACBindings.Internal.COptionalHeader

    // Child Types
    public unsafe struct CEchoRequestHeader_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CEchoRequestHeader*, void> CEchoRequestHeader_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CEchoRequestHeader*, int> UpdateTimeSensitivePayload; // function pointer

        // Methods
    }

    // Members
    public float m_LocalTime;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00547E60
    /// int __thiscall CEchoRequestHeader::UpdateTimeSensitivePayload(CEchoRequestHeader*)</code>
    /// </summary>
    public int UpdateTimeSensitivePayload() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEchoRequestHeader, int>)0x00547E60)(ref this);

    /// <summary>
    /// <code>Offset: 0x005481E0
    /// COptionalHeader* __cdecl CEchoRequestHeader::CreateFromData()</code>
    /// </summary>
    public static ACBindings.Internal.COptionalHeader* CreateFromData() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.COptionalHeader*>)0x005481E0)();

    /// <summary>
    /// <code>Offset: 0x005ABB50
    /// COptionalHeader* __cdecl CEchoRequestHeader::CreateFromStream(CBufferIterator*)</code>
    /// </summary>
    public static ACBindings.Internal.COptionalHeader* CreateFromStream(ACBindings.Internal.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*>)0x005ABB50)(Buf);
}

