namespace ACBindings;

// SquelchDB
public unsafe struct SquelchDB : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // SquelchDB_vtbl
    public unsafe struct SquelchDB_vtbl
    {
        // Members
        public System.IntPtr SquelchDB_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PackableHashTable__AC1Legacy_PStringBase__sbyte__uint _account_hash;
    public ACBindings.PackableHashTable__uint__SquelchInfo _character_hash;
    public ACBindings.SquelchInfo _global_squelch_info;

    // Generated Constructor
    public SquelchDB() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall SquelchDB::Pack(SquelchDB*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchDB, void**, uint, uint>)0x006B1B70)(ref this, addr, size);
    // int __thiscall SquelchDB::IsPlayerSquelched(SquelchDB*,unsigned int,unsigned int)
    public int IsPlayerSquelched(uint player_iid, uint msg_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchDB, uint, uint, int>)0x006B1C00)(ref this, player_iid, msg_type);
    // BOOL __thiscall SquelchDB::IsSquelched(SquelchDB*,unsigned int,int*,unsigned int)
    public byte IsSquelched(uint player_iid, int* a3, uint msg_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchDB, uint, int*, uint, byte>)0x006B2360)(ref this, player_iid, a3, msg_type);
    // void __thiscall SquelchDB::Clear(SquelchDB*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchDB, void>)0x006B27B0)(ref this);
    // int __thiscall SquelchDB::UnPack(SquelchDB*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchDB, void**, uint, int>)0x006B27D0)(ref this, addr, size);
    // void __thiscall SquelchDB::SquelchDB(SquelchDB*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchDB, void>)0x006B2A90)(ref this);
    // void __thiscall SquelchDB::~SquelchDB(SquelchDB*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchDB, void>)0x006B2B10)(ref this);
}

