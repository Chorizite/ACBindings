namespace ACBindings;

// UISurfaceObject
public unsafe struct UISurfaceObject : System.IDisposable
{
    // Base Classes
    public ACBindings.UIObject BaseClass_UIObject; // ACBindings.UIObject

    // Child Types
    // UISurfaceObject_vtbl
    public unsafe struct UISurfaceObject_vtbl
    {
        // Members
        public System.IntPtr UIObject_dtor_0; // function pointer
        public System.IntPtr Render; // function pointer
        public System.IntPtr ForceUpdate; // function pointer
        public System.IntPtr SetVirtualScreenPosition; // function pointer
        public System.IntPtr SetPhysicalSize; // function pointer
        public System.IntPtr GetPhysicalSize; // function pointer
        public System.IntPtr RayTest; // function pointer
        public fixed byte gap1C[4];
        public System.IntPtr DynamicCast_UISurfaceObject; // function pointer
        public fixed byte gap24[4];
        public System.IntPtr DynamicCast_UIViewportObject; // function pointer
        public fixed byte gap2C[4];
        public System.IntPtr DynamicCast_UIRectangleObject; // function pointer
        public System.IntPtr SetTransform; // function pointer
        public System.IntPtr SetSurface; // function pointer
        public System.IntPtr SetMaterial;
        public System.IntPtr SetMaterialAlphaEnable; // function pointer
        public System.IntPtr SetMaterialColor; // function pointer
        public System.IntPtr SetMaterialOpacity; // function pointer
        public System.IntPtr GetMaterialOpacity; // function pointer
        public System.IntPtr SetMaterialFiltering; // function pointer
        public System.IntPtr SetRotateVals; // function pointer
        public System.IntPtr InqRotateVals; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Matrix4 m_transform;
    public ACBindings.Matrix4 m_invTransform;
    public ACBindings.Matrix4 m_rotMatrix;
    public ACBindings.UISurface* m_surface;
    public ACBindings.RenderMaterial* m_material;
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
    // void __thiscall UISurfaceObject::SetTransform(UISurfaceObject*,const Matrix4*)
    public void SetTransform(ACBindings.Matrix4* transform) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, ACBindings.Matrix4*, void>)0x00694E50)(ref this, transform);
    // void __thiscall UISurfaceObject::InqRotateVals(UISurfaceObject*,int*,int*,int*)
    public void InqRotateVals(int* rx, int* ry, int* rz) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, int*, int*, int*, void>)0x00694E80)(ref this, rx, ry, rz);
    // bool __thiscall UISurfaceObject::SetPhysicalSize(UISurfaceObject*,const unsigned int,const unsigned int)
    public byte SetPhysicalSize(uint i_width, uint i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, uint, uint, byte>)0x00694EB0)(ref this, i_width, i_height);
    // bool __thiscall UISurfaceObject::GetPhysicalSize(UISurfaceObject*,unsigned int*,unsigned int*)
    public byte GetPhysicalSize(uint* o_nWidth, uint* o_nHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, uint*, uint*, byte>)0x00694ED0)(ref this, o_nWidth, o_nHeight);
    // void __thiscall UISurfaceObject::ObjectToUISurface(UISurfaceObject*,const float*,const float*,int*,int*)
    public void ObjectToUISurface(float* i_fObjX, float* i_fObjY, int* o_nSurfX, int* o_nSurfY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, float*, float*, int*, int*, void>)0x00694F00)(ref this, i_fObjX, i_fObjY, o_nSurfX, o_nSurfY);
    // void __thiscall UISurfaceObject::SetSurface(UISurfaceObject*,UISurface*,const bool)
    public void SetSurface(ACBindings.UISurface* surface, byte i_bTile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, ACBindings.UISurface*, byte, void>)0x00694F70)(ref this, surface, i_bTile);
    // void __thiscall UISurfaceObject::SetMaterialColor(UISurfaceObject*,const RGBAColor*)
    public void SetMaterialColor(ACBindings.RGBAColor* Color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, ACBindings.RGBAColor*, void>)0x00694FE0)(ref this, Color);
    // void __thiscall UISurfaceObject::SetMaterialOpacity(UISurfaceObject*,const float)
    public void SetMaterialOpacity(float fOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, float, void>)0x00695040)(ref this, fOpacity);
    // void __thiscall UISurfaceObject::SetMaterialAlphaEnable(UISurfaceObject*,const bool)
    public void SetMaterialAlphaEnable(byte Enable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, byte, void>)0x006950A0)(ref this, Enable);
    // void __thiscall UISurfaceObject::SetMaterialFiltering(UISurfaceObject*,const bool)
    public void SetMaterialFiltering(byte bFiltering) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, byte, void>)0x006950F0)(ref this, bFiltering);
    // void __thiscall UISurfaceObject::Render(UISurfaceObject*)
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, void>)0x00695140)(ref this);
    // void __thiscall UISurfaceObject::UpdateTransform(UISurfaceObject*)
    public void UpdateTransform() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, void>)0x006952D0)(ref this);
    // float __thiscall UISurfaceObject::GetMaterialOpacity(UISurfaceObject*)
    public float GetMaterialOpacity() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, float>)0x00695800)(ref this);
    // void __thiscall UISurfaceObject::~UISurfaceObject(UISurfaceObject*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, void>)0x00695820)(ref this);
    // void __thiscall UISurfaceObject::SetRotateVals(UISurfaceObject*,int,int,int)
    public void SetRotateVals(int rx, int ry, int rz) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, int, int, int, void>)0x00695890)(ref this, rx, ry, rz);
    // void __thiscall UISurfaceObject::SetVirtualScreenPosition(UISurfaceObject*,const unsigned int,const unsigned int,const unsigned int,const unsigned int)
    public void SetVirtualScreenPosition(uint i_x, uint i_y, uint i_width, uint i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, uint, uint, uint, uint, void>)0x00695980)(ref this, i_x, i_y, i_width, i_height);
    // bool __thiscall UISurfaceObject::RayTest(UISurfaceObject*,const unsigned int*,const unsigned int*)
    public byte RayTest(uint* i_nScreenX, uint* i_nScreenY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, uint*, uint*, byte>)0x006959D0)(ref this, i_nScreenX, i_nScreenY);
    // RenderMaterial* __thiscall UISurfaceObject::GenerateMaterial(UISurfaceObject*)
    public ACBindings.RenderMaterial* GenerateMaterial() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, ACBindings.RenderMaterial*>)0x00695A60)(ref this);
    // RenderMaterial* __thiscall UISurfaceObject::SetMaterial(UISurfaceObject*,int)
    public ACBindings.RenderMaterial* SetMaterial(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurfaceObject, int, ACBindings.RenderMaterial*>)0x00695D00)(ref this, a2);
}

