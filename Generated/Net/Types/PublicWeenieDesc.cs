namespace ACBindings;

// PublicWeenieDesc
public unsafe struct PublicWeenieDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.WeenieDesc BaseClass_WeenieDesc; // ACBindings.WeenieDesc

    // Child Types
    // PublicWeenieDesc_vtbl
    public unsafe struct PublicWeenieDesc_vtbl
    {
        // Members
        public System.IntPtr PublicWeenieDesc_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr pack_size; // function pointer

        // Methods
    }
    // PublicWeenieDesc::BitfieldIndex
    public enum BitfieldIndex : uint
    {
        BF_OPENABLE = 0x1,
        BF_INSCRIBABLE = 0x2,
        BF_STUCK = 0x4,
        BF_PLAYER = 0x8,
        BF_ATTACKABLE = 0x10,
        BF_PLAYER_KILLER = 0x20,
        BF_HIDDEN_ADMIN = 0x40,
        BF_UI_HIDDEN = 0x80,
        BF_BOOK = 0x100,
        BF_VENDOR = 0x200,
        BF_PKSWITCH = 0x400,
        BF_NPKSWITCH = 0x800,
        BF_DOOR = 0x1000,
        BF_CORPSE = 0x2000,
        BF_LIFESTONE = 0x4000,
        BF_FOOD = 0x8000,
        BF_HEALER = 0x10000,
        BF_LOCKPICK = 0x20000,
        BF_PORTAL = 0x40000,
        BF_ADMIN = 0x100000,
        BF_FREE_PKSTATUS = 0x200000,
        BF_IMMUNE_CELL_RESTRICTIONS = 0x400000,
        BF_REQUIRES_PACKSLOT = 0x800000,
        BF_RETAINED = 0x1000000,
        BF_PKLITE_PKSTATUS = 0x2000000,
        BF_INCLUDES_SECOND_HEADER = 0x4000000,
        BF_BINDSTONE = 0x8000000,
        BF_VOLATILE_RARE = 0x10000000,
        BF_WIELD_ON_USE = 0x20000000,
        BF_WIELD_LEFT = 0x40000000,
        FORCE_BitfieldIndex_32_BIT = 0x7FFFFFFF
    }

    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte _name;
    public ACBindings.AC1Legacy.PStringBase__sbyte _plural_name;
    public ACBindings.IDClass___tagDataID _wcid;
    public ACBindings.IDClass___tagDataID _iconID;
    public ACBindings.IDClass___tagDataID _iconOverlayID;
    public ACBindings.IDClass___tagDataID _iconUnderlayID;
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
    public int _burden;
    public uint _spellID;
    public uint _house_owner_iid;
    public ACBindings.RestrictionDB* _db;
    public ACBindings.PScriptType _pscript;
    public uint _hook_type;
    public ACBindings.ITEM_TYPE _hook_item_types;
    public uint _monarch;
    public int _material_type;
    public float _workmanship;
    public int _cooldown_id;
    public double _cooldown_duration;
    public uint _pet_owner;

    // Generated Constructor
    public PublicWeenieDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // int __cdecl PublicWeenieDesc::IsTalkable(const ITEM_TYPE)
    public static int IsTalkable(ACBindings.ITEM_TYPE itemType) => ((delegate* unmanaged[Cdecl]<ACBindings.ITEM_TYPE, int>)0x005AD860)(itemType);
    // void __thiscall PublicWeenieDesc::SetPlayerKillerStatus(PublicWeenieDesc*,unsigned int)
    public void SetPlayerKillerStatus(uint pk) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PublicWeenieDesc, uint, void>)0x005AD870)(ref this, pk);
    // void __thiscall PublicWeenieDesc::set_pack_header(PublicWeenieDesc*,unsigned int*)
    public void set_pack_header(uint* header) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PublicWeenieDesc, uint*, void>)0x005AD8D0)(ref this, header);
    // void __thiscall PublicWeenieDesc::~PublicWeenieDesc(PublicWeenieDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PublicWeenieDesc, void>)0x005ADA90)(ref this);
    // void __thiscall PublicWeenieDesc::Reset(PublicWeenieDesc*)
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PublicWeenieDesc, void>)0x005ADD20)(ref this);
    // unsigned int __thiscall PublicWeenieDesc::pack_size(PublicWeenieDesc*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PublicWeenieDesc, uint>)0x005ADEB0)(ref this);
    // unsigned int __thiscall PublicWeenieDesc::Pack(PublicWeenieDesc*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PublicWeenieDesc, void**, uint, uint>)0x005AE120)(ref this, addr, size);
    // void __thiscall PublicWeenieDesc::PublicWeenieDesc(PublicWeenieDesc*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PublicWeenieDesc, void>)0x005AE4D0)(ref this);
    // int __thiscall PublicWeenieDesc::UnPack(PublicWeenieDesc*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PublicWeenieDesc, void**, uint, int>)0x005AE520)(ref this, addr, size);
}

