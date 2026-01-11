namespace ACBindings.Internal;

public unsafe struct MotionTableManager : System.IDisposable
{
    // Child Types
    public unsafe struct AnimNode
    {
        // Base Classes
        public ACBindings.Internal.DLListData BaseClass_DLListData; // ACBindings.Internal.DLListData

        // Members
        public uint motion;
        public uint num_anims;

        // Methods
    }

    // Members
    public ACBindings.Internal.CPhysicsObj* physics_obj;
    public ACBindings.Internal.CMotionTable* table;
    public ACBindings.Internal.MotionState state;
    public int animation_counter;
    public ACBindings.Internal.DLList___MotionTableManager_AnimNode pending_animations;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0051C700
    /// BOOL __thiscall MotionTableManager::SetMotionTableID(_DWORD*,int)</code>
    /// </summary>
    public byte SetMotionTableID(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, int, byte>)0x0051C700)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0051C740
    /// unsigned int* __thiscall MotionTableManager::GetMotionTableID(_DWORD*,unsigned int*)</code>
    /// </summary>
    public uint* GetMotionTableID(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, uint*, uint*>)0x0051C740)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0051C780
    /// _DWORD* __cdecl MotionTableManager::Create(int)</code>
    /// </summary>
    public static int* Create(int a1) => ((delegate* unmanaged[Cdecl]<int, int*>)0x0051C780)(a1);

    /// <summary>
    /// <code>Offset: 0x0051C7D0
    /// void __thiscall MotionTableManager::truncate_animation_list(MotionTableManager*,const MotionTableManager::AnimNode*,CSequence*)</code>
    /// </summary>
    public void truncate_animation_list(ACBindings.Internal.MotionTableManager.AnimNode* node, ACBindings.Internal.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, ACBindings.Internal.MotionTableManager.AnimNode*, ACBindings.Internal.CSequence*, void>)0x0051C7D0)(ref this, node, seq);

    /// <summary>
    /// <code>Offset: 0x0051C810
    /// void __thiscall MotionTableManager::AnimationDone(MotionTableManager*,int)</code>
    /// </summary>
    public void AnimationDone(int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, int, void>)0x0051C810)(ref this, success);

    /// <summary>
    /// <code>Offset: 0x0051C8D0
    /// void __thiscall MotionTableManager::HandleExitWorld(MotionTableManager*,CSequence*)</code>
    /// </summary>
    public void HandleExitWorld(ACBindings.Internal.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, ACBindings.Internal.CSequence*, void>)0x0051C8D0)(ref this, seq);

    /// <summary>
    /// <code>Offset: 0x0051C900
    /// void __thiscall MotionTableManager::CheckForCompletedMotions(MotionTableManager*)</code>
    /// </summary>
    public void CheckForCompletedMotions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, void>)0x0051C900)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051C990
    /// void __thiscall MotionTableManager::Destroy(MotionTableManager*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, void>)0x0051C990)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051CA00
    /// void __thiscall MotionTableManager::~MotionTableManager(MotionTableManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, void>)0x0051CA00)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051CA20
    /// void __thiscall MotionTableManager::remove_redundant_links(MotionTableManager*,CSequence*)</code>
    /// </summary>
    public void remove_redundant_links(ACBindings.Internal.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, ACBindings.Internal.CSequence*, void>)0x0051CA20)(ref this, seq);

    /// <summary>
    /// <code>Offset: 0x0051CAD0
    /// void __thiscall MotionTableManager::HandleEnterWorld(MotionTableManager*,CSequence*)</code>
    /// </summary>
    public void HandleEnterWorld(ACBindings.Internal.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, ACBindings.Internal.CSequence*, void>)0x0051CAD0)(ref this, seq);

    /// <summary>
    /// <code>Offset: 0x0051CB10
    /// void __thiscall MotionTableManager::add_to_queue(MotionTableManager*,unsigned int,unsigned int,CSequence*)</code>
    /// </summary>
    public void add_to_queue(uint motion, uint num_anims, ACBindings.Internal.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, uint, uint, ACBindings.Internal.CSequence*, void>)0x0051CB10)(ref this, motion, num_anims, seq);

    /// <summary>
    /// <code>Offset: 0x0051CB60
    /// void __thiscall MotionTableManager::initialize_state(MotionTableManager*,CSequence*)</code>
    /// </summary>
    public void initialize_state(ACBindings.Internal.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, ACBindings.Internal.CSequence*, void>)0x0051CB60)(ref this, seq);

    /// <summary>
    /// <code>Offset: 0x0051CBE0
    /// unsigned int __thiscall MotionTableManager::PerformMovement(MotionTableManager*,const MovementStruct*,CSequence*)</code>
    /// </summary>
    public uint PerformMovement(ACBindings.Internal.MovementStruct* ms, ACBindings.Internal.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, ACBindings.Internal.MovementStruct*, ACBindings.Internal.CSequence*, uint>)0x0051CBE0)(ref this, ms, seq);
}

