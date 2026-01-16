namespace ACBindings.Internal;


/// <summary>Extends the core MasterDBMap to provide specialized initialization of game database type definitions, mapping table names to identifiers and handling resource classification.</summary>
public unsafe struct gmMasterDBMap
{
    // Base Classes
    public ACBindings.Internal.MasterDBMap BaseClass_MasterDBMap; // ACBindings.Internal.MasterDBMap

    // Child Types
    public unsafe struct gmMasterDBMap_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMasterDBMap*, byte> InitDBTypeDef_Internal; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr DivineType_Internal;
        public System.IntPtr InqTypeByString_Internal;
        public System.IntPtr InqStringByType_Internal;

        // Methods
    }

    // Methods

    /// <summary>Determines a divine type code for a given identifier by evaluating it against predefined ranges and mapping to constant values.
    /// <code>Offset: 0x005D6A90
    /// int __stdcall gmMasterDBMap::DivineType_Internal(unsigned int)</code>
    /// </summary>
    /// <param name="a1">The unsigned integer identifier whose divine type is to be resolved.</param>
    /// <returns>An integer representing the mapped divine type; if no specific range matches, the base class implementation's result is returned.</returns>
    public static int DivineType_Internal(uint a1) => ((delegate* unmanaged[Stdcall]<uint, int>)0x005D6A90)(a1);

    /// <summary>Determines a resource’s divine type by examining its file extension, returning specific constants for known extensions or delegating to the base class if none match.
    /// <code>Offset: 0x005D6BE0
    /// int __thiscall gmMasterDBMap::DivineType_Internal(char*,int)</code>
    /// </summary>
    /// <param name="a2">Identifier of the resource whose filename extension is used to determine the type.</param>
    /// <returns>Integer constant indicating the resource type; returns predefined values for recognized extensions (e.g., .wa2, .wts, .xpt) or the value returned by MasterDBMap::DivineType_Internal if no match is found.</returns>
    public int DivineType_Internal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMasterDBMap, int, int>)0x005D6BE0)(ref this, a2);

    /// <summary>Mapped a database name string to its numeric type identifier, writing the result through the supplied output pointer before delegating to the base class.
    /// <code>Offset: 0x005D71D0
    /// char __thiscall gmMasterDBMap::InqTypeByString_Internal(char*,char**,char*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the input string containing the database name (case‑insensitive).</param>
    /// <param name="String2">Pointer to an integer where the resulting type code will be stored.</param>
    /// <returns>Return value from the base class's InqTypeByString_Internal method, indicating success or failure.</returns>
    public sbyte InqTypeByString_Internal(sbyte** a2, sbyte* String2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMasterDBMap, sbyte**, sbyte*, sbyte>)0x005D71D0)(ref this, a2, String2);

    /// <summary>Retrieves the string name associated with a database type identifier and stores it in the supplied pointer, handling predefined types or delegating to the base implementation.
    /// <code>Offset: 0x005D7700
    /// char __stdcall gmMasterDBMap::InqStringByType_Internal(int,void**)</code>
    /// </summary>
    /// <param name="a1">Integer code representing a specific database table type.</param>
    /// <param name="a2">Reference to a void* that will receive the resolved string pointer.</param>
    /// <returns>Character status returned by the underlying MasterDBMap implementation indicating success or failure.</returns>
    public static sbyte InqStringByType_Internal(int a1, void** a2) => ((delegate* unmanaged[Stdcall]<int, void**, sbyte>)0x005D7700)(a1, a2);

    /// <summary>Initializes the master database map with a set of predefined type definitions, registering multiple DB types in the internal cache for use by the application.
    /// <code>Offset: 0x005D77E0
    /// bool __thiscall gmMasterDBMap::InitDBTypeDef_Internal(gmMasterDBMap*)</code>
    /// </summary>
    /// <returns>True if all database type definitions were registered successfully; otherwise false.</returns>
    public byte InitDBTypeDef_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMasterDBMap, byte>)0x005D77E0)(ref this);
}

