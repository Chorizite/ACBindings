namespace ACBindings.Internal;


/// <summary>Encapsulates a file descriptor for low-level disk I/O, providing methods to open, close, and perform synchronous reads and writes on the device.</summary>
public unsafe struct DiskDev
{
    // Members
    public System.IntPtr _fd;

    // Methods

    /// <summary>Closes the disk device handle stored in DiskDev, marking the instance as closed.
    /// <code>Offset: 0x00677C70
    /// int __thiscall DiskDev::Close(DiskDev*)</code>
    /// </summary>
    /// <returns>Zero on success; a negative value if the handle was already invalid or closing failed.</returns>
    public int Close() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskDev, int>)0x00677C70)(ref this);

    /// <summary>Synchronously reads the requested number of bytes from a disk device at the given offset into the supplied buffer.
    /// <code>Offset: 0x00677CC0
    /// int __thiscall DiskDev::SyncRead(DiskDev*,void*,unsigned int,int)</code>
    /// </summary>
    /// <param name="buf">Pointer to the memory where read data will be stored.</param>
    /// <param name="size">Number of bytes to read.</param>
    /// <param name="off">Offset in the file from which to begin reading.</param>
    /// <returns>Zero if all requested bytes were successfully read; otherwise, a negative error code indicating failure.</returns>
    public int SyncRead(System.IntPtr buf, uint size, int off) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskDev, System.IntPtr, uint, int, int>)0x00677CC0)(ref this, buf, size, off);

    /// <summary>Synchronously writes a specified number of bytes from a buffer into the device at a given offset, returning zero when all requested bytes are successfully written.
    /// <code>Offset: 0x00677D20
    /// int __thiscall DiskDev::SyncWrite(DiskDev*,void*,unsigned int,int)</code>
    /// </summary>
    /// <param name="buf">Pointer to the data buffer to write.</param>
    /// <param name="size">Number of bytes from the buffer to write.</param>
    /// <param name="off">Zero‑based file position where writing begins.</param>
    /// <returns>0 if all requested bytes were written; -105 if setting the file pointer fails; -103 otherwise (e.g., fewer than the requested number of bytes are written).</returns>
    public int SyncWrite(System.IntPtr buf, uint size, int off) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskDev, System.IntPtr, uint, int, int>)0x00677D20)(ref this, buf, size, off);

    /// <summary>Opens a disk file by combining a base name (ref‑counted string) with an additional path component, applies access and sharing options encoded in the flag byte, stores the resulting handle in this->_fd, and optionally reads or writes a header record. 
    /// <code>Offset: 0x00677D80
    /// int __thiscall DiskDev::Open_File(DiskDev*,volatile LONG*,int*,int,char)</code>
    /// </summary>
    /// <param name="Source">Pointer to the supplementary path segment appended to the base file name.</param>
    /// <param name="a3">Pointer to a reference‑counted string holding the initial part of the file name; its count is incremented before use.</param>
    /// <param name="a4">Unused parameter reserved for future extensions.</param>
    /// <param name="a5">Bit flags controlling access and sharing: bit 2 selects read or write mode, and bit 3 sets the sharing mode. Bits are interpreted when calling CreateFileW.</param>
    /// <returns>Zero on success; a negative error code (e.g., –1 for file open failure) otherwise. The function may also return values from the optional header read/write operations. </returns>
    public int Open_File(int* Source, int* a3, int a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskDev, int*, int*, int, sbyte, int>)0x00677D80)(ref this, Source, a3, a4, a5);
}

