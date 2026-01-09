namespace ACBindings;

// CMotionTable
public unsafe struct CMotionTable : System.IDisposable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // CMotionTable_vtbl
    public unsafe struct CMotionTable_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBObj_dtor_18; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr InitLoad; // function pointer
        public System.IntPtr GetSubObjects; // function pointer
        public System.IntPtr ReleaseSubObjects; // function pointer
        public System.IntPtr NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr Destroy; // function pointer
        public System.IntPtr FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public System.IntPtr GetDBOType; // function pointer
        public System.IntPtr Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public System.IntPtr ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.LongNIValHash__uint style_defaults;
    public ACBindings.LongHash__MotionData cycles;
    public ACBindings.LongHash__MotionData modifiers;
    public ACBindings.LongNIValHash__LongHash__MotionData_ptr links;
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
    // void __thiscall CMotionTable::CMotionTable(CMotionTable*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionTable, void>)0x004FA080)(ref this);
    // DBObj* __thiscall CMotionTable::Allocator(CMotionTable*)
    public ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionTable, ACBindings.DBObj*>)0x004FA280)(ref this);
    // void __thiscall CMotionTable::re_modify(CMotionTable*,CSequence*,MotionState*)
    public void re_modify(ACBindings.CSequence* sequence, ACBindings.MotionState* state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionTable, ACBindings.CSequence*, ACBindings.MotionState*, void>)0x00522E30)(ref this, sequence, state);
    // int __thiscall CMotionTable::is_allowed(CMotionTable*,unsigned int,const MotionData*,const MotionState*)
    public int is_allowed(uint motion, ACBindings.MotionData* mdata, ACBindings.MotionState* state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionTable, uint, ACBindings.MotionData*, ACBindings.MotionState*, int>)0x00523260)(ref this, motion, mdata, state);
    // MotionData* __thiscall CMotionTable::get_link(CMotionTable*,unsigned int,unsigned int,float,unsigned int,float)
    public ACBindings.MotionData* get_link(uint style, uint substate, float substate_speed, uint motion, float speed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionTable, uint, uint, float, uint, float, ACBindings.MotionData*>)0x005232B0)(ref this, style, substate, substate_speed, motion, speed);
    // int __thiscall CMotionTable::GetObjectSequence(CMotionTable*,unsigned int,MotionState*,CSequence*,float,unsigned int*,int)
    public int GetObjectSequence(uint motion, ACBindings.MotionState* curr_state, ACBindings.CSequence* sequence, float speed_mod, uint* num_anims, int stop_modifiers) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionTable, uint, ACBindings.MotionState*, ACBindings.CSequence*, float, uint*, int, int>)0x00523400)(ref this, motion, curr_state, sequence, speed_mod, num_anims, stop_modifiers);
    // int __thiscall CMotionTable::StopSequenceMotion(CMotionTable*,unsigned int,float,MotionState*,CSequence*,unsigned int*)
    public int StopSequenceMotion(uint motion, float speed, ACBindings.MotionState* curr_state, ACBindings.CSequence* sequence, uint* num_anims) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionTable, uint, float, ACBindings.MotionState*, ACBindings.CSequence*, uint*, int>)0x00523B60)(ref this, motion, speed, curr_state, sequence, num_anims);
    // int __thiscall CMotionTable::SetDefaultState(CMotionTable*,MotionState*,CSequence*,unsigned int*)
    public int SetDefaultState(ACBindings.MotionState* state, ACBindings.CSequence* sequence, uint* num_anims) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionTable, ACBindings.MotionState*, ACBindings.CSequence*, uint*, int>)0x00523C40)(ref this, state, sequence, num_anims);
    // unsigned int __thiscall CMotionTable::Pack(CMotionTable*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionTable, void**, uint, uint>)0x00523D20)(ref this, addr, size);
    // int __thiscall CMotionTable::UnPack(CMotionTable*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionTable, void**, uint, int>)0x00524460)(ref this, addr, size);
    // void __thiscall CMotionTable::Destroy(CMotionTable*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionTable, void>)0x00524970)(ref this);
    // int __thiscall CMotionTable::DoObjectMotion(CMotionTable*,unsigned int,MotionState*,CSequence*,float,unsigned int*)
    public int DoObjectMotion(uint motion, ACBindings.MotionState* curr_state, ACBindings.CSequence* sequence, float speed_mod, uint* num_anims) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionTable, uint, ACBindings.MotionState*, ACBindings.CSequence*, float, uint*, int>)0x00524A90)(ref this, motion, curr_state, sequence, speed_mod, num_anims);
    // int __thiscall CMotionTable::StopObjectCompletely(CMotionTable*,MotionState*,CSequence*,unsigned int*)
    public int StopObjectCompletely(ACBindings.MotionState* curr_state, ACBindings.CSequence* sequence, uint* num_anims) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionTable, ACBindings.MotionState*, ACBindings.CSequence*, uint*, int>)0x00524AD0)(ref this, curr_state, sequence, num_anims);
    // void __thiscall CMotionTable::~CMotionTable(CMotionTable*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionTable, void>)0x00524B50)(ref this);
}

