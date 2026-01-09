namespace ACBindings;

// RestrictionDB
public unsafe struct RestrictionDB : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // RestrictionDB_vtbl
    public unsafe struct RestrictionDB_vtbl
    {
        // Members
        public System.IntPtr RestrictionDB_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _bitmask;
    public uint _monarch_iid;
    public ACBindings.PHashTable__uint__uint _table;

    // Generated Constructor
    public RestrictionDB() {
        _ConstructorInternal();
    }
    public RestrictionDB(ACBindings.RestrictionDB* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall RestrictionDB::SetOpenHouse(RestrictionDB*,int)
    public void SetOpenHouse(int open) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RestrictionDB, int, void>)0x005AF3C0)(ref this, open);
    // unsigned int __thiscall RestrictionDB::Pack(RestrictionDB*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RestrictionDB, void**, uint, uint>)0x005AF3E0)(ref this, addr, size);
    // int __thiscall RestrictionDB::IsAllowedIn(RestrictionDB*,unsigned int,unsigned int)
    public int IsAllowedIn(uint guest, uint monarch) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RestrictionDB, uint, uint, int>)0x005AF9A0)(ref this, guest, monarch);
    // int __thiscall RestrictionDB::UnPack(RestrictionDB*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RestrictionDB, void**, uint, int>)0x005AFA40)(ref this, addr, size);
    // void __thiscall RestrictionDB::RestrictionDB(RestrictionDB*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RestrictionDB, void>)0x005AFF60)(ref this);
    // void __thiscall RestrictionDB::~RestrictionDB(RestrictionDB*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RestrictionDB, void>)0x005AFFE0)(ref this);
    // void __thiscall RestrictionDB::RestrictionDB(RestrictionDB*,const RestrictionDB*)
    public void _ConstructorInternal(ACBindings.RestrictionDB* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RestrictionDB, ACBindings.RestrictionDB*, void>)0x005B0060)(ref this, rhs);
}

