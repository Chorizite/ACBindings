namespace ACBindings.Internal;

public unsafe struct RestrictionDB : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct RestrictionDB_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RestrictionDB*, void> RestrictionDB_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RestrictionDB*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RestrictionDB*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RestrictionDB*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _bitmask;
    public uint _monarch_iid;
    public ACBindings.Internal.PHashTable__uint__uint _table;

    // Generated Constructor
    public RestrictionDB() {
        _ConstructorInternal();
    }
    public RestrictionDB(ACBindings.Internal.RestrictionDB* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005AF3C0
    /// void __thiscall RestrictionDB::SetOpenHouse(RestrictionDB*,int)</code>
    /// </summary>
    public void SetOpenHouse(int open) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RestrictionDB, int, void>)0x005AF3C0)(ref this, open);

    /// <summary>
    /// <code>Offset: 0x005AF3E0
    /// unsigned int __thiscall RestrictionDB::Pack(RestrictionDB*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RestrictionDB, void**, uint, uint>)0x005AF3E0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AF9A0
    /// int __thiscall RestrictionDB::IsAllowedIn(RestrictionDB*,unsigned int,unsigned int)</code>
    /// </summary>
    public int IsAllowedIn(uint guest, uint monarch) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RestrictionDB, uint, uint, int>)0x005AF9A0)(ref this, guest, monarch);

    /// <summary>
    /// <code>Offset: 0x005AFA40
    /// int __thiscall RestrictionDB::UnPack(RestrictionDB*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RestrictionDB, void**, uint, int>)0x005AFA40)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AFF60
    /// void __thiscall RestrictionDB::RestrictionDB(RestrictionDB*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RestrictionDB, void>)0x005AFF60)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AFFE0
    /// void __thiscall RestrictionDB::~RestrictionDB(RestrictionDB*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RestrictionDB, void>)0x005AFFE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B0060
    /// void __thiscall RestrictionDB::RestrictionDB(RestrictionDB*,const RestrictionDB*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.RestrictionDB* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RestrictionDB, ACBindings.Internal.RestrictionDB*, void>)0x005B0060)(ref this, rhs);
}

