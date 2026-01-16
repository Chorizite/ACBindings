namespace ACBindings.Internal;


/// <summary>Encapsulates animation metadata—identifier, frame range, and playback rate—for use in rendering or game logic.</summary>
public unsafe struct AnimData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AnimData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimData*, void> AnimData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID anim_id;
    public int low_frame;
    public int high_frame;
    public float framerate;

    // Generated Constructor
    public AnimData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes an AnimData instance with default settings, assigning a zero ID, setting the frame range from 0 to unlimited, and using a standard framerate of 30 fps.
    /// <code>Offset: 0x005268E0
    /// void __thiscall AnimData::AnimData(AnimData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimData, void>)0x005268E0)(ref this);

    /// <summary>Packs animation metadata—ID, low frame, high frame, and framerate—into a contiguous 16‑byte block when sufficient buffer space is available; otherwise leaves the buffer unchanged.
    /// <code>Offset: 0x00526A00
    /// unsigned int __thiscall AnimData::Pack(AnimData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location; updated to point past the packed data only if packing occurs.</param>
    /// <param name="size">Remaining capacity in bytes; must be at least 16 for packing.</param>
    /// <returns>Number of bytes that would be written (always 16), even when no data is actually packed due to insufficient space.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimData, void**, uint, uint>)0x00526A00)(ref this, addr, size);

    /// <summary>Extracts animation metadata from a packed data stream and populates the AnimData object.
    /// <code>Offset: 0x00526A50
    /// int __thiscall AnimData::UnPack(AnimData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position within the source buffer; advanced as fields are consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer; must be at least 16 for a valid unpack.</param>
    /// <returns>Non‑zero on successful unpack, zero if the provided size is insufficient or data cannot be processed.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimData, void**, uint, int>)0x00526A50)(ref this, addr, size);
}

