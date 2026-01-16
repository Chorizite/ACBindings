namespace ACBindings.Internal;


/// <summary>Represents a user interface element within the application, encapsulating visual state, layout parameters, scaling, interaction timing, and ownership relationships.</summary>
/// <summary>It tracks visibility, temporary status, depth ordering, virtual positioning and sizing, scale transformation, and maintains a list of dirty rectangles for efficient redraws.</summary>
public unsafe struct UIObject
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct UIObject_vtbl
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
    public byte m_bVisible;
    public byte m_bTemporary;
    public uint m_eClampGameView;
    public int m_nDepth;
    public double m_tTouchTime;
    public uint m_nVirtualX;
    public uint m_nVirtualY;
    public uint m_nVirtualWidth;
    public uint m_nVirtualHeight;
    public ACBindings.Internal.Vector3 m_vScale;
    public ACBindings.Internal.UIRegion* m_pOwner;
    public ACBindings.Internal.SmartArray___Box2D m_dirtyRects;

    // Methods

    /// <summary>Returns zero regardless of inputs.
    /// <code>Offset: 0x00509430
    /// unsigned int __cdecl UIObject::DynamicCast_UIViewportObject(const unsigned int,char*,const unsigned int)</code>
    /// </summary>
    /// <param name="ct">Type code specifying desired cast target (currently unused).</param>
    /// <param name="buf">Pointer to a buffer where data would be written (currently unused).</param>
    /// <param name="size">Maximum number of bytes that may be written into buf (currently unused).</param>
    /// <returns>Zero.</returns>
    public static uint DynamicCast_UIViewportObject(uint ct, sbyte* buf, uint size) => ((delegate* unmanaged[Cdecl]<uint, sbyte*, uint, uint>)0x00509430)(ct, buf, size);

    /// <summary>Defines the virtual screen bounds for a UI object and triggers recalculation of its clamped position.
    /// <code>Offset: 0x0069A2C0
    /// void __thiscall UIObject::SetVirtualScreenPosition(UIObject*,const unsigned int,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="i_x">The X coordinate of the top-left corner of the virtual screen area.</param>
    /// <param name="i_y">The Y coordinate of the top-left corner of the virtual screen area.</param>
    /// <param name="i_width">The width of the virtual screen area.</param>
    /// <param name="i_height">The height of the virtual screen area.</param>
    public void SetVirtualScreenPosition(uint i_x, uint i_y, uint i_width, uint i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIObject, uint, uint, uint, uint, void>)0x0069A2C0)(ref this, i_x, i_y, i_width, i_height);

    /// <summary>Registers a region that requires repainting, updating the UIObject's dirty‑rectangle list while eliminating redundant entries. If an existing rectangle already fully covers the new one, it is left unchanged; if the new rectangle fully contains any existing ones they are removed. Partially overlapping rectangles are split into non‑overlapping sub‑rectangles which are added recursively.
    /// <code>Offset: 0x0069A530
    /// void __thiscall UIObject::AddDirtyRect(UIObject*,const Box2D*)</code>
    /// </summary>
    /// <param name="rect">Defines the area that has changed and must be repainted.</param>
    public void AddDirtyRect(ACBindings.Internal.Box2D* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIObject, ACBindings.Internal.Box2D*, void>)0x0069A530)(ref this, rect);
}

