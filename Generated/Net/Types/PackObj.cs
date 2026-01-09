namespace ACBindings;

// PackObj
public unsafe struct PackObj
{
    // Child Types
    // PackObj_vtbl
    public unsafe struct PackObj_vtbl
    {
        // Members
        public System.IntPtr PackObj_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
    // unsigned int __thiscall PackObj::GetPackSize(PackObj*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PackObj, uint>)0x00401090)(ref this);
    // int __cdecl PackObj::UNPACK_TYPE(int*,void**,unsigned int*)
    public static int UNPACK_TYPE(int* data_r, void** buffer_vpr, uint* size_r) => ((delegate* unmanaged[Cdecl]<int*, void**, uint*, int>)0x004FD180)(data_r, buffer_vpr, size_r);
    // unsigned int __cdecl PackObj::ALIGN_PTR(void**)
    public static uint ALIGN_PTR(void** ptr) => ((delegate* unmanaged[Cdecl]<void**, uint>)0x004FD1B0)(ptr);
    // int __cdecl PackObj::ALIGN_PTR(void**,unsigned int*)
    public static int ALIGN_PTR(void** ptr, uint* size) => ((delegate* unmanaged[Cdecl]<void**, uint*, int>)0x00500610)(ptr, size);
    // unsigned int __cdecl PackObj::GET_SIZE_LEFT(void*,void*,unsigned int)
    public static uint GET_SIZE_LEFT(System.IntPtr addr, System.IntPtr start, uint size) => ((delegate* unmanaged[Cdecl]<System.IntPtr, System.IntPtr, uint, uint>)0x00526D90)(addr, start, size);
    // int __cdecl PackObj::VERIFY_ADDR(void*,void*,unsigned int)
    public static int VERIFY_ADDR(System.IntPtr addr, System.IntPtr start, uint size) => ((delegate* unmanaged[Cdecl]<System.IntPtr, System.IntPtr, uint, int>)0x00526DB0)(addr, start, size);
}

