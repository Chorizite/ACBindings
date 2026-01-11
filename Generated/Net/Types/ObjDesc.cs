namespace ACBindings.Internal;

public unsafe struct ObjDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.VisualDesc BaseClass_VisualDesc; // ACBindings.Internal.VisualDesc

    // Child Types
    public unsafe struct ObjDesc_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ObjDesc*, void> ObjDesc_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ObjDesc*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ObjDesc*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ObjDesc*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ObjDesc*, uint> pack_size; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID paletteID;
    public ACBindings.Internal.Subpalette* firstSubpal;
    public ACBindings.Internal.Subpalette* lastSubpal;
    public int num_subpalettes;
    public ACBindings.Internal.TextureMapChange* firstTMChange;
    public ACBindings.Internal.TextureMapChange* lastTMChange;
    public int num_texture_map_changes;
    public ACBindings.Internal.AnimPartChange* firstAPChange;
    public ACBindings.Internal.AnimPartChange* lastAPChange;
    public int num_anim_part_changes;

    // Generated Constructor
    public ObjDesc() {
        _ConstructorInternal();
    }
    public ObjDesc(ACBindings.Internal.ObjDesc* od) {
        _ConstructorInternal(od);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005AC6B0
    /// TextureMapChange* __thiscall ObjDesc::GetTextureMapChange(ObjDesc*,int)</code>
    /// </summary>
    public ACBindings.Internal.TextureMapChange* GetTextureMapChange(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, int, ACBindings.Internal.TextureMapChange*>)0x005AC6B0)(ref this, num);

    /// <summary>
    /// <code>Offset: 0x005AC6D0
    /// AnimPartChange* __thiscall ObjDesc::GetAnimPartChange(ObjDesc*,int)</code>
    /// </summary>
    public ACBindings.Internal.AnimPartChange* GetAnimPartChange(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, int, ACBindings.Internal.AnimPartChange*>)0x005AC6D0)(ref this, num);

    /// <summary>
    /// <code>Offset: 0x005AC6F0
    /// void __thiscall ObjDesc::RemoveDuplicateSubpalette(ObjDesc*,Subpalette*)</code>
    /// </summary>
    public void RemoveDuplicateSubpalette(ACBindings.Internal.Subpalette* newGuy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.Subpalette*, void>)0x005AC6F0)(ref this, newGuy);

    /// <summary>
    /// <code>Offset: 0x005AC760
    /// void __thiscall ObjDesc::RemoveDuplicateTextureMapChange(ObjDesc*,TextureMapChange*)</code>
    /// </summary>
    public void RemoveDuplicateTextureMapChange(ACBindings.Internal.TextureMapChange* newGuy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.TextureMapChange*, void>)0x005AC760)(ref this, newGuy);

    /// <summary>
    /// <code>Offset: 0x005AC7D0
    /// void __thiscall ObjDesc::RemoveDuplicateAnimPartChange(ObjDesc*,AnimPartChange*)</code>
    /// </summary>
    public void RemoveDuplicateAnimPartChange(ACBindings.Internal.AnimPartChange* newGuy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.AnimPartChange*, void>)0x005AC7D0)(ref this, newGuy);

    /// <summary>
    /// <code>Offset: 0x005AC840
    /// void __thiscall ObjDesc::Clear(ObjDesc*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, void>)0x005AC840)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AC8D0
    /// void __thiscall ObjDesc::Wipe(ObjDesc*)</code>
    /// </summary>
    public void Wipe() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, void>)0x005AC8D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AC9C0
    /// void __thiscall ObjDesc::ObjDesc(ObjDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, void>)0x005AC9C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005ACA00
    /// void __thiscall ObjDesc::~ObjDesc(ObjDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, void>)0x005ACA00)(ref this);

    /// <summary>
    /// <code>Offset: 0x005ACA20
    /// int __thiscall ObjDesc::AddSubpalette(ObjDesc*,Subpalette*)</code>
    /// </summary>
    public int AddSubpalette(ACBindings.Internal.Subpalette* subpal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.Subpalette*, int>)0x005ACA20)(ref this, subpal);

    /// <summary>
    /// <code>Offset: 0x005ACAC0
    /// int __thiscall ObjDesc::AddTextureMapChange(ObjDesc*,TextureMapChange*)</code>
    /// </summary>
    public int AddTextureMapChange(ACBindings.Internal.TextureMapChange* texChange) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.TextureMapChange*, int>)0x005ACAC0)(ref this, texChange);

    /// <summary>
    /// <code>Offset: 0x005ACB30
    /// int __thiscall ObjDesc::AddAnimPartChange(ObjDesc*,AnimPartChange*)</code>
    /// </summary>
    public int AddAnimPartChange(ACBindings.Internal.AnimPartChange* partChange) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.AnimPartChange*, int>)0x005ACB30)(ref this, partChange);

    /// <summary>
    /// <code>Offset: 0x005ACBA0
    /// unsigned int __thiscall ObjDesc::pack_size(ObjDesc*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, uint>)0x005ACBA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005ACC70
    /// unsigned int __thiscall ObjDesc::Pack(ObjDesc*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, void**, uint, uint>)0x005ACC70)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005ACDA0
    /// int __thiscall ObjDesc::UnPack(ObjDesc*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, void**, uint, int>)0x005ACDA0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AD040
    /// int __thiscall ObjDesc::AddSubpalette_1(ObjDesc*,Subpalette*)</code>
    /// </summary>
    public int AddSubpalette_1(ACBindings.Internal.Subpalette* subpal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.Subpalette*, int>)0x005AD040)(ref this, subpal);

    /// <summary>
    /// <code>Offset: 0x005AD0A0
    /// int __thiscall ObjDesc::AddTextureMapChange_1(ObjDesc*,TextureMapChange*)</code>
    /// </summary>
    public int AddTextureMapChange_1(ACBindings.Internal.TextureMapChange* texChange) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.TextureMapChange*, int>)0x005AD0A0)(ref this, texChange);

    /// <summary>
    /// <code>Offset: 0x005AD100
    /// int __thiscall ObjDesc::AddAnimPartChange_1(ObjDesc*,AnimPartChange*)</code>
    /// </summary>
    public int AddAnimPartChange_1(ACBindings.Internal.AnimPartChange* partChange) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.AnimPartChange*, int>)0x005AD100)(ref this, partChange);

    /// <summary>
    /// <code>Offset: 0x005AD4C0
    /// void __thiscall ObjDesc::GetSubDataIDs(ObjDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005AD4C0)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x005AD590
    /// void __thiscall ObjDesc::ObjDesc(ObjDesc*,const ObjDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.ObjDesc* od) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.ObjDesc*, void>)0x005AD590)(ref this, od);
}

