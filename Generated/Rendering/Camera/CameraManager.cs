namespace ACBindings.Internal;


/// <summary>CameraManager encapsulates camera positioning, orientation, and smoothing logic within the game engine.</summary>
/// <remarks>It processes user input, tracks targets and pivots, aligns the view to terrain slopes, and manages stiffness parameters for smooth transitions.</remarks>
public unsafe struct CameraManager : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CInputHandler BaseClass_CInputHandler; // ACBindings.Internal.CInputHandler
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback

    // Child Types
    public unsafe struct CameraManager_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CameraManager*, ACBindings.Internal.InputEvent*, void> ActionHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CameraManager*, int, int, void> MouseMoveHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CameraManager*, int, int, void> MouseLookHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CameraManager*, byte, int, void> FocusSwitchHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CameraManager*, System.Char, void> CharacterHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CameraManager*, ACBindings.Internal.QualifiedControl*, uint*, byte> KeyHitHandler; // function pointer

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

    /// <summary>Clears the current camera target by setting its status to INVALID_TARGET.
    /// <code>Offset: 0x00455FA0
    /// void __thiscall CameraManager::ClearTarget(CameraManager*)</code>
    /// </summary>
    public void ClearTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, void>)0x00455FA0)(ref this);

    /// <summary>Sets one or more camera target flags on the manager.
    /// <code>Offset: 0x00455FB0
    /// void __thiscall CameraManager::SetTarget(CameraManager*,CameraTarget)</code>
    /// </summary>
    /// <param name="target">Bitmask indicating which target statuses to activate.</param>
    public void SetTarget(ACBindings.Internal.CameraTarget target) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, ACBindings.Internal.CameraTarget, void>)0x00455FB0)(ref this, target);

    /// <summary>Sets the camera pivot to the specified object and records which part of that object the camera should use.
    /// <code>Offset: 0x00455FC0
    /// void __thiscall CameraManager::SetPivotObject(CameraManager*,unsigned int,int)</code>
    /// </summary>
    /// <param name="object_id">Identifier of the object to become the pivot.</param>
    /// <param name="part_index">Index of the object's part used as the pivot point; negative values may indicate no specific part.</param>
    public void SetPivotObject(uint object_id, int part_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, uint, int, void>)0x00455FC0)(ref this, object_id, part_index);

    /// <summary>
    /// Sets the camera's translational stiffness when the supplied value lies within [0, 1]; otherwise leaves it unchanged.
    /// 
    /// <code>Offset: 0x00455FE0
    /// int __thiscall CameraManager::SetTranslationalStiffness(CameraManager*,float)</code>
    /// </summary>
    /// <param name="stiffness">The desired stiffness value for camera translation, constrained to the range [0, 1].</param>
    /// <returns>1 if the stiffness was accepted and stored; 0 if the input was out of bounds.</returns>
    public int SetTranslationalStiffness(float stiffness) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, float, int>)0x00455FE0)(ref this, stiffness);

    /// <summary>Sets the camera’s rotational stiffness when the supplied value lies within the valid range of 0 to 1.
    /// <code>Offset: 0x00456020
    /// int __thiscall CameraManager::SetRotationalStiffness(CameraManager*,float)</code>
    /// </summary>
    /// <param name="stiffness">The desired rotational stiffness; must be between 0 and 1 inclusive.</param>
    /// <returns>Returns 1 if the stiffness was accepted, or 0 if the input is outside the allowed bounds.</returns>
    public int SetRotationalStiffness(float stiffness) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, float, int>)0x00456020)(ref this, stiffness);

    /// <summary>
    /// Processes input events related to camera controls, adjusting zoom, rotation, elevation, and toggling modes based on the event's action code.
    /// 
    /// <code>Offset: 0x00456060
    /// bool __thiscall CameraManager::OnAction(CameraManager*,const InputEvent*)</code>
    /// </summary>
    /// <param name="i_evt">
    /// An InputEvent describing the user's action; used to determine which camera operation to perform.
    /// </param>
    /// <returns>True if the event was recognized as a camera control action and processed; otherwise false.</returns>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, ACBindings.Internal.InputEvent*, byte>)0x00456060)(ref this, i_evt);

    /// <summary>Handles mouse look input by delegating to the current camera set's handler when a camera set is active.
    /// <code>Offset: 0x00456260
    /// void __thiscall CameraManager::MouseLookHandler(CameraManager*,int,int)</code>
    /// </summary>
    /// <param name="i_nXMove">Horizontal mouse movement delta.</param>
    /// <param name="i_nYMove">Vertical mouse movement delta.</param>
    public void MouseLookHandler(int i_nXMove, int i_nYMove) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, int, int, void>)0x00456260)(ref this, i_nXMove, i_nYMove);

    /// <summary>Switches the mouse‑look setting of the current camera set according to the supplied flag.
    /// <code>Offset: 0x00456280
    /// void __thiscall CameraManager::ToggleMouseLook(CameraManager*,int)</code>
    /// </summary>
    /// <param name="camera_on">Non‑zero value enables mouse look; zero disables it.</param>
    public void ToggleMouseLook(int camera_on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, int, void>)0x00456280)(ref this, camera_on);

    /// <summary>Destroys a CameraManager instance, releasing its current camera set, decrementing reference counts, unregistering global registry variables, and notifying any associated input system.
    /// <code>Offset: 0x004563A0
    /// void __thiscall CameraManager::~CameraManager(CameraManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, void>)0x004563A0)(ref this);

    /// <summary>Assigns a new camera set to the manager, updating references and applying current stiffness values.
    /// <code>Offset: 0x00456430
    /// void __thiscall CameraManager::SetCameraSet(CameraManager*,CameraSet*)</code>
    /// </summary>
    /// <param name="pCameraSet">The camera set instance to become active; may be null to clear the current set.</param>
    public void SetCameraSet(ACBindings.Internal.CameraSet* pCameraSet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, ACBindings.Internal.CameraSet*, void>)0x00456430)(ref this, pCameraSet);

    /// <summary>Updates camera's target to specified object and part, setting status to look at that target.
    /// <code>Offset: 0x004564A0
    /// void __thiscall CameraManager::SetTargetObject(CameraManager*,unsigned int,int)</code>
    /// </summary>
    /// <param name="object_id">The identifier of the target object.</param>
    /// <param name="part_index">The index of a specific part within the target object.</param>
    public void SetTargetObject(uint object_id, int part_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, uint, int, void>)0x004564A0)(ref this, object_id, part_index);

    /// <summary>Assigns a normalized direction for the camera’s target from the supplied vector, ignoring vectors that are too close to zero.
    /// <code>Offset: 0x004564C0
    /// void __thiscall CameraManager::SetTargetDirection(CameraManager*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="dir">The desired direction; copied and normalized internally if its length is above a small threshold.</param>
    public void SetTargetDirection(ACBindings.Internal.AC1Legacy.Vector3* dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x004564C0)(ref this, dir);

    /// <summary>Converts flag bits into a directional vector based on the CameraManager's current movement speed.
    /// <code>Offset: 0x00456510
    /// AC1Legacy::Vector3* __thiscall CameraManager::FlagsToVector(CameraManager*,AC1Legacy::Vector3*,unsigned int)</code>
    /// </summary>
    /// <param name="result">Pointer to a Vector3 that receives the resulting components.</param>
    /// <param name="flags">Bitmask controlling the sign of each axis: bit 0 for negative X, bit 1 for positive X; bits 2-3 for Y (4 and 8); bits 4-5 for Z (16 and 32). Unset flags leave the corresponding component zero.</param>
    /// <returns>Returns the supplied result pointer after it has been populated.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* FlagsToVector(ACBindings.Internal.AC1Legacy.Vector3* result, uint flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, ACBindings.Internal.AC1Legacy.Vector3*, uint, ACBindings.Internal.AC1Legacy.Vector3*>)0x00456510)(ref this, result, flags);

    /// <summary>Propagates updated camera stiffness from the global SmartBox configuration to the current CameraSet.
    /// <code>Offset: 0x004565B0
    /// void CameraManager::OnStiffnessChanged()</code>
    /// </summary>
    public static void OnStiffnessChanged() => ((delegate* unmanaged[Cdecl]<void>)0x004565B0)();

    /// <summary>Computes the world-space pivot location for the camera based on its configured pivot object, part, and offset, storing the result in the supplied Position structure.
    /// <code>Offset: 0x00456610
    /// int __thiscall CameraManager::QueryPivotPosition(CameraManager*,Position*)</code>
    /// </summary>
    /// <param name="pivot_position">Output parameter that receives the calculated position (object ID, cell ID, frame).</param>
    /// <returns>Non-zero if the pivot position was successfully retrieved; otherwise zero.</returns>
    public int QueryPivotPosition(ACBindings.Internal.Position* pivot_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, ACBindings.Internal.Position*, int>)0x00456610)(ref this, pivot_position);

    /// <summary>Updates the camera's transform using target and pivot objects, offsets, alignment to slope, and stiffness parameters; if disabled, copies the viewer position unchanged.
    /// <code>Offset: 0x00456780
    /// Position* __thiscall CameraManager::UpdateCamera(CameraManager*,Position*,const Position*)</code>
    /// </summary>
    /// <param name="result">Output Position structure that receives the updated camera transform.</param>
    /// <param name="viewer_pos">Current camera view position used as a reference for computing new transforms.</param>
    /// <returns>Pointer to the updated Position instance (the same as the 'result' parameter).</returns>
    public ACBindings.Internal.Position* UpdateCamera(ACBindings.Internal.Position* result, ACBindings.Internal.Position* viewer_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, ACBindings.Internal.Position*, ACBindings.Internal.Position*, ACBindings.Internal.Position*>)0x00456780)(ref this, result, viewer_pos);

    /// <summary>Initializes a CameraManager instance by setting default camera parameters, preparing internal state, registering camera configuration variables with the global registry, and subscribing to relevant input actions for camera control.
    /// <code>Offset: 0x004571B0
    /// void __thiscall CameraManager::CameraManager(CameraManager*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, void>)0x004571B0)(ref this);

    /// <summary>Sets the camera’s translational and rotational stiffness to the specified value for consistent movement behavior.
    /// <code>Offset: 0x004574E0
    /// bool __thiscall CameraManager::SetStiffness(CameraManager*,float)</code>
    /// </summary>
    /// <param name="stiffness">The desired stiffness level applied to both translation and rotation of the camera.</param>
    /// <returns>True if both the translational and rotational stiffness were set successfully; otherwise, false.</returns>
    public byte SetStiffness(float stiffness) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraManager, float, byte>)0x004574E0)(ref this, stiffness);
}

