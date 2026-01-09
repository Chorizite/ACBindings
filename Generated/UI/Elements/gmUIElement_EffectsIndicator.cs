namespace ACBindings;

// gmUIElement_EffectsIndicator
public unsafe struct gmUIElement_EffectsIndicator
{
    // Base Classes
    public ACBindings.UIElement_Button BaseClass_UIElement_Button; // ACBindings.UIElement_Button
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmUIElement_EffectsIndicator_vtbl
    public unsafe struct gmUIElement_EffectsIndicator_vtbl
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
    public uint m_eEffectTypeIndicator;

    // Generated Constructor
    public gmUIElement_EffectsIndicator(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods
    // void __thiscall gmUIElement_EffectsIndicator::gmUIElement_EffectsIndicator(gmUIElement_EffectsIndicator*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_EffectsIndicator, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004E7530)(ref this, layout, full_desc);
    // UIElement* __thiscall gmUIElement_EffectsIndicator::DynamicCast(gmUIElement_EffectsIndicator*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_EffectsIndicator, uint, ACBindings.UIElement*>)0x004E7580)(ref this, i_eType);
    // unsigned int __thiscall gmUIElement_EffectsIndicator::GetUIElementType(ACCharGenData*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_EffectsIndicator, uint>)0x004E75B0)(ref this);
    // void __thiscall gmUIElement_EffectsIndicator::PostInit(gmUIElement_EffectsIndicator*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_EffectsIndicator, void>)0x004E75C0)(ref this);
    // UIElement* __cdecl gmUIElement_EffectsIndicator::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004E7630)(layout, full_desc);
    // void __cdecl gmUIElement_EffectsIndicator::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004E76C0)();
    // void __thiscall gmUIElement_EffectsIndicator::Update(gmUIElement_EffectsIndicator*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_EffectsIndicator, void>)0x004E76E0)(ref this);
    // void __thiscall gmUIElement_EffectsIndicator::RecvNotice_PlayerDescReceived(gmUIElement_EffectsIndicator*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_EffectsIndicator, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x004E77B0)(ref this, i_playerDesc, i_playerModule);
    // void __thiscall gmUIElement_EffectsIndicator::RecvNotice_EnchantmentsChanged(gmUIElement_EffectsIndicator*)
    public void RecvNotice_EnchantmentsChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_EffectsIndicator, void>)0x004E77C0)(ref this);
}

