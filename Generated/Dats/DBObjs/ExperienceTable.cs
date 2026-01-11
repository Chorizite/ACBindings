namespace ACBindings.Internal;

public unsafe struct ExperienceTable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct ExperienceTable_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004C0870
    /// unsigned int __thiscall ExperienceTable::GetDBOType(ExperienceTable*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint>)0x004C0870)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058B750
    /// DBObj* __cdecl ExperienceTable::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B750)();

    /// <summary>
    /// <code>Offset: 0x005CAB90
    /// unsigned int __thiscall ExperienceTable::GetExperienceForTrainedSkillLevel(ExperienceTable*,unsigned int)</code>
    /// </summary>
    public uint GetExperienceForTrainedSkillLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CAB90)(ref this, level);

    /// <summary>
    /// <code>Offset: 0x005CABB0
    /// unsigned int __thiscall ExperienceTable::GetExperienceForSpecializedSkillLevel(ExperienceTable*,unsigned int)</code>
    /// </summary>
    public uint GetExperienceForSpecializedSkillLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CABB0)(ref this, level);

    /// <summary>
    /// <code>Offset: 0x005CABD0
    /// unsigned int __thiscall ExperienceTable::GetExperienceForAttributeLevel(ExperienceTable*,unsigned int)</code>
    /// </summary>
    public uint GetExperienceForAttributeLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CABD0)(ref this, level);

    /// <summary>
    /// <code>Offset: 0x005CABF0
    /// unsigned int __thiscall ExperienceTable::GetExperienceForAttribute2ndLevel(ExperienceTable*,unsigned int)</code>
    /// </summary>
    public uint GetExperienceForAttribute2ndLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CABF0)(ref this, level);

    /// <summary>
    /// <code>Offset: 0x005CAC10
    /// unsigned __int64 __thiscall ExperienceTable::GetExperienceForLevel(ExperienceTable*,unsigned int)</code>
    /// </summary>
    public ulong GetExperienceForLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, ulong>)0x005CAC10)(ref this, level);

    /// <summary>
    /// <code>Offset: 0x005CAC40
    /// unsigned int __thiscall ExperienceTable::GetExperienceForLevel(ExperienceTable*,ExperienceType,unsigned int)</code>
    /// </summary>
    public uint GetExperienceForLevel(ACBindings.Internal.ExperienceType type, uint lvl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, ACBindings.Internal.ExperienceType, uint, uint>)0x005CAC40)(ref this, type, lvl);

    /// <summary>
    /// <code>Offset: 0x005CACB0
    /// unsigned int __thiscall ExperienceTable::GetLevelForExperience(ExperienceTable*,ExperienceType,unsigned int)</code>
    /// </summary>
    public uint GetLevelForExperience(ACBindings.Internal.ExperienceType type, uint pp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, ACBindings.Internal.ExperienceType, uint, uint>)0x005CACB0)(ref this, type, pp);

    /// <summary>
    /// <code>Offset: 0x005CADE0
    /// unsigned int __thiscall ExperienceTable::GetTrainedSkillLevelForExperience(ExperienceTable*,unsigned int)</code>
    /// </summary>
    public uint GetTrainedSkillLevelForExperience(uint pp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CADE0)(ref this, pp);

    /// <summary>
    /// <code>Offset: 0x005CADF0
    /// unsigned int __thiscall ExperienceTable::GetSpecializedSkillLevelForExperience(ExperienceTable*,unsigned int)</code>
    /// </summary>
    public uint GetSpecializedSkillLevelForExperience(uint pp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CADF0)(ref this, pp);

    /// <summary>
    /// <code>Offset: 0x005CAE00
    /// unsigned int __thiscall ExperienceTable::GetAttributeLevelForExperience(ExperienceTable*,unsigned int)</code>
    /// </summary>
    public uint GetAttributeLevelForExperience(uint xp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CAE00)(ref this, xp);

    /// <summary>
    /// <code>Offset: 0x005CAE10
    /// unsigned int __thiscall ExperienceTable::GetAttribute2ndLevelForExperience(ExperienceTable*,unsigned int)</code>
    /// </summary>
    public uint GetAttribute2ndLevelForExperience(uint xp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, uint, uint>)0x005CAE10)(ref this, xp);

    /// <summary>
    /// <code>Offset: 0x005CAE20
    /// unsigned int __thiscall ExperienceTable::Pack(ExperienceTable*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, void**, uint, uint>)0x005CAE20)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CAFF0
    /// int __thiscall ExperienceTable::ExperienceTable(int,void**)</code>
    /// </summary>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, void**, int>)0x005CAFF0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005CB050
    /// void __thiscall ExperienceTable::Clear(ExperienceTable*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, void>)0x005CB050)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CB0D0
    /// int __thiscall ExperienceTable::UnPack(ExperienceTable*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExperienceTable, void**, uint, int>)0x005CB0D0)(ref this, addr, size);
}

