namespace ACBindings;

// gmCombatUI
public unsafe struct gmCombatUI
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmCombatUI_vtbl
    public unsafe struct gmCombatUI_vtbl
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

        // Methods
    }

    // Members
    public ACBindings.UIElement_Field* m_RecklessnessField;

    // Methods
    // UIElement* __thiscall gmCombatUI::DynamicCast(gmCombatUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCombatUI, uint, ACBindings.UIElement*>)0x004CCBF0)(ref this, i_eType);
    // UIElement* __cdecl gmCombatUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004CCC20)(layout, full_desc);
    // void __thiscall gmCombatUI::RecvNotice_AttackHeightChanged(gmCombatUI*,ATTACK_HEIGHT)
    public void RecvNotice_AttackHeightChanged(ACBindings.ATTACK_HEIGHT i_newHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCombatUI, ACBindings.ATTACK_HEIGHT, void>)0x004CCC70)(ref this, i_newHeight);
    // void __thiscall gmCombatUI::RecvNotice_SetPowerbarLevel(gmCombatUI*,PowerBarMode,float)
    public void RecvNotice_SetPowerbarLevel(ACBindings.PowerBarMode i_pbm, float i_fLevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCombatUI, ACBindings.PowerBarMode, float, void>)0x004CCCD0)(ref this, i_pbm, i_fLevel);
    // void __thiscall gmCombatUI::RecvNotice_DesiredAttackPowerChanged(gmCombatUI*,float)
    public void RecvNotice_DesiredAttackPowerChanged(float i_fLevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCombatUI, float, void>)0x004CCD00)(ref this, i_fLevel);
    // void __thiscall gmCombatUI::PostInit(gmCombatUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCombatUI, void>)0x004CCD90)(ref this);
    // void __cdecl gmCombatUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004CD000)();
    // UIElementMessageListenResult __thiscall gmCombatUI::ListenToElementMessage(gmCombatUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCombatUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004CD020)(ref this, i_rMsg);
    // void __thiscall gmCombatUI::RecvNotice_SetCombatMode(gmCombatUI*,COMBAT_MODE)
    public void RecvNotice_SetCombatMode(ACBindings.COMBAT_MODE i_eCombatMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCombatUI, ACBindings.COMBAT_MODE, void>)0x004CD210)(ref this, i_eCombatMode);
}

