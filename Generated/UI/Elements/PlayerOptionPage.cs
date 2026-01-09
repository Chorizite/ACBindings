namespace ACBindings;

// PlayerOptionPage
public unsafe struct PlayerOptionPage : System.IDisposable
{
    // Base Classes
    public ACBindings.OptionPage BaseClass_OptionPage; // ACBindings.OptionPage

    // Child Types
    // PlayerOptionPage_vtbl
    public unsafe struct PlayerOptionPage_vtbl
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
    public ACBindings.UIElement_ListBox* m_pOptionBox;

    // Generated Constructor
    public PlayerOptionPage(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall PlayerOptionPage::PlayerOptionPage(PlayerOptionPage*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerOptionPage, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004F32E0)(ref this, layout, full_desc);
    // void __thiscall PlayerOptionPage::~PlayerOptionPage(PlayerOptionPage*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerOptionPage, void>)0x004F3320)(ref this);
    // void __thiscall PlayerOptionPage::OnVisibilityChanged(PlayerOptionPage*,bool)
    public void OnVisibilityChanged(byte i_bVisibleNow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerOptionPage, byte, void>)0x004F3340)(ref this, i_bVisibleNow);
    // bool __thiscall PlayerOptionPage::SaveCurrentValues(PlayerOptionPage*)
    public byte SaveCurrentValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerOptionPage, byte>)0x004F3370)(ref this);
    // bool __thiscall PlayerOptionPage::AddSeperator(PlayerOptionPage*)
    public byte AddSeperator() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerOptionPage, byte>)0x004F3390)(ref this);
    // void __thiscall PlayerOptionPage::SetToggleLabel(PlayerOptionPage*,UIOption_Checkbox*,unsigned int,unsigned int)
    public void SetToggleLabel(ACBindings.UIOption_Checkbox* pToggle, uint tokLabel, uint tokTooltip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerOptionPage, ACBindings.UIOption_Checkbox*, uint, uint, void>)0x004F33B0)(ref this, pToggle, tokLabel, tokTooltip);
    // void __thiscall PlayerOptionPage::OnOptionChanged(PlayerOptionPage*,const UIOption*)
    public void OnOptionChanged(ACBindings.UIOption* pOption) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerOptionPage, ACBindings.UIOption*, void>)0x004F3430)(ref this, pOption);
    // void __thiscall PlayerOptionPage::OnOptionChangeConfirmed(PlayerOptionPage*,const UIOption*,bool)
    public void OnOptionChangeConfirmed(ACBindings.UIOption* pOption, byte bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerOptionPage, ACBindings.UIOption*, byte, void>)0x004F34B0)(ref this, pOption, bConfirm);
    // bool __thiscall PlayerOptionPage::AddHeader(PlayerOptionPage*,unsigned int)
    public byte AddHeader(uint st) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerOptionPage, uint, byte>)0x004F3510)(ref this, st);
    // UIOption* __thiscall PlayerOptionPage::AddToggleWithSliderOption(OptionPage*,int*,char**)
    public ACBindings.UIOption* AddToggleWithSliderOption(int* a2, sbyte** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerOptionPage, int*, sbyte**, ACBindings.UIOption*>)0x004F3590)(ref this, a2, a3);
    // UIOption* __thiscall PlayerOptionPage::AddToggleOption(OptionPage*,int*)
    public ACBindings.UIOption* AddToggleOption(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerOptionPage, int*, ACBindings.UIOption*>)0x004F35F0)(ref this, a2);
    // UIOption_Checkbox* __thiscall PlayerOptionPage::AddToggleOption(PlayerOptionPage*,PlayerOption)
    public ACBindings.UIOption_Checkbox* AddToggleOption(ACBindings.PlayerOption po) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerOptionPage, ACBindings.PlayerOption, ACBindings.UIOption_Checkbox*>)0x004F3660)(ref this, po);
    // UIOption* __thiscall PlayerOptionPage::AddSliderOption(OptionPage*,char**,char)
    public ACBindings.UIOption* AddSliderOption(sbyte** a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerOptionPage, sbyte**, sbyte, ACBindings.UIOption*>)0x004F36D0)(ref this, a2, a3);
    // UIOption* __thiscall PlayerOptionPage::AddMenuOption(OptionPage*,bool (__cdecl**a2)(),char)
    public ACBindings.UIOption* AddMenuOption(delegate* unmanaged[Cdecl]<byte>* a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerOptionPage, delegate* unmanaged[Cdecl]<byte>*, sbyte, ACBindings.UIOption*>)0x004F3750)(ref this, a2, a3);
    // void __thiscall PlayerOptionPage::SetSliderLabel(PlayerOptionPage*,UIOption_Slider*,unsigned int,unsigned int)
    public void SetSliderLabel(ACBindings.UIOption_Slider* pSlider, uint tokMinLabel, uint tokMaxLabel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerOptionPage, ACBindings.UIOption_Slider*, uint, uint, void>)0x004F37E0)(ref this, pSlider, tokMinLabel, tokMaxLabel);
}

