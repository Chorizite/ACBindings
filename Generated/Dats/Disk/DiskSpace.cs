namespace ACBindings.Internal;

public unsafe struct DiskSpace
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x005D69C0
    /// int __thiscall DiskSpace::GetDriveFreeBytes(DiskSpace*,char*,unsigned __int64*)</code>
    /// </summary>
    public int GetDriveFreeBytes(sbyte* path, ulong* freeBytes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskSpace, sbyte*, ulong*, int>)0x005D69C0)(ref this, path, freeBytes);
}

