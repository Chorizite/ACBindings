namespace ACBindings.Internal;

public unsafe struct gmEffectsUI
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmEffectsUI_vtbl
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
    public ACBindings.Internal.UIElement_Text* m_pInfoText;
    public ACBindings.Internal.UIElement_ListBox* m_pListBox;
    public ACBindings.Internal.SmartArray___EffectInfoRegion_ptr m_rgTokens;
    public uint m_effectsUIType;
    public double m_nextDurationUpdate;
    public uint m_SelectedSpell;
    public byte m_bNeedToRebuild;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004B8180
    /// void __thiscall gmEffectsUI::PostInit(gmEffectsUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, void>)0x004B8180)(ref this);

    /// <summary>
    /// <code>Offset: 0x004B8290
    /// bool __thiscall gmEffectsUI::UpdateDurations(gmEffectsUI*,const CACQualities*)</code>
    /// </summary>
    public byte UpdateDurations(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, ACBindings.Internal.CACQualities*, byte>)0x004B8290)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x004B82E0
    /// bool __thiscall gmEffectsUI::SpellEffectMatchesUIType(gmEffectsUI*,unsigned int)</code>
    /// </summary>
    public byte SpellEffectMatchesUIType(uint i_spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, uint, byte>)0x004B82E0)(ref this, i_spellID);

    /// <summary>
    /// <code>Offset: 0x004B8470
    /// UIElement* __thiscall gmEffectsUI::DynamicCast(gmEffectsUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, uint, ACBindings.Internal.UIElement*>)0x004B8470)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004B84C0
    /// void __cdecl gmEffectsUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004B84C0)();

    /// <summary>
    /// <code>Offset: 0x004B84E0
    /// unsigned int __thiscall gmEffectsUI::GetSortedInsertionPlace(gmEffectsUI*,CSpellBase*)</code>
    /// </summary>
    public uint GetSortedInsertionPlace(ACBindings.Internal.CSpellBase* spellBase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, ACBindings.Internal.CSpellBase*, uint>)0x004B84E0)(ref this, spellBase);

    /// <summary>
    /// <code>Offset: 0x004B87D0
    /// bool __thiscall gmEffectsUI::UpdateDurations(gmEffectsUI*)</code>
    /// </summary>
    public byte UpdateDurations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, byte>)0x004B87D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004B8880
    /// bool __thiscall gmEffectsUI::FlushList(gmEffectsUI*)</code>
    /// </summary>
    public byte FlushList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, byte>)0x004B8880)(ref this);

    /// <summary>
    /// <code>Offset: 0x004B8B60
    /// void __thiscall gmEffectsUI::ListenToGlobalMessage(gmEffectsUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, uint, int, void>)0x004B8B60)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x004B8BB0
    /// bool __thiscall gmEffectsUI::UpdateSelection(gmEffectsUI*)</code>
    /// </summary>
    public byte UpdateSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, byte>)0x004B8BB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004B8EB0
    /// bool __thiscall gmEffectsUI::SetSelectedSpell(gmEffectsUI*,UIElement*)</code>
    /// </summary>
    public byte SetSelectedSpell(ACBindings.Internal.UIElement* selectedUI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, ACBindings.Internal.UIElement*, byte>)0x004B8EB0)(ref this, selectedUI);

    /// <summary>
    /// <code>Offset: 0x004B8F70
    /// bool __thiscall gmEffectsUI::RebuildList(gmEffectsUI*,const CACQualities*)</code>
    /// </summary>
    public byte RebuildList(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, ACBindings.Internal.CACQualities*, byte>)0x004B8F70)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x004B9150
    /// bool __thiscall gmEffectsUI::Update(gmEffectsUI*,const CACQualities*)</code>
    /// </summary>
    public byte Update(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, ACBindings.Internal.CACQualities*, byte>)0x004B9150)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x004B9190
    /// void __thiscall gmEffectsUI::RecvNotice_PlayerDescReceived(gmEffectsUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004B9190)(ref this, i_playerDesc, i_playerModule);

    /// <summary>
    /// <code>Offset: 0x004B91D0
    /// bool __thiscall gmEffectsUI::Update(gmEffectsUI*)</code>
    /// </summary>
    public byte Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, byte>)0x004B91D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004B9280
    /// UIElementMessageListenResult __thiscall gmEffectsUI::ListenToElementMessage(gmEffectsUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004B9280)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004B9300
    /// void __thiscall gmEffectsUI::RecvNotice_EnchantmentsChanged(gmEffectsUI*)</code>
    /// </summary>
    public void RecvNotice_EnchantmentsChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, void>)0x004B9300)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E7800
    /// unsigned int __thiscall gmEffectsUI::GetUIElementType(gmUIElement_BurdenIndicator*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, uint>)0x004E7800)(ref this);
}

