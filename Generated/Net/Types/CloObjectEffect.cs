namespace ACBindings.Internal;


/// <summary>Encapsulates an object's appearance data for binary packing, storing part number, object identifier, and a collection of texture effects.</summary>
public unsafe struct CloObjectEffect : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CloObjectEffect_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloObjectEffect*, void> CloObjectEffect_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloObjectEffect*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloObjectEffect*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloObjectEffect*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint partNum;
    public ACBindings.Internal.IDClass____tagDataID objectID;
    public uint numTextureEffects;
    public ACBindings.Internal.CloTextureEffect* textureEffects;

    // Generated Constructor
    public CloObjectEffect() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Computes the total size in bytes needed to serialize a CloObjectEffect, adding a fixed header and the packed sizes of all associated texture effects.
    /// <code>Offset: 0x005A9390
    /// unsigned int __thiscall CloObjectEffect::pack_size(CloObjectEffect*)</code>
    /// </summary>
    /// <returns>The number of bytes required to pack the object.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloObjectEffect, uint>)0x005A9390)(ref this);

    /// <summary>Sets the object's virtual function table to the appropriate CloObjectEffect vtable. Initializes fields to defaults: partNum zero, objectID set to INVALID_DID_345, numTextureEffects zero, and textureEffects null.
    /// <code>Offset: 0x005A9430
    /// void __thiscall CloObjectEffect::CloObjectEffect(CloObjectEffect*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloObjectEffect, void>)0x005A9430)(ref this);

    /// <summary>Releases texture effect resources and resets base class virtual tables when a CloObjectEffect instance is destroyed.
    /// <code>Offset: 0x005A94B0
    /// void __thiscall CloObjectEffect::~CloObjectEffect(CloObjectEffect*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloObjectEffect, void>)0x005A94B0)(ref this);

    /// <summary>Packs the CloObjectEffect data into a contiguous buffer, advancing the address pointer accordingly while ensuring sufficient space is available.
    /// <code>Offset: 0x005A9700
    /// unsigned int __thiscall CloObjectEffect::Pack(CloObjectEffect*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">A reference to the current write position; updated to point after the packed data.</param>
    /// <param name="size">The remaining byte capacity of the buffer at the start of packing.</param>
    /// <returns>The total size required for this object (including its texture effects). If the provided buffer is large enough, the function writes the data and returns that size; otherwise it does not modify the buffer but still reports the needed size.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloObjectEffect, void**, uint, uint>)0x005A9700)(ref this, addr, size);

    /// <summary>Deserializes a CloObjectEffect from binary data starting at the buffer pointed to by *addr. The method reads part number, object ID, and an optional list of texture effects, allocating storage for them as needed.
    /// <code>Offset: 0x005A9780
    /// int __thiscall CloObjectEffect::UnPack(CloObjectEffect*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the source buffer; updated to point after the consumed data upon success.</param>
    /// <param name="size">Number of bytes remaining in the source buffer; used to guard against overruns.</param>
    /// <returns>Non‑zero if the entire structure was unpacked successfully, zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloObjectEffect, void**, uint, int>)0x005A9780)(ref this, addr, size);
}

