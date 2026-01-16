namespace ACBindings.Internal;


/// <summary>Central manager for the application's string resources, coordinating reference counting and insertion into a global table.</summary>
public unsafe struct MasterStringTableGen
{
    // Statics
    public static ACBindings.Internal.StringTableGen** s_pStringTableGen = (ACBindings.Internal.StringTableGen**)0x00837F58;

    // Methods

    /// <summary>Adds five string objects to the master string table, managing reference counts for each before and after the operation. The function delegates the actual insertion to an internal method of the global string table generator instance. Returns a non‑zero value when the strings were successfully added.
    /// <code>Offset: 0x00430BC0
    /// char __cdecl MasterStringTableGen::AddString(int,int,int,int,int)</code>
    /// </summary>
    /// <param name="a1">First string object to add.</param>
    /// <param name="a2">Second string object to add.</param>
    /// <param name="a3">Third string object to add.</param>
    /// <param name="a4">Fourth string object to add.</param>
    /// <param name="a5">Fifth string object to add.</param>
    /// <returns>Non‑zero if the strings were added successfully; zero otherwise.</returns>
    public static sbyte AddString(int a1, int a2, int a3, int a4, int a5) => ((delegate* unmanaged[Cdecl]<int, int, int, int, int, sbyte>)0x00430BC0)(a1, a2, a3, a4, a5);
}

