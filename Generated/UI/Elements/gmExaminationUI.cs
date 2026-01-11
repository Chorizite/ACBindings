namespace ACBindings.Internal;

public unsafe struct gmExaminationUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmExaminationUI_vtbl
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
    public ACBindings.Internal.ExamineSubUI* m_activeUI;
    public ACBindings.Internal.ItemExamineUI* m_itemUI;
    public ACBindings.Internal.CreatureExamineUI* m_creatureUI;
    public ACBindings.Internal.CharExamineUI* m_charUI;
    public ACBindings.Internal.SpellExamineUI* m_spellUI;
    public ACBindings.Internal.UIElement_Text* m_displayedNameText;
    public uint awaiting_appraisal_ID;
    public uint current_appraisal_ID;
    public byte m_examineNewlySelectedItem;
    public double m_timeNextUpdate;

    // Generated Constructor
    public gmExaminationUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004AB630
    /// void __thiscall gmExaminationUI::gmExaminationUI(gmExaminationUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004AB630)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004AB6B0
    /// UIElement* __thiscall gmExaminationUI::DynamicCast(gmExaminationUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint, ACBindings.Internal.UIElement*>)0x004AB6B0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004AB6D0
    /// unsigned int __thiscall gmExaminationUI::GetUIElementType(gmExaminationUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint>)0x004AB6D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004AB6E0
    /// UIElement* __cdecl gmExaminationUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004AB6E0)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004AB710
    /// bool __thiscall gmExaminationUI::OnChildAction(gmExaminationUI*,const UIElement*,const InputEvent*)</code>
    /// </summary>
    public byte OnChildAction(ACBindings.Internal.UIElement* i_pChild, ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte>)0x004AB710)(ref this, i_pChild, i_evt);

    /// <summary>
    /// <code>Offset: 0x004AB750
    /// void __thiscall gmExaminationUI::RecvNotice_SelectionChanged(gmExaminationUI*)</code>
    /// </summary>
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, void>)0x004AB750)(ref this);

    /// <summary>
    /// <code>Offset: 0x004AB7A0
    /// void __thiscall gmExaminationUI::SetActiveExamineUI(gmExaminationUI*,ExamineSubUI*)</code>
    /// </summary>
    public void SetActiveExamineUI(ACBindings.Internal.ExamineSubUI* ui) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, ACBindings.Internal.ExamineSubUI*, void>)0x004AB7A0)(ref this, ui);

    /// <summary>
    /// <code>Offset: 0x004AB8B0
    /// void __thiscall gmExaminationUI::UseTime(gmExaminationUI*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, void>)0x004AB8B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004ABB00
    /// void __cdecl gmExaminationUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004ABB00)();

    /// <summary>
    /// <code>Offset: 0x004ABB20
    /// void __thiscall gmExaminationUI::ListenToGlobalMessage(gmExaminationUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint, int, void>)0x004ABB20)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x004ABB30
    /// void __thiscall gmExaminationUI::RecvNotice_ExamineObject(gmExaminationUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ExamineObject(uint i_objid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint, void>)0x004ABB30)(ref this, i_objid);

    /// <summary>
    /// <code>Offset: 0x004AC3C0
    /// void __thiscall gmExaminationUI::RecvNotice_UpdateSpellComponents(gmExaminationUI*,int)</code>
    /// </summary>
    public void RecvNotice_UpdateSpellComponents(int i_change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, int, void>)0x004AC3C0)(ref this, i_change);

    /// <summary>
    /// <code>Offset: 0x004ADA20
    /// void __thiscall gmExaminationUI::PostInit(gmExaminationUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, void>)0x004ADA20)(ref this);

    /// <summary>
    /// <code>Offset: 0x004ADB80
    /// void __thiscall gmExaminationUI::RecvNotice_ServerSaysMoveItem(gmExaminationUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004ADB80)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>
    /// <code>Offset: 0x004ADBD0
    /// void __thiscall gmExaminationUI::~gmExaminationUI(gmExaminationUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, void>)0x004ADBD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004ADCB0
    /// void __thiscall gmExaminationUI::SetTitleText(gmExaminationUI*,const char*,int)</code>
    /// </summary>
    public void SetTitleText(sbyte* name, int stack) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, sbyte*, int, void>)0x004ADCB0)(ref this, name, stack);

    /// <summary>
    /// <code>Offset: 0x004ADE60
    /// void __thiscall gmExaminationUI::SetAppraiseInfo(gmExaminationUI*,unsigned int,const AppraisalProfile*)</code>
    /// </summary>
    public void SetAppraiseInfo(uint objid, ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint, ACBindings.Internal.AppraisalProfile*, void>)0x004ADE60)(ref this, objid, prof);

    /// <summary>
    /// <code>Offset: 0x004B6CE0
    /// UIElementMessageListenResult __thiscall gmExaminationUI::ListenToElementMessage(gmExaminationUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004B6CE0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004B6E20
    /// void __thiscall gmExaminationUI::RecvNotice_SetAppraiseInfo(gmExaminationUI*,unsigned int,const AppraisalProfile*)</code>
    /// </summary>
    public void RecvNotice_SetAppraiseInfo(uint i_objid, ACBindings.Internal.AppraisalProfile* i_prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint, ACBindings.Internal.AppraisalProfile*, void>)0x004B6E20)(ref this, i_objid, i_prof);

    /// <summary>
    /// <code>Offset: 0x004B75A0
    /// void __thiscall gmExaminationUI::RecvNotice_ExamineSpell(gmExaminationUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ExamineSpell(uint i_spellid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint, void>)0x004B75A0)(ref this, i_spellid);
}

