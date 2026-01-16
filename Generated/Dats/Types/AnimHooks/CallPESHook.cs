namespace ACBindings.Internal;


/// <summary>Executes physics effect scripts on game objects by holding a PES identifier and an optional pause duration.</summary>
public unsafe struct CallPESHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct CallPESHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CallPESHook*, void> CallPESHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CallPESHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CallPESHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CallPESHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CallPESHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CallPESHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CallPESHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID pes;
    public float pause;

    // Methods

    /// <summary>Executes a physics effect script on the given physics object using the stored PES ID and pause duration.
    /// <code>Offset: 0x00527A20
    /// void __thiscall CallPESHook::Execute(CallPESHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">Target physics object for the PES execution.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CallPESHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527A20)(ref this, object_);

    /// <summary>Provides the numeric type ID for a PES hook.
    /// <code>Offset: 0x00527DC0
    /// int __thiscall CallPESHook::GetType(CallPESHook*)</code>
    /// </summary>
    /// <returns>The integer value 19 identifying the PES hook type.</returns>
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CallPESHook, int>)0x00527DC0)(ref this);

    /// <summary>Serializes the CallPESHook's pes ID and pause value into a buffer when enough space is provided.
    /// <code>Offset: 0x005283F0
    /// unsigned int __thiscall CallPESHook::Pack(CallPESHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within a buffer; will be advanced past written data.</param>
    /// <param name="size">Number of bytes available for writing in the buffer.</param>
    /// <returns>The total number of bytes required to serialize the CallPESHook, regardless of whether serialization occurred.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CallPESHook, void**, uint, uint>)0x005283F0)(ref this, addr, size);

    /// <summary>Unpacks an identifier and a pause value from a data buffer, storing them in the PES hook's fields while advancing the buffer pointer.
    /// <code>Offset: 0x00528420
    /// int __thiscall CallPESHook::UnPack(CallPESHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the data buffer. After unpacking, it points past the consumed bytes.</param>
    /// <param name="size">Total size of the data block to be unpacked; not used by this implementation but part of the interface.</param>
    /// <returns>Always returns 1 to signal successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CallPESHook, void**, uint, int>)0x00528420)(ref this, addr, size);
}

