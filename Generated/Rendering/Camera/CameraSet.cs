namespace ACBindings.Internal;

public unsafe struct CameraSet
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct CameraSet_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CameraSet*, void> CameraSet_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.CameraManager* cm;
    public ACBindings.Internal.SmartBox* sbox;
    public int looking_down;
    public int in_map_mode;
    public int mouselook_active;
    public int camera_movement_active;
    public int targeting;
    public int rot_left;
    public int rot_right;
    public int lower;
    public int raise;
    public int farther;
    public int closer;
    public float current_stiffness;
    public short mouselook_x_extent;
    public short mouselook_y_extent;
    public ACBindings.Internal.AC1Legacy.Vector3 lookdown_saved_offset;
    public ACBindings.Internal.AC1Legacy.Vector3 lookdown_saved_target_dir;
    public double m_ttLastRotate;
    public double m_ttLastRaiseOrLower;
    public double m_ttLastZoom;
    public double m_LastServerMessage;
    public double m_LastMouseMovement;

    // Generated Constructor
    public CameraSet(ACBindings.Internal.SmartBox* sbox) {
        _ConstructorInternal(sbox);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00455F60
    /// void __thiscall CameraSet::ToggleLookDown(CameraSet*)</code>
    /// </summary>
    public void ToggleLookDown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00455F60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00455F80
    /// void __thiscall CameraSet::ToggleMapMode(CameraSet*)</code>
    /// </summary>
    public void ToggleMapMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00455F80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00457510
    /// void __thiscall CameraSet::StopRotating(CameraSet*,int)</code>
    /// </summary>
    public void StopRotating(int formal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, void>)0x00457510)(ref this, formal);

    /// <summary>
    /// <code>Offset: 0x00457530
    /// void __thiscall CameraSet::StopRaising(CameraSet*)</code>
    /// </summary>
    public void StopRaising() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00457530)(ref this);

    /// <summary>
    /// <code>Offset: 0x00457540
    /// void __thiscall CameraSet::StopLowering(CameraSet*)</code>
    /// </summary>
    public void StopLowering() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00457540)(ref this);

    /// <summary>
    /// <code>Offset: 0x00457550
    /// void __thiscall CameraSet::StopCloser(CameraSet*)</code>
    /// </summary>
    public void StopCloser() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00457550)(ref this);

    /// <summary>
    /// <code>Offset: 0x00457560
    /// void __thiscall CameraSet::StopFarther(CameraSet*)</code>
    /// </summary>
    public void StopFarther() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00457560)(ref this);

    /// <summary>
    /// <code>Offset: 0x00457570
    /// int __thiscall CameraSet::InHead(CameraSet*,AC1Legacy::Vector3)</code>
    /// </summary>
    public int InHead(ACBindings.Internal.AC1Legacy.Vector3 camera_off) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, ACBindings.Internal.AC1Legacy.Vector3, int>)0x00457570)(ref this, camera_off);

    /// <summary>
    /// <code>Offset: 0x004575B0
    /// void __thiscall CameraSet::ToggleMouseLook(CameraSet*,int)</code>
    /// </summary>
    public void ToggleMouseLook(int mouse_on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, void>)0x004575B0)(ref this, mouse_on);

    /// <summary>
    /// <code>Offset: 0x00457650
    /// void __thiscall CameraSet::FilterMouseInput(CameraSet*,const float,const float,const float,float*,float*)</code>
    /// </summary>
    public void FilterMouseInput(float DeltaX, float DeltaY, float MouseSmoothingAmount, float* o_FilteredX, float* o_FilteredY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, float, float, float, float*, float*, void>)0x00457650)(ref this, DeltaX, DeltaY, MouseSmoothingAmount, o_FilteredX, o_FilteredY);

    /// <summary>
    /// <code>Offset: 0x004577A0
    /// int __thiscall CameraSet::InHead(CameraSet*)</code>
    /// </summary>
    public int InHead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int>)0x004577A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00457800
    /// void __thiscall CameraSet::SetTargetForOffset(CameraSet*,AC1Legacy::Vector3)</code>
    /// </summary>
    public void SetTargetForOffset(ACBindings.Internal.AC1Legacy.Vector3 camera_off) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, ACBindings.Internal.AC1Legacy.Vector3, void>)0x00457800)(ref this, camera_off);

    /// <summary>
    /// <code>Offset: 0x00457910
    /// void __thiscall CameraSet::SetStiffness(CameraSet*,float)</code>
    /// </summary>
    public void SetStiffness(float stiffness) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, float, void>)0x00457910)(ref this, stiffness);

    /// <summary>
    /// <code>Offset: 0x00457960
    /// void __thiscall CameraSet::SetScale(CameraSet*,float)</code>
    /// </summary>
    public void SetScale(float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, float, void>)0x00457960)(ref this, scale);

    /// <summary>
    /// <code>Offset: 0x00457AA0
    /// void __thiscall CameraSet::Raise(CameraSet*,int,float)</code>
    /// </summary>
    public void Raise(int keep_going, float i_fChangeModOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, float, void>)0x00457AA0)(ref this, keep_going, i_fChangeModOverride);

    /// <summary>
    /// <code>Offset: 0x00457E10
    /// void __thiscall CameraSet::Lower(CameraSet*,int,float)</code>
    /// </summary>
    public void Lower(int keep_going, float i_fChangeModOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, float, void>)0x00457E10)(ref this, keep_going, i_fChangeModOverride);

    /// <summary>
    /// <code>Offset: 0x00458110
    /// void __thiscall CameraSet::LookDown(CameraSet*,int)</code>
    /// </summary>
    public void LookDown(int look_down) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, void>)0x00458110)(ref this, look_down);

    /// <summary>
    /// <code>Offset: 0x004582F0
    /// void __thiscall CameraSet::SetMapMode(CameraSet*,int)</code>
    /// </summary>
    public void SetMapMode(int map_mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, void>)0x004582F0)(ref this, map_mode);

    /// <summary>
    /// <code>Offset: 0x004583A0
    /// void __thiscall CameraSet::TrackTarget(CameraSet*,unsigned int)</code>
    /// </summary>
    public void TrackTarget(uint gid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, uint, void>)0x004583A0)(ref this, gid);

    /// <summary>
    /// <code>Offset: 0x00458430
    /// void __thiscall CameraSet::Rotate(CameraSet*,int,int,float,int)</code>
    /// </summary>
    public void Rotate(int clockwise_dir, int keep_going, float i_fChangeModOverride, int camera_keys) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, int, float, int, void>)0x00458430)(ref this, clockwise_dir, keep_going, i_fChangeModOverride, camera_keys);

    /// <summary>
    /// <code>Offset: 0x004587F0
    /// void __thiscall CameraSet::Closer(CameraSet*,int,float)</code>
    /// </summary>
    public void Closer(int keep_going, float i_fChangeModOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, float, void>)0x004587F0)(ref this, keep_going, i_fChangeModOverride);

    /// <summary>
    /// <code>Offset: 0x004589B0
    /// void __thiscall CameraSet::Farther(CameraSet*,int,float)</code>
    /// </summary>
    public void Farther(int keep_going, float i_fChangeModOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, float, void>)0x004589B0)(ref this, keep_going, i_fChangeModOverride);

    /// <summary>
    /// <code>Offset: 0x00458C00
    /// void __thiscall CameraSet::UpdateCamera(CameraSet*)</code>
    /// </summary>
    public void UpdateCamera() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00458C00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00458E00
    /// void __thiscall CameraSet::SetInHead(CameraSet*)</code>
    /// </summary>
    public void SetInHead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00458E00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00458EA0
    /// void __thiscall CameraSet::MouseLookHandler(CameraSet*,int,int)</code>
    /// </summary>
    public void MouseLookHandler(int i_nXMove, int i_nYMove) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, int, void>)0x00458EA0)(ref this, i_nXMove, i_nYMove);

    /// <summary>
    /// <code>Offset: 0x004590A0
    /// void __thiscall CameraSet::SetDefaultOffsets(CameraSet*,int)</code>
    /// </summary>
    public void SetDefaultOffsets(int move_camera) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, void>)0x004590A0)(ref this, move_camera);

    /// <summary>
    /// <code>Offset: 0x004591E0
    /// void __thiscall CameraSet::CameraSet(CameraSet*,SmartBox*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.SmartBox* sbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, ACBindings.Internal.SmartBox*, void>)0x004591E0)(ref this, sbox);
}

