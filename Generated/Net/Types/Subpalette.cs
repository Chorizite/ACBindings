namespace ACBindings.Internal;


/// <summary>Represents a sub‑palette entry used in color packing, holding an identifier, offset position, and number of colors, along with links to adjacent entries.</summary>
/// <remarks>The pack and unpack routines serialize this data into binary buffers; the default constructor initializes an invalid ID and zeroed values.</remarks>
public unsafe struct Subpalette
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Subpalette_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Subpalette*, void> Subpalette_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Subpalette*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Subpalette*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Subpalette*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID subID;
    public uint offset;
    public uint numcolors;
    public ACBindings.Internal.Subpalette* prev;
    public ACBindings.Internal.Subpalette* next;

    // Generated Constructor
    public Subpalette() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a Subpalette instance with default values: sets the virtual table pointer, assigns an invalid identifier, zeros offset and color count, and clears previous/next pointers.
    /// <code>Offset: 0x00500660
    /// void __thiscall Subpalette::Subpalette(Subpalette*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Subpalette, void>)0x00500660)(ref this);

    /// <summary>Determines whether the current subpalette can replace another based on matching offset and color count or by being a default full palette when no offset is set.
    /// <code>Offset: 0x005AE8E0
    /// int __thiscall Subpalette::replaces(Subpalette*,const Subpalette*)</code>
    /// </summary>
    /// <param name="change">The subpalette to compare against.</param>
    /// <returns>True if offsets and color counts match, or if this subpalette has zero offset and contains 2048 colors; otherwise false.</returns>
    public int replaces(ACBindings.Internal.Subpalette* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Subpalette, ACBindings.Internal.Subpalette*, int>)0x005AE8E0)(ref this, change);

    /// <summary>Returns true if this palette has no offset and 2048 colors, and the supplied palette either has an offset or lacks 2048 colors; otherwise false.
    /// <code>Offset: 0x005AE920
    /// int __thiscall Subpalette::supercedes(Subpalette*,const Subpalette*)</code>
    /// </summary>
    /// <param name="change">The subpalette to compare against.</param>
    /// <returns>Non-zero when this palette supersedes the provided one; zero otherwise.</returns>
    public int supercedes(ACBindings.Internal.Subpalette* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Subpalette, ACBindings.Internal.Subpalette*, int>)0x005AE920)(ref this, change);

    /// <summary>Packs Subpalette data into a byte buffer, encoding offset and color count in compact form.
    /// <code>Offset: 0x005AEB00
    /// unsigned int __thiscall Subpalette::Pack(Subpalette*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a pointer to the output buffer; updated to point after written bytes.</param>
    /// <param name="size">Maximum number of bytes available at *addr for packing. If insufficient, no data is written.</param>
    /// <returns>The total byte count required to pack this Subpalette.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Subpalette, void**, uint, uint>)0x005AEB00)(ref this, addr, size);

    /// <summary>Unpacks a subpalette from serialized data into this Subpalette instance, reading its identifier, offset index and color count.
    /// <code>Offset: 0x005AEB60
    /// int __thiscall Subpalette::UnPack(Subpalette*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the input buffer; will be advanced as bytes are consumed during unpacking.</param>
    /// <param name="size">Number of remaining bytes available for unpacking; must be at least 4 for a successful operation.</param>
    /// <returns>1 if unpack succeeded, 0 if data is incomplete or invalid.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Subpalette, void**, uint, int>)0x005AEB60)(ref this, addr, size);
}

