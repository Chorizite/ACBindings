namespace ACBindings.Internal;

public unsafe struct UIRectangleObject
{
    // Base Classes
    public ACBindings.Internal.UIObject BaseClass_UIObject; // ACBindings.Internal.UIObject

    // Child Types
    public unsafe struct UIRectangleObject_vtbl
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

        // Methods
    }

    // Members
    public ACBindings.Internal.RGBAColor m_color;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00695D80
    /// void __thiscall UIRectangleObject::Render(UIRectangleObject*)</code>
    /// </summary>
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRectangleObject, void>)0x00695D80)(ref this);
}

