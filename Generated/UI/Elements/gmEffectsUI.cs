namespace ACBindings;

// gmEffectsUI
public unsafe struct gmEffectsUI
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmEffectsUI_vtbl
    public unsafe struct gmEffectsUI_vtbl
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
    public ACBindings.UIElement_Text* m_pInfoText;
    public ACBindings.UIElement_ListBox* m_pListBox;
    public ACBindings.SmartArray__EffectInfoRegion_ptr m_rgTokens;
    public uint m_effectsUIType;
    public double m_nextDurationUpdate;
    public uint m_SelectedSpell;
    public byte m_bNeedToRebuild;

    // Methods
    // void __thiscall gmEffectsUI::PostInit(gmEffectsUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, void>)0x004B8180)(ref this);
    // bool __thiscall gmEffectsUI::UpdateDurations(gmEffectsUI*,const CACQualities*)
    public byte UpdateDurations(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, ACBindings.CACQualities*, byte>)0x004B8290)(ref this, i_playerDesc);
    // bool __thiscall gmEffectsUI::SpellEffectMatchesUIType(gmEffectsUI*,unsigned int)
    public byte SpellEffectMatchesUIType(uint i_spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, uint, byte>)0x004B82E0)(ref this, i_spellID);
    // UIElement* __thiscall gmEffectsUI::DynamicCast(gmEffectsUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, uint, ACBindings.UIElement*>)0x004B8470)(ref this, i_eType);
    // void __cdecl gmEffectsUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004B84C0)();
    // unsigned int __thiscall gmEffectsUI::GetSortedInsertionPlace(gmEffectsUI*,CSpellBase*)
    public uint GetSortedInsertionPlace(ACBindings.CSpellBase* spellBase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, ACBindings.CSpellBase*, uint>)0x004B84E0)(ref this, spellBase);
    // bool __thiscall gmEffectsUI::UpdateDurations(gmEffectsUI*)
    public byte UpdateDurations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, byte>)0x004B87D0)(ref this);
    // bool __thiscall gmEffectsUI::FlushList(gmEffectsUI*)
    public byte FlushList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, byte>)0x004B8880)(ref this);
    // void __thiscall gmEffectsUI::ListenToGlobalMessage(gmEffectsUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, uint, int, void>)0x004B8B60)(ref this, i_messageID, i_data_int);
    // bool __thiscall gmEffectsUI::UpdateSelection(gmEffectsUI*)
    public byte UpdateSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, byte>)0x004B8BB0)(ref this);
    // bool __thiscall gmEffectsUI::SetSelectedSpell(gmEffectsUI*,UIElement*)
    public byte SetSelectedSpell(ACBindings.UIElement* selectedUI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, ACBindings.UIElement*, byte>)0x004B8EB0)(ref this, selectedUI);
    // bool __thiscall gmEffectsUI::RebuildList(gmEffectsUI*,const CACQualities*)
    public byte RebuildList(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, ACBindings.CACQualities*, byte>)0x004B8F70)(ref this, i_playerDesc);
    // bool __thiscall gmEffectsUI::Update(gmEffectsUI*,const CACQualities*)
    public byte Update(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, ACBindings.CACQualities*, byte>)0x004B9150)(ref this, i_playerDesc);
    // void __thiscall gmEffectsUI::RecvNotice_PlayerDescReceived(gmEffectsUI*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x004B9190)(ref this, i_playerDesc, i_playerModule);
    // bool __thiscall gmEffectsUI::Update(gmEffectsUI*)
    public byte Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, byte>)0x004B91D0)(ref this);
    // UIElementMessageListenResult __thiscall gmEffectsUI::ListenToElementMessage(gmEffectsUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004B9280)(ref this, i_rMsg);
    // void __thiscall gmEffectsUI::RecvNotice_EnchantmentsChanged(gmEffectsUI*)
    public void RecvNotice_EnchantmentsChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, void>)0x004B9300)(ref this);
    // unsigned int __thiscall gmEffectsUI::GetUIElementType(gmUIElement_BurdenIndicator*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEffectsUI, uint>)0x004E7800)(ref this);
}

