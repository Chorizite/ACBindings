namespace ACBindings.Internal;


/// <summary>Provides the user interface framework that displays game credits, managing scrolling text and sequentially shown pictures with timed transitions. Handles creation of credit elements, updates their positions, and coordinates waiting dialogs during transition periods.</summary>
public unsafe struct gmCreditsUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.gmUIMainFramework BaseClass_gmUIMainFramework; // ACBindings.Internal.gmUIMainFramework

    // Child Types
    public unsafe struct gmCreditsUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, void> gmCreditsUI_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, byte> Shown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, byte, void> ForceHidden; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, void> Update; // function pointer

        // Methods
    }

    // Members
    public uint m_waitContext;
    public int m_lastPicture;
    public int m_lastX;
    public int m_lastY;
    public ACBindings.Internal.BaseProperty m_pictureProp;
    public uint m_numPictures;
    public float m_duration;
    public double m_endTime;
    public ACBindings.Internal.SmartArray___UIElement_ptr m_aPictureElements;
    public ACBindings.Internal.UIElement* m_pictureField;
    public ACBindings.Internal.UIElement* m_textField;
    public ACBindings.Internal.UIElement_Text* m_textArea;
    public byte m_alternate;

    // Generated Constructor
    public gmCreditsUI() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Responds to global UI messages by invoking the base framework’s action handler when a message with ID 3 is received.
    /// <code>Offset: 0x004E7AD0
    /// void __thiscall gmCreditsUI::ListenToGlobalMessage(gmCreditsUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="messageID">The identifier of the global message being processed.</param>
    /// <param name="data_int">An additional integer value supplied with the message (unused in this implementation).</param>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, uint, int, void>)0x004E7AD0)(ref this, messageID, data_int);

    /// <summary>Retrieves the next picture identifier for the credits UI sequence, cycling through available pictures and handling reference counts.
    /// <code>Offset: 0x004E7B00
    /// IDClass&lt;_tagDataID,32,0&gt;* __thiscall gmCreditsUI::GetNextPictureID(_DWORD*,IDClass&lt;_tagDataID,32,0&gt;*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an IDClass structure that receives the next picture ID; if no pictures remain its id field is set to INVALID_DID_174.</param>
    /// <returns>The same pointer passed in as a2, now containing the retrieved picture ID or an invalid ID when none are available.</returns>
    public ACBindings.Internal.IDClass____tagDataID* GetNextPictureID(ACBindings.Internal.IDClass____tagDataID* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, ACBindings.Internal.IDClass____tagDataID*, ACBindings.Internal.IDClass____tagDataID*>)0x004E7B00)(ref this, a2);

    /// <summary>Releases all resources held by the credits UI, removing its picture and text fields from the root element list, clearing internal arrays of picture elements, closing any pending wait dialogs, and decrementing reference counts on associated property descriptors and values before invoking the base framework destructor.
    /// <code>Offset: 0x004E7C50
    /// void __thiscall gmCreditsUI::~gmCreditsUI(gmCreditsUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, void>)0x004E7C50)(ref this);

    /// <summary>Initializes the credits UI by loading each credit line into the text area, configuring scrolling parameters, computing the display duration based on content size, registering focus handling, and initiating picture animations.
    /// <code>Offset: 0x004E7D30
    /// void __thiscall gmCreditsUI::Initialize(gmCreditsUI*)</code>
    /// </summary>
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, void>)0x004E7D30)(ref this);

    /// <summary>Constructs the credits UI framework, initializing internal state, creating picture and text fields, obtaining a reference to the text area element, and registering a delayed input action callback.
    /// <code>Offset: 0x004E7FA0
    /// void __thiscall gmCreditsUI::gmCreditsUI(gmCreditsUI*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, void>)0x004E7FA0)(ref this);

    /// <summary>Creates a new gmCreditsUI instance and returns it as a UIMainFramework pointer.
    /// <code>Offset: 0x004E8170
    /// UIMainFramework* __cdecl gmCreditsUI::Create()</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed UIMainFramework, or null if memory allocation fails.</returns>
    public static ACBindings.Internal.UIMainFramework* Create() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIMainFramework*>)0x004E8170)();

    /// <summary>Registers the credits user interface framework with the UI flow system using the specified mode.
    /// <code>Offset: 0x004E8190
    /// void __cdecl gmCreditsUI::Register(unsigned int)</code>
    /// </summary>
    /// <param name="mode">Specifies how the Credits UI should be registered within the flow manager (e.g., normal, modal).</param>
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004E8190)(mode);

    /// <summary>Creates a new credit picture UI element, assigns the next available picture ID, positions it relative to previous pictures, loads the associated media image, and registers the element in the credits UI’s internal collection.
    /// <code>Offset: 0x004E81B0
    /// void __thiscall gmCreditsUI::CreateAndAddPicture(gmCreditsUI*)</code>
    /// </summary>
    public void CreateAndAddPicture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, void>)0x004E81B0)(ref this);

    /// <summary>Scrolls credit images vertically within the credits UI by a specified pixel offset, removing any that scroll off the top of the visible area and adding new images at the bottom to maintain continuous scrolling.
    /// <code>Offset: 0x004E82A0
    /// void __thiscall gmCreditsUI::ScrollPictures(gmCreditsUI*,int)</code>
    /// </summary>
    /// <param name="pixels">Number of pixels by which each picture element is moved vertically; positive values scroll pictures upward, negative values scroll downward.</param>
    public void ScrollPictures(int pixels) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, int, void>)0x004E82A0)(ref this, pixels);

    /// <summary>Create a waiting dialog for the credits UI by configuring property collection and invoking DialogFactory, storing resulting context in m_waitContext.
    /// <code>Offset: 0x004E8380
    /// void __thiscall gmCreditsUI::MakePleaseWaitDialog(gmCreditsUI*)</code>
    /// </summary>
    public void MakePleaseWaitDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, void>)0x004E8380)(ref this);

    /// <summary>Scrolls the credits text area over a specified duration, adjusting its vertical position until fully scrolled. When scrolling completes, unregisters for global messages, shows a wait dialog, and queues a UI mode transition.
    /// <code>Offset: 0x004E84E0
    /// int __thiscall gmCreditsUI::ScrollText(gmCreditsUI*)</code>
    /// </summary>
    /// <returns>The screen Y coordinate of the text field after applying the scroll offset, or 0 if scrolling has finished and the credits sequence is complete.</returns>
    public int ScrollText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, int>)0x004E84E0)(ref this);

    /// <summary>Handles a user action within the credits UI by unregistering from global messages, displaying a “please wait” dialog, queuing a UI mode transition, and signaling successful completion.
    /// <code>Offset: 0x004E8630
    /// bool __thiscall gmCreditsUI::OnAction(gmCreditsUI*,const InputEvent*)</code>
    /// </summary>
    /// <param name="i_evt">The input event that triggered the action.</param>
    /// <returns>True after processing the event.</returns>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, ACBindings.Internal.InputEvent*, byte>)0x004E8630)(ref this, i_evt);

    /// <summary>Updates the credits interface by scrolling text and synchronizing picture transitions.
    /// <code>Offset: 0x004E8660
    /// void __thiscall gmCreditsUI::Update(gmCreditsUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, void>)0x004E8660)(ref this);
}

