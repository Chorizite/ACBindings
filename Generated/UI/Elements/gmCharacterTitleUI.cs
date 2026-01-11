namespace ACBindings.Internal;

public unsafe struct gmCharacterTitleUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmCharacterTitleUI_vtbl
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
    public ACBindings.Internal.UIElement_Text* m_pDisplayTitleText;
    public ACBindings.Internal.UIElement_Button* m_pDisplayButton;
    public ACBindings.Internal.UIElement_ListBox* m_pTitleListBox;
    public ACBindings.Internal.CharacterTitleTable m_characterTitleTable;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0049A7E0
    /// void __thiscall gmCharacterTitleUI::UpdateButtons(gmCharacterTitleUI*)</code>
    /// </summary>
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, void>)0x0049A7E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049A8F0
    /// void __thiscall gmCharacterTitleUI::PostInit(gmCharacterTitleUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, void>)0x0049A8F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049A9B0
    /// UIElementMessageListenResult __thiscall gmCharacterTitleUI::ListenToElementMessage(gmCharacterTitleUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0049A9B0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x0049AA40
    /// UIElement* __thiscall gmCharacterTitleUI::FindSortedInsertPosition(_DWORD*,const wchar_t**)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* FindSortedInsertPosition(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, System.IntPtr, ACBindings.Internal.UIElement*>)0x0049AA40)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0049AB20
    /// bool __thiscall gmCharacterTitleUI::AddTitleToList(gmCharacterTitleUI*,unsigned int)</code>
    /// </summary>
    public byte AddTitleToList(uint i_title) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, uint, byte>)0x0049AB20)(ref this, i_title);

    /// <summary>
    /// <code>Offset: 0x0049AC00
    /// void __thiscall gmCharacterTitleUI::RecvNotice_AddCharacterTitle(gmCharacterTitleUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_AddCharacterTitle(uint i_title) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, uint, void>)0x0049AC00)(ref this, i_title);

    /// <summary>
    /// <code>Offset: 0x0049AD20
    /// UIElement* __thiscall gmCharacterTitleUI::DynamicCast(gmCharacterTitleUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, uint, ACBindings.Internal.UIElement*>)0x0049AD20)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x0049AD40
    /// unsigned int __thiscall gmCharacterTitleUI::GetUIElementType(gmCharacterTitleUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, uint>)0x0049AD40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049AD50
    /// void __thiscall gmCharacterTitleUI::~gmCharacterTitleUI(gmCharacterTitleUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, void>)0x0049AD50)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049AE10
    /// void __cdecl gmCharacterTitleUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0049AE10)();

    /// <summary>
    /// <code>Offset: 0x0049AE30
    /// bool __thiscall gmCharacterTitleUI::Refresh(gmCharacterTitleUI*)</code>
    /// </summary>
    public byte Refresh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, byte>)0x0049AE30)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049AFA0
    /// void __thiscall gmCharacterTitleUI::RecvNotice_UpdateCharacterTitleTable(gmCharacterTitleUI*,const CharacterTitleTable*)</code>
    /// </summary>
    public void RecvNotice_UpdateCharacterTitleTable(ACBindings.Internal.CharacterTitleTable* i_titleTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, ACBindings.Internal.CharacterTitleTable*, void>)0x0049AFA0)(ref this, i_titleTable);

    /// <summary>
    /// <code>Offset: 0x0049AFC0
    /// void __thiscall gmCharacterTitleUI::RecvNotice_SetDisplayCharacterTitle(gmCharacterTitleUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_SetDisplayCharacterTitle(uint i_title) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, uint, void>)0x0049AFC0)(ref this, i_title);
}

