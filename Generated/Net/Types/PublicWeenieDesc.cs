namespace ACBindings.Internal;


/// <summary>Describes the public attributes of a game object, including identifiers, visual properties, behavior flags, capacity limits, and restriction rules, enabling packing/unpacking and runtime manipulation.</summary>
public unsafe struct PublicWeenieDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.WeenieDesc BaseClass_WeenieDesc; // ACBindings.Internal.WeenieDesc

    // Child Types
    public unsafe struct PublicWeenieDesc_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PublicWeenieDesc*, void> PublicWeenieDesc_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PublicWeenieDesc*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PublicWeenieDesc*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PublicWeenieDesc*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PublicWeenieDesc*, uint> pack_size; // function pointer

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
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _plural_name;
    public ACBindings.Internal.IDClass____tagDataID _wcid;
    public ACBindings.Internal.IDClass____tagDataID _iconID;
    public ACBindings.Internal.IDClass____tagDataID _iconOverlayID;
    public ACBindings.Internal.IDClass____tagDataID _iconUnderlayID;
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
    public int _burden;
    public uint _spellID;
    public uint _house_owner_iid;
    public ACBindings.Internal.RestrictionDB* _db;
    public ACBindings.Internal.PScriptType _pscript;
    public uint _hook_type;
    public ACBindings.Internal.ITEM_TYPE _hook_item_types;
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

    /// <summary>Determines if a given item type represents a creature that can be interacted with through conversation.
    /// <code>Offset: 0x005AD860
    /// int __cdecl PublicWeenieDesc::IsTalkable(const ITEM_TYPE)</code>
    /// </summary>
    /// <param name="itemType">The type of the item to evaluate.</param>
    /// <returns>Non‑zero if the item type is talkable (i.e., a creature); otherwise zero.</returns>
    public static int IsTalkable(ACBindings.Internal.ITEM_TYPE itemType) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ITEM_TYPE, int>)0x005AD860)(itemType);

    /// <summary>Updates the object's internal bitfield to reflect the specified player killer status flag, setting or clearing specific bits based on the supplied value.
    /// <code>Offset: 0x005AD870
    /// void __thiscall PublicWeenieDesc::SetPlayerKillerStatus(PublicWeenieDesc*,unsigned int)</code>
    /// </summary>
    /// <param name="pk">Bitmask indicating which killer status flag should be set or cleared; values 4, 0x20, and 0x40 correspond to different status bits, while any other value clears all related flags.</param>
    public void SetPlayerKillerStatus(uint pk) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PublicWeenieDesc, uint, void>)0x005AD870)(ref this, pk);

    /// <summary>Sets flag bits in the supplied header according to which properties of the weenie are defined or non‑zero.
    /// <code>Offset: 0x005AD8D0
    /// void __thiscall PublicWeenieDesc::set_pack_header(PublicWeenieDesc*,unsigned int*)</code>
    /// </summary>
    /// <param name="header">A pointer to an unsigned integer that receives ORed flag values indicating present attributes.</param>
    public void set_pack_header(uint* header) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PublicWeenieDesc, uint*, void>)0x005AD8D0)(ref this, header);

    /// <summary>Destroys a PublicWeenieDesc instance, releasing owned resources such as the associated RestrictionDB and string buffers, then invokes its base WeenieDesc destructor.
    /// <code>Offset: 0x005ADA90
    /// void __thiscall PublicWeenieDesc::~PublicWeenieDesc(PublicWeenieDesc*)</code>
    /// </summary>
    /// <param name="this">Pointer to the object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PublicWeenieDesc, void>)0x005ADA90)(ref this);

    /// <summary>Reinitializes a PublicWeenieDesc instance, resetting all member fields—including names, IDs, capacities, flags, and any allocated resources—to their default states.
    /// <code>Offset: 0x005ADD20
    /// void __thiscall PublicWeenieDesc::Reset(PublicWeenieDesc*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PublicWeenieDesc, void>)0x005ADD20)(ref this);

    /// <summary>Computes the size in bytes required to pack a PublicWeenieDesc object for serialization.
    /// <code>Offset: 0x005ADEB0
    /// unsigned int __thiscall PublicWeenieDesc::pack_size(PublicWeenieDesc*)</code>
    /// </summary>
    /// <returns>The number of bytes necessary to represent the object when packed.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PublicWeenieDesc, uint>)0x005ADEB0)(ref this);

    /// <summary>Packs the PublicWeenieDesc into a binary buffer, writing fields according to internal flags and updating bitfields as required.
    /// <code>Offset: 0x005AE120
    /// unsigned int __thiscall PublicWeenieDesc::Pack(PublicWeenieDesc*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a buffer pointer that receives the packed data; after packing it points past the last byte written.</param>
    /// <param name="size">Maximum number of bytes available for packing.</param>
    /// <returns>The size in bytes needed to serialize the object, which is also the number of bytes written when the supplied buffer has sufficient space. If the requested buffer is too small, no data is written but the returned value indicates the required size.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PublicWeenieDesc, void**, uint, uint>)0x005AE120)(ref this, addr, size);

    /// <summary>Initializes a new PublicWeenieDesc instance, establishing the base class, allocating empty name strings, nullifying the restriction database pointer, and resetting all fields to their default values.
    /// <code>Offset: 0x005AE4D0
    /// void __thiscall PublicWeenieDesc::PublicWeenieDesc(PublicWeenieDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PublicWeenieDesc, void>)0x005AE4D0)(ref this);

    /// <summary>Resets this PublicWeenieDesc and reads a serialized representation from the supplied buffer, populating all fields according to embedded flags and bitfields; returns success status.
    /// <code>Offset: 0x005AE520
    /// int __thiscall PublicWeenieDesc::UnPack(PublicWeenieDesc*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the packed data buffer; it is advanced as each field is read.</param>
    /// <param name="size">Size of the available data in bytes. If the size is insufficient for any expected field, unpacking fails.</param>
    /// <returns>Non‑zero if all fields were successfully unpacked; zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PublicWeenieDesc, void**, uint, int>)0x005AE520)(ref this, addr, size);
}

