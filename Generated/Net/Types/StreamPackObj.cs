namespace ACBindings;

// StreamPackObj
public unsafe struct StreamPackObj
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // StreamPackObj_vtbl
    public unsafe struct StreamPackObj_vtbl
    {
        // Members
        public System.IntPtr StreamPackObj_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr StreamPack; // function pointer

        // Methods
    }

    // Methods
    // unsigned int __thiscall StreamPackObj::Pack(StreamPackObj*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StreamPackObj, void**, uint, uint>)0x00541340)(ref this, addr, size);
    // int __thiscall StreamPackObj::UnPack(StreamPackObj*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StreamPackObj, void**, uint, int>)0x00541380)(ref this, addr, size);
}

