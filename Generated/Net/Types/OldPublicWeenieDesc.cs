namespace ACBindings;

// OldPublicWeenieDesc
public unsafe struct OldPublicWeenieDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.WeenieDesc BaseClass_WeenieDesc; // ACBindings.WeenieDesc

    // Child Types
    // OldPublicWeenieDesc_vtbl
    public unsafe struct OldPublicWeenieDesc_vtbl
    {
        // Members
        public System.IntPtr OldPublicWeenieDesc_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr pack_size; // function pointer

        // Methods
    }
    // OldPublicWeenieDesc::BitfieldIndex
    public enum BitfieldIndex : uint
    {
    }

    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte _name;
    public ACBindings.AC1Legacy.PStringBase__sbyte _plural_name;
    public ACBindings.IDClass___tagDataID _wcid;
    public ACBindings.IDClass___tagDataID _iconID;
    public ACBindings.IDClass___tagDataID _iconOverlayID;
    public uint _containerID;
    public uint _wielderID;
    public uint _priority;
    public uint _valid_locations;
    public uint _location;
    public int _itemsCapacity;
    public int _containersCapacity;
    public ACBindings.ITEM_TYPE _type;
    public uint _value;
    public ACBindings.ITEM_USEABLE _useability;
    public float _useRadius;
    public ACBindings.ITEM_TYPE _targetType;
    public uint _effects;
    public ACBindings.AMMO_TYPE _ammoType;
    public ACBindings.COMBAT_USE _combatUse;
    public uint _structure;
    public uint _maxStructure;
    public uint _stackSize;
    public uint _maxStackSize;
    public uint _bitfield;
    public int _blipColor;
    public ACBindings.RadarEnum _radar_enum;
    public float _obvious_distance;
    public ACBindings.IDClass___tagDataID _vndwcid;
    public uint _spellID;
    public uint _house_owner_iid;
    public ACBindings.RestrictionDB* _db;
    public ACBindings.PScriptType _pscript;
    public uint _hook_type;
    public ACBindings.ITEM_TYPE _hook_item_types;
    public uint _monarch;
    public int _material_type;

    // Generated Constructor
    public OldPublicWeenieDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall OldPublicWeenieDesc::~OldPublicWeenieDesc(OldPublicWeenieDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.OldPublicWeenieDesc, void>)0x006B8000)(ref this);
    // void __thiscall OldPublicWeenieDesc::Reset(OldPublicWeenieDesc*)
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.OldPublicWeenieDesc, void>)0x006B8090)(ref this);
    // void __thiscall OldPublicWeenieDesc::OldPublicWeenieDesc(OldPublicWeenieDesc*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.OldPublicWeenieDesc, void>)0x006B8200)(ref this);
    // int __thiscall OldPublicWeenieDesc::UnPack(OldPublicWeenieDesc*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.OldPublicWeenieDesc, void**, uint, int>)0x006B8250)(ref this, addr, size);
}

