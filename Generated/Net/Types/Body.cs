namespace ACBindings.Internal;


/// <summary>Represents a collection of body parts identified by unique keys, stored in an efficient hash table.</summary>
/// <remarks>Supports packing and unpacking operations through the inherited PackObj interface.</remarks>
public unsafe struct Body
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Body_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Body*, void> Body_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Body*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Body*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Body*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable__int___BodyPart _body_part_table;

    // Generated Constructor
    public Body() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a Body instance by setting up its internal hash table for body parts and configuring base class virtual function pointers.
    /// <code>Offset: 0x005905B0
    /// void __thiscall Body::Body(Body*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Body, void>)0x005905B0)(ref this);

    /// <summary>Restores a Body object's state from a serialized data block, validating buffer size and preventing overflow.
    /// <code>Offset: 0x005D2040
    /// int __thiscall Body::UnPack(Body*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the memory location holding the serialized body data; may be updated during unpacking.</param>
    /// <param name="size">Size of the supplied data buffer in bytes.</param>
    /// <returns>Non‑zero if unpacking succeeded, zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Body, void**, uint, int>)0x005D2040)(ref this, addr, size);
}

