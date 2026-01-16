namespace ACBindings.Internal;


/// <summary>Represents a palette of colors, storing the number of entries, a minimum lighting threshold, and an array of 32‑bit ARGB values for serialization within the PackDBObj system.</summary>
public unsafe struct Palette
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Statics
    public static int* curr_solid_index = (int*)0x0081F918;
    public static ACBindings.Internal.Palette** solid_color_palette = (ACBindings.Internal.Palette**)0x00846758;

    // Child Types
    public unsafe struct Palette_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public uint num_colors;
    public float min_lighting;
    public uint* ARGB;

    // Generated Constructor
    public Palette(int total_num_colors) {
        _ConstructorInternal(total_num_colors);
    }

    // Methods

    /// <summary>Creates a new Palette instance and initializes it with a default size of 2048 colors.
    /// <code>Offset: 0x004F7B70
    /// DBObj* __cdecl Palette::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated DBObj representing the Palette, or null if memory allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7B70)();

    /// <summary>Returns the database object type identifier for Palette instances.
    /// <code>Offset: 0x00527490
    /// unsigned int __thiscall Palette::GetDBOType(Palette*)</code>
    /// </summary>
    /// <returns>An unsigned integer representing the DBO type of a palette.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, uint>)0x00527490)(ref this);

    /// <summary>Releases the palette's color buffer if allocated, freeing memory and resetting internal pointers.
    /// <code>Offset: 0x0053ECF0
    /// void __thiscall Palette::Destroy(Palette*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, void>)0x0053ECF0)(ref this);

    /// <summary>Releases the specified Palette object by decrementing its reference count and performing cleanup when it reaches zero. If the palette is the globally shared solid color palette, releases associated resources and resets global references. Delegates to base class release logic for other palettes.
    /// <code>Offset: 0x0053ED10
    /// void __cdecl Palette::releasePalette(Palette*)</code>
    /// </summary>
    /// <param name="pal">The Palette instance to release; may be null, in which case no action is taken.</param>
    public static void releasePalette(ACBindings.Internal.Palette* pal) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Palette*, void>)0x0053ED10)(pal);

    /// <summary>Increments the reference count of the specified palette and returns it.
    /// <code>Offset: 0x0053ED90
    /// Palette* __cdecl Palette::copyRef(Palette*)</code>
    /// </summary>
    /// <param name="palette">Palette whose reference count to increment.</param>
    /// <returns>The original palette pointer (or null if none).</returns>
    public static ACBindings.Internal.Palette* copyRef(ACBindings.Internal.Palette* palette) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Palette*, ACBindings.Internal.Palette*>)0x0053ED90)(palette);

    /// <summary>Returns the 32‑bit ARGB color at the specified index in the palette.
    /// <code>Offset: 0x0053EDB0
    /// unsigned int __thiscall Palette::get_color32(Palette*,unsigned int)</code>
    /// </summary>
    /// <param name="color_index">Zero-based position of the desired color within the palette's internal array.</param>
    /// <returns>The 32‑bit ARGB value stored at that position.</returns>
    public uint get_color32(uint color_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, uint, uint>)0x0053EDB0)(ref this, color_index);

    /// <summary>Expands a 256‑color palette to 2048 colors at runtime by allocating a larger array and duplicating each existing color across the new slots.
    /// <code>Offset: 0x0053EDC0
    /// bool __thiscall Palette::InitLoad(Palette*)</code>
    /// </summary>
    /// <returns>True after successfully expanding or if no expansion was necessary.</returns>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, byte>)0x0053EDC0)(ref this);

    /// <summary>Creates a new Palette instance with the specified number of colors, initializing serialization base classes and allocating an ARGB array.
    /// <code>Offset: 0x0053EE60
    /// void __thiscall Palette::Palette(Palette*,int)</code>
    /// </summary>
    /// <param name="total_num_colors">The desired count of color entries in the palette.</param>
    public void _ConstructorInternal(int total_num_colors) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, int, void>)0x0053EE60)(ref this, total_num_colors);

    /// <summary>Replaces a range of color entries in the palette with values from another database object identified by a given data ID.
    /// <code>Offset: 0x0053EEC0
    /// int __thiscall Palette::Modify(_DWORD*,int,unsigned int,int)</code>
    /// </summary>
    /// <param name="a2">Data identifier used to locate the source palette.</param>
    /// <param name="a3">Zero‑based starting index within this palette where replacement begins.</param>
    /// <param name="a4">Number of consecutive color entries to replace.</param>
    /// <returns>1 on success, 0 if the data ID is invalid, indices are out of bounds, or the source object cannot be found.</returns>
    public int Modify(int a2, uint a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, int, uint, int, int>)0x0053EEC0)(ref this, a2, a3, a4);

    /// <summary>Applies each Subpalette in a linked list to the current Palette, returning non‑zero if every modification succeeds.
    /// <code>Offset: 0x0053EF50
    /// int __thiscall Palette::Modify(Palette*,Subpalette*)</code>
    /// </summary>
    /// <param name="subs">First element of a linked list of Subpalette objects to apply. If null, the method exits immediately with success.</param>
    /// <returns>Non‑zero value when all subpalettes are applied successfully; zero if any application fails.</returns>
    public int Modify(ACBindings.Internal.Subpalette* subs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, ACBindings.Internal.Subpalette*, int>)0x0053EF50)(ref this, subs);

    /// <summary>Applies an array of Subpalette objects to this Palette, updating its color data.
    /// <code>Offset: 0x0053EF90
    /// int __thiscall Palette::Modify(Palette*,int,Subpalette*)</code>
    /// </summary>
    /// <param name="numSubs">The number of Subpalette entries in the array.</param>
    /// <param name="subs">Pointer to the first Subpalette in a contiguous array of subpalettes.</param>
    /// <returns>Non‑zero if all modifications succeeded or no subpalettes were processed; zero if any modification failed.</returns>
    public int Modify(int numSubs, ACBindings.Internal.Subpalette* subs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, int, ACBindings.Internal.Subpalette*, int>)0x0053EF90)(ref this, numSubs, subs);

    /// <summary>Creates a new Palette instance with a capacity of 2048 colors and increments its reference count when successful.
    /// <code>Offset: 0x0053EFE0
    /// Palette* __cdecl Palette::makeModifiedPalette()</code>
    /// </summary>
    /// <returns>A pointer to the newly created Palette, or nullptr if memory allocation fails.</returns>
    public static ACBindings.Internal.Palette* makeModifiedPalette() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Palette*>)0x0053EFE0)();

    /// <summary>Packs a palette’s load flag and part of its timestamp into a byte buffer, advancing the destination pointer when sufficient space is available.
    /// <code>Offset: 0x0053F010
    /// unsigned int __thiscall Palette::Pack(Palette*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location; updated past the written data if serialization succeeds.</param>
    /// <param name="size">Number of bytes remaining in the buffer; serialization proceeds only if this value is at least 4 + 4×m_bLoaded.</param>
    /// <returns>Byte count required for a complete serialization: 4 plus 4 times the palette’s m_bLoaded flag.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, void**, uint, uint>)0x0053F010)(ref this, addr, size);

    /// <summary>Restores a Palette object from a serialized buffer, initializing load state and timestamp data.
    /// <code>Offset: 0x0053F070
    /// int __thiscall Palette::UnPack(Palette*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the Palette instance being populated.</param>
    /// <param name="addr">Double pointer to the memory region containing packed data; advanced as data is consumed.</param>
    /// <param name="size">Size of the data block (unused in current implementation).</param>
    /// <returns>Always 1, indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, void**, uint, int>)0x0053F070)(ref this, addr, size);

    /// <summary>Creates or retrieves a palette object based on an identifier and optional subpalette data. If an existing palette is found it is returned; otherwise a new 2048‑color palette is allocated, initialized with the provided identifier, modified according to the subpalette (if any), and then returned.
    /// <code>Offset: 0x0053F120
    /// DBObj* __cdecl Palette::makeModifiedPalette(int,Subpalette*)</code>
    /// </summary>
    /// <param name="a1">The DataID of the desired palette.</param>
    /// <param name="subs">An optional subpalette providing modification data; if it represents a single 2048‑color subpalette without offset or next link, its identifier overrides a1.</param>
    /// <returns>Pointer to the resulting DBObj representing the palette, or null on failure or invalid input.</returns>
    public static ACBindings.Internal.DBObj* makeModifiedPalette(int a1, ACBindings.Internal.Subpalette* subs) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.Subpalette*, ACBindings.Internal.DBObj*>)0x0053F120)(a1, subs);
}

