namespace ACBindings.Internal;

public unsafe struct SkillTable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct SkillTable_vtbl
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
    public ACBindings.Internal.PackableHashTable__uint___SkillBase _skillBaseHash;

    // Generated Constructor
    public SkillTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0049B8B0
    /// SkillBase* __thiscall SkillTable::GetSkillBase(SkillTable*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.SkillBase* GetSkillBase(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillTable, uint, ACBindings.Internal.SkillBase*>)0x0049B8B0)(ref this, key);

    /// <summary>
    /// <code>Offset: 0x004E7010
    /// unsigned int __thiscall SkillTable::GetDBOType(SkillTable*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillTable, uint>)0x004E7010)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F2510
    /// int __thiscall SkillTable::InqSkillBase(SkillTable*,unsigned int,SkillBase*)</code>
    /// </summary>
    public int InqSkillBase(uint key, ACBindings.Internal.SkillBase* sbase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillTable, uint, ACBindings.Internal.SkillBase*, int>)0x004F2510)(ref this, key, sbase);

    /// <summary>
    /// <code>Offset: 0x0058B6E0
    /// DBObj* __cdecl SkillTable::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B6E0)();

    /// <summary>
    /// <code>Offset: 0x0059A8D0
    /// int __thiscall SkillTable::UnPack(SkillTable*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillTable, void**, uint, int>)0x0059A8D0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CC660
    /// void __thiscall SkillTable::GetSubDataIDs(SkillTable*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillTable, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005CC660)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x005CCAA0
    /// int __thiscall SkillTable::SkillTable(int,void**)</code>
    /// </summary>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillTable, void**, int>)0x005CCAA0)(ref this, a2);
}

