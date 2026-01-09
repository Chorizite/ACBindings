namespace ACBindings;

// NetError
public unsafe struct NetError
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // NetError_vtbl
    public unsafe struct NetError_vtbl
    {
        // Members
        public System.IntPtr NetError_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_stringID;
    public int m_tableID;

    // Methods
    // unsigned int __thiscall NetError::Pack(NetError*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetError, void**, uint, uint>)0x004117B0)(ref this, addr, size);
    // int __thiscall NetError::UnPack(NetError*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetError, void**, uint, int>)0x00411800)(ref this, addr, size);
    // int* __thiscall NetError::GetLogString(int,int*)
    public int* GetLogString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetError, int*, int*>)0x00412AE0)(ref this, a2);
}

