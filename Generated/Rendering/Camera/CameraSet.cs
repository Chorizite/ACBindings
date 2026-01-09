namespace ACBindings;

// CameraSet
public unsafe struct CameraSet
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // CameraSet_vtbl
    public unsafe struct CameraSet_vtbl
    {
        // Members
        public System.IntPtr CameraSet_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.CameraManager* cm;
    public ACBindings.SmartBox* sbox;
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
    public ACBindings.AC1Legacy.Vector3 lookdown_saved_offset;
    public ACBindings.AC1Legacy.Vector3 lookdown_saved_target_dir;
    public double m_ttLastRotate;
    public double m_ttLastRaiseOrLower;
    public double m_ttLastZoom;
    public double m_LastServerMessage;
    public double m_LastMouseMovement;

    // Generated Constructor
    public CameraSet(ACBindings.SmartBox* sbox) {
        _ConstructorInternal(sbox);
    }

    // Methods
    // void __thiscall CameraSet::ToggleLookDown(CameraSet*)
    public void ToggleLookDown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, void>)0x00455F60)(ref this);
    // void __thiscall CameraSet::ToggleMapMode(CameraSet*)
    public void ToggleMapMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, void>)0x00455F80)(ref this);
    // void __thiscall CameraSet::StopRotating(CameraSet*,int)
    public void StopRotating(int formal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, int, void>)0x00457510)(ref this, formal);
    // void __thiscall CameraSet::StopRaising(CameraSet*)
    public void StopRaising() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, void>)0x00457530)(ref this);
    // void __thiscall CameraSet::StopLowering(CameraSet*)
    public void StopLowering() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, void>)0x00457540)(ref this);
    // void __thiscall CameraSet::StopCloser(CameraSet*)
    public void StopCloser() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, void>)0x00457550)(ref this);
    // void __thiscall CameraSet::StopFarther(CameraSet*)
    public void StopFarther() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, void>)0x00457560)(ref this);
    // int __thiscall CameraSet::InHead(CameraSet*,AC1Legacy::Vector3)
    public int InHead(ACBindings.AC1Legacy.Vector3 camera_off) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, ACBindings.AC1Legacy.Vector3, int>)0x00457570)(ref this, camera_off);
    // void __thiscall CameraSet::ToggleMouseLook(CameraSet*,int)
    public void ToggleMouseLook(int mouse_on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, int, void>)0x004575B0)(ref this, mouse_on);
    // void __thiscall CameraSet::FilterMouseInput(CameraSet*,const float,const float,const float,float*,float*)
    public void FilterMouseInput(float DeltaX, float DeltaY, float MouseSmoothingAmount, float* o_FilteredX, float* o_FilteredY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, float, float, float, float*, float*, void>)0x00457650)(ref this, DeltaX, DeltaY, MouseSmoothingAmount, o_FilteredX, o_FilteredY);
    // int __thiscall CameraSet::InHead(CameraSet*)
    public int InHead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, int>)0x004577A0)(ref this);
    // void __thiscall CameraSet::SetTargetForOffset(CameraSet*,AC1Legacy::Vector3)
    public void SetTargetForOffset(ACBindings.AC1Legacy.Vector3 camera_off) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, ACBindings.AC1Legacy.Vector3, void>)0x00457800)(ref this, camera_off);
    // void __thiscall CameraSet::SetStiffness(CameraSet*,float)
    public void SetStiffness(float stiffness) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, float, void>)0x00457910)(ref this, stiffness);
    // void __thiscall CameraSet::SetScale(CameraSet*,float)
    public void SetScale(float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, float, void>)0x00457960)(ref this, scale);
    // void __thiscall CameraSet::Raise(CameraSet*,int,float)
    public void Raise(int keep_going, float i_fChangeModOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, int, float, void>)0x00457AA0)(ref this, keep_going, i_fChangeModOverride);
    // void __thiscall CameraSet::Lower(CameraSet*,int,float)
    public void Lower(int keep_going, float i_fChangeModOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, int, float, void>)0x00457E10)(ref this, keep_going, i_fChangeModOverride);
    // void __thiscall CameraSet::LookDown(CameraSet*,int)
    public void LookDown(int look_down) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, int, void>)0x00458110)(ref this, look_down);
    // void __thiscall CameraSet::SetMapMode(CameraSet*,int)
    public void SetMapMode(int map_mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, int, void>)0x004582F0)(ref this, map_mode);
    // void __thiscall CameraSet::TrackTarget(CameraSet*,unsigned int)
    public void TrackTarget(uint gid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, uint, void>)0x004583A0)(ref this, gid);
    // void __thiscall CameraSet::Rotate(CameraSet*,int,int,float,int)
    public void Rotate(int clockwise_dir, int keep_going, float i_fChangeModOverride, int camera_keys) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, int, int, float, int, void>)0x00458430)(ref this, clockwise_dir, keep_going, i_fChangeModOverride, camera_keys);
    // void __thiscall CameraSet::Closer(CameraSet*,int,float)
    public void Closer(int keep_going, float i_fChangeModOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, int, float, void>)0x004587F0)(ref this, keep_going, i_fChangeModOverride);
    // void __thiscall CameraSet::Farther(CameraSet*,int,float)
    public void Farther(int keep_going, float i_fChangeModOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, int, float, void>)0x004589B0)(ref this, keep_going, i_fChangeModOverride);
    // void __thiscall CameraSet::UpdateCamera(CameraSet*)
    public void UpdateCamera() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, void>)0x00458C00)(ref this);
    // void __thiscall CameraSet::SetInHead(CameraSet*)
    public void SetInHead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, void>)0x00458E00)(ref this);
    // void __thiscall CameraSet::MouseLookHandler(CameraSet*,int,int)
    public void MouseLookHandler(int i_nXMove, int i_nYMove) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, int, int, void>)0x00458EA0)(ref this, i_nXMove, i_nYMove);
    // void __thiscall CameraSet::SetDefaultOffsets(CameraSet*,int)
    public void SetDefaultOffsets(int move_camera) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, int, void>)0x004590A0)(ref this, move_camera);
    // void __thiscall CameraSet::CameraSet(CameraSet*,SmartBox*)
    public void _ConstructorInternal(ACBindings.SmartBox* sbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CameraSet, ACBindings.SmartBox*, void>)0x004591E0)(ref this, sbox);
}

