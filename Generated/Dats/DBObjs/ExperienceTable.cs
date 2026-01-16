namespace ACBindings.Internal;


/// <summary>Stores lookup tables mapping character attributes, skills, and overall level to required experience points, while providing pack/unpack functionality for persistence.</summary>
public unsafe struct ExperienceTable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct ExperienceTable_vtbl
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
    public uint _max_attribute_level;
    public uint* _attribute_table;
    public uint _max_attribute2nd_level;
    public uint* _attribute2nd_table;
    public uint _max_trained_skill_level;
    public uint* _trained_skill_table;
    public uint _max_specialized_skill_level;
    public uint* _specialized_skill_table;
    public uint _max_level;
    public ulong* _level_table;
    public uint* _credit_table;

    // Generated Constructor
    public ExperienceTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>Retrieves the database object type identifier for an ExperienceTable instance.
    /// <code>Offset: 0x004C0870
    /// unsigned int __thiscall ExperienceTable::GetDBOType(ExperienceTable*)</code>
    /// </summary>
    /// <returns>The 32‑bit unsigned integer representing the DBO type of this table.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint>)0x004C0870)(ref this);

    /// <summary>Allocates and constructs an ExperienceTable instance, returning its DBObj interface pointer.
    /// <code>Offset: 0x0058B750
    /// DBObj* __cdecl ExperienceTable::Allocator()</code>
    /// </summary>
    /// <returns>A DBObj* pointing to the newly created ExperienceTable, or nullptr if memory allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B750)();

    /// <summary>Retrieves the experience requirement for a specific trained skill level.
    /// <code>Offset: 0x005CAB90
    /// unsigned int __thiscall ExperienceTable::GetExperienceForTrainedSkillLevel(ExperienceTable*,unsigned int)</code>
    /// </summary>
    /// <param name="level">Desired trained skill level to query.</param>
    /// <returns>Experience points required for the specified level; returns –1 when the level is out of range or the table is unavailable.</returns>
    public uint GetExperienceForTrainedSkillLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CAB90)(ref this, level);

    /// <summary>Retrieves the experience needed to reach a given specialized skill level, returning –1 when the level is out of range.
    /// <code>Offset: 0x005CABB0
    /// unsigned int __thiscall ExperienceTable::GetExperienceForSpecializedSkillLevel(ExperienceTable*,unsigned int)</code>
    /// </summary>
    /// <param name="level">The desired specialized skill level.</param>
    /// <returns>The required experience points, or –1 if the specified level exceeds available data.</returns>
    public uint GetExperienceForSpecializedSkillLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CABB0)(ref this, level);

    /// <summary>Retrieves the experience needed to reach a specified attribute level from the internal table.
    /// <code>Offset: 0x005CABD0
    /// unsigned int __thiscall ExperienceTable::GetExperienceForAttributeLevel(ExperienceTable*,unsigned int)</code>
    /// </summary>
    /// <param name="level">Desired attribute level.</param>
    /// <returns>-1 if level exceeds maximum or attribute table is null; otherwise, the required experience value.</returns>
    public uint GetExperienceForAttributeLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CABD0)(ref this, level);

    /// <summary>Retrieves the required experience points for a second‑level attribute at the specified level.
    /// <code>Offset: 0x005CABF0
    /// unsigned int __thiscall ExperienceTable::GetExperienceForAttribute2ndLevel(ExperienceTable*,unsigned int)</code>
    /// </summary>
    /// <param name="level">The target attribute level to query.</param>
    /// <returns>The experience value from the internal table, or –1 if the level is out of bounds or no table exists.</returns>
    public uint GetExperienceForAttribute2ndLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CABF0)(ref this, level);

    /// <summary>Obtains the required experience for a given character level, using an internal lookup table. If the requested level exceeds the maximum defined in the table, it is clamped to that maximum. When the table has not been initialized, zero is returned.
    /// <code>Offset: 0x005CAC10
    /// unsigned __int64 __thiscall ExperienceTable::GetExperienceForLevel(ExperienceTable*,unsigned int)</code>
    /// </summary>
    /// <param name="level">The target level whose experience value should be retrieved.</param>
    /// <returns>The cumulative experience needed to reach the specified level (after clamping), or 0 if no level table exists.</returns>
    public ulong GetExperienceForLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, ulong>)0x005CAC10)(ref this, level);

    /// <summary>Retrieves the experience required to reach a specified level for a given experience type, returning 0xFFFFFFFF if the level exceeds defined limits or data is missing.
    /// <code>Offset: 0x005CAC40
    /// unsigned int __thiscall ExperienceTable::GetExperienceForLevel(ExperienceTable*,ExperienceType,unsigned int)</code>
    /// </summary>
    /// <param name="type">The category of experience (e.g., Attribute_ExperienceType, TrainedSkill_ExperienceType).</param>
    /// <param name="lvl">Target level for which experience is requested.</param>
    /// <returns>The experience value for the specified level and type, or 0xFFFFFFFF when the request is invalid.</returns>
    public uint GetExperienceForLevel(ACBindings.Internal.ExperienceType type, uint lvl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, ACBindings.Internal.ExperienceType, uint, uint>)0x005CAC40)(ref this, type, lvl);

    /// <summary>
    /// Determines the level corresponding to a specified amount of experience for a given experience type by consulting the appropriate experience table.
    /// 
    /// <code>Offset: 0x005CACB0
    /// unsigned int __thiscall ExperienceTable::GetLevelForExperience(ExperienceTable*,ExperienceType,unsigned int)</code>
    /// </summary>
    /// <param name="type">The category of experience (e.g., attribute, skill) used to select the relevant table.</param>
    /// <param name="pp">The total accumulated experience points to evaluate.</param>
    /// <returns>The level that matches or exceeds the provided experience value for the specified type.</returns>
    public uint GetLevelForExperience(ACBindings.Internal.ExperienceType type, uint pp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, ACBindings.Internal.ExperienceType, uint, uint>)0x005CACB0)(ref this, type, pp);

    /// <summary>Retrieves the trained skill level associated with a specified amount of experience points.
    /// <code>Offset: 0x005CADE0
    /// unsigned int __thiscall ExperienceTable::GetTrainedSkillLevelForExperience(ExperienceTable*,unsigned int)</code>
    /// </summary>
    /// <param name="pp">The total number of experience points to evaluate.</param>
    /// <returns>The trained skill level that corresponds to the supplied experience points.</returns>
    public uint GetTrainedSkillLevelForExperience(uint pp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CADE0)(ref this, pp);

    /// <summary>Computes the level of a specialized skill from a given experience point total.
    /// <code>Offset: 0x005CADF0
    /// unsigned int __thiscall ExperienceTable::GetSpecializedSkillLevelForExperience(ExperienceTable*,unsigned int)</code>
    /// </summary>
    /// <param name="pp">The accumulated experience points to evaluate for the skill level.</param>
    /// <returns>The resulting skill level as an unsigned integer.</returns>
    public uint GetSpecializedSkillLevelForExperience(uint pp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CADF0)(ref this, pp);

    /// <summary>Returns the attribute level associated with a specified amount of experience.
    /// <code>Offset: 0x005CAE00
    /// unsigned int __thiscall ExperienceTable::GetAttributeLevelForExperience(ExperienceTable*,unsigned int)</code>
    /// </summary>
    /// <param name="xp">The experience points used to determine the level.</param>
    /// <returns>The calculated attribute level based on internal experience tables.</returns>
    public uint GetAttributeLevelForExperience(uint xp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CAE00)(ref this, xp);

    /// <summary>Determines the secondary attribute level associated with a given amount of experience points.
    /// <code>Offset: 0x005CAE10
    /// unsigned int __thiscall ExperienceTable::GetAttribute2ndLevelForExperience(ExperienceTable*,unsigned int)</code>
    /// </summary>
    /// <param name="xp">The total experience points from which to calculate the attribute level.</param>
    /// <returns>The calculated second‑level attribute value derived from the experience table.</returns>
    public uint GetAttribute2ndLevelForExperience(uint xp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CAE10)(ref this, xp);

    /// <summary>Serializes an ExperienceTable instance into a contiguous memory block, writing its fields sequentially when the supplied buffer is large enough.
    /// <code>Offset: 0x005CAE20
    /// unsigned int __thiscall ExperienceTable::Pack(ExperienceTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer where packed data will be written.</param>
    /// <param name="size">Size of the available buffer in bytes; packing occurs only if this value meets or exceeds the required size.</param>
    /// <returns>The total number of bytes needed to represent the ExperienceTable data, regardless of whether packing was performed.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, void**, uint, uint>)0x005CAE20)(ref this, addr, size);

    /// <summary>Initializes an ExperienceTable instance by invoking its base DBObj constructor, setting up pack and experience tables to default values, and assigning the appropriate virtual function tables.
    /// <code>Offset: 0x005CAFF0
    /// int __thiscall ExperienceTable::ExperienceTable(int,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer to initialization data passed to the base DBObj constructor.</param>
    /// <returns>The constructed ExperienceTable object pointer.</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, void**, int>)0x005CAFF0)(ref this, a2);

    /// <summary>Deallocates all internal tables of the experience table and resets pointers to null.
    /// <code>Offset: 0x005CB050
    /// void __thiscall ExperienceTable::Clear(ExperienceTable*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, void>)0x005CB050)(ref this);

    /// <summary>Deserializes an ExperienceTable from a binary buffer, allocating internal arrays as needed and initializing base class fields.
    /// <code>Offset: 0x005CB0D0
    /// int __thiscall ExperienceTable::UnPack(ExperienceTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a pointer that references the start of serialized data; it will be advanced past each field read.</param>
    /// <param name="size">Number of bytes available in the buffer for deserialization. Must be at least 0x14 bytes.</param>
    /// <returns>Non‑zero on successful unpack, zero if size is insufficient.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, void**, uint, int>)0x005CB0D0)(ref this, addr, size);
}

