namespace ACBindings.Internal;


/// <summary>Metadata container for a game quest, holding the quest's name, minimum delta, and maximum allowed solves. Provides pack/unpack support for serializing quest definitions to and from binary buffers. Used by quest management subsystem to enforce play constraints.</summary>
public unsafe struct QuestDef : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct QuestDef_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestDef*, void> QuestDef_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestDef*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestDef*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestDef*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _fullname;
    public int _mindelta;
    public int _maxsolves;

    // Generated Constructor
    public QuestDef(ACBindings.Internal.QuestDef* that) {
        _ConstructorInternal(that);
    }
    public QuestDef() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a QuestDef instance by decrementing the reference count of its full name string, invoking cleanup when the count reaches zero, and restoring the base PackObj virtual table to its default state.
    /// <code>Offset: 0x0059A280
    /// void __thiscall QuestDef::~QuestDef(QuestDef*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuestDef, void>)0x0059A280)(ref this);

    /// <summary>Creates a QuestDef by copying properties from another instance, sharing the full‑name string and incrementing its reference count.
    /// <code>Offset: 0x0059A6C0
    /// void __thiscall QuestDef::QuestDef(QuestDef*,const QuestDef*)</code>
    /// </summary>
    /// <param name="that">The source QuestDef whose data is copied into the new object.</param>
    public void _ConstructorInternal(ACBindings.Internal.QuestDef* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuestDef, ACBindings.Internal.QuestDef*, void>)0x0059A6C0)(ref this, that);

    /// <summary>Serializes a QuestDef instance into a contiguous memory block by writing _mindelta, _maxsolves, and the full name string. The buffer pointer is advanced past each written element during serialization.
    /// <code>Offset: 0x005D3740
    /// unsigned int __thiscall QuestDef::Pack(QuestDef*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a pointer that will be updated to point after each serialized field.</param>
    /// <param name="size">Size of the preallocated buffer; serialization occurs only if this size is sufficient.</param>
    /// <returns>Required size in bytes for fully serializing this QuestDef object, regardless of available space.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuestDef, void**, uint, uint>)0x005D3740)(ref this, addr, size);

    /// <summary>Initializes a QuestDef object by setting its base class vtable, default mindelta and maxsolves values, assigning the full name string from an internal source, and applying a byte‑wise transformation to obfuscate the stored string. The constructor also handles reference counting for the string buffer to ensure correct memory management.
    /// <code>Offset: 0x005D37A0
    /// void __thiscall QuestDef::QuestDef(QuestDef*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuestDef, void>)0x005D37A0)(ref this);

    /// <summary>Unpacks a QuestDef object's data from the supplied buffer, populating its name and numerical limits.
    /// <code>Offset: 0x005D3810
    /// int __thiscall QuestDef::UnPack(QuestDef*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current read position within the source buffer; advanced past each field as it is decoded.</param>
    /// <param name="size">Remaining byte count available in the buffer for unpacking.</param>
    /// <returns>Non‑zero on success, zero if insufficient data or unpack failure.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuestDef, void**, uint, int>)0x005D3810)(ref this, addr, size);
}

