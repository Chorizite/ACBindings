namespace ACBindings;

// MotionTableManager
public unsafe struct MotionTableManager : System.IDisposable
{
    // Child Types
    // MotionTableManager::AnimNode
    public unsafe struct AnimNode
    {
        // Base Classes
        public ACBindings.DLListData BaseClass_DLListData; // ACBindings.DLListData

        // Members
        public uint motion;
        public uint num_anims;

        // Methods
    }

    // Members
    public ACBindings.CPhysicsObj* physics_obj;
    public ACBindings.CMotionTable* table;
    public ACBindings.MotionState state;
    public int animation_counter;
    public ACBindings.DLList__MotionTableManager_AnimNode pending_animations;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // BOOL __thiscall MotionTableManager::SetMotionTableID(_DWORD*,int)
    public byte SetMotionTableID(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionTableManager, int, byte>)0x0051C700)(ref this, a2);
    // unsigned int* __thiscall MotionTableManager::GetMotionTableID(_DWORD*,unsigned int*)
    public uint* GetMotionTableID(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionTableManager, uint*, uint*>)0x0051C740)(ref this, a2);
    // _DWORD* __cdecl MotionTableManager::Create(int)
    public static int* Create(int a1) => ((delegate* unmanaged[Cdecl]<int, int*>)0x0051C780)(a1);
    // void __thiscall MotionTableManager::truncate_animation_list(MotionTableManager*,const MotionTableManager::AnimNode*,CSequence*)
    public void truncate_animation_list(ACBindings.MotionTableManager.AnimNode* node, ACBindings.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionTableManager, ACBindings.MotionTableManager.AnimNode*, ACBindings.CSequence*, void>)0x0051C7D0)(ref this, node, seq);
    // void __thiscall MotionTableManager::AnimationDone(MotionTableManager*,int)
    public void AnimationDone(int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionTableManager, int, void>)0x0051C810)(ref this, success);
    // void __thiscall MotionTableManager::HandleExitWorld(MotionTableManager*,CSequence*)
    public void HandleExitWorld(ACBindings.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionTableManager, ACBindings.CSequence*, void>)0x0051C8D0)(ref this, seq);
    // void __thiscall MotionTableManager::CheckForCompletedMotions(MotionTableManager*)
    public void CheckForCompletedMotions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionTableManager, void>)0x0051C900)(ref this);
    // void __thiscall MotionTableManager::Destroy(MotionTableManager*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionTableManager, void>)0x0051C990)(ref this);
    // void __thiscall MotionTableManager::~MotionTableManager(MotionTableManager*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionTableManager, void>)0x0051CA00)(ref this);
    // void __thiscall MotionTableManager::remove_redundant_links(MotionTableManager*,CSequence*)
    public void remove_redundant_links(ACBindings.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionTableManager, ACBindings.CSequence*, void>)0x0051CA20)(ref this, seq);
    // void __thiscall MotionTableManager::HandleEnterWorld(MotionTableManager*,CSequence*)
    public void HandleEnterWorld(ACBindings.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionTableManager, ACBindings.CSequence*, void>)0x0051CAD0)(ref this, seq);
    // void __thiscall MotionTableManager::add_to_queue(MotionTableManager*,unsigned int,unsigned int,CSequence*)
    public void add_to_queue(uint motion, uint num_anims, ACBindings.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionTableManager, uint, uint, ACBindings.CSequence*, void>)0x0051CB10)(ref this, motion, num_anims, seq);
    // void __thiscall MotionTableManager::initialize_state(MotionTableManager*,CSequence*)
    public void initialize_state(ACBindings.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionTableManager, ACBindings.CSequence*, void>)0x0051CB60)(ref this, seq);
    // unsigned int __thiscall MotionTableManager::PerformMovement(MotionTableManager*,const MovementStruct*,CSequence*)
    public uint PerformMovement(ACBindings.MovementStruct* ms, ACBindings.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionTableManager, ACBindings.MovementStruct*, ACBindings.CSequence*, uint>)0x0051CBE0)(ref this, ms, seq);
}

