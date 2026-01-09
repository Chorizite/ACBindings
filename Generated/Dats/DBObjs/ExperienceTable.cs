namespace ACBindings;

// ExperienceTable
public unsafe struct ExperienceTable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // ExperienceTable_vtbl
    public unsafe struct ExperienceTable_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBObj_dtor_18; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr InitLoad; // function pointer
        public System.IntPtr GetSubObjects; // function pointer
        public System.IntPtr ReleaseSubObjects; // function pointer
        public System.IntPtr NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr Destroy; // function pointer
        public System.IntPtr FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public System.IntPtr GetDBOType; // function pointer
        public System.IntPtr Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public System.IntPtr ReloadFromDisk; // function pointer

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
    // unsigned int __thiscall ExperienceTable::GetDBOType(ExperienceTable*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, uint>)0x004C0870)(ref this);
    // DBObj* __cdecl ExperienceTable::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x0058B750)();
    // unsigned int __thiscall ExperienceTable::GetExperienceForTrainedSkillLevel(ExperienceTable*,unsigned int)
    public uint GetExperienceForTrainedSkillLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, uint, uint>)0x005CAB90)(ref this, level);
    // unsigned int __thiscall ExperienceTable::GetExperienceForSpecializedSkillLevel(ExperienceTable*,unsigned int)
    public uint GetExperienceForSpecializedSkillLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, uint, uint>)0x005CABB0)(ref this, level);
    // unsigned int __thiscall ExperienceTable::GetExperienceForAttributeLevel(ExperienceTable*,unsigned int)
    public uint GetExperienceForAttributeLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, uint, uint>)0x005CABD0)(ref this, level);
    // unsigned int __thiscall ExperienceTable::GetExperienceForAttribute2ndLevel(ExperienceTable*,unsigned int)
    public uint GetExperienceForAttribute2ndLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, uint, uint>)0x005CABF0)(ref this, level);
    // unsigned __int64 __thiscall ExperienceTable::GetExperienceForLevel(ExperienceTable*,unsigned int)
    public ulong GetExperienceForLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, uint, ulong>)0x005CAC10)(ref this, level);
    // unsigned int __thiscall ExperienceTable::GetExperienceForLevel(ExperienceTable*,ExperienceType,unsigned int)
    public uint GetExperienceForLevel(ACBindings.ExperienceType type, uint lvl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, ACBindings.ExperienceType, uint, uint>)0x005CAC40)(ref this, type, lvl);
    // unsigned int __thiscall ExperienceTable::GetLevelForExperience(ExperienceTable*,ExperienceType,unsigned int)
    public uint GetLevelForExperience(ACBindings.ExperienceType type, uint pp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, ACBindings.ExperienceType, uint, uint>)0x005CACB0)(ref this, type, pp);
    // unsigned int __thiscall ExperienceTable::GetTrainedSkillLevelForExperience(ExperienceTable*,unsigned int)
    public uint GetTrainedSkillLevelForExperience(uint pp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, uint, uint>)0x005CADE0)(ref this, pp);
    // unsigned int __thiscall ExperienceTable::GetSpecializedSkillLevelForExperience(ExperienceTable*,unsigned int)
    public uint GetSpecializedSkillLevelForExperience(uint pp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, uint, uint>)0x005CADF0)(ref this, pp);
    // unsigned int __thiscall ExperienceTable::GetAttributeLevelForExperience(ExperienceTable*,unsigned int)
    public uint GetAttributeLevelForExperience(uint xp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, uint, uint>)0x005CAE00)(ref this, xp);
    // unsigned int __thiscall ExperienceTable::GetAttribute2ndLevelForExperience(ExperienceTable*,unsigned int)
    public uint GetAttribute2ndLevelForExperience(uint xp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, uint, uint>)0x005CAE10)(ref this, xp);
    // unsigned int __thiscall ExperienceTable::Pack(ExperienceTable*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, void**, uint, uint>)0x005CAE20)(ref this, addr, size);
    // int __thiscall ExperienceTable::ExperienceTable(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, void**, int>)0x005CAFF0)(ref this, a2);
    // void __thiscall ExperienceTable::Clear(ExperienceTable*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, void>)0x005CB050)(ref this);
    // int __thiscall ExperienceTable::UnPack(ExperienceTable*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExperienceTable, void**, uint, int>)0x005CB0D0)(ref this, addr, size);
}

