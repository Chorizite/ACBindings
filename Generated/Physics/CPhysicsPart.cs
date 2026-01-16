namespace ACBindings.Internal;


/// <summary>Represents a physical component within the rendering engine, storing transformation data, visual properties, and references to associated graphics objects and materials for rendering and physics simulation.</summary>
public unsafe struct CPhysicsPart : System.IDisposable
{
    // Statics
    public static uint* viewcone_check_object_id = (uint*)0x00844BFC;
    public static int* selected_object_in_view = (int*)0x00844C00;
    public static int* creature_mode = (int*)0x00844C04;
    public static uint* player_iid = (uint*)0x00844C08;

    // Child Types
    // CPhysicsPart::PartDrawState
    public enum PartDrawState : uint
    {
        DEFAULT_DS = 0x0,
        NODRAW_DS = 0x1,
        FORCE_PartDrawState_32_BIT = 0x7FFFFFFF
    }

    // Members
    public float CYpt;
    public ACBindings.Internal.AC1Legacy.Vector3 viewer_heading;
    public ACBindings.Internal.GfxObjDegradeInfo* degrades;
    public uint deg_level;
    public int deg_mode;
    public int draw_state;
    public ACBindings.Internal.CGfxObj** gfxobj;
    public ACBindings.Internal.AC1Legacy.Vector3 gfxobj_scale;
    public ACBindings.Internal.Position pos;
    public ACBindings.Internal.Position draw_pos;
    public ACBindings.Internal.CMaterial* material;
    public ACBindings.Internal.CSurface** surfaces;
    public ACBindings.Internal.IDClass____tagDataID original_palette_id;
    public float curTranslucency;
    public float curDiffuse;
    public float curLuminosity;
    public ACBindings.Internal.Palette* shiftPal;
    public uint m_current_render_frame_num;
    public ACBindings.Internal.CPhysicsObj* physobj;
    public int physobj_index;

