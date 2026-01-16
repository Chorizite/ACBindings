namespace ACBindings.Internal;


/// <summary>Barber user interface for character appearance editing, providing controls for hair, eyes, nose, mouth, skin, and rotation within a 3‑D preview.</summary>
/// <remarks>Manages UI elements, handles input, updates the character generator state, and animates the 3‑D view.</remarks>
public unsafe struct gmBarberUI
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmBarberUI_vtbl
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
    // gmBarberUI::EGender
    public enum EGender : byte
    {
        ECG_GENDER_INVALID = 0x0,
        ECG_GENDER_FEMALE = 0x1,
        ECG_GENDER_MALE = 0x2
    }
    // gmBarberUI::EParts
    public enum EParts : uint
    {
    }
    // gmBarberUI::ERotateDirection
    public enum ERotateDirection : uint
    {
    }

    /// <summary>Maintains the selection state for a barber UI, including the total number of options, the currently selected option, the number of available colors, the chosen color index, and the shading level.</summary>
    public unsafe struct tagChoices
    {
        // Members
        public int iNumChoices;
        public int iCurrentChoice;
        public int iNumColors;
        public int iCurrentColor;
        public double dShade;

        // Methods
    }

    /// <summary>Captures RGB values and related UI elements for a color wheel used within the barber interface, linking visual components to their logical parts.</summary>
    public unsafe struct tagColorWheel
    {
        // Members
        public uint iRed;
        public uint iGreen;
        public uint iBlue;
        public ACBindings.Internal.UIElement* pColor;
        public ACBindings.Internal.UIElement* pPointer;
        public ACBindings.Internal.Graphic* pGraphic;
        public ACBindings.Internal.gmBarberUI.EParts ePart;

        // Methods
    }

    // Members
    public ACBindings.Internal.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.Internal.UIElement_Button* m_pRotateClockButton;
    public ACBindings.Internal.UIElement_Button* m_pRotateCounterClockButton;
    public ACBindings.Internal.UIElement_Button* m_pHairSpin;
    public ACBindings.Internal.UIElement_Button* m_pEyesSpin;
    public ACBindings.Internal.UIElement_Button* m_pNoseSpin;
    public ACBindings.Internal.UIElement_Button* m_pMouthSpin;
    public ACBindings.Internal.UIElement_Button* m_pSkinSpin;
    public ACBindings.Internal.UIElement_Button* m_pApplyButton;
    public ACBindings.Internal.UIElement_Button* m_pCancelButton;
    public ACBindings.Internal.UIElement_Button* m_pOption1Checkbox;
    public ACBindings.Internal.UIElement_Button* m_pOption2Checkbox;
    public ACBindings.Internal.UIElement_Button* m_pOption3Checkbox;
    public ACBindings.Internal.UIElement_Scrollbar* m_pShadeScroll;
    public ACBindings.Internal.UIElement* m_pFaceChoices;
    public ACBindings.Internal.UIElement* m_pGradCircle;
    public ACBindings.Internal.Graphic* m_pGradGraphic;
    public ACBindings.Internal.Graphic* m_pGradPlug;
    public ACBindings.Internal.UIElement* m_pCurSelection;
    public ACBindings.Internal.UIElement_Viewport* m_pViewport;
    public ACBindings.Internal.gmCG3DView* m_p3DView;
    public int m_iCurColor;
    public int m_iPartIndex;
    public int m_iHoldheadgear;
    public byte m_bRotating;
    public float m_fCurHeading;
    public float m_fTargHeading;
    public double m_dAnimStartTime;
    public double m_dAnimDuration;
    public double m_dLastRotateTime;
    public double m_dRotationPerSec;
    public ACBindings.Internal.gmBarberUI.ERotateDirection m_eRotateDir;
    public fixed byte m_tChoices_Raw[216];
    public ACBindings.Internal.gmBarberUI.tagChoices* m_tChoices => (ACBindings.Internal.gmBarberUI.tagChoices*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_tChoices_Raw[0]);
    public ACBindings.Internal.gmBarberUI.EParts m_eCurPart;
    public fixed byte m_tColorWheel_Raw[252];
    public ACBindings.Internal.gmBarberUI.tagColorWheel* m_tColorWheel => (ACBindings.Internal.gmBarberUI.tagColorWheel*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_tColorWheel_Raw[0]);

    // Generated Constructor
    public gmBarberUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>Initializes a gmBarberUI instance, configuring its UI elements, event handlers, and default appearance settings.
    /// <code>Offset: 0x004DEE40
    /// void __thiscall gmBarberUI::gmBarberUI(gmBarberUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout description defining screen dimensions and element mappings for the UI.</param>
    /// <param name="full_desc">Full element descriptor used to configure the root UI element hierarchy.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004DEE40)(ref this, layout, full_desc);

    /// <summary>Returns a UIElement pointer representing this instance when the requested type identifier matches known values, otherwise returns null.
    /// <code>Offset: 0x004DEF40
    /// UIElement* __thiscall gmBarberUI::DynamicCast(gmBarberUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The numeric type identifier used to determine which UIElement representation to return.</param>
    /// <returns>A UIElement pointer that matches the specified type or 0 if no matching type is found.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, uint, ACBindings.Internal.UIElement*>)0x004DEF40)(ref this, i_eType);

    /// <summary>Retrieves a numeric code identifying the UI element type associated with this barber UI instance.
    /// <code>Offset: 0x004DEF60
    /// unsigned int __thiscall gmBarberUI::GetUIElementType(gmBarberUI*)</code>
    /// </summary>
    /// <returns>An unsigned 32‑bit integer that represents the specific UI element type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, uint>)0x004DEF60)(ref this);

    /// <summary>
    /// Initializes the barber UI by invoking its base UI element initialization, registering necessary notice handlers and a global message callback, then sets the default heading angle to 180 degrees.
    /// 
    /// <code>Offset: 0x004DEF70
    /// void __thiscall gmBarberUI::PostInit(gmBarberUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, void>)0x004DEF70)(ref this);

    /// <summary>Responds to a player object description change notice by updating the 3D view if the associated UI element is currently visible.
    /// <code>Offset: 0x004DF040
    /// void __thiscall gmBarberUI::RecvNotice_PlayerObjDescChanged(gmBarberUI*)</code>
    /// </summary>
    public void RecvNotice_PlayerObjDescChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, void>)0x004DF040)(ref this);

    /// <summary>Applies the specified shade value to the currently selected character part (hair or skin) and updates the corresponding UI scrollbar and 3D preview if visible.
    /// <code>Offset: 0x004DF060
    /// void __thiscall gmBarberUI::SetShade(gmBarberUI*,long double)</code>
    /// </summary>
    /// <param name="dShade">The new shade intensity as a long double.</param>
    public void SetShade(double dShade) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, double, void>)0x004DF060)(ref this, dShade);

    /// <summary>Updates the player’s heading in the barber UI by advancing it according to the elapsed time and rotation speed, then normalizes the result to a 0–360° range before applying it to the 3‑D view.
    /// <code>Offset: 0x004DF0E0
    /// void __thiscall gmBarberUI::DoRotation(gmBarberUI*)</code>
    /// </summary>
    public void DoRotation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, void>)0x004DF0E0)(ref this);

    /// <summary>Begins or cancels character rotation in the barber UI based on the requested direction. If already rotating in that direction, stops rotation; otherwise starts a new rotation cycle and updates internal state.
    /// <code>Offset: 0x004DF1B0
    /// void __thiscall gmBarberUI::Rotate(gmBarberUI*,gmBarberUI::ERotateDirection)</code>
    /// </summary>
    /// <param name="eDir">The desired rotation direction (clockwise or counter‑clockwise).</param>
    public void Rotate(ACBindings.Internal.gmBarberUI.ERotateDirection eDir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, ACBindings.Internal.gmBarberUI.ERotateDirection, void>)0x004DF1B0)(ref this, eDir);

    /// <summary>Registers the barber UI element class with the system, associating it with its layout descriptor and creation callback.
    /// <code>Offset: 0x004DF290
    /// void __cdecl gmBarberUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004DF290)();

    /// <summary>Handles global messages; when a rotation request (message ID 3) arrives while the UI is rotating, continues the rotation animation.
    /// <code>Offset: 0x004DF2B0
    /// void __thiscall gmBarberUI::ListenToGlobalMessage(gmBarberUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="messageID">Identifier of the received message.</param>
    /// <param name="data_int">Additional data for the message; not used by this handler.</param>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, uint, int, void>)0x004DF2B0)(ref this, messageID, data_int);

    /// <summary>Refreshes the color wheel spots for a given character part, recalculating each spot’s image and replacing its color to match the current selection.
    /// <code>Offset: 0x004DF2D0
    /// void __thiscall gmBarberUI::DoColorSpots(gmBarberUI*,int)</code>
    /// </summary>
    /// <param name="iPart">Zero‑based index of the body part whose color wheel should be updated (e.g., hair, eyes, etc.).</param>
    public void DoColorSpots(int iPart) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, int, void>)0x004DF2D0)(ref this, iPart);

    /// <summary>Updates the barber UI’s gradient disk visual by loading or creating gradient resources, applying the selected color from the color wheel, and blitting either a plug graphic or a colored gradient onto the display region.
    /// <code>Offset: 0x004DF510
    /// void __thiscall gmBarberUI::DoGradDisk(gmBarberUI*,bool)</code>
    /// </summary>
    /// <param name="bUsePlug">Specifies whether to use a pre-rendered plug image (true) or apply the current color to the gradient graphic (false).</param>
    public void DoGradDisk(byte bUsePlug) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, byte, void>)0x004DF510)(ref this, bUsePlug);

    /// <summary>Changes the currently selected color for the active facial feature, updates the character generator state with the new hair or eye color, refreshes the color wheel visuals, and redraws the 3D preview if the UI is visible.
    /// <code>Offset: 0x004DF7D0
    /// void __thiscall gmBarberUI::SetColor(gmBarberUI*,int)</code>
    /// </summary>
    /// <param name="iColor">Index of the color wheel entry to activate; passing –1 clears any previous selection.</param>
    public void SetColor(int iColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, int, void>)0x004DF7D0)(ref this, iColor);

    /// <summary>Initializes the barber UI’s part selections and colors from the player’s current character generation data, populating the internal choice arrays with available options and setting the current values for hair, eyes, nose, mouth, shirt, trousers, and footwear.
    /// <code>Offset: 0x004DF880
    /// void __thiscall gmBarberUI::SetupParts(gmBarberUI*)</code>
    /// </summary>
    public void SetupParts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, void>)0x004DF880)(ref this);

    /// <summary>Sets the currently selected body part in the barber interface, updating internal state, color options, shading controls, and UI indicators for hair, eyes, nose, mouth or skin.
    /// <code>Offset: 0x004DFA80
    /// void __thiscall gmBarberUI::SetSelection(gmBarberUI*,gmBarberUI::EParts)</code>
    /// </summary>
    /// <param name="ePart">The enumeration value indicating which part to select (hair, eyes, nose, mouth, skin, etc.).</param>
    public void SetSelection(ACBindings.Internal.gmBarberUI.EParts ePart) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, ACBindings.Internal.gmBarberUI.EParts, void>)0x004DFA80)(ref this, ePart);

    /// <summary>Processes messages for the barber UI, updating hairstyle, eye, nose, mouth choices, colors, rotation and shade settings, and applying or canceling character customization changes.
    /// <code>Offset: 0x004DFEF0
    /// UIElementMessageListenResult __thiscall gmBarberUI::ListenToElementMessage(gmBarberUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element message to process.</param>
    /// <returns>The result of handling the message, typically forwarded from the base class after custom processing.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004DFEF0)(ref this, i_rMsg);

    /// <summary>Initializes the barber UI page, setting up character appearance controls and 3‑D view based on supplied style identifiers and flags.
    /// <code>Offset: 0x004E0CD0
    /// void __thiscall gmBarberUI::InitializePage(UIElement*,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmBarberUI instance being initialized.</param>
    /// <param name="a2">Reserved or unused parameter for binary compatibility.</param>
    /// <param name="a3">Hair style identifier used to set the character’s hairstyle.</param>
    /// <param name="a4">Flag indicating whether the selected hair style is dark; influences hair index selection.</param>
    /// <param name="a5">Reserved or unused parameter.</param>
    /// <param name="a6">Eye strip identifier for selecting eye appearance.</param>
    /// <param name="a7">Reserved or unused parameter.</param>
    /// <param name="a8">Nose strip identifier for selecting nose appearance.</param>
    /// <param name="a9">Reserved or unused parameter.</param>
    /// <param name="a10">Mouth strip identifier for selecting mouth appearance.</param>
    /// <param name="a11">Reserved or unused parameter.</param>
    /// <param name="a12">Skin shade value applied to the character’s skin tone.</param>
    /// <param name="a13">Hair color identifier used to set the hair color palette.</param>
    /// <param name="a14">Eye color identifier used to set eye coloration.</param>
    /// <param name="a15">Gear item ID that influences UI text and styling options.</param>
    /// <param name="a16">Boolean flag controlling special styling based on the selected gear.</param>
    /// <param name="a17">Reserved or unused parameter.</param>
    public void InitializePage(int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, int a11, int a12, int a13, int a14, int a15, int a16, int a17) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, void>)0x004E0CD0)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17);

    /// <summary>Initializes the barber UI page with supplied configuration values, updates the 3D view, and begins the first character animation.
    /// <code>Offset: 0x004E1B50
    /// int __thiscall gmBarberUI::RecvNotice_StartBarberNotice(gmCG3DView**,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int)</code>
    /// </summary>
    /// <param name="a2">Configuration value used during page initialization.</param>
    /// <param name="a3">Configuration value used during page initialization.</param>
    /// <param name="a4">Configuration value used during page initialization.</param>
    /// <param name="a5">Configuration value used during page initialization.</param>
    /// <param name="a6">Configuration value used during page initialization.</param>
    /// <param name="a7">Configuration value used during page initialization.</param>
    /// <param name="a8">Configuration value used during page initialization.</param>
    /// <param name="a9">Configuration value used during page initialization.</param>
    /// <param name="a10">Configuration value used during page initialization.</param>
    /// <param name="a11">Configuration value used during page initialization.</param>
    /// <param name="a12">Configuration value used during page initialization.</param>
    /// <param name="a13">Configuration value used during page initialization.</param>
    /// <param name="a14">Configuration value used during page initialization.</param>
    /// <param name="a15">Configuration value used during page initialization.</param>
    /// <param name="a16">Configuration value used during page initialization.</param>
    /// <param name="a17">Configuration value used during page initialization.</param>
    /// <returns>Result of the animation start operation (typically a status code).</returns>
    public int RecvNotice_StartBarberNotice(int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, int a11, int a12, int a13, int a14, int a15, int a16, int a17) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>)0x004E1B50)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17);
}

