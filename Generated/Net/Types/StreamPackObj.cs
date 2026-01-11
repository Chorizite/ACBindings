namespace ACBindings.Internal;

public unsafe struct StreamPackObj
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct StreamPackObj_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StreamPackObj*, void> StreamPackObj_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StreamPackObj*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StreamPackObj*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StreamPackObj*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StreamPackObj*, ACBindings.Internal.STREAMTYPE, void**, uint*, int> StreamPack; // function pointer

        // Methods
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00541340
    /// unsigned int __thiscall StreamPackObj::Pack(StreamPackObj*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StreamPackObj, void**, uint, uint>)0x00541340)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00541380
    /// int __thiscall StreamPackObj::UnPack(StreamPackObj*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StreamPackObj, void**, uint, int>)0x00541380)(ref this, addr, size);
}

