namespace ACBindings;

// UIElement_Viewport
public unsafe struct UIElement_Viewport
{
    // Base Classes
    public ACBindings.UIElement BaseClass_UIElement; // ACBindings.UIElement
    public ACBindings.CreatureMode BaseClass_CreatureMode; // ACBindings.CreatureMode

    // Child Types
    // UIElement_Viewport_vtbl
    public unsafe struct UIElement_Viewport_vtbl
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

    // Methods
    // UIElement* __thiscall UIElement_Viewport::DynamicCast(UIElement_Viewport*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Viewport, uint, ACBindings.UIElement*>)0x0046BD20)(ref this, i_eType);
    // UIElement* __cdecl UIElement_Viewport::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0046BD40)(layout, full_desc);
    // void __thiscall UIElement_Viewport::OnSetAttribute(UIElement_Viewport*,const BaseProperty*)
    public void OnSetAttribute(ACBindings.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Viewport, ACBindings.BaseProperty*, void>)0x0046BD80)(ref this, attribute);
    // bool __thiscall UIElement_Viewport::MakeUIObject(UIElement_Viewport*,UIObject**)
    public byte MakeUIObject(ACBindings.UIObject** o_pcUIObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Viewport, ACBindings.UIObject**, byte>)0x0046BDA0)(ref this, o_pcUIObject);
    // void __thiscall UIElement_Viewport::PostInit(UIElement_Viewport*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Viewport, void>)0x0046BDF0)(ref this);
    // void __thiscall UIElement_Viewport::SetCamera(UIElement_Viewport*,const Vector3*,const Vector3*)
    public void SetCamera(ACBindings.Vector3* position, ACBindings.Vector3* direction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Viewport, ACBindings.Vector3*, ACBindings.Vector3*, void>)0x0046BE10)(ref this, position, direction);
    // void __thiscall UIElement_Viewport::SetLight(UIElement_Viewport*,LIGHTINFO::LightType,float,const Vector3*)
    public void SetLight(ACBindings.LIGHTINFO.LightType lightType, float intensity, ACBindings.Vector3* direction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Viewport, ACBindings.LIGHTINFO.LightType, float, ACBindings.Vector3*, void>)0x0046BE40)(ref this, lightType, intensity, direction);
    // bool __thiscall UIElement_Viewport::InqAvailableProperties(UIElement_Viewport*,AvailablePropertySet*)
    public byte InqAvailableProperties(ACBindings.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Viewport, ACBindings.AvailablePropertySet*, byte>)0x0046BED0)(ref this, set);
}

