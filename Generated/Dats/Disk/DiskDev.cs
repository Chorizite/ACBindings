namespace ACBindings;

// DiskDev
public unsafe struct DiskDev
{
    // Members
    public System.IntPtr _fd;

    // Methods
    // int __thiscall DiskDev::Close(DiskDev*)
    public int Close() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskDev, int>)0x00677C70)(ref this);
    // int __thiscall DiskDev::SyncRead(DiskDev*,void*,unsigned int,int)
    public int SyncRead(System.IntPtr buf, uint size, int off) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskDev, System.IntPtr, uint, int, int>)0x00677CC0)(ref this, buf, size, off);
    // int __thiscall DiskDev::SyncWrite(DiskDev*,void*,unsigned int,int)
    public int SyncWrite(System.IntPtr buf, uint size, int off) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskDev, System.IntPtr, uint, int, int>)0x00677D20)(ref this, buf, size, off);
    // int __thiscall DiskDev::Open_File(DiskDev*,volatile LONG*,int*,int,char)
    public int Open_File(int* Source, int* a3, int a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskDev, int*, int*, int, sbyte, int>)0x00677D80)(ref this, Source, a3, a4, a5);
}

