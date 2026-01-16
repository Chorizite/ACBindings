namespace ACBindings.Internal;


/// <summary>Encapsulates the logic required to determine available storage on a given drive or directory by invoking Windows API calls such as GetDiskFreeSpaceEx and GetDiskFreeSpace.</summary>
public unsafe struct DiskSpace
{
    // Methods

    /// <summary>Retrieves the number of free bytes on the drive specified by path.
    /// <code>Offset: 0x005D69C0
    /// int __thiscall DiskSpace::GetDriveFreeBytes(DiskSpace*,char*,unsigned __int64*)</code>
    /// </summary>
    /// <param name="path">The drive or directory path to query for free space.</param>
    /// <param name="freeBytes">Pointer to an unsigned 64‑bit integer that receives the count of available bytes.</param>
    /// <returns>The error code from the underlying API call; zero indicates success, otherwise a Win32 error code.</returns>
    public int GetDriveFreeBytes(sbyte* path, ulong* freeBytes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskSpace, sbyte*, ulong*, int>)0x005D69C0)(ref this, path, freeBytes);
}

