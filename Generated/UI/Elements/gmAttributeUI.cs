namespace ACBindings.Internal;

public unsafe struct gmAttributeUI
{
    // Base Classes
    public ACBindings.Internal.gmStatManagementUI BaseClass_gmStatManagementUI; // ACBindings.Internal.gmStatManagementUI

    // Child Types
    public unsafe struct gmAttributeUI_vtbl
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
        public fixed byte gap138[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> Update; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, byte> UpdateCharacterInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, byte> UpdatePKStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, byte> UpdateExperience; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.UIElement*, byte> SetSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> UpdateSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> RaiseSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> Raise10Selection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, uint> GetCostToRaise; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.StatType, uint, byte> MessageIsFromSelectedElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmAttributeUI*, ACBindings.Internal.CACQualities*, uint> GetCostToRaise10; // function pointer

        // Methods
    }

    // Members
    public int m_SelectedIndex;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0049CC40
    /// UIElement* __thiscall gmAttributeUI::DynamicCast(gmAttributeUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, uint, ACBindings.Internal.UIElement*>)0x0049CC40)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x0049CC60
    /// unsigned int __thiscall gmAttributeUI::GetUIElementType(gmAttributeUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, uint>)0x0049CC60)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049CC70
    /// UIElement* __cdecl gmAttributeUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0049CC70)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0049CD10
    /// void __cdecl gmAttributeUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0049CD10)();

    /// <summary>
    /// <code>Offset: 0x0049CD30
    /// bool __thiscall gmAttributeUI::SetSelection(gmAttributeUI*,UIElement*)</code>
    /// </summary>
    public byte SetSelection(ACBindings.Internal.UIElement* selectedUI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, ACBindings.Internal.UIElement*, byte>)0x0049CD30)(ref this, selectedUI);

    /// <summary>
    /// <code>Offset: 0x0049CDF0
    /// unsigned int __thiscall gmAttributeUI::GetCostToRaise(gmAttributeUI*,const CACQualities*)</code>
    /// </summary>
    public uint GetCostToRaise(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, ACBindings.Internal.CACQualities*, uint>)0x0049CDF0)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x0049CEE0
    /// unsigned int __thiscall gmAttributeUI::GetCostToRaise10(gmAttributeUI*,const CACQualities*)</code>
    /// </summary>
    public uint GetCostToRaise10(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, ACBindings.Internal.CACQualities*, uint>)0x0049CEE0)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x0049D000
    /// bool __thiscall gmAttributeUI::MessageIsFromSelectedElement(gmAttributeUI*,StatType,unsigned int)</code>
    /// </summary>
    public byte MessageIsFromSelectedElement(ACBindings.Internal.StatType i_statType, uint i_statEnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, ACBindings.Internal.StatType, uint, byte>)0x0049D000)(ref this, i_statType, i_statEnum);

    /// <summary>
    /// <code>Offset: 0x0049D050
    /// bool __thiscall gmAttributeUI::DisplayDefaultFooter(gmAttributeUI*,const CACQualities*)</code>
    /// </summary>
    public byte DisplayDefaultFooter(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, ACBindings.Internal.CACQualities*, byte>)0x0049D050)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x0049D290
    /// bool __thiscall gmAttributeUI::RaiseSelection(gmAttributeUI*)</code>
    /// </summary>
    public byte RaiseSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, byte>)0x0049D290)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049D3C0
    /// bool __thiscall gmAttributeUI::Raise10Selection(gmAttributeUI*)</code>
    /// </summary>
    public byte Raise10Selection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, byte>)0x0049D3C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049D4F0
    /// bool __thiscall gmAttributeUI::DisplaySelectionFooter_Attribute(gmAttributeUI*,const CACQualities*)</code>
    /// </summary>
    public byte DisplaySelectionFooter_Attribute(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, ACBindings.Internal.CACQualities*, byte>)0x0049D4F0)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x0049D920
    /// bool __thiscall gmAttributeUI::DisplaySelectionFooter_Vital(gmAttributeUI*,const CACQualities*)</code>
    /// </summary>
    public byte DisplaySelectionFooter_Vital(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, ACBindings.Internal.CACQualities*, byte>)0x0049D920)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x0049DDE0
    /// void __thiscall gmAttributeUI::PostInit(gmAttributeUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, void>)0x0049DDE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049E150
    /// bool __thiscall gmAttributeUI::UpdateSelection(gmAttributeUI*)</code>
    /// </summary>
    public byte UpdateSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, byte>)0x0049E150)(ref this);
}

