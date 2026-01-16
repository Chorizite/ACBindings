namespace ACBindings.Internal;


/// <summary>Encapsulates the state and behavior of a user interface surface, storing its geometry, transformation matrices, rendering material, and visual properties such as opacity, tiling, and rotation.</summary>
public unsafe struct UISurfaceObject : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIObject BaseClass_UIObject; // ACBindings.Internal.UIObject

    // Child Types
    public unsafe struct UISurfaceObject_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, void> UIObject_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, void> Render; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, void> ForceUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, uint, uint, uint, uint, void> SetVirtualScreenPosition; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, uint, uint, byte> SetPhysicalSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, uint*, uint*, byte> GetPhysicalSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, uint*, uint*, byte> RayTest; // function pointer
        public fixed byte gap1C[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, ACBindings.Internal.UISurfaceObject*> DynamicCast_UISurfaceObject; // function pointer
        public fixed byte gap24[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, ACBindings.Internal.UIViewportObject*> DynamicCast_UIViewportObject; // function pointer
        public fixed byte gap2C[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, ACBindings.Internal.UIRectangleObject*> DynamicCast_UIRectangleObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, ACBindings.Internal.Matrix4*, void> SetTransform; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, ACBindings.Internal.UISurface*, byte, void> SetSurface; // function pointer
        public System.IntPtr SetMaterial;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, byte, void> SetMaterialAlphaEnable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, ACBindings.Internal.RGBAColor*, void> SetMaterialColor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, float, void> SetMaterialOpacity; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, float> GetMaterialOpacity; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, byte, void> SetMaterialFiltering; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, int, int, int, void> SetRotateVals; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, int*, int*, int*, void> InqRotateVals; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.Matrix4 m_transform;
    public ACBindings.Internal.Matrix4 m_invTransform;
    public ACBindings.Internal.Matrix4 m_rotMatrix;
    public ACBindings.Internal.UISurface* m_surface;
    public ACBindings.Internal.RenderMaterial* m_material;
    public float m_opacity;
    public byte m_bTile;
    public int m_virtualXRot;
    public int m_virtualYRot;
    public int m_virtualZRot;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Assigns a new transformation matrix to the object and recomputes its inverse.
    /// <code>Offset: 0x00694E50
    /// void __thiscall UISurfaceObject::SetTransform(UISurfaceObject*,const Matrix4*)</code>
    /// </summary>
    /// <param name="transform">The new 4×4 transformation matrix for the surface object.</param>
    public void SetTransform(ACBindings.Internal.Matrix4* transform) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, ACBindings.Internal.Matrix4*, void>)0x00694E50)(ref this, transform);

    /// <summary>Retrieves the current virtual rotation angles of a surface object.
    /// <code>Offset: 0x00694E80
    /// void __thiscall UISurfaceObject::InqRotateVals(UISurfaceObject*,int*,int*,int*)</code>
    /// </summary>
    /// <param name="rx">Output pointer to receive the X‑axis rotation value (stored as an integer).</param>
    /// <param name="ry">Output pointer to receive the Y‑axis rotation value (stored as an integer).</param>
    /// <param name="rz">Output pointer to receive the Z‑axis rotation value (stored as an integer).</param>
    public void InqRotateVals(int* rx, int* ry, int* rz) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, int*, int*, int*, void>)0x00694E80)(ref this, rx, ry, rz);

    /// <summary>Adjusts the underlying UISurface to the specified width and height, if a surface is attached.
    /// <code>Offset: 0x00694EB0
    /// bool __thiscall UISurfaceObject::SetPhysicalSize(UISurfaceObject*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="i_width">Desired width in pixels.</param>
    /// <param name="i_height">Desired height in pixels.</param>
    /// <returns>True when the surface exists and resizing succeeds; otherwise false.</returns>
    public byte SetPhysicalSize(uint i_width, uint i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, uint, uint, byte>)0x00694EB0)(ref this, i_width, i_height);

    /// <summary>Retrieves the physical width and height of the object's underlying surface, if present.
    /// <code>Offset: 0x00694ED0
    /// bool __thiscall UISurfaceObject::GetPhysicalSize(UISurfaceObject*,unsigned int*,unsigned int*)</code>
    /// </summary>
    /// <param name="o_nWidth">Receives the physical width of the surface.</param>
    /// <param name="o_nHeight">Receives the physical height of the surface.</param>
    /// <returns>True when a valid surface exists and the dimensions are written; otherwise false.</returns>
    public byte GetPhysicalSize(uint* o_nWidth, uint* o_nHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, uint*, uint*, byte>)0x00694ED0)(ref this, o_nWidth, o_nHeight);

    /// <summary>Converts normalized object coordinates to pixel positions on the object's surface.
    /// <code>Offset: 0x00694F00
    /// void __thiscall UISurfaceObject::ObjectToUISurface(UISurfaceObject*,const float*,const float*,int*,int*)</code>
    /// </summary>
    /// <param name="this">Instance of UISurfaceObject whose surface provides the target dimensions.</param>
    /// <param name="i_fObjX">Pointer to a float representing the X coordinate in the object’s local space, expected within [–0.5, 0.5].</param>
    /// <param name="i_fObjY">Pointer to a float representing the Y coordinate in the object’s local space, expected within [–0.5, 0.5].</param>
    /// <param name="o_nSurfX">Output pointer that receives the calculated X pixel value on the surface.</param>
    /// <param name="o_nSurfY">Output pointer that receives the calculated Y pixel value on the surface.</param>
    public void ObjectToUISurface(float* i_fObjX, float* i_fObjY, int* o_nSurfX, int* o_nSurfY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, float*, float*, int*, int*, void>)0x00694F00)(ref this, i_fObjX, i_fObjY, o_nSurfX, o_nSurfY);

    /// <summary>Assigns a UISurface to this object, managing reference counts, updating virtual size, and setting tiling behavior.
    /// <code>Offset: 0x00694F70
    /// void __thiscall UISurfaceObject::SetSurface(UISurfaceObject*,UISurface*,const bool)</code>
    /// </summary>
    /// <param name="surface">The UISurface to associate with the object; its reference count is incremented.</param>
    /// <param name="i_bTile">If true, the surface will be tiled across the object's area; otherwise it will stretch or clamp.</param>
    public void SetSurface(ACBindings.Internal.UISurface* surface, byte i_bTile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, ACBindings.Internal.UISurface*, byte, void>)0x00694F70)(ref this, surface, i_bTile);

    /// <summary>Updates the diffuse color of the surface object's material when a suitable material is attached.
    /// <code>Offset: 0x00694FE0
    /// void __thiscall UISurfaceObject::SetMaterialColor(UISurfaceObject*,const RGBAColor*)</code>
    /// </summary>
    /// <param name="Color">The RGBAColor to apply as the new material color.</param>
    public void SetMaterialColor(ACBindings.Internal.RGBAColor* Color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, ACBindings.Internal.RGBAColor*, void>)0x00694FE0)(ref this, Color);

    /// <summary>Sets the transparency level for the surface's rendering material and records the value in the object.
    /// <code>Offset: 0x00695040
    /// void __thiscall UISurfaceObject::SetMaterialOpacity(UISurfaceObject*,const float)</code>
    /// </summary>
    /// <param name="fOpacity">Desired opacity (0.0 = fully transparent, 1.0 = fully opaque).</param>
    public void SetMaterialOpacity(float fOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, float, void>)0x00695040)(ref this, fOpacity);

    /// <summary>Enables or disables alpha blending on the surface object's material by setting the appropriate alpha operation flag in its first rendering stage.
    /// <code>Offset: 0x006950A0
    /// void __thiscall UISurfaceObject::SetMaterialAlphaEnable(UISurfaceObject*,const bool)</code>
    /// </summary>
    /// <param name="Enable">True to enable alpha blending; false to disable it.</param>
    public void SetMaterialAlphaEnable(byte Enable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, byte, void>)0x006950A0)(ref this, Enable);

    /// <summary>Sets the texture filtering mode of the UISurfaceObject’s material when available and valid. The min/mag filter modes are switched between nearest (false) and linear (true) based on the supplied flag.
    /// <code>Offset: 0x006950F0
    /// void __thiscall UISurfaceObject::SetMaterialFiltering(UISurfaceObject*,const bool)</code>
    /// </summary>
    /// <param name="bFiltering">Specifies whether to use linear filtering (true) or nearest filtering (false).</param>
    public void SetMaterialFiltering(byte bFiltering) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, byte, void>)0x006950F0)(ref this, bFiltering);

    /// <summary>Renders a UI surface by applying its transform and drawing its vertex/index buffers with the configured material. If the surface contains a remote texture, binds that texture to the first stage of the material before rendering and restores render device state afterward.
    /// <code>Offset: 0x00695140
    /// void __thiscall UISurfaceObject::Render(UISurfaceObject*)</code>
    /// </summary>
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, void>)0x00695140)(ref this);

    /// <summary>Recalculates the object's world transform to align its virtual size with screen coordinates, applies rotation and translation, and adjusts UV tiling settings when a surface is tiled.
    /// <code>Offset: 0x006952D0
    /// void __thiscall UISurfaceObject::UpdateTransform(UISurfaceObject*)</code>
    /// </summary>
    public void UpdateTransform() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, void>)0x006952D0)(ref this);

    /// <summary>Retrieves the current opacity of the surface object's material.
    /// <code>Offset: 0x00695800
    /// float __thiscall UISurfaceObject::GetMaterialOpacity(UISurfaceObject*)</code>
    /// </summary>
    /// <returns>The opacity value as a floating-point number between 0 and 1.</returns>
    public float GetMaterialOpacity() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, float>)0x00695800)(ref this);

    /// <summary>Releases the surface and material references held by the object, cleans up allocated resources such as dirty rectangles, and restores base class vtables before the instance is destroyed.
    /// <code>Offset: 0x00695820
    /// void __thiscall UISurfaceObject::~UISurfaceObject(UISurfaceObject*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, void>)0x00695820)(ref this);

    /// <summary>Sets the object's virtual X, Y, and Z rotation values in degrees, recomputes its rotation matrix, and updates the overall transformation.
    /// <code>Offset: 0x00695890
    /// void __thiscall UISurfaceObject::SetRotateVals(UISurfaceObject*,int,int,int)</code>
    /// </summary>
    /// <param name="rx">Rotation around the X axis (degrees).</param>
    /// <param name="ry">Rotation around the Y axis (degrees).</param>
    /// <param name="rz">Rotation around the Z axis (degrees).</param>
    public void SetRotateVals(int rx, int ry, int rz) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, int, int, int, void>)0x00695890)(ref this, rx, ry, rz);

    /// <summary>Assigns the virtual screen position and dimensions of the surface object, updating its transform matrix accordingly.
    /// <code>Offset: 0x00695980
    /// void __thiscall UISurfaceObject::SetVirtualScreenPosition(UISurfaceObject*,const unsigned int,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="i_x">The X coordinate of the object's top-left corner in virtual screen space.</param>
    /// <param name="i_y">The Y coordinate of the object's top-left corner in virtual screen space.</param>
    /// <param name="i_width">The width of the object in virtual screen units.</param>
    /// <param name="i_height">The height of the object in virtual screen units.</param>
    public void SetVirtualScreenPosition(uint i_x, uint i_y, uint i_width, uint i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, uint, uint, uint, uint, void>)0x00695980)(ref this, i_x, i_y, i_width, i_height);

    /// <summary>Determines if a ray cast from the specified screen coordinates intersects this surface object by converting screen position into clip space, transforming to surface pixel coordinates, and checking bounds against the object's physical dimensions.
    /// <code>Offset: 0x006959D0
    /// bool __thiscall UISurfaceObject::RayTest(UISurfaceObject*,const unsigned int*,const unsigned int*)</code>
    /// </summary>
    /// <param name="i_nScreenX">Pointer to an unsigned int containing the X coordinate on the screen.</param>
    /// <param name="i_nScreenY">Pointer to an unsigned int containing the Y coordinate on the screen.</param>
    /// <returns>True if the coordinates map inside the surface bounds; otherwise false.</returns>
    public byte RayTest(uint* i_nScreenX, uint* i_nScreenY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, uint*, uint*, byte>)0x006959D0)(ref this, i_nScreenX, i_nScreenY);

    /// <summary>Create and configure a RenderMaterial based on the UISurfaceObject’s surface properties, tiling flag, and virtual/physical dimensions. If tiling is enabled and a surface exists, UV scaling is applied to match virtual size to physical texture size. The material is then optimized before being returned.
    /// <code>Offset: 0x00695A60
    /// RenderMaterial* __thiscall UISurfaceObject::GenerateMaterial(UISurfaceObject*)</code>
    /// </summary>
    /// <returns>A pointer to the constructed RenderMaterial, or nullptr if allocation fails or necessary data (material, layer, stage) cannot be created.</returns>
    public ACBindings.Internal.RenderMaterial* GenerateMaterial() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, ACBindings.Internal.RenderMaterial*>)0x00695A60)(ref this);

    /// <summary>
    /// Releases any currently assigned material and assigns a new RenderMaterial to the surface object based on the supplied data identifier.
    /// If the identifier equals INVALID_DID_450.baseclass_0.id, a default material is generated; otherwise the function attempts to load the material from the database and falls back to a virtual handler when loading fails.
    /// 
    /// <code>Offset: 0x00695D00
    /// RenderMaterial* __thiscall UISurfaceObject::SetMaterial(UISurfaceObject*,int)</code>
    /// </summary>
    /// <param name="a2">Data identifier for the desired RenderMaterial. A value of INVALID_DID_450.baseclass_0.id signals that a default material should be created automatically.</param>
    /// <returns>Pointer to the RenderMaterial now associated with this UISurfaceObject, possibly obtained from the database or via a virtual fallback if the lookup fails.</returns>
    public ACBindings.Internal.RenderMaterial* SetMaterial(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, int, ACBindings.Internal.RenderMaterial*>)0x00695D00)(ref this, a2);
}

