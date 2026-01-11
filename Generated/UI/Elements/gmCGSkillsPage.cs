namespace ACBindings.Internal;

public unsafe struct gmCGSkillsPage : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmCGSkillsPage_vtbl
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

        /// <summary>
        /// <code>Offset: 0x004807B0
        /// void __thiscall gmCGSkillsPage::tagSkillRecord::tagSkillRecord(gmCGSkillsPage::tagSkillRecord*)</code>
        /// </summary>
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage.tagSkillRecord, void>)0x004807B0)(ref this);

        /// <summary>
        /// <code>Offset: 0x00480810
        /// void __thiscall gmCGSkillsPage::tagSkillRecord::~tagSkillRecord(gmCGSkillsPage::tagSkillRecord*)</code>
        /// </summary>
        public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage.tagSkillRecord, void>)0x00480810)(ref this);

        /// <summary>
        /// <code>Offset: 0x00480880
        /// void __thiscall gmCGSkillsPage::tagSkillRecord::tagSkillRecord(gmCGSkillsPage::tagSkillRecord*,const gmCGSkillsPage::tagSkillRecord*)</code>
        /// </summary>
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

    /// <summary>
    /// <code>Offset: 0x00480750
    /// void __thiscall gmCGSkillsPage::PostInit(gmCGTownPage*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, void>)0x00480750)(ref this);

    /// <summary>
    /// <code>Offset: 0x004809C0
    /// void __thiscall gmCGSkillsPage::SetSkillText(gmCGSkillsPage*,gmCGSkillsPage::tagSkillRecord*)</code>
    /// </summary>
    public void SetSkillText(ACBindings.Internal.gmCGSkillsPage.tagSkillRecord* tRec) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.gmCGSkillsPage.tagSkillRecord*, void>)0x004809C0)(ref this, tRec);

    /// <summary>
    /// <code>Offset: 0x00480CB0
    /// void __thiscall gmCGSkillsPage::UpdateCreditsMeter(gmCGSkillsPage*)</code>
    /// </summary>
    public void UpdateCreditsMeter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, void>)0x00480CB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00480D10
    /// void __thiscall gmCGSkillsPage::UpdateAllTrainingValues(gmCGSkillsPage*)</code>
    /// </summary>
    public void UpdateAllTrainingValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, void>)0x00480D10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00480E00
    /// void __thiscall gmCGSkillsPage::InsertEntrySorted(gmCGSkillsPage*,gmCGSkillsPage::tagSkillRecord*,UIElement*,UIElement*)</code>
    /// </summary>
    public void InsertEntrySorted(ACBindings.Internal.gmCGSkillsPage.tagSkillRecord* tRec, ACBindings.Internal.UIElement* pAfter, ACBindings.Internal.UIElement* pBefore) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.gmCGSkillsPage.tagSkillRecord*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void>)0x00480E00)(ref this, tRec, pAfter, pBefore);

    /// <summary>
    /// <code>Offset: 0x00480FB0
    /// void __thiscall gmCGSkillsPage::UpdateSkillEntry(gmCGSkillsPage*,gmCGSkillsPage::tagSkillRecord*)</code>
    /// </summary>
    public void UpdateSkillEntry(ACBindings.Internal.gmCGSkillsPage.tagSkillRecord* tRec) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.gmCGSkillsPage.tagSkillRecord*, void>)0x00480FB0)(ref this, tRec);

    /// <summary>
    /// <code>Offset: 0x00481060
    /// void __thiscall gmCGSkillsPage::IncreaseSkillLevel(gmCGSkillsPage*,UIElement*)</code>
    /// </summary>
    public void IncreaseSkillLevel(ACBindings.Internal.UIElement* pEntry) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.UIElement*, void>)0x00481060)(ref this, pEntry);

    /// <summary>
    /// <code>Offset: 0x00481120
    /// void __thiscall gmCGSkillsPage::DecreaseSkillLevel(gmCGSkillsPage*,UIElement*)</code>
    /// </summary>
    public void DecreaseSkillLevel(ACBindings.Internal.UIElement* pEntry) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.UIElement*, void>)0x00481120)(ref this, pEntry);

    /// <summary>
    /// <code>Offset: 0x004811D0
    /// void __thiscall gmCGSkillsPage::MakeSkillFormula(gmCGSkillsPage*,gmCGSkillsPage::tagSkillRecord*)</code>
    /// </summary>
    public void MakeSkillFormula(ACBindings.Internal.gmCGSkillsPage.tagSkillRecord* tRec) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.gmCGSkillsPage.tagSkillRecord*, void>)0x004811D0)(ref this, tRec);

    /// <summary>
    /// <code>Offset: 0x00481610
    /// void __thiscall gmCGSkillsPage::ShowSkillsText(gmCGSkillsPage*,UIElement*)</code>
    /// </summary>
    public void ShowSkillsText(ACBindings.Internal.UIElement* pEntry) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.UIElement*, void>)0x00481610)(ref this, pEntry);

    /// <summary>
    /// <code>Offset: 0x00481880
    /// UIElementMessageListenResult __thiscall gmCGSkillsPage::ListenToElementMessage(gmCGSkillsPage*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00481880)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x00481A00
    /// void __thiscall gmCGSkillsPage::gmCGSkillsPage(gmCGSkillsPage*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00481A00)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x00481A70
    /// UIElement* __thiscall gmCGSkillsPage::DynamicCast(gmCGSkillsPage*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, uint, ACBindings.Internal.UIElement*>)0x00481A70)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x00481A90
    /// unsigned int __thiscall gmCGSkillsPage::GetUIElementType(gmCGSkillsPage*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, uint>)0x00481A90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00481AA0
    /// void __thiscall gmCGSkillsPage::~gmCGSkillsPage(gmCGSkillsPage*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, void>)0x00481AA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00481B30
    /// UIElement* __cdecl gmCGSkillsPage::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00481B30)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x00481B80
    /// void __cdecl gmCGSkillsPage::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00481B80)();

    /// <summary>
    /// <code>Offset: 0x00481BA0
    /// void __thiscall gmCGSkillsPage::DoSkillRecords(gmCGSkillsPage*)</code>
    /// </summary>
    public void DoSkillRecords() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, void>)0x00481BA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00482180
    /// void __thiscall gmCGSkillsPage::Update(gmCGSkillsPage*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, void>)0x00482180)(ref this);

    /// <summary>
    /// <code>Offset: 0x00482190
    /// void __thiscall gmCGSkillsPage::InitializePage(gmCGSkillsPage*,gmCharGenMainUI*)</code>
    /// </summary>
    public void InitializePage(ACBindings.Internal.gmCharGenMainUI* pMain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSkillsPage, ACBindings.Internal.gmCharGenMainUI*, void>)0x00482190)(ref this, pMain);
}

