namespace ACBindings;

// gmFloatyIndicatorsUI
public unsafe struct gmFloatyIndicatorsUI
{
    // Base Classes
    public ACBindings.gmIndicatorsUI BaseClass_gmIndicatorsUI; // ACBindings.gmIndicatorsUI

    // Child Types
    // gmFloatyIndicatorsUI_vtbl
    public unsafe struct gmFloatyIndicatorsUI_vtbl
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
    // UIElement* __thiscall gmFloatyIndicatorsUI::DynamicCast(gmFloatyIndicatorsUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyIndicatorsUI, uint, ACBindings.UIElement*>)0x004D3B80)(ref this, i_eType);
    // UIElementMessageListenResult __thiscall gmFloatyIndicatorsUI::ListenToElementMessage(gmFloatyIndicatorsUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyIndicatorsUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004D3BF0)(ref this, i_rMsg);
    // void __thiscall gmFloatyIndicatorsUI::UpdateLockedStatus(gmFloatyIndicatorsUI*)
    public void UpdateLockedStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyIndicatorsUI, void>)0x004D3C20)(ref this);
    // void __cdecl gmFloatyIndicatorsUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004D3E20)();
    // void __thiscall gmFloatyIndicatorsUI::PostInit(gmFloatyIndicatorsUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyIndicatorsUI, void>)0x004D3E40)(ref this);
    // void __thiscall gmFloatyIndicatorsUI::UpdateFromPlayerModule(gmFloatyIndicatorsUI*)
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyIndicatorsUI, void>)0x004D4120)(ref this);
    // void __thiscall gmFloatyIndicatorsUI::ResizeTo(gmFloatyIndicatorsUI*,const int,const int)
    public void ResizeTo(int i_width, int i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyIndicatorsUI, int, int, void>)0x004D4380)(ref this, i_width, i_height);
    // void __thiscall gmFloatyIndicatorsUI::MoveTo(gmFloatyIndicatorsUI*,const int,const int)
    public void MoveTo(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyIndicatorsUI, int, int, void>)0x004D44F0)(ref this, i_x, i_y);
    // void __thiscall gmFloatyIndicatorsUI::SetVisible(gmFloatyIndicatorsUI*,bool)
    public void SetVisible(byte i_fVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyIndicatorsUI, byte, void>)0x004D46F0)(ref this, i_fVisible);
}

