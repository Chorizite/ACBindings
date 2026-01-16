namespace ACBindings.Internal;


/// <summary>Encapsulates an animation hook that triggers playback of a designated sound during execution.</summary>
/// <remarks>Contains base animation hook data and specifies which sound to play. The hook’s Execute method calls SoundManager::PlaySoundA using the stored sound_type_.</remarks>
public unsafe struct SoundTableHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct SoundTableHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableHook*, void> SoundTableHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SoundType sound_type_;

    // Methods

    /// <summary>Triggers playback of the designated sound type using the provided physics object's context.
    /// <code>Offset: 0x005276B0
    /// void __thiscall SoundTableHook::Execute(SoundTableHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="physobj">The physics object that provides positional and contextual information for the sound.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableHook, ACBindings.Internal.CPhysicsObj*, void>)0x005276B0)(ref this, physobj);

    /// <summary>Packs the object’s identifier into a byte stream, advancing the destination pointer and returning the size needed for packing.
    /// <code>Offset: 0x005276D0
    /// unsigned int __thiscall SoundTableHook::Pack(SoundHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location; after execution points past the data written.</param>
    /// <param name="size">Maximum number of bytes available in the destination buffer (unused by this implementation).</param>
    /// <returns>The total number of bytes required to represent the packed object.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableHook, void**, uint, uint>)0x005276D0)(ref this, addr, size);

    /// <summary>Extracts a sound type from the data stream pointed to by addr, assigns it to the hook's sound_type_, and advances addr past the consumed bytes.
    /// <code>Offset: 0x005276F0
    /// int __thiscall SoundTableHook::UnPack(SoundTableHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer that points to the current position within the raw data buffer; after execution it will point to the next unread byte.</param>
    /// <param name="size">The size of the remaining data block (unused in this implementation).</param>
    /// <returns>Always returns 1, indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableHook, void**, uint, int>)0x005276F0)(ref this, addr, size);
}

