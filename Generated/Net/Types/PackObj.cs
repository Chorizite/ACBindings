namespace ACBindings.Internal;

public unsafe struct PackObj
{
    // Child Types
    public unsafe struct PackObj_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObj*, void> PackObj_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObj*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObj*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObj*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods

    /// <summary>Retrieves the total size in bytes of the pack represented by this object.
    /// <code>Offset: 0x00401090
    /// unsigned int __thiscall PackObj::GetPackSize(PackObj*)</code>
    /// </summary>
    /// <returns>The size of the pack in bytes as an unsigned integer.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PackObj, uint>)0x00401090)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FD180
    /// int __cdecl PackObj::UNPACK_TYPE(int*,void**,unsigned int*)</code>
    /// </summary>
    public static int UNPACK_TYPE(int* data_r, void** buffer_vpr, uint* size_r) => ((delegate* unmanaged[Cdecl]<int*, void**, uint*, int>)0x004FD180)(data_r, buffer_vpr, size_r);

    /// <summary>
    /// <code>Offset: 0x004FD1B0
    /// unsigned int __cdecl PackObj::ALIGN_PTR(void**)</code>
    /// </summary>
    public static uint ALIGN_PTR(void** ptr) => ((delegate* unmanaged[Cdecl]<void**, uint>)0x004FD1B0)(ptr);

    /// <summary>
    /// <code>Offset: 0x00500610
    /// int __cdecl PackObj::ALIGN_PTR(void**,unsigned int*)</code>
    /// </summary>
    public static int ALIGN_PTR(void** ptr, uint* size) => ((delegate* unmanaged[Cdecl]<void**, uint*, int>)0x00500610)(ptr, size);

    /// <summary>
    /// <code>Offset: 0x00526D90
    /// unsigned int __cdecl PackObj::GET_SIZE_LEFT(void*,void*,unsigned int)</code>
    /// </summary>
    public static uint GET_SIZE_LEFT(System.IntPtr addr, System.IntPtr start, uint size) => ((delegate* unmanaged[Cdecl]<System.IntPtr, System.IntPtr, uint, uint>)0x00526D90)(addr, start, size);

    /// <summary>
    /// <code>Offset: 0x00526DB0
    /// int __cdecl PackObj::VERIFY_ADDR(void*,void*,unsigned int)</code>
    /// </summary>
    public static int VERIFY_ADDR(System.IntPtr addr, System.IntPtr start, uint size) => ((delegate* unmanaged[Cdecl]<System.IntPtr, System.IntPtr, uint, int>)0x00526DB0)(addr, start, size);
}

