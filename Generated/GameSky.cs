namespace ACBindings.Internal;


/// <summary>Maintains celestial objects and their positions in the game world, handling creation, deletion, updates, and rendering of sky elements.</summary>
public unsafe struct GameSky : System.IDisposable
{
    // Statics
    public static byte* s_weatherEnabled = (byte*)0x0081DD3C;
    public static double* s_timeAdjustment = (double*)0x00842970;

    // Members
    public ACBindings.Internal.AC1Legacy.SmartArray___CelestialPosition sky_obj_pos;
    public ACBindings.Internal.AC1Legacy.SmartArray___CPhysicsObj_ptr sky_obj;
    public ACBindings.Internal.AC1Legacy.SmartArray__uint property_array;
    public ACBindings.Internal.CEnvCell* before_sky_cell;
    public ACBindings.Internal.CEnvCell* after_sky_cell;

    // Generated Constructor
    public GameSky() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// Updates all celestial objects in the sky to match a new world position, adjusting their frames and cell identifiers accordingly.
    /// 
    /// <code>Offset: 0x00507830
    /// void __thiscall GameSky::UpdatePosition(GameSky*,const Position*)</code>
    /// </summary>
    /// <param name="p">The Position containing the target object cell ID and frame information for the update.</param>
    public void UpdatePosition(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, ACBindings.Internal.Position*, void>)0x00507830)(ref this, p);

    /// <summary>Creates a physics object of the specified type for the sky, optionally applies texture velocity, then adds it to one of two sky cells based on a flag; returns the created object or nullptr if creation fails or weather is disabled.
    /// <code>Offset: 0x00507940
    /// CPhysicsObj* __thiscall GameSky::MakeObject(CObjCell**,int,float*,int,int)</code>
    /// </summary>
    /// <param name="objectType">Identifier of the physics object to instantiate.</param>
    /// <param name="textureVelocity">Two-component vector specifying texture scrolling speed; set to zero to skip applying velocity.</param>
    /// <param name="useSecondCell">When non-zero, adds the object to the second sky cell (index 10); otherwise uses the first cell (index 9).</param>
    /// <param name="weatherCondition">If true and global weather is disabled, object creation is aborted and nullptr returned.</param>
    /// <returns>Pointer to the newly created CPhysicsObj, or nullptr if creation failed or weather conditions prevent it.</returns>
    public ACBindings.Internal.CPhysicsObj* MakeObject(int a2, float* a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, int, float*, int, int, ACBindings.Internal.CPhysicsObj*>)0x00507940)(ref this, a2, a3, a4, a5);

    /// <summary>Adjusts a frame's orientation by setting its heading and applying an optional yaw rotation.
    /// <code>Offset: 0x005079E0
    /// void __thiscall GameSky::CalcFrame(GameSky*,Frame*,float,float)</code>
    /// </summary>
    /// <param name="dummy_frame">Frame to modify.</param>
    /// <param name="heading">New heading angle in degrees; applied only when non‑zero.</param>
    /// <param name="rotation">Yaw rotation around the Y axis in degrees; applied only when non‑zero.</param>
    public void CalcFrame(ACBindings.Internal.Frame* dummy_frame, float heading, float rotation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, ACBindings.Internal.Frame*, float, float, void>)0x005079E0)(ref this, dummy_frame, heading, rotation);

    /// <summary>Renders sky elements for the current level by drawing either the after‑sky cell or individual celestial objects based on the supplied flag and environmental state. Drawing occurs only when the player is outside or the flag is zero; otherwise the function exits without rendering.
    /// <code>Offset: 0x00507A50
    /// void __thiscall GameSky::Draw(GameSky*,int)</code>
    /// </summary>
    /// <param name="after">Non‑zero indicates an attempt to render the after‑sky cell (subject to weather conditions); zero causes iteration over sky objects, drawing those that satisfy visibility and fog checks.</param>
    public void Draw(int after) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, int, void>)0x00507A50)(ref this, after);

    /// <summary>Updates time‑adjustment data, logs current date and time to the global registry, and releases temporary resources.
    /// <code>Offset: 0x00507B80
    /// LONG GameSky::OnTimeAdjustment()</code>
    /// </summary>
    /// <returns>The reference count of the temporary string after decrementing; zero indicates that the string has been released, non‑zero indicates remaining references.</returns>
    public static int OnTimeAdjustment() => ((delegate* unmanaged[Cdecl]<int>)0x00507B80)();

    /// <summary>Initializes sky object collections to empty, creates before and after environmental cell instances, and registers a global time‑adjustment variable used to compute GameTime for the sky system.
    /// <code>Offset: 0x00507C50
    /// void __thiscall GameSky::GameSky(GameSky*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, void>)0x00507C50)(ref this);

    /// <summary>Destroys a GameSky instance, unregisters the global time variable, removes celestial objects from their associated environment cells, releases cell references, and deallocates all allocated resources.
    /// <code>Offset: 0x00507D40
    /// void __thiscall GameSky::~GameSky(GameSky*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, void>)0x00507D40)(ref this);

    /// <summary>Synchronizes physics objects for the sky with their celestial positions, creating new objects when needed and removing obsolete ones while adjusting array sizes and handling weather state changes.
    /// <code>Offset: 0x00507E20
    /// void __thiscall GameSky::CreateDeletePhysicsObjects(GameSky*)</code>
    /// </summary>
    public void CreateDeletePhysicsObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, void>)0x00507E20)(ref this);

    /// <summary>Updates sky physics objects’ positions, orientations and visual properties each frame according to the current game time.
    /// <code>Offset: 0x00508010
    /// void __thiscall GameSky::UseTime(GameSky*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, void>)0x00508010)(ref this);

    /// <summary>Clears celestial positions and deactivates the sky by resetting its internal state.
    /// <code>Offset: 0x005081C0
    /// void __thiscall GameSky::SetInactive(GameSky*)</code>
    /// </summary>
    public void SetInactive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, void>)0x005081C0)(ref this);
}

