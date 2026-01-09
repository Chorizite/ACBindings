namespace ACBindings;

// DataSource
public unsafe struct DataSource
{
    // Child Types
    // DataSource_vtbl
    public unsafe struct DataSource_vtbl
    {
        // Members
        public System.IntPtr DataSource_dtor_0; // function pointer
        public System.IntPtr Close; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public byte* pData;
    public byte* pStartData;
    public sbyte* pszName;
    public int dataSize;
    public byte bSrcLSBFirst;

    // Methods
    // void __thiscall DataSource::Open(DataSource*,unsigned __int8*,int)
    public void Open(byte* pData, int dataSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DataSource, byte*, int, void>)0x00670E80)(ref this, pData, dataSize);
    // void __thiscall DataSource::Close(DataSource*)
    public void Close() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DataSource, void>)0x00670EA0)(ref this);
}

