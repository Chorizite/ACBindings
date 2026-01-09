namespace ACBindings;

// gmFloatyExaminationUI
public unsafe struct gmFloatyExaminationUI
{
    // Base Classes
    public ACBindings.gmExaminationUI BaseClass_gmExaminationUI; // ACBindings.gmExaminationUI

    // Child Types
    // gmFloatyExaminationUI_vtbl
    public unsafe struct gmFloatyExaminationUI_vtbl
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
    // UIElement* __thiscall gmFloatyExaminationUI::DynamicCast(gmFloatyExaminationUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyExaminationUI, uint, ACBindings.UIElement*>)0x004D4880)(ref this, i_eType);
    // UIElementMessageListenResult __thiscall gmFloatyExaminationUI::ListenToElementMessage(gmFloatyExaminationUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyExaminationUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004D48F0)(ref this, i_rMsg);
    // void __thiscall gmFloatyExaminationUI::UpdateLockedStatus(gmFloatyExaminationUI*)
    public void UpdateLockedStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyExaminationUI, void>)0x004D4930)(ref this);
    // void __cdecl gmFloatyExaminationUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004D4B30)();
    // void __thiscall gmFloatyExaminationUI::PostInit(gmFloatyExaminationUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyExaminationUI, void>)0x004D4B50)(ref this);
    // void __thiscall gmFloatyExaminationUI::UpdateFromPlayerModule(gmFloatyExaminationUI*)
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyExaminationUI, void>)0x004D4E80)(ref this);
    // void __thiscall gmFloatyExaminationUI::ResizeTo(gmFloatyExaminationUI*,const int,const int)
    public void ResizeTo(int i_width, int i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyExaminationUI, int, int, void>)0x004D50A0)(ref this, i_width, i_height);
    // void __thiscall gmFloatyExaminationUI::MoveTo(gmFloatyExaminationUI*,const int,const int)
    public void MoveTo(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyExaminationUI, int, int, void>)0x004D5210)(ref this, i_x, i_y);
}

