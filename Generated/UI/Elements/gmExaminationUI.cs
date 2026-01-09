namespace ACBindings;

// gmExaminationUI
public unsafe struct gmExaminationUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmExaminationUI_vtbl
    public unsafe struct gmExaminationUI_vtbl
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
    public ACBindings.ExamineSubUI* m_activeUI;
    public ACBindings.ItemExamineUI* m_itemUI;
    public ACBindings.CreatureExamineUI* m_creatureUI;
    public ACBindings.CharExamineUI* m_charUI;
    public ACBindings.SpellExamineUI* m_spellUI;
    public ACBindings.UIElement_Text* m_displayedNameText;
    public uint awaiting_appraisal_ID;
    public uint current_appraisal_ID;
    public byte m_examineNewlySelectedItem;
    public double m_timeNextUpdate;

    // Generated Constructor
    public gmExaminationUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmExaminationUI::gmExaminationUI(gmExaminationUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004AB630)(ref this, layout, full_desc);
    // UIElement* __thiscall gmExaminationUI::DynamicCast(gmExaminationUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, uint, ACBindings.UIElement*>)0x004AB6B0)(ref this, i_eType);
    // unsigned int __thiscall gmExaminationUI::GetUIElementType(gmExaminationUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, uint>)0x004AB6D0)(ref this);
    // UIElement* __cdecl gmExaminationUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004AB6E0)(layout, full_desc);
    // bool __thiscall gmExaminationUI::OnChildAction(gmExaminationUI*,const UIElement*,const InputEvent*)
    public byte OnChildAction(ACBindings.UIElement* i_pChild, ACBindings.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, ACBindings.UIElement*, ACBindings.InputEvent*, byte>)0x004AB710)(ref this, i_pChild, i_evt);
    // void __thiscall gmExaminationUI::RecvNotice_SelectionChanged(gmExaminationUI*)
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, void>)0x004AB750)(ref this);
    // void __thiscall gmExaminationUI::SetActiveExamineUI(gmExaminationUI*,ExamineSubUI*)
    public void SetActiveExamineUI(ACBindings.ExamineSubUI* ui) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, ACBindings.ExamineSubUI*, void>)0x004AB7A0)(ref this, ui);
    // void __thiscall gmExaminationUI::UseTime(gmExaminationUI*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, void>)0x004AB8B0)(ref this);
    // void __cdecl gmExaminationUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004ABB00)();
    // void __thiscall gmExaminationUI::ListenToGlobalMessage(gmExaminationUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, uint, int, void>)0x004ABB20)(ref this, i_messageID, i_data_int);
    // void __thiscall gmExaminationUI::RecvNotice_ExamineObject(gmExaminationUI*,unsigned int)
    public void RecvNotice_ExamineObject(uint i_objid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, uint, void>)0x004ABB30)(ref this, i_objid);
    // void __thiscall gmExaminationUI::RecvNotice_UpdateSpellComponents(gmExaminationUI*,int)
    public void RecvNotice_UpdateSpellComponents(int i_change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, int, void>)0x004AC3C0)(ref this, i_change);
    // void __thiscall gmExaminationUI::PostInit(gmExaminationUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, void>)0x004ADA20)(ref this);
    // void __thiscall gmExaminationUI::RecvNotice_ServerSaysMoveItem(gmExaminationUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004ADB80)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);
    // void __thiscall gmExaminationUI::~gmExaminationUI(gmExaminationUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, void>)0x004ADBD0)(ref this);
    // void __thiscall gmExaminationUI::SetTitleText(gmExaminationUI*,const char*,int)
    public void SetTitleText(sbyte* name, int stack) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, sbyte*, int, void>)0x004ADCB0)(ref this, name, stack);
    // void __thiscall gmExaminationUI::SetAppraiseInfo(gmExaminationUI*,unsigned int,const AppraisalProfile*)
    public void SetAppraiseInfo(uint objid, ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, uint, ACBindings.AppraisalProfile*, void>)0x004ADE60)(ref this, objid, prof);
    // UIElementMessageListenResult __thiscall gmExaminationUI::ListenToElementMessage(gmExaminationUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004B6CE0)(ref this, i_rMsg);
    // void __thiscall gmExaminationUI::RecvNotice_SetAppraiseInfo(gmExaminationUI*,unsigned int,const AppraisalProfile*)
    public void RecvNotice_SetAppraiseInfo(uint i_objid, ACBindings.AppraisalProfile* i_prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, uint, ACBindings.AppraisalProfile*, void>)0x004B6E20)(ref this, i_objid, i_prof);
    // void __thiscall gmExaminationUI::RecvNotice_ExamineSpell(gmExaminationUI*,unsigned int)
    public void RecvNotice_ExamineSpell(uint i_spellid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExaminationUI, uint, void>)0x004B75A0)(ref this, i_spellid);
}

