namespace ACBindings.Internal;


/// <summary>Handles viewport configuration for a UI object, preserving its initial view‑distance and degradation status so that rendering can be accurately restored after temporary changes.</summary>
public unsafe struct UIViewportObject
{
    // Base Classes
    public ACBindings.Internal.UIObject BaseClass_UIObject; // ACBindings.Internal.UIObject

    // Child Types
    public unsafe struct UIViewportObject_vtbl
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

    /// <summary>Renders the viewport owned by this UI object when an associated creature mode exists, setting up rendering state, clearing the area to black, drawing the child, and restoring the original matrices.
    /// <code>Offset: 0x00695F50
    /// void __thiscall UIViewportObject::Render(UIViewportObject*)</code>
    /// </summary>
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIViewportObject, void>)0x00695F50)(ref this);

    /// <summary>Initializes a new UIViewportObject by constructing the base UIObject and setting up default viewport properties.
    /// <code>Offset: 0x00696020
    /// void __thiscall UIViewportObject::UIViewportObject(UIViewportObject*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIViewportObject, void>)0x00696020)(ref this);
}

