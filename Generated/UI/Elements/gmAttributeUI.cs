namespace ACBindings.Internal;


/// <summary>Holds base UI logic for attribute management and tracks the currently selected attribute token index.</summary>
public unsafe struct gmAttributeUI
{
    // Base Classes
    public ACBindings.Internal.gmStatManagementUI BaseClass_gmStatManagementUI; // ACBindings.Internal.gmStatManagementUI

    // Child Types
    public unsafe struct gmAttributeUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*> GetSurfaceBox; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> HasCursor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawStart; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> EraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawDone; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> SetState; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetParent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> GetAncestorByID; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> Initialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> PostInit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, ACBindings.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement**, byte> DragItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> MatchElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Activate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Deactivate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> TakeFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetActivatable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject*, byte> SetUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer
        public fixed byte gap138[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> Update; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, byte> UpdateCharacterInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, byte> UpdatePKStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, byte> UpdateExperience; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.UIElement*, byte> SetSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> UpdateSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> RaiseSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> Raise10Selection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, uint> GetCostToRaise; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.StatType, uint, byte> MessageIsFromSelectedElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmAttributeUI*, ACBindings.Internal.CACQualities*, uint> GetCostToRaise10; // function pointer

        // Methods
    }

    // Members
    public int m_SelectedIndex;

    // Methods

    /// <summary>Returns a pointer to the UIElement part of this gmAttributeUI instance when the requested type id matches known UI element types; otherwise returns null.
    /// <code>Offset: 0x0049CC40
    /// UIElement* __thiscall gmAttributeUI::DynamicCast(gmAttributeUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The identifier of the desired component type.</param>
    /// <returns>A UIElement* pointing to the matching subobject, or nullptr if no match is found.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, uint, ACBindings.Internal.UIElement*>)0x0049CC40)(ref this, i_eType);

    /// <summary>Returns the numeric identifier representing the UI element type.
    /// <code>Offset: 0x0049CC60
    /// unsigned int __thiscall gmAttributeUI::GetUIElementType(gmAttributeUI*)</code>
    /// </summary>
    /// <returns>The constant UI element type ID 268435498 for gmAttributeUI instances.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, uint>)0x0049CC60)(ref this);

    /// <summary>Create a new attribute UI element from the provided layout and element descriptors, allocating a gmStatManagementUI instance and initializing its base UIElement hierarchy.
    /// <code>Offset: 0x0049CC70
    /// UIElement* __cdecl gmAttributeUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor specifying display dimensions and element mappings used to configure the UI.</param>
    /// <param name="full_desc">Full element description providing state information and geometry for the attribute component.</param>
    /// <returns>Pointer to the constructed UIElement, or null if memory allocation fails. The caller owns the returned object and is responsible for its lifetime.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0049CC70)(layout, full_desc);

    /// <summary>Registers the gmAttributeUI element class with the UI system for dynamic instantiation.
    /// <code>Offset: 0x0049CD10
    /// void __cdecl gmAttributeUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0049CD10)();

