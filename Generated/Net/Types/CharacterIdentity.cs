namespace ACBindings.Internal;


/// <summary>Represents a character’s identity by storing its unique ID, display name, and timing information for visual status changes.</summary>
public unsafe struct CharacterIdentity : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CharacterIdentity_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterIdentity*, void> CharacterIdentity_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterIdentity*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterIdentity*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterIdentity*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint gid_;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte name_;
    public uint secondsGreyedOut_;

    // Generated Constructor
    public CharacterIdentity() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a CharacterIdentity instance by decrementing the reference count of its name string buffer and freeing the buffer when no longer referenced.
    /// <code>Offset: 0x004FEB40
    /// void __thiscall CharacterIdentity::~CharacterIdentity(CharacterIdentity*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterIdentity, void>)0x004FEB40)(ref this);

    /// <summary>Initializes a new CharacterIdentity object with default values: zero gid, an empty name string, and no greyed‑out time, while assigning the correct virtual table and managing the string buffer’s reference count.
    /// <code>Offset: 0x004FF180
    /// void __thiscall CharacterIdentity::CharacterIdentity(CharacterIdentity*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterIdentity, void>)0x004FF180)(ref this);

    /// <summary>Computes the number of bytes required to serialize a CharacterIdentity instance, including its name string prefixed with length and any necessary padding for 4‑byte alignment.
    /// <code>Offset: 0x004FF1B0
    /// unsigned int __thiscall CharacterIdentity::pack_size(CharacterIdentity*)</code>
    /// </summary>
    /// <returns>The total packed size in bytes, rounded up to the nearest multiple of four.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterIdentity, uint>)0x004FF1B0)(ref this);

    /// <summary>Packs a CharacterIdentity into a binary buffer, writing gid, name string, and secondsGreyedOut while aligning data boundaries. If the supplied buffer has sufficient space, writes the data, updates the address pointer, and returns the number of bytes written; otherwise returns the required size without modifying the buffer.
    /// <code>Offset: 0x004FF200
    /// unsigned int __thiscall CharacterIdentity::Pack(CharacterIdentity*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location in the destination buffer; updated to point after the serialized data on success.</param>
    /// <param name="size">Number of bytes remaining in the destination buffer. If less than the required size, the function does not modify the buffer.</param>
    /// <returns>The number of bytes written when successful, or the total byte count needed if the buffer is too small.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterIdentity, void**, uint, uint>)0x004FF200)(ref this, addr, size);

    /// <summary>Unpacks a CharacterIdentity from a serialized buffer, populating gid_, name_, and secondsGreyedOut_ while advancing the buffer pointer.
    /// <code>Offset: 0x004FF300
    /// int __thiscall CharacterIdentity::UnPack(CharacterIdentity*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the source buffer; updated to point after the unpacked data on success.</param>
    /// <param name="size">Number of bytes remaining in the buffer from the original address.</param>
    /// <returns>Non-zero if all fields were unpacked successfully; zero if name_ unpack fails, restoring the original buffer pointer.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterIdentity, void**, uint, int>)0x004FF300)(ref this, addr, size);
}

