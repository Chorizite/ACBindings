namespace ACBindings.Internal;


/// <summary>
/// Keyboard configuration page that manages keymap dialogs, default restoration, and action‑mapping UI elements across multiple input categories.
/// </summary>
public unsafe struct gmKeyboardUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.OptionPage BaseClass_OptionPage; // ACBindings.Internal.OptionPage
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmKeyboardUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*> GetSurfaceBox; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> HasCursor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawStart; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> EraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawDone; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> SetState; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetParent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> GetAncestorByID; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> Initialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> PostInit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, ACBindings.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement**, byte> DragItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> MatchElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Activate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Deactivate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> TakeFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetActivatable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject*, byte> SetUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OptionPage*, byte> SaveCurrentValues; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OptionPage*, byte> RestoreDefaultValues; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OptionPage*, byte> RestoreSavedValues; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OptionPage*, void> InitOptions; // function pointer

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

    /// <summary>Resets the keyboard UI to its original default configuration and reinitializes input settings via ICIDM.
    /// <code>Offset: 0x004DB4B0
    /// bool __thiscall gmKeyboardUI::RestoreDefaultValues(gmKeyboardUI*)</code>
    /// </summary>
    /// <returns>True if defaults were applied successfully; otherwise, false.</returns>
    public byte RestoreDefaultValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, byte>)0x004DB4B0)(ref this);

    /// <summary>Retrieves the directory path used for keyboard keymaps and stores it in the supplied output buffer.
    /// <code>Offset: 0x004DB540
    /// volatile LONG** __stdcall gmKeyboardUI::GetKeymapDirectory(volatile LONG**)</code>
    /// </summary>
    /// <param name="a1">Pointer to a volatile LONG* that receives the keymap directory string buffer.</param>
    /// <returns>The same pointer passed as a1, now pointing to the retrieved directory string.</returns>
    public static int** GetKeymapDirectory(int** a1) => ((delegate* unmanaged[Stdcall]<int**, int**>)0x004DB540)(a1);

    /// <summary>Obtains a StringInfo structure that represents the name of an input map specified by its identifier.
    /// <code>Offset: 0x004DB5E0
    /// StringInfo* __thiscall gmKeyboardUI::GetStringInfoFromInputMapID(gmKeyboardUI*,StringInfo*,unsigned int)</code>
    /// </summary>
    /// <param name="result">The StringInfo object to be filled with the tokenized string and related information.</param>
    /// <param name="i_eInputMap">The numeric ID of the desired input map; recognized values are mapped to predefined strings.</param>
    /// <returns>Pointer to the supplied result parameter, now containing the string info for the requested input map.</returns>
    public ACBindings.Internal.StringInfo* GetStringInfoFromInputMapID(ACBindings.Internal.StringInfo* result, uint i_eInputMap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, ACBindings.Internal.StringInfo*, uint, ACBindings.Internal.StringInfo*>)0x004DB5E0)(ref this, result, i_eInputMap);

    /// <summary>Closes the load‑keymap dialog; if a keymap was selected, loads the chosen file and cleans up the dialog.
    /// <code>Offset: 0x004DB880
    /// void __thiscall gmKeyboardUI::HandleCloseLoadKeymapDialog(gmKeyboardUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_uiMenuChoice">Index of the selected keymap in the cached list, or –1 to cancel.</param>
    public void HandleCloseLoadKeymapDialog(uint i_uiMenuChoice) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, uint, void>)0x004DB880)(ref this, i_uiMenuChoice);

    /// <summary>Updates the keyboard UI’s current keymap label to display the filename of the keymap presently loaded from the client instance.
    /// <code>Offset: 0x004DBF20
    /// void __thiscall gmKeyboardUI::UpdateKeymapFilenameLabel(gmKeyboardUI*)</code>
    /// </summary>
    public void UpdateKeymapFilenameLabel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, void>)0x004DBF20)(ref this);

    /// <summary>Adds a new action key mapping item to the specified list box and registers it as an option on the page. The function creates a UI element from a template, associates it with an action ID, configures the option using the supplied identifiers and string information, then clears temporary input map entries before returning the created option or null if unsuccessful.
    /// <code>Offset: 0x004DBF80
    /// UIOption* __thiscall gmKeyboardUI::AddActionKeyMap(OptionPage*,UIElement_ListBox*,int,int,int,StringInfo*,void**,int,int,int)</code>
    /// </summary>
    /// <param name="a2">The UIElement_ListBox to which the new key mapping item will be added.</param>
    /// <param name="a3">Primary identifier for the key mapping option (e.g., action ID).</param>
    /// <param name="a4">Secondary identifier or category index used in option configuration.</param>
    /// <param name="a5">Tertiary identifier or subcategory for the mapping.</param>
    /// <param name="a6">StringInfo containing display text and metadata for the new item.</param>
    /// <param name="a7">Pointer to an array of input map entries that will be flushed after creation.</param>
    /// <param name="a8">Additional flag or context value forwarded to sub_488C10.</param>
    /// <param name="a9">Parameter passed to sub_488C10, possibly indicating key repeat behavior.</param>
    /// <param name="a10">Final integer parameter for sub_488C10, potentially specifying default action state.</param>
    /// <returns>Pointer to the newly created UIOption if successful; otherwise null.</returns>
    public ACBindings.Internal.UIOption* AddActionKeyMap(ACBindings.Internal.UIElement_ListBox* a2, int a3, int a4, int a5, ACBindings.Internal.StringInfo* a6, void** a7, int a8, int a9, int a10) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, ACBindings.Internal.UIElement_ListBox*, int, int, int, ACBindings.Internal.StringInfo*, void**, int, int, int, ACBindings.Internal.UIOption*>)0x004DBF80)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10);

    /// <summary>Initializes the keyboard settings user interface, registering global notice handlers and locating interactive widgets such as buttons, labels, and list boxes based on layout attributes.
    /// <code>Offset: 0x004DC400
    /// void __thiscall gmKeyboardUI::PostInit(gmKeyboardUI*)</code>
    /// </summary>
    /// <param name="this">The gmKeyboardUI instance to initialize.</param>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, void>)0x004DC400)(ref this);

    /// <summary>Initializes a gmKeyboardUI page from the supplied layout and element descriptors, establishing base class relationships, notice handling, button placeholders, and internal data structures for keymap management.
    /// <code>Offset: 0x004DCB40
    /// void __thiscall gmKeyboardUI::gmKeyboardUI(gmKeyboardUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout description used to construct the underlying OptionPage and provide size/element information.</param>
    /// <param name="full_desc">Full element descriptor defining the UI elements that compose this keyboard page.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004DCB40)(ref this, layout, full_desc);

    /// <summary>Returns a pointer to this gmKeyboardUI instance cast as a UIElement when the requested type matches; otherwise returns null.
    /// <code>Offset: 0x004DCC00
    /// UIElement* __thiscall gmKeyboardUI::DynamicCast(gmKeyboardUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The type identifier to cast to.</param>
    /// <returns>A UIElement pointer if i_eType equals 268435470, otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, uint, ACBindings.Internal.UIElement*>)0x004DCC00)(ref this, i_eType);

    /// <summary>Provides the unique identifier for the gmKeyboardUI component’s UI element type.
    /// <code>Offset: 0x004DCC20
    /// unsigned int __thiscall gmKeyboardUI::GetUIElementType(gmKeyboardUI*)</code>
    /// </summary>
    /// <returns>The unsigned integer value 268435470 that identifies this UI element type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, uint>)0x004DCC20)(ref this);

    /// <summary>Cleans up all keyboard UI resources, closes associated dialogs, clears cached keymap filenames and mapping list boxes, releases allocated memory, and invokes base class destructors to properly dispose of the object.
    /// <code>Offset: 0x004DCC30
    /// void __thiscall gmKeyboardUI::~gmKeyboardUI(gmKeyboardUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, void>)0x004DCC30)(ref this);

    /// <summary>Creates a new gmKeyboardUI instance initialized with the supplied layout and element description, returning its root UIElement.
    /// <code>Offset: 0x004DCD10
    /// UIElement* __cdecl gmKeyboardUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Specification of display dimensions and child elements for the keyboard UI.</param>
    /// <param name="full_desc">Detailed descriptor defining the keyboard’s visual and behavioral properties.</param>
    /// <returns>Pointer to the newly created UIElement representing the keyboard, or null if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004DCD10)(layout, full_desc);

    /// <summary>Creates and displays a “Load Keymap” dialog, populating it with available keymap files from the keyboard configuration directory and configuring the necessary dialog properties.
    /// <code>Offset: 0x004DCD40
    /// bool __thiscall gmKeyboardUI::MakeLoadKeymapDialog(gmKeyboardUI*)</code>
    /// </summary>
    /// <returns>True if the dialog was successfully created; otherwise false.</returns>
    public byte MakeLoadKeymapDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, byte>)0x004DCD40)(ref this);

    /// <summary>Creates and displays a “Save Keymap” dialog, initializing its properties and adding it to the current UI.
    /// <code>Offset: 0x004DD240
    /// bool __thiscall gmKeyboardUI::MakeSaveKeymapDialog(gmKeyboardUI*)</code>
    /// </summary>
    /// <returns>True if the dialog was created successfully; false if a save keymap dialog is already active.</returns>
    public byte MakeSaveKeymapDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, byte>)0x004DD240)(ref this);

    /// <summary>Creates a read‑only keymap warning dialog if none exists; otherwise updates its reference count and returns failure.
    /// <code>Offset: 0x004DD440
    /// char __thiscall gmKeyboardUI::MakeCantOverwriteReadOnlyKeymapDialog(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Context identifier for the keymap used in the dialog’s variable substitution.</param>
    /// <returns>1 when the dialog is successfully created, 0 if it already existed (reference count only incremented).</returns>
    public sbyte MakeCantOverwriteReadOnlyKeymapDialog(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, int, sbyte>)0x004DD440)(ref this, a2);

    /// <summary>Creates an overwrite keymap dialog for the current UI if one does not already exist; otherwise decrements its reference count and returns without creating a new instance.
    /// <code>Offset: 0x004DD6B0
    /// char __thiscall gmKeyboardUI::MakeOverwriteKeymapDialog(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Identifier used as the context for dialog creation and reference counting.</param>
    /// <returns>1 when a new dialog is created, 0 if an existing dialog was found or cleanup performed.</returns>
    public sbyte MakeOverwriteKeymapDialog(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, int, sbyte>)0x004DD6B0)(ref this, a2);

    /// <summary>Registers the gmKeyboardUI element class with the UI system, enabling creation of keyboard configuration panels.
    /// <code>Offset: 0x004DDC00
    /// void __cdecl gmKeyboardUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004DDC00)();

    /// <summary>
    /// Validates a keyboard layout file name, appends a ".keymap" extension if missing, resolves it against the key‑map directory, displays overwrite or read‑only dialogs when necessary, then stores the resulting path in the client configuration and updates the UI label. The function does not write any data to disk.
    /// 
    /// <code>Offset: 0x004DDC20
    /// LONG __thiscall gmKeyboardUI::SaveKeymap(gmKeyboardUI*,volatile LONG*,char)</code>
    /// </summary>
    /// <param name="Source">Pointer to a reference‑counted string that holds the desired key map file name; may be modified by appending ".keymap".</param>
    /// <param name="a3">Flag indicating whether an overwrite confirmation dialog should be shown if the target file already exists.</param>
    /// <returns>Remaining reference count of the source string after it has been decremented, or 0 when the string is released.</returns>
    public int SaveKeymap(int* Source, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, int*, sbyte, int>)0x004DDC20)(ref this, Source, a3);

    /// <summary>Closes the Save Keymap dialog, resetting its context and attempting to save a keymap if a source filename is provided.
    /// <code>Offset: 0x004DDDF0
    /// char __thiscall gmKeyboardUI::HandleCloseSaveKeymapDialog(gmKeyboardUI*,const char**)</code>
    /// </summary>
    /// <param name="Source">Pointer to a string containing the desired file path; null when no file should be saved.</param>
    /// <returns>Non‑zero on success, zero otherwise.</returns>
    public sbyte HandleCloseSaveKeymapDialog(sbyte** Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, sbyte**, sbyte>)0x004DDDF0)(ref this, Source);

    /// <summary>Closes the overwrite key‑map dialog and, if confirmed, saves the current key map.
    /// <code>Offset: 0x004DDE30
    /// char __thiscall gmKeyboardUI::HandleCloseOverwriteKeymapDialog(gmKeyboardUI*,char,volatile LONG*)</code>
    /// </summary>
    /// <param name="a2">True when the user chooses to overwrite; otherwise false.</param>
    /// <param name="Source">Pointer passed to SaveKeymap for saving the key map. The function does not modify it directly.</param>
    /// <returns>The result of the save operation if the dialog was confirmed, otherwise the value of a2 indicating that no overwrite took place.</returns>
    public sbyte HandleCloseOverwriteKeymapDialog(sbyte a2, int* Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, sbyte, int*, sbyte>)0x004DDE30)(ref this, a2, Source);

    /// <summary>Processes UI element messages for the keyboard configuration page, handling button actions such as loading a keymap, saving a keymap, resetting defaults, reverting to saved settings and applying changes via dialogs.
    /// <code>Offset: 0x004DDEC0
    /// UIElementMessageListenResult __thiscall gmKeyboardUI::ListenToElementMessage(gmKeyboardUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information describing which UI element triggered the event and additional parameters.</param>
    /// <returns>Result of processing the message; delegates to the base class for unhandled messages or signals completion after applying changes.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004DDEC0)(ref this, i_rMsg);

    /// <summary>Handles close dialog notices for keyboard UI, dispatching actions based on context identifiers such as load, save, or overwrite keymap dialogs. Retrieves relevant properties from the supplied PropertyCollection and triggers corresponding handler methods to finalize the dialog operation.
    /// <code>Offset: 0x004DE000
    /// void __thiscall gmKeyboardUI::RecvNotice_CloseDialog(gmKeyboardUI*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    /// <param name="context">Identifier indicating which dialog is closing (e.g., load, save, overwrite).</param>
    /// <param name="data">Property collection containing any parameters passed with the notice; may include file names or flags used by handlers.</param>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, uint, ACBindings.Internal.PropertyCollection*, void>)0x004DE000)(ref this, context, data);

    /// <summary>Initializes keyboard configuration options UI by clearing existing data, loading available action maps, populating list boxes with mapped actions and their key bindings, merging the default input map into the custom map, and creating UI entries for each action.
    /// <code>Offset: 0x004DE540
    /// void __thiscall gmKeyboardUI::InitOptions(gmKeyboardUI*)</code>
    /// </summary>
    public void InitOptions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmKeyboardUI, void>)0x004DE540)(ref this);
}

