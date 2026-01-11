namespace ACBindings.Internal;

public unsafe struct PlayerOptionPage : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.OptionPage BaseClass_OptionPage; // ACBindings.Internal.OptionPage

    // Child Types
    public unsafe struct PlayerOptionPage_vtbl
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
    // PlayerOptionPage::OptionListType
    public enum OptionListType : byte
    {
        Header_OptionListType = 0x0,
        Seperator_OptionListType = 0x1,
        Boolean_OptionListType = 0x2,
        Float_OptionListType = 0x3,
        Menu_OptionListType = 0x4,
        BoolAndFloat_OptionListType = 0x5,
        FloatWithLabels_OptionListType = 0x6,
        BoolAndFloatWithLabels_OptionListType = 0x7,
        Bitfield64_OptionListType = 0x8
    }

    // Members
    public ACBindings.Internal.UIElement_ListBox* m_pOptionBox;

    // Generated Constructor
    public PlayerOptionPage(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F32E0
    /// void __thiscall PlayerOptionPage::PlayerOptionPage(PlayerOptionPage*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004F32E0)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004F3320
    /// void __thiscall PlayerOptionPage::~PlayerOptionPage(PlayerOptionPage*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, void>)0x004F3320)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F3340
    /// void __thiscall PlayerOptionPage::OnVisibilityChanged(PlayerOptionPage*,bool)</code>
    /// </summary>
    public void OnVisibilityChanged(byte i_bVisibleNow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, byte, void>)0x004F3340)(ref this, i_bVisibleNow);

    /// <summary>
    /// <code>Offset: 0x004F3370
    /// bool __thiscall PlayerOptionPage::SaveCurrentValues(PlayerOptionPage*)</code>
    /// </summary>
    public byte SaveCurrentValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, byte>)0x004F3370)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F3390
    /// bool __thiscall PlayerOptionPage::AddSeperator(PlayerOptionPage*)</code>
    /// </summary>
    public byte AddSeperator() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, byte>)0x004F3390)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F33B0
    /// void __thiscall PlayerOptionPage::SetToggleLabel(PlayerOptionPage*,UIOption_Checkbox*,unsigned int,unsigned int)</code>
    /// </summary>
    public void SetToggleLabel(ACBindings.Internal.UIOption_Checkbox* pToggle, uint tokLabel, uint tokTooltip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, ACBindings.Internal.UIOption_Checkbox*, uint, uint, void>)0x004F33B0)(ref this, pToggle, tokLabel, tokTooltip);

    /// <summary>
    /// <code>Offset: 0x004F3430
    /// void __thiscall PlayerOptionPage::OnOptionChanged(PlayerOptionPage*,const UIOption*)</code>
    /// </summary>
    public void OnOptionChanged(ACBindings.Internal.UIOption* pOption) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, ACBindings.Internal.UIOption*, void>)0x004F3430)(ref this, pOption);

    /// <summary>
    /// <code>Offset: 0x004F34B0
    /// void __thiscall PlayerOptionPage::OnOptionChangeConfirmed(PlayerOptionPage*,const UIOption*,bool)</code>
    /// </summary>
    public void OnOptionChangeConfirmed(ACBindings.Internal.UIOption* pOption, byte bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, ACBindings.Internal.UIOption*, byte, void>)0x004F34B0)(ref this, pOption, bConfirm);

    /// <summary>
    /// <code>Offset: 0x004F3510
    /// bool __thiscall PlayerOptionPage::AddHeader(PlayerOptionPage*,unsigned int)</code>
    /// </summary>
    public byte AddHeader(uint st) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, uint, byte>)0x004F3510)(ref this, st);

    /// <summary>
    /// <code>Offset: 0x004F3590
    /// UIOption* __thiscall PlayerOptionPage::AddToggleWithSliderOption(OptionPage*,int*,char**)</code>
    /// </summary>
    public ACBindings.Internal.UIOption* AddToggleWithSliderOption(int* a2, sbyte** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, int*, sbyte**, ACBindings.Internal.UIOption*>)0x004F3590)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004F35F0
    /// UIOption* __thiscall PlayerOptionPage::AddToggleOption(OptionPage*,int*)</code>
    /// </summary>
    public ACBindings.Internal.UIOption* AddToggleOption(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, int*, ACBindings.Internal.UIOption*>)0x004F35F0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004F3660
    /// UIOption_Checkbox* __thiscall PlayerOptionPage::AddToggleOption(PlayerOptionPage*,PlayerOption)</code>
    /// </summary>
    public ACBindings.Internal.UIOption_Checkbox* AddToggleOption(ACBindings.Internal.PlayerOption po) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, ACBindings.Internal.PlayerOption, ACBindings.Internal.UIOption_Checkbox*>)0x004F3660)(ref this, po);

    /// <summary>
    /// <code>Offset: 0x004F36D0
    /// UIOption* __thiscall PlayerOptionPage::AddSliderOption(OptionPage*,char**,char)</code>
    /// </summary>
    public ACBindings.Internal.UIOption* AddSliderOption(sbyte** a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, sbyte**, sbyte, ACBindings.Internal.UIOption*>)0x004F36D0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004F3750
    /// UIOption* __thiscall PlayerOptionPage::AddMenuOption(OptionPage*,bool (__cdecl**a2)(),char)</code>
    /// </summary>
    public ACBindings.Internal.UIOption* AddMenuOption(delegate* unmanaged[Cdecl]<byte>* a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, delegate* unmanaged[Cdecl]<byte>*, sbyte, ACBindings.Internal.UIOption*>)0x004F3750)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004F37E0
    /// void __thiscall PlayerOptionPage::SetSliderLabel(PlayerOptionPage*,UIOption_Slider*,unsigned int,unsigned int)</code>
    /// </summary>
    public void SetSliderLabel(ACBindings.Internal.UIOption_Slider* pSlider, uint tokMinLabel, uint tokMaxLabel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, ACBindings.Internal.UIOption_Slider*, uint, uint, void>)0x004F37E0)(ref this, pSlider, tokMinLabel, tokMaxLabel);
}

