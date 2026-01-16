namespace ACBindings.Internal;


/// <summary>Holds an organized collection of physics components associated with a single entity, maintaining state, transformation data, and rendering resources for simulation and visual representation.</summary>
/// <remarks>Used by the physics engine to update and render complex objects composed of multiple parts.</remarks>
public unsafe struct CPartArray : System.IDisposable
{
    // Members
    public uint pa_state;
    public ACBindings.Internal.CPhysicsObj* owner;
    public ACBindings.Internal.CSequence sequence;
    public ACBindings.Internal.MotionTableManager* motion_table_manager;
    public System.IntPtr setup;
    public uint num_parts;
    public ACBindings.Internal.CPhysicsPart** parts;
    public ACBindings.Internal.AC1Legacy.Vector3 scale;
    public ACBindings.Internal.Palette** pals;
    public ACBindings.Internal.LIGHTLIST* lights;
    public ACBindings.Internal.AnimFrame* last_animframe;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Notifies the associated MotionTableManager that an animation has finished, optionally indicating whether it succeeded.
    /// <code>Offset: 0x00518860
    /// void __thiscall CPartArray::AnimationDone(CPartArray*,int)</code>
    /// </summary>
    /// <param name="success">Non‑zero if the animation completed successfully; zero indicates failure or cancellation.</param>
    public void AnimationDone(int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int, void>)0x00518860)(ref this, success);

    /// <summary>Checks the associated MotionTableManager for finished motions and initiates any required completion logic.
    /// <code>Offset: 0x00518890
    /// void __thiscall CPartArray::HandleMovement(CPartArray*)</code>
    /// </summary>
    public void HandleMovement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x00518890)(ref this);

    /// <summary>Notifies the motion table manager that the part array has entered the world, forwarding its current animation sequence.
    /// <code>Offset: 0x005188A0
    /// void __thiscall CPartArray::HandleEnterWorld(CPartArray*)</code>
    /// </summary>
    public void HandleEnterWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x005188A0)(ref this);

    /// <summary>Handles cleanup for the part array when it exits the world by delegating to its motion table manager.
    /// <code>Offset: 0x005188C0
    /// void __thiscall CPartArray::HandleExitWorld(CPartArray*)</code>
    /// </summary>
    public void HandleExitWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x005188C0)(ref this);

    /// <summary>Advances the part array’s animation sequence by the specified time increment, optionally applying a frame offset.
    /// <code>Offset: 0x005188E0
    /// void __thiscall CPartArray::Update(CPartArray*,float,Frame*)</code>
    /// </summary>
    /// <param name="quantum">The elapsed time used to progress the animation sequence.</param>
    /// <param name="offset_frame">Optional frame data applied during the update; may be null to indicate no offset.</param>
    public void Update(float quantum, ACBindings.Internal.Frame* offset_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, float, ACBindings.Internal.Frame*, void>)0x005188E0)(ref this, quantum, offset_frame);

    /// <summary>Assigns the specified cell identifier to every part within the array.
    /// <code>Offset: 0x00518900
    /// void __thiscall CPartArray::SetCellID(CPartArray*,const unsigned int)</code>
    /// </summary>
    /// <param name="cell_id">The cell ID to set on each part's position data.</param>
    public void SetCellID(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint, void>)0x00518900)(ref this, cell_id);

    /// <summary>Removes every physics part stored in this array from the given object cell.
    /// <code>Offset: 0x00518930
    /// void __thiscall CPartArray::RemoveParts(CPartArray*,CObjCell*)</code>
    /// </summary>
    /// <param name="this">The <c>CPartArray</c> instance whose parts should be detached.</param>
    /// <param name="obj_cell">The <c>CObjCell</c> from which each part will be removed via its internal <c>CPartCell</c>.</param>
    public void RemoveParts(ACBindings.Internal.CObjCell* obj_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CObjCell*, void>)0x00518930)(ref this, obj_cell);

    /// <summary>Adds each physics part in the array as a shadow part to the specified object cell, optionally applying clipping planes when multiple shadows are requested.
    /// <code>Offset: 0x00518970
    /// void __thiscall CPartArray::AddPartsShadow(CPartArray*,CObjCell*,unsigned int)</code>
    /// </summary>
    /// <param name="obj_cell">The object cell to which parts will be added as shadows.</param>
    /// <param name="num_shadow_parts">Number of shadow parts to add per part; if greater than one, clipping planes from the cell are used during addition.</param>
    public void AddPartsShadow(ACBindings.Internal.CObjCell* obj_cell, uint num_shadow_parts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CObjCell*, uint, void>)0x00518970)(ref this, obj_cell, num_shadow_parts);

    /// <summary>Adds each light from this part array’s internal light list into the specified object cell, invoking the cell’s add_light method for every light.
    /// <code>Offset: 0x005189D0
    /// void __thiscall CPartArray::AddLightsToCell(CPartArray*,CObjCell*)</code>
    /// </summary>
    /// <param name="cell">The target cell that will receive the added lights; if null, no lights are processed.</param>
    public void AddLightsToCell(ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CObjCell*, void>)0x005189D0)(ref this, cell);

    /// <summary>Removes every light associated with this part array from the specified object cell, updating the cell’s lighting data.
    /// <code>Offset: 0x00518A20
    /// void __thiscall CPartArray::RemoveLightsFromCell(CPartArray*,CObjCell*)</code>
    /// </summary>
    /// <param name="cell">The object cell that should lose all of the part array’s lights.</param>
    public void RemoveLightsFromCell(ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CObjCell*, void>)0x00518A20)(ref this, cell);

    /// <summary>Initializes the array of physics parts for this CPartArray instance by allocating storage, creating each part from associated GFX objects, linking them to the owning physics object, and applying per-part scale values if supplied.
    /// <code>Offset: 0x00518A70
    /// int __thiscall CPartArray::InitParts(CPartArray*)</code>
    /// </summary>
    /// <returns>1 on successful initialization; 0 if no parts exist or a failure occurs during allocation or part creation.</returns>
    public int InitParts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int>)0x00518A70)(ref this);

    /// <summary>Retrieves the total number of sphere elements stored in the part array.
    /// <code>Offset: 0x00518B90
    /// unsigned int __thiscall CPartArray::GetNumSphere(CPartArray*)</code>
    /// </summary>
    /// <returns>The count of sphere objects represented by this CPartArray instance.</returns>
    public uint GetNumSphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint>)0x00518B90)(ref this);

    /// <summary>Retrieves the collision sphere used by this part array.
    /// <code>Offset: 0x00518BA0
    /// const CSphere* __thiscall CPartArray::GetSphere(CPartArray*)</code>
    /// </summary>
    /// <returns>A pointer to a constant CSphere that defines the sphere's center and radius for collision detection; may be null if no sphere is set.</returns>
    public ACBindings.Internal.CSphere* GetSphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CSphere*>)0x00518BA0)(ref this);

    /// <summary>Returns the count of cylsphere elements in the part array.
    /// <code>Offset: 0x00518BB0
    /// unsigned int __thiscall CPartArray::GetNumCylsphere(CPartArray*)</code>
    /// </summary>
    /// <returns>The number of cylsphere components associated with this CPartArray instance.</returns>
    public uint GetNumCylsphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint>)0x00518BB0)(ref this);

    /// <summary>Retrieves the cylindrical geometry parameters for a physics part from the array's setup data.
    /// <code>Offset: 0x00518BC0
    /// const CCylSphere* __thiscall CPartArray::GetCylsphere(CPartArray*)</code>
    /// </summary>
    /// <returns>A const pointer to a CCylSphere structure that holds the low point, height, and radius of the cylinder.</returns>
    public ACBindings.Internal.CCylSphere* GetCylsphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CCylSphere*>)0x00518BC0)(ref this);

    /// <summary>Retrieves the radial size of a part array, scaling it by the object’s Z‑axis scale factor.
    /// <code>Offset: 0x00518BD0
    /// float __thiscall CPartArray::GetRadius(CPartArray*)</code>
    /// </summary>
    /// <returns>The computed radius as a floating‑point value.</returns>
    public float GetRadius() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, float>)0x00518BD0)(ref this);

    /// <summary>Returns the vertical size of the part array, scaled by its local z scale factor.
    /// <code>Offset: 0x00518BE0
    /// float __thiscall CPartArray::GetHeight(CPartArray*)</code>
    /// </summary>
    /// <returns>A float representing the calculated height.</returns>
    public float GetHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, float>)0x00518BE0)(ref this);

    /// <summary>Determines whether the part array permits free heading based on its internal setup configuration.
    /// <code>Offset: 0x00518BF0
    /// int __thiscall CPartArray::AllowsFreeHeading(CPartArray*)</code>
    /// </summary>
    /// <returns>Non‑zero if free heading is allowed, zero otherwise.</returns>
    public int AllowsFreeHeading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int>)0x00518BF0)(ref this);

    /// <summary>
    /// Checks whether the part array contains any parts that reference a physics BSP and updates the internal state flag accordingly.
    /// 
    /// <code>Offset: 0x00518C40
    /// int __thiscall CPartArray::CacheHasPhysicsBSP(CPartArray*)</code>
    /// </summary>
    /// <returns>
    /// Non‑zero (1) if at least one part has a physics BSP; zero otherwise.
    /// </returns>
    public int CacheHasPhysicsBSP() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int>)0x00518C40)(ref this);

    /// <summary>Calculates cross‑cell references for the part array within the specified object cell and appends them to the provided cell array.
    /// <code>Offset: 0x00518C90
    /// void __thiscall CPartArray::calc_cross_cells_static(CPartArray*,const CObjCell*,CELLARRAY*)</code>
    /// </summary>
    /// <param name="cell">The object cell whose contents are examined.</param>
    /// <param name="cell_array">The destination cell array that receives the computed cross‑cell data.</param>
    public void calc_cross_cells_static(ACBindings.Internal.CObjCell* cell, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CObjCell*, ACBindings.Internal.CELLARRAY*, void>)0x00518C90)(ref this, cell, cell_array);

    /// <summary>Iterates over all physics parts in the array and checks each for collisions using the supplied transition data, returning the first non‑OK status or OK_TS if all parts succeed.
    /// <code>Offset: 0x00518CB0
    /// TransitionState __thiscall CPartArray::FindObjCollisions(CPartArray*,CTransition*)</code>
    /// </summary>
    /// <param name="transition">Transition information used to evaluate potential collisions.</param>
    /// <returns>The TransitionState indicating success (OK_TS) or the first error encountered during collision checks.</returns>
    public ACBindings.Internal.TransitionState FindObjCollisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x00518CB0)(ref this, transition);

    /// <summary>Initializes the palette array for each part of the component, allocating memory if necessary and zero‑initializing all pointers.
    /// <code>Offset: 0x00518CF0
    /// int __thiscall CPartArray::InitPals(CPartArray*)</code>
    /// </summary>
    /// <returns>Non‑zero on success; zero if allocation fails or an error occurs.</returns>
    public int InitPals() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int>)0x00518CF0)(ref this);

    /// <summary>Releases all palette resources associated with this part array and frees the internal palette array memory.
    /// <code>Offset: 0x00518D40
    /// void __thiscall CPartArray::DestroyPals(CPartArray*)</code>
    /// </summary>
    public void DestroyPals() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x00518D40)(ref this);

    /// <summary>Updates the viewer distance for all physics parts in the array by invoking each part's UpdateViewerDistance method.
    /// <code>Offset: 0x00518D90
    /// void __thiscall CPartArray::UpdateViewerDistance(CPartArray*)</code>
    /// </summary>
    public void UpdateViewerDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x00518D90)(ref this);

    /// <summary>Updates each physics part in the array by applying the specified viewer distance and heading.
    /// <code>Offset: 0x00518DC0
    /// void __thiscall CPartArray::UpdateViewerDistance(CPartArray*,float,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="CYpt">The viewer distance value to be applied to each part.</param>
    /// <param name="viewer_heading">Pointer to a Vector3 representing the viewer's heading direction.</param>
    public void UpdateViewerDistance(float CYpt, ACBindings.Internal.AC1Legacy.Vector3* viewer_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, float, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00518DC0)(ref this, CYpt, viewer_heading);

    /// <summary>Renders each physics part contained in this CPartArray instance.
    /// <code>Offset: 0x00518E00
    /// void __thiscall CPartArray::Draw(CPartArray*,const Position*)</code>
    /// </summary>
    /// <param name="p">Optional position context for drawing; presently unused by the implementation.</param>
    public void Draw(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.Position*, void>)0x00518E00)(ref this, p);

    /// <summary>Applies the specified draw flag to every physics part in the array when the part list has been initialized.
    /// <code>Offset: 0x00518E30
    /// void __thiscall CPartArray::SetNoDrawInternal(CPartArray*,int)</code>
    /// </summary>
    /// <param name="no_draw">A value passed to each contained part’s SetNoDraw method, typically indicating whether the parts should be rendered or hidden.</param>
    public void SetNoDrawInternal(int no_draw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int, void>)0x00518E30)(ref this, no_draw);

    /// <summary>Applies a translucency value to every valid physics part contained in the array, provided that a setup object is present.
    /// <code>Offset: 0x00518E70
    /// void __thiscall CPartArray::SetTranslucencyInternal(CPartArray*,float)</code>
    /// </summary>
    /// <param name="translucency">The desired translucency factor to assign to each part.</param>
    public void SetTranslucencyInternal(float translucency) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, float, void>)0x00518E70)(ref this, translucency);

    /// <summary>Sets the translucency level for a specific physics part in the array when the array is initialized and the index is valid.
    /// <code>Offset: 0x00518EB0
    /// void __thiscall CPartArray::SetPartTranslucencyInternal(CPartArray*,unsigned int,float)</code>
    /// </summary>
    /// <param name="part_index">Index of the part whose translucency should be updated.</param>
    /// <param name="translucency">Desired translucency value to apply to the part.</param>
    public void SetPartTranslucencyInternal(uint part_index, float translucency) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint, float, void>)0x00518EB0)(ref this, part_index, translucency);

    /// <summary>Applies the specified luminosity to every physics part managed by this array when a valid setup exists.
    /// <code>Offset: 0x00518EE0
    /// void __thiscall CPartArray::SetLuminosityInternal(CPartArray*,float)</code>
    /// </summary>
    /// <param name="lumi">The new luminosity value to apply to each part.</param>
    public void SetLuminosityInternal(float lumi) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, float, void>)0x00518EE0)(ref this, lumi);

    /// <summary>Sets the luminosity of a physics part in the array when the part exists and the array is initialized.
    /// <code>Offset: 0x00518F20
    /// void __thiscall CPartArray::SetPartLuminosityInternal(CPartArray*,unsigned int,float)</code>
    /// </summary>
    /// <param name="part_index">Index of the target part within the array.</param>
    /// <param name="lumi">Desired luminosity value to apply to the part.</param>
    public void SetPartLuminosityInternal(uint part_index, float lumi) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint, float, void>)0x00518F20)(ref this, part_index, lumi);

    /// <summary>Applies the specified diffusion value to every valid physics part in the array when a setup is present.
    /// <code>Offset: 0x00518F50
    /// void __thiscall CPartArray::SetDiffusionInternal(CPartArray*,float)</code>
    /// </summary>
    /// <param name="diff">Diffusion coefficient to assign to each part.</param>
    public void SetDiffusionInternal(float diff) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, float, void>)0x00518F50)(ref this, diff);

    /// <summary>Sets the diffusion coefficient for a specified physics part within the array when the array has been initialized and the index is valid.
    /// <code>Offset: 0x00518F90
    /// void __thiscall CPartArray::SetPartDiffusionInternal(CPartArray*,unsigned int,float)</code>
    /// </summary>
    /// <param name="part_index">Index of the part to update.</param>
    /// <param name="diff">The new diffusion value to apply.</param>
    public void SetPartDiffusionInternal(uint part_index, float diff) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint, float, void>)0x00518F90)(ref this, part_index, diff);

    /// <summary>Initializes object description changes for each part in the array when a setup is present, indicating whether any part required updates.
    /// <code>Offset: 0x00519070
    /// int __thiscall CPartArray::InitObjDescChanges(CPartArray*)</code>
    /// </summary>
    /// <returns>Non‑zero if at least one part had its changes initialized; zero otherwise.</returns>
    public int InitObjDescChanges() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int>)0x00519070)(ref this);

    /// <summary>Updates the array’s physics parts based on a linked list of change descriptors, applying each modification to the corresponding part when present.
    /// <code>Offset: 0x005190B0
    /// int __thiscall CPartArray::SetPart(CPartArray*,const AnimPartChange*)</code>
    /// </summary>
    /// <param name="changes">Linked list of AnimPartChange structures describing parts to update.</param>
    /// <returns>1 if every requested part was updated successfully; 0 if the setup is missing or any update fails.</returns>
    public int SetPart(ACBindings.Internal.AnimPartChange* changes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.AnimPartChange*, int>)0x005190B0)(ref this, changes);

    /// <summary>Applies a series of texture map changes to the parts in the array, updating each specified part's texture mapping based on old and new IDs.
    /// <code>Offset: 0x00519110
    /// int __thiscall CPartArray::SetTextureMap(CPartArray*,const TextureMapChange*)</code>
    /// </summary>
    /// <param name="changes">Head of a linked list describing texture replacements for individual parts. Each node contains a part index, an old texture ID, and a new texture ID.</param>
    /// <returns>1 if all changes succeeded; 0 if any change failed or the array is uninitialized.</returns>
    public int SetTextureMap(ACBindings.Internal.TextureMapChange* changes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.TextureMapChange*, int>)0x00519110)(ref this, changes);

    /// <summary>Sets or updates the motion table used by the part array to the specified identifier.
    /// <code>Offset: 0x00519210
    /// int __thiscall CPartArray::SetMotionTableID(int,int)</code>
    /// </summary>
    /// <param name="motionTableID">The identifier of the motion table to associate with this part array. Passing zero removes any existing association.</param>
    /// <returns>True if a motion table is assigned or cleared successfully; false if creation of a new table fails.</returns>
    public int SetMotionTableID(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int, int>)0x00519210)(ref this, a2);

    /// <summary>Executes an interpreted motion command on the part array using the provided motion identifier and movement parameters via the motion table manager.
    /// <code>Offset: 0x00519280
    /// unsigned int __thiscall CPartArray::DoInterpretedMotion(CPartArray*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    /// <param name="motion">Identifier of the motion to perform.</param>
    /// <param name="params">MovementParameters containing distance, heading, speed, etc.</param>
    /// <returns>Result code from MotionTableManager::PerformMovement; returns 7 if no motion table manager is available.</returns>
    public uint DoInterpretedMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint, ACBindings.Internal.MovementParameters*, uint>)0x00519280)(ref this, motion, params_);

    /// <summary>Stops an interpreted motion on the part array by issuing a command to the MotionTableManager and updating the sequence.
    /// <code>Offset: 0x00519320
    /// unsigned int __thiscall CPartArray::StopInterpretedMotion(CPartArray*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    /// <param name="motion">Identifier of the motion to be halted.</param>
    /// <param name="params">Movement parameters controlling the stop behavior (e.g., distance thresholds, heading).</param>
    /// <returns>Zero or another value indicating success; returns 7 if no MotionTableManager is available.</returns>
    public uint StopInterpretedMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint, ACBindings.Internal.MovementParameters*, uint>)0x00519320)(ref this, motion, params_);

    /// <summary>Stops the part array’s current motion sequence immediately by delegating to its MotionTableManager.
    /// <code>Offset: 0x005193C0
    /// unsigned int __thiscall CPartArray::StopCompletelyInternal(CPartArray*)</code>
    /// </summary>
    /// <returns>A status code: 7 if no MotionTableManager is attached; otherwise returns the result from MotionTableManager::PerformMovement.</returns>
    public uint StopCompletelyInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint>)0x005193C0)(ref this);

    /// <summary>Deletes each physics part in the array, freeing its memory, then releases the parts array itself and clears the part count.
    /// <code>Offset: 0x00519450
    /// void __thiscall CPartArray::DestroyParts(CPartArray*)</code>
    /// </summary>
    public void DestroyParts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x00519450)(ref this);

    /// <summary>Initializes default animation sequence for the part array using its setup configuration and propagates default initialization to the owning physics object.
    /// <code>Offset: 0x005194B0
    /// void __thiscall CPartArray::InitDefaults(CPartArray*)</code>
    /// </summary>
    public void InitDefaults() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x005194B0)(ref this);

    /// <summary>Assigns a new scale to the part array and propagates it to each physics part's graphics object.
    /// <code>Offset: 0x00519530
    /// int __thiscall CPartArray::SetScaleInternal(CPartArray*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="new_scale">The desired scaling vector for the entire array.</param>
    /// <returns>Always returns 1 to indicate successful application of the new scale.</returns>
    public int SetScaleInternal(ACBindings.Internal.AC1Legacy.Vector3* new_scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00519530)(ref this, new_scale);

    /// <summary>Copies an internal identifier from the CPartArray instance into a supplied DWORD reference.
    /// <code>Offset: 0x005195E0
    /// _DWORD* __thiscall CPartArray::GetSetupID(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a DWORD where the retrieved identifier will be stored.</param>
    /// <returns>The same pointer passed in, now pointing to the stored identifier value.</returns>
    public int* GetSetupID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int*, int*>)0x005195E0)(ref this, a2);

    /// <summary>Retrieves the data identifier for this part array, writing it into the supplied unsigned int and returning that reference.
    /// <code>Offset: 0x005195F0
    /// unsigned int* __thiscall CPartArray::GetDataID(int,unsigned int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to receive the retrieved data identifier; receives INVALID_DID_217.baseclass_0.id if unavailable or conditions are not met.</param>
    /// <returns>The same pointer passed in a2, pointing to the stored data identifier.</returns>
    public uint* GetDataID(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint*, uint*>)0x005195F0)(ref this, a2);

    /// <summary>Retrieves the sphere used for sorting this part array, providing either the user‑supplied sphere or a shared default when none is configured.
    /// <code>Offset: 0x00519630
    /// const CSphere* __thiscall CPartArray::GetSortingSphere(CPartArray*)</code>
    /// </summary>
    /// <returns>A constant pointer to the sorting sphere. If no custom sphere exists, returns a reference to an internal static default sphere.</returns>
    public ACBindings.Internal.CSphere* GetSortingSphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CSphere*>)0x00519630)(ref this);

    /// <summary>Computes and populates a sphere representing the object's selection bounds using its setup data and scale; returns 1 on success or 0 if the setup is missing.
    /// <code>Offset: 0x005196B0
    /// int __thiscall CPartArray::GetSelectionSphere(CPartArray*,CSphere*)</code>
    /// </summary>
    /// <param name="selection_sphere">The CSphere structure to receive the computed center and radius.</param>
    /// <returns>Non‑zero (1) when the sphere was successfully calculated, zero when no setup data is available.</returns>
    public int GetSelectionSphere(ACBindings.Internal.CSphere* selection_sphere) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CSphere*, int>)0x005196B0)(ref this, selection_sphere);

    /// <summary>Initializes light objects associated with the part array by allocating a light list from setup data, configuring each light’s information and state based on the owner’s current state, and registering them in the owner’s spatial cell.
    /// <code>Offset: 0x00519730
    /// int __thiscall CPartArray::InitLights(CPartArray*)</code>
    /// </summary>
    /// <returns>Always returns 1 to indicate successful initialization.</returns>
    public int InitLights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int>)0x00519730)(ref this);

    /// <summary>Morphs the current part array to match another, destroying existing parts and duplicating scale, parts, and palette data.
    /// <code>Offset: 0x00519870
    /// int __thiscall CPartArray::MorphToExistingObject(CPartArray*,const CPartArray*)</code>
    /// </summary>
    /// <param name="pObj">The source CPartArray whose contents will replace those of this instance.</param>
    /// <returns>Always 1 indicating successful morphing.</returns>
    public int MorphToExistingObject(ACBindings.Internal.CPartArray* pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CPartArray*, int>)0x00519870)(ref this, pObj);

    /// <summary>Sets or updates the palette identified by the given ID using the supplied subpalette, then applies that palette to all physics parts that originally used it.
    /// <code>Offset: 0x00519940
    /// int __thiscall CPartArray::SetPalette(CPartArray*,int,Subpalette*)</code>
    /// </summary>
    /// <param name="a2">The identifier of the palette to modify; must not be INVALID_DID_217.baseclass_0.id.</param>
    /// <param name="subs">Pointer to a Subpalette structure containing new color data and linkage information.</param>
    /// <returns>1 if the palette was successfully set or modified and applied; 0 otherwise (e.g., missing setup, invalid ID, or no matching parts).</returns>
    public int SetPalette(int a2, ACBindings.Internal.Subpalette* subs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int, ACBindings.Internal.Subpalette*, int>)0x00519940)(ref this, a2, subs);

    /// <summary>Computes the global bounding box that encloses all physics parts in this array, taking each part's local bounds, scale and world position into account.
    /// <code>Offset: 0x00519A20
    /// void __thiscall CPartArray::GetBoundingBox(CPartArray*,BBox*)</code>
    /// </summary>
    /// <param name="o_bbox">The output parameter that will contain the resulting global bounding box.</param>
    public void GetBoundingBox(ACBindings.Internal.BBox* o_bbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.BBox*, void>)0x00519A20)(ref this, o_bbox);

    /// <summary>Updates each physics part in the array by merging its animation data with a supplied transform frame, applying the array’s scaling factor. If no current animation frame exists, the operation is skipped.
    /// <code>Offset: 0x00519C20
    /// void __thiscall CPartArray::UpdateParts(CPartArray*,const Frame*)</code>
    /// </summary>
    /// <param name="frame">The reference frame used to combine with each part’s animation frame during the update.</param>
    public void UpdateParts(ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.Frame*, void>)0x00519C20)(ref this, frame);

    /// <summary>Sets the mesh ID of this part array by creating a simple setup from the supplied id, replacing existing parts and initialization data.
    /// <code>Offset: 0x00519C80
    /// BOOL __thiscall CPartArray::SetMeshID(CPartArray*,int)</code>
    /// </summary>
    /// <param name="a2">The new mesh identifier to associate with the part array.</param>
    /// <returns>True if the mesh was successfully set; otherwise false.</returns>
    public byte SetMeshID(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int, byte>)0x00519C80)(ref this, a2);

    /// <summary>Destroys all lights associated with the part array, removing them from their cell and freeing allocated memory.
    /// <code>Offset: 0x00519CE0
    /// void __thiscall CPartArray::DestroyLights(CPartArray*)</code>
    /// </summary>
    public void DestroyLights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x00519CE0)(ref this);

    /// <summary>Applies animation part, texture map, and palette changes specified in an ObjDesc to the part array, then finalizes the update.
    /// <code>Offset: 0x00519D40
    /// int __thiscall CPartArray::DoObjDescChanges(CPartArray*,const ObjDesc*)</code>
    /// </summary>
    /// <param name="objdesc">Descriptor containing optional lists of animation part changes, texture map changes, and subpalette updates to apply.</param>
    /// <returns>Non‑zero if all requested changes were applied successfully; zero if any step failed or initialization did not complete.</returns>
    public int DoObjDescChanges(ACBindings.Internal.ObjDesc* objdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.ObjDesc*, int>)0x00519D40)(ref this, objdesc);

    /// <summary>Releases all resources owned by the part array, including motion tables, palettes, lights, parts, and setup data, then resets internal state and clears the associated sequence.
    /// <code>Offset: 0x00519DD0
    /// void __thiscall CPartArray::Destroy(CPartArray*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x00519DD0)(ref this);

    /// <summary>Applies the specified frame to all physics parts in the array and updates any associated light sources.
    /// <code>Offset: 0x00519E40
    /// void __thiscall CPartArray::SetFrame(CPartArray*,const Frame*)</code>
    /// </summary>
    /// <param name="this">The part array whose parts will be updated.</param>
    /// <param name="frame">The new animation frame containing orientation, transformation matrix and origin for the parts.</param>
    public void SetFrame(ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.Frame*, void>)0x00519E40)(ref this, frame);

    /// <summary>Updates the part array’s configuration to use the specified setup identifier. If the current setup differs or is absent, loads the new data, resets palettes, lights, and parts, optionally reinitializes parts, then prepares lights and default state.
    /// <code>Offset: 0x00519E60
    /// int __thiscall CPartArray::SetSetupID(CPartArray*,int,int)</code>
    /// </summary>
    /// <param name="setupId">Identifier for the new setup configuration.</param>
    /// <param name="initializeParts">Non‑zero to rebuild part instances after loading the new setup; zero skips this step.</param>
    /// <returns>1 if the setup was successfully applied or already matched; 0 if the requested setup could not be loaded or initialization failed.</returns>
    public int SetSetupID(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int, int, int>)0x00519E60)(ref this, a2, a3);

    /// <summary>Sets the sequence's placement frame according to the supplied placement ID by consulting the object's setup data. If no matching frame is found, assigns a default zeroed frame.
    /// <code>Offset: 0x00519F00
    /// int __thiscall CPartArray::SetPlacementFrame(CPartArray*,unsigned int)</code>
    /// </summary>
    /// <param name="placement_id">Identifier for the desired placement frame within the animation sequence.</param>
    /// <returns>Non‑zero if a valid frame was applied; otherwise zero and the sequence defaults to its base state.</returns>
    public int SetPlacementFrame(uint placement_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint, int>)0x00519F00)(ref this, placement_id);

    /// <summary>Applies default palette restoration to all physics parts, destroys any existing palette allocations, and optionally applies further object descriptor changes if supplied.
    /// <code>Offset: 0x00519FB0
    /// int __thiscall CPartArray::DoObjDescChangesFromDefault(CPartArray*,const ObjDesc*)</code>
    /// </summary>
    /// <param name="objdesc">Optional object description containing palette, texture map, or animation part changes to apply after restoring defaults; may be null.</param>
    /// <returns>An integer status code: returns 1 when no descriptor is provided, otherwise forwards the result of DoObjDescChanges(this, objdesc).</returns>
    public int DoObjDescChangesFromDefault(ACBindings.Internal.ObjDesc* objdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.ObjDesc*, int>)0x00519FB0)(ref this, objdesc);

    /// <summary>Destroys the CPartArray instance, freeing allocated resources such as physics parts and associated sequences.
    /// <code>Offset: 0x0051A000
    /// void __thiscall CPartArray::~CPartArray(CPartArray*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x0051A000)(ref this);

    /// <summary>Create a new particle array associated with the specified physics object and allocate space for the requested number of particles. The optional sorting sphere argument is not used by this implementation.
    /// <code>Offset: 0x0051A020
    /// CPartArray* __cdecl CPartArray::CreateParticle(CPhysicsObj*,unsigned int,const CSphere*)</code>
    /// </summary>
    /// <param name="owner">The physics object that will own the created particle array.</param>
    /// <param name="num_parts">Number of individual particles to allocate within the array.</param>
    /// <param name="sorting_sphere">Ignored in this function; present for API compatibility or future use.</param>
    /// <returns>A pointer to the newly initialized CPartArray on success, or null if allocation or initialization fails.</returns>
    public static ACBindings.Internal.CPartArray* CreateParticle(ACBindings.Internal.CPhysicsObj* owner, uint num_parts, ACBindings.Internal.CSphere* sorting_sphere) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CPartArray*>)0x0051A020)(owner, num_parts, sorting_sphere);

    /// <summary>Creates a new CPartArray linked to the supplied physics object and configures it with the provided setup identifiers. Initializes all internal members, associates the sequence with the owner, and assigns default scale before invoking SetSetupID. If configuration succeeds, returns the initialized array; otherwise performs cleanup and returns null.
    /// <code>Offset: 0x0051A0D0
    /// CPartArray* __cdecl CPartArray::CreateSetup(CPhysicsObj*,int,int)</code>
    /// </summary>
    /// <param name="phys_obj">The physics object that will own the created part array.</param>
    /// <param name="a2">First identifier used by SetSetupID to locate the appropriate setup.</param>
    /// <param name="a3">Second identifier used by SetSetupID for setup selection.</param>
    /// <returns>A pointer to the initialized CPartArray, or null if setup configuration fails.</returns>
    public static ACBindings.Internal.CPartArray* CreateSetup(ACBindings.Internal.CPhysicsObj* phys_obj, int a2, int a3) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, int, int, ACBindings.Internal.CPartArray*>)0x0051A0D0)(phys_obj, a2, a3);

    /// <summary>Create a new mesh representation (CPartArray) linked to the supplied physics object, initializing its state and assigning the specified mesh ID.
    /// <code>Offset: 0x0051A170
    /// CPartArray* __cdecl CPartArray::CreateMesh(CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="phys_obj">The physics object that will own and manage the created mesh.</param>
    /// <param name="a2">Identifier of the mesh to be used for this part array.</param>
    /// <returns>Pointer to the newly constructed CPartArray on success; otherwise nullptr if initialization fails.</returns>
    public static ACBindings.Internal.CPartArray* CreateMesh(ACBindings.Internal.CPhysicsObj* phys_obj, int a2) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, int, ACBindings.Internal.CPartArray*>)0x0051A170)(phys_obj, a2);
}

