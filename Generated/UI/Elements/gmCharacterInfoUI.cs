namespace ACBindings;

// gmCharacterInfoUI
public unsafe struct gmCharacterInfoUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler
    public ACBindings.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.QualityChangeHandler

    // Child Types
    // gmCharacterInfoUI_vtbl
    public unsafe struct gmCharacterInfoUI_vtbl
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
    public ACBindings.UIElement_Text* m_pMainText;

    // Generated Constructor
    public gmCharacterInfoUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmCharacterInfoUI::PostInit(gmCharacterInfoUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, void>)0x004B9310)(ref this);
    // void __thiscall gmCharacterInfoUI::~gmCharacterInfoUI(gmCharacterInfoUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, void>)0x004B9370)(ref this);
    // UIElement* __thiscall gmCharacterInfoUI::DynamicCast(gmCharacterInfoUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, uint, ACBindings.UIElement*>)0x004B93D0)(ref this, i_eType);
    // unsigned int __thiscall gmCharacterInfoUI::GetUIElementType(gmCharacterInfoUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, uint>)0x004B93F0)(ref this);
    // bool __thiscall gmCharacterInfoUI::UpdateInnateAttributeInfo(gmCharacterInfoUI*,const CACQualities*)
    public byte UpdateInnateAttributeInfo(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, ACBindings.CACQualities*, byte>)0x004B9400)(ref this, i_playerDesc);
    // bool __thiscall gmCharacterInfoUI::UpdateFakeSkills(gmCharacterInfoUI*,const CACQualities*)
    public byte UpdateFakeSkills(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, ACBindings.CACQualities*, byte>)0x004B9550)(ref this, i_playerDesc);
    // bool __thiscall gmCharacterInfoUI::UpdateLoad(gmCharacterInfoUI*,const CACQualities*)
    public byte UpdateLoad(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, ACBindings.CACQualities*, byte>)0x004B9640)(ref this, i_playerDesc);
    // void __thiscall gmCharacterInfoUI::gmCharacterInfoUI(gmCharacterInfoUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004B9800)(ref this, layout, full_desc);
    // void __cdecl gmCharacterInfoUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004B98B0)();
    // bool __thiscall gmCharacterInfoUI::UpdatePlayerBirthAgeDeaths(gmCharacterInfoUI*,const CACQualities*)
    public byte UpdatePlayerBirthAgeDeaths(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, ACBindings.CACQualities*, byte>)0x004B98D0)(ref this, i_playerDesc);
    // bool __thiscall gmCharacterInfoUI::UpdateEnduranceInfo(gmCharacterInfoUI*,const CACQualities*)
    public byte UpdateEnduranceInfo(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, ACBindings.CACQualities*, byte>)0x004B9B40)(ref this, i_playerDesc);
    // bool __thiscall gmCharacterInfoUI::UpdateAugmentations(gmCharacterInfoUI*,const CACQualities*)
    public byte UpdateAugmentations(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, ACBindings.CACQualities*, byte>)0x004B9C90)(ref this, i_playerDesc);
    // bool __thiscall gmCharacterInfoUI::Update(gmCharacterInfoUI*,const CACQualities*)
    public byte Update(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, ACBindings.CACQualities*, byte>)0x004BB420)(ref this, i_playerDesc);
    // void __thiscall gmCharacterInfoUI::RecvNotice_PlayerDescReceived(gmCharacterInfoUI*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x004BB5C0)(ref this, i_playerDesc, i_playerModule);
    // bool __thiscall gmCharacterInfoUI::Update(gmCharacterInfoUI*)
    public byte Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, byte>)0x004BB5E0)(ref this);
    // UIElementMessageListenResult __thiscall gmCharacterInfoUI::ListenToElementMessage(gmCharacterInfoUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004BB690)(ref this, i_rMsg);
    // void __thiscall gmCharacterInfoUI::RecvNotice_LoadChanged(gmCharacterInfoUI*,float)
    public void RecvNotice_LoadChanged(float fNewLoad) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, float, void>)0x004BB6C0)(ref this, fNewLoad);
    // void __thiscall gmCharacterInfoUI::OnQualityChanged(gmCharacterInfoUI*,CWeenieObject*,StatType,unsigned int)
    public void OnQualityChanged(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterInfoUI, ACBindings.CWeenieObject*, ACBindings.StatType, uint, void>)0x004BB6D0)(ref this, cwobj, stype, senum);
}

