namespace ACBindings.Internal;


/// <summary>Stores character generation data, including start areas and heritage groups, and provides lookup, serialization, and formatting utilities for the game world.</summary>
public unsafe struct ACCharGenData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CharGenData BaseClass_CharGenData; // ACBindings.Internal.CharGenData

    // Child Types

    /// <summary>Provides virtual function table for character generation data objects, exposing COM-style interface operations such as reference counting, serialization, and sub‑object management within the game’s database system.</summary>
    public unsafe struct ACCharGenData_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharGenData*, ACBindings.Internal.CharGenResult*, ACBindings.Internal.Position*, int> GetStartingPosition; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___ACCharGenStartArea mStartAreaList;
    public ACBindings.Internal.HashTable__uint___HeritageGroup_CG mHeritageGroupList;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// Creates a new ACCharGenData object, initializing its base class and internal tables, returning a pointer to the constructed instance or null if allocation fails.
    /// 
    /// <code>Offset: 0x0058B690
    /// DBObj* __cdecl ACCharGenData::Allocator()</code>
    /// </summary>
    /// <returns>
    /// A pointer to the newly allocated ACCharGenData cast as DBObj; returns nullptr when memory allocation fails.
    /// </returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B690)();

    /// <summary>Formats a character name in place: removes trailing spaces, filters to letters, apostrophes and hyphens, normalizes separators, and applies capitalization rules for common prefixes (De, Mac, Fitz, etc.) and single‑letter middle initials.
    /// <code>Offset: 0x005BE6A0
    /// void __cdecl ACCharGenData::FormatName(char*)</code>
    /// </summary>
    /// <param name="name">Null‑terminated string containing the original name; it is modified directly.</param>
    public static void FormatName(sbyte* name) => ((delegate* unmanaged[Cdecl]<sbyte*, void>)0x005BE6A0)(name);

    /// <summary>Aggregates sub-data identifiers from all heritage group objects into the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x005C1E80
    /// void __thiscall ACCharGenData::GetSubDataIDs(ACCharGenData*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array to receive the collected data identifiers.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005C1E80)(ref this, id_array);

    /// <summary>
    /// Determines the starting position for a character based on the provided generation result. If the result indicates a special case, assigns a fixed location; otherwise selects a random start area from the internal list and copies its coordinates into the output structure.
    /// 
    /// <code>Offset: 0x005C2360
    /// int __thiscall ACCharGenData::GetStartingPosition(ACCharGenData*,const CharGenResult*,Position*)</code>
    /// </summary>
    /// <param name="cgr">Character generation result used to choose the start area.</param>
    /// <param name="pos">Output position structure populated with object cell ID and frame data.</param>
    /// <returns>Non‑zero if a valid starting position was determined, zero otherwise.</returns>
    public int GetStartingPosition(ACBindings.Internal.CharGenResult* cgr, ACBindings.Internal.Position* pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, ACBindings.Internal.CharGenResult*, ACBindings.Internal.Position*, int>)0x005C2360)(ref this, cgr, pos);

    /// <summary>Retrieves a heritage group by its identifier, copying it into the supplied result object.
    /// <code>Offset: 0x005C3380
    /// const HeritageGroup_CG* __thiscall ACCharGenData::GetHG(ACCharGenData*,const HeritageGroup_CG*,unsigned int)</code>
    /// </summary>
    /// <param name="this">The character generation data instance containing the heritage groups.</param>
    /// <param name="result">Output parameter where the found heritage group is stored; if no matching entry exists, receives a default‑constructed instance.</param>
    /// <param name="heritage">Identifier of the desired heritage group.</param>
    /// <returns>The result pointer, pointing to the populated HeritageGroup_CG object.</returns>
    public ACBindings.Internal.HeritageGroup_CG* GetHG(ACBindings.Internal.HeritageGroup_CG* result, uint heritage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, ACBindings.Internal.HeritageGroup_CG*, uint, ACBindings.Internal.HeritageGroup_CG*>)0x005C3380)(ref this, result, heritage);

    /// <summary>
    /// Calculates the training cost for a specified skill based on the character’s heritage and gender.
    /// If the skill is not present in the heritage group, it falls back to a global database lookup; returns -1 when unavailable.
    /// 
    /// <code>Offset: 0x005C36B0
    /// int __thiscall ACCharGenData::GetSkillTrainedCost(ACCharGenData*,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="skillID">Identifier of the skill whose cost is requested.</param>
    /// <param name="heritage">Numeric code representing the character's heritage group.</param>
    /// <param name="gender">Code indicating the character's gender (used when retrieving skill cost).</param>
    /// <returns>Integer representing the normal training cost for the skill, or -1 if the skill cannot be found in either the heritage group's list or the global database.</returns>
    public int GetSkillTrainedCost(int skillID, uint heritage, uint gender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, int, uint, uint, int>)0x005C36B0)(ref this, skillID, heritage, gender);

    /// <summary>Retrieves the specialized cost of a specified skill for a character’s heritage and gender. If the skill is not present in the heritage‑specific list, returns –1.
    /// <code>Offset: 0x005C37B0
    /// int __thiscall ACCharGenData::GetSkillSpecializedCost(ACCharGenData*,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="skillID">Identifier of the skill whose cost is requested.</param>
    /// <param name="heritage">Index or ID representing the character’s heritage group.</param>
    /// <param name="gender">Gender flag used to select the appropriate specialization data.</param>
    /// <returns>Primary cost value for the skill, or –1 if the skill cannot be found in the selected heritage/gender list.</returns>
    public int GetSkillSpecializedCost(int skillID, uint heritage, uint gender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, int, uint, uint, int>)0x005C37B0)(ref this, skillID, heritage, gender);

    /// <summary>Creates character base appearance data from ACCharGenResult and populates CharAppearanceData and ObjDesc with palettes, textures, subpalettes, and animation changes.
    /// <code>Offset: 0x005C38B0
    /// int __thiscall ACCharGenData::GenerateBaseAppearanceData(ACCharGenData*,const ACCharGenResult*,CharAppearanceData*,ObjDesc*)</code>
    /// </summary>
    /// <param name="cgr">Character generation result containing selected traits such as heritage group, gender, hair style, eye strip, etc.</param>
    /// <param name="cad">Output structure receiving base palette IDs, head object ID, eyes/nose/mouth texture IDs, and other appearance identifiers.</param>
    /// <param name="objDesc">Object descriptor that receives subpalettes, texture map changes, and animation part changes derived from the selected traits.</param>
    /// <returns>Non‑zero if all required data was successfully retrieved and applied; zero otherwise.</returns>
    public int GenerateBaseAppearanceData(ACBindings.Internal.ACCharGenResult* cgr, ACBindings.Internal.CharAppearanceData* cad, ACBindings.Internal.ObjDesc* objDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, ACBindings.Internal.ACCharGenResult*, ACBindings.Internal.CharAppearanceData*, ACBindings.Internal.ObjDesc*, int>)0x005C38B0)(ref this, cgr, cad, objDesc);

    /// <summary>Locates a hairstyle matching the supplied part ID and bald flag for the specified heritage group and gender, returning its index in that list.
    /// <code>Offset: 0x005C3DB0
    /// unsigned int __thiscall ACCharGenData::GetHairIndexFromID(ACCharGenData*,unsigned int,unsigned int,int,char)</code>
    /// </summary>
    /// <param name="heritage">Identifier of the character’s heritage group.</param>
    /// <param name="gender">Gender selection used to choose the appropriate hairstyle set.</param>
    /// <param name="a4">AnimPartChange ID to match against hairstyles; if this equals INVALID_DID_375.baseclass_0.id, the function returns 0 immediately.</param>
    /// <param name="a5">Desired bald state (typically 1 for bald, 0 otherwise).</param>
    /// <returns>Zero‑based index of the matching hairstyle within its list. Returns 0 when no match is found or a4 is invalid; note that a valid match at position zero also yields 0.</returns>
    public uint GetHairIndexFromID(uint heritage, uint gender, int a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, uint, uint, int, sbyte, uint>)0x005C3DB0)(ref this, heritage, gender, a4, a5);

    /// <summary>
    /// Finds the zero‑based index of an eye strip whose texture map change matches a given texture ID within the specified heritage group and gender, optionally considering bald or normal variants.
    /// 
    /// <code>Offset: 0x005C3EE0
    /// unsigned int __thiscall ACCharGenData::GetEyeStripIndexFromID(ACCharGenData*,unsigned int,unsigned int,int,char,char)</code>
    /// </summary>
    /// <param name="heritage">Identifier of the heritage group to search.</param>
    /// <param name="gender">Gender specification for which to locate the eye strip.</param>
    /// <param name="a4">Texture ID to match against eye strip texture map changes.</param>
    /// <param name="a5">Flag indicating whether to use updated texture mapping when searching.</param>
    /// <param name="a6">Flag selecting between bald (true) and normal (false) eye strip variants.</param>
    /// <returns>Zero‑based index of the matching eye strip; returns 0 if no match is found or the list is empty.</returns>
    public uint GetEyeStripIndexFromID(uint heritage, uint gender, int a4, sbyte a5, sbyte a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, uint, uint, int, sbyte, sbyte, uint>)0x005C3EE0)(ref this, heritage, gender, a4, a5, a6);

    /// <summary>Finds the index of a nose strip within a character's heritage and gender-specific list that matches a specified texture map change ID, returning zero if the ID is invalid or no match exists.
    /// <code>Offset: 0x005C4050
    /// unsigned int __thiscall ACCharGenData::GetNoseStripIndexFromID(ACCharGenData*,unsigned int,unsigned int,int,char)</code>
    /// </summary>
    /// <param name="heritage">Identifier for the character's heritage group.</param>
    /// <param name="gender">Identifier indicating male, female, or other gender categories.</param>
    /// <param name="a4">Texture map change identifier to locate within the nose strip list.</param>
    /// <param name="a5">Flag determining whether to use new texture IDs during lookup.</param>
    /// <returns>Zero-based index of the matching nose strip; zero if no match is found or the input ID is invalid.</returns>
    public uint GetNoseStripIndexFromID(uint heritage, uint gender, int a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, uint, uint, int, sbyte, uint>)0x005C4050)(ref this, heritage, gender, a4, a5);

    /// <summary>Locates the index of a mouth strip matching a given texture map change ID within the specified heritage and gender data.
    /// <code>Offset: 0x005C4170
    /// unsigned int __thiscall ACCharGenData::GetMouthStripIndexFromID(ACCharGenData*,unsigned int,unsigned int,int,char)</code>
    /// </summary>
    /// <param name="heritage">Identifier for the character's heritage group.</param>
    /// <param name="gender">Gender identifier used to select the appropriate set of mouth strips.</param>
    /// <param name="a4">Texture map change ID to search for in the mouth strip list.</param>
    /// <param name="a5">Flag indicating whether to compare against the new texture ID (non‑zero) or the default texture ID (zero).</param>
    /// <returns>Zero if the ID is invalid or not found; otherwise, the zero‑based index of the matching mouth strip in its list.</returns>
    public uint GetMouthStripIndexFromID(uint heritage, uint gender, int a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, uint, uint, int, sbyte, uint>)0x005C4170)(ref this, heritage, gender, a4, a5);

    /// <summary>Retrieves the relative shade index for the specified skin palette ID based on heritage and gender, storing the result as a double between 0.0 and 1.0.
    /// <code>Offset: 0x005C4290
    /// void __thiscall ACCharGenData::GetSkinShadeFromID(ACCharGenData*,unsigned int,unsigned int,int,double*)</code>
    /// </summary>
    /// <param name="heritage">Identifier of the heritage group.</param>
    /// <param name="gender">Gender identifier used to select the correct palette set.</param>
    /// <param name="a4">Skin palette ID whose shade position is sought.</param>
    /// <param name="a5">Output pointer that receives the computed fraction; zero if the palette ID cannot be located.</param>
    public void GetSkinShadeFromID(uint heritage, uint gender, int a4, double* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, uint, uint, int, double*, void>)0x005C4290)(ref this, heritage, gender, a4, a5);

    /// <summary>
    /// Retrieves the hair color index and its relative selection ratio for a character based on heritage, gender and specified hair color ID.
    /// 
    /// <code>Offset: 0x005C4380
    /// void __thiscall ACCharGenData::GetHairColorFromID(ACCharGenData*,unsigned int,unsigned int,int,unsigned int*,_DWORD*)</code>
    /// </summary>
    /// <param name="heritage">Identifier of the heritage group used to look up the appropriate hair color list.</param>
    /// <param name="gender">Gender value applied when selecting a hair data set within the heritage group.</param>
    /// <param name="a4">Hair color data ID to locate in the heritage group's list; if it equals INVALID_DID_375.baseclass_0.id, no color is selected and outputs are cleared.</param>
    /// <param name="a5">Output pointer that receives the zero‑based index of the matching hair color entry in the heritage group’s hair color list (or 0 when not found).</param>
    /// <param name="a6">Output pointer to memory where a double representing the ratio of the chosen palette within its set is written; 0 if no match is found.</param>
    public void GetHairColorFromID(uint heritage, uint gender, int a4, uint* a5, int* a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, uint, uint, int, uint*, int*, void>)0x005C4380)(ref this, heritage, gender, a4, a5, a6);

    /// <summary>Determines the index of an eye color within a heritage‑gender specific list based on its ID. If the ID is valid and present, writes the matching list index into the supplied output pointer; otherwise stores zero.
    /// <code>Offset: 0x005C44E0
    /// void __thiscall ACCharGenData::GetEyeColorFromID(ACCharGenData*,unsigned int,unsigned int,int,unsigned int*)</code>
    /// </summary>
    /// <param name="heritage">The identifier for the heritage group to query.</param>
    /// <param name="gender">The gender identifier used to select the appropriate eye color list.</param>
    /// <param name="a4">The eye‑color ID that is searched for in the selected list.</param>
    /// <param name="a5">Pointer to an unsigned integer that receives the zero‑based index of the matching eye color; set to zero if not found or invalid.</param>
    public void GetEyeColorFromID(uint heritage, uint gender, int a4, uint* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, uint, uint, int, uint*, void>)0x005C44E0)(ref this, heritage, gender, a4, a5);

    /// <summary>Destroys an ACCharGenData instance, freeing memory for the start area list and heritage group hash table before delegating to base CharGenData and DBObj destructors.
    /// <code>Offset: 0x005C4620
    /// void __thiscall ACCharGenData::~ACCharGenData(ACCharGenData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, void>)0x005C4620)(ref this);

    /// <summary>Serializes ACCharGenData to or from an Archive. Handles base class data, data identifier, start area list, and heritage groups, releasing existing content when loading.
    /// <code>Offset: 0x005C46B0
    /// void __thiscall ACCharGenData::Serialize(ACCharGenData*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive controlling serialization; its flags determine whether the function writes current state or reads into the object.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, ACBindings.Internal.Archive*, void>)0x005C46B0)(ref this, io_archive);
}

