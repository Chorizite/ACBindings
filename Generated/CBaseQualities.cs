namespace ACBindings;

// CBaseQualities
public unsafe struct CBaseQualities : System.IDisposable
{
    // Child Types
    // CBaseQualities_vtbl
    public unsafe struct CBaseQualities_vtbl
    {
        // Members
        public System.IntPtr CBaseQualities_dtor_0; // function pointer
        public System.IntPtr EnchantInt; // function pointer
        public System.IntPtr EnchantFloat; // function pointer
        public System.IntPtr GetFloatEnchantmentDetails; // function pointer
        public System.IntPtr InqRunRate; // function pointer
        public System.IntPtr InqMaxRunRate; // function pointer
        public System.IntPtr InqJumpVelocity; // function pointer
        public System.IntPtr CanJump; // function pointer
        public System.IntPtr JumpStaminaCost; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr InqWeenieTypeString; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint _weenie_type;
    public System.IntPtr _intStatsTable;
    public System.IntPtr _int64StatsTable;
    public System.IntPtr _boolStatsTable;
    public System.IntPtr _floatStatsTable;
    public System.IntPtr _strStatsTable;
    public System.IntPtr _didStatsTable;
    public System.IntPtr _iidStatsTable;
    public System.IntPtr _posStatsTable;

    // Generated Constructor
    public CBaseQualities(int a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // int __thiscall CBaseQualities::InqInt(CBaseQualities*,unsigned int,int*,int,int)
    public int InqInt(uint stype, int* retval, int raw, int allow_negative) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, int*, int, int, int>)0x00590C20)(ref this, stype, retval, raw, allow_negative);
    // int __thiscall CBaseQualities::InqInt64(CBaseQualities*,unsigned int,__int64*)
    public int InqInt64(uint stype, long* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, long*, int>)0x00590C70)(ref this, stype, retval);
    // int __thiscall CBaseQualities::InqBool(CBaseQualities*,unsigned int,int*)
    public int InqBool(uint stype, int* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, int*, int>)0x00590CA0)(ref this, stype, retval);
    // int __thiscall CBaseQualities::InqFloat(CBaseQualities*,unsigned int,long double*,int)
    public int InqFloat(uint stype, double* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, double*, int, int>)0x00590CD0)(ref this, stype, retval, raw);
    // int __thiscall CBaseQualities::InqDataID(_DWORD*,int,_DWORD*)
    public int InqDataID(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, int, int*, int>)0x00590D20)(ref this, a2, a3);
    // int __thiscall CBaseQualities::InqInstanceID(CBaseQualities*,unsigned int,unsigned int*)
    public int InqInstanceID(uint stype, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, uint*, int>)0x00590D50)(ref this, stype, retval);
    // int __thiscall CBaseQualities::InqPosition(CBaseQualities*,unsigned int,Position*)
    public int InqPosition(uint stype, ACBindings.Position* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, ACBindings.Position*, int>)0x00590D80)(ref this, stype, retval);
    // int __thiscall CBaseQualities::RemoveInt(CBaseQualities*,unsigned int)
    public int RemoveInt(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, int>)0x00591400)(ref this, stype);
    // int __thiscall CBaseQualities::SetInt(CBaseQualities*,unsigned int,const int)
    public int SetInt(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, int, int>)0x00591430)(ref this, stype, val);
    // int __thiscall CBaseQualities::RemoveInt64(CBaseQualities*,unsigned int)
    public int RemoveInt64(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, int>)0x00591500)(ref this, stype);
    // int __thiscall CBaseQualities::SetInt64(CBaseQualities*,unsigned int,const __int64)
    public int SetInt64(uint stype, long val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, long, int>)0x00591530)(ref this, stype, val);
    // int __thiscall CBaseQualities::RemoveBool(CBaseQualities*,unsigned int)
    public int RemoveBool(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, int>)0x00591610)(ref this, stype);
    // int __thiscall CBaseQualities::SetBool(CBaseQualities*,unsigned int,const int)
    public int SetBool(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, int, int>)0x00591640)(ref this, stype, val);
    // int __thiscall CBaseQualities::RemoveFloat(CBaseQualities*,unsigned int)
    public int RemoveFloat(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, int>)0x00591710)(ref this, stype);
    // int __thiscall CBaseQualities::SetFloat(CBaseQualities*,unsigned int,const long double)
    public int SetFloat(uint stype, double val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, double, int>)0x00591740)(ref this, stype, val);
    // int __thiscall CBaseQualities::SetDataID(_DWORD*,unsigned int,int)
    public int SetDataID(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, int, int>)0x00591820)(ref this, a2, a3);
    // int __thiscall CBaseQualities::RemoveInstanceID(CBaseQualities*,unsigned int)
    public int RemoveInstanceID(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, int>)0x005918F0)(ref this, stype);
    // int __thiscall CBaseQualities::SetInstanceID(CBaseQualities*,unsigned int,const unsigned int)
    public int SetInstanceID(uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, uint, int>)0x00591920)(ref this, stype, val);
    // int __thiscall CBaseQualities::InqString(_DWORD*,int,_DWORD*)
    public int InqString(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, int, int*, int>)0x005919F0)(ref this, a2, a3);
    // int __thiscall CBaseQualities::SetString(_DWORD*,unsigned int,int*)
    public int SetString(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, int*, int>)0x00591CC0)(ref this, a2, a3);
    // int __thiscall CBaseQualities::SetPosition(CBaseQualities*,unsigned int,const Position*)
    public int SetPosition(uint stype, ACBindings.Position* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, ACBindings.Position*, int>)0x00591DA0)(ref this, stype, val);
    // int __thiscall CBaseQualities::RemoveDataID(CBaseQualities*,unsigned int)
    public int RemoveDataID(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, int>)0x00592220)(ref this, stype);
    // int __thiscall CBaseQualities::RemovePosition(CBaseQualities*,unsigned int)
    public int RemovePosition(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, int>)0x00592250)(ref this, stype);
    // int __thiscall CBaseQualities::RemoveString(CBaseQualities*,unsigned int)
    public int RemoveString(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint, int>)0x005925F0)(ref this, stype);
    // void __thiscall CBaseQualities::SetPackHeader(CBaseQualities*,unsigned int*)
    public void SetPackHeader(uint* bitfield) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint*, void>)0x00596BD0)(ref this, bitfield);
    // unsigned int __thiscall CBaseQualities::GetPackSize(CBaseQualities*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, uint>)0x00596C30)(ref this);
    // void*** __thiscall CBaseQualities::CBaseQualities(void***,int)
    public void*** _ConstructorInternal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, int, void***>)0x00596D00)(ref this, a2);
    // void __thiscall CBaseQualities::~CBaseQualities(CBaseQualities*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, void>)0x00596D30)(ref this);
    // unsigned int __thiscall CBaseQualities::Pack(CBaseQualities*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, void**, uint, uint>)0x00596D40)(ref this, addr, size);
    // int __thiscall CBaseQualities::UnPack(CBaseQualities*,void**,unsigned int)
    public int UnPack(void** addr, uint left) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBaseQualities, void**, uint, int>)0x00596E10)(ref this, addr, left);
}

