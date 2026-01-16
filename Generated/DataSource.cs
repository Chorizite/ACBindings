namespace ACBindings.Internal;


/// <summary>Provides a handle to raw data buffers along with metadata such as size, name, and byte order for consumption by processing modules.</summary>
public unsafe struct DataSource
{
    // Child Types

    /// <summary>Defines the virtual function table for a data source, providing destructor and close operations.</summary>
    public unsafe struct DataSource_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DataSource*, void> DataSource_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DataSource*, void> Close; // function pointer

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

    /// <summary>Initializes the data source with a memory buffer, setting both the start and current pointers and recording its size for future processing.
    /// <code>Offset: 0x00670E80
    /// void __thiscall DataSource::Open(DataSource*,unsigned __int8*,int)</code>
    /// </summary>
    /// <param name="pData">Pointer to the beginning of the data buffer to be used by this source.</param>
    /// <param name="dataSize">Number of bytes in the supplied data buffer.</param>
    public void Open(byte* pData, int dataSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DataSource, byte*, int, void>)0x00670E80)(ref this, pData, dataSize);

    /// <summary>Resets internal data pointers to null, effectively closing the data source.
    /// <code>Offset: 0x00670EA0
    /// void __thiscall DataSource::Close(DataSource*)</code>
    /// </summary>
    public void Close() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DataSource, void>)0x00670EA0)(ref this);
}

