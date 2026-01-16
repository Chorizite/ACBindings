namespace ACBindings.Internal;


/// <summary>Aggregates motion information—including a list of animations, linear velocity, angular velocity, and flag bits—and provides packing/unpacking support for binary serialization.</summary>
public unsafe struct MotionData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj
    public ACBindings.Internal.LongHashData BaseClass_LongHashData; // ACBindings.Internal.LongHashData

    // Child Types
    public unsafe struct MotionData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MotionData*, void> MotionData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MotionData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MotionData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MotionData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public byte num_anims;
    public ACBindings.Internal.AnimData* anims;
    public ACBindings.Internal.AC1Legacy.Vector3 velocity;
    public ACBindings.Internal.AC1Legacy.Vector3 omega;
    public byte bitfield;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases resources owned by a MotionData instance, resets the virtual table pointers of its embedded base classes, calls the custom Destroy routine, and clears hash identifiers.
    /// <code>Offset: 0x00522FD0
    /// void __thiscall MotionData::~MotionData(MotionData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionData, void>)0x00522FD0)(ref this);

    /// <summary>
    /// Destroys animation data owned by the MotionData instance, freeing allocated memory and resetting animation count.
    /// 
    /// <code>Offset: 0x00526D50
    /// void __thiscall MotionData::Destroy(MotionData*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionData, void>)0x00526D50)(ref this);

    /// <summary>Serializes the MotionData object into a contiguous byte buffer. The method writes a header containing the object's identifier, animation count, and flags, aligns to 4‑byte boundaries, packs each contained AnimData instance, and optionally appends velocity and angular‑velocity vectors if present.
    /// <code>Offset: 0x00526F80
    /// unsigned int __thiscall MotionData::Pack(MotionData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">A pointer to the current write position in the destination buffer; it is updated to point past the data written by this call.</param>
    /// <param name="size">The number of bytes remaining in the destination buffer. If insufficient, the function returns the required size without modifying the buffer.</param>
    /// <returns>The total number of bytes that would be written if the buffer were large enough; otherwise the size needed to fully serialize the object.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionData, void**, uint, uint>)0x00526F80)(ref this, addr, size);

    /// <summary>Unpacks serialized motion data from the supplied buffer into this MotionData instance. The function reads a header containing an identifier, number of animations and flag bits, allocates and populates an array of AnimData objects, then conditionally parses velocity and angular‑velocity vectors based on those flags.
    /// <code>Offset: 0x00527170
    /// int __thiscall MotionData::UnPack(MotionData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the buffer; advanced as data is consumed. Must point to a valid block containing at least `size` bytes remaining.</param>
    /// <param name="size">Number of bytes left in the buffer from the current address. Used only for bounds checking when reading optional velocity or omega data.</param>
    /// <returns>Always 1 on success; other values are not used by this implementation.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionData, void**, uint, int>)0x00527170)(ref this, addr, size);
}

