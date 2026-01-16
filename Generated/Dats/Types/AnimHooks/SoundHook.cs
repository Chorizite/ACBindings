namespace ACBindings.Internal;


/// <summary>Links a global sound identifier to an animation hook, allowing the referenced sound to be played at a physics object's position when executed.</summary>
public unsafe struct SoundHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct SoundHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundHook*, void> SoundHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID gid_;

    // Generated Constructor
    public SoundHook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a new SoundHook instance with default animation hook settings and assigns an invalid global ID placeholder.
    /// <code>Offset: 0x00527600
    /// void __thiscall SoundHook::SoundHook(SoundHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundHook, void>)0x00527600)(ref this);

    /// <summary>Plays the sound referenced by gid_ at the position of physobj.
    /// <code>Offset: 0x00527620
    /// void __thiscall SoundHook::Execute(SoundHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="this">SoundHook instance containing the sound identifier.</param>
    /// <param name="physobj">Physics object whose Position determines where the sound is played.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527620)(ref this, physobj);

    /// <summary>Extracts a sound identifier from the supplied address, assigns it to this hook, and initiates its creation through the sound manager.
    /// <code>Offset: 0x005282C0
    /// int __thiscall SoundHook::UnPack(SoundHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a buffer containing the sound ID; after unpacking the pointer is advanced by four bytes.</param>
    /// <param name="size">Size of the data block (currently unused).</param>
    /// <returns>Always returns 1, indicating successful unpacking and initialization.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundHook, void**, uint, int>)0x005282C0)(ref this, addr, size);
}

