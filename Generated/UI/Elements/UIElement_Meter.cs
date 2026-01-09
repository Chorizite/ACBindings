namespace ACBindings;

// UIElement_Meter
public unsafe struct UIElement_Meter
{
    // Base Classes
    public ACBindings.UIElement BaseClass_UIElement; // ACBindings.UIElement

    // Child Types
    // UIElement_Meter_vtbl
    public unsafe struct UIElement_Meter_vtbl
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
    public byte m_framemeter;
    public byte m_animating;
    public double m_animStartTime;
    public double m_animEndTime;
    public float m_anim_start_pos;
    public float m_anim_end_pos;
    public int m_currentFrame;
    public float m_fOldPosition;
    public ACBindings.UIElement* m_pcChildImage;
    public uint m_eDirection;

    // Generated Constructor
    public UIElement_Meter(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods
    // void __thiscall UIElement_Meter::UIElement_Meter(UIElement_Meter*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Meter, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x0046F880)(ref this, layout, full_desc);
    // UIElement* __thiscall UIElement_Meter::DynamicCast(UIElement_Meter*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Meter, uint, ACBindings.UIElement*>)0x0046F900)(ref this, i_eType);
    // UIElement* __cdecl UIElement_Meter::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0046F920)(layout, full_desc);
    // void __thiscall UIElement_Meter::RemoveChild(UIElement_Meter*,UIRegion*)
    public void RemoveChild(ACBindings.UIRegion* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Meter, ACBindings.UIRegion*, void>)0x0046F950)(ref this, child);
    // void __thiscall UIElement_Meter::StartAnimation(UIElement_Meter*)
    public void StartAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Meter, void>)0x0046F980)(ref this);
    // void __thiscall UIElement_Meter::UpdateChild(UIElement_Meter*)
    public void UpdateChild() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Meter, void>)0x0046FA20)(ref this);
    // void __thiscall UIElement_Meter::Initialize(UIElement_Meter*)
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Meter, void>)0x0046FB70)(ref this);
    // void __thiscall UIElement_Meter::ListenToGlobalMessage(UIElement_Meter*,unsigned int,int)
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Meter, uint, int, void>)0x0046FC30)(ref this, messageID, data_int);
    // bool __thiscall UIElement_Meter::InqAvailableProperties(UIElement_Meter*,AvailablePropertySet*)
    public byte InqAvailableProperties(ACBindings.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Meter, ACBindings.AvailablePropertySet*, byte>)0x0046FCB0)(ref this, set);
    // void __thiscall UIElement_Meter::UpdateFrame(UIElement_Meter*)
    public void UpdateFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Meter, void>)0x0046FD00)(ref this);
    // int __thiscall UIElement_Meter::DrawChildren(UIElement*,_DWORD*,Box2D*,int,int)
    public int DrawChildren(int* a2, ACBindings.Box2D* a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Meter, int*, ACBindings.Box2D*, int, int, int>)0x0046FF90)(ref this, a2, a3, a4, a5);
    // void __thiscall UIElement_Meter::OnSetAttribute(UIElement_Meter*,const BaseProperty*)
    public void OnSetAttribute(ACBindings.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Meter, ACBindings.BaseProperty*, void>)0x00470230)(ref this, attribute);
    // void __thiscall UIElement_Meter::ResizeTo(UIElement_Meter*,const int,const int)
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Meter, int, int, void>)0x00470370)(ref this, width, height);
}

