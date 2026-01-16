namespace ACBindings.Internal;


/// <summary>Represents a header used to synchronize time across components, containing a reference‑counted optional payload and a high‑resolution timestamp.</summary>
/// <remarks>Created by CTimeSyncHeader::CreateFromData or CreateFromStream; m_time is refreshed via Timer::compute_time().</remarks>
public unsafe struct CTimeSyncHeader
{
    // Base Classes
    public ACBindings.Internal.COptionalHeader BaseClass_COptionalHeader; // ACBindings.Internal.COptionalHeader

    // Child Types
    public unsafe struct CTimeSyncHeader_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CTimeSyncHeader*, void> CTimeSyncHeader_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CTimeSyncHeader*, int> UpdateTimeSensitivePayload; // function pointer

        // Methods
    }

    // Members
    public double m_time;

    // Methods

    /// <summary>Updates the header's time field with the current computed time from Timer::compute_time().
    /// <code>Offset: 0x00547E50
    /// int __thiscall CTimeSyncHeader::UpdateTimeSensitivePayload(CTimeSyncHeader*)</code>
    /// </summary>
    public int UpdateTimeSensitivePayload() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTimeSyncHeader, int>)0x00547E50)(ref this);

    /// <summary>Creates a new optional header containing the given timestamp and initializes its reference counts, mask, flags, and data pointers.
    /// <code>Offset: 0x00548190
    /// COptionalHeader* __cdecl CTimeSyncHeader::CreateFromData(long double)</code>
    /// </summary>
    /// <param name="time">Timestamp to store in the created header.</param>
    /// <returns>A pointer to the allocated COptionalHeader structure or null if allocation fails.</returns>
    public static ACBindings.Internal.COptionalHeader* CreateFromData(double time) => ((delegate* unmanaged[Cdecl]<double, ACBindings.Internal.COptionalHeader*>)0x00548190)(time);

    /// <summary>Creates a COptionalHeader object by reading an 8‑byte block from the supplied buffer iterator, initializing reference counts and vtable pointers.
    /// <code>Offset: 0x005ABAB0
    /// COptionalHeader* __cdecl CTimeSyncHeader::CreateFromStream(CBufferIterator*)</code>
    /// </summary>
    /// <param name="Buf">Iterator pointing into the data stream; its current offset is advanced by 8 bytes on success.</param>
    /// <returns>nullptr if the remaining buffer is too small or memory allocation fails; otherwise a pointer to the newly created COptionalHeader instance.</returns>
    public static ACBindings.Internal.COptionalHeader* CreateFromStream(ACBindings.Internal.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*>)0x005ABAB0)(Buf);
}

