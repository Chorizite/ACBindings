namespace ACBindings;

// UIObject
public unsafe struct UIObject
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // UIObject_vtbl
    public unsafe struct UIObject_vtbl
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

        // Methods
    }

    // Members
    public byte m_bVisible;
    public byte m_bTemporary;
    public uint m_eClampGameView;
    public int m_nDepth;
    public double m_tTouchTime;
    public uint m_nVirtualX;
    public uint m_nVirtualY;
    public uint m_nVirtualWidth;
    public uint m_nVirtualHeight;
    public ACBindings.Vector3 m_vScale;
    public ACBindings.UIRegion* m_pOwner;
    public ACBindings.SmartArray__Box2D m_dirtyRects;

    // Methods
    // unsigned int __cdecl UIObject::DynamicCast_UIViewportObject(const unsigned int,char*,const unsigned int)
    public static uint DynamicCast_UIViewportObject(uint ct, sbyte* buf, uint size) => ((delegate* unmanaged[Cdecl]<uint, sbyte*, uint, uint>)0x00509430)(ct, buf, size);
    // void __thiscall UIObject::SetVirtualScreenPosition(UIObject*,const unsigned int,const unsigned int,const unsigned int,const unsigned int)
    public void SetVirtualScreenPosition(uint i_x, uint i_y, uint i_width, uint i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIObject, uint, uint, uint, uint, void>)0x0069A2C0)(ref this, i_x, i_y, i_width, i_height);
    // void __thiscall UIObject::AddDirtyRect(UIObject*,const Box2D*)
    public void AddDirtyRect(ACBindings.Box2D* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIObject, ACBindings.Box2D*, void>)0x0069A530)(ref this, rect);
}

