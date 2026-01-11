namespace ACBindings.Internal;

public unsafe struct DataSource
{
    // Child Types
    public unsafe struct DataSource_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DataSource*, void> DataSource_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DataSource*, void> Close; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00670E80
    /// void __thiscall DataSource::Open(DataSource*,unsigned __int8*,int)</code>
    /// </summary>
    public void Open(byte* pData, int dataSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DataSource, byte*, int, void>)0x00670E80)(ref this, pData, dataSize);

    /// <summary>
    /// <code>Offset: 0x00670EA0
    /// void __thiscall DataSource::Close(DataSource*)</code>
    /// </summary>
    public void Close() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DataSource, void>)0x00670EA0)(ref this);
}

