namespace ACBindings;

// TextureMapChange
public unsafe struct TextureMapChange
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // TextureMapChange_vtbl
    public unsafe struct TextureMapChange_vtbl
    {
        // Members
        public System.IntPtr TextureMapChange_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint part_index;
    public ACBindings.IDClass___tagDataID old_tex_id;
    public ACBindings.IDClass___tagDataID new_tex_id;
    public ACBindings.TextureMapChange* prev;
    public ACBindings.TextureMapChange* next;

    // Methods
    // unsigned int __thiscall TextureMapChange::Pack(TextureMapChange*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextureMapChange, void**, uint, uint>)0x005AE950)(ref this, addr, size);
    // int __thiscall TextureMapChange::UnPack(TextureMapChange*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextureMapChange, void**, uint, int>)0x005AE9D0)(ref this, addr, size);
    // int __thiscall TextureMapChange::replaces(TextureMapChange*,const TextureMapChange*)
    public int replaces(ACBindings.TextureMapChange* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextureMapChange, ACBindings.TextureMapChange*, int>)0x005AEA30)(ref this, change);
}

