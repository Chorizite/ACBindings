namespace ACBindings;

// gmUIElement_LinkStatusIndicator
public unsafe struct gmUIElement_LinkStatusIndicator
{
    // Base Classes
    public ACBindings.UIElement_Button BaseClass_UIElement_Button; // ACBindings.UIElement_Button
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmUIElement_LinkStatusIndicator_vtbl
    public unsafe struct gmUIElement_LinkStatusIndicator_vtbl
    {
        // Members
        public System.IntPtr UIListener_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public System.IntPtr ListenToElementMessage; // function pointer
        public System.IntPtr ListenToGlobalMessage; // function pointer
        public System.IntPtr SetVisible; // function pointer
        public System.IntPtr SetShouldBlockClicks; // function pointer
        public System.IntPtr SetShouldEraseBackground; // function pointer
        public System.IntPtr SetClampGameViewEdge; // function pointer
        public System.IntPtr CheckOverOverride; // function pointer
        public System.IntPtr MoveTo; // function pointer
        public System.IntPtr ResizeTo; // function pointer
        public System.IntPtr GetSurfaceBox; // function pointer
        public System.IntPtr CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public System.IntPtr SetParent; // function pointer
        public fixed byte gap48[4];
        public System.IntPtr MouseMove; // function pointer
        public System.IntPtr MouseOver; // function pointer
        public System.IntPtr MouseOverTop; // function pointer
        public System.IntPtr MouseHover; // function pointer
        public System.IntPtr MouseUnhover; // function pointer
        public System.IntPtr MouseDown; // function pointer
        public System.IntPtr MouseUp; // function pointer
        public System.IntPtr HasCursor; // function pointer
        public System.IntPtr AddChild; // function pointer
        public System.IntPtr RemoveChild; // function pointer
        public System.IntPtr DrawStart; // function pointer
        public System.IntPtr EraseBackground; // function pointer
        public System.IntPtr PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public System.IntPtr PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public System.IntPtr DrawDone; // function pointer
        public System.IntPtr MouseTap; // function pointer
        public System.IntPtr DynamicCast; // function pointer
        public System.IntPtr GetUIElementType; // function pointer
        public System.IntPtr SetState; // function pointer
        public System.IntPtr GetParent; // function pointer
        public System.IntPtr GetAncestorByID; // function pointer
        public System.IntPtr KeyUp; // function pointer
        public System.IntPtr KeyDown; // function pointer
        public System.IntPtr RegisterInputMaps; // function pointer
        public System.IntPtr UnregisterInputMaps; // function pointer
        public System.IntPtr OnChildAction; // function pointer
        public System.IntPtr Initialize; // function pointer
        public System.IntPtr PostInit; // function pointer
        public System.IntPtr InqAvailableProperties; // function pointer
        public System.IntPtr OnSetAttribute; // function pointer
        public System.IntPtr ContainsProperty; // function pointer
        public System.IntPtr InqProperty; // function pointer
        public System.IntPtr SetProperty; // function pointer
        public fixed byte gapD8[4];
        public System.IntPtr CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public System.IntPtr DragAndDropComplete; // function pointer
        public System.IntPtr DragItem; // function pointer
        public System.IntPtr GetDragAndDropCatcher; // function pointer
        public System.IntPtr MatchElement; // function pointer
        public System.IntPtr UpdateForChildSizeChange; // function pointer
        public System.IntPtr UpdateForParentVisibilityChange; // function pointer
        public System.IntPtr Activate; // function pointer
        public System.IntPtr Deactivate; // function pointer
        public System.IntPtr TakeFocus; // function pointer
        public System.IntPtr RelinquishFocus; // function pointer
        public System.IntPtr GetActivatable; // function pointer
        public System.IntPtr SetMouseVisible; // function pointer
        public System.IntPtr UpdateForScreenPositionChange; // function pointer
        public System.IntPtr SetUIObject; // function pointer
        public System.IntPtr MakeUIObject; // function pointer
        public System.IntPtr OnChildActivationChanged; // function pointer
        public System.IntPtr GetShouldBeMouseVisible; // function pointer
        public System.IntPtr ForwardElementMessage; // function pointer
        public System.IntPtr DefElementMessageHandler; // function pointer
        public System.IntPtr OnVisibilityChanged; // function pointer
        public System.IntPtr Initialized; // function pointer
        public System.IntPtr AdjustToScrollableXYChange; // function pointer
        public System.IntPtr InqScrollDelta; // function pointer

        // Methods
    }

    // Members
    public uint m_eLinkState;
    public double m_ttLastUpdate;
    public double m_ttLastFlash;

    // Generated Constructor
    public gmUIElement_LinkStatusIndicator(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods
    // void __thiscall gmUIElement_LinkStatusIndicator::gmUIElement_LinkStatusIndicator(gmUIElement_LinkStatusIndicator*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_LinkStatusIndicator, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004E71A0)(ref this, layout, full_desc);
    // UIElement* __thiscall gmUIElement_LinkStatusIndicator::DynamicCast(gmUIElement_LinkStatusIndicator*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_LinkStatusIndicator, uint, ACBindings.UIElement*>)0x004E7200)(ref this, i_eType);
    // UIElement* __cdecl gmUIElement_LinkStatusIndicator::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004E7240)(layout, full_desc);
    // void __thiscall gmUIElement_LinkStatusIndicator::SetLinkState(gmUIElement_LinkStatusIndicator*,unsigned int)
    public void SetLinkState(uint i_eLinkState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_LinkStatusIndicator, uint, void>)0x004E7270)(ref this, i_eLinkState);
    // void __thiscall gmUIElement_LinkStatusIndicator::PostInit(gmUIElement_LinkStatusIndicator*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_LinkStatusIndicator, void>)0x004E7360)(ref this);
    // void __cdecl gmUIElement_LinkStatusIndicator::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004E73A0)();
    // void __thiscall gmUIElement_LinkStatusIndicator::UpdateLinkState(gmUIElement_LinkStatusIndicator*)
    public void UpdateLinkState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_LinkStatusIndicator, void>)0x004E73C0)(ref this);
    // void __thiscall gmUIElement_LinkStatusIndicator::UseTime(gmUIElement_LinkStatusIndicator*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_LinkStatusIndicator, void>)0x004E7450)(ref this);
    // void __thiscall gmUIElement_LinkStatusIndicator::ListenToGlobalMessage(gmUIElement_LinkStatusIndicator*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_LinkStatusIndicator, uint, int, void>)0x004E7500)(ref this, i_messageID, i_data_int);
}

