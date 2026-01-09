namespace ACBindings;

// CameraManager
public unsafe struct CameraManager : System.IDisposable
{
    // Base Classes
    public ACBindings.CInputHandler BaseClass_CInputHandler; // ACBindings.CInputHandler
    public ACBindings.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.IInputActionCallback

    // Child Types
    // CameraManager_vtbl
    public unsafe struct CameraManager_vtbl
    {
        // Members
        public System.IntPtr ActionHandler; // function pointer
        public System.IntPtr MouseMoveHandler; // function pointer
        public System.IntPtr MouseLookHandler; // function pointer
        public System.IntPtr FocusSwitchHandler; // function pointer
        public System.IntPtr CharacterHandler; // function pointer
        public System.IntPtr KeyHitHandler; // function pointer

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
    public ACBindings.AC1Legacy.Vector3 pivot_offset;
    public uint target_object_id;
    public int target_part_index;
    public ACBindings.AC1Legacy.Vector3 target_offset;
    public ACBindings.AC1Legacy.Vector3 direction;
    public ACBindings.CameraTarget target_status;
    public ACBindings.AC1Legacy.Vector3 viewer_offset;
    public byte m_bAlignCameraToSlope;
    public float m_rCameraStiffness;
    public float m_rCameraAdjustmentSpeed;
    public uint m_dwPivotOffsetMovement;
    public uint m_dwCameraOffsetMovement;
    public float m_rMovementSpeed;
    public float scale;
    public double last_update_time;
    public fixed byte old_velocities_Raw[60];
    public ACBindings.AC1Legacy.Vector3* old_velocities => (ACBindings.AC1Legacy.Vector3*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref old_velocities_Raw[0]);
    public int old_velocity_num;
    public byte m_bEnabled;
    public ACBindings.CameraSet* m_pCurrentCameraSet;

    // Generated Constructor
    public CameraManager() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CameraManager::ClearTarget(CameraManager*)
    public void ClearTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, void>)0x00455FA0)(ref this);
    // void __thiscall CameraManager::SetTarget(CameraManager*,CameraTarget)
    public void SetTarget(ACBindings.CameraTarget target) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, ACBindings.CameraTarget, void>)0x00455FB0)(ref this, target);
    // void __thiscall CameraManager::SetPivotObject(CameraManager*,unsigned int,int)
    public void SetPivotObject(uint object_id, int part_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, uint, int, void>)0x00455FC0)(ref this, object_id, part_index);
    // int __thiscall CameraManager::SetTranslationalStiffness(CameraManager*,float)
    public int SetTranslationalStiffness(float stiffness) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, float, int>)0x00455FE0)(ref this, stiffness);
    // int __thiscall CameraManager::SetRotationalStiffness(CameraManager*,float)
    public int SetRotationalStiffness(float stiffness) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, float, int>)0x00456020)(ref this, stiffness);
    // bool __thiscall CameraManager::OnAction(CameraManager*,const InputEvent*)
    public byte OnAction(ACBindings.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, ACBindings.InputEvent*, byte>)0x00456060)(ref this, i_evt);
    // void __thiscall CameraManager::MouseLookHandler(CameraManager*,int,int)
    public void MouseLookHandler(int i_nXMove, int i_nYMove) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, int, int, void>)0x00456260)(ref this, i_nXMove, i_nYMove);
    // void __thiscall CameraManager::ToggleMouseLook(CameraManager*,int)
    public void ToggleMouseLook(int camera_on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, int, void>)0x00456280)(ref this, camera_on);
    // void __thiscall CameraManager::~CameraManager(CameraManager*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, void>)0x004563A0)(ref this);
    // void __thiscall CameraManager::SetCameraSet(CameraManager*,CameraSet*)
    public void SetCameraSet(ACBindings.CameraSet* pCameraSet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, ACBindings.CameraSet*, void>)0x00456430)(ref this, pCameraSet);
    // void __thiscall CameraManager::SetTargetObject(CameraManager*,unsigned int,int)
    public void SetTargetObject(uint object_id, int part_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, uint, int, void>)0x004564A0)(ref this, object_id, part_index);
    // void __thiscall CameraManager::SetTargetDirection(CameraManager*,const AC1Legacy::Vector3*)
    public void SetTargetDirection(ACBindings.AC1Legacy.Vector3* dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, ACBindings.AC1Legacy.Vector3*, void>)0x004564C0)(ref this, dir);
    // AC1Legacy::Vector3* __thiscall CameraManager::FlagsToVector(CameraManager*,AC1Legacy::Vector3*,unsigned int)
    public ACBindings.AC1Legacy.Vector3* FlagsToVector(ACBindings.AC1Legacy.Vector3* result, uint flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, ACBindings.AC1Legacy.Vector3*, uint, ACBindings.AC1Legacy.Vector3*>)0x00456510)(ref this, result, flags);
    // void CameraManager::OnStiffnessChanged()
    public static void OnStiffnessChanged() => ((delegate* unmanaged[Cdecl]<void>)0x004565B0)();
    // int __thiscall CameraManager::QueryPivotPosition(CameraManager*,Position*)
    public int QueryPivotPosition(ACBindings.Position* pivot_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, ACBindings.Position*, int>)0x00456610)(ref this, pivot_position);
    // Position* __thiscall CameraManager::UpdateCamera(CameraManager*,Position*,const Position*)
    public ACBindings.Position* UpdateCamera(ACBindings.Position* result, ACBindings.Position* viewer_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, ACBindings.Position*, ACBindings.Position*, ACBindings.Position*>)0x00456780)(ref this, result, viewer_pos);
    // void __thiscall CameraManager::CameraManager(CameraManager*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, void>)0x004571B0)(ref this);
    // bool __thiscall CameraManager::SetStiffness(CameraManager*,float)
    public byte SetStiffness(float stiffness) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraManager, float, byte>)0x004574E0)(ref this, stiffness);
}

