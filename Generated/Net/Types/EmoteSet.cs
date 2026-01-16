namespace ACBindings.Internal;


/// <summary>Represents a collection of emotes that are triggered based on category, probability, and optional quest or health conditions, each containing a list of individual emote actions.</summary>
public unsafe struct EmoteSet : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct EmoteSet_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EmoteSet*, void> EmoteSet_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EmoteSet*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EmoteSet*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EmoteSet*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint category;
    public float probability;
    public ACBindings.Internal.IDClass____tagDataID classID;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte quest;
    public uint style;
    public uint substyle;
    public uint vendorType;
    public float minhealth;
    public float maxhealth;
    public ACBindings.Internal.PackableList___Emote emotes;

    // Generated Constructor
    public EmoteSet() {
        _ConstructorInternal();
    }
    public EmoteSet(ACBindings.Internal.EmoteSet* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Calculates the serialized size of an EmoteSet, accounting for its category‑dependent header and packed emotes.
    /// <code>Offset: 0x00597300
    /// unsigned int __thiscall EmoteSet::pack_size(EmoteSet*)</code>
    /// </summary>
    /// <returns>The total number of bytes required to pack the object.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EmoteSet, uint>)0x00597300)(ref this);

    /// <summary>Packs the EmoteSet into a buffer according to its category. If the supplied size is insufficient, no data is written but the required byte count is returned.
    /// <code>Offset: 0x005973A0
    /// unsigned int __thiscall EmoteSet::Pack(EmoteSet*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a pointer that points into the destination buffer; updated to point after each piece written.</param>
    /// <param name="size">Maximum number of bytes available for writing in the buffer. If less than the pack size, no data is emitted.</param>
    /// <returns>The total number of bytes required to serialize this EmoteSet.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EmoteSet, void**, uint, uint>)0x005973A0)(ref this, addr, size);

    /// <summary>Unpacks serialized data into an EmoteSet instance, interpreting fields based on the category identifier.
    /// <code>Offset: 0x00597520
    /// int __thiscall EmoteSet::UnPack(EmoteSet*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a buffer pointer that advances as data is consumed during unpacking.</param>
    /// <param name="size">Number of bytes remaining in the buffer.</param>
    /// <returns>Non‑zero if unpacking succeeds; zero if insufficient data or an error occurs.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EmoteSet, void**, uint, int>)0x00597520)(ref this, addr, size);

    /// <summary>Initializes a new EmoteSet instance by setting default values, creating an empty emotes list, and configuring base class behavior.
    /// <code>Offset: 0x00597750
    /// void __thiscall EmoteSet::EmoteSet(EmoteSet*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EmoteSet, void>)0x00597750)(ref this);

    /// <summary>Destroys an EmoteSet instance by clearing its emotes list, decrementing the reference count of its quest string buffer (releasing it if last owner), and resetting the object’s virtual table pointers to their base classes.
    /// <code>Offset: 0x005977C0
    /// void __thiscall EmoteSet::~EmoteSet(EmoteSet*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EmoteSet, void>)0x005977C0)(ref this);

    /// <summary>Creates an EmoteSet by initializing its members and copying data from another EmoteSet.
    /// <code>Offset: 0x00597900
    /// void __thiscall EmoteSet::EmoteSet(EmoteSet*,const EmoteSet*)</code>
    /// </summary>
    /// <param name="rhs">The EmoteSet instance whose contents are copied into the new object.</param>
    public void _ConstructorInternal(ACBindings.Internal.EmoteSet* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EmoteSet, ACBindings.Internal.EmoteSet*, void>)0x00597900)(ref this, rhs);
}

