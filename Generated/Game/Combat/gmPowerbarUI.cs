namespace ACBindings;

// gmPowerbarUI
public unsafe struct gmPowerbarUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmPowerbarUI_vtbl
    public unsafe struct gmPowerbarUI_vtbl
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
    public ACBindings.PowerBarMode m_pbmCurrentMode;
    public ACBindings.UIElement_Field* m_RecklessnessField;

    // Generated Constructor
    public gmPowerbarUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmPowerbarUI::gmPowerbarUI(gmPowerbarUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPowerbarUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004DB000)(ref this, layout, full_desc);
    // UIElement* __thiscall gmPowerbarUI::DynamicCast(gmPowerbarUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPowerbarUI, uint, ACBindings.UIElement*>)0x004DB040)(ref this, i_eType);
    // unsigned int __thiscall gmPowerbarUI::GetUIElementType(gmPowerbarUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPowerbarUI, uint>)0x004DB060)(ref this);
    // void __thiscall gmPowerbarUI::~gmPowerbarUI(gmPowerbarUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPowerbarUI, void>)0x004DB070)(ref this);
    // UIElement* __cdecl gmPowerbarUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004DB0A0)(layout, full_desc);
    // void __thiscall gmPowerbarUI::PostInit(gmPowerbarUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPowerbarUI, void>)0x004DB140)(ref this);
    // void __cdecl gmPowerbarUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004DB190)();
    // void __thiscall gmPowerbarUI::RecvNotice_SetPowerbarLevel(gmPowerbarUI*,PowerBarMode,float)
    public void RecvNotice_SetPowerbarLevel(ACBindings.PowerBarMode i_pbm, float i_fLevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPowerbarUI, ACBindings.PowerBarMode, float, void>)0x004DB1B0)(ref this, i_pbm, i_fLevel);
    // void __thiscall gmPowerbarUI::RecvNotice_FinishPowerbar(gmPowerbarUI*,PowerBarMode)
    public void RecvNotice_FinishPowerbar(ACBindings.PowerBarMode i_pbm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPowerbarUI, ACBindings.PowerBarMode, void>)0x004DB1E0)(ref this, i_pbm);
    // void __thiscall gmPowerbarUI::RecvNotice_RuntimeDDDStatus(gmPowerbarUI*,bool,unsigned int,unsigned int)
    public void RecvNotice_RuntimeDDDStatus(byte bStart, uint current, uint total) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPowerbarUI, byte, uint, uint, void>)0x004DB220)(ref this, bStart, current, total);
    // void __thiscall gmPowerbarUI::RecvNotice_BeginPowerbar(gmPowerbarUI*,PowerBarMode)
    public void RecvNotice_BeginPowerbar(ACBindings.PowerBarMode pbm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPowerbarUI, ACBindings.PowerBarMode, void>)0x004DB390)(ref this, pbm);
}

