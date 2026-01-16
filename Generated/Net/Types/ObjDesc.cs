namespace ACBindings.Internal;


/// <summary>Represents a visual object descriptor that stores its base appearance, palette information, sub‑palettes, texture map changes, and animation part modifications through linked lists, enabling dynamic rendering adjustments.</summary>
public unsafe struct ObjDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.VisualDesc BaseClass_VisualDesc; // ACBindings.Internal.VisualDesc

    // Child Types
    public unsafe struct ObjDesc_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ObjDesc*, void> ObjDesc_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ObjDesc*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ObjDesc*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ObjDesc*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ObjDesc*, uint> pack_size; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID paletteID;
    public ACBindings.Internal.Subpalette* firstSubpal;
    public ACBindings.Internal.Subpalette* lastSubpal;
    public int num_subpalettes;
    public ACBindings.Internal.TextureMapChange* firstTMChange;
    public ACBindings.Internal.TextureMapChange* lastTMChange;
    public int num_texture_map_changes;
    public ACBindings.Internal.AnimPartChange* firstAPChange;
    public ACBindings.Internal.AnimPartChange* lastAPChange;
    public int num_anim_part_changes;

    // Generated Constructor
    public ObjDesc() {
        _ConstructorInternal();
    }
    public ObjDesc(ACBindings.Internal.ObjDesc* od) {
        _ConstructorInternal(od);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Returns the texture map change at the specified zero-based position within an object's collection of texture map changes.
    /// <code>Offset: 0x005AC6B0
    /// TextureMapChange* __thiscall ObjDesc::GetTextureMapChange(ObjDesc*,int)</code>
    /// </summary>
    /// <param name="num">Zero‑based index of the desired texture map change.</param>
    /// <returns>A pointer to the requested TextureMapChange, or nullptr if the index is outside the range of available changes.</returns>
    public ACBindings.Internal.TextureMapChange* GetTextureMapChange(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, int, ACBindings.Internal.TextureMapChange*>)0x005AC6B0)(ref this, num);

    /// <summary>Returns a pointer to the animation part change at the specified index within this object's list.
    /// <code>Offset: 0x005AC6D0
    /// AnimPartChange* __thiscall ObjDesc::GetAnimPartChange(ObjDesc*,int)</code>
    /// </summary>
    /// <param name="num">Zero-based index of the desired animation part change.</param>
    /// <returns>Pointer to the requested AnimPartChange, or null if the index is out of bounds.</returns>
    public ACBindings.Internal.AnimPartChange* GetAnimPartChange(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, int, ACBindings.Internal.AnimPartChange*>)0x005AC6D0)(ref this, num);

    /// <summary>Removes any existing subpalette entries from this object's linked list that are superseded by the provided subpalette.
    /// <code>Offset: 0x005AC6F0
    /// void __thiscall ObjDesc::RemoveDuplicateSubpalette(ObjDesc*,Subpalette*)</code>
    /// </summary>
    /// <param name="newGuy">The subpalette used as a reference to identify duplicates or replacements.</param>
    public void RemoveDuplicateSubpalette(ACBindings.Internal.Subpalette* newGuy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.Subpalette*, void>)0x005AC6F0)(ref this, newGuy);

    /// <summary>Removes a duplicate texture map change from the object's list by comparing it with an incoming change and updating links and counters accordingly.
    /// <code>Offset: 0x005AC760
    /// void __thiscall ObjDesc::RemoveDuplicateTextureMapChange(ObjDesc*,TextureMapChange*)</code>
    /// </summary>
    /// <param name="this">The object description containing the list of changes.</param>
    /// <param name="newGuy">The texture map change to check against for duplication.</param>
    public void RemoveDuplicateTextureMapChange(ACBindings.Internal.TextureMapChange* newGuy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.TextureMapChange*, void>)0x005AC760)(ref this, newGuy);

    /// <summary>Removes a duplicate animation part change from this object's description, if one exists that matches the supplied change.
    /// <code>Offset: 0x005AC7D0
    /// void __thiscall ObjDesc::RemoveDuplicateAnimPartChange(ObjDesc*,AnimPartChange*)</code>
    /// </summary>
    /// <param name="newGuy">The animation part change to compare against existing entries for duplication.</param>
    public void RemoveDuplicateAnimPartChange(ACBindings.Internal.AnimPartChange* newGuy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.AnimPartChange*, void>)0x005AC7D0)(ref this, newGuy);

    /// <summary>Removes all subpalette, texture map change, and animation part change objects from the descriptor, releasing their resources and resetting associated counters.
    /// <code>Offset: 0x005AC840
    /// void __thiscall ObjDesc::Clear(ObjDesc*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, void>)0x005AC840)(ref this);

    /// <summary>Removes all subpalette, texture map change, and animation part change entries from the object, destroying each entry and resetting counters.
    /// <code>Offset: 0x005AC8D0
    /// void __thiscall ObjDesc::Wipe(ObjDesc*)</code>
    /// </summary>
    public void Wipe() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, void>)0x005AC8D0)(ref this);

    /// <summary>Initializes a new ObjDesc instance with default visual and palette settings, clearing subpalette, texture map change, and animation part change lists.
    /// <code>Offset: 0x005AC9C0
    /// void __thiscall ObjDesc::ObjDesc(ObjDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, void>)0x005AC9C0)(ref this);

    /// <summary>Releases all resources held by an ObjDesc object, clearing its subpalette and texture map change lists, resetting its virtual table pointer, and invoking the base class destructor to clean inherited data.
    /// <code>Offset: 0x005ACA00
    /// void __thiscall ObjDesc::~ObjDesc(ObjDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, void>)0x005ACA00)(ref this);

    /// <summary>Adds a new subpalette to the object's list while preventing duplicates and respecting a maximum limit of 255 entries. If an existing entry supersedes the new one, the new subpalette is discarded but the operation still reports success.
    /// <code>Offset: 0x005ACA20
    /// int __thiscall ObjDesc::AddSubpalette(ObjDesc*,Subpalette*)</code>
    /// </summary>
    /// <param name="subpal">The subpalette to insert into the object.</param>
    /// <returns>1 if the subpalette was successfully added or was redundant due to a superseding entry; 0 when the input is null or the maximum number of subpalettes has been reached and the new entry cannot be stored.</returns>
    public int AddSubpalette(ACBindings.Internal.Subpalette* subpal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.Subpalette*, int>)0x005ACA20)(ref this, subpal);

    /// <summary>Adds the supplied texture-map change to this object's linked list after removing any existing identical entry; returns 1 if the change was appended successfully, or 0 if the input is null or the list has reached its maximum capacity of 255 entries.
    /// <code>Offset: 0x005ACAC0
    /// int __thiscall ObjDesc::AddTextureMapChange(ObjDesc*,TextureMapChange*)</code>
    /// </summary>
    /// <param name="texChange">The texture map change to add. If null, the operation fails and returns 0.</param>
    /// <returns>Non‑zero (1) when the change was successfully appended; zero when the input is null or the list is full.</returns>
    public int AddTextureMapChange(ACBindings.Internal.TextureMapChange* texChange) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.TextureMapChange*, int>)0x005ACAC0)(ref this, texChange);

    /// <summary>Adds an AnimPartChange to the object's linked list, ensuring no duplicate entries and respecting a maximum capacity of 255 items.
    /// <code>Offset: 0x005ACB30
    /// int __thiscall ObjDesc::AddAnimPartChange(ObjDesc*,AnimPartChange*)</code>
    /// </summary>
    /// <param name="partChange">The AnimPartChange instance to be appended to the list; must not be null.</param>
    /// <returns>1 if the change was successfully added; 0 if the input is null or the list has reached its maximum size.</returns>
    public int AddAnimPartChange(ACBindings.Internal.AnimPartChange* partChange) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.AnimPartChange*, int>)0x005ACB30)(ref this, partChange);

    /// <summary>Calculates the byte-size required to serialize this object, accounting for sub‑palettes, texture map changes, and animation part changes, then rounds up to a 4‑byte boundary.
    /// <code>Offset: 0x005ACBA0
    /// unsigned int __thiscall ObjDesc::pack_size(ObjDesc*)</code>
    /// </summary>
    /// <returns>The aligned packed size in bytes.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, uint>)0x005ACBA0)(ref this);

    /// <summary>Packs an ObjDesc into a binary format at the supplied address, writing a type marker, component counts and each sub‑component’s packed data while maintaining 4‑byte alignment.
    /// <code>Offset: 0x005ACC70
    /// unsigned int __thiscall ObjDesc::Pack(ObjDesc*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position; updated as bytes are written.</param>
    /// <param name="size">Maximum number of bytes available in the buffer; if less than the required size, no data is written but the required byte count is still returned.</param>
    /// <returns>Size in bytes that would be required to serialize this ObjDesc (including header, component data and padding).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, void**, uint, uint>)0x005ACC70)(ref this, addr, size);

    /// <summary>Unpacks an ObjDesc from a binary stream, resetting its current state and reading subpalettes, texture map changes, and animation part changes accordingly.
    /// <code>Offset: 0x005ACDA0
    /// int __thiscall ObjDesc::UnPack(ObjDesc*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the buffer; it is advanced as data is consumed.</param>
    /// <param name="size">Total size of remaining data available for unpacking.</param>
    /// <returns>Non-zero if the stream was successfully parsed and the object state updated, zero on failure (e.g., format mismatch or allocation error).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, void**, uint, int>)0x005ACDA0)(ref this, addr, size);

    /// <summary>Adds a copy of the specified subpalette to this object by allocating a new Subpalette instance and delegating to AddSubpalette.
    /// <code>Offset: 0x005AD040
    /// int __thiscall ObjDesc::AddSubpalette_1(ObjDesc*,Subpalette*)</code>
    /// </summary>
    /// <param name="subpal">The subpalette data to duplicate and add.</param>
    /// <returns>Result code from AddSubpalette, typically 0 for success or an error indicator if allocation fails.</returns>
    public int AddSubpalette_1(ACBindings.Internal.Subpalette* subpal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.Subpalette*, int>)0x005AD040)(ref this, subpal);

    /// <summary>Adds a texture map change by creating a copy of the supplied change and inserting it into this object's change list.
    /// <code>Offset: 0x005AD0A0
    /// int __thiscall ObjDesc::AddTextureMapChange_1(ObjDesc*,TextureMapChange*)</code>
    /// </summary>
    /// <param name="this">The ObjDesc instance to modify.</param>
    /// <param name="texChange">A TextureMapChange structure containing details of the change to add.</param>
    /// <returns>Result code from AddTextureMapChange; typically zero on success or an error code if allocation fails.</returns>
    public int AddTextureMapChange_1(ACBindings.Internal.TextureMapChange* texChange) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.TextureMapChange*, int>)0x005AD0A0)(ref this, texChange);

    /// <summary>Creates a copy of the supplied animation part change and adds it to this object's list.
    /// <code>Offset: 0x005AD100
    /// int __thiscall ObjDesc::AddAnimPartChange_1(ObjDesc*,AnimPartChange*)</code>
    /// </summary>
    /// <param name="partChange">The animation part change to duplicate and add.</param>
    /// <returns>The result code returned by ObjDesc::AddAnimPartChange; typically zero on success or a negative value if the addition fails.</returns>
    public int AddAnimPartChange_1(ACBindings.Internal.AnimPartChange* partChange) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.AnimPartChange*, int>)0x005AD100)(ref this, partChange);

    /// <summary>Collects all data identifiers associated with this object, including palette, subpalettes, texture map changes, and animation part changes, and inserts them into the provided array.
    /// <code>Offset: 0x005AD4C0
    /// void __thiscall ObjDesc::GetSubDataIDs(ObjDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="this">The ObjDesc instance whose IDs are to be collected.</param>
    /// <param name="id_array">Array to receive the gathered QualifiedDataID entries.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005AD4C0)(ref this, id_array);

    /// <summary>Initializes a new ObjDesc instance by copying core properties from another instance and merging its subpalettes, texture map changes, and animation part changes into this object.
    /// <code>Offset: 0x005AD590
    /// void __thiscall ObjDesc::ObjDesc(ObjDesc*,const ObjDesc*)</code>
    /// </summary>
    /// <param name="od">The source ObjDesc whose data is copied and merged.</param>
    public void _ConstructorInternal(ACBindings.Internal.ObjDesc* od) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjDesc, ACBindings.Internal.ObjDesc*, void>)0x005AD590)(ref this, od);
}

