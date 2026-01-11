namespace ACBindings.Internal;

public unsafe struct UISurfaceObject : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIObject BaseClass_UIObject; // ACBindings.Internal.UIObject

    // Child Types
    public unsafe struct UISurfaceObject_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, void> UIObject_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, void> Render; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, void> ForceUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, uint, uint, uint, uint, void> SetVirtualScreenPosition; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, uint, uint, byte> SetPhysicalSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, uint*, uint*, byte> GetPhysicalSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, uint*, uint*, byte> RayTest; // function pointer
        public fixed byte gap1C[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, ACBindings.Internal.UISurfaceObject*> DynamicCast_UISurfaceObject; // function pointer
        public fixed byte gap24[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, ACBindings.Internal.UIViewportObject*> DynamicCast_UIViewportObject; // function pointer
        public fixed byte gap2C[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIObject*, ACBindings.Internal.UIRectangleObject*> DynamicCast_UIRectangleObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, ACBindings.Internal.Matrix4*, void> SetTransform; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, ACBindings.Internal.UISurface*, byte, void> SetSurface; // function pointer
        public System.IntPtr SetMaterial;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, byte, void> SetMaterialAlphaEnable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, ACBindings.Internal.RGBAColor*, void> SetMaterialColor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, float, void> SetMaterialOpacity; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, float> GetMaterialOpacity; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, byte, void> SetMaterialFiltering; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, int, int, int, void> SetRotateVals; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurfaceObject*, int*, int*, int*, void> InqRotateVals; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00694E50
    /// void __thiscall UISurfaceObject::SetTransform(UISurfaceObject*,const Matrix4*)</code>
    /// </summary>
    public void SetTransform(ACBindings.Internal.Matrix4* transform) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, ACBindings.Internal.Matrix4*, void>)0x00694E50)(ref this, transform);

    /// <summary>
    /// <code>Offset: 0x00694E80
    /// void __thiscall UISurfaceObject::InqRotateVals(UISurfaceObject*,int*,int*,int*)</code>
    /// </summary>
    public void InqRotateVals(int* rx, int* ry, int* rz) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, int*, int*, int*, void>)0x00694E80)(ref this, rx, ry, rz);

    /// <summary>
    /// <code>Offset: 0x00694EB0
    /// bool __thiscall UISurfaceObject::SetPhysicalSize(UISurfaceObject*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public byte SetPhysicalSize(uint i_width, uint i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, uint, uint, byte>)0x00694EB0)(ref this, i_width, i_height);

    /// <summary>
    /// <code>Offset: 0x00694ED0
    /// bool __thiscall UISurfaceObject::GetPhysicalSize(UISurfaceObject*,unsigned int*,unsigned int*)</code>
    /// </summary>
    public byte GetPhysicalSize(uint* o_nWidth, uint* o_nHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, uint*, uint*, byte>)0x00694ED0)(ref this, o_nWidth, o_nHeight);

    /// <summary>
    /// <code>Offset: 0x00694F00
    /// void __thiscall UISurfaceObject::ObjectToUISurface(UISurfaceObject*,const float*,const float*,int*,int*)</code>
    /// </summary>
    public void ObjectToUISurface(float* i_fObjX, float* i_fObjY, int* o_nSurfX, int* o_nSurfY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, float*, float*, int*, int*, void>)0x00694F00)(ref this, i_fObjX, i_fObjY, o_nSurfX, o_nSurfY);

    /// <summary>
    /// <code>Offset: 0x00694F70
    /// void __thiscall UISurfaceObject::SetSurface(UISurfaceObject*,UISurface*,const bool)</code>
    /// </summary>
    public void SetSurface(ACBindings.Internal.UISurface* surface, byte i_bTile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, ACBindings.Internal.UISurface*, byte, void>)0x00694F70)(ref this, surface, i_bTile);

    /// <summary>
    /// <code>Offset: 0x00694FE0
    /// void __thiscall UISurfaceObject::SetMaterialColor(UISurfaceObject*,const RGBAColor*)</code>
    /// </summary>
    public void SetMaterialColor(ACBindings.Internal.RGBAColor* Color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, ACBindings.Internal.RGBAColor*, void>)0x00694FE0)(ref this, Color);

    /// <summary>
    /// <code>Offset: 0x00695040
    /// void __thiscall UISurfaceObject::SetMaterialOpacity(UISurfaceObject*,const float)</code>
    /// </summary>
    public void SetMaterialOpacity(float fOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, float, void>)0x00695040)(ref this, fOpacity);

    /// <summary>
    /// <code>Offset: 0x006950A0
    /// void __thiscall UISurfaceObject::SetMaterialAlphaEnable(UISurfaceObject*,const bool)</code>
    /// </summary>
    public void SetMaterialAlphaEnable(byte Enable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, byte, void>)0x006950A0)(ref this, Enable);

    /// <summary>
    /// <code>Offset: 0x006950F0
    /// void __thiscall UISurfaceObject::SetMaterialFiltering(UISurfaceObject*,const bool)</code>
    /// </summary>
    public void SetMaterialFiltering(byte bFiltering) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, byte, void>)0x006950F0)(ref this, bFiltering);

    /// <summary>
    /// <code>Offset: 0x00695140
    /// void __thiscall UISurfaceObject::Render(UISurfaceObject*)</code>
    /// </summary>
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, void>)0x00695140)(ref this);

    /// <summary>
    /// <code>Offset: 0x006952D0
    /// void __thiscall UISurfaceObject::UpdateTransform(UISurfaceObject*)</code>
    /// </summary>
    public void UpdateTransform() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, void>)0x006952D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00695800
    /// float __thiscall UISurfaceObject::GetMaterialOpacity(UISurfaceObject*)</code>
    /// </summary>
    public float GetMaterialOpacity() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, float>)0x00695800)(ref this);

    /// <summary>
    /// <code>Offset: 0x00695820
    /// void __thiscall UISurfaceObject::~UISurfaceObject(UISurfaceObject*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, void>)0x00695820)(ref this);

    /// <summary>
    /// <code>Offset: 0x00695890
    /// void __thiscall UISurfaceObject::SetRotateVals(UISurfaceObject*,int,int,int)</code>
    /// </summary>
    public void SetRotateVals(int rx, int ry, int rz) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, int, int, int, void>)0x00695890)(ref this, rx, ry, rz);

    /// <summary>
    /// <code>Offset: 0x00695980
    /// void __thiscall UISurfaceObject::SetVirtualScreenPosition(UISurfaceObject*,const unsigned int,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    public void SetVirtualScreenPosition(uint i_x, uint i_y, uint i_width, uint i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, uint, uint, uint, uint, void>)0x00695980)(ref this, i_x, i_y, i_width, i_height);

    /// <summary>
    /// <code>Offset: 0x006959D0
    /// bool __thiscall UISurfaceObject::RayTest(UISurfaceObject*,const unsigned int*,const unsigned int*)</code>
    /// </summary>
    public byte RayTest(uint* i_nScreenX, uint* i_nScreenY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, uint*, uint*, byte>)0x006959D0)(ref this, i_nScreenX, i_nScreenY);

    /// <summary>
    /// <code>Offset: 0x00695A60
    /// RenderMaterial* __thiscall UISurfaceObject::GenerateMaterial(UISurfaceObject*)</code>
    /// </summary>
    public ACBindings.Internal.RenderMaterial* GenerateMaterial() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, ACBindings.Internal.RenderMaterial*>)0x00695A60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00695D00
    /// RenderMaterial* __thiscall UISurfaceObject::SetMaterial(UISurfaceObject*,int)</code>
    /// </summary>
    public ACBindings.Internal.RenderMaterial* SetMaterial(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurfaceObject, int, ACBindings.Internal.RenderMaterial*>)0x00695D00)(ref this, a2);
}

