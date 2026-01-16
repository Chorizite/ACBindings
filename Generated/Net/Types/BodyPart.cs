namespace ACBindings.Internal;


/// <summary>Represents a body part of an entity, holding its damage characteristics, armor statistics, height, and optional selection data used in game logic.</summary>
public unsafe struct BodyPart : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct BodyPart_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPart*, void> BodyPart_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPart*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPart*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPart*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.DAMAGE_TYPE _dtype;
    public int _dval;
    public float _dvar;
    public ACBindings.Internal.ArmorCache _acache;
    public ACBindings.Internal.BODY_HEIGHT _bh;
    public ACBindings.Internal.BodyPartSelectionData* _bpsd;

    // Generated Constructor
    public BodyPart() {
        _ConstructorInternal();
    }
    public BodyPart(ACBindings.Internal.BodyPart* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a new BodyPart instance with default damage, armor, and body height settings.
    /// <code>Offset: 0x0058FFF0
    /// void __thiscall BodyPart::BodyPart(BodyPart*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPart, void>)0x0058FFF0)(ref this);

    /// <summary>Computes the total pack size for a body part by summing the size of its armor cache and, if present, its selection data, adding a fixed overhead.
    /// <code>Offset: 0x005D20A0
    /// unsigned int __thiscall BodyPart::GetPackSize(BodyPart*)</code>
    /// </summary>
    /// <returns>The combined size in bytes required to serialize this body part.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPart, uint>)0x005D20A0)(ref this);

    /// <summary>Destroys a BodyPart object, releasing owned resources and resetting virtual tables.
    /// <code>Offset: 0x005D2180
    /// void __thiscall BodyPart::~BodyPart(BodyPart*)</code>
    /// </summary>
    /// <param name="this">The BodyPart instance being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPart, void>)0x005D2180)(ref this);

    /// <summary>Serializes this BodyPart instance into the buffer pointed to by *addr when sufficient space is available, returning the total number of bytes required for the packed data.
    /// <code>Offset: 0x005D2210
    /// unsigned int __thiscall BodyPart::Pack(BodyPart*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer indicating the current write location; updated to point past the packed data upon successful serialization.</param>
    /// <param name="size">Remaining size in the buffer; if smaller than the required pack size, nothing is written and the function simply returns the needed size.</param>
    /// <returns>The number of bytes that would be written for this object (including nested components). If the provided buffer is too small, the return value indicates the required size but no data is copied.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPart, void**, uint, uint>)0x005D2210)(ref this, addr, size);

    /// <summary>Deserializes a BodyPart object from binary data, extracting damage type, value, variance, body height and optional selection data.
    /// <code>Offset: 0x005D22A0
    /// int __thiscall BodyPart::UnPack(BodyPart*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current read position within the buffer; updated to point after the consumed bytes.</param>
    /// <param name="size">Total number of bytes remaining in the buffer.</param>
    /// <returns>1 if unpacking succeeds and all bounds checks pass; otherwise 0, indicating a failure or insufficient data.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPart, void**, uint, int>)0x005D22A0)(ref this, addr, size);

    /// <summary>Constructs a BodyPart instance, initializing all members before copying data from the source.
    /// <code>Offset: 0x005D2460
    /// void __thiscall BodyPart::BodyPart(BodyPart*,const BodyPart*)</code>
    /// </summary>
    /// <param name="rhs">The BodyPart whose values are copied into the new object.</param>
    public void _ConstructorInternal(ACBindings.Internal.BodyPart* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPart, ACBindings.Internal.BodyPart*, void>)0x005D2460)(ref this, rhs);
}

