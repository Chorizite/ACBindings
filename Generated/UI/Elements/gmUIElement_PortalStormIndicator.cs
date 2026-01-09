namespace ACBindings;

// gmUIElement_PortalStormIndicator
public unsafe struct gmUIElement_PortalStormIndicator : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Button BaseClass_UIElement_Button; // ACBindings.UIElement_Button
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmUIElement_PortalStormIndicator_vtbl
    public unsafe struct gmUIElement_PortalStormIndicator_vtbl
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
        public System.IntPtr AdjustToScrollableXYChange; // function pointer
        public System.IntPtr InqScrollDelta; // function pointer

        // Methods
    }

    // Members
    public double m_ttLastPortalStormWarningTime;

    // Generated Constructor
    public gmUIElement_PortalStormIndicator(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmUIElement_PortalStormIndicator::gmUIElement_PortalStormIndicator(gmUIElement_PortalStormIndicator*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_PortalStormIndicator, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004E6D90)(ref this, layout, full_desc);
    // UIElement* __thiscall gmUIElement_PortalStormIndicator::DynamicCast(gmUIElement_PortalStormIndicator*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_PortalStormIndicator, uint, ACBindings.UIElement*>)0x004E6DE0)(ref this, i_eType);
    // unsigned int __thiscall gmUIElement_PortalStormIndicator::GetUIElementType(CSpellTable*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_PortalStormIndicator, uint>)0x004E6E10)(ref this);
    // void __thiscall gmUIElement_PortalStormIndicator::PostInit(gmUIElement_PortalStormIndicator*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_PortalStormIndicator, void>)0x004E6E20)(ref this);
    // void __thiscall gmUIElement_PortalStormIndicator::~gmUIElement_PortalStormIndicator(gmUIElement_PortalStormIndicator*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_PortalStormIndicator, void>)0x004E6E60)(ref this);
    // void __thiscall gmUIElement_PortalStormIndicator::Update(gmUIElement_PortalStormIndicator*,float)
    public void Update(float i_fExtent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_PortalStormIndicator, float, void>)0x004E6EE0)(ref this, i_fExtent);
    // void __cdecl gmUIElement_PortalStormIndicator::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004E6F70)();
    // void __thiscall gmUIElement_PortalStormIndicator::ListenToGlobalMessage(gmUIElement_PortalStormIndicator*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_PortalStormIndicator, uint, int, void>)0x004E6F90)(ref this, i_messageID, i_data_int);
    // void __thiscall gmUIElement_PortalStormIndicator::RecvNotice_PortalStormLevel(gmUIElement_PortalStormIndicator*,float)
    public void RecvNotice_PortalStormLevel(float i_fExtent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIElement_PortalStormIndicator, float, void>)0x004E6FD0)(ref this, i_fExtent);
}