    /// <summary>Sets or clears the currently selected attribute UI element based on the supplied UI element.
    /// <code>Offset: 0x0049CD30
    /// bool __thiscall gmAttributeUI::SetSelection(gmAttributeUI*,UIElement*)</code>
    /// </summary>
    /// <param name="selectedUI">The UI element to select, or null to clear the current selection.</param>
    /// <returns>A boolean indicating whether the underlying base class operation succeeded.</returns>
    public byte SetSelection(ACBindings.Internal.UIElement* selectedUI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, ACBindings.Internal.UIElement*, byte>)0x0049CD30)(ref this, selectedUI);

    /// <summary>
    /// Calculates the experience points needed to raise the currently selected attribute by one level, taking into account current progress and maximum allowed levels.
    /// 
    /// <code>Offset: 0x0049CDF0
    /// unsigned int __thiscall gmAttributeUI::GetCostToRaise(gmAttributeUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player quality descriptor containing current attribute values used in the calculation.</param>
    /// <returns>Number of experience points required; zero if the attribute is already at its maximum level or cannot be raised further.</returns>
    public uint GetCostToRaise(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, ACBindings.Internal.CACQualities*, uint>)0x0049CDF0)(ref this, i_playerDesc);

    /// <summary>Calculates the character point cost required to raise the currently selected attribute by up to ten levels, respecting maximum limits for main or secondary attributes.
    /// <code>Offset: 0x0049CEE0
    /// unsigned int __thiscall gmAttributeUI::GetCostToRaise10(gmAttributeUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player qualities used to determine the current level and spent points of the chosen attribute.</param>
    /// <returns>The CP needed to increase the attribute; returns 0 if the attribute is already at its maximum level or no additional cost applies.</returns>
    public uint GetCostToRaise10(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, ACBindings.Internal.CACQualities*, uint>)0x0049CEE0)(ref this, i_playerDesc);

    /// <summary>Verifies whether the currently selected attribute token in the UI corresponds to a specific stat type and enumeration value.
    /// <code>Offset: 0x0049D000
    /// bool __thiscall gmAttributeUI::MessageIsFromSelectedElement(gmAttributeUI*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="i_statType">The stat type to compare against the token's quality removed event.</param>
    /// <param name="i_statEnum">The enumeration value to compare against the token's quality changed event.</param>
    /// <returns>True if both the stat type and enum match the selected element; otherwise false.</returns>
    public byte MessageIsFromSelectedElement(ACBindings.Internal.StatType i_statType, uint i_statEnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, ACBindings.Internal.StatType, uint, byte>)0x0049D000)(ref this, i_statType, i_statEnum);

    /// <summary>Displays the default attribute footer in the stat management UI by setting the title, skill credits, and experience labels and values based on the supplied player qualities.
    /// <code>Offset: 0x0049D050
    /// bool __thiscall gmAttributeUI::DisplayDefaultFooter(gmAttributeUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player quality data used to obtain skill credits and available experience for display.</param>
    /// <returns>Always true, indicating the footer was updated successfully.</returns>
    public byte DisplayDefaultFooter(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, ACBindings.Internal.CACQualities*, byte>)0x0049D050)(ref this, i_playerDesc);

    /// <summary>Raises the currently selected attribute token for the player, applying training logic and updating UI state.
    /// <code>Offset: 0x0049D290
    /// bool __thiscall gmAttributeUI::RaiseSelection(gmAttributeUI*)</code>
    /// </summary>
    /// <returns>True if a valid selection was processed and the raise succeeded; otherwise false.</returns>
    public byte RaiseSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, byte>)0x0049D290)(ref this);

    /// <summary>Raises the currently selected attribute by ten levels using available XP, returning whether the operation succeeded.
    /// <code>Offset: 0x0049D3C0
    /// bool __thiscall gmAttributeUI::Raise10Selection(gmAttributeUI*)</code>
    /// </summary>
    /// <returns>True when the attribute was raised; false if no selection or insufficient XP.</returns>
    public byte Raise10Selection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, byte>)0x0049D3C0)(ref this);

    /// <summary>Updates the attribute selection footer UI elements based on the player's current qualities, including title, line values, and button states.
    /// <code>Offset: 0x0049D4F0
    /// bool __thiscall gmAttributeUI::DisplaySelectionFooter_Attribute(gmAttributeUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player qualities providing current attribute data.</param>
    /// <returns>True when the footer was refreshed successfully (always true).</returns>
    public byte DisplaySelectionFooter_Attribute(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, ACBindings.Internal.CACQualities*, byte>)0x0049D4F0)(ref this, i_playerDesc);

    /// <summary>Updates the attribute selection footer with vital information for the currently selected attribute, including title, level progress, experience remaining and button states based on available experience.
    /// <code>Offset: 0x0049D920
    /// bool __thiscall gmAttributeUI::DisplaySelectionFooter_Vital(gmAttributeUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player's quality description used to query attribute values and experience data.</param>
    /// <returns>True, indicating the UI was successfully updated.</returns>
    public byte DisplaySelectionFooter_Vital(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, ACBindings.Internal.CACQualities*, byte>)0x0049D920)(ref this, i_playerDesc);

    /// <summary>Initializes the attribute UI component by creating a set of token buttons and secondary info regions linked to the list box once the base stat management UI has been initialized. This setup occurs only when no tokens are currently present.
    /// <code>Offset: 0x0049DDE0
    /// void __thiscall gmAttributeUI::PostInit(gmAttributeUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, void>)0x0049DDE0)(ref this);

    /// <summary>
    /// Updates the attribute UI selection by resetting token states, retrieving the current player descriptor, and updating the footer text to reflect either a default state or the details of the selected item.
    /// 
    /// <code>Offset: 0x0049E150
    /// bool __thiscall gmAttributeUI::UpdateSelection(gmAttributeUI*)</code>
    /// </summary>
    /// <returns>True if the operation succeeded; false otherwise.</returns>
    public byte UpdateSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAttributeUI, byte>)0x0049E150)(ref this);
}

