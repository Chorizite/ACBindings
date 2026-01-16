namespace ACBindings.Internal;


/// <summary>
/// Represents a spell component, holding metadata such as name, category, icon ID, type, gesture code, execution time, descriptive text, and cooldown modifier used by the spell system.
/// </summary>
public unsafe struct SpellComponentBase : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SpellComponentBase_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellComponentBase*, void> SpellComponentBase_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellComponentBase*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellComponentBase*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellComponentBase*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;
    public ACBindings.Internal.SpellComponentCategory _category;
    public ACBindings.Internal.IDClass____tagDataID _iconID;
    public ACBindings.Internal.SpellComponentType _type;
    public uint _gesture;
    public float _time;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _text;
    public float _CDM;

    // Generated Constructor
    public SpellComponentBase() {
        _ConstructorInternal();
    }
    public SpellComponentBase(ACBindings.Internal.SpellComponentBase* that) {
        _ConstructorInternal(that);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a new instance of SpellComponentBase by setting up the base class vtable, assigning empty strings for name and text with proper reference counting, and invoking Init to configure default values.
    /// <code>Offset: 0x00489EE0
    /// void __thiscall SpellComponentBase::SpellComponentBase(SpellComponentBase*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentBase, void>)0x00489EE0)(ref this);

    /// <summary>Destroys a SpellComponentBase instance, releasing its name and text strings by decrementing reference counts, freeing memory if needed, and restoring the base PackObj virtual table to its default state.
    /// <code>Offset: 0x00489F20
    /// void __thiscall SpellComponentBase::~SpellComponentBase(SpellComponentBase*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentBase, void>)0x00489F20)(ref this);

    /// <summary>Retrieves the decoded name of the spell component, providing a reference‑counted string via an output pointer.
    /// <code>Offset: 0x00597D40
    /// int* __thiscall SpellComponentBase::InqName(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to receive the string reference; on return holds the component’s name.</param>
    /// <returns>The same pointer passed in as a2, containing the referenced name string.</returns>
    public int* InqName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentBase, int*, int*>)0x00597D40)(ref this, a2);

    /// <summary>Serializes a spell component into a contiguous memory buffer when sufficient space is available and returns the total byte size required for full serialization.
    /// <code>Offset: 0x005BCEB0
    /// unsigned int __thiscall SpellComponentBase::Pack(SpellComponentBase*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; advanced as each field is written.</param>
    /// <param name="size">Maximum number of bytes that may be written to the buffer.</param>
    /// <returns>The total number of bytes needed to pack this spell component completely.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentBase, void**, uint, uint>)0x005BCEB0)(ref this, addr, size);

    /// <summary>Initializes a SpellComponentBase object by setting its name and text from a global value and resetting category, icon ID, type, gesture, time, and cooldown modifier to defaults.
    /// <code>Offset: 0x005BCF60
    /// void __thiscall SpellComponentBase::Init(SpellComponentBase*)</code>
    /// </summary>
    public void Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentBase, void>)0x005BCF60)(ref this);

    /// <summary>Deserializes a spell component from a buffer into the current object, validating that the supplied size contains all required data before unpacking.
    /// <code>Offset: 0x005BCFA0
    /// int __thiscall SpellComponentBase::UnPack(SpellComponentBase*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the start of the serialized data; after execution it points to the byte following the consumed block.</param>
    /// <param name="size">Total number of bytes available in the buffer pointed to by <paramref name="addr"/>.</param>
    /// <returns>1 if unpacking succeeded and the buffer was large enough; otherwise 0, leaving the object partially updated.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentBase, void**, uint, int>)0x005BCFA0)(ref this, addr, size);

    /// <summary>Constructs a new SpellComponentBase by copying another instance’s data, incrementing reference counts for shared string buffers so the original and copy share resources.
    /// <code>Offset: 0x005BD360
    /// void __thiscall SpellComponentBase::SpellComponentBase(SpellComponentBase*,const SpellComponentBase*)</code>
    /// </summary>
    /// <param name="that">The component whose state is duplicated into this object.</param>
    public void _ConstructorInternal(ACBindings.Internal.SpellComponentBase* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentBase, ACBindings.Internal.SpellComponentBase*, void>)0x005BD360)(ref this, that);
}

