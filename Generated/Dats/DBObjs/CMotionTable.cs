namespace ACBindings.Internal;

public unsafe struct CMotionTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct CMotionTable_vtbl
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
    public ACBindings.Internal.LongNIValHash__uint style_defaults;
    public ACBindings.Internal.LongHash___MotionData cycles;
    public ACBindings.Internal.LongHash___MotionData modifiers;
    public ACBindings.Internal.LongNIValHash___LongHash___MotionData_ptr links;
    public uint default_style;

    // Generated Constructor
    public CMotionTable() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004FA080
    /// void __thiscall CMotionTable::CMotionTable(CMotionTable*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, void>)0x004FA080)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FA280
    /// DBObj* __thiscall CMotionTable::Allocator(CMotionTable*)</code>
    /// </summary>
    public ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, ACBindings.Internal.DBObj*>)0x004FA280)(ref this);

    /// <summary>
    /// <code>Offset: 0x00522E30
    /// void __thiscall CMotionTable::re_modify(CMotionTable*,CSequence*,MotionState*)</code>
    /// </summary>
    public void re_modify(ACBindings.Internal.CSequence* sequence, ACBindings.Internal.MotionState* state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, ACBindings.Internal.CSequence*, ACBindings.Internal.MotionState*, void>)0x00522E30)(ref this, sequence, state);

    /// <summary>
    /// <code>Offset: 0x00523260
    /// int __thiscall CMotionTable::is_allowed(CMotionTable*,unsigned int,const MotionData*,const MotionState*)</code>
    /// </summary>
    public int is_allowed(uint motion, ACBindings.Internal.MotionData* mdata, ACBindings.Internal.MotionState* state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, uint, ACBindings.Internal.MotionData*, ACBindings.Internal.MotionState*, int>)0x00523260)(ref this, motion, mdata, state);

    /// <summary>
    /// <code>Offset: 0x005232B0
    /// MotionData* __thiscall CMotionTable::get_link(CMotionTable*,unsigned int,unsigned int,float,unsigned int,float)</code>
    /// </summary>
    public ACBindings.Internal.MotionData* get_link(uint style, uint substate, float substate_speed, uint motion, float speed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, uint, uint, float, uint, float, ACBindings.Internal.MotionData*>)0x005232B0)(ref this, style, substate, substate_speed, motion, speed);

    /// <summary>
    /// <code>Offset: 0x00523400
    /// int __thiscall CMotionTable::GetObjectSequence(CMotionTable*,unsigned int,MotionState*,CSequence*,float,unsigned int*,int)</code>
    /// </summary>
    public int GetObjectSequence(uint motion, ACBindings.Internal.MotionState* curr_state, ACBindings.Internal.CSequence* sequence, float speed_mod, uint* num_anims, int stop_modifiers) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, uint, ACBindings.Internal.MotionState*, ACBindings.Internal.CSequence*, float, uint*, int, int>)0x00523400)(ref this, motion, curr_state, sequence, speed_mod, num_anims, stop_modifiers);

    /// <summary>
    /// <code>Offset: 0x00523B60
    /// int __thiscall CMotionTable::StopSequenceMotion(CMotionTable*,unsigned int,float,MotionState*,CSequence*,unsigned int*)</code>
    /// </summary>
    public int StopSequenceMotion(uint motion, float speed, ACBindings.Internal.MotionState* curr_state, ACBindings.Internal.CSequence* sequence, uint* num_anims) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, uint, float, ACBindings.Internal.MotionState*, ACBindings.Internal.CSequence*, uint*, int>)0x00523B60)(ref this, motion, speed, curr_state, sequence, num_anims);

    /// <summary>
    /// <code>Offset: 0x00523C40
    /// int __thiscall CMotionTable::SetDefaultState(CMotionTable*,MotionState*,CSequence*,unsigned int*)</code>
    /// </summary>
    public int SetDefaultState(ACBindings.Internal.MotionState* state, ACBindings.Internal.CSequence* sequence, uint* num_anims) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, ACBindings.Internal.MotionState*, ACBindings.Internal.CSequence*, uint*, int>)0x00523C40)(ref this, state, sequence, num_anims);

    /// <summary>
    /// <code>Offset: 0x00523D20
    /// unsigned int __thiscall CMotionTable::Pack(CMotionTable*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, void**, uint, uint>)0x00523D20)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00524460
    /// int __thiscall CMotionTable::UnPack(CMotionTable*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, void**, uint, int>)0x00524460)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00524970
    /// void __thiscall CMotionTable::Destroy(CMotionTable*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, void>)0x00524970)(ref this);

    /// <summary>
    /// <code>Offset: 0x00524A90
    /// int __thiscall CMotionTable::DoObjectMotion(CMotionTable*,unsigned int,MotionState*,CSequence*,float,unsigned int*)</code>
    /// </summary>
    public int DoObjectMotion(uint motion, ACBindings.Internal.MotionState* curr_state, ACBindings.Internal.CSequence* sequence, float speed_mod, uint* num_anims) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, uint, ACBindings.Internal.MotionState*, ACBindings.Internal.CSequence*, float, uint*, int>)0x00524A90)(ref this, motion, curr_state, sequence, speed_mod, num_anims);

    /// <summary>
    /// <code>Offset: 0x00524AD0
    /// int __thiscall CMotionTable::StopObjectCompletely(CMotionTable*,MotionState*,CSequence*,unsigned int*)</code>
    /// </summary>
    public int StopObjectCompletely(ACBindings.Internal.MotionState* curr_state, ACBindings.Internal.CSequence* sequence, uint* num_anims) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, ACBindings.Internal.MotionState*, ACBindings.Internal.CSequence*, uint*, int>)0x00524AD0)(ref this, curr_state, sequence, num_anims);

    /// <summary>
    /// <code>Offset: 0x00524B50
    /// void __thiscall CMotionTable::~CMotionTable(CMotionTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, void>)0x00524B50)(ref this);
}

