namespace ACBindings;

// ClientObjMaintSystem
public unsafe struct ClientObjMaintSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.ClientSystem BaseClass_ClientSystem; // ACBindings.ClientSystem
    public ACBindings.ACCObjectMaint BaseClass_ACCObjectMaint; // ACBindings.ACCObjectMaint

    // Child Types
    // ClientObjMaintSystem_vtbl
    public unsafe struct ClientObjMaintSystem_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr OnStartup; // function pointer
        public System.IntPtr UseTime; // function pointer
        public System.IntPtr OnBeginCharacterSession; // function pointer
        public System.IntPtr OnEndCharacterSession; // function pointer
        public System.IntPtr OnShutdown; // function pointer

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
    // void __thiscall ClientObjMaintSystem::~ClientObjMaintSystem(ClientObjMaintSystem*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, void>)0x00558370)(ref this);
    // ACCWeenieObject* __cdecl ClientObjMaintSystem::GetWeenieObject(unsigned int)
    public static ACBindings.ACCWeenieObject* GetWeenieObject(uint i_iid) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.ACCWeenieObject*>)0x005583F0)(i_iid);
    // CPhysicsObj* __cdecl ClientObjMaintSystem::GetPhysicsObject(unsigned int)
    public static ACBindings.CPhysicsObj* GetPhysicsObject(uint i_iid) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.CPhysicsObj*>)0x00558410)(i_iid);
    // unsigned int __thiscall ClientObjMaintSystem::Release(ClientObjMaintSystem*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, uint>)0x00558490)(ref this);
    // TResult* __thiscall ClientObjMaintSystem::QueryInterface(ClientObjMaintSystem*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x00558540)(ref this, result, i_rcInterface, o_ppvInterface);
    // TResult* __thiscall ClientObjMaintSystem::QueryInterface(TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.Turbine_GUID* a2, void** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x00558630)(ref this, a2, a3);
    // bool __thiscall ClientObjMaintSystem::UpdateStackSize(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,unsigned int)
    public byte UpdateStackSize(byte ts, uint item, uint amount, uint newValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, uint, byte>)0x005587E0)(ref this, ts, item, amount, newValue);
    // int __stdcall ClientObjMaintSystem::RemoveStat<Int_QualityType>(unsigned int,unsigned __int8,unsigned int)
    public static int RemoveStat__Int_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x005590B0)(stype, new_ts, object_id);
    // int __stdcall ClientObjMaintSystem::RemoveStat<Int64_QualityType>(unsigned int,unsigned __int8,unsigned int)
    public static int RemoveStat__Int64_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x00559130)(stype, new_ts, object_id);
    // int __stdcall ClientObjMaintSystem::RemoveStat<Bool_QualityType>(unsigned int,unsigned __int8,unsigned int)
    public static int RemoveStat__Bool_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x005591B0)(stype, new_ts, object_id);
    // int __stdcall ClientObjMaintSystem::RemoveStat<Float_QualityType>(unsigned int,unsigned __int8,unsigned int)
    public static int RemoveStat__Float_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x00559230)(stype, new_ts, object_id);
    // int __stdcall ClientObjMaintSystem::RemoveStat<String_QualityType>(unsigned int,unsigned __int8,unsigned int)
    public static int RemoveStat__String_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x005592B0)(stype, new_ts, object_id);
    // int __stdcall ClientObjMaintSystem::RemoveStat<DataID_QualityType>(unsigned int,unsigned __int8,unsigned int)
    public static int RemoveStat__DataID_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x00559330)(stype, new_ts, object_id);
    // int __stdcall ClientObjMaintSystem::RemoveStat<InstanceID_QualityType>(unsigned int,unsigned __int8,unsigned int)
    public static int RemoveStat__InstanceID_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x005593B0)(stype, new_ts, object_id);
    // int __stdcall ClientObjMaintSystem::RemoveStat<Position_QualityType>(unsigned int,unsigned __int8,unsigned int)
    public static int RemoveStat__Position_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x00559430)(stype, new_ts, object_id);
    // void __thiscall ClientObjMaintSystem::ClientObjMaintSystem(ClientObjMaintSystem*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, void>)0x005597B0)(ref this);
    // void __thiscall ClientObjMaintSystem::OnShutdown(ClientObjMaintSystem*)
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, void>)0x00559860)(ref this);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateAttribute(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,Attribute*)
    public uint Handle_Qualities__UpdateAttribute(byte wts, uint sender, uint stype, ACBindings.Attribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, ACBindings.Attribute*, uint>)0x005598C0)(ref this, wts, sender, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateAttributeLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,int)
    public uint Handle_Qualities__UpdateAttributeLevel(byte wts, uint sender, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, int, uint>)0x005598E0)(ref this, wts, sender, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateAttribute2nd(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,SecondaryAttribute*)
    public uint Handle_Qualities__UpdateAttribute2nd(byte wts, uint sender, uint stype, ACBindings.SecondaryAttribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, ACBindings.SecondaryAttribute*, uint>)0x00559900)(ref this, wts, sender, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateAttribute2ndLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,int)
    public uint Handle_Qualities__UpdateAttribute2ndLevel(byte wts, uint sender, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, int, uint>)0x00559920)(ref this, wts, sender, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateSkill(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,Skill*)
    public uint Handle_Qualities__UpdateSkill(byte wts, uint sender, uint stype, ACBindings.Skill* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, ACBindings.Skill*, uint>)0x00559940)(ref this, wts, sender, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateSkillLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,int)
    public uint Handle_Qualities__UpdateSkillLevel(byte wts, uint sender, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, int, uint>)0x00559960)(ref this, wts, sender, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateSkillAC(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,SKILL_ADVANCEMENT_CLASS)
    public uint Handle_Qualities__UpdateSkillAC(byte wts, uint sender, uint stype, ACBindings.SKILL_ADVANCEMENT_CLASS val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, ACBindings.SKILL_ADVANCEMENT_CLASS, uint>)0x00559980)(ref this, wts, sender, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateInt(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,int)
    public uint Handle_Qualities__UpdateInt(byte wts, uint sender, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, int, uint>)0x005599A0)(ref this, wts, sender, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateInt64(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,__int64)
    public uint Handle_Qualities__UpdateInt64(byte wts, uint sender, uint stype, long val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, long, uint>)0x005599C0)(ref this, wts, sender, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateBool(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,int)
    public uint Handle_Qualities__UpdateBool(byte wts, uint sender, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, int, uint>)0x005599F0)(ref this, wts, sender, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateFloat(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,long double)
    public uint Handle_Qualities__UpdateFloat(byte wts, uint sender, uint stype, double val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, double, uint>)0x00559A10)(ref this, wts, sender, stype, val);
    // int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateString(void*,unsigned __int8,unsigned int,unsigned int,int*)
    public int Handle_Qualities__UpdateString(byte a2, uint a3, uint a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, int*, int>)0x00559A40)(ref this, a2, a3, a4, a5);
    // int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateDataID(void*,unsigned __int8,unsigned int,unsigned int,int)
    public int Handle_Qualities__UpdateDataID(byte a2, uint a3, uint a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, int, int>)0x00559A60)(ref this, a2, a3, a4, a5);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateInstanceID(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,unsigned int)
    public uint Handle_Qualities__UpdateInstanceID(byte wts, uint sender, uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, uint, uint>)0x00559A80)(ref this, wts, sender, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdatePosition(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,const Position*)
    public uint Handle_Qualities__UpdatePosition(byte wts, uint sender, uint stype, ACBindings.Position* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, ACBindings.Position*, uint>)0x00559AA0)(ref this, wts, sender, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateAttribute(ClientObjMaintSystem*,unsigned __int8,unsigned int,Attribute*)
    public uint Handle_Qualities__PrivateUpdateAttribute(byte wts, uint stype, ACBindings.Attribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, ACBindings.Attribute*, uint>)0x00559AC0)(ref this, wts, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateAttributeLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,int)
    public uint Handle_Qualities__PrivateUpdateAttributeLevel(byte wts, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, int, uint>)0x00559AF0)(ref this, wts, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateAttribute2nd(ClientObjMaintSystem*,unsigned __int8,unsigned int,SecondaryAttribute*)
    public uint Handle_Qualities__PrivateUpdateAttribute2nd(byte wts, uint stype, ACBindings.SecondaryAttribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, ACBindings.SecondaryAttribute*, uint>)0x00559B20)(ref this, wts, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateAttribute2ndLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,int)
    public uint Handle_Qualities__PrivateUpdateAttribute2ndLevel(byte wts, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, int, uint>)0x00559B50)(ref this, wts, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateSkill(ClientObjMaintSystem*,unsigned __int8,unsigned int,Skill*)
    public uint Handle_Qualities__PrivateUpdateSkill(byte wts, uint stype, ACBindings.Skill* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, ACBindings.Skill*, uint>)0x00559B80)(ref this, wts, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateSkillLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,int)
    public uint Handle_Qualities__PrivateUpdateSkillLevel(byte wts, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, int, uint>)0x00559BB0)(ref this, wts, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateSkillAC(ClientObjMaintSystem*,unsigned __int8,unsigned int,SKILL_ADVANCEMENT_CLASS)
    public uint Handle_Qualities__PrivateUpdateSkillAC(byte wts, uint stype, ACBindings.SKILL_ADVANCEMENT_CLASS val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, ACBindings.SKILL_ADVANCEMENT_CLASS, uint>)0x00559BE0)(ref this, wts, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateInt(ClientObjMaintSystem*,unsigned __int8,unsigned int,int)
    public uint Handle_Qualities__PrivateUpdateInt(byte wts, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, int, uint>)0x00559C10)(ref this, wts, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateInt64(ClientObjMaintSystem*,unsigned __int8,unsigned int,__int64)
    public uint Handle_Qualities__PrivateUpdateInt64(byte wts, uint stype, long val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, long, uint>)0x00559C40)(ref this, wts, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateBool(ClientObjMaintSystem*,unsigned __int8,unsigned int,int)
    public uint Handle_Qualities__PrivateUpdateBool(byte wts, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, int, uint>)0x00559C70)(ref this, wts, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateFloat(ClientObjMaintSystem*,unsigned __int8,unsigned int,long double)
    public uint Handle_Qualities__PrivateUpdateFloat(byte wts, uint stype, double val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, double, uint>)0x00559CA0)(ref this, wts, stype, val);
    // int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateString(void*,unsigned __int8,unsigned int,int*)
    public int Handle_Qualities__PrivateUpdateString(byte a2, uint a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, int*, int>)0x00559CD0)(ref this, a2, a3, a4);
    // int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateDataID(void*,unsigned __int8,unsigned int,int)
    public int Handle_Qualities__PrivateUpdateDataID(byte a2, uint a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, int, int>)0x00559D00)(ref this, a2, a3, a4);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateInstanceID(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)
    public uint Handle_Qualities__PrivateUpdateInstanceID(byte wts, uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559D30)(ref this, wts, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdatePosition(ClientObjMaintSystem*,unsigned __int8,unsigned int,const Position*)
    public uint Handle_Qualities__PrivateUpdatePosition(byte wts, uint stype, ACBindings.Position* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, ACBindings.Position*, uint>)0x00559D60)(ref this, wts, stype, val);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveIntEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)
    public uint Handle_Qualities__RemoveIntEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559D90)(ref this, wts, sender, stype);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveInt64Event(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)
    public uint Handle_Qualities__RemoveInt64Event(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559DB0)(ref this, wts, sender, stype);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveBoolEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)
    public uint Handle_Qualities__RemoveBoolEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559DD0)(ref this, wts, sender, stype);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveFloatEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)
    public uint Handle_Qualities__RemoveFloatEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559DF0)(ref this, wts, sender, stype);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveStringEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)
    public uint Handle_Qualities__RemoveStringEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559E10)(ref this, wts, sender, stype);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveDataIDEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)
    public uint Handle_Qualities__RemoveDataIDEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559E30)(ref this, wts, sender, stype);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveInstanceIDEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)
    public uint Handle_Qualities__RemoveInstanceIDEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559E50)(ref this, wts, sender, stype);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemovePositionEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)
    public uint Handle_Qualities__RemovePositionEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559E70)(ref this, wts, sender, stype);
    // ClientObjMaintSystem* __cdecl ClientObjMaintSystem::Allocate()
    public static ACBindings.ClientObjMaintSystem* Allocate() => ((delegate* unmanaged[Cdecl]<ACBindings.ClientObjMaintSystem*>)0x00559EA0)();
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveIntEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)
    public uint Handle_Qualities__PrivateRemoveIntEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint>)0x00559EC0)(ref this, wts, stype);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveInt64Event(ClientObjMaintSystem*,unsigned __int8,unsigned int)
    public uint Handle_Qualities__PrivateRemoveInt64Event(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint>)0x00559F00)(ref this, wts, stype);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveBoolEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)
    public uint Handle_Qualities__PrivateRemoveBoolEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint>)0x00559F40)(ref this, wts, stype);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveFloatEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)
    public uint Handle_Qualities__PrivateRemoveFloatEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint>)0x00559F80)(ref this, wts, stype);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveStringEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)
    public uint Handle_Qualities__PrivateRemoveStringEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint>)0x00559FC0)(ref this, wts, stype);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveDataIDEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)
    public uint Handle_Qualities__PrivateRemoveDataIDEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint>)0x0055A000)(ref this, wts, stype);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveInstanceIDEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)
    public uint Handle_Qualities__PrivateRemoveInstanceIDEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint>)0x0055A040)(ref this, wts, stype);
    // unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemovePositionEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)
    public uint Handle_Qualities__PrivateRemovePositionEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, byte, uint, uint>)0x0055A080)(ref this, wts, stype);
    // unsigned int __thiscall ClientObjMaintSystem::AddRef(ClientCombatSystem*)
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientObjMaintSystem, uint>)0x0056B950)(ref this);
}

