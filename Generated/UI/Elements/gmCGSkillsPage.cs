namespace ACBindings.Internal;


/// <summary>
/// Manages the character generation skills page UI, coordinating skill entries, training progression, and credit tracking within the character creation process.
/// Handles initialization, event responses, and visual updates for each skill record and associated UI components.
/// </summary>
public unsafe struct gmCGSkillsPage : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmCGSkillsPage_vtbl
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

        // Methods
    }

    /// <summary>Encapsulates all data and UI elements associated with a single skill entry on the skills page, including identifiers, costs, level information, descriptive strings, and calculation logic.</summary>
    /// <remarks>Manages reference‑counted string buffers for name, description, and formula, and owns a SkillFormula instance used to compute skill effects. Provides pointers to UI controls that display and modify the skill within the game's interface.</remarks>
    public unsafe struct tagSkillRecord : System.IDisposable
    {
        // Members
        public ACBindings.Internal.UIElement* pEntry;
        public ACBindings.Internal.UIElement_Text* pUpCostText;
        public ACBindings.Internal.UIElement_Text* pDownCostText;
        public ACBindings.Internal.UIElement_Text* pSkillLevelText;
        public ACBindings.Internal.UIElement_Button* pSkillUpButton;
        public ACBindings.Internal.UIElement_Button* pSkillDownButton;
        public ACBindings.Internal.PStringBase__ushort strName;
        public ACBindings.Internal.PStringBase__ushort strDesc;
        public ACBindings.Internal.PStringBase__ushort strFormula;
        public int iSkillID;
        public int iSkillLevel;
        public int iTrainCost;
        public int iSpecCost;
        public int iMinlevel;
        public byte bUntrainable;
        public byte bUnspecializable;
        public ACBindings.Internal.SKILL_ADVANCEMENT_CLASS saCurClass;
        public ACBindings.Internal.SkillFormula formSkill;

        // Generated Constructor
        public tagSkillRecord() {
            _ConstructorInternal();
        }
        public tagSkillRecord(ACBindings.Internal.gmCGSkillsPage.tagSkillRecord* that) {
            _ConstructorInternal(that);
        }

        // Generated Dispose
        public void Dispose() {
            _DestructorInternal();
        }

        // Methods

        /// <summary>Initializes a tagSkillRecord with empty name, description, and formula strings, resetting the associated SkillFormula to its default state.
        /// <code>Offset: 0x004807B0
        /// void __thiscall gmCGSkillsPage::tagSkillRecord::tagSkillRecord(gmCGSkillsPage::tagSkillRecord*)</code>
        /// </summary>
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage.tagSkillRecord, void>)0x004807B0)(ref this);

        /// <summary>
        /// Deallocates resources owned by a tagSkillRecord instance, decrementing reference counts for strName, strDesc and strFormula string buffers and resetting the SkillFormula to its base class state.
        /// 
        /// <code>Offset: 0x00480810
        /// void __thiscall gmCGSkillsPage::tagSkillRecord::~tagSkillRecord(gmCGSkillsPage::tagSkillRecord*)</code>
        /// </summary>
        public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage.tagSkillRecord, void>)0x00480810)(ref this);

        /// <summary>Copies all UI elements and skill data from another tagSkillRecord into this instance, incrementing shared string buffer reference counts to maintain proper ownership.
        /// <code>Offset: 0x00480880
        /// void __thiscall gmCGSkillsPage::tagSkillRecord::tagSkillRecord(gmCGSkillsPage::tagSkillRecord*,const gmCGSkillsPage::tagSkillRecord*)</code>
        /// </summary>
        /// <param name="that">Source record whose contents are copied.</param>
        public void _ConstructorInternal(ACBindings.Internal.gmCGSkillsPage.tagSkillRecord* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage.tagSkillRecord, ACBindings.Internal.gmCGSkillsPage.tagSkillRecord*, void>)0x00480880)(ref this, that);
    }

    // Members
    public ACBindings.Internal.gmCGSkillsPage.tagSkillRecord m_tConstInit;
    public ACBindings.Internal.UIElement* m_pSpecEntry;
    public ACBindings.Internal.UIElement* m_pTrainedEntry;
    public ACBindings.Internal.UIElement* m_pUseableUntrainedEntry;
    public ACBindings.Internal.UIElement* m_pUnuseableUntrainedEntry;
    public ACBindings.Internal.UIElement_Text* m_pCreditsMeter;
    public ACBindings.Internal.UIElement_Text* m_pInfoBoxTitle;
    public ACBindings.Internal.UIElement_Text* m_pInfoBoxText;
    public ACBindings.Internal.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.Internal.gmCharGenMainUI* m_pMainFramework;
    public ACBindings.Internal.UIElement_ListBox* m_pSkillsListBox;
    public ACBindings.Internal.HashTable__uint___gmCGSkillsPage_tagSkillRecord m_hashSkills;

    // Generated Constructor
    public gmCGSkillsPage(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes the skills page by performing base UI element setup and registering with the global event handler.
    /// <code>Offset: 0x00480750
    /// void __thiscall gmCGSkillsPage::PostInit(gmCGTownPage*)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmCGTownPage instance that owns this skills page.</param>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, void>)0x00480750)(ref this);

    /// <summary>Updates the skill UI entry with current level, training costs, and button states for a given skill record.
    /// <code>Offset: 0x004809C0
    /// void __thiscall gmCGSkillsPage::SetSkillText(gmCGSkillsPage*,gmCGSkillsPage::tagSkillRecord*)</code>
    /// </summary>
    /// <param name="this">The skills page instance owning the UI elements.</param>
    /// <param name="tRec">Skill record containing UI references and cost data to be refreshed.</param>
    public void SetSkillText(ACBindings.Internal.gmCGSkillsPage.tagSkillRecord* tRec) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.gmCGSkillsPage.tagSkillRecord*, void>)0x004809C0)(ref this, tRec);

    /// <summary>Updates the credits meter display to show the current remaining skill credits from the character generation state.
    /// <code>Offset: 0x00480CB0
    /// void __thiscall gmCGSkillsPage::UpdateCreditsMeter(gmCGSkillsPage*)</code>
    /// </summary>
    public void UpdateCreditsMeter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, void>)0x00480CB0)(ref this);

    /// <summary>Refreshes all skill training values on the skills page, iterating through each registered skill to update its displayed text and then recalculates the credits meter.
    /// <code>Offset: 0x00480D10
    /// void __thiscall gmCGSkillsPage::UpdateAllTrainingValues(gmCGSkillsPage*)</code>
    /// </summary>
    public void UpdateAllTrainingValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, void>)0x00480D10)(ref this);

    /// <summary>Inserts a skill record’s UI element into the skills list box at its proper sorted position, ordering entries alphabetically by skill name.
    /// <code>Offset: 0x00480E00
    /// void __thiscall gmCGSkillsPage::InsertEntrySorted(gmCGSkillsPage*,gmCGSkillsPage::tagSkillRecord*,UIElement*,UIElement*)</code>
    /// </summary>
    /// <param name="tRec">Skill record containing the entry to insert and its associated data.</param>
    /// <param name="pAfter">Optional reference element marking the start of the search range; if null, the list is searched from the beginning.</param>
    /// <param name="pBefore">Optional reference element limiting the search to elements preceding it; if null, the search continues to the end of the list.</param>
    public void InsertEntrySorted(ACBindings.Internal.gmCGSkillsPage.tagSkillRecord* tRec, ACBindings.Internal.UIElement* pAfter, ACBindings.Internal.UIElement* pBefore) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.gmCGSkillsPage.tagSkillRecord*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void>)0x00480E00)(ref this, tRec, pAfter, pBefore);

    /// <summary>Updates the visual representation of a skill in the skills list, repositioning it according to its current advancement class (untrained, trained, or specialized). The existing entry is removed and re‑inserted into the appropriate section, sorted among peers.
    /// <code>Offset: 0x00480FB0
    /// void __thiscall gmCGSkillsPage::UpdateSkillEntry(gmCGSkillsPage*,gmCGSkillsPage::tagSkillRecord*)</code>
    /// </summary>
    /// <param name="this">The gmCGSkillsPage instance whose UI is being updated.</param>
    /// <param name="tRec">A tagSkillRecord describing the skill to refresh in the list.</param>
    public void UpdateSkillEntry(ACBindings.Internal.gmCGSkillsPage.tagSkillRecord* tRec) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.gmCGSkillsPage.tagSkillRecord*, void>)0x00480FB0)(ref this, tRec);

    /// <summary>
    /// Attempts to advance the selected skill from untrained to trained or to specialized, deducting required credits and updating UI entries when successful.
    /// 
    /// <code>Offset: 0x00481060
    /// void __thiscall gmCGSkillsPage::IncreaseSkillLevel(gmCGSkillsPage*,UIElement*)</code>
    /// </summary>
    /// <param name="pEntry">The UI element representing a skill entry; its instance ID identifies the corresponding skill record.</param>
    public void IncreaseSkillLevel(ACBindings.Internal.UIElement* pEntry) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.UIElement*, void>)0x00481060)(ref this, pEntry);

    /// <summary>Downgrades the training level of a selected skill, moving from higher to lower state if permitted and refreshing associated UI elements.
    /// <code>Offset: 0x00481120
    /// void __thiscall gmCGSkillsPage::DecreaseSkillLevel(gmCGSkillsPage*,UIElement*)</code>
    /// </summary>
    /// <param name="pEntry">The UI element representing the skill entry whose training level should be decreased.</param>
    public void DecreaseSkillLevel(ACBindings.Internal.UIElement* pEntry) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.UIElement*, void>)0x00481120)(ref this, pEntry);

    /// <summary>Builds the skill formula string for the supplied tagSkillRecord, formatting attribute names and scaling values into tRec-&gt;strFormula based on the current character generator state.
    /// <code>Offset: 0x004811D0
    /// void __thiscall gmCGSkillsPage::MakeSkillFormula(gmCGSkillsPage*,gmCGSkillsPage::tagSkillRecord*)</code>
    /// </summary>
    /// <param name="tRec">The skill record to update with its calculated formula text.</param>
    public void MakeSkillFormula(ACBindings.Internal.gmCGSkillsPage.tagSkillRecord* tRec) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.gmCGSkillsPage.tagSkillRecord*, void>)0x004811D0)(ref this, tRec);

    /// <summary>Displays detailed skill information in the info box when a skill list entry is selected; clears the text if no valid selection.
    /// <code>Offset: 0x00481610
    /// void __thiscall gmCGSkillsPage::ShowSkillsText(gmCGSkillsPage*,UIElement*)</code>
    /// </summary>
    /// <param name="pEntry">UI element representing the selected skill list entry.</param>
    public void ShowSkillsText(ACBindings.Internal.UIElement* pEntry) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.UIElement*, void>)0x00481610)(ref this, pEntry);

    /// <summary>Handles UI element messages for the skills page, updating skill levels and displaying information based on user interaction.
    /// <code>Offset: 0x00481880
    /// UIElementMessageListenResult __thiscall gmCGSkillsPage::ListenToElementMessage(gmCGSkillsPage*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">The gmCGSkillsPage instance receiving the message.</param>
    /// <param name="i_rMsg">Message info describing the source element, message type, and associated parameters.</param>
    /// <returns>Result from the base UI element listener indicating whether the event was handled.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00481880)(ref this, i_rMsg);

    /// <summary>Constructs a skills page UI element, initializing base UI components and preparing internal data structures for skill management.
    /// <code>Offset: 0x00481A00
    /// void __thiscall gmCGSkillsPage::gmCGSkillsPage(gmCGSkillsPage*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor used to build the UI layout of the skills page.</param>
    /// <param name="full_desc">Element description that defines the root UI element’s properties and children.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00481A00)(ref this, layout, full_desc);

    /// <summary>
    /// Performs a dynamic cast of the gmCGSkillsPage instance to the specified type identifier, returning a pointer to the desired base or derived interface when compatible, otherwise returns null.
    /// 
    /// <code>Offset: 0x00481A70
    /// UIElement* __thiscall gmCGSkillsPage::DynamicCast(gmCGSkillsPage*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The target type identifier for the requested cast.</param>
    /// <returns>A UIElement pointer representing the object in the requested form, or nullptr if the conversion is not possible.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, uint, ACBindings.Internal.UIElement*>)0x00481A70)(ref this, i_eType);

    /// <summary>Retrieves the unique type identifier for a gmCGSkillsPage UI element.
    /// <code>Offset: 0x00481A90
    /// unsigned int __thiscall gmCGSkillsPage::GetUIElementType(gmCGSkillsPage*)</code>
    /// </summary>
    /// <returns>The constant UI element type value, currently set to 268435515.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, uint>)0x00481A90)(ref this);

    /// <summary>Destroys a gmCGSkillsPage instance, cleaning up UI components, unregistering event handlers, clearing the internal skills hash table, and destroying contained skill records.
    /// <code>Offset: 0x00481AA0
    /// void __thiscall gmCGSkillsPage::~gmCGSkillsPage(gmCGSkillsPage*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, void>)0x00481AA0)(ref this);

    /// <summary>Creates a new skills page UI element initialized with the supplied layout and element description.
    /// <code>Offset: 0x00481B30
    /// UIElement* __cdecl gmCGSkillsPage::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining display dimensions and elements for the skills page.</param>
    /// <param name="full_desc">Full element descriptor providing properties and state information for the root element of the skills page.</param>
    /// <returns>Pointer to the newly constructed UIElement representing the skills page, or null if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00481B30)(layout, full_desc);

    /// <summary>Registers the skills page UI element class so that it can be instantiated by the UI system.
    /// <code>Offset: 0x00481B80
    /// void __cdecl gmCGSkillsPage::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00481B80)();

    /// <summary>Initializes the skills list UI by clearing existing items, creating template entries for each skill category (specialized, trained, useable/untrained, unuseable/untrained), then iterating through all character generator skill records to populate detailed skill entries with level, score, and cost information while updating internal lookup tables.
    /// <code>Offset: 0x00481BA0
    /// void __thiscall gmCGSkillsPage::DoSkillRecords(gmCGSkillsPage*)</code>
    /// </summary>
    public void DoSkillRecords() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, void>)0x00481BA0)(ref this);

    /// <summary>Refreshes the skills page by updating skill records and training values.
    /// <code>Offset: 0x00482180
    /// void __thiscall gmCGSkillsPage::Update(gmCGSkillsPage*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, void>)0x00482180)(ref this);

    /// <summary>Initializes the skills page by acquiring player system information, locating key UI components such as the skills list, credit meter, and info box, then populating skill records and refreshing the credits display.
    /// <code>Offset: 0x00482190
    /// void __thiscall gmCGSkillsPage::InitializePage(gmCGSkillsPage*,gmCharGenMainUI*)</code>
    /// </summary>
    /// <param name="pMain">Reference to the main character generation UI framework used to access shared resources and child elements.</param>
    public void InitializePage(ACBindings.Internal.gmCharGenMainUI* pMain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.gmCharGenMainUI*, void>)0x00482190)(ref this, pMain);
}

