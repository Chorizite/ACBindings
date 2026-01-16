namespace ACBindings.Internal;


/// <summary>Linked list node for animation hooks, holding a virtual table pointer, link to the next hook, and an integer direction value.</summary>
public unsafe struct CAnimHook
{
    // Child Types

    /// <summary>Defines the virtual function table for animation hooks, providing callbacks for lifecycle management, execution on physics objects, type identification, data handling, and serialization support.</summary>
    public unsafe struct CAnimHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAnimHook*, void> CAnimHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAnimHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAnimHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAnimHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAnimHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAnimHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAnimHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }
    // CAnimHook::AnimHookDir
    public enum AnimHookDir : uint
    {
        BOTH_ANIMHOOK = 0x0,
        FORWARD_ANIMHOOK = 0x1,
        FORCE_AnimHookDir_32_BIT = 0x7FFFFFFF,
        UNKNOWN_ANIMHOOK = 0xFFFFFFFE,
        BACKWARD_ANIMHOOK = 0xFFFFFFFF
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.CAnimHook* next_hook;
    public int direction_;

    // Methods

    /// <summary>Appends the current CAnimHook instance to the tail of a linked list referenced by start, initializing the list if empty.
    /// <code>Offset: 0x00527540
    /// void __thiscall CAnimHook::add_to_list(CAnimHook*,CAnimHook**)</code>
    /// </summary>
    /// <param name="start">Pointer to the head of the list where this hook will be added; may point to null to create a new list.</param>
    public void add_to_list(ACBindings.Internal.CAnimHook** start) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAnimHook, ACBindings.Internal.CAnimHook**, void>)0x00527540)(ref this, start);

    /// <summary>Calculates the total packed size of a CAnimHook object, accounting for header data and aligning to a four‑byte boundary.
    /// <code>Offset: 0x00527570
    /// unsigned int __cdecl CAnimHook::PackSize(CAnimHook*)</code>
    /// </summary>
    /// <param name="hook">The CAnimHook instance whose size is computed.</param>
    /// <returns>The packed size in bytes.</returns>
    public static uint PackSize(ACBindings.Internal.CAnimHook* hook) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CAnimHook*, uint>)0x00527570)(hook);

    /// <summary>Writes the hook type and direction into the provided buffer, then calls the hook’s Pack method to serialize additional data and aligns the write pointer for subsequent operations.
    /// <code>Offset: 0x005275A0
    /// void __cdecl CAnimHook::PackHook(CAnimHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="hook">The animation hook instance to pack.</param>
    /// <param name="addr">Pointer to the current position in the output buffer; updated after packing.</param>
    /// <param name="size">Remaining size of the output buffer or maximum bytes allowed for this packing operation.</param>
    public static void PackHook(ACBindings.Internal.CAnimHook* hook, void** addr, uint size) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CAnimHook*, void**, uint, void>)0x005275A0)(hook, addr, size);

    /// <summary>Parses a serialized animation hook from the supplied buffer, dynamically creates the appropriate derived hook subtype based on its identifier, unpacks its fields and returns the constructed object.
    /// <code>Offset: 0x00527DD0
    /// CAnimHook* __cdecl CAnimHook::UnPackHook(void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a pointer that references the current position in the data stream; it is advanced as bytes are consumed during unpacking.</param>
    /// <param name="size">Remaining size of the data block available for reading.</param>
    /// <returns>Pointer to the newly allocated <c>CAnimHook</c> instance representing the parsed hook, or <c>nullptr</c> if allocation fails or an unsupported type is encountered. The returned object's <c>direction_</c> field is set from the next integer value in the stream.</returns>
    public static ACBindings.Internal.CAnimHook* UnPackHook(void** addr, uint size) => ((delegate* unmanaged[Cdecl]<void**, uint, ACBindings.Internal.CAnimHook*>)0x00527DD0)(addr, size);
}

