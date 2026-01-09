namespace ACBindings;

// DiskSpace
public unsafe struct DiskSpace
{
    // Methods
    // int __thiscall DiskSpace::GetDriveFreeBytes(DiskSpace*,char*,unsigned __int64*)
    public int GetDriveFreeBytes(sbyte* path, ulong* freeBytes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskSpace, sbyte*, ulong*, int>)0x005D69C0)(ref this, path, freeBytes);
}

