namespace ACBindings.Internal;


/// <summary>Holds blend weights for high, mid, and low segments of left/right forearms and backs, used to drive animation blending or pose selection.</summary>
/// <remarks>Packable into a 48‑byte buffer via PackObj methods.</remarks>
public unsafe struct BodyPartSelectionData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct BodyPartSelectionData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPartSelectionData*, void> BodyPartSelectionData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPartSelectionData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPartSelectionData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPartSelectionData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float HLF;
    public float MLF;
    public float LLF;
    public float HRF;
    public float MRF;
    public float LRF;
    public float HLB;
    public float MLB;
    public float LLB;
    public float HRB;
    public float MRB;
    public float LRB;

    // Generated Constructor
    public BodyPartSelectionData() {
        _ConstructorInternal();
    }
    public BodyPartSelectionData(ACBindings.Internal.BodyPartSelectionData* that) {
        _ConstructorInternal(that);
    }

    // Methods

    /// <summary>Provides the fixed size of a BodyPartSelectionData pack in bytes.
    /// <code>Offset: 0x00422370
    /// unsigned int __thiscall BodyPartSelectionData::GetPackSize(BodyPartSelectionData*)</code>
    /// </summary>
    /// <returns>The size, in bytes, of the BodyPartSelectionData structure (typically 48).</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPartSelectionData, uint>)0x00422370)(ref this);

    /// <summary>Initializes a new instance of BodyPartSelectionData, setting all body part selection values to zero.
    /// <code>Offset: 0x005D20F0
    /// void __thiscall BodyPartSelectionData::BodyPartSelectionData(BodyPartSelectionData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPartSelectionData, void>)0x005D20F0)(ref this);

    /// <summary>Copies all limb selection parameters from the provided source instance into this new object.
    /// <code>Offset: 0x005D2120
    /// void __thiscall BodyPartSelectionData::BodyPartSelectionData(BodyPartSelectionData*,const BodyPartSelectionData*)</code>
    /// </summary>
    /// <param name="that">The BodyPartSelectionData instance whose values are copied.</param>
    public void _ConstructorInternal(ACBindings.Internal.BodyPartSelectionData* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPartSelectionData, ACBindings.Internal.BodyPartSelectionData*, void>)0x005D2120)(ref this, that);

    /// <summary>Encodes the body part selection values into a contiguous float array when enough space is available.
    /// <code>Offset: 0x005D25E0
    /// unsigned int __thiscall BodyPartSelectionData::Pack(BodyPartSelectionData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location; updated to point after the last stored float.</param>
    /// <param name="size">Number of bytes remaining in the buffer; packing occurs only if this value is at least the required pack size.</param>
    /// <returns>The byte count necessary to store all body part selection fields (12 floats).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPartSelectionData, void**, uint, uint>)0x005D25E0)(ref this, addr, size);

    /// <summary>Unpacks body part selection data from the supplied buffer into this object's fields.
    /// <code>Offset: 0x005D2690
    /// int __thiscall BodyPartSelectionData::UnPack(BodyPartSelectionData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the input buffer; advanced past each value as it is read.</param>
    /// <param name="size">Number of bytes remaining at *addr; must be at least this->baseclass_0.GetPackSize(...).</param>
    /// <returns>Non‑zero on success, zero if the buffer contains insufficient data.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPartSelectionData, void**, uint, int>)0x005D2690)(ref this, addr, size);
}

