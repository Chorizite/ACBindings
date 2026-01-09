namespace ACBindings;

// gmKeyboardUI
public unsafe struct gmKeyboardUI : System.IDisposable
{
    // Base Classes
    public ACBindings.OptionPage BaseClass_OptionPage; // ACBindings.OptionPage
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmKeyboardUI_vtbl
    public unsafe struct gmKeyboardUI_vtbl
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
        public System.IntPtr SaveCurrentValues; // function pointer
        public System.IntPtr RestoreDefaultValues; // function pointer
        public System.IntPtr RestoreSavedValues; // function pointer
        public System.IntPtr InitOptions; // function pointer

        // Methods
    }
    // gmKeyboardUI::ListBoxEntryType
    public enum ListBoxEntryType : byte
    {
        Header_ListBoxEntryType = 0x0,
        ActionKeyMap_ListBoxEntryType = 0x1
    }

    // Members
    public ACBindings.UIElement_Button* m_pKeyboardLoadKeymapButton;
    public ACBindings.UIElement_Button* m_pKeyboardSaveKeymapButton;
    public ACBindings.UIElement_Text* m_pKeyboardCurrentKeymapLabel;
    public ACBindings.UIElement_Button* m_pKeyboardResetToDefaultsButton;
    public ACBindings.UIElement_Button* m_pKeyboardRevertToSavedButton;
    public ACBindings.UIElement_Button* m_pKeyboardOKButton;
    public ACBindings.UIElement_Button* m_pKeyboardCancelButton;
    public ACBindings.HashTable__uint__UIElement_ListBox_ptr m_hashMappingListBoxes;
    public uint m_uiLoadKeymapDialogContext;
    public uint m_uiSaveKeymapDialogContext;
    public uint m_uiCantOverwriteReadOnlyKeymapDialogContext;
    public uint m_uiOverwriteKeymapDialogContext;
    public ACBindings.List__PStringBase__sbyte m_listCachedKeymapFilenames;

    // Generated Constructor
    public gmKeyboardUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall gmKeyboardUI::RestoreDefaultValues(gmKeyboardUI*)
    public byte RestoreDefaultValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, byte>)0x004DB4B0)(ref this);
    // volatile LONG** __stdcall gmKeyboardUI::GetKeymapDirectory(volatile LONG**)
    public static int** GetKeymapDirectory(int** a1) => ((delegate* unmanaged[Stdcall]<int**, int**>)0x004DB540)(a1);
    // StringInfo* __thiscall gmKeyboardUI::GetStringInfoFromInputMapID(gmKeyboardUI*,StringInfo*,unsigned int)
    public ACBindings.StringInfo* GetStringInfoFromInputMapID(ACBindings.StringInfo* result, uint i_eInputMap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, ACBindings.StringInfo*, uint, ACBindings.StringInfo*>)0x004DB5E0)(ref this, result, i_eInputMap);
    // void __thiscall gmKeyboardUI::HandleCloseLoadKeymapDialog(gmKeyboardUI*,unsigned int)
    public void HandleCloseLoadKeymapDialog(uint i_uiMenuChoice) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, uint, void>)0x004DB880)(ref this, i_uiMenuChoice);
    // void __thiscall gmKeyboardUI::UpdateKeymapFilenameLabel(gmKeyboardUI*)
    public void UpdateKeymapFilenameLabel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, void>)0x004DBF20)(ref this);
    // UIOption* __thiscall gmKeyboardUI::AddActionKeyMap(OptionPage*,UIElement_ListBox*,int,int,int,StringInfo*,void**,int,int,int)
    public ACBindings.UIOption* AddActionKeyMap(ACBindings.UIElement_ListBox* a2, int a3, int a4, int a5, ACBindings.StringInfo* a6, void** a7, int a8, int a9, int a10) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, ACBindings.UIElement_ListBox*, int, int, int, ACBindings.StringInfo*, void**, int, int, int, ACBindings.UIOption*>)0x004DBF80)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10);
    // void __thiscall gmKeyboardUI::PostInit(gmKeyboardUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, void>)0x004DC400)(ref this);
    // void __thiscall gmKeyboardUI::gmKeyboardUI(gmKeyboardUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004DCB40)(ref this, layout, full_desc);
    // UIElement* __thiscall gmKeyboardUI::DynamicCast(gmKeyboardUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, uint, ACBindings.UIElement*>)0x004DCC00)(ref this, i_eType);
    // unsigned int __thiscall gmKeyboardUI::GetUIElementType(gmKeyboardUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, uint>)0x004DCC20)(ref this);
    // void __thiscall gmKeyboardUI::~gmKeyboardUI(gmKeyboardUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, void>)0x004DCC30)(ref this);
    // UIElement* __cdecl gmKeyboardUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004DCD10)(layout, full_desc);
    // bool __thiscall gmKeyboardUI::MakeLoadKeymapDialog(gmKeyboardUI*)
    public byte MakeLoadKeymapDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, byte>)0x004DCD40)(ref this);
    // bool __thiscall gmKeyboardUI::MakeSaveKeymapDialog(gmKeyboardUI*)
    public byte MakeSaveKeymapDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, byte>)0x004DD240)(ref this);
    // char __thiscall gmKeyboardUI::MakeCantOverwriteReadOnlyKeymapDialog(_DWORD*,int)
    public sbyte MakeCantOverwriteReadOnlyKeymapDialog(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, int, sbyte>)0x004DD440)(ref this, a2);
    // char __thiscall gmKeyboardUI::MakeOverwriteKeymapDialog(_DWORD*,int)
    public sbyte MakeOverwriteKeymapDialog(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, int, sbyte>)0x004DD6B0)(ref this, a2);
    // void __cdecl gmKeyboardUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004DDC00)();
    // LONG __thiscall gmKeyboardUI::SaveKeymap(gmKeyboardUI*,volatile LONG*,char)
    public int SaveKeymap(int* Source, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, int*, sbyte, int>)0x004DDC20)(ref this, Source, a3);
    // char __thiscall gmKeyboardUI::HandleCloseSaveKeymapDialog(gmKeyboardUI*,const char**)
    public sbyte HandleCloseSaveKeymapDialog(sbyte** Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, sbyte**, sbyte>)0x004DDDF0)(ref this, Source);
    // char __thiscall gmKeyboardUI::HandleCloseOverwriteKeymapDialog(gmKeyboardUI*,char,volatile LONG*)
    public sbyte HandleCloseOverwriteKeymapDialog(sbyte a2, int* Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, sbyte, int*, sbyte>)0x004DDE30)(ref this, a2, Source);
    // UIElementMessageListenResult __thiscall gmKeyboardUI::ListenToElementMessage(gmKeyboardUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004DDEC0)(ref this, i_rMsg);
    // void __thiscall gmKeyboardUI::RecvNotice_CloseDialog(gmKeyboardUI*,unsigned int,const PropertyCollection*)
    public void RecvNotice_CloseDialog(uint context, ACBindings.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, uint, ACBindings.PropertyCollection*, void>)0x004DE000)(ref this, context, data);
    // void __thiscall gmKeyboardUI::InitOptions(gmKeyboardUI*)
    public void InitOptions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmKeyboardUI, void>)0x004DE540)(ref this);
}

