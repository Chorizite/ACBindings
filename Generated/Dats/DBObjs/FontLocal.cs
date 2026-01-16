namespace ACBindings.Internal;


/// <summary>Encapsulates a <c>Font</c> instance to support localized font definitions within the database system. Serves as a wrapper for local fonts, enabling distinction between global and local resources during lookup.</summary>
public unsafe struct FontLocal
{
    // Base Classes
    public ACBindings.Internal.Font BaseClass_Font; // ACBindings.Internal.Font

    // Child Types
    public unsafe struct FontLocal_vtbl
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

    // Methods

    /// <summary>Retrieves a database object representing either a global or local font based on the supplied identifier.
    /// <code>Offset: 0x0044B680
    /// DBObj* __cdecl FontLocal::GetGlobalOrLocalFont(int)</code>
    /// </summary>
    /// <param name="a1">The font identifier used to determine which variant (global or local) is retrieved.</param>
    /// <returns>A pointer to the corresponding DBObj, or nullptr if no matching object exists.</returns>
    public static ACBindings.Internal.DBObj* GetGlobalOrLocalFont(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.DBObj*>)0x0044B680)(a1);

    /// <summary>Retrieves the database object type identifier for a FontLocal instance.
    /// <code>Offset: 0x004F8300
    /// unsigned int __thiscall FontLocal::GetDBOType(FontLocal*)</code>
    /// </summary>
    /// <returns>The DBO type value, which is 47.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FontLocal, uint>)0x004F8300)(ref this);

    /// <summary>Allocates a new font object, initializes its core fields and file name buffers, then returns a pointer to its underlying DBObj base class.
    /// <code>Offset: 0x004F8800
    /// DBObj* __thiscall FontLocal::Allocate(FontLocal*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated object's DBObj base; returns null if allocation fails.</returns>
    public ACBindings.Internal.DBObj* Allocate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FontLocal, ACBindings.Internal.DBObj*>)0x004F8800)(ref this);
}

