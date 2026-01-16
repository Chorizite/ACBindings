namespace ACBindings.Internal;


/// <summary>Represents a palette template used to manage an icon identifier and a collection of sub‑palette effects, facilitating serialization through packing and unpacking operations.</summary>
public unsafe struct CloPaletteTemplate : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CloPaletteTemplate_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloPaletteTemplate*, void> CloPaletteTemplate_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloPaletteTemplate*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloPaletteTemplate*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloPaletteTemplate*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID iconID;
    public uint numSubpalEffects;
    public ACBindings.Internal.CloSubpalEffect* subpalEffects;

    // Generated Constructor
    public CloPaletteTemplate() {
        _ConstructorInternal();
    }
    public CloPaletteTemplate(ACBindings.Internal.CloPaletteTemplate* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Computes the number of bytes needed to pack a palette template by summing the packed sizes of all contained sub‑palette effects and adding an 8‑byte header.
    /// <code>Offset: 0x005A93E0
    /// unsigned int __thiscall CloPaletteTemplate::pack_size(CloPaletteTemplate*)</code>
    /// </summary>
    /// <returns>The total byte count required for serialization.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloPaletteTemplate, uint>)0x005A93E0)(ref this);

    /// <summary>Initializes a CloPaletteTemplate instance with default values, assigning the proper virtual table, marking the icon identifier as invalid, and resetting sub‑palette effect counts and pointers.
    /// <code>Offset: 0x005A9520
    /// void __thiscall CloPaletteTemplate::CloPaletteTemplate(CloPaletteTemplate*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloPaletteTemplate, void>)0x005A9520)(ref this);

    /// <summary>Destroys a CloPaletteTemplate instance, freeing any allocated subpalette effect data and resetting the icon identifier to an invalid state.
    /// <code>Offset: 0x005A9540
    /// void __thiscall CloPaletteTemplate::~CloPaletteTemplate(CloPaletteTemplate*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloPaletteTemplate, void>)0x005A9540)(ref this);

    /// <summary>Packs the palette's icon ID and subpalette effects into a contiguous memory buffer, advancing the supplied address pointer past the written data.
    /// <code>Offset: 0x005A9AB0
    /// unsigned int __thiscall CloPaletteTemplate::Pack(CloPaletteTemplate*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current write position; updated to point after the last byte written.</param>
    /// <param name="size">Maximum number of bytes available for packing.</param>
    /// <returns>The total size in bytes that would be written. If the buffer is too small, no data is written but this value still indicates the required space.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloPaletteTemplate, void**, uint, uint>)0x005A9AB0)(ref this, addr, size);

    /// <summary>Unpacks a serialized CloPaletteTemplate from the provided buffer, initializing iconID, numSubpalEffects, and allocating subpalEffects accordingly.
    /// <code>Offset: 0x005A9B20
    /// int __thiscall CloPaletteTemplate::UnPack(CloPaletteTemplate*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current read position within the buffer; updated as data is consumed.</param>
    /// <param name="size">Remaining size of the buffer in bytes; function verifies sufficient space before unpacking.</param>
    /// <returns>Non-zero if the entire structure was successfully decoded; zero on failure or insufficient data.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloPaletteTemplate, void**, uint, int>)0x005A9B20)(ref this, addr, size);

    /// <summary>Initializes a new CloPaletteTemplate instance, assigning default values and copying data from an existing template.
    /// <code>Offset: 0x005A9D50
    /// void __thiscall CloPaletteTemplate::CloPaletteTemplate(CloPaletteTemplate*,const CloPaletteTemplate*)</code>
    /// </summary>
    /// <param name="rhs">The source template from which to copy properties.</param>
    public void _ConstructorInternal(ACBindings.Internal.CloPaletteTemplate* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloPaletteTemplate, ACBindings.Internal.CloPaletteTemplate*, void>)0x005A9D50)(ref this, rhs);
}

