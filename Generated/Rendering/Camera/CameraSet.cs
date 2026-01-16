namespace ACBindings.Internal;


/// <summary>Manages camera behavior for a player character, maintaining offsets, targets, stiffness, and state flags for rotation, zoom, and look‑down modes. Handles updates per frame and interacts with the game's camera manager to apply user input and system events.</summary>
public unsafe struct CameraSet
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct CameraSet_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CameraSet*, void> CameraSet_dtor_0; // function pointer

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

    /// <summary>Switches the camera’s look‑down state, enabling look down when currently inactive and disabling it otherwise.
    /// <code>Offset: 0x00455F60
    /// void __thiscall CameraSet::ToggleLookDown(CameraSet*)</code>
    /// </summary>
    public void ToggleLookDown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00455F60)(ref this);

    /// <summary>Toggles between normal and map view modes, updating the camera’s internal state accordingly.
    /// <code>Offset: 0x00455F80
    /// void __thiscall CameraSet::ToggleMapMode(CameraSet*)</code>
    /// </summary>
    public void ToggleMapMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00455F80)(ref this);

    /// <summary>Stops any active camera rotation by clearing left/right flags and resetting the last rotate timestamp.
    /// <code>Offset: 0x00457510
    /// void __thiscall CameraSet::StopRotating(CameraSet*,int)</code>
    /// </summary>
    public void StopRotating(int formal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, void>)0x00457510)(ref this, formal);

    /// <summary>Stops any ongoing camera raise operation by clearing the raise flag and resetting the raise‑or‑lower timestamp.
    /// <code>Offset: 0x00457530
    /// void __thiscall CameraSet::StopRaising(CameraSet*)</code>
    /// </summary>
    public void StopRaising() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00457530)(ref this);

    /// <summary>Halts camera lowering by clearing the lower flag and resetting its timestamp.
    /// <code>Offset: 0x00457540
    /// void __thiscall CameraSet::StopLowering(CameraSet*)</code>
    /// </summary>
    public void StopLowering() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00457540)(ref this);

    /// <summary>Stops any ongoing camera zoom‑in action by clearing the closer flag and resetting the last zoom timestamp.
    /// <code>Offset: 0x00457550
    /// void __thiscall CameraSet::StopCloser(CameraSet*)</code>
    /// </summary>
    public void StopCloser() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00457550)(ref this);

    /// <summary>Halts ongoing camera movement toward a farther distance, clearing the active flag and resetting the zoom timer.
    /// <code>Offset: 0x00457560
    /// void __thiscall CameraSet::StopFarther(CameraSet*)</code>
    /// </summary>
    public void StopFarther() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00457560)(ref this);

    /// <summary>Determines whether the supplied camera offset matches the predefined head offset (0, 0.18, 0).
    /// <code>Offset: 0x00457570
    /// int __thiscall CameraSet::InHead(CameraSet*,AC1Legacy::Vector3)</code>
    /// </summary>
    /// <param name="camera_off">Vector indicating camera offset relative to player.</param>
    /// <returns>Non‑zero if camera_off equals the head offset; zero otherwise.</returns>
    public int InHead(ACBindings.Internal.AC1Legacy.Vector3 camera_off) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, ACBindings.Internal.AC1Legacy.Vector3, int>)0x00457570)(ref this, camera_off);

    /// <summary>Toggles mouse‑look mode for the camera, updating internal flags and resetting movement extents when enabled, then notifies the command interpreter of the state change.
    /// <code>Offset: 0x004575B0
    /// void __thiscall CameraSet::ToggleMouseLook(CameraSet*,int)</code>
    /// </summary>
    /// <param name="mouse_on">Non‑zero to enable mouse look; zero to disable it.</param>
    public void ToggleMouseLook(int mouse_on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, void>)0x004575B0)(ref this, mouse_on);

    /// <summary>Applies time‑based smoothing to mouse movement deltas, averaging recent values when input occurs quickly and producing smoothed X and Y outputs.
    /// <code>Offset: 0x00457650
    /// void __thiscall CameraSet::FilterMouseInput(CameraSet*,const float,const float,const float,float*,float*)</code>
    /// </summary>
    /// <param name="DeltaX">Raw horizontal mouse delta.</param>
    /// <param name="DeltaY">Raw vertical mouse delta.</param>
    /// <param name="MouseSmoothingAmount">Blending factor between current and previous delta (0 = no smoothing, 1 = full smoothing).</param>
    /// <param name="o_FilteredX">Pointer to receive the smoothed horizontal delta.</param>
    /// <param name="o_FilteredY">Pointer to receive the smoothed vertical delta.</param>
    public void FilterMouseInput(float DeltaX, float DeltaY, float MouseSmoothingAmount, float* o_FilteredX, float* o_FilteredY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, float, float, float, float*, float*, void>)0x00457650)(ref this, DeltaX, DeltaY, MouseSmoothingAmount, o_FilteredX, o_FilteredY);

    /// <summary>Determines if the camera's viewer offset corresponds to the default in‑head position.
    /// <code>Offset: 0x004577A0
    /// int __thiscall CameraSet::InHead(CameraSet*)</code>
    /// </summary>
    /// <returns>Non‑zero when the viewer offset equals (0, 0.18, 0); otherwise zero.</returns>
    public int InHead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int>)0x004577A0)(ref this);

    /// <summary>Sets the camera's target mode based on the supplied offset vector and internal state flags, clearing any existing target before selecting a new one.
    /// <code>Offset: 0x00457800
    /// void __thiscall CameraSet::SetTargetForOffset(CameraSet*,AC1Legacy::Vector3)</code>
    /// </summary>
    /// <param name="camera_off">Vector offset used to determine which camera target behaviour to apply.</param>
    public void SetTargetForOffset(ACBindings.Internal.AC1Legacy.Vector3 camera_off) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, ACBindings.Internal.AC1Legacy.Vector3, void>)0x00457800)(ref this, camera_off);

    /// <summary>Adjusts the camera's current stiffness and applies it to either rotational or both translational and rotational components depending on whether a head view is active.
    /// <code>Offset: 0x00457910
    /// void __thiscall CameraSet::SetStiffness(CameraSet*,float)</code>
    /// </summary>
    /// <param name="stiffness">The new stiffness value for the camera, influencing how quickly it reacts to changes in orientation or position.</param>
    public void SetStiffness(float stiffness) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, float, void>)0x00457910)(ref this, stiffness);

    /// <summary>Adjusts the camera's scaling factor, recalculates its viewer offset accordingly, and restores translational and rotational stiffness parameters.
    /// <code>Offset: 0x00457960
    /// void __thiscall CameraSet::SetScale(CameraSet*,float)</code>
    /// </summary>
    /// <param name="scale">The new desired scale factor to apply to the camera.</param>
    public void SetScale(float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, float, void>)0x00457960)(ref this, scale);

    /// <summary>Raises the camera view over time by moving its offset and target direction. When the player is looking downward the camera lowers a fixed amount; otherwise it adjusts heading and pitch gradually based on an elapsed‑time speed that can be overridden.
    /// <code>Offset: 0x00457AA0
    /// void __thiscall CameraSet::Raise(CameraSet*,int,float)</code>
    /// </summary>
    /// <param name="keep_going">Non‑zero starts or continues the raising operation; zero stops it, resetting the internal timer.</param>
    /// <param name="i_fChangeModOverride">Overrides the camera adjustment speed used during the raise. A value of 1.0 retains the default speed; any other value replaces it directly. If a specific flag is set, this override is further scaled by 0.25.</param>
    public void Raise(int keep_going, float i_fChangeModOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, float, void>)0x00457AA0)(ref this, keep_going, i_fChangeModOverride);

    /// <summary>Adjusts the camera to look downward over time while ensuring constraints on view angle and smooth transition. When active, it modifies the viewer offset and target direction to achieve a lowered perspective; stopping occurs when the keep_going flag is cleared.
    /// <code>Offset: 0x00457E10
    /// void __thiscall CameraSet::Lower(CameraSet*,int,float)</code>
    /// </summary>
    /// <param name="keep_going">If non‑zero, lowering continues; if zero, the operation stops and flags are reset.</param>
    /// <param name="i_fChangeModOverride">Overrides the default adjustment speed. A value of 1.0 uses the standard rate; other values modify the interpolation speed, possibly scaled by user settings.</param>
    public void Lower(int keep_going, float i_fChangeModOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, float, void>)0x00457E10)(ref this, keep_going, i_fChangeModOverride);

    /// <summary>Enables or disables a camera “look‑down” mode by storing the current viewer offset and target direction, then restoring them when deactivated.
    /// <code>Offset: 0x00458110
    /// void __thiscall CameraSet::LookDown(CameraSet*,int)</code>
    /// </summary>
    /// <param name="look_down">Nonzero activates look‑down; zero restores normal view.</param>
    public void LookDown(int look_down) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, void>)0x00458110)(ref this, look_down);

    /// <summary>Enables or disables the camera's map mode, adjusting stiffness, orientation, and viewer offset accordingly.
    /// <code>Offset: 0x004582F0
    /// void __thiscall CameraSet::SetMapMode(CameraSet*,int)</code>
    /// </summary>
    /// <param name="map_mode">Non‑zero to activate map mode; zero to deactivate it.</param>
    public void SetMapMode(int map_mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, void>)0x004582F0)(ref this, map_mode);

    /// <summary>Tracks the camera toward a specified object identified by gid, updating targeting state and offset parameters accordingly.
    /// <code>Offset: 0x004583A0
    /// void __thiscall CameraSet::TrackTarget(CameraSet*,unsigned int)</code>
    /// </summary>
    /// <param name="gid">The unique identifier of the target object; zero disables tracking.</param>
    public void TrackTarget(uint gid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, uint, void>)0x004583A0)(ref this, gid);

    /// <summary>Rotates the camera around its focus point according to input direction, speed override, and key‑based handling. Updates the camera’s offset and orientation and may trigger command‑interpreter events or server notifications.
    /// <code>Offset: 0x00458430
    /// void __thiscall CameraSet::Rotate(CameraSet*,int,int,float,int)</code>
    /// </summary>
    /// <param name="clockwise_dir">Non‑zero selects rotation in one direction (typically left); zero selects the opposite direction.</param>
    /// <param name="keep_going">When non‑zero, the camera continues rotating on subsequent frames; when zero, rotation stops after this call.</param>
    /// <param name="i_fChangeModOverride">If not equal to 1.0, overrides the computed rotation amount with this value; otherwise rotation speed is based on elapsed time and adjustment speed.</param>
    /// <param name="camera_keys">Non‑zero causes rotation to be handled via key‑based action callbacks; zero uses continuous movement logic.</param>
    public void Rotate(int clockwise_dir, int keep_going, float i_fChangeModOverride, int camera_keys) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, int, float, int, void>)0x00458430)(ref this, clockwise_dir, keep_going, i_fChangeModOverride, camera_keys);

    /// <summary>Gradually moves the camera closer by updating its viewer offset over time, optionally overriding the adjustment rate and handling look‑down adjustments.
    /// <code>Offset: 0x004587F0
    /// void __thiscall CameraSet::Closer(CameraSet*,int,float)</code>
    /// </summary>
    /// <param name="this">The CameraSet instance whose camera is being modified.</param>
    /// <param name="keep_going">If nonzero, continues the zoom operation; otherwise stops after the current step.</param>
    /// <param name="i_fChangeModOverride">Multiplier for the adjustment speed; if zero the function exits immediately.</param>
    public void Closer(int keep_going, float i_fChangeModOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, float, void>)0x004587F0)(ref this, keep_going, i_fChangeModOverride);

    /// <summary>Zooms the camera farther from its target, adjusting the viewer offset over time and applying stiffness constraints. Resets state when the zoom operation ends.
    /// <code>Offset: 0x004589B0
    /// void __thiscall CameraSet::Farther(CameraSet*,int,float)</code>
    /// </summary>
    /// <param name="keep_going">When non‑zero, continues zooming in subsequent calls; zero stops and resets the zoom timer.</param>
    /// <param name="i_fChangeModOverride">Multiplier applied to the camera’s zoom change speed; 1.0 uses the default adjustment rate.</param>
    public void Farther(int keep_going, float i_fChangeModOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, float, void>)0x004589B0)(ref this, keep_going, i_fChangeModOverride);

    /// <summary>Updates camera orientation and zoom based on active control flags and adjusts player translucency when the camera enters head view or approaches too close to the pivot point.
    /// <code>Offset: 0x00458C00
    /// void __thiscall CameraSet::UpdateCamera(CameraSet*)</code>
    /// </summary>
    public void UpdateCamera() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00458C00)(ref this);

    /// <summary>Configures the camera for an in‑head view by resetting translational stiffness, clearing any look‑down state, setting a neutral target direction and applying a small upward offset.
    /// <code>Offset: 0x00458E00
    /// void __thiscall CameraSet::SetInHead(CameraSet*)</code>
    /// </summary>
    public void SetInHead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, void>)0x00458E00)(ref this);

    /// <summary>Handles mouse movement input to control camera orientation, applying user‑configured smoothing, sensitivity and inversion. If the cursor is idle, it may release focus or trigger a delayed command action via the attached interpreter. When motion exceeds a short threshold, it adjusts pitch for vertical deltas and raises or lowers the camera for horizontal deltas.
    /// <code>Offset: 0x00458EA0
    /// void __thiscall CameraSet::MouseLookHandler(CameraSet*,int,int)</code>
    /// </summary>
    /// <param name="i_nXMove">Horizontal mouse movement delta (pixels or device units).</param>
    /// <param name="i_nYMove">Vertical mouse movement delta (pixels or device units).</param>
    public void MouseLookHandler(int i_nXMove, int i_nYMove) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, int, void>)0x00458EA0)(ref this, i_nXMove, i_nYMove);

    /// <summary>Resets the camera to its default configuration for a player, aligning pivot, target direction, and stiffness settings.
    /// <code>Offset: 0x004590A0
    /// void __thiscall CameraSet::SetDefaultOffsets(CameraSet*,int)</code>
    /// </summary>
    /// <param name="move_camera">When non‑zero, applies the full reset of offsets, pivot objects, target direction, and stiffness; otherwise no changes are made.</param>
    public void SetDefaultOffsets(int move_camera) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, int, void>)0x004590A0)(ref this, move_camera);

    /// <summary>Initializes a new CameraSet instance by associating it with the supplied SmartBox, resetting all state flags, registering itself with the camera manager, and setting default camera offsets.
    /// <code>Offset: 0x004591E0
    /// void __thiscall CameraSet::CameraSet(CameraSet*,SmartBox*)</code>
    /// </summary>
    /// <param name="sbox">The SmartBox providing the camera manager and game context for this camera set.</param>
    public void _ConstructorInternal(ACBindings.Internal.SmartBox* sbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CameraSet, ACBindings.Internal.SmartBox*, void>)0x004591E0)(ref this, sbox);
}

