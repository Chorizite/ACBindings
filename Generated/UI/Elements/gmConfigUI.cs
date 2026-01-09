namespace ACBindings;

// gmConfigUI
public unsafe struct gmConfigUI : System.IDisposable
{
    // Base Classes
    public ACBindings.PlayerOptionPage BaseClass_PlayerOptionPage; // ACBindings.PlayerOptionPage
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmConfigUI_vtbl
    public unsafe struct gmConfigUI_vtbl
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

    // Members
    public ACBindings.UIOption_Slider* m_pStiffness;
    public ACBindings.UIOption_Slider* m_pAdjustmentSpeed;
    public ACBindings.UIOption_Slider* m_pSensitivity;
    public ACBindings.UIOption_Checkbox* m_pSlope;
    public ACBindings.UIOption_Checkbox* m_pInvert;
    public ACBindings.UIOption_Checkbox* m_pMouseTurn;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // UIElement* __thiscall gmConfigUI::DynamicCast(gmConfigUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmConfigUI, uint, ACBindings.UIElement*>)0x0049E540)(ref this, i_eType);
    // unsigned int __thiscall gmConfigUI::GetUIElementType(gmConfigUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmConfigUI, uint>)0x0049E560)(ref this);
    // void __thiscall gmConfigUI::~gmConfigUI(gmConfigUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmConfigUI, void>)0x0049E570)(ref this);
    // void __thiscall gmConfigUI::InitOptions(gmConfigUI*)
    public void InitOptions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmConfigUI, void>)0x0049E680)(ref this);
    // void __thiscall gmConfigUI::PostInit(gmConfigUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmConfigUI, void>)0x0049EAC0)(ref this);
    // void __cdecl gmConfigUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0049EB50)();
    // void __thiscall gmConfigUI::SetMouseTurningDefaults(gmConfigUI*)
    public void SetMouseTurningDefaults() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmConfigUI, void>)0x0049EB70)(ref this);
    // void __thiscall gmConfigUI::ListenToGlobalMessage(gmConfigUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmConfigUI, uint, int, void>)0x0049EE10)(ref this, i_messageID, i_data_int);
    // void __stdcall gmConfigUI::RecvNotice_UserPreferenceChanged_Menu(const char**,int,int)
    public static void RecvNotice_UserPreferenceChanged_Menu(sbyte** a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<sbyte**, int, int, void>)0x0049EE20)(a1, a2, a3);
}

