namespace ACBindings.Internal;

public unsafe struct CBaseQualities : System.IDisposable
{
    // Child Types
    public unsafe struct CBaseQualities_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, void> CBaseQualities_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, uint, int*, int, int> EnchantInt; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, uint, double*, int> EnchantFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, uint, ACBindings.Internal.EnchantedQualityDetails*, int> GetFloatEnchantmentDetails; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, float*, int> InqRunRate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, float*, int> InqMaxRunRate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, float, float*, int> InqJumpVelocity; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, float, int> CanJump; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, float, int*, int> JumpStaminaCost; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, sbyte*, uint, int> InqWeenieTypeString; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00590C20
    /// int __thiscall CBaseQualities::InqInt(CBaseQualities*,unsigned int,int*,int,int)</code>
    /// </summary>
    public int InqInt(uint stype, int* retval, int raw, int allow_negative) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int*, int, int, int>)0x00590C20)(ref this, stype, retval, raw, allow_negative);

    /// <summary>
    /// <code>Offset: 0x00590C70
    /// int __thiscall CBaseQualities::InqInt64(CBaseQualities*,unsigned int,__int64*)</code>
    /// </summary>
    public int InqInt64(uint stype, long* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, long*, int>)0x00590C70)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x00590CA0
    /// int __thiscall CBaseQualities::InqBool(CBaseQualities*,unsigned int,int*)</code>
    /// </summary>
    public int InqBool(uint stype, int* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int*, int>)0x00590CA0)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x00590CD0
    /// int __thiscall CBaseQualities::InqFloat(CBaseQualities*,unsigned int,long double*,int)</code>
    /// </summary>
    public int InqFloat(uint stype, double* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, double*, int, int>)0x00590CD0)(ref this, stype, retval, raw);

    /// <summary>
    /// <code>Offset: 0x00590D20
    /// int __thiscall CBaseQualities::InqDataID(_DWORD*,int,_DWORD*)</code>
    /// </summary>
    public int InqDataID(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, int, int*, int>)0x00590D20)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00590D50
    /// int __thiscall CBaseQualities::InqInstanceID(CBaseQualities*,unsigned int,unsigned int*)</code>
    /// </summary>
    public int InqInstanceID(uint stype, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, uint*, int>)0x00590D50)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x00590D80
    /// int __thiscall CBaseQualities::InqPosition(CBaseQualities*,unsigned int,Position*)</code>
    /// </summary>
    public int InqPosition(uint stype, ACBindings.Internal.Position* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, ACBindings.Internal.Position*, int>)0x00590D80)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x00591400
    /// int __thiscall CBaseQualities::RemoveInt(CBaseQualities*,unsigned int)</code>
    /// </summary>
    public int RemoveInt(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x00591400)(ref this, stype);

    /// <summary>
    /// <code>Offset: 0x00591430
    /// int __thiscall CBaseQualities::SetInt(CBaseQualities*,unsigned int,const int)</code>
    /// </summary>
    public int SetInt(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int, int>)0x00591430)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x00591500
    /// int __thiscall CBaseQualities::RemoveInt64(CBaseQualities*,unsigned int)</code>
    /// </summary>
    public int RemoveInt64(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x00591500)(ref this, stype);

    /// <summary>
    /// <code>Offset: 0x00591530
    /// int __thiscall CBaseQualities::SetInt64(CBaseQualities*,unsigned int,const __int64)</code>
    /// </summary>
    public int SetInt64(uint stype, long val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, long, int>)0x00591530)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x00591610
    /// int __thiscall CBaseQualities::RemoveBool(CBaseQualities*,unsigned int)</code>
    /// </summary>
    public int RemoveBool(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x00591610)(ref this, stype);

    /// <summary>
    /// <code>Offset: 0x00591640
    /// int __thiscall CBaseQualities::SetBool(CBaseQualities*,unsigned int,const int)</code>
    /// </summary>
    public int SetBool(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int, int>)0x00591640)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x00591710
    /// int __thiscall CBaseQualities::RemoveFloat(CBaseQualities*,unsigned int)</code>
    /// </summary>
    public int RemoveFloat(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x00591710)(ref this, stype);

    /// <summary>
    /// <code>Offset: 0x00591740
    /// int __thiscall CBaseQualities::SetFloat(CBaseQualities*,unsigned int,const long double)</code>
    /// </summary>
    public int SetFloat(uint stype, double val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, double, int>)0x00591740)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x00591820
    /// int __thiscall CBaseQualities::SetDataID(_DWORD*,unsigned int,int)</code>
    /// </summary>
    public int SetDataID(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int, int>)0x00591820)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005918F0
    /// int __thiscall CBaseQualities::RemoveInstanceID(CBaseQualities*,unsigned int)</code>
    /// </summary>
    public int RemoveInstanceID(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x005918F0)(ref this, stype);

    /// <summary>
    /// <code>Offset: 0x00591920
    /// int __thiscall CBaseQualities::SetInstanceID(CBaseQualities*,unsigned int,const unsigned int)</code>
    /// </summary>
    public int SetInstanceID(uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, uint, int>)0x00591920)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x005919F0
    /// int __thiscall CBaseQualities::InqString(_DWORD*,int,_DWORD*)</code>
    /// </summary>
    public int InqString(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, int, int*, int>)0x005919F0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00591CC0
    /// int __thiscall CBaseQualities::SetString(_DWORD*,unsigned int,int*)</code>
    /// </summary>
    public int SetString(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int*, int>)0x00591CC0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00591DA0
    /// int __thiscall CBaseQualities::SetPosition(CBaseQualities*,unsigned int,const Position*)</code>
    /// </summary>
    public int SetPosition(uint stype, ACBindings.Internal.Position* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, ACBindings.Internal.Position*, int>)0x00591DA0)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x00592220
    /// int __thiscall CBaseQualities::RemoveDataID(CBaseQualities*,unsigned int)</code>
    /// </summary>
    public int RemoveDataID(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x00592220)(ref this, stype);

    /// <summary>
    /// <code>Offset: 0x00592250
    /// int __thiscall CBaseQualities::RemovePosition(CBaseQualities*,unsigned int)</code>
    /// </summary>
    public int RemovePosition(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x00592250)(ref this, stype);

    /// <summary>
    /// <code>Offset: 0x005925F0
    /// int __thiscall CBaseQualities::RemoveString(CBaseQualities*,unsigned int)</code>
    /// </summary>
    public int RemoveString(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x005925F0)(ref this, stype);

    /// <summary>
    /// <code>Offset: 0x00596BD0
    /// void __thiscall CBaseQualities::SetPackHeader(CBaseQualities*,unsigned int*)</code>
    /// </summary>
    public void SetPackHeader(uint* bitfield) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint*, void>)0x00596BD0)(ref this, bitfield);

    /// <summary>
    /// <code>Offset: 0x00596C30
    /// unsigned int __thiscall CBaseQualities::GetPackSize(CBaseQualities*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint>)0x00596C30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00596D00
    /// void*** __thiscall CBaseQualities::CBaseQualities(void***,int)</code>
    /// </summary>
    public void*** _ConstructorInternal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, int, void***>)0x00596D00)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00596D30
    /// void __thiscall CBaseQualities::~CBaseQualities(CBaseQualities*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, void>)0x00596D30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00596D40
    /// unsigned int __thiscall CBaseQualities::Pack(CBaseQualities*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, void**, uint, uint>)0x00596D40)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00596E10
    /// int __thiscall CBaseQualities::UnPack(CBaseQualities*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint left) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, void**, uint, int>)0x00596E10)(ref this, addr, left);
}

