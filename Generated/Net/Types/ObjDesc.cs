namespace ACBindings;

// ObjDesc
public unsafe struct ObjDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.VisualDesc BaseClass_VisualDesc; // ACBindings.VisualDesc

    // Child Types
    // ObjDesc_vtbl
    public unsafe struct ObjDesc_vtbl
    {
        // Members
        public System.IntPtr ObjDesc_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr pack_size; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IDClass___tagDataID paletteID;
    public ACBindings.Subpalette* firstSubpal;
    public ACBindings.Subpalette* lastSubpal;
    public int num_subpalettes;
    public ACBindings.TextureMapChange* firstTMChange;
    public ACBindings.TextureMapChange* lastTMChange;
    public int num_texture_map_changes;
    public ACBindings.AnimPartChange* firstAPChange;
    public ACBindings.AnimPartChange* lastAPChange;
    public int num_anim_part_changes;

    // Generated Constructor
    public ObjDesc() {
        _ConstructorInternal();
    }
    public ObjDesc(ACBindings.ObjDesc* od) {
        _ConstructorInternal(od);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // TextureMapChange* __thiscall ObjDesc::GetTextureMapChange(ObjDesc*,int)
    public ACBindings.TextureMapChange* GetTextureMapChange(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, int, ACBindings.TextureMapChange*>)0x005AC6B0)(ref this, num);
    // AnimPartChange* __thiscall ObjDesc::GetAnimPartChange(ObjDesc*,int)
    public ACBindings.AnimPartChange* GetAnimPartChange(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, int, ACBindings.AnimPartChange*>)0x005AC6D0)(ref this, num);
    // void __thiscall ObjDesc::RemoveDuplicateSubpalette(ObjDesc*,Subpalette*)
    public void RemoveDuplicateSubpalette(ACBindings.Subpalette* newGuy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, ACBindings.Subpalette*, void>)0x005AC6F0)(ref this, newGuy);
    // void __thiscall ObjDesc::RemoveDuplicateTextureMapChange(ObjDesc*,TextureMapChange*)
    public void RemoveDuplicateTextureMapChange(ACBindings.TextureMapChange* newGuy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, ACBindings.TextureMapChange*, void>)0x005AC760)(ref this, newGuy);
    // void __thiscall ObjDesc::RemoveDuplicateAnimPartChange(ObjDesc*,AnimPartChange*)
    public void RemoveDuplicateAnimPartChange(ACBindings.AnimPartChange* newGuy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, ACBindings.AnimPartChange*, void>)0x005AC7D0)(ref this, newGuy);
    // void __thiscall ObjDesc::Clear(ObjDesc*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, void>)0x005AC840)(ref this);
    // void __thiscall ObjDesc::Wipe(ObjDesc*)
    public void Wipe() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, void>)0x005AC8D0)(ref this);
    // void __thiscall ObjDesc::ObjDesc(ObjDesc*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, void>)0x005AC9C0)(ref this);
    // void __thiscall ObjDesc::~ObjDesc(ObjDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, void>)0x005ACA00)(ref this);
    // int __thiscall ObjDesc::AddSubpalette(ObjDesc*,Subpalette*)
    public int AddSubpalette(ACBindings.Subpalette* subpal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, ACBindings.Subpalette*, int>)0x005ACA20)(ref this, subpal);
    // int __thiscall ObjDesc::AddTextureMapChange(ObjDesc*,TextureMapChange*)
    public int AddTextureMapChange(ACBindings.TextureMapChange* texChange) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, ACBindings.TextureMapChange*, int>)0x005ACAC0)(ref this, texChange);
    // int __thiscall ObjDesc::AddAnimPartChange(ObjDesc*,AnimPartChange*)
    public int AddAnimPartChange(ACBindings.AnimPartChange* partChange) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, ACBindings.AnimPartChange*, int>)0x005ACB30)(ref this, partChange);
    // unsigned int __thiscall ObjDesc::pack_size(ObjDesc*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, uint>)0x005ACBA0)(ref this);
    // unsigned int __thiscall ObjDesc::Pack(ObjDesc*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, void**, uint, uint>)0x005ACC70)(ref this, addr, size);
    // int __thiscall ObjDesc::UnPack(ObjDesc*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, void**, uint, int>)0x005ACDA0)(ref this, addr, size);
    // void __thiscall ObjDesc::GetSubDataIDs(ObjDesc*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, ACBindings.QualifiedDataIDArray*, void>)0x005AD4C0)(ref this, id_array);
    // void __thiscall ObjDesc::ObjDesc(ObjDesc*,const ObjDesc*)
    public void _ConstructorInternal(ACBindings.ObjDesc* od) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjDesc, ACBindings.ObjDesc*, void>)0x005AD590)(ref this, od);
}

