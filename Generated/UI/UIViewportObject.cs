namespace ACBindings.Internal;

public unsafe struct UIViewportObject
{
    // Base Classes
    public ACBindings.Internal.UIObject BaseClass_UIObject; // ACBindings.Internal.UIObject

    // Child Types
    public unsafe struct UIViewportObject_vtbl
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
    public float m_rOriginalVDist;
    public byte m_fOriginalDegrades;

    // Generated Constructor
    public UIViewportObject() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00695F50
    /// void __thiscall UIViewportObject::Render(UIViewportObject*)</code>
    /// </summary>
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIViewportObject, void>)0x00695F50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00696020
    /// void __thiscall UIViewportObject::UIViewportObject(UIViewportObject*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIViewportObject, void>)0x00696020)(ref this);
}

