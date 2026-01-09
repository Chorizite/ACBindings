namespace ACBindings;

// SkillTable
public unsafe struct SkillTable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // SkillTable_vtbl
    public unsafe struct SkillTable_vtbl
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
    public ACBindings.PackableHashTable__uint__SkillBase _skillBaseHash;

    // Generated Constructor
    public SkillTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods
    // SkillBase* __thiscall SkillTable::GetSkillBase(SkillTable*,unsigned int)
    public ACBindings.SkillBase* GetSkillBase(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillTable, uint, ACBindings.SkillBase*>)0x0049B8B0)(ref this, key);
    // unsigned int __thiscall SkillTable::GetDBOType(SkillTable*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillTable, uint>)0x004E7010)(ref this);
    // int __thiscall SkillTable::InqSkillBase(SkillTable*,unsigned int,SkillBase*)
    public int InqSkillBase(uint key, ACBindings.SkillBase* sbase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillTable, uint, ACBindings.SkillBase*, int>)0x004F2510)(ref this, key, sbase);
    // DBObj* __cdecl SkillTable::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x0058B6E0)();
    // int __thiscall SkillTable::UnPack(SkillTable*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillTable, void**, uint, int>)0x0059A8D0)(ref this, addr, size);
    // void __thiscall SkillTable::GetSubDataIDs(SkillTable*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillTable, ACBindings.QualifiedDataIDArray*, void>)0x005CC660)(ref this, id_array);
    // int __thiscall SkillTable::SkillTable(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillTable, void**, int>)0x005CCAA0)(ref this, a2);
}

