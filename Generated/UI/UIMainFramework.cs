namespace ACBindings.Internal;


/// <summary>Manages root UI elements within the UI framework, providing creation, registration, and removal of top‑level components while inheriting core UI behavior from UIFramework.</summary>
public unsafe struct UIMainFramework : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIFramework BaseClass_UIFramework; // ACBindings.Internal.UIFramework

    // Child Types
    public unsafe struct UIMainFramework_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, void> UIMainFramework_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, byte> Shown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, byte, void> ForceHidden; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, void> Update; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___UIElement_ptr m_rootElements;

    // Generated Constructor
    public UIMainFramework() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Creates a new root UI element using the specified layout enumeration and element identifier, adding it to the framework’s root elements collection.
    /// <code>Offset: 0x006A1A20
    /// UIElement* __thiscall UIMainFramework::CreateAndAddRootElement(UIMainFramework*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="layoutEnum">Enumeration value identifying the desired layout for the new element.</param>
    /// <param name="elementID">Identifier used to distinguish the created element within the framework.</param>
    /// <returns>Pointer to the newly created UIElement if the layout is valid; otherwise, null.</returns>
    public ACBindings.Internal.UIElement* CreateAndAddRootElement(uint layoutEnum, uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIMainFramework, uint, uint, ACBindings.Internal.UIElement*>)0x006A1A20)(ref this, layoutEnum, elementID);

    /// <summary>Removes a specified root UI element from the framework, unregistering its message handlers and deleting it if required, then clears the caller's reference.
    /// <code>Offset: 0x006A1A60
    /// void __thiscall UIMainFramework::RemoveRootElement(UIMainFramework*,UIElement**)</code>
    /// </summary>
    /// <param name="element">Pointer to the root UIElement to be removed; will be set to null after removal.</param>
    public void RemoveRootElement(ACBindings.Internal.UIElement** element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIMainFramework, ACBindings.Internal.UIElement**, void>)0x006A1A60)(ref this, element);

    /// <summary>Constructs a new UI main framework instance, initializing its base UIFramework and clearing the root element collection.
    /// <code>Offset: 0x006A1AB0
    /// void __thiscall UIMainFramework::UIMainFramework(UIMainFramework*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIMainFramework, void>)0x006A1AB0)(ref this);

    /// <summary>Cleans up UI framework resources by resetting the dialog factory, freeing any allocated root element data, and invoking the base UIFramework destructor.
    /// <code>Offset: 0x006A1AE0
    /// void __thiscall UIMainFramework::~UIMainFramework(UIMainFramework*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIMainFramework, void>)0x006A1AE0)(ref this);

    /// <summary>Creates a root UI element from a data ID, registers it with a listener, and records the registration so the listener receives element messages.
    /// <code>Offset: 0x006A1B70
    /// UIElement* __thiscall UIMainFramework::CreateAndAddRootElementByDataID(UIListener*,int,unsigned int)</code>
    /// </summary>
    /// <param name="i_pListener">Listener to receive element notifications for the new element.</param>
    /// <param name="a2">Identifier used by the element manager to locate and instantiate the root element definition.</param>
    /// <param name="a3">Optional parameter passed to the element manager (often a flag or secondary identifier); may be ignored if element creation fails.</param>
    /// <returns>Pointer to the created UIElement, or nullptr if creation failed.</returns>
    public ACBindings.Internal.UIElement* CreateAndAddRootElementByDataID(int a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIMainFramework, int, uint, ACBindings.Internal.UIElement*>)0x006A1B70)(ref this, a2, a3);
}

