namespace ACBindings;

// gmCGSkillsPage
public unsafe struct gmCGSkillsPage : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmCGSkillsPage_vtbl
    public unsafe struct gmCGSkillsPage_vtbl
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
    // gmCGSkillsPage::tagSkillRecord
    public unsafe struct tagSkillRecord : System.IDisposable
    {
        // Members
        public ACBindings.UIElement* pEntry;
        public ACBindings.UIElement_Text* pUpCostText;
        public ACBindings.UIElement_Text* pDownCostText;
        public ACBindings.UIElement_Text* pSkillLevelText;
        public ACBindings.UIElement_Button* pSkillUpButton;
        public ACBindings.UIElement_Button* pSkillDownButton;
        public ACBindings.PStringBase__ushort strName;
        public ACBindings.PStringBase__ushort strDesc;
        public ACBindings.PStringBase__ushort strFormula;
        public int iSkillID;
        public int iSkillLevel;
        public int iTrainCost;
        public int iSpecCost;
        public int iMinlevel;
        public byte bUntrainable;
        public byte bUnspecializable;
        public ACBindings.SKILL_ADVANCEMENT_CLASS saCurClass;
        public ACBindings.SkillFormula formSkill;

        // Generated Constructor
        public tagSkillRecord() {
            _ConstructorInternal();
        }
        public tagSkillRecord(ACBindings.gmCGSkillsPage.tagSkillRecord* that) {
            _ConstructorInternal(that);
        }

        // Generated Dispose
        public void Dispose() {
            _DestructorInternal();
        }

        // Methods
        // void __thiscall gmCGSkillsPage::tagSkillRecord::tagSkillRecord(gmCGSkillsPage::tagSkillRecord*)
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage.tagSkillRecord, void>)0x004807B0)(ref this);
        // void __thiscall gmCGSkillsPage::tagSkillRecord::~tagSkillRecord(gmCGSkillsPage::tagSkillRecord*)
        public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage.tagSkillRecord, void>)0x00480810)(ref this);
        // void __thiscall gmCGSkillsPage::tagSkillRecord::tagSkillRecord(gmCGSkillsPage::tagSkillRecord*,const gmCGSkillsPage::tagSkillRecord*)
        public void _ConstructorInternal(ACBindings.gmCGSkillsPage.tagSkillRecord* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage.tagSkillRecord, ACBindings.gmCGSkillsPage.tagSkillRecord*, void>)0x00480880)(ref this, that);
    }

    // Members
    public ACBindings.gmCGSkillsPage.tagSkillRecord m_tConstInit;
    public ACBindings.UIElement* m_pSpecEntry;
    public ACBindings.UIElement* m_pTrainedEntry;
    public ACBindings.UIElement* m_pUseableUntrainedEntry;
    public ACBindings.UIElement* m_pUnuseableUntrainedEntry;
    public ACBindings.UIElement_Text* m_pCreditsMeter;
    public ACBindings.UIElement_Text* m_pInfoBoxTitle;
    public ACBindings.UIElement_Text* m_pInfoBoxText;
    public ACBindings.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.gmCharGenMainUI* m_pMainFramework;
    public ACBindings.UIElement_ListBox* m_pSkillsListBox;
    public ACBindings.HashTable__uint__gmCGSkillsPage_tagSkillRecord m_hashSkills;

    // Generated Constructor
    public gmCGSkillsPage(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmCGSkillsPage::PostInit(gmCGTownPage*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, void>)0x00480750)(ref this);
    // void __thiscall gmCGSkillsPage::SetSkillText(gmCGSkillsPage*,gmCGSkillsPage::tagSkillRecord*)
    public void SetSkillText(ACBindings.gmCGSkillsPage.tagSkillRecord* tRec) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, ACBindings.gmCGSkillsPage.tagSkillRecord*, void>)0x004809C0)(ref this, tRec);
    // void __thiscall gmCGSkillsPage::UpdateCreditsMeter(gmCGSkillsPage*)
    public void UpdateCreditsMeter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, void>)0x00480CB0)(ref this);
    // void __thiscall gmCGSkillsPage::UpdateAllTrainingValues(gmCGSkillsPage*)
    public void UpdateAllTrainingValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, void>)0x00480D10)(ref this);
    // void __thiscall gmCGSkillsPage::InsertEntrySorted(gmCGSkillsPage*,gmCGSkillsPage::tagSkillRecord*,UIElement*,UIElement*)
    public void InsertEntrySorted(ACBindings.gmCGSkillsPage.tagSkillRecord* tRec, ACBindings.UIElement* pAfter, ACBindings.UIElement* pBefore) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, ACBindings.gmCGSkillsPage.tagSkillRecord*, ACBindings.UIElement*, ACBindings.UIElement*, void>)0x00480E00)(ref this, tRec, pAfter, pBefore);
    // void __thiscall gmCGSkillsPage::UpdateSkillEntry(gmCGSkillsPage*,gmCGSkillsPage::tagSkillRecord*)
    public void UpdateSkillEntry(ACBindings.gmCGSkillsPage.tagSkillRecord* tRec) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, ACBindings.gmCGSkillsPage.tagSkillRecord*, void>)0x00480FB0)(ref this, tRec);
    // void __thiscall gmCGSkillsPage::IncreaseSkillLevel(gmCGSkillsPage*,UIElement*)
    public void IncreaseSkillLevel(ACBindings.UIElement* pEntry) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, ACBindings.UIElement*, void>)0x00481060)(ref this, pEntry);
    // void __thiscall gmCGSkillsPage::DecreaseSkillLevel(gmCGSkillsPage*,UIElement*)
    public void DecreaseSkillLevel(ACBindings.UIElement* pEntry) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, ACBindings.UIElement*, void>)0x00481120)(ref this, pEntry);
    // void __thiscall gmCGSkillsPage::MakeSkillFormula(gmCGSkillsPage*,gmCGSkillsPage::tagSkillRecord*)
    public void MakeSkillFormula(ACBindings.gmCGSkillsPage.tagSkillRecord* tRec) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, ACBindings.gmCGSkillsPage.tagSkillRecord*, void>)0x004811D0)(ref this, tRec);
    // void __thiscall gmCGSkillsPage::ShowSkillsText(gmCGSkillsPage*,UIElement*)
    public void ShowSkillsText(ACBindings.UIElement* pEntry) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, ACBindings.UIElement*, void>)0x00481610)(ref this, pEntry);
    // UIElementMessageListenResult __thiscall gmCGSkillsPage::ListenToElementMessage(gmCGSkillsPage*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x00481880)(ref this, i_rMsg);
    // void __thiscall gmCGSkillsPage::gmCGSkillsPage(gmCGSkillsPage*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x00481A00)(ref this, layout, full_desc);
    // UIElement* __thiscall gmCGSkillsPage::DynamicCast(gmCGSkillsPage*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, uint, ACBindings.UIElement*>)0x00481A70)(ref this, i_eType);
    // unsigned int __thiscall gmCGSkillsPage::GetUIElementType(gmCGSkillsPage*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, uint>)0x00481A90)(ref this);
    // void __thiscall gmCGSkillsPage::~gmCGSkillsPage(gmCGSkillsPage*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, void>)0x00481AA0)(ref this);
    // UIElement* __cdecl gmCGSkillsPage::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x00481B30)(layout, full_desc);
    // void __cdecl gmCGSkillsPage::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00481B80)();
    // void __thiscall gmCGSkillsPage::DoSkillRecords(gmCGSkillsPage*)
    public void DoSkillRecords() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, void>)0x00481BA0)(ref this);
    // void __thiscall gmCGSkillsPage::Update(gmCGSkillsPage*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, void>)0x00482180)(ref this);
    // void __thiscall gmCGSkillsPage::InitializePage(gmCGSkillsPage*,gmCharGenMainUI*)
    public void InitializePage(ACBindings.gmCharGenMainUI* pMain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSkillsPage, ACBindings.gmCharGenMainUI*, void>)0x00482190)(ref this, pMain);
}

