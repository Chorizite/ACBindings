namespace ACBindings.Internal;

public unsafe struct UIElement_ColorPicker
{
    // Base Classes
    public ACBindings.Internal.UIElement BaseClass_UIElement; // ACBindings.Internal.UIElement

    // Child Types
    public unsafe struct UIElement_ColorPicker_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*> GetSurfaceBox; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> HasCursor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawStart; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> EraseBackground; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawDone; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> SetState; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetParent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> GetAncestorByID; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> Initialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> PostInit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, ACBindings.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement**, byte> DragItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> MatchElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Activate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Deactivate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> TakeFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetActivatable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject*, byte> SetUIObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer

        // Methods
    }

    // Members
    public byte m_bDisplaySelection;
    public ACBindings.Internal.RGBAColor m_rgbaCurrentSelected;
    public uint m_nCurrentSelection;

    // Generated Constructor
    public UIElement_ColorPicker(ACBindings.Internal.LayoutDesc* i_layout, ACBindings.Internal.ElementDesc* i_full_desc) {
        _ConstructorInternal(i_layout, i_full_desc);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0046B0C0
    /// void __thiscall UIElement_ColorPicker::UIElement_ColorPicker(UIElement_ColorPicker*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* i_layout, ACBindings.Internal.ElementDesc* i_full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ColorPicker, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0046B0C0)(ref this, i_layout, i_full_desc);

    /// <summary>
    /// <code>Offset: 0x0046B120
    /// UIElement* __thiscall UIElement_ColorPicker::DynamicCast(UIElement_ColorPicker*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ColorPicker, uint, ACBindings.Internal.UIElement*>)0x0046B120)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x0046B140
    /// UIElement* __cdecl UIElement_ColorPicker::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0046B140)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0046B170
    /// bool __thiscall UIElement_ColorPicker::SetCurrentSelectedColor(UIElement_ColorPicker*,const RGBAColor*)</code>
    /// </summary>
    public byte SetCurrentSelectedColor(ACBindings.Internal.RGBAColor* i_rgba) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ColorPicker, ACBindings.Internal.RGBAColor*, byte>)0x0046B170)(ref this, i_rgba);

    /// <summary>
    /// <code>Offset: 0x0046B220
    /// bool __thiscall UIElement_ColorPicker::IndexToRGBA(UIElement_ColorPicker*,const unsigned int*,RGBAColor*)</code>
    /// </summary>
    public byte IndexToRGBA(uint* i_index, ACBindings.Internal.RGBAColor* o_rgbaVal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ColorPicker, uint*, ACBindings.Internal.RGBAColor*, byte>)0x0046B220)(ref this, i_index, o_rgbaVal);

    /// <summary>
    /// <code>Offset: 0x0046B280
    /// void __thiscall UIElement_ColorPicker::HandleMouseClick(UIElement_ColorPicker*,const tagPOINT*)</code>
    /// </summary>
    public void HandleMouseClick(ACBindings.Internal.tagPOINT* i_ptElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ColorPicker, ACBindings.Internal.tagPOINT*, void>)0x0046B280)(ref this, i_ptElement);

    /// <summary>
    /// <code>Offset: 0x0046B300
    /// bool __thiscall UIElement_ColorPicker::GetShouldBeMouseVisible(UIElement_ColorPicker*)</code>
    /// </summary>
    public byte GetShouldBeMouseVisible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ColorPicker, byte>)0x0046B300)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046B320
    /// void __thiscall UIElement_ColorPicker::DrawSelf(_DWORD*,Box2D*,int,_DWORD*,UISurface*)</code>
    /// </summary>
    public void DrawSelf(ACBindings.Internal.Box2D* a2, int a3, int* a4, ACBindings.Internal.UISurface* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ColorPicker, ACBindings.Internal.Box2D*, int, int*, ACBindings.Internal.UISurface*, void>)0x0046B320)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x0046B440
    /// void __thiscall UIElement_ColorPicker::OnSetAttribute(UIElement_ColorPicker*,const BaseProperty*)</code>
    /// </summary>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* i_attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ColorPicker, ACBindings.Internal.BaseProperty*, void>)0x0046B440)(ref this, i_attribute);

    /// <summary>
    /// <code>Offset: 0x0046B4E0
    /// UIElementMessageListenResult __thiscall UIElement_ColorPicker::ListenToElementMessage(UIElement_ColorPicker*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ColorPicker, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0046B4E0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x0046B510
    /// bool __thiscall UIElement_ColorPicker::InqAvailableProperties(UIElement_ColorPicker*,AvailablePropertySet*)</code>
    /// </summary>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* o_set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ColorPicker, ACBindings.Internal.AvailablePropertySet*, byte>)0x0046B510)(ref this, o_set);
}

