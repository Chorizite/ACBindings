namespace ACBindings.Internal;


/// <summary>Encapsulates data for a squelch filter, tracking the number of messages processed, whether zone‑based filtering is enabled, and the filter’s identifier.</summary>
public unsafe struct SquelchInfo : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SquelchInfo_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchInfo*, void> SquelchInfo_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchInfo*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchInfo*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchInfo*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.vlong _squelch_msgs;
    public int _is_zone_squelch;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;

    // Generated Constructor
    public SquelchInfo() {
        _ConstructorInternal();
    }
    public SquelchInfo(void** a2, uint i) {
        _ConstructorInternal(a2, i);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Updates the supplied integer pointer with this SquelchInfo object's current name handle, adjusting reference counts for any previous value.
    /// <code>Offset: 0x0058A180
    /// void __thiscall SquelchInfo::InqName(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an int that holds a reference to the instance's name; after execution it points to the new name and its reference count is incremented while the old reference (if different) has been decremented.</param>
    public void InqName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, int*, void>)0x0058A180)(ref this, a2);

    /// <summary>Checks whether the squelch message set stored in the object contains any entries.
    /// <code>Offset: 0x006B1AF0
    /// int __thiscall SquelchInfo::IsEmpty(SquelchInfo*)</code>
    /// </summary>
    /// <returns>Non‑zero (true) if the squelch mask is empty; zero otherwise.</returns>
    public int IsEmpty() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, int>)0x006B1AF0)(ref this);

    /// <summary>Determines whether a message type is currently suppressed by the object's squelch settings.
    /// <code>Offset: 0x006B1B20
    /// int __thiscall SquelchInfo::IsSquelched(SquelchInfo*,unsigned int)</code>
    /// </summary>
    /// <param name="msg_type">Identifier of the message to evaluate.</param>
    /// <returns>Non‑zero if the specified message type is squelched; zero otherwise. For msg_type = 1, returns non‑zero only when all possible message bits are set.</returns>
    public int IsSquelched(uint msg_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, uint, int>)0x006B1B20)(ref this, msg_type);

    /// <summary>Resets the squelch state by clearing the message counter, resetting the zone flag, and releasing any allocated name string if present.
    /// <code>Offset: 0x006B1DA0
    /// void __thiscall SquelchInfo::Clear(SquelchInfo*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, void>)0x006B1DA0)(ref this);

    /// <summary>Initializes a SquelchInfo instance by setting the vtable, zeroing the message counter, assigning an empty name string, incrementing its reference count, and clearing any existing data.
    /// <code>Offset: 0x006B1F00
    /// void __thiscall SquelchInfo::SquelchInfo(SquelchInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, void>)0x006B1F00)(ref this);

    /// <summary>Constructs a SquelchInfo object, initializing its vtable, clearing message flags, setting the name buffer to null, and configuring squelch bits based on the supplied index.
    /// <code>Offset: 0x006B1F40
    /// SquelchInfo* __thiscall SquelchInfo::SquelchInfo(SquelchInfo*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a PStringBase&lt;char&gt; buffer that becomes the object's name; if different from the current buffer, releases the previous buffer before assigning.</param>
    /// <param name="i">Index specifying which squelch bit(s) to set: passing 1 sets all bits in the message mask; otherwise sets only the bit at position i (0‑127).</param>
    /// <returns>Reference to the newly constructed SquelchInfo instance.</returns>
    public ACBindings.Internal.SquelchInfo* _ConstructorInternal(void** a2, uint i) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, void**, uint, ACBindings.Internal.SquelchInfo*>)0x006B1F40)(ref this, a2, i);

    /// <summary>Destroys a SquelchInfo instance, freeing the name string, resetting the squelch message counter, and restoring base‑class virtual table pointers.
    /// <code>Offset: 0x006B1FE0
    /// void __thiscall SquelchInfo::~SquelchInfo(SquelchInfo*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, void>)0x006B1FE0)(ref this);

    /// <summary>Serializes a SquelchInfo instance into the provided buffer when enough space is available. The function writes the squelch message count, name string, and zone flag sequentially.
    /// <code>Offset: 0x006B2020
    /// unsigned int __thiscall SquelchInfo::Pack(SquelchInfo*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of the destination buffer where packed data will be written.</param>
    /// <param name="size">Maximum number of bytes that can be written to the destination buffer.</param>
    /// <returns>The total number of bytes required to pack a SquelchInfo object. If size is less than this value, no data is copied.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, void**, uint, uint>)0x006B2020)(ref this, addr, size);

    /// <summary>Unpacks a SquelchInfo object from a buffer, initializing its name, squelch message list and zone flag.
    /// <code>Offset: 0x006B2090
    /// int __thiscall SquelchInfo::UnPack(SquelchInfo*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the source buffer; updated as data is consumed.</param>
    /// <param name="size">Total size of the remaining buffer data available for unpacking.</param>
    /// <returns>1 if unpacking succeeds; 0 otherwise (e.g., insufficient buffer).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, void**, uint, int>)0x006B2090)(ref this, addr, size);
}

