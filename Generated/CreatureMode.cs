namespace ACBindings.Internal;


/// <summary>Manages a creature’s visual environment by tracking physics objects, lights, and camera state; provides functionality to add or remove elements, configure lighting, and render the scene.</summary>
public unsafe struct CreatureMode : System.IDisposable
{
    // Members
    public ACBindings.Internal.SmartArray___CPhysicsObj_ptr creature_mode_objects;
    public ACBindings.Internal.SmartArray___LIGHTINFO_ptr creature_mode_lights;
    public ACBindings.Internal.CEnvCell* creature_cell;
    public ACBindings.Internal.Frame creature_view_frame;
    public ACBindings.Internal.RGBColor m_clrAmbientLight;
    public float m_fFOVRadians;
    public byte m_bUseSmartboxFOV;
    public byte m_bUseSharpMode;

    // Generated Constructor
    public CreatureMode() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Sets the camera's origin within the creature mode to the specified 3‑dimensional position.
    /// <code>Offset: 0x004523A0
    /// void __thiscall CreatureMode::SetCameraPosition(CreatureMode*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="i_position">The target position for the camera in world coordinates.</param>
    public void SetCameraPosition(ACBindings.Internal.AC1Legacy.Vector3* i_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x004523A0)(ref this, i_position);

    /// <summary>Enables the creature’s smart box field‑of‑view mode.
    /// <code>Offset: 0x004523C0
    /// void __thiscall CreatureMode::UseSmartboxFOV(CreatureMode*)</code>
    /// </summary>
    public void UseSmartboxFOV() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, void>)0x004523C0)(ref this);

    /// <summary>Enables sharp mode for the creature, setting an internal flag that alters its viewing behavior.
    /// <code>Offset: 0x004523D0
    /// void __thiscall CreatureMode::UseSharpMode(CreatureMode*)</code>
    /// </summary>
    public void UseSharpMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, void>)0x004523D0)(ref this);

    /// <summary>Configures lighting, camera orientation, field‑of‑view, and texture filtering for the creature mode view before invoking the render device to draw the associated environment cell; applies smartbox FOV adjustments and restores mipmap bias after rendering when sharp mode is active.
    /// <code>Offset: 0x00452A10
    /// void __thiscall CreatureMode::Render(CreatureMode*)</code>
    /// </summary>
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, void>)0x00452A10)(ref this);

    /// <summary>Removes the specified physics object from the creature mode’s list and its associated cell.
    /// <code>Offset: 0x004536E0
    /// bool __thiscall CreatureMode::RemoveObject(CreatureMode*,const CPhysicsObj*)</code>
    /// </summary>
    /// <param name="i_pObject">The physics object to be removed.</param>
    /// <returns>True if the object was found and removed; otherwise, false.</returns>
    public byte RemoveObject(ACBindings.Internal.CPhysicsObj* i_pObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, ACBindings.Internal.CPhysicsObj*, byte>)0x004536E0)(ref this, i_pObject);

    /// <summary>Retrieves a physics object from the creature mode’s internal array by index.
    /// <code>Offset: 0x00453750
    /// CPhysicsObj* __thiscall CreatureMode::GetObjectByIndex(CreatureMode*,unsigned int)</code>
    /// </summary>
    /// <param name="i_index">Index of the desired physics object within the creature mode's object list.</param>
    /// <returns>Pointer to the CPhysicsObj at the specified index, or null if the index is out of bounds.</returns>
    public ACBindings.Internal.CPhysicsObj* GetObjectByIndex(uint i_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, uint, ACBindings.Internal.CPhysicsObj*>)0x00453750)(ref this, i_index);

    /// <summary>Sets the creature mode’s camera orientation by applying a rotation derived from the supplied direction vector.
    /// <code>Offset: 0x00453770
    /// void __thiscall CreatureMode::SetCameraDirection(CreatureMode*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="i_direction">Target direction for the camera, specified as a 3‑component vector.</param>
    public void SetCameraDirection(ACBindings.Internal.AC1Legacy.Vector3* i_direction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00453770)(ref this, i_direction);

    /// <summary>Sets the creature's camera orientation by converting a degree‑based direction vector into radians and applying it as an Euler rotation to its view frame.
    /// <code>Offset: 0x004537A0
    /// void __thiscall CreatureMode::SetCameraDirection_Degrees(CreatureMode*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="i_direction_degrees">The desired camera orientation expressed as a Vector3 containing degrees for X, Y, and Z axes.</param>
    public void SetCameraDirection_Degrees(ACBindings.Internal.AC1Legacy.Vector3* i_direction_degrees) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x004537A0)(ref this, i_direction_degrees);

    /// <summary>Initializes a CreatureMode instance by clearing object and light arrays, setting the view frame to identity, configuring ambient lighting, field‑of‑view, and mode flags to their default states.
    /// <code>Offset: 0x00454430
    /// void __thiscall CreatureMode::CreatureMode(CreatureMode*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, void>)0x00454430)(ref this);

    /// <summary>Removes all physics objects associated with this creature mode from its current environment cell, cleans up any shadow data, and clears related object lists.
    /// <code>Offset: 0x00454490
    /// void __thiscall CreatureMode::RemoveAllObjects(CreatureMode*)</code>
    /// </summary>
    public void RemoveAllObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, void>)0x00454490)(ref this);

    /// <summary>Deletes all light objects stored in the creature mode, freeing allocated memory and resetting the lights array to an empty state.
    /// <code>Offset: 0x004544D0
    /// void __thiscall CreatureMode::RemoveAllLights(CreatureMode*)</code>
    /// </summary>
    public void RemoveAllLights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, void>)0x004544D0)(ref this);

    /// <summary>Sets the direction of a specified light in the creature mode to the supplied vector.
    /// <code>Offset: 0x00454560
    /// bool __thiscall CreatureMode::SetLightDirection(CreatureMode*,unsigned int,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="i_index">Zero-based index identifying which light to update.</param>
    /// <param name="i_direction">Vector indicating the new direction for the selected light.</param>
    /// <returns>True if the light was updated; false when the index is outside the valid range of lights. </returns>
    public byte SetLightDirection(uint i_index, ACBindings.Internal.AC1Legacy.Vector3* i_direction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, uint, ACBindings.Internal.AC1Legacy.Vector3*, byte>)0x00454560)(ref this, i_index, i_direction);

    /// <summary>Destroys a CreatureMode instance by removing all attached objects, releasing the environment cell reference, and freeing allocated light and object arrays.
    /// <code>Offset: 0x004551F0
    /// void __thiscall CreatureMode::~CreatureMode(CreatureMode*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, void>)0x004551F0)(ref this);

    /// <summary>Adds a new light source to the creature mode's internal light collection with the specified type and intensity. The created LIGHTINFO object is initialized with default direction, color, and falloff values before being appended to the array.
    /// <code>Offset: 0x00455650
    /// void __thiscall CreatureMode::AddLight(CreatureMode*,LIGHTINFO::LightType,float)</code>
    /// </summary>
    /// <param name="lightType">The type of light to add, defined in LIGHTINFO::LightType.</param>
    /// <param name="intensity">The intensity value for the new light source.</param>
    public void AddLight(ACBindings.Internal.LIGHTINFO.LightType lightType, float intensity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, ACBindings.Internal.LIGHTINFO.LightType, float, void>)0x00455650)(ref this, lightType, intensity);

    /// <summary>Adds the specified physics object to the creature mode’s cell and sets its placement frame, but only if the object is non‑null and not already present.
    /// <code>Offset: 0x004557F0
    /// bool __thiscall CreatureMode::AddObject(CreatureMode*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="i_pObject">The physics object to add to the creature mode.</param>
    /// <returns>True when the object was successfully added; false if the object is null or already exists in the mode.</returns>
    public byte AddObject(ACBindings.Internal.CPhysicsObj* i_pObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, ACBindings.Internal.CPhysicsObj*, byte>)0x004557F0)(ref this, i_pObject);
}

