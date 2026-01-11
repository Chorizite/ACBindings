namespace ACBindings.Internal;

public unsafe struct SquelchDB : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SquelchDB_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchDB*, void> SquelchDB_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchDB*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchDB*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchDB*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable___AC1Legacy_PStringBase__sbyte__uint _account_hash;
    public ACBindings.Internal.PackableHashTable__uint___SquelchInfo _character_hash;
    public ACBindings.Internal.SquelchInfo _global_squelch_info;

    // Generated Constructor
    public SquelchDB() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x006B1B70
    /// unsigned int __thiscall SquelchDB::Pack(SquelchDB*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchDB, void**, uint, uint>)0x006B1B70)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x006B1C00
    /// int __thiscall SquelchDB::IsPlayerSquelched(SquelchDB*,unsigned int,unsigned int)</code>
    /// </summary>
    public int IsPlayerSquelched(uint player_iid, uint msg_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchDB, uint, uint, int>)0x006B1C00)(ref this, player_iid, msg_type);

    /// <summary>
    /// <code>Offset: 0x006B2360
    /// BOOL __thiscall SquelchDB::IsSquelched(SquelchDB*,unsigned int,int*,unsigned int)</code>
    /// </summary>
    public byte IsSquelched(uint player_iid, int* a3, uint msg_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchDB, uint, int*, uint, byte>)0x006B2360)(ref this, player_iid, a3, msg_type);

    /// <summary>
    /// <code>Offset: 0x006B27B0
    /// void __thiscall SquelchDB::Clear(SquelchDB*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchDB, void>)0x006B27B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B27D0
    /// int __thiscall SquelchDB::UnPack(SquelchDB*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchDB, void**, uint, int>)0x006B27D0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x006B2A90
    /// void __thiscall SquelchDB::SquelchDB(SquelchDB*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchDB, void>)0x006B2A90)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B2B10
    /// void __thiscall SquelchDB::~SquelchDB(SquelchDB*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchDB, void>)0x006B2B10)(ref this);
}

