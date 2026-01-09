namespace ACBindings;

// Cache_Pack_t
public unsafe struct Cache_Pack_t : System.IDisposable
{
    // Members
    public int m_dwOffset;
    public uint m_iVersion;
    public ACBindings.SmartBuffer m_buff;

    // Generated Constructor
    public Cache_Pack_t() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall Cache_Pack_t::Cache_Pack_t(Cache_Pack_t*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Cache_Pack_t, void>)0x00417600)(ref this);
    // unsigned __int8* __thiscall Cache_Pack_t::GetPackBufferPtr(Cache_Pack_t*)
    public byte* GetPackBufferPtr() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Cache_Pack_t, byte*>)0x00417620)(ref this);
    // unsigned int __thiscall Cache_Pack_t::GetDataSize(Cache_Pack_t*)
    public uint GetDataSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Cache_Pack_t, uint>)0x00417640)(ref this);
    // void __thiscall Cache_Pack_t::~Cache_Pack_t(Cache_Pack_t*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Cache_Pack_t, void>)0x004178A0)(ref this);
    // void __thiscall Cache_Pack_t::SerializeOrWindow(Cache_Pack_t*,Archive*)
    public void SerializeOrWindow(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Cache_Pack_t, ACBindings.Archive*, void>)0x004F88C0)(ref this, io_rcArchive);
    // void __thiscall Cache_Pack_t::UpdatePackedSize(Cache_Pack_t*,const SmartBuffer*)
    public void UpdatePackedSize(ACBindings.SmartBuffer* i_buff) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Cache_Pack_t, ACBindings.SmartBuffer*, void>)0x00671440)(ref this, i_buff);
}

