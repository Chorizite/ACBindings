namespace ACBindings.Internal;

public unsafe struct Cache_Pack_t : System.IDisposable
{
    // Members
    public int m_dwOffset;
    public uint m_iVersion;
    public ACBindings.Internal.SmartBuffer m_buff;

    // Generated Constructor
    public Cache_Pack_t() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a cache pack with default values, setting offset and version to zero and constructing its buffer.
    /// <code>Offset: 0x00417600
    /// void __thiscall Cache_Pack_t::Cache_Pack_t(Cache_Pack_t*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Cache_Pack_t, void>)0x00417600)(ref this);

    /// <summary>Provides a writable pointer into the pack's internal buffer, allocating at least four bytes and skipping the first four bytes that are used as a header.
    /// <code>Offset: 0x00417620
    /// unsigned __int8* __thiscall Cache_Pack_t::GetPackBufferPtr(Cache_Pack_t*)</code>
    /// </summary>
    /// <returns>A pointer to the start of usable data within the pack’s buffer.</returns>
    public byte* GetPackBufferPtr() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Cache_Pack_t, byte*>)0x00417620)(ref this);

    /// <summary>Provides the effective data size stored in the pack's buffer, discarding a four‑byte header.
    /// <code>Offset: 0x00417640
    /// unsigned int __thiscall Cache_Pack_t::GetDataSize(Cache_Pack_t*)</code>
    /// </summary>
    /// <returns>The count of usable bytes; zero if the buffer contains only the header or less.</returns>
    public uint GetDataSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Cache_Pack_t, uint>)0x00417640)(ref this);

    /// <summary>Releases the SmartBuffer owned by the Cache_Pack_t instance and frees associated resources.
    /// <code>Offset: 0x004178A0
    /// void __thiscall Cache_Pack_t::~Cache_Pack_t(Cache_Pack_t*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Cache_Pack_t, void>)0x004178A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F88C0
    /// void __thiscall Cache_Pack_t::SerializeOrWindow(Cache_Pack_t*,Archive*)</code>
    /// </summary>
    public void SerializeOrWindow(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Cache_Pack_t, ACBindings.Internal.Archive*, void>)0x004F88C0)(ref this, io_rcArchive);

    /// <summary>
    /// <code>Offset: 0x00671440
    /// void __thiscall Cache_Pack_t::UpdatePackedSize(Cache_Pack_t*,const SmartBuffer*)</code>
    /// </summary>
    public void UpdatePackedSize(ACBindings.Internal.SmartBuffer* i_buff) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Cache_Pack_t, ACBindings.Internal.SmartBuffer*, void>)0x00671440)(ref this, i_buff);
}

