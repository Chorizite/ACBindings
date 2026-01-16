namespace ACBindings.Internal;


/// <summary>A collection of palette identifiers used by the rendering engine, storing the count of palettes and a pointer to their data. Inherits serialization behavior from SerializeUsingPackDBObj.</summary>
public unsafe struct PalSet
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct PalSet_vtbl
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
    public uint num_pals;
    public System.IntPtr palette_IDs;

    // Generated Constructor
    public PalSet(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>Retrieves the database object associated with the specified palette index in this set.
    /// <code>Offset: 0x0047D050
    /// DBObj* __cdecl PalSet::Get(int)</code>
    /// </summary>
    /// <param name="a1">The zero‑based index of the desired palette within the set.</param>
    /// <returns>A pointer to the corresponding DBObj, or nullptr if the index is out of range or the object cannot be retrieved.</returns>
    public static ACBindings.Internal.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.DBObj*>)0x0047D050)(a1);

    /// <summary>Allocates a new PalSet instance and returns a pointer to its DBObj base object.
    /// <code>Offset: 0x004F7D60
    /// DBObj* __cdecl PalSet::Allocator()</code>
    /// </summary>
    /// <returns>A DBObj pointer representing the newly created PalSet; returns null when memory allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7D60)();

    /// <summary>Constructs a PalSet instance by initializing its base DBObj and PackObj components with the supplied data.
    /// <code>Offset: 0x005AD5E0
    /// int __thiscall PalSet::PalSet(int,void**)</code>
    /// </summary>
    /// <param name="this">Pointer to the PalSet object being created.</param>
    /// <param name="a2">Initialization data forwarded to the DBObj constructor.</param>
    /// <returns>The pointer to the newly constructed PalSet object.</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalSet, void**, int>)0x005AD5E0)(ref this, a2);

    /// <summary>Retrieves the palette identifier corresponding to a normalized position within the set and writes it into the supplied output parameter.
    /// <code>Offset: 0x005AD620
    /// unsigned int* __thiscall PalSet::GetPaletteID(_DWORD*,unsigned int*,double)</code>
    /// </summary>
    /// <param name="a2">Pointer to an unsigned integer where the selected palette ID will be stored.</param>
    /// <param name="a3">Normalized value (0.0–1.0) indicating relative position among available palettes; values outside this range result in an INVALID ID being written.</param>
    /// <returns>Same pointer passed as a2, now holding the retrieved palette ID or an INVALID identifier when input is invalid or out of bounds.</returns>
    public uint* GetPaletteID(uint* a2, double a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalSet, uint*, double, uint*>)0x005AD620)(ref this, a2, a3);

    /// <summary>Retrieves the palette ID at the specified index, storing it into the supplied output pointer. If the index is out of bounds, writes an invalid identifier instead.
    /// <code>Offset: 0x005AD6A0
    /// unsigned int* __thiscall PalSet::GetPaletteID_Integral(_DWORD*,unsigned int*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to receive the palette ID.</param>
    /// <param name="a3">Index of the desired palette entry.</param>
    /// <returns>Returns the same pointer provided in a2 for chaining convenience.</returns>
    public uint* GetPaletteID_Integral(uint* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalSet, uint*, int, uint*>)0x005AD6A0)(ref this, a2, a3);

    /// <summary>Serializes a PalSet into a contiguous memory block, writing the palette count followed by each palette identifier.
    /// <code>Offset: 0x005AD6E0
    /// unsigned int __thiscall PalSet::Pack(PalSet*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the output buffer; updated to point after the written data.</param>
    /// <param name="size">Number of bytes available at the provided buffer location. If this is less than the required size, no data is written.</param>
    /// <returns>The total number of bytes that would be written (the size needed for serialization). If the supplied buffer is large enough, this value equals the number of bytes actually written.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalSet, void**, uint, uint>)0x005AD6E0)(ref this, addr, size);

    /// <summary>Deserializes a PalSet from a binary buffer, updating the object's state and allocating palette entries as required.
    /// <code>Offset: 0x005AD730
    /// int __thiscall PalSet::UnPack(PalSet*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the buffer; advanced during unpacking. If insufficient data, it is reset.</param>
    /// <param name="size">Number of bytes remaining in the buffer at the start of the call.</param>
    /// <returns>1 if the buffer contained enough data and was fully consumed; 0 otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalSet, void**, uint, int>)0x005AD730)(ref this, addr, size);
}

