namespace ACBindings.Internal;


/// <summary>Paper‑doll interface that manages item slots, handles drag‑and‑drop equip operations, updates lighting for selected body parts, and maintains a click‑map surface for hit testing.</summary>
/// <remarks>Encapsulates UI elements for each equipment slot, a physics object rendering the character model, and logic to synchronize with the player's inventory state. Provides animation control and global message handling for target mode and quality changes.</remarks>
public unsafe struct gmPaperDollUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler
    public ACBindings.Internal.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.Internal.ItemListDragHandler

    // Child Types
    public unsafe struct gmPaperDollUI_vtbl
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

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_ItemList* m_neckSlot;
    public ACBindings.Internal.UIElement_ItemList* m_leftWristSlot;
    public ACBindings.Internal.UIElement_ItemList* m_leftRingSlot;
    public ACBindings.Internal.UIElement_ItemList* m_rightWristSlot;
    public ACBindings.Internal.UIElement_ItemList* m_rightRingSlot;
    public ACBindings.Internal.UIElement_ItemList* m_weaponReadySlot;
    public ACBindings.Internal.UIElement_ItemList* m_ammoReadySlot;
    public ACBindings.Internal.UIElement_ItemList* m_shieldReadySlot;
    public ACBindings.Internal.UIElement_ItemList* m_clothesPantsSlot;
    public ACBindings.Internal.UIElement_ItemList* m_clothesShirtSlot;
    public ACBindings.Internal.UIElement_ItemList* m_trinketOneSlot;
    public ACBindings.Internal.UIElement_ItemList* m_cloakSlot;
    public ACBindings.Internal.UIElement_ItemList* m_sigilOneSlot;
    public ACBindings.Internal.UIElement_ItemList* m_sigilTwoSlot;
    public ACBindings.Internal.UIElement_ItemList* m_sigilThreeSlot;
    public ACBindings.Internal.UIElement_ItemList* m_headSlot;
    public ACBindings.Internal.UIElement_ItemList* m_chestSlot;
    public ACBindings.Internal.UIElement_ItemList* m_abdomenSlot;
    public ACBindings.Internal.UIElement_ItemList* m_upperArmSlot;
    public ACBindings.Internal.UIElement_ItemList* m_lowerArmSlot;
    public ACBindings.Internal.UIElement_ItemList* m_handSlot;
    public ACBindings.Internal.UIElement_ItemList* m_upperLegSlot;
    public ACBindings.Internal.UIElement_ItemList* m_lowerLegSlot;
    public ACBindings.Internal.UIElement_ItemList* m_footSlot;
    public ACBindings.Internal.CPhysicsObj* m_pInventoryObject;
    public ACBindings.Internal.UIElement_Viewport* m_pPaperDoll;
    public ACBindings.Internal.IDClass____tagDataID m_didAnimation;
    public ACBindings.Internal.UIElement* m_dragIcon;
    public ACBindings.Internal.UIElement* m_paperDollDragMask;
    public ACBindings.Internal.UIElement* m_paperDollDragOverlay;
    public ACBindings.Internal.UIElement* m_sigilOneItem;
    public ACBindings.Internal.UIElement* m_sigilTwoItem;
    public ACBindings.Internal.UIElement* m_sigilThreeItem;
    public ACBindings.Internal.UIElement_Button* m_SlotCheckbox;
    public ACBindings.Internal.RenderSurface* m_clickMap;
    public uint m_cFlipCount;
    public double m_timeNextFlip;
    public uint m_selectionMask;

    // Generated Constructor
    public gmPaperDollUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys gmPaperDollUI instance by unregistering global messages, releasing item list drag handlers for all equipment slots, removing the paper doll viewport from creature mode, deleting the inventory physics object and click map surface, deregistering quality change notifications, and cleaning up base class resources.
    /// <code>Offset: 0x004A3900
    /// void __thiscall gmPaperDollUI::~gmPaperDollUI(gmPaperDollUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, void>)0x004A3900)(ref this);

    /// <summary>
    /// Returns a pointer to the UIElement that matches the requested type identifier within the gmPaperDollUI instance.
    /// 
    /// <code>Offset: 0x004A3B30
    /// UIElement* __thiscall gmPaperDollUI::DynamicCast(gmPaperDollUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The element type ID to query. A value of 268435492 requests the base UIElement; a value of 3 returns the current gmPaperDollUI object as a UIElement.</param>
    /// <returns>Pointer to the matching UIElement, or nullptr if the requested type is not supported.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, ACBindings.Internal.UIElement*>)0x004A3B30)(ref this, i_eType);

    /// <summary>Returns the UI element type identifier for this paper‑doll interface.
    /// <code>Offset: 0x004A3B50
    /// unsigned int __thiscall gmPaperDollUI::GetUIElementType(gmPaperDollUI*)</code>
    /// </summary>
    /// <returns>Unsigned integer constant 268435492, identifying the element type within the UI system.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint>)0x004A3B50)(ref this);

    /// <summary>Translates a UI element ID into its corresponding location code and side.
    /// <code>Offset: 0x004A3B60
    /// void __thiscall gmPaperDollUI::GetLocationInfoFromElementID(gmPaperDollUI*,unsigned int,unsigned int*,UI_SLOT_SIDE*)</code>
    /// </summary>
    /// <param name="elemID">The identifier of the UI element to query.</param>
    /// <param name="loc">Pointer that receives the computed location value; set to 0 if the ID is unknown.</param>
    /// <param name="slotSide">Pointer that receives the slot side (left, right, or null) associated with the element; defaults to null for unknown IDs.</param>
    public void GetLocationInfoFromElementID(uint elemID, uint* loc, ACBindings.Internal.UI_SLOT_SIDE* slotSide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, uint*, ACBindings.Internal.UI_SLOT_SIDE*, void>)0x004A3B60)(ref this, elemID, loc, slotSide);

    /// <summary>Handles drag‑over events for items onto the character's paper‑doll UI, determining whether the dragged item can be auto‑worn and updating the overlay to indicate a valid or invalid drop zone.
    /// <code>Offset: 0x004A3DE0
    /// void __thiscall gmPaperDollUI::HandlePaperDollDragOver(gmPaperDollUI*,UIElement*)</code>
    /// </summary>
    /// <param name="this">Instance of gmPaperDollUI processing the event.</param>
    /// <param name="dragElement">The UI element representing the item currently being dragged over the paper doll.</param>
    public void HandlePaperDollDragOver(ACBindings.Internal.UIElement* dragElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.UIElement*, void>)0x004A3DE0)(ref this, dragElement);

    /// <summary>Accepts a dragged item onto the paper‑doll UI, verifies that the target equipment location is valid for the item, and automatically equips or wields it through the player system.
    /// <code>Offset: 0x004A3E80
    /// bool __thiscall gmPaperDollUI::AcceptDragObject(gmPaperDollUI*,unsigned int,unsigned int*,UI_SLOT_SIDE*)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the dragged item.</param>
    /// <param name="loc">Pointer to a bitmask indicating the desired equipment slot; the function reads this value to determine if the item can be placed there.</param>
    /// <param name="slotSide">Receives which side (left or right) the item will occupy when it is equipped, if applicable.</param>
    /// <returns>True if the item was successfully auto‑equipped or wielded; otherwise false.</returns>
    public byte AcceptDragObject(uint itemID, uint* loc, ACBindings.Internal.UI_SLOT_SIDE* slotSide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, uint*, ACBindings.Internal.UI_SLOT_SIDE*, byte>)0x004A3E80)(ref this, itemID, loc, slotSide);

    /// <summary>Refreshes the creature’s paper doll representation by creating or updating its physics object, setting orientation and animation, adding it to the viewport if necessary, and applying the current visual description.
    /// <code>Offset: 0x004A3F30
    /// void __thiscall gmPaperDollUI::RedressCreature(gmPaperDollUI*)</code>
    /// </summary>
    public void RedressCreature() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, void>)0x004A3F30)(ref this);

    /// <summary>Applies lighting to an inventory object's parts based on a selection mask; when <paramref name="locations"/> equals 0x7FFFFFFF the entire object receives uniform lighting, otherwise individual part lights are set according to internal flags.
    /// <code>Offset: 0x004A4010
    /// void __thiscall gmPaperDollUI::ApplyPartSelectionLighting(gmPaperDollUI*,unsigned int,float,float)</code>
    /// </summary>
    /// <param name="locations">Bitmask indicating which parts should receive lighting. The special value 0x7FFFFFFF triggers lighting on all parts of the object.</param>
    /// <param name="luminosity">Brightness intensity applied to the selected parts or the entire object.</param>
    /// <param name="diffuse">Diffuse shading factor influencing how light scatters on the parts.</param>
    public void ApplyPartSelectionLighting(uint locations, float luminosity, float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, float, float, void>)0x004A4010)(ref this, locations, luminosity, diffuse);

    /// <summary>Refreshes the visibility of the three sigil items in the paper doll UI by querying the object’s aetheria quality bits and updating each element accordingly.
    /// <code>Offset: 0x004A41C0
    /// void __thiscall gmPaperDollUI::UpdateAetheria(gmPaperDollUI*,CWeenieObject*)</code>
    /// </summary>
    /// <param name="cwobj">The character or item whose aetheria settings determine which sigils are shown.</param>
    public void UpdateAetheria(ACBindings.Internal.CWeenieObject* cwobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.CWeenieObject*, void>)0x004A41C0)(ref this, cwobj);

    /// <summary>
    /// Adjusts the paper‑doll viewport and animation sequence to match the character’s race heritage.
    /// Sets camera position, direction and, for certain heritages, changes the inventory object's animation.
    /// 
    /// <code>Offset: 0x004A4240
    /// void __thiscall gmPaperDollUI::UpdateForRace(gmPaperDollUI*,unsigned int)</code>
    /// </summary>
    /// <param name="heritage">Race heritage identifier used to determine camera settings and animation.</param>
    public void UpdateForRace(uint heritage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, void>)0x004A4240)(ref this, heritage);

    /// <summary>Initializes a paper‑doll user interface element with the specified layout and element description, setting up all equipment slots and loading the associated animation identifier.
    /// <code>Offset: 0x004A4430
    /// void __thiscall gmPaperDollUI::gmPaperDollUI(gmPaperDollUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Specifies the layout data used to construct the UI element.</param>
    /// <param name="full_desc">Provides the full element description from which slot references and animation ID are extracted.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004A4430)(ref this, layout, full_desc);

    /// <summary>Handles a dragged item hovering over an inventory slot in the paper‑doll UI, determining whether the drop target accepts the item based on its properties and auto‑wield rules, updating the UI state to indicate accept or reject. Always returns true to signal that the event was processed.
    /// <code>Offset: 0x004A45E0
    /// bool __thiscall gmPaperDollUI::OnItemListDragOver(gmPaperDollUI*,UIElement_UIItem*,unsigned int,unsigned int,DropItemFlags)</code>
    /// </summary>
    /// <param name="this">Instance of gmPaperDollUI handling the drag‑over event.</param>
    /// <param name="catchElement">UI element representing the slot currently hovered over.</param>
    /// <param name="dropItemID">Identifier of the item being dragged.</param>
    /// <param name="dropSpellID">Identifier of a spell associated with the drag (unused in this logic).</param>
    /// <param name="dropFlags">Context flags for the drop operation, influencing slot compatibility checks.</param>
    /// <returns>True, indicating that the event was handled and the UI state updated appropriately.</returns>
    public byte OnItemListDragOver(ACBindings.Internal.UIElement_UIItem* catchElement, uint dropItemID, uint dropSpellID, ACBindings.Internal.DropItemFlags dropFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.UIElement_UIItem*, uint, uint, ACBindings.Internal.DropItemFlags, byte>)0x004A45E0)(ref this, catchElement, dropItemID, dropSpellID, dropFlags);

    /// <summary>Responds to a notice indicating the player’s object description changed, refreshing the paper‑doll display accordingly.
    /// <code>Offset: 0x004A46C0
    /// void __thiscall gmPaperDollUI::RecvNotice_PlayerObjDescChanged(gmPaperDollUI*)</code>
    /// </summary>
    public void RecvNotice_PlayerObjDescChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, void>)0x004A46C0)(ref this);

    /// <summary>Cycles the paper‑doll part selection lighting based on a flip counter and elapsed time, applying alternating light values until the cycle completes, then clears the selection mask, restores original lighting, and unregisters from global messages.
    /// <code>Offset: 0x004A46D0
    /// void __thiscall gmPaperDollUI::UpdatePartSelectionLighting(gmPaperDollUI*)</code>
    /// </summary>
    public void UpdatePartSelectionLighting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, void>)0x004A46D0)(ref this);

    /// <summary>Handles a player description notification, extracting gender/appearance flags from the supplied qualities to adjust UI element visibility and updating the paper‑doll display for the player's race.
    /// <code>Offset: 0x004A4750
    /// void __thiscall gmPaperDollUI::RecvNotice_PlayerDescReceived(gmPaperDollUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Quality data containing the player's attributes used to determine UI state and race.</param>
    /// <param name="i_playerModule">Player module information; currently not directly used by this handler.</param>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004A4750)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Refreshes the aetheria display for the paper doll when an object's quality changes.
    /// <code>Offset: 0x004A4800
    /// void __thiscall gmPaperDollUI::OnQualityChanged(gmPaperDollUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="cwobj">The item whose quality has changed.</param>
    /// <param name="stype">The specific stat type that triggered the update.</param>
    /// <param name="senum">Enumeration value identifying the nature of the change event.</param>
    public void OnQualityChanged(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004A4800)(ref this, cwobj, stype, senum);

    /// <summary>Registers the PaperDollUI element type with the UI system, associating it with its unique class identifier and providing a factory method for creating instances based on layout and descriptor data.
    /// <code>Offset: 0x004A48D0
    /// void __cdecl gmPaperDollUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004A48D0)();

    /// <summary>Prepares a visual representation for dragging an item from the paper‑doll UI. If the supplied itemID is zero, no action occurs and the function returns false; otherwise it clears any existing drag image, attempts to load the item's icon, applies it if available, and updates the drag element state.
    /// <code>Offset: 0x004A48F0
    /// bool __thiscall gmPaperDollUI::PrepareDragIcon(gmPaperDollUI*,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the item to be dragged.</param>
    /// <returns>True when a non‑zero item ID is supplied; false when the ID is zero. The return value does not indicate whether an icon was successfully loaded.</returns>
    public byte PrepareDragIcon(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, byte>)0x004A48F0)(ref this, itemID);

    /// <summary>Returns the ID of the highest‑priority item that occupies any slot matching the supplied mask for the current player; if no such item exists, returns the player's own ID.
    /// <code>Offset: 0x004A4AC0
    /// unsigned int __thiscall gmPaperDollUI::GetUpperInvObj(gmPaperDollUI*,unsigned int)</code>
    /// </summary>
    /// <param name="locations">Bitmask indicating which inventory placement flags to search for.</param>
    /// <returns>The object ID of the selected inventory item, or the player's ID when no matching item is found. Returns 0 only when the player cannot be identified or an invalid request occurs.</returns>
    public uint GetUpperInvObj(uint locations) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, uint>)0x004A4AC0)(ref this, locations);

    /// <summary>Releases any existing click‑map surface, then loads a predefined render surface from the game database and assigns it to the UI element’s m_clickMap field.
    /// <code>Offset: 0x004A4BC0
    /// void __thiscall gmPaperDollUI::CreateClickMap(gmPaperDollUI*)</code>
    /// </summary>
    public void CreateClickMap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, void>)0x004A4BC0)(ref this);

    /// <summary>Performs a hit test on the paper‑doll click map to determine which body slot the mouse is over and returns the corresponding inventory object identifier.
    /// <code>Offset: 0x004A4C90
    /// unsigned int __thiscall gmPaperDollUI::GetPaperDollItemUnderMouse(gmPaperDollUI*,int,int)</code>
    /// </summary>
    /// <param name="window_mousex">The X coordinate of the mouse within the window.</param>
    /// <param name="window_mousey">The Y coordinate of the mouse within the window.</param>
    /// <returns>Identifier of the inventory object under the cursor, or zero if no slot is hit or the click map is unavailable.</returns>
    public uint GetPaperDollItemUnderMouse(int window_mousex, int window_mousey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, int, int, uint>)0x004A4C90)(ref this, window_mousex, window_mousey);

    /// <summary>Accepts a dragged item onto the paper‑doll UI, validating its placement, ensuring the player is ready to modify inventory, and automatically equipping it if possible.
    /// <code>Offset: 0x004A4DE0
    /// bool __thiscall gmPaperDollUI::AcceptPaperDollDragObject(gmPaperDollUI*,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the item being dragged into the paper doll.</param>
    /// <returns>True when the item was successfully validated and auto‑worn; otherwise false (e.g., invalid location or player not ready).</returns>
    public byte AcceptPaperDollDragObject(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, byte>)0x004A4DE0)(ref this, itemID);

    /// <summary>Computes a bitmask indicating which equipment slots correspond to the specified object ID, returning a full‑range mask when it matches the active smart box.
    /// <code>Offset: 0x004A4EC0
    /// unsigned int __thiscall gmPaperDollUI::GetSelectionMaskFromObject(gmPaperDollUI*,unsigned int)</code>
    /// </summary>
    /// <param name="objID">The identifier of the object being queried.</param>
    /// <returns>Bitmask of slot flags; 0x7FFFFFFF if objID equals the current SmartBox ID, otherwise a combination of flags for upper inventory slots that match objID.</returns>
    public uint GetSelectionMaskFromObject(uint objID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, uint>)0x004A4EC0)(ref this, objID);

    /// <summary>Begins the lighting animation for a selected body part by determining its selection mask, resetting flip counters and timers, restoring inventory lighting if present, and registering for global update messages.
    /// <code>Offset: 0x004A4FC0
    /// void __thiscall gmPaperDollUI::BeginPartSelectionLighting(gmPaperDollUI*,unsigned int)</code>
    /// </summary>
    /// <param name="objID">The identifier of the object whose part should be highlighted.</param>
    public void BeginPartSelectionLighting(uint objID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, void>)0x004A4FC0)(ref this, objID);

    /// <summary>Processes global messages relevant to the paper‑doll interface, updating lighting or race‑specific visuals when appropriate.
    /// <code>Offset: 0x004A5020
    /// void __thiscall gmPaperDollUI::ListenToGlobalMessage(gmPaperDollUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the global message received.</param>
    /// <param name="i_data_int">Integer payload associated with the message (unused for current message types).</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, int, void>)0x004A5020)(ref this, i_messageID, i_data_int);

    /// <summary>Handles a drop‑release event on the paper doll UI, determining where an item should be placed and attempting to apply it if permissible.
    /// <code>Offset: 0x004A50F0
    /// void __thiscall gmPaperDollUI::HandleDropRelease(gmPaperDollUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information describing the drag operation, including references to the dragged element and any associated data.</param>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004A50F0)(ref this, i_rMsg);

    /// <summary>Activates lighting for the specified equipment part when a new item is selected.
    /// <code>Offset: 0x004A51E0
    /// void __thiscall gmPaperDollUI::RecvNotice_SetSelectedItem(gmPaperDollUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="oldSelectedID">Identifier of the previously selected item; ignored by this implementation.</param>
    /// <param name="selectedID">Identifier of the newly selected item. If non‑zero, lighting is activated for that item; otherwise no action occurs.</param>
    public void RecvNotice_SetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, uint, void>)0x004A51E0)(ref this, oldSelectedID, selectedID);

    /// <summary>Updates the tooltip shown for a gear slot in the paper doll UI. If an item is present, displays its name and whether it can be taken off or unwielded; otherwise shows a default drag‑prompt appropriate to that slot.
    /// <code>Offset: 0x004A5200
    /// void __thiscall gmPaperDollUI::UpdateItemSlotTooltip(gmPaperDollUI*,UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    /// <param name="i_pSlot">The UI element representing the inventory slot being updated.</param>
    /// <param name="itemID">The ID of the item currently in the slot (zero if the slot is empty).</param>
    public void UpdateItemSlotTooltip(ACBindings.Internal.UIElement_ItemList* i_pSlot, uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.UIElement_ItemList*, uint, void>)0x004A5200)(ref this, i_pSlot, itemID);

    /// <summary>
    /// Initializes the paper doll UI by locating all slot elements, registering drag handlers, updating tooltips, configuring the viewport camera and lighting, and setting up global event listeners. It also creates a click map and prepares the drag icon for item interaction.
    /// 
    /// <code>Offset: 0x004A56D0
    /// void __thiscall gmPaperDollUI::PostInit(gmPaperDollUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, void>)0x004A56D0)(ref this);

    /// <summary>Processes element messages for the paper doll interface, handling slot interactions, drag‑drop events, item selection and target mode execution, then delegates remaining messages to the base UI listener.
    /// <code>Offset: 0x004A5FA0
    /// UIElementMessageListenResult __thiscall gmPaperDollUI::ListenToElementMessage(gmPaperDollUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Provides information about the message, including the element ID, message type, coordinates, parameters, and timestamp.</param>
    /// <returns>Result of listening to the message as determined by the base UI element listener.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004A5FA0)(ref this, i_rMsg);

    /// <summary>Equips the specified item into all slots indicated by the location mask, updating each corresponding UI list and tooltip.
    /// <code>Offset: 0x004A6300
    /// void __thiscall gmPaperDollUI::SetUIItemIntoLocation(gmPaperDollUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the item to place into slots.</param>
    /// <param name="location">Bitmask specifying which body slot(s) should receive the item; each bit corresponds to a specific equipment position (e.g., head, chest, armor, weapons).</param>
    public void SetUIItemIntoLocation(uint itemID, uint location) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, uint, void>)0x004A6300)(ref this, itemID, location);

    /// <summary>Adjusts the player system masks and updates the paper doll UI in response to a server move‑item notification by reconciling old and new item locations.
    /// <code>Offset: 0x004A6810
    /// void __thiscall gmPaperDollUI::ServerSaysMoveItem(gmPaperDollUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmPaperDollUI instance.</param>
    /// <param name="itemID">Identifier of the moved item.</param>
    /// <param name="oldContainer">Previous container ID (unused).</param>
    /// <param name="oldWielder">Previous wielder ID, used to determine if the item was equipped by the player.</param>
    /// <param name="oldLocation">Bitmask representing the item's former location; used when clearing inventory and clothing masks.</param>
    /// <param name="newContainer">New container ID (unused).</param>
    /// <param name="place">Placement index within the new container (unused).</param>
    /// <param name="newWielder">New wielder ID, indicating whether the item is now equipped by the player.</param>
    /// <param name="newLocation">Bitmask representing the item's new location; used to set inventory and clothing masks and update the UI.</param>
    public void ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004A6810)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>Rebuilds the character inventory UI for the current player, resetting slot states and applying item placement data from the server.
    /// <code>Offset: 0x004A6930
    /// bool __thiscall gmPaperDollUI::RemakeCharacterInventory(gmPaperDollUI*)</code>
    /// </summary>
    /// <returns>True if the inventory UI was successfully regenerated; this function always returns true on completion.</returns>
    public byte RemakeCharacterInventory() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, byte>)0x004A6930)(ref this);
}

