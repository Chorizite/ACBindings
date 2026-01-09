namespace ACBindings;

// gmFloatyPowerBarUI
public unsafe struct gmFloatyPowerBarUI
{
    // Base Classes
    public ACBindings.gmPowerbarUI BaseClass_gmPowerbarUI; // ACBindings.gmPowerbarUI

    // Child Types
    // gmFloatyPowerBarUI_vtbl
    public unsafe struct gmFloatyPowerBarUI_vtbl
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
        public System.IntPtr UpdateFromPlayerModule; // function pointer

        // Methods
    }

    // Members
    public uint m_eWindowID;
    public ACBindings.UIElement* m_pTopBorder;
    public ACBindings.UIElement* m_pLeftBorder;
    public ACBindings.UIElement* m_pBottomBorder;
    public ACBindings.UIElement* m_pRightBorder;
    public ACBindings.UIElement* m_pTopLeftCorner;
    public ACBindings.UIElement* m_pTopRightCorner;
    public ACBindings.UIElement* m_pBottomLeftCorner;
    public ACBindings.UIElement* m_pBottomRightCorner;
    public ACBindings.UIElement* m_pTopBorder_Locked;
    public ACBindings.UIElement* m_pLeftBorder_Locked;
    public ACBindings.UIElement* m_pBottomBorder_Locked;
    public ACBindings.UIElement* m_pRightBorder_Locked;
    public ACBindings.UIElement* m_pTopLeftCorner_Locked;
    public ACBindings.UIElement* m_pTopRightCorner_Locked;
    public ACBindings.UIElement* m_pBottomLeftCorner_Locked;
    public ACBindings.UIElement* m_pBottomRightCorner_Locked;

    // Methods
    // UIElement* __thiscall gmFloatyPowerBarUI::DynamicCast(gmFloatyPowerBarUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyPowerBarUI, uint, ACBindings.UIElement*>)0x004D1AA0)(ref this, i_eType);
    // void __thiscall gmFloatyPowerBarUI::UpdateLockedStatus(gmFloatyPowerBarUI*)
    public void UpdateLockedStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyPowerBarUI, void>)0x004D1B10)(ref this);
    // void __cdecl gmFloatyPowerBarUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004D1D10)();
    // void __thiscall gmFloatyPowerBarUI::PostInit(gmFloatyPowerBarUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyPowerBarUI, void>)0x004D1D30)(ref this);
    // void __thiscall gmFloatyPowerBarUI::ListenToGlobalMessage(gmFloatyPowerBarUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyPowerBarUI, uint, int, void>)0x004D2020)(ref this, i_messageID, i_data_int);
    // void __thiscall gmFloatyPowerBarUI::UpdateFromPlayerModule(gmFloatyPowerBarUI*)
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyPowerBarUI, void>)0x004D2030)(ref this);
    // void __thiscall gmFloatyPowerBarUI::ResizeTo(gmFloatyPowerBarUI*,const int,const int)
    public void ResizeTo(int i_width, int i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyPowerBarUI, int, int, void>)0x004D2290)(ref this, i_width, i_height);
    // void __thiscall gmFloatyPowerBarUI::MoveTo(gmFloatyPowerBarUI*,const int,const int)
    public void MoveTo(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyPowerBarUI, int, int, void>)0x004D2400)(ref this, i_x, i_y);
    // void __thiscall gmFloatyPowerBarUI::SetVisible(gmFloatyPowerBarUI*,bool)
    public void SetVisible(byte i_fVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyPowerBarUI, byte, void>)0x004D2600)(ref this, i_fVisible);
    // void __thiscall gmFloatyPowerBarUI::RecvNotice_PlayerDescReceived(gmFloatyPowerBarUI*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyPowerBarUI, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x004D71A0)(ref this, i_playerDesc, i_playerModule);
}

