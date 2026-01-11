namespace ACBindings.Internal;

public unsafe struct ClientObjMaintSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem
    public ACBindings.Internal.ACCObjectMaint BaseClass_ACCObjectMaint; // ACBindings.Internal.ACCObjectMaint

    // Child Types
    public unsafe struct ClientObjMaintSystem_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnStartup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> UseTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnBeginCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnEndCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnShutdown; // function pointer

        // Methods
    }

    // Generated Constructor
    public ClientObjMaintSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00558370
    /// void __thiscall ClientObjMaintSystem::~ClientObjMaintSystem(ClientObjMaintSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, void>)0x00558370)(ref this);

    /// <summary>
    /// <code>Offset: 0x005583F0
    /// ACCWeenieObject* __cdecl ClientObjMaintSystem::GetWeenieObject(unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.ACCWeenieObject* GetWeenieObject(uint i_iid) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.ACCWeenieObject*>)0x005583F0)(i_iid);

    /// <summary>
    /// <code>Offset: 0x00558410
    /// CPhysicsObj* __cdecl ClientObjMaintSystem::GetPhysicsObject(unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.CPhysicsObj* GetPhysicsObject(uint i_iid) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CPhysicsObj*>)0x00558410)(i_iid);

    /// <summary>
    /// <code>Offset: 0x00558490
    /// unsigned int __thiscall ClientObjMaintSystem::Release(ClientObjMaintSystem*)</code>
    /// </summary>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, uint>)0x00558490)(ref this);

    /// <summary>
    /// <code>Offset: 0x00558540
    /// TResult* __thiscall ClientObjMaintSystem::QueryInterface(ClientObjMaintSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x00558540)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>
    /// <code>Offset: 0x00558630
    /// TResult* __thiscall ClientObjMaintSystem::QueryInterface(TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.Turbine_GUID* a2, void** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x00558630)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005587E0
    /// bool __thiscall ClientObjMaintSystem::UpdateStackSize(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public byte UpdateStackSize(byte ts, uint item, uint amount, uint newValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint, byte>)0x005587E0)(ref this, ts, item, amount, newValue);

    /// <summary>
    /// <code>Offset: 0x005590B0
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;Int_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    public static int RemoveStat__Int_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x005590B0)(stype, new_ts, object_id);

    /// <summary>
    /// <code>Offset: 0x00559130
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;Int64_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    public static int RemoveStat__Int64_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x00559130)(stype, new_ts, object_id);

    /// <summary>
    /// <code>Offset: 0x005591B0
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;Bool_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    public static int RemoveStat__Bool_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x005591B0)(stype, new_ts, object_id);

    /// <summary>
    /// <code>Offset: 0x00559230
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;Float_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    public static int RemoveStat__Float_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x00559230)(stype, new_ts, object_id);

    /// <summary>
    /// <code>Offset: 0x005592B0
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;String_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    public static int RemoveStat__String_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x005592B0)(stype, new_ts, object_id);

    /// <summary>
    /// <code>Offset: 0x00559330
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;DataID_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    public static int RemoveStat__DataID_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x00559330)(stype, new_ts, object_id);

    /// <summary>
    /// <code>Offset: 0x005593B0
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;InstanceID_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    public static int RemoveStat__InstanceID_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x005593B0)(stype, new_ts, object_id);

    /// <summary>
    /// <code>Offset: 0x00559430
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;Position_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    public static int RemoveStat__Position_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x00559430)(stype, new_ts, object_id);

    /// <summary>
    /// <code>Offset: 0x005597B0
    /// void __thiscall ClientObjMaintSystem::ClientObjMaintSystem(ClientObjMaintSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, void>)0x005597B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00559860
    /// void __thiscall ClientObjMaintSystem::OnShutdown(ClientObjMaintSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, void>)0x00559860)(ref this);

    /// <summary>
    /// <code>Offset: 0x005598C0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateAttribute(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,Attribute*)</code>
    /// </summary>
    public uint Handle_Qualities__UpdateAttribute(byte wts, uint sender, uint stype, ACBindings.Internal.Attribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, ACBindings.Internal.Attribute*, uint>)0x005598C0)(ref this, wts, sender, stype, val);

    /// <summary>
    /// <code>Offset: 0x005598E0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateAttributeLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Qualities__UpdateAttributeLevel(byte wts, uint sender, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, int, uint>)0x005598E0)(ref this, wts, sender, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559900
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateAttribute2nd(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,SecondaryAttribute*)</code>
    /// </summary>
    public uint Handle_Qualities__UpdateAttribute2nd(byte wts, uint sender, uint stype, ACBindings.Internal.SecondaryAttribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, ACBindings.Internal.SecondaryAttribute*, uint>)0x00559900)(ref this, wts, sender, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559920
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateAttribute2ndLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Qualities__UpdateAttribute2ndLevel(byte wts, uint sender, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, int, uint>)0x00559920)(ref this, wts, sender, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559940
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateSkill(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,Skill*)</code>
    /// </summary>
    public uint Handle_Qualities__UpdateSkill(byte wts, uint sender, uint stype, ACBindings.Internal.Skill* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, ACBindings.Internal.Skill*, uint>)0x00559940)(ref this, wts, sender, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559960
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateSkillLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Qualities__UpdateSkillLevel(byte wts, uint sender, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, int, uint>)0x00559960)(ref this, wts, sender, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559980
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateSkillAC(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,SKILL_ADVANCEMENT_CLASS)</code>
    /// </summary>
    public uint Handle_Qualities__UpdateSkillAC(byte wts, uint sender, uint stype, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS, uint>)0x00559980)(ref this, wts, sender, stype, val);

    /// <summary>
    /// <code>Offset: 0x005599A0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateInt(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Qualities__UpdateInt(byte wts, uint sender, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, int, uint>)0x005599A0)(ref this, wts, sender, stype, val);

    /// <summary>
    /// <code>Offset: 0x005599C0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateInt64(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,__int64)</code>
    /// </summary>
    public uint Handle_Qualities__UpdateInt64(byte wts, uint sender, uint stype, long val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, long, uint>)0x005599C0)(ref this, wts, sender, stype, val);

    /// <summary>
    /// <code>Offset: 0x005599F0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateBool(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Qualities__UpdateBool(byte wts, uint sender, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, int, uint>)0x005599F0)(ref this, wts, sender, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559A10
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateFloat(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,long double)</code>
    /// </summary>
    public uint Handle_Qualities__UpdateFloat(byte wts, uint sender, uint stype, double val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, double, uint>)0x00559A10)(ref this, wts, sender, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559A40
    /// int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateString(void*,unsigned __int8,unsigned int,unsigned int,int*)</code>
    /// </summary>
    public int Handle_Qualities__UpdateString(byte a2, uint a3, uint a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, int*, int>)0x00559A40)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x00559A60
    /// int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateDataID(void*,unsigned __int8,unsigned int,unsigned int,int)</code>
    /// </summary>
    public int Handle_Qualities__UpdateDataID(byte a2, uint a3, uint a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, int, int>)0x00559A60)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x00559A80
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateInstanceID(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__UpdateInstanceID(byte wts, uint sender, uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint, uint>)0x00559A80)(ref this, wts, sender, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559AA0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdatePosition(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,const Position*)</code>
    /// </summary>
    public uint Handle_Qualities__UpdatePosition(byte wts, uint sender, uint stype, ACBindings.Internal.Position* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, ACBindings.Internal.Position*, uint>)0x00559AA0)(ref this, wts, sender, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559AC0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateAttribute(ClientObjMaintSystem*,unsigned __int8,unsigned int,Attribute*)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateUpdateAttribute(byte wts, uint stype, ACBindings.Internal.Attribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, ACBindings.Internal.Attribute*, uint>)0x00559AC0)(ref this, wts, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559AF0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateAttributeLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateUpdateAttributeLevel(byte wts, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, int, uint>)0x00559AF0)(ref this, wts, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559B20
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateAttribute2nd(ClientObjMaintSystem*,unsigned __int8,unsigned int,SecondaryAttribute*)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateUpdateAttribute2nd(byte wts, uint stype, ACBindings.Internal.SecondaryAttribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, ACBindings.Internal.SecondaryAttribute*, uint>)0x00559B20)(ref this, wts, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559B50
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateAttribute2ndLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateUpdateAttribute2ndLevel(byte wts, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, int, uint>)0x00559B50)(ref this, wts, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559B80
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateSkill(ClientObjMaintSystem*,unsigned __int8,unsigned int,Skill*)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateUpdateSkill(byte wts, uint stype, ACBindings.Internal.Skill* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, ACBindings.Internal.Skill*, uint>)0x00559B80)(ref this, wts, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559BB0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateSkillLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateUpdateSkillLevel(byte wts, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, int, uint>)0x00559BB0)(ref this, wts, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559BE0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateSkillAC(ClientObjMaintSystem*,unsigned __int8,unsigned int,SKILL_ADVANCEMENT_CLASS)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateUpdateSkillAC(byte wts, uint stype, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS, uint>)0x00559BE0)(ref this, wts, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559C10
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateInt(ClientObjMaintSystem*,unsigned __int8,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateUpdateInt(byte wts, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, int, uint>)0x00559C10)(ref this, wts, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559C40
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateInt64(ClientObjMaintSystem*,unsigned __int8,unsigned int,__int64)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateUpdateInt64(byte wts, uint stype, long val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, long, uint>)0x00559C40)(ref this, wts, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559C70
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateBool(ClientObjMaintSystem*,unsigned __int8,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateUpdateBool(byte wts, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, int, uint>)0x00559C70)(ref this, wts, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559CA0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateFloat(ClientObjMaintSystem*,unsigned __int8,unsigned int,long double)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateUpdateFloat(byte wts, uint stype, double val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, double, uint>)0x00559CA0)(ref this, wts, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559CD0
    /// int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateString(void*,unsigned __int8,unsigned int,int*)</code>
    /// </summary>
    public int Handle_Qualities__PrivateUpdateString(byte a2, uint a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, int*, int>)0x00559CD0)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x00559D00
    /// int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateDataID(void*,unsigned __int8,unsigned int,int)</code>
    /// </summary>
    public int Handle_Qualities__PrivateUpdateDataID(byte a2, uint a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, int, int>)0x00559D00)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x00559D30
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateInstanceID(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateUpdateInstanceID(byte wts, uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559D30)(ref this, wts, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559D60
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdatePosition(ClientObjMaintSystem*,unsigned __int8,unsigned int,const Position*)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateUpdatePosition(byte wts, uint stype, ACBindings.Internal.Position* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, ACBindings.Internal.Position*, uint>)0x00559D60)(ref this, wts, stype, val);

    /// <summary>
    /// <code>Offset: 0x00559D90
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveIntEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__RemoveIntEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559D90)(ref this, wts, sender, stype);

    /// <summary>
    /// <code>Offset: 0x00559DB0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveInt64Event(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__RemoveInt64Event(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559DB0)(ref this, wts, sender, stype);

    /// <summary>
    /// <code>Offset: 0x00559DD0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveBoolEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__RemoveBoolEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559DD0)(ref this, wts, sender, stype);

    /// <summary>
    /// <code>Offset: 0x00559DF0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveFloatEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__RemoveFloatEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559DF0)(ref this, wts, sender, stype);

    /// <summary>
    /// <code>Offset: 0x00559E10
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveStringEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__RemoveStringEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559E10)(ref this, wts, sender, stype);

    /// <summary>
    /// <code>Offset: 0x00559E30
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveDataIDEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__RemoveDataIDEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559E30)(ref this, wts, sender, stype);

    /// <summary>
    /// <code>Offset: 0x00559E50
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveInstanceIDEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__RemoveInstanceIDEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559E50)(ref this, wts, sender, stype);

    /// <summary>
    /// <code>Offset: 0x00559E70
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemovePositionEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__RemovePositionEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559E70)(ref this, wts, sender, stype);

    /// <summary>
    /// <code>Offset: 0x00559EA0
    /// ClientObjMaintSystem* __cdecl ClientObjMaintSystem::Allocate()</code>
    /// </summary>
    public static ACBindings.Internal.ClientObjMaintSystem* Allocate() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ClientObjMaintSystem*>)0x00559EA0)();

    /// <summary>
    /// <code>Offset: 0x00559EC0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveIntEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateRemoveIntEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x00559EC0)(ref this, wts, stype);

    /// <summary>
    /// <code>Offset: 0x00559F00
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveInt64Event(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateRemoveInt64Event(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x00559F00)(ref this, wts, stype);

    /// <summary>
    /// <code>Offset: 0x00559F40
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveBoolEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateRemoveBoolEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x00559F40)(ref this, wts, stype);

    /// <summary>
    /// <code>Offset: 0x00559F80
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveFloatEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateRemoveFloatEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x00559F80)(ref this, wts, stype);

    /// <summary>
    /// <code>Offset: 0x00559FC0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveStringEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateRemoveStringEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x00559FC0)(ref this, wts, stype);

    /// <summary>
    /// <code>Offset: 0x0055A000
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveDataIDEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateRemoveDataIDEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x0055A000)(ref this, wts, stype);

    /// <summary>
    /// <code>Offset: 0x0055A040
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveInstanceIDEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateRemoveInstanceIDEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x0055A040)(ref this, wts, stype);

    /// <summary>
    /// <code>Offset: 0x0055A080
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemovePositionEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    public uint Handle_Qualities__PrivateRemovePositionEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x0055A080)(ref this, wts, stype);

    /// <summary>
    /// <code>Offset: 0x0056B950
    /// unsigned int __thiscall ClientObjMaintSystem::AddRef(ClientCombatSystem*)</code>
    /// </summary>
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, uint>)0x0056B950)(ref this);
}

