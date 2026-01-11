namespace ACBindings.Internal;

public unsafe struct CameraManager : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CInputHandler BaseClass_CInputHandler; // ACBindings.Internal.CInputHandler
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback

    // Child Types
    public unsafe struct CameraManager_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CameraManager*, ACBindings.Internal.InputEvent*, void> ActionHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CameraManager*, int, int, void> MouseMoveHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CameraManager*, int, int, void> MouseLookHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CameraManager*, byte, int, void> FocusSwitchHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CameraManager*, System.Char, void> CharacterHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CameraManager*, ACBindings.Internal.QualifiedControl*, uint*, byte> KeyHitHandler; // function pointer

        // Methods
    }
    // CameraManager::MovementDirectionFlags
    public enum MovementDirectionFlags : byte
    {
        mdf_Left = 0x1,
        mdf_Right = 0x2,
        mdf_XAxis = 0x3,
        mdf_Forward = 0x4,
        mdf_Backward = 0x8,
        mdf_YAxis = 0xC,
        mdf_Up = 0x10,
        mdf_Down = 0x20,
        mdf_ZAxis = 0x30
    }

    // Members
    public float t_stiffness;
    public float r_stiffness;
    public uint pivot_object_id;
    public int pivot_part_index;
    public ACBindings.Internal.AC1Legacy.Vector3 pivot_offset;
    public uint target_object_id;
    public int target_part_index;
    public ACBindings.Internal.AC1Legacy.Vector3 target_offset;
    public ACBindings.Internal.AC1Legacy.Vector3 direction;
    public ACBindings.Internal.CameraTarget target_status;
    public ACBindings.Internal.AC1Legacy.Vector3 viewer_offset;
    public byte m_bAlignCameraToSlope;
    public float m_rCameraStiffness;
    public float m_rCameraAdjustmentSpeed;
    public uint m_dwPivotOffsetMovement;
    public uint m_dwCameraOffsetMovement;
    public float m_rMovementSpeed;
    public float scale;
    public double last_update_time;
    public fixed byte old_velocities_Raw[60];
    public ACBindings.Internal.AC1Legacy.Vector3* old_velocities => (ACBindings.Internal.AC1Legacy.Vector3*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref old_velocities_Raw[0]);
    public int old_velocity_num;
    public byte m_bEnabled;
    public ACBindings.Internal.CameraSet* m_pCurrentCameraSet;

    // Generated Constructor
    public CameraManager() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00455FA0
    /// void __thiscall CameraManager::ClearTarget(CameraManager*)</code>
    /// </summary>
    public void ClearTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, void>)0x00455FA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00455FB0
    /// void __thiscall CameraManager::SetTarget(CameraManager*,CameraTarget)</code>
    /// </summary>
    public void SetTarget(ACBindings.Internal.CameraTarget target) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, ACBindings.Internal.CameraTarget, void>)0x00455FB0)(ref this, target);

    /// <summary>
    /// <code>Offset: 0x00455FC0
    /// void __thiscall CameraManager::SetPivotObject(CameraManager*,unsigned int,int)</code>
    /// </summary>
    public void SetPivotObject(uint object_id, int part_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, uint, int, void>)0x00455FC0)(ref this, object_id, part_index);

    /// <summary>
    /// <code>Offset: 0x00455FE0
    /// int __thiscall CameraManager::SetTranslationalStiffness(CameraManager*,float)</code>
    /// </summary>
    public int SetTranslationalStiffness(float stiffness) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, float, int>)0x00455FE0)(ref this, stiffness);

    /// <summary>
    /// <code>Offset: 0x00456020
    /// int __thiscall CameraManager::SetRotationalStiffness(CameraManager*,float)</code>
    /// </summary>
    public int SetRotationalStiffness(float stiffness) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, float, int>)0x00456020)(ref this, stiffness);

    /// <summary>
    /// <code>Offset: 0x00456060
    /// bool __thiscall CameraManager::OnAction(CameraManager*,const InputEvent*)</code>
    /// </summary>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, ACBindings.Internal.InputEvent*, byte>)0x00456060)(ref this, i_evt);

    /// <summary>
    /// <code>Offset: 0x00456260
    /// void __thiscall CameraManager::MouseLookHandler(CameraManager*,int,int)</code>
    /// </summary>
    public void MouseLookHandler(int i_nXMove, int i_nYMove) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, int, int, void>)0x00456260)(ref this, i_nXMove, i_nYMove);

    /// <summary>
    /// <code>Offset: 0x00456280
    /// void __thiscall CameraManager::ToggleMouseLook(CameraManager*,int)</code>
    /// </summary>
    public void ToggleMouseLook(int camera_on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, int, void>)0x00456280)(ref this, camera_on);

    /// <summary>
    /// <code>Offset: 0x004563A0
    /// void __thiscall CameraManager::~CameraManager(CameraManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, void>)0x004563A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00456430
    /// void __thiscall CameraManager::SetCameraSet(CameraManager*,CameraSet*)</code>
    /// </summary>
    public void SetCameraSet(ACBindings.Internal.CameraSet* pCameraSet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, ACBindings.Internal.CameraSet*, void>)0x00456430)(ref this, pCameraSet);

    /// <summary>
    /// <code>Offset: 0x004564A0
    /// void __thiscall CameraManager::SetTargetObject(CameraManager*,unsigned int,int)</code>
    /// </summary>
    public void SetTargetObject(uint object_id, int part_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, uint, int, void>)0x004564A0)(ref this, object_id, part_index);

    /// <summary>
    /// <code>Offset: 0x004564C0
    /// void __thiscall CameraManager::SetTargetDirection(CameraManager*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void SetTargetDirection(ACBindings.Internal.AC1Legacy.Vector3* dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x004564C0)(ref this, dir);

    /// <summary>
    /// <code>Offset: 0x00456510
    /// AC1Legacy::Vector3* __thiscall CameraManager::FlagsToVector(CameraManager*,AC1Legacy::Vector3*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* FlagsToVector(ACBindings.Internal.AC1Legacy.Vector3* result, uint flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, ACBindings.Internal.AC1Legacy.Vector3*, uint, ACBindings.Internal.AC1Legacy.Vector3*>)0x00456510)(ref this, result, flags);

    /// <summary>
    /// <code>Offset: 0x004565B0
    /// void CameraManager::OnStiffnessChanged()</code>
    /// </summary>
    public static void OnStiffnessChanged() => ((delegate* unmanaged[Cdecl]<void>)0x004565B0)();

    /// <summary>
    /// <code>Offset: 0x00456610
    /// int __thiscall CameraManager::QueryPivotPosition(CameraManager*,Position*)</code>
    /// </summary>
    public int QueryPivotPosition(ACBindings.Internal.Position* pivot_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, ACBindings.Internal.Position*, int>)0x00456610)(ref this, pivot_position);

    /// <summary>
    /// <code>Offset: 0x00456780
    /// Position* __thiscall CameraManager::UpdateCamera(CameraManager*,Position*,const Position*)</code>
    /// </summary>
    public ACBindings.Internal.Position* UpdateCamera(ACBindings.Internal.Position* result, ACBindings.Internal.Position* viewer_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, ACBindings.Internal.Position*, ACBindings.Internal.Position*, ACBindings.Internal.Position*>)0x00456780)(ref this, result, viewer_pos);

    /// <summary>
    /// <code>Offset: 0x004571B0
    /// void __thiscall CameraManager::CameraManager(CameraManager*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, void>)0x004571B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004574E0
    /// bool __thiscall CameraManager::SetStiffness(CameraManager*,float)</code>
    /// </summary>
    public byte SetStiffness(float stiffness) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, float, byte>)0x004574E0)(ref this, stiffness);
}