    // Generated Constructor
    public CPhysicsPart() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves the identifier of the associated physics object, or zero when none exists.
    /// <code>Offset: 0x0050DF60
    /// unsigned int __thiscall CPhysicsPart::get_physobj_id(CPhysicsPart*)</code>
    /// </summary>
    /// <returns>The unique ID of the physics object, or 0 if the part is not linked to a physics object.</returns>
    public uint get_physobj_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, uint>)0x0050DF60)(ref this);

    /// <summary>Determines whether this physics part belongs to the current player object.
    /// <code>Offset: 0x0050DF80
    /// bool __thiscall CPhysicsPart::IsPartOfPlayerObj(CPhysicsPart*)</code>
    /// </summary>
    /// <returns>True if the part’s underlying CPhysicsObj is the globally referenced player object; otherwise, false.</returns>
    public byte IsPartOfPlayerObj() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, byte>)0x0050DF80)(ref this);

    /// <summary>Reports whether the part was rendered in the current frame.
    /// <code>Offset: 0x0050DFA0
    /// bool __thiscall CPhysicsPart::GetDrawnThisFrame(CPhysicsPart*)</code>
    /// </summary>
    /// <returns>True if the part has been drawn during the current rendering cycle; otherwise, false.</returns>
    public byte GetDrawnThisFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, byte>)0x0050DFA0)(ref this);

    /// <summary>Records the current render frame number in the physics part, marking it as drawn for this frame.
    /// <code>Offset: 0x0050DFC0
    /// void __thiscall CPhysicsPart::SetDrawnThisFrame(CPhysicsPart*)</code>
    /// </summary>
    public void SetDrawnThisFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050DFC0)(ref this);

    /// <summary>Obtains the maximum distance at which a physics part degrades, using stored degrade information or defaulting to 100 when none is available.
    /// <code>Offset: 0x0050DFE0
    /// float __thiscall CPhysicsPart::GetMaxDegradeDistance(CPhysicsPart*)</code>
    /// </summary>
    /// <returns>The maximum degradation distance; defaults to 100 if no degradation data exists for this part.</returns>
    public float GetMaxDegradeDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, float>)0x0050DFE0)(ref this);

    /// <summary>Releases a GfxObjDegradeInfo instance and an array of CGfxObj objects, freeing associated resources and clearing the provided pointers.
    /// <code>Offset: 0x0050E000
    /// void __cdecl CPhysicsPart::ReleaseGfxObjArray(GfxObjDegradeInfo**,CGfxObj***)</code>
    /// </summary>
    /// <param name="old_degrades">Double pointer to a GfxObjDegradeInfo instance; if non‑null, its contents are released and the pointer set to null.</param>
    /// <param name="old_gfxobj">Triple pointer to an array of CGfxObj instances; each object is released, the array memory freed, and the pointer reset to null.</param>
    public static void ReleaseGfxObjArray(ACBindings.Internal.GfxObjDegradeInfo** old_degrades, ACBindings.Internal.CGfxObj*** old_gfxobj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.GfxObjDegradeInfo**, ACBindings.Internal.CGfxObj***, void>)0x0050E000)(old_degrades, old_gfxobj);

    /// <summary>Retrieves the original palette identifier associated with this physics part.
    /// <code>Offset: 0x0050E070
    /// _DWORD* __thiscall CPhysicsPart::GetOriginalPaletteID(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a DWORD that will receive the palette ID.</param>
    /// <returns>The same pointer supplied in *a2, now pointing to the stored palette ID value.</returns>
    public int* GetOriginalPaletteID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int*, int*>)0x0050E070)(ref this, a2);

    /// <summary>Restores surface palettes for the physics part and releases any temporary palette shift used during rendering.
    /// <code>Offset: 0x0050E080
    /// void __thiscall CPhysicsPart::RestorePalette(CPhysicsPart*)</code>
    /// </summary>
    public void RestorePalette() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050E080)(ref this);

    /// <summary>Retrieves the axis-aligned bounding box defined by the first graphics object of this physics part.
    /// <code>Offset: 0x0050E0D0
    /// const BBox* __thiscall CPhysicsPart::GetBoundingBox(CPhysicsPart*)</code>
    /// </summary>
    /// <returns>A pointer to the BBox structure representing the part's bounding volume.</returns>
    public ACBindings.Internal.BBox* GetBoundingBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, ACBindings.Internal.BBox*>)0x0050E0D0)(ref this);

    /// <summary>Sets or clears the part’s draw flag based on the supplied value.
    /// <code>Offset: 0x0050E0E0
    /// void __thiscall CPhysicsPart::SetNoDraw(CPhysicsPart*,int)</code>
    /// </summary>
    /// <param name="no_draw">Non‑zero to disable drawing; zero to enable drawing.</param>
    public void SetNoDraw(int no_draw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int, void>)0x0050E0E0)(ref this, no_draw);

    /// <summary>Creates an independent copy of the material referenced by the part’s first graphical object if that material is currently shared with the part; otherwise leaves the material unchanged.
    /// <code>Offset: 0x0050E100
    /// int __thiscall CPhysicsPart::CopyMaterial(CPhysicsPart*)</code>
    /// </summary>
    /// <returns>Non‑zero if the operation succeeded or was unnecessary, zero if memory allocation failed.</returns>
    public int CopyMaterial() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int>)0x0050E100)(ref this);

    /// <summary>Copies the surface definitions from the part's graphics object into its own surface array, creating custom copies of each surface. Returns non‑zero on success and zero if allocation fails or a copy operation fails.
    /// <code>Offset: 0x0050E170
    /// int __thiscall CPhysicsPart::CopySurfaces(CPhysicsPart*)</code>
    /// </summary>
    /// <returns>An integer: 1 for successful copy (or when already copied), 0 if an error occurs.</returns>
    public int CopySurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int>)0x0050E170)(ref this);

    /// <summary>Restores surface references of the physics part from its associated graphics object, releasing any custom surfaces and updating pointers if they differ.
    /// <code>Offset: 0x0050E200
    /// void __thiscall CPhysicsPart::RestoreSurfaces(CPhysicsPart*)</code>
    /// </summary>
    public void RestoreSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050E200)(ref this);

    /// <summary>Renders the physics part if it has not yet been drawn for the current frame, selecting an appropriate degradation level and applying material, surface, and scale settings before drawing via the render device. If rendering completes with a special result code (2) and the object's ID matches a global view‑cone check ID, marks the object as selected in view.
    /// <code>Offset: 0x0050E270
    /// void __thiscall CPhysicsPart::Draw(CPhysicsPart*,int)</code>
    /// </summary>
    /// <param name="building_flag">Non‑zero forces drawing of the part regardless of the current frame number and signals building‑mode rendering to the renderer; zero allows normal per‑frame draw logic.</param>
    public void Draw(int building_flag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int, void>)0x0050E270)(ref this, building_flag);

    /// <summary>Determines whether the physics part is forced to render in 2D based on its degradation configuration.
    /// <code>Offset: 0x0050E370
    /// int __thiscall CPhysicsPart::Always2D(CPhysicsPart*)</code>
    /// </summary>
    /// <returns>Non‑zero when a degradation exists, at least one degrade entry is present, and the first degrade mode is not equal to 1; otherwise zero.</returns>
    public int Always2D() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int>)0x0050E370)(ref this);

    /// <summary>Detects collisions for the physics part by delegating to its graphic object when available.
    /// <code>Offset: 0x0050E3A0
    /// TransitionState __thiscall CPhysicsPart::find_obj_collisions(CPhysicsPart*,CTransition*)</code>
    /// </summary>
    /// <param name="transition">The transition data containing collision information and sphere path used during detection.</param>
    /// <returns>A TransitionState value indicating whether a collision was found; returns OK_TS if no graphic object or physics BSP is present, otherwise forwards the result from CGfxObj::find_obj_collisions.</returns>
    public ACBindings.Internal.TransitionState find_obj_collisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0050E3A0)(ref this, transition);

    /// <summary>Determines whether the physics part’s rendering parameters (translucency, diffuse color, luminosity) match the defaults derived from its first graphics object’s material.
    /// <code>Offset: 0x0050E4B0
    /// bool __thiscall CPhysicsPart::CurSettingsAreDefault(CPhysicsPart*)</code>
    /// </summary>
    /// <returns>True if all current settings equal the calculated defaults; otherwise false.</returns>
    public byte CurSettingsAreDefault() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, byte>)0x0050E4B0)(ref this);

    /// <summary>Initializes a CPhysicsPart instance with default spatial properties, rendering configuration, and physics placeholders.
    /// <code>Offset: 0x0050E550
    /// void __thiscall CPhysicsPart::CPhysicsPart(CPhysicsPart*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050E550)(ref this);

    /// <summary>Copies the visual representation and related attributes from a template physics part into this instance, updating graphics objects, scales, positions, palette IDs, and surface references.
    /// <code>Offset: 0x0050E640
    /// bool __thiscall CPhysicsPart::MorphToExistingObject(CPhysicsPart*,const CPhysicsPart*)</code>
    /// </summary>
    /// <param name="pTemplate">The source physics part whose properties are copied.</param>
    /// <returns>true to indicate successful morphing; always true in current implementation.</returns>
    public byte MorphToExistingObject(ACBindings.Internal.CPhysicsPart* pTemplate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, ACBindings.Internal.CPhysicsPart*, byte>)0x0050E640)(ref this, pTemplate);

    /// <summary>Examines the physics part’s associated surface objects to locate a valid original palette identifier and assigns it to original_palette_id; if none is found, assigns INVALID_DID_213.
    /// <code>Offset: 0x0050E750
    /// void __thiscall CPhysicsPart::DetermineBasePal(CPhysicsPart*)</code>
    /// </summary>
    public void DetermineBasePal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050E750)(ref this);

    /// <summary>Loads graphical objects and associated degradation data for a physics part identified by the supplied ID, allocating and filling output arrays with references to the retrieved CGfxObj instances.
    /// <code>Offset: 0x0050E7C0
    /// int __cdecl CPhysicsPart::LoadGfxObjArray(int,GfxObjDegradeInfo**,CGfxObj***)</code>
    /// </summary>
    /// <param name="a1">The unique identifier of the physics part whose graphics assets should be loaded.</param>
    /// <param name="old_degrades">Receives a pointer to the GfxObjDegradeInfo structure obtained from the database; may remain null if no degradation data exists.</param>
    /// <param name="old_gfxobj">Receives an array of CGfxObj pointers, one per degradation level, allocated by the function and initialized with references to the corresponding graphics objects.</param>
    /// <returns>Non‑zero on success, zero if the physics part could not be found or no valid graphics objects were retrieved.</returns>
    public static int LoadGfxObjArray(int a1, ACBindings.Internal.GfxObjDegradeInfo** old_degrades, ACBindings.Internal.CGfxObj*** old_gfxobj) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.GfxObjDegradeInfo**, ACBindings.Internal.CGfxObj***, int>)0x0050E7C0)(a1, old_degrades, old_gfxobj);

    /// <summary>Replaces the texture map of this physics part’s surfaces that use a specified original texture ID with a new texture ID.
    /// <code>Offset: 0x0050E900
    /// int __thiscall CPhysicsPart::SetTextureMap(CPhysicsPart*,int,int)</code>
    /// </summary>
    /// <param name="originalTextureId">The identifier of the texture map to be replaced on matching surfaces.</param>
    /// <param name="newTextureId">The identifier of the texture map to apply to those surfaces.</param>
    /// <returns>Zero if a surface was successfully updated; one if no matching surfaces were found or if there are no surfaces to update.</returns>
    public int SetTextureMap(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int, int, int>)0x0050E900)(ref this, a2, a3);

    /// <summary>Applies the specified color palette to all surfaces of this physics part, updating internal references and freeing any previous temporary palette. Returns 1 on success or 0 if no palette is supplied or surface copying fails.
    /// <code>Offset: 0x0050E9A0
    /// int __thiscall CPhysicsPart::UsePalette(CPhysicsPart*,Palette*)</code>
    /// </summary>
    /// <param name="pal">Palette to apply; must not be null for successful operation.</param>
    /// <returns>1 if the palette was applied successfully; otherwise 0.</returns>
    public int UsePalette(ACBindings.Internal.Palette* pal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, ACBindings.Internal.Palette*, int>)0x0050E9A0)(ref this, pal);

    /// <summary>Reverts the physics part to its default material state by releasing any custom material reference and clearing the material pointer.
    /// <code>Offset: 0x0050EA40
    /// void __thiscall CPhysicsPart::RestoreMaterial(CPhysicsPart*)</code>
    /// </summary>
    public void RestoreMaterial() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050EA40)(ref this);

    /// <summary>Updates the drawing position and orientation of a physics part by copying its current pose and adjusting it according to the degradation mode relative to the viewer’s heading.
    /// <code>Offset: 0x0050EA70
    /// void __thiscall CPhysicsPart::calc_draw_frame(CPhysicsPart*)</code>
    /// </summary>
    public void calc_draw_frame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050EA70)(ref this);

    /// <summary>Computes the distance from the object to the viewer, normalizes the heading vector toward the viewer, updates degradation level based on that distance, and triggers a draw frame calculation when necessary.
    /// <code>Offset: 0x0050EB00
    /// void __thiscall CPhysicsPart::UpdateViewerDistance(CPhysicsPart*)</code>
    /// </summary>
    public void UpdateViewerDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050EB00)(ref this);

    /// <summary>Updates internal rendering parameters for a physics part based on the viewer’s position and direction, calculates degradation level when applicable, and initiates a new draw frame if necessary.
    /// <code>Offset: 0x0050EC70
    /// void __thiscall CPhysicsPart::UpdateViewerDistance(CPhysicsPart*,float,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="CYpt">Distance from the viewer to the part used to determine degradation scaling.</param>
    /// <param name="viewer_heading">Vector representing the viewer’s heading relative to the part.</param>
    public void UpdateViewerDistance(float CYpt, ACBindings.Internal.AC1Legacy.Vector3* viewer_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, float, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0050EC70)(ref this, CYpt, viewer_heading);

    /// <summary>Creates a new physics part instance, optionally initializing it with data from the supplied template.
    /// <code>Offset: 0x0050ED00
    /// CPhysicsPart* __cdecl CPhysicsPart::makePhysicsPart(const CPhysicsPart*)</code>
    /// </summary>
    /// <param name="pTemplate">The optional source object whose properties are copied into the new part; may be nullptr.</param>
    /// <returns>A pointer to the newly allocated CPhysicsPart or nullptr if memory allocation fails.</returns>
    public static ACBindings.Internal.CPhysicsPart* makePhysicsPart(ACBindings.Internal.CPhysicsPart* pTemplate) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsPart*, ACBindings.Internal.CPhysicsPart*>)0x0050ED00)(pTemplate);

    /// <summary>Destroys a CPhysicsPart instance by releasing its shift palette, associated graphics objects and material references, restoring surface data, freeing the graphics object array, and resetting position objects to their base vtable state.
    /// <code>Offset: 0x0050ED40
    /// void __thiscall CPhysicsPart::~CPhysicsPart(CPhysicsPart*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050ED40)(ref this);

    /// <summary>Replaces the physics part’s graphics objects and degradation data with new values, updating material attributes and surfaces, and applies any shift palette if present.
    /// <code>Offset: 0x0050EDB0
    /// void __thiscall CPhysicsPart::SetGfxObjArray(CPhysicsPart*,GfxObjDegradeInfo*,CGfxObj**)</code>
    /// </summary>
    /// <param name="new_degrades">Pointer to a GfxObjDegradeInfo structure containing information about degraded graphics states.</param>
    /// <param name="new_gfxobj">Array of CGfxObj pointers that will become the part’s new graphical representation; the first element is used for surface and material data.</param>
    public void SetGfxObjArray(ACBindings.Internal.GfxObjDegradeInfo* new_degrades, ACBindings.Internal.CGfxObj** new_gfxobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, ACBindings.Internal.GfxObjDegradeInfo*, ACBindings.Internal.CGfxObj**, void>)0x0050EDB0)(ref this, new_degrades, new_gfxobj);

    /// <summary>Applies a shift palette if present and finalizes surface initialization for the physics part.
    /// <code>Offset: 0x0050EE80
    /// int __thiscall CPhysicsPart::InitObjDescChanges(CPhysicsPart*)</code>
    /// </summary>
    /// <returns>Always returns 1 to indicate successful completion.</returns>
    public int InitObjDescChanges() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int>)0x0050EE80)(ref this);

    /// <summary>Updates the part's lighting properties when either luminosity or diffuse changes, adjusting its material accordingly.
    /// <code>Offset: 0x0050EED0
    /// void __thiscall CPhysicsPart::SetLighting(CPhysicsPart*,float,float)</code>
    /// </summary>
    /// <param name="luminosity">Desired luminosity to apply.</param>
    /// <param name="diffuse">Desired diffuse factor to apply.</param>
    public void SetLighting(float luminosity, float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, float, float, void>)0x0050EED0)(ref this, luminosity, diffuse);

    /// <summary>Restores the lighting state of a physics part by comparing its current translucency with the stored value, updating or resetting its material reference accordingly, and setting new lighting parameters derived from its associated graphics object's material properties.
    /// <code>Offset: 0x0050EF70
    /// void __thiscall CPhysicsPart::RestoreLighting(CPhysicsPart*)</code>
    /// </summary>
    public void RestoreLighting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050EF70)(ref this);

    /// <summary>Adjusts the diffusion factor of the physics part, updating or resetting its material to reflect the new value.
    /// <code>Offset: 0x0050F040
    /// void __thiscall CPhysicsPart::SetDiffusion(CPhysicsPart*,float)</code>
    /// </summary>
    /// <param name="diffuse">The desired diffusion level to set on this part.</param>
    public void SetDiffusion(float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, float, void>)0x0050F040)(ref this, diffuse);

    /// <summary>Sets the part's luminosity, updating its material when appropriate.
    /// <code>Offset: 0x0050F0C0
    /// void __thiscall CPhysicsPart::SetLuminosity(CPhysicsPart*,float)</code>
    /// </summary>
    /// <param name="luminosity">The new luminosity value to apply to this physics part.</param>
    public void SetLuminosity(float luminosity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, float, void>)0x0050F0C0)(ref this, luminosity);

    /// <summary>Sets the translucency level of this physics part and updates its rendering state and material accordingly.
    /// <code>Offset: 0x0050F140
    /// void __thiscall CPhysicsPart::SetTranslucency(CPhysicsPart*,float)</code>
    /// </summary>
    /// <param name="translucency">The desired translucency value (typically 0.0 to 1.0).</param>
    public void SetTranslucency(float translucency) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, float, void>)0x0050F140)(ref this, translucency);

    /// <summary>Sets the graphics objects for this physics part by loading the specified gfx objects and updating internal references.
    /// <code>Offset: 0x0050F1D0
    /// int __thiscall CPhysicsPart::SetPart(CPhysicsPart*,CGfxObj**)</code>
    /// </summary>
    /// <param name="new_gfxobj">Pointer to an identifier or container of CGfxObj structures; may be replaced with loaded data during the call.</param>
    /// <returns>Non‑zero if the operation succeeded, zero on failure (e.g., invalid ID or load error).</returns>
    public int SetPart(ACBindings.Internal.CGfxObj** new_gfxobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, ACBindings.Internal.CGfxObj**, int>)0x0050F1D0)(ref this, new_gfxobj);

    /// <summary>Creates a new physics part from the supplied graphics objects, initializing internal state and linking it to the given CGfxObj array. If allocation or initialization fails, cleans up and returns null.
    /// <code>Offset: 0x0050F230
    /// CPhysicsPart* __cdecl CPhysicsPart::makePhysicsPart(CGfxObj**)</code>
    /// </summary>
    /// <param name="a1">Pointer to an array of CGfxObj pointers that define the geometry and surfaces for the physics part.</param>
    /// <returns>Pointer to a newly allocated CPhysicsPart instance initialized from the provided graphics objects, or null if allocation or initialization fails.</returns>
    public static ACBindings.Internal.CPhysicsPart* makePhysicsPart(ACBindings.Internal.CGfxObj** a1) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CGfxObj**, ACBindings.Internal.CPhysicsPart*>)0x0050F230)(a1);
}

