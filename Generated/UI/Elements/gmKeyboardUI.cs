namespace ACBindings.Internal;

public unsafe struct gmKeyboardUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.OptionPage BaseClass_OptionPage; // ACBindings.Internal.OptionPage
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmKeyboardUI_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OptionPage*, byte> SaveCurrentValues; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OptionPage*, byte> RestoreDefaultValues; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OptionPage*, byte> RestoreSavedValues; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OptionPage*, void> InitOptions; // function pointer

        // Methods
    }
    // gmKeyboardUI::ListBoxEntryType
    public enum ListBoxEntryType : byte
    {
        Header_ListBoxEntryType = 0x0,
        ActionKeyMap_ListBoxEntryType = 0x1
    }

    // Members
    public ACBindings.Internal.UIElement_Button* m_pKeyboardLoadKeymapButton;
    public ACBindings.Internal.UIElement_Button* m_pKeyboardSaveKeymapButton;
    public ACBindings.Internal.UIElement_Text* m_pKeyboardCurrentKeymapLabel;
    public ACBindings.Internal.UIElement_Button* m_pKeyboardResetToDefaultsButton;
    public ACBindings.Internal.UIElement_Button* m_pKeyboardRevertToSavedButton;
    public ACBindings.Internal.UIElement_Button* m_pKeyboardOKButton;
    public ACBindings.Internal.UIElement_Button* m_pKeyboardCancelButton;
    public ACBindings.Internal.HashTable__uint___UIElement_ListBox_ptr m_hashMappingListBoxes;
    public uint m_uiLoadKeymapDialogContext;
    public uint m_uiSaveKeymapDialogContext;
    public uint m_uiCantOverwriteReadOnlyKeymapDialogContext;
    public uint m_uiOverwriteKeymapDialogContext;
    public ACBindings.Internal.List___PStringBase__sbyte m_listCachedKeymapFilenames;

    // Generated Constructor
    public gmKeyboardUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004DB4B0
    /// bool __thiscall gmKeyboardUI::RestoreDefaultValues(gmKeyboardUI*)</code>
    /// </summary>
    public byte RestoreDefaultValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, byte>)0x004DB4B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004DB540
    /// volatile LONG** __stdcall gmKeyboardUI::GetKeymapDirectory(volatile LONG**)</code>
    /// </summary>
    public static int** GetKeymapDirectory(int** a1) => ((delegate* unmanaged[Stdcall]<int**, int**>)0x004DB540)(a1);

    /// <summary>
    /// <code>Offset: 0x004DB5E0
    /// StringInfo* __thiscall gmKeyboardUI::GetStringInfoFromInputMapID(gmKeyboardUI*,StringInfo*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.StringInfo* GetStringInfoFromInputMapID(ACBindings.Internal.StringInfo* result, uint i_eInputMap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, ACBindings.Internal.StringInfo*, uint, ACBindings.Internal.StringInfo*>)0x004DB5E0)(ref this, result, i_eInputMap);

    /// <summary>
    /// <code>Offset: 0x004DB880
    /// void __thiscall gmKeyboardUI::HandleCloseLoadKeymapDialog(gmKeyboardUI*,unsigned int)</code>
    /// </summary>
    public void HandleCloseLoadKeymapDialog(uint i_uiMenuChoice) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, uint, void>)0x004DB880)(ref this, i_uiMenuChoice);

    /// <summary>
    /// <code>Offset: 0x004DBF20
    /// void __thiscall gmKeyboardUI::UpdateKeymapFilenameLabel(gmKeyboardUI*)</code>
    /// </summary>
    public void UpdateKeymapFilenameLabel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, void>)0x004DBF20)(ref this);

    /// <summary>
    /// <code>Offset: 0x004DBF80
    /// UIOption* __thiscall gmKeyboardUI::AddActionKeyMap(OptionPage*,UIElement_ListBox*,int,int,int,StringInfo*,void**,int,int,int)</code>
    /// </summary>
    public ACBindings.Internal.UIOption* AddActionKeyMap(ACBindings.Internal.UIElement_ListBox* a2, int a3, int a4, int a5, ACBindings.Internal.StringInfo* a6, void** a7, int a8, int a9, int a10) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, ACBindings.Internal.UIElement_ListBox*, int, int, int, ACBindings.Internal.StringInfo*, void**, int, int, int, ACBindings.Internal.UIOption*>)0x004DBF80)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10);

    /// <summary>
    /// <code>Offset: 0x004DC400
    /// void __thiscall gmKeyboardUI::PostInit(gmKeyboardUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, void>)0x004DC400)(ref this);

    /// <summary>
    /// <code>Offset: 0x004DCB40
    /// void __thiscall gmKeyboardUI::gmKeyboardUI(gmKeyboardUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004DCB40)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004DCC00
    /// UIElement* __thiscall gmKeyboardUI::DynamicCast(gmKeyboardUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, uint, ACBindings.Internal.UIElement*>)0x004DCC00)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004DCC20
    /// unsigned int __thiscall gmKeyboardUI::GetUIElementType(gmKeyboardUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, uint>)0x004DCC20)(ref this);

    /// <summary>
    /// <code>Offset: 0x004DCC30
    /// void __thiscall gmKeyboardUI::~gmKeyboardUI(gmKeyboardUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, void>)0x004DCC30)(ref this);

    /// <summary>
    /// <code>Offset: 0x004DCD10
    /// UIElement* __cdecl gmKeyboardUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004DCD10)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004DCD40
    /// bool __thiscall gmKeyboardUI::MakeLoadKeymapDialog(gmKeyboardUI*)</code>
    /// </summary>
    public byte MakeLoadKeymapDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, byte>)0x004DCD40)(ref this);

    /// <summary>
    /// <code>Offset: 0x004DD240
    /// bool __thiscall gmKeyboardUI::MakeSaveKeymapDialog(gmKeyboardUI*)</code>
    /// </summary>
    public byte MakeSaveKeymapDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, byte>)0x004DD240)(ref this);

    /// <summary>
    /// <code>Offset: 0x004DD440
    /// char __thiscall gmKeyboardUI::MakeCantOverwriteReadOnlyKeymapDialog(_DWORD*,int)</code>
    /// </summary>
    public sbyte MakeCantOverwriteReadOnlyKeymapDialog(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, int, sbyte>)0x004DD440)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004DD6B0
    /// char __thiscall gmKeyboardUI::MakeOverwriteKeymapDialog(_DWORD*,int)</code>
    /// </summary>
    public sbyte MakeOverwriteKeymapDialog(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, int, sbyte>)0x004DD6B0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004DDC00
    /// void __cdecl gmKeyboardUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004DDC00)();

    /// <summary>
    /// <code>Offset: 0x004DDC20
    /// LONG __thiscall gmKeyboardUI::SaveKeymap(gmKeyboardUI*,volatile LONG*,char)</code>
    /// </summary>
    public int SaveKeymap(int* Source, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, int*, sbyte, int>)0x004DDC20)(ref this, Source, a3);

    /// <summary>
    /// <code>Offset: 0x004DDDF0
    /// char __thiscall gmKeyboardUI::HandleCloseSaveKeymapDialog(gmKeyboardUI*,const char**)</code>
    /// </summary>
    public sbyte HandleCloseSaveKeymapDialog(sbyte** Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, sbyte**, sbyte>)0x004DDDF0)(ref this, Source);

    /// <summary>
    /// <code>Offset: 0x004DDE30
    /// char __thiscall gmKeyboardUI::HandleCloseOverwriteKeymapDialog(gmKeyboardUI*,char,volatile LONG*)</code>
    /// </summary>
    public sbyte HandleCloseOverwriteKeymapDialog(sbyte a2, int* Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, sbyte, int*, sbyte>)0x004DDE30)(ref this, a2, Source);

    /// <summary>
    /// <code>Offset: 0x004DDEC0
    /// UIElementMessageListenResult __thiscall gmKeyboardUI::ListenToElementMessage(gmKeyboardUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004DDEC0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004DE000
    /// void __thiscall gmKeyboardUI::RecvNotice_CloseDialog(gmKeyboardUI*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, uint, ACBindings.Internal.PropertyCollection*, void>)0x004DE000)(ref this, context, data);

    /// <summary>
    /// <code>Offset: 0x004DE540
    /// void __thiscall gmKeyboardUI::InitOptions(gmKeyboardUI*)</code>
    /// </summary>
    public void InitOptions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, void>)0x004DE540)(ref this);
}

