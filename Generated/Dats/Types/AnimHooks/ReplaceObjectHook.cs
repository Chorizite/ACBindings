namespace ACBindings.Internal;


/// <summary>Replaces an animation part within a model, specifying which component to swap and how it should be altered during playback. Implements serialization logic through its embedded AnimPartChange instance.</summary>
public unsafe struct ReplaceObjectHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct ReplaceObjectHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ReplaceObjectHook*, void> ReplaceObjectHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ReplaceObjectHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ReplaceObjectHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ReplaceObjectHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ReplaceObjectHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ReplaceObjectHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ReplaceObjectHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AnimPartChange ap_change;

    // Generated Constructor
    public ReplaceObjectHook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Computes the packed size of a ReplaceObjectHook instance by delegating to its underlying AnimPartChange’s baseclass pack implementation.
    /// <code>Offset: 0x00527710
    /// unsigned int __thiscall ReplaceObjectHook::pack_size(ReplaceObjectHook*)</code>
    /// </summary>
    /// <returns>The number of bytes required to serialize this object.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReplaceObjectHook, uint>)0x00527710)(ref this);

    /// <summary>Serializes the animation part change associated with this hook into the supplied buffer.
    /// <code>Offset: 0x00527730
    /// unsigned int __thiscall ReplaceObjectHook::Pack(ReplaceObjectHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a memory block where packed data will be written.</param>
    /// <param name="size">Maximum number of bytes that may be written to the buffer.</param>
    /// <returns>The size in bytes actually written during packing.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReplaceObjectHook, void**, uint, uint>)0x00527730)(ref this, addr, size);

    /// <summary>Delegates unpacking of a ReplaceObjectHook instance to its AnimPartChange base class using the supplied buffer and size.
    /// <code>Offset: 0x00527740
    /// int __thiscall ReplaceObjectHook::UnPack(ReplaceObjectHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to memory containing packed data for this object.</param>
    /// <param name="size">Number of bytes to read from the buffer during unpacking.</param>
    /// <returns>Integer status code returned by CAnimHook::UnPack, indicating success or failure of the operation.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReplaceObjectHook, void**, uint, int>)0x00527740)(ref this, addr, size);

    /// <summary>Initializes a ReplaceObjectHook instance by clearing its hook chain, setting the default animation direction to -2, assigning appropriate virtual function tables, and configuring an associated AnimPartChange structure for part replacement operations.
    /// <code>Offset: 0x00527CC0
    /// void __thiscall ReplaceObjectHook::ReplaceObjectHook(ReplaceObjectHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReplaceObjectHook, void>)0x00527CC0)(ref this);

    /// <summary>Returns the numeric type identifier for a ReplaceObjectHook instance.
    /// <code>Offset: 0x00527CF0
    /// int __thiscall ReplaceObjectHook::GetType(ReplaceObjectHook*)</code>
    /// </summary>
    /// <returns>An integer constant identifying the hook type; always 5 for ReplaceObjectHook.</returns>
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReplaceObjectHook, int>)0x00527CF0)(ref this);

    /// <summary>Adds the qualified data ID representing the object’s changed part to the supplied collection.
    /// <code>Offset: 0x00528580
    /// void __thiscall ReplaceObjectHook::GetSubDataIDs(ReplaceObjectHook*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="this">The ReplaceObjectHook instance whose sub-data ID is retrieved.</param>
    /// <param name="id_array">Collection that receives the generated QualifiedDataID.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReplaceObjectHook, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00528580)(ref this, id_array);
}

