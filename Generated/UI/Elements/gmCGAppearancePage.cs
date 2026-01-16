namespace ACBindings.Internal;


/// <summary>Controls the character appearance editor, managing UI components for part selection, color wheels, and style changes while driving a 3‑D preview view that supports zooming and rotation.</summary>
/// <remarks>Maintains references to buttons, graphics, and state variables; interacts with CPlayerSystem to apply user choices and updates gmCG3DView. Handles global messages and player object description updates to keep the preview in sync.</remarks>
public unsafe struct gmCGAppearancePage
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmCGAppearancePage_vtbl
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
    // gmCGAppearancePage::EGender
    public enum EGender : uint
    {
    }
    // gmCGAppearancePage::EParts
    public enum EParts : byte
    {
        ECG_PARTS_INVALID = 0x0,
        ECG_PARTS_HAIR = 0x1,
        ECG_PARTS_EYES = 0x2,
        ECG_PARTS_NOSE = 0x3,
        ECG_PARTS_MOUTH = 0x4,
        ECG_PARTS_SKIN = 0x5,
        ECG_PARTS_HEADGEAR = 0x6,
        ECG_PARTS_SHIRT = 0x7,
        ECG_PARTS_TROUSERS = 0x8,
        ECG_PARTS_FOOTWEAR = 0x9
    }
    // gmCGAppearancePage::ERotateDirection
    public enum ERotateDirection : byte
    {
        ECG_ROTATE_INVALID = 0x0,
        ECG_ROTATE_CLOCKWISE = 0x1,
        ECG_ROTATE_COUNTERCLOCKWISE = 0x2
    }
    // gmCGAppearancePage::EType
    public enum EType : byte
    {
        ECG_CHOICE_INVALID = 0x0,
        ECG_CHOICE_FACE = 0x1,
        ECG_CHOICE_CLOTHES = 0x2
    }

    /// <summary>Represents the current selection state for appearance options, including available choices, selected indices, color palette count, chosen color, and shading intensity.</summary>
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

    /// <summary>Contains RGB color data for a character appearance page's color wheel, along with references to its UI representation and the specific appearance part it modifies.</summary>
    public unsafe struct tagColorWheel
    {
        // Members
        public uint iRed;
        public uint iGreen;
        public uint iBlue;
        public ACBindings.Internal.UIElement* pColor;
        public ACBindings.Internal.UIElement* pPointer;
        public ACBindings.Internal.Graphic* pGraphic;
        public ACBindings.Internal.gmCGAppearancePage.EParts ePart;

        // Methods
    }

    // Members
    public ACBindings.Internal.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.Internal.gmCharGenMainUI* m_pMainFramework;
    public ACBindings.Internal.UIElement_Button* m_pFemaleButton;
    public ACBindings.Internal.UIElement_Button* m_pMaleButton;
    public ACBindings.Internal.UIElement_Button* m_pFaceButton;
    public ACBindings.Internal.UIElement_Button* m_pClothesButton;
    public ACBindings.Internal.UIElement_Button* m_pZoomInButton;
    public ACBindings.Internal.UIElement_Button* m_pZoomOutButton;
    public ACBindings.Internal.UIElement_Button* m_pRotateClockButton;
    public ACBindings.Internal.UIElement_Button* m_pRotateCounterClockButton;
    public ACBindings.Internal.UIElement_Button* m_pHairSpin;
    public ACBindings.Internal.UIElement_Button* m_pEyesSpin;
    public ACBindings.Internal.UIElement_Button* m_pNoseSpin;
    public ACBindings.Internal.UIElement_Button* m_pMouthSpin;
    public ACBindings.Internal.UIElement_Button* m_pSkinSpin;
    public ACBindings.Internal.UIElement_Button* m_pHeadgearSpin;
    public ACBindings.Internal.UIElement_Button* m_pShirtSpin;
    public ACBindings.Internal.UIElement_Button* m_pTrousersSpin;
    public ACBindings.Internal.UIElement_Button* m_pFootwearSpin;
    public ACBindings.Internal.UIElement_Scrollbar* m_pShadeScroll;
    public ACBindings.Internal.UIElement* m_pFaceChoices;
    public ACBindings.Internal.UIElement* m_pClothesChoices;
    public ACBindings.Internal.UIElement* m_pGradCircle;
    public ACBindings.Internal.Graphic* m_pGradGraphic;
    public ACBindings.Internal.Graphic* m_pGradPlug;
    public ACBindings.Internal.UIElement* m_pCurSelection;
    public ACBindings.Internal.UIElement_Viewport* m_pViewport;
    public ACBindings.Internal.gmCG3DView* m_p3DView;
    public int m_iCurColor;
    public int m_iPartIndex;
    public int m_iHoldheadgear;
    public byte m_bShouldZoomAnimate;
    public byte m_bRotating;
    public byte m_bZoomedIn;
    public ACBindings.Internal.AC1Legacy.Vector3 m_vectTargPosition;
    public ACBindings.Internal.AC1Legacy.Vector3 m_vectStartPosition;
    public ACBindings.Internal.AC1Legacy.Vector3 m_vectCurPosition;
    public ACBindings.Internal.AC1Legacy.Vector3 m_vectTargDirection;
    public ACBindings.Internal.AC1Legacy.Vector3 m_vectStartDirection;
    public ACBindings.Internal.AC1Legacy.Vector3 m_vectCurDirection;
    public float m_fCurHeading;
    public float m_fTargHeading;
    public double m_dAnimStartTime;
    public double m_dAnimDuration;
    public double m_dLastRotateTime;
    public double m_dRotationPerSec;
    public uint m_LastHeritageGroup;
    public ACBindings.Internal.gmCGAppearancePage.ERotateDirection m_eRotateDir;
    public ACBindings.Internal.gmCGAppearancePage.EType m_eCurType;
    public fixed byte m_tChoices_Raw[216];
    public ACBindings.Internal.gmCGAppearancePage.tagChoices* m_tChoices => (ACBindings.Internal.gmCGAppearancePage.tagChoices*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_tChoices_Raw[0]);
    public ACBindings.Internal.gmCGAppearancePage.EParts m_eCurPart;
    public fixed byte m_tColorWheel_Raw[252];
    public ACBindings.Internal.gmCGAppearancePage.tagColorWheel* m_tColorWheel => (ACBindings.Internal.gmCGAppearancePage.tagColorWheel*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_tColorWheel_Raw[0]);
    public ACBindings.Internal.gmCGAppearancePage.EGender m_eGender;

    // Generated Constructor
    public gmCGAppearancePage(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>Initializes the appearance page by setting up its base UI components and registering event handlers for character appearance updates.
    /// <code>Offset: 0x0047CB80
    /// void __thiscall gmCGAppearancePage::PostInit(gmCGAppearancePage*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047CB80)(ref this);

    /// <summary>Attempts to cast a gmCGAppearancePage instance to the requested UI element type, returning a pointer to the appropriate UIElement or null if the type is unsupported.
    /// <code>Offset: 0x0047CBC0
    /// UIElement* __thiscall gmCGAppearancePage::DynamicCast(gmCGAppearancePage*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the desired UI element type for the cast.</param>
    /// <returns>A UIElement pointer corresponding to the requested type, or null when the conversion cannot be performed.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, uint, ACBindings.Internal.UIElement*>)0x0047CBC0)(ref this, i_eType);

    /// <summary>Provides the identifier for the UI element type of this appearance page.
    /// <code>Offset: 0x0047CBE0
    /// unsigned int __thiscall gmCGAppearancePage::GetUIElementType(gmCGAppearancePage*)</code>
    /// </summary>
    /// <returns>Unsigned integer denoting the UI element type (currently fixed to 268435516).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, uint>)0x0047CBE0)(ref this);

    /// <summary>Handles a player object description change notification by updating the 3D view when the corresponding UI element is visible.
    /// <code>Offset: 0x0047CBF0
    /// void __thiscall gmCGAppearancePage::RecvNotice_PlayerObjDescChanged(gmCGAppearancePage*)</code>
    /// </summary>
    public void RecvNotice_PlayerObjDescChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047CBF0)(ref this);

    /// <summary>Applies the supplied shade value to the currently selected character part and updates the 3‑D preview if the appearance page is visible.
    /// <code>Offset: 0x0047CC10
    /// void __thiscall gmCGAppearancePage::SetShade(gmCGAppearancePage*,long double)</code>
    /// </summary>
    /// <param name="dShade">The numeric shade level to apply to the current body part, represented as a long double.</param>
    public void SetShade(double dShade) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, double, void>)0x0047CC10)(ref this, dShade);

    /// <summary>Interpolates the camera’s position and orientation from a start state to a target state over a set duration, updating the view each frame until the target is reached.
    /// <code>Offset: 0x0047CD10
    /// void __thiscall gmCGAppearancePage::DoZoomAnimation(gmCGAppearancePage*)</code>
    /// </summary>
    public void DoZoomAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047CD10)(ref this);

    /// <summary>Updates the character’s viewing angle in the 3D appearance page, rotating it smoothly based on elapsed time and the selected direction.
    /// <code>Offset: 0x0047CE30
    /// void __thiscall gmCGAppearancePage::DoRotation(gmCGAppearancePage*)</code>
    /// </summary>
    public void DoRotation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047CE30)(ref this);

    /// <summary>Starts or stops rotation of the character preview based on the supplied direction. If a rotation is already active in that direction, calling this function will cancel it; otherwise it initiates a new rotation.
    /// <code>Offset: 0x0047CF00
    /// void __thiscall gmCGAppearancePage::Rotate(gmCGAppearancePage*,gmCGAppearancePage::ERotateDirection)</code>
    /// </summary>
    /// <param name="eDir">The rotation direction to apply—clockwise or counter‑clockwise.</param>
    public void Rotate(ACBindings.Internal.gmCGAppearancePage.ERotateDirection eDir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, ACBindings.Internal.gmCGAppearancePage.ERotateDirection, void>)0x0047CF00)(ref this, eDir);

    /// <summary>Creates the character appearance page, initializing its base UI element and preparing internal state such as color wheels, choice lists, and view parameters. Resets all button pointers to null and sets the default part selection.
    /// <code>Offset: 0x0047D070
    /// void __thiscall gmCGAppearancePage::gmCGAppearancePage(gmCGAppearancePage*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining dimensions and elements for the appearance page.</param>
    /// <param name="full_desc">Element descriptor containing properties for the root UI element.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0047D070)(ref this, layout, full_desc);

    /// <summary>Creates a gmCGAppearancePage instance configured by layout and full_desc, initializing its UIElement base.
    /// <code>Offset: 0x0047D250
    /// UIElement* __cdecl gmCGAppearancePage::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout description containing display dimensions and element table.</param>
    /// <param name="full_desc">Full element descriptor hierarchy used to build the UI structure.</param>
    /// <returns>Pointer to the created UIElement representing the appearance page, or nullptr if memory allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0047D250)(layout, full_desc);

    /// <summary>Responds to a global update message by executing queued zoom and rotation actions if enabled.
    /// <code>Offset: 0x0047D280
    /// void __thiscall gmCGAppearancePage::ListenToGlobalMessage(gmCGAppearancePage*,unsigned int,int)</code>
    /// </summary>
    /// <param name="messageID">Identifier of the received global message; only ID 3 triggers processing.</param>
    /// <param name="data_int">Additional data attached to the message (unused in this handler).</param>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, uint, int, void>)0x0047D280)(ref this, messageID, data_int);

    /// <summary>Starts a zoom‑in animation for the character view if it is not already zoomed in; otherwise disables the zoom‑in button. The target position and direction are set according to the player’s heritage group, and any ongoing animations are stopped before marking the view as zoomed in.
    /// <code>Offset: 0x0047D2B0
    /// void __thiscall gmCGAppearancePage::ZoomIn(gmCGAppearancePage*)</code>
    /// </summary>
    public void ZoomIn() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047D2B0)(ref this);

    /// <summary>Switches the character preview from a zoomed‑in view back to its default position and orientation, initiating an animated transition based on the selected heritage group.
    /// <code>Offset: 0x0047D400
    /// void __thiscall gmCGAppearancePage::ZoomOut(gmCGAppearancePage*)</code>
    /// </summary>
    public void ZoomOut() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047D400)(ref this);

    /// <summary>Registers the gmCGAppearancePage element type with the UI framework, enabling dynamic creation of appearance page instances.
    /// <code>Offset: 0x0047D840
    /// void __cdecl gmCGAppearancePage::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0047D840)();

    /// <summary>Switches the active appearance section to either face or clothes, updating UI controls and character state accordingly.
    /// <code>Offset: 0x0047D860
    /// void __thiscall gmCGAppearancePage::SetChoice(gmCGAppearancePage*,gmCGAppearancePage::EType)</code>
    /// </summary>
    /// <param name="eType">The type of choice to activate (face or clothing). </param>
    public void SetChoice(ACBindings.Internal.gmCGAppearancePage.EType eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, ACBindings.Internal.gmCGAppearancePage.EType, void>)0x0047D860)(ref this, eType);

    /// <summary>Refreshes the color wheel UI for a specified body part by updating each spot's graphic with current RGBA values, retrieving appropriate textures from the database and applying color replacements when necessary.
    /// <code>Offset: 0x0047DC00
    /// void __thiscall gmCGAppearancePage::DoColorSpots(gmCGAppearancePage*,int)</code>
    /// </summary>
    /// <param name="iPart">Index of the character part whose color wheel is being updated (0‑based).</param>
    public void DoColorSpots(int iPart) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, int, void>)0x0047DC00)(ref this, iPart);

    /// <summary>Updates the gradient disk UI element by loading required textures, creating graphics if needed, applying the currently selected color, and optionally rendering a plug texture.
    /// <code>Offset: 0x0047DE40
    /// void __thiscall gmCGAppearancePage::DoGradDisk(gmCGAppearancePage*,bool)</code>
    /// </summary>
    /// <param name="bUsePlug">If true, uses the plug texture for the disk; otherwise applies the current color to the base gradient graphic.</param>
    public void DoGradDisk(byte bUsePlug) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, byte, void>)0x0047DE40)(ref this, bUsePlug);

    /// <summary>Updates the currently selected color for the active part of the character and refreshes UI elements and the 3D preview accordingly.
    /// <code>Offset: 0x0047E100
    /// void __thiscall gmCGAppearancePage::SetColor(gmCGAppearancePage*,int)</code>
    /// </summary>
    /// <param name="iColor">Index of the new color; a value of -1 disables color selection.</param>
    public void SetColor(int iColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, int, void>)0x0047E100)(ref this, iColor);

    /// <summary>Initializes appearance choice data structures to match the current character generation state, configuring available options and selected values for hair, eyes, nose, mouth, headgear, shirt, trousers, and footwear.
    /// <code>Offset: 0x0047E3D0
    /// void __thiscall gmCGAppearancePage::SetupParts(gmCGAppearancePage*)</code>
    /// </summary>
    /// <param name="this">The gmCGAppearancePage instance whose parts are being set up.</param>
    public void SetupParts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047E3D0)(ref this);

    /// <summary>Sets the active appearance component for the character creator, loading available colors, updating the color wheel, and adjusting shade controls and gradient display based on the selected part.
    /// <code>Offset: 0x0047E610
    /// void __thiscall gmCGAppearancePage::SetSelection(gmCGAppearancePage*,gmCGAppearancePage::EParts)</code>
    /// </summary>
    /// <param name="ePart">Body part enumeration indicating which component to activate (hair, eyes, nose, mouth, skin, headgear, shirt, trousers, or footwear).</param>
    public void SetSelection(ACBindings.Internal.gmCGAppearancePage.EParts ePart) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, ACBindings.Internal.gmCGAppearancePage.EParts, void>)0x0047E610)(ref this, ePart);

    /// <summary>Updates the appearance UI and 3D view according to the current character generation state, adjusting button states, text labels, camera targets, and animation playback based on gender, heritage group, and selected part.
    /// <code>Offset: 0x0047ECA0
    /// void __thiscall gmCGAppearancePage::Update(gmCGAppearancePage*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047ECA0)(ref this);

    /// <summary>Processes UI element messages for the character appearance page, updating selections, colors, rotation, zoom and gender based on button actions.
    /// <code>Offset: 0x0047F2E0
    /// UIElementMessageListenResult __thiscall gmCGAppearancePage::ListenToElementMessage(gmCGAppearancePage*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">The message information sent by a UI element, containing identifiers for the source element and action performed.</param>
    /// <returns>The <c>UIElementMessageListenResult</c> produced by the base element listener after handling the message.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0047F2E0)(ref this, i_rMsg);

    /// <summary>Initializes the appearance page by linking UI controls to internal members, configuring the 3D view camera based on character heritage, setting default selections, and updating gender‑specific settings.
    /// <code>Offset: 0x00480180
    /// void __thiscall gmCGAppearancePage::InitializePage(gmCGAppearancePage*,gmCharGenMainUI*)</code>
    /// </summary>
    /// <param name="pMain">Reference to the main character generation UI framework used for retrieving shared resources and state.</param>
    public void InitializePage(ACBindings.Internal.gmCharGenMainUI* pMain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, ACBindings.Internal.gmCharGenMainUI*, void>)0x00480180)(ref this, pMain);
}

