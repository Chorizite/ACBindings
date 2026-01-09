namespace ACBindings;

// UIViewportObject
public unsafe struct UIViewportObject
{
    // Base Classes
    public ACBindings.UIObject BaseClass_UIObject; // ACBindings.UIObject

    // Child Types
    // UIViewportObject_vtbl
    public unsafe struct UIViewportObject_vtbl
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
    public float m_rOriginalVDist;
    public byte m_fOriginalDegrades;

    // Generated Constructor
    public UIViewportObject() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall UIViewportObject::Render(UIViewportObject*)
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIViewportObject, void>)0x00695F50)(ref this);
    // void __thiscall UIViewportObject::UIViewportObject(UIViewportObject*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIViewportObject, void>)0x00696020)(ref this);
}

