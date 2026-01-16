namespace ACBindings.Internal;


/// <summary>Stores a list of object effects that define how clothing alters animation parts and textures for models.</summary>
/// <remarks>Supports serialization, deserialization, and application of these effects to ObjDesc instances.</remarks>
public unsafe struct ClothingBase : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ClothingBase_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClothingBase*, void> ClothingBase_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClothingBase*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClothingBase*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClothingBase*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint numObjectEffects;
    public ACBindings.Internal.CloObjectEffect* objectEffects;

    // Generated Constructor
    public ClothingBase() {
        _ConstructorInternal();
    }
    public ClothingBase(ACBindings.Internal.ClothingBase* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Computes the total number of bytes needed to serialize this clothing object's effects, including base overhead.
    /// <code>Offset: 0x005A9D80
    /// unsigned int __thiscall ClothingBase::pack_size(ClothingBase*)</code>
    /// </summary>
    /// <returns>The size in bytes required to pack all associated object effects.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingBase, uint>)0x005A9D80)(ref this);

    /// <summary>Constructs a ClothingBase object, initializing it to have no object effects.
    /// <code>Offset: 0x005A9DD0
    /// void __thiscall ClothingBase::ClothingBase(ClothingBase*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingBase, void>)0x005A9DD0)(ref this);

    /// <summary>Destroys a ClothingBase instance by freeing its object effects array, deleting any associated texture data, and invoking the base class destructor. Ensures that internal vtable pointers are reset to prevent further use of the destroyed object.
    /// <code>Offset: 0x005A9DF0
    /// void __thiscall ClothingBase::~ClothingBase(ClothingBase*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingBase, void>)0x005A9DF0)(ref this);

    /// <summary>Applies clothing object effects stored in this instance to the specified ObjDesc, adding animation part changes and texture map changes for each effect.
    /// <code>Offset: 0x005A9F60
    /// int __thiscall ClothingBase::ApplyPartAndTextureChanges(ClothingBase*,ObjDesc*)</code>
    /// </summary>
    /// <param name="od">Target ObjDesc that receives the added changes.</param>
    /// <returns>A non‑zero value if all texture IDs were valid; zero otherwise.</returns>
    public int ApplyPartAndTextureChanges(ACBindings.Internal.ObjDesc* od) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingBase, ACBindings.Internal.ObjDesc*, int>)0x005A9F60)(ref this, od);

    /// <summary>Packs the ClothingBase instance into a preallocated buffer, advancing the pointer as data is written. If the supplied space is insufficient, no data is written and the function returns the size that would be required.
    /// <code>Offset: 0x005AA070
    /// unsigned int __thiscall ClothingBase::Pack(ClothingBase*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of the current write position in the buffer; updated to point after the packed data.</param>
    /// <param name="size">Number of bytes available in the buffer for packing.</param>
    /// <returns>The number of bytes written if successful, or the total size needed to pack the object when insufficient space is provided.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingBase, void**, uint, uint>)0x005AA070)(ref this, addr, size);

    /// <summary>Deserializes a ClothingBase object from the supplied buffer, allocating and initializing its CloObjectEffect array while cleaning up any previously stored effects.
    /// <code>Offset: 0x005AA0E0
    /// int __thiscall ClothingBase::UnPack(ClothingBase*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current read position in the input buffer; updated as data is consumed during unpacking.</param>
    /// <param name="size">Total number of bytes available for unpacking from the buffer.</param>
    /// <returns>Non-zero if the operation succeeds and sufficient data were available; otherwise zero.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingBase, void**, uint, int>)0x005AA0E0)(ref this, addr, size);

    /// <summary>Copies the contents of a given ClothingBase instance into this object, setting up base class pointers and delegating further copying to the assignment operator.
    /// <code>Offset: 0x005AA230
    /// void __thiscall ClothingBase::ClothingBase(ClothingBase*,const ClothingBase*)</code>
    /// </summary>
    /// <param name="rhs">The source ClothingBase from which to copy data.</param>
    public void _ConstructorInternal(ACBindings.Internal.ClothingBase* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingBase, ACBindings.Internal.ClothingBase*, void>)0x005AA230)(ref this, rhs);
}

