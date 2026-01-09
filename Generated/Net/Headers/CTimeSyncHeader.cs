namespace ACBindings;

// CTimeSyncHeader
public unsafe struct CTimeSyncHeader
{
    // Base Classes
    public ACBindings.COptionalHeader BaseClass_COptionalHeader; // ACBindings.COptionalHeader

    // Child Types
    // CTimeSyncHeader_vtbl
    public unsafe struct CTimeSyncHeader_vtbl
    {
        // Members
        public System.IntPtr CTimeSyncHeader_dtor_0; // function pointer
        public System.IntPtr UpdateTimeSensitivePayload; // function pointer

        // Methods
    }

    // Members
    public double m_time;

    // Methods
    // int __thiscall CTimeSyncHeader::UpdateTimeSensitivePayload(CTimeSyncHeader*)
    public int UpdateTimeSensitivePayload() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTimeSyncHeader, int>)0x00547E50)(ref this);
    // COptionalHeader* __cdecl CTimeSyncHeader::CreateFromData(long double)
    public static ACBindings.COptionalHeader* CreateFromData(double time) => ((delegate* unmanaged[Cdecl]<double, ACBindings.COptionalHeader*>)0x00548190)(time);
    // COptionalHeader* __cdecl CTimeSyncHeader::CreateFromStream(CBufferIterator*)
    public static ACBindings.COptionalHeader* CreateFromStream(ACBindings.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.CBufferIterator*, ACBindings.COptionalHeader*>)0x005ABAB0)(Buf);
}

