namespace ACBindings.Internal;


/// <summary>Handles playback of a sound at the location of a physics object, with configurable priority, probability and volume.</summary>
public unsafe struct SoundTweakedHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct SoundTweakedHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTweakedHook*, void> SoundTweakedHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTweakedHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTweakedHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTweakedHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTweakedHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTweakedHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTweakedHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID gid_;
    public float prio;
    public float prob;
    public float vol;

    // Generated Constructor
    public SoundTweakedHook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a SoundTweakedHook instance with default priority, probability, and volume values, and sets up its base animation hook linkage for use in the sound system.
    /// <code>Offset: 0x00527640
    /// void __thiscall SoundTweakedHook::SoundTweakedHook(SoundTweakedHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTweakedHook, void>)0x00527640)(ref this);

    /// <summary>Plays a sound associated with this hook at the given physics object’s location using specified priority, probability, and volume settings.
    /// <code>Offset: 0x00527680
    /// void __thiscall SoundTweakedHook::Execute(SoundTweakedHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="this">The SoundTweakedHook instance containing sound configuration.</param>
    /// <param name="physobj">The physics object whose position determines where the sound is played.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTweakedHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527680)(ref this, physobj);

    /// <summary>Packs the SoundTweakedHook instance into a binary format by writing its ID and audio properties (probability, priority, volume) sequentially into the memory location pointed to by addr.
    /// <code>Offset: 0x00528330
    /// unsigned int __thiscall SoundTweakedHook::Pack(SoundTweakedHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position; after packing it points to the next free byte in the buffer.</param>
    /// <param name="size">Maximum number of bytes available for writing (not explicitly used within this function).</param>
    /// <returns>The total size in bytes required for the packed representation, as returned by the base class's pack_size method.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTweakedHook, void**, uint, uint>)0x00528330)(ref this, addr, size);

    /// <summary>Unpacks a sound hook from a binary stream, initializing its ID, probability, priority, and volume, then creates the corresponding sound.
    /// <code>Offset: 0x00528380
    /// int __thiscall SoundTweakedHook::UnPack(SoundTweakedHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the data buffer; advanced as each field is read.</param>
    /// <param name="size">Size of the data buffer (unused in this implementation).</param>
    /// <returns>Always returns 1 indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTweakedHook, void**, uint, int>)0x00528380)(ref this, addr, size);
}

