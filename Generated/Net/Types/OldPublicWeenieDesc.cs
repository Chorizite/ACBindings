namespace ACBindings.Internal;


/// <summary>Describes a legacy game entity, storing identifiers, display data, and gameplay attributes such as value, useability, and restrictions. Serves as the core data structure for loading and serializing item descriptions in the old public client.</summary>
public unsafe struct OldPublicWeenieDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.WeenieDesc BaseClass_WeenieDesc; // ACBindings.Internal.WeenieDesc

    // Child Types
    public unsafe struct OldPublicWeenieDesc_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OldPublicWeenieDesc*, void> OldPublicWeenieDesc_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OldPublicWeenieDesc*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OldPublicWeenieDesc*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OldPublicWeenieDesc*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OldPublicWeenieDesc*, uint> pack_size; // function pointer

        // Methods
    }
    // OldPublicWeenieDesc::BitfieldIndex
    public enum BitfieldIndex : uint
    {
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _plural_name;
    public ACBindings.Internal.IDClass____tagDataID _wcid;
    public ACBindings.Internal.IDClass____tagDataID _iconID;
    public ACBindings.Internal.IDClass____tagDataID _iconOverlayID;
    public uint _containerID;
    public uint _wielderID;
    public uint _priority;
    public uint _valid_locations;
    public uint _location;
    public int _itemsCapacity;
    public int _containersCapacity;
    public ACBindings.Internal.ITEM_TYPE _type;
    public uint _value;
    public ACBindings.Internal.ITEM_USEABLE _useability;
    public float _useRadius;
    public ACBindings.Internal.ITEM_TYPE _targetType;
    public uint _effects;
    public ACBindings.Internal.AMMO_TYPE _ammoType;
    public ACBindings.Internal.COMBAT_USE _combatUse;
    public uint _structure;
    public uint _maxStructure;
    public uint _stackSize;
    public uint _maxStackSize;
    public uint _bitfield;
    public int _blipColor;
    public ACBindings.Internal.RadarEnum _radar_enum;
    public float _obvious_distance;
    public ACBindings.Internal.IDClass____tagDataID _vndwcid;
    public uint _spellID;
    public uint _house_owner_iid;
    public ACBindings.Internal.RestrictionDB* _db;
    public ACBindings.Internal.PScriptType _pscript;
    public uint _hook_type;
    public ACBindings.Internal.ITEM_TYPE _hook_item_types;
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

    /// <summary>Destroys an OldPublicWeenieDesc object, releasing its name strings and any attached RestrictionDB before calling the base WeenieDesc destructor.
    /// <code>Offset: 0x006B8000
    /// void __thiscall OldPublicWeenieDesc::~OldPublicWeenieDesc(OldPublicWeenieDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OldPublicWeenieDesc, void>)0x006B8000)(ref this);

    /// <summary>Resets all fields of an OldPublicWeenieDesc to default values, clearing names and releasing allocated resources such as string buffers and the restriction database. After execution, the descriptor is in a clean state ready for reuse or destruction.
    /// <code>Offset: 0x006B8090
    /// void __thiscall OldPublicWeenieDesc::Reset(OldPublicWeenieDesc*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OldPublicWeenieDesc, void>)0x006B8090)(ref this);

    /// <summary>Initializes an OldPublicWeenieDesc object with default values, setting up its base class, virtual table, and reference‑counted string buffers for name fields, clearing the database pointer, and invoking Reset to establish other defaults.
    /// <code>Offset: 0x006B8200
    /// void __thiscall OldPublicWeenieDesc::OldPublicWeenieDesc(OldPublicWeenieDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OldPublicWeenieDesc, void>)0x006B8200)(ref this);

    /// <summary>Unpacks an OldPublicWeenieDesc object from binary data, resetting the instance first and interpreting a flag field to determine which attributes are present in the buffer.
    /// <code>Offset: 0x006B8250
    /// int __thiscall OldPublicWeenieDesc::UnPack(OldPublicWeenieDesc*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the start of the serialized data; advanced as fields are read.</param>
    /// <param name="size">Total number of bytes available at *addr for unpacking.</param>
    /// <returns>1 if unpack succeeded and all required data was consumed correctly; 0 otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OldPublicWeenieDesc, void**, uint, int>)0x006B8250)(ref this, addr, size);
}

