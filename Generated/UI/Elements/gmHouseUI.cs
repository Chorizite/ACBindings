namespace ACBindings.Internal;


/// <summary>Represents the user interface component that displays house information—including location, payments, and purchase status—and updates itself in response to game events.</summary>
public unsafe struct gmHouseUI
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmHouseUI_vtbl
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
    public ACBindings.Internal.HouseData* m_pHouseData;
    public ACBindings.Internal.UIElement_ListBox* m_pTextBox;

    // Methods

    /// <summary>Attempts to cast a gmHouseUI instance to a UIElement when the supplied element type identifier matches known identifiers.
    /// <code>Offset: 0x004A28D0
    /// UIElement* __thiscall gmHouseUI::DynamicCast(gmHouseUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The desired element type ID for casting. A value of 268435493 requests the embedded UIElement; a value of 3 returns the gmHouseUI object itself as a UIElement. Any other value yields null.</param>
    /// <returns>A pointer to the requested UIElement representation, or nullptr if the type does not match.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, uint, ACBindings.Internal.UIElement*>)0x004A28D0)(ref this, i_eType);

    /// <summary>Retrieves the unique identifier for the house UI component.
    /// <code>Offset: 0x004A28F0
    /// unsigned int __thiscall gmHouseUI::GetUIElementType(gmHouseUI*)</code>
    /// </summary>
    /// <returns>The unsigned integer constant representing the UI element type (268435493).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, uint>)0x004A28F0)(ref this);

    /// <summary>Creates a UI element for the house interface using the provided layout and element descriptors, returning an initialized UIElement instance.
    /// <code>Offset: 0x004A2900
    /// UIElement* __cdecl gmHouseUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Pointer to the layout descriptor defining overall UI dimensions and elements.</param>
    /// <param name="full_desc">Pointer to the element descriptor providing properties for the specific element to create.</param>
    /// <returns>Pointer to the newly constructed UIElement, or nullptr if memory allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004A2900)(layout, full_desc);

    /// <summary>Performs additional initialization for the house UI after construction. Locates the text box element and stores it in m_pTextBox, then registers several notice handlers with the global event system.
    /// <code>Offset: 0x004A2A40
    /// void __thiscall gmHouseUI::PostInit(gmHouseUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A2A40)(ref this);

    /// <summary>Registers the House UI element class within the UI framework, mapping a unique identifier to its factory method for subsequent instantiation.
    /// <code>Offset: 0x004A2AC0
    /// void __cdecl gmHouseUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004A2AC0)();

    /// <summary>Retrieves the land coordinates of a house when valid data exists; writes the X and Y values into the supplied pointers.
    /// <code>Offset: 0x004A2AE0
    /// bool __thiscall gmHouseUI::GetHouseLocation(gmHouseUI*,int*,int*)</code>
    /// </summary>
    /// <param name="io_px">Output pointer for the house's X coordinate.</param>
    /// <param name="io_py">Output pointer for the house's Y coordinate.</param>
    /// <returns>True if a location was successfully retrieved; otherwise false, leaving coordinates set to -1.</returns>
    public byte GetHouseLocation(int* io_px, int* io_py) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, int*, int*, byte>)0x004A2AE0)(ref this, io_px, io_py);

    /// <summary>Adds a new line of text to the house panel’s list box, creating an item from its template and setting the provided string with the specified font style.
    /// <code>Offset: 0x004A2B40
    /// void __thiscall gmHouseUI::AddHousePanelText(_DWORD*,int*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the string that will be displayed in the newly added list item.</param>
    /// <param name="a3">Integer identifying the font or formatting option used when rendering the text.</param>
    public void AddHousePanelText(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, int*, int, void>)0x004A2B40)(ref this, a2, a3);

    /// <summary>Displays a message in the house UI text box indicating either the purchase cost of the dwelling or, if none is owned, informs the player that they do not currently own a house.
    /// <code>Offset: 0x004A2E60
    /// void __thiscall gmHouseUI::DisplayBuyPayment(gmHouseUI*)</code>
    /// </summary>
    public void DisplayBuyPayment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A2E60)(ref this);

    /// <summary>Displays the house’s current rent payment information on the user interface by composing a formatted string from the house data and adding it to the house panel text list.
    /// <code>Offset: 0x004A2F50
    /// void __thiscall gmHouseUI::DisplayRentPayment(gmHouseUI*)</code>
    /// </summary>
    public void DisplayRentPayment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A2F50)(ref this);

    /// <summary>Shows the purchase time of the house by adding a formatted "Bought: &lt;time&gt;" string to the UI panel when house data is available.
    /// <code>Offset: 0x004A2FF0
    /// void __thiscall gmHouseUI::DisplayBuyTime(gmHouseUI*)</code>
    /// </summary>
    public void DisplayBuyTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A2FF0)(ref this);

    /// <summary>Displays the current maintenance period end date/time and the next scheduled maintenance or payment deadline for the house on the UI panel.
    /// <code>Offset: 0x004A3090
    /// void __thiscall gmHouseUI::DisplayRentTimes(gmHouseUI*)</code>
    /// </summary>
    public void DisplayRentTimes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A3090)(ref this);

    /// <summary>Displays the current location of the house on the user interface by converting its world coordinates into a formatted string with cardinal direction indicators and appending it to the panel text box.
    /// <code>Offset: 0x004A3210
    /// void __thiscall gmHouseUI::DisplayLocation(gmHouseUI*)</code>
    /// </summary>
    public void DisplayLocation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A3210)(ref this);

    /// <summary>Displays a maintenance or rent warning message in the house UI panel, showing that maintenance has been prepaid for the period or presenting next‑period payment options based on current house status.
    /// <code>Offset: 0x004A3350
    /// void __thiscall gmHouseUI::DisplayWarningText(gmHouseUI*)</code>
    /// </summary>
    public void DisplayWarningText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A3350)(ref this);

    /// <summary>Displays a message indicating whether the player may buy another house immediately or must wait until the purchase restriction period expires, based on their current purchase status.
    /// <code>Offset: 0x004A3440
    /// void __thiscall gmHouseUI::DisplayPurchaseTimeText(gmHouseUI*)</code>
    /// </summary>
    public void DisplayPurchaseTimeText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A3440)(ref this);

    /// <summary>Refreshes the house user interface by clearing its list box and displaying updated information about buying and renting options, payment amounts, availability times, location details, warning messages, and purchase time text.
    /// <code>Offset: 0x004A36B0
    /// void __thiscall gmHouseUI::DisplayHouseData(gmHouseUI*)</code>
    /// </summary>
    public void DisplayHouseData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A36B0)(ref this);

    /// <summary>Updates the house UI with new data and refreshes all displayed information such as payments, times, location, and warnings.
    /// <code>Offset: 0x004A3800
    /// void __thiscall gmHouseUI::RecvNotice_UpdateHouseData(gmHouseUI*,const HouseData*)</code>
    /// </summary>
    /// <param name="i_houseData">The HouseData structure containing updated information about the house.</param>
    public void RecvNotice_UpdateHouseData(ACBindings.Internal.HouseData* i_houseData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, ACBindings.Internal.HouseData*, void>)0x004A3800)(ref this, i_houseData);

    /// <summary>Handles a failed house transaction by clearing pending data, resetting UI elements, and updating payment, time, location, and warning displays.
    /// <code>Offset: 0x004A3810
    /// void __thiscall gmHouseUI::RecvNotice_FailedHouseTransaction(gmHouseUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The identifier for the notice type triggering the failure handling.</param>
    public void RecvNotice_FailedHouseTransaction(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, uint, void>)0x004A3810)(ref this, i_eType);

    /// <summary>Updates the house’s rent time based on a received notice, resets pending payments, and refreshes the UI display.
    /// <code>Offset: 0x004A3820
    /// void __thiscall gmHouseUI::RecvNotice_UpdateRentTime(gmHouseUI*,int)</code>
    /// </summary>
    /// <param name="i_rentTime">The new rent duration value to apply.</param>
    public void RecvNotice_UpdateRentTime(int i_rentTime) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, int, void>)0x004A3820)(ref this, i_rentTime);

    /// <summary>Updates the house UI with a new rent payment list and refreshes the displayed information.
    /// <code>Offset: 0x004A3850
    /// void __thiscall gmHouseUI::RecvNotice_UpdateRentPayment(gmHouseUI*,const HousePaymentList*)</code>
    /// </summary>
    /// <param name="i_rent">The list of rent payments to display.</param>
    public void RecvNotice_UpdateRentPayment(ACBindings.Internal.HousePaymentList* i_rent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, ACBindings.Internal.HousePaymentList*, void>)0x004A3850)(ref this, i_rent);
}

