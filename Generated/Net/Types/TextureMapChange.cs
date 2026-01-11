namespace ACBindings.Internal;

public unsafe struct TextureMapChange
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct TextureMapChange_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureMapChange*, void> TextureMapChange_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureMapChange*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureMapChange*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureMapChange*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint part_index;
    public ACBindings.Internal.IDClass____tagDataID old_tex_id;
    public ACBindings.Internal.IDClass____tagDataID new_tex_id;
    public ACBindings.Internal.TextureMapChange* prev;
    public ACBindings.Internal.TextureMapChange* next;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005AE950
    /// unsigned int __thiscall TextureMapChange::Pack(TextureMapChange*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureMapChange, void**, uint, uint>)0x005AE950)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AE9D0
    /// int __thiscall TextureMapChange::UnPack(TextureMapChange*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureMapChange, void**, uint, int>)0x005AE9D0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AEA30
    /// int __thiscall TextureMapChange::replaces(TextureMapChange*,const TextureMapChange*)</code>
    /// </summary>
    public int replaces(ACBindings.Internal.TextureMapChange* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureMapChange, ACBindings.Internal.TextureMapChange*, int>)0x005AEA30)(ref this, change);
}

