namespace ACBindings.Internal;

public unsafe struct CTimeSyncHeader
{
    // Base Classes
    public ACBindings.Internal.COptionalHeader BaseClass_COptionalHeader; // ACBindings.Internal.COptionalHeader

    // Child Types
    public unsafe struct CTimeSyncHeader_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CTimeSyncHeader*, void> CTimeSyncHeader_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CTimeSyncHeader*, int> UpdateTimeSensitivePayload; // function pointer

        // Methods
    }

    // Members
    public double m_time;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00547E50
    /// int __thiscall CTimeSyncHeader::UpdateTimeSensitivePayload(CTimeSyncHeader*)</code>
    /// </summary>
    public int UpdateTimeSensitivePayload() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTimeSyncHeader, int>)0x00547E50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00548190
    /// COptionalHeader* __cdecl CTimeSyncHeader::CreateFromData(long double)</code>
    /// </summary>
    public static ACBindings.Internal.COptionalHeader* CreateFromData(double time) => ((delegate* unmanaged[Cdecl]<double, ACBindings.Internal.COptionalHeader*>)0x00548190)(time);

    /// <summary>
    /// <code>Offset: 0x005ABAB0
    /// COptionalHeader* __cdecl CTimeSyncHeader::CreateFromStream(CBufferIterator*)</code>
    /// </summary>
    public static ACBindings.Internal.COptionalHeader* CreateFromStream(ACBindings.Internal.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*>)0x005ABAB0)(Buf);
}

