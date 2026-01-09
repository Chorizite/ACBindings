namespace ACBindings;

// UIRectangleObject
public unsafe struct UIRectangleObject
{
    // Base Classes
    public ACBindings.UIObject BaseClass_UIObject; // ACBindings.UIObject

    // Child Types
    // UIRectangleObject_vtbl
    public unsafe struct UIRectangleObject_vtbl
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
    public ACBindings.RGBAColor m_color;

    // Methods
    // void __thiscall UIRectangleObject::Render(UIRectangleObject*)
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRectangleObject, void>)0x00695D80)(ref this);
}

