namespace ACBindings.Internal;


/// <summary>Manages a user interface component within the application, handling visibility state and containing child elements for hierarchical layout.</summary>
public unsafe struct UIFramework : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIListener BaseClass_UIListener; // ACBindings.Internal.UIListener

    // Child Types
    public unsafe struct UIFramework_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, void> UIFramework_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, byte> Shown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, byte, void> ForceHidden; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer

        // Methods
    }

    // Members
    public byte m_bCanForceHide;
    public byte m_bIsForcedHidden;
    public byte m_shown;
    public ACBindings.Internal.SmartArray___UIChildFramework_ptr m_children;

    // Generated Constructor
    public UIFramework() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Determines whether the UI framework is currently displayed, accounting for forced hide state.
    /// <code>Offset: 0x004E7AE0
    /// bool __thiscall UIFramework::Shown(UIFramework*)</code>
    /// </summary>
    /// <returns>True if the framework is marked as shown and is not forcefully hidden; otherwise, false.</returns>
    public byte Shown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, byte>)0x004E7AE0)(ref this);

    /// <summary>Retrieves the UIPersistantData object associated with the UI framework instance, providing access to persisted configuration such as selected avatar and character set.
    /// <code>Offset: 0x006A1730
    /// UIPersistantData* __thiscall UIFramework::GetPersistantData(UIFramework*)</code>
    /// </summary>
    /// <returns>A pointer to the persistent data structure used by the framework.</returns>
    public ACBindings.Internal.UIPersistantData* GetPersistantData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, ACBindings.Internal.UIPersistantData*>)0x006A1730)(ref this);

    /// <summary>Queues a transition to the specified UI mode through the global UI flow controller.
    /// <code>Offset: 0x006A1740
    /// void __thiscall UIFramework::QueueUIMode(UIFramework*,const unsigned int)</code>
    /// </summary>
    /// <param name="newMode">Identifier of the UI mode to be queued.</param>
    public void QueueUIMode(uint newMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, uint, void>)0x006A1740)(ref this, newMode);

    /// <summary>Shows or hides the UI framework and its children according to visibility rules.
    /// <code>Offset: 0x006A1750
    /// void __thiscall UIFramework::Show(UIFramework*,bool)</code>
    /// </summary>
    /// <param name="shown">True to display the framework; false to hide it.</param>
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, byte, void>)0x006A1750)(ref this, shown);

    /// <summary>Forces the framework and all child components into a hidden or visible state based on the supplied flag, updating internal state and notifying child elements of focus changes.
    /// <code>Offset: 0x006A17C0
    /// void __thiscall UIFramework::ForceHidden(UIFramework*,bool)</code>
    /// </summary>
    /// <param name="hide">True to hide the framework and its children; false to restore visibility.</param>
    public void ForceHidden(byte hide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, byte, void>)0x006A17C0)(ref this, hide);

    /// <summary>Finds the zero‑based index of a specified child framework within the caller's children collection, returning –1 when the child is absent.
    /// <code>Offset: 0x006A1830
    /// int __thiscall UIFramework::FindChild(UIFramework*,UIChildFramework*)</code>
    /// </summary>
    /// <param name="child">The child framework to locate.</param>
    /// <returns>The child’s index in the children array or –1 if not found.</returns>
    public int FindChild(ACBindings.Internal.UIChildFramework* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, ACBindings.Internal.UIChildFramework*, int>)0x006A1830)(ref this, child);

    /// <summary>Propagates an element message to child frameworks until one handles it or all have been queried.
    /// <code>Offset: 0x006A1860
    /// UIElementMessageListenResult __thiscall UIFramework::ListenToElementMessage(UIFramework*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information containing target element, parameters and coordinates.</param>
    /// <returns>A <c>UIElementMessageListenResult</c> value: <c>lrHandled (2)</c> if a child handled the message; otherwise returns the last non‑default result reported by a child, or <c>lrDefault</c> if none did.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x006A1860)(ref this, i_rMsg);

    /// <summary>Removes a child UI framework from this UIFramework after invoking its OnLoseFocus callback.
    /// <code>Offset: 0x006A18B0
    /// void __thiscall UIFramework::RemoveChild(UIFramework*,UIChildFramework*)</code>
    /// </summary>
    /// <param name="child">The child framework to be removed.</param>
    public void RemoveChild(ACBindings.Internal.UIChildFramework* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, ACBindings.Internal.UIChildFramework*, void>)0x006A18B0)(ref this, child);

    /// <summary>Constructs a UI framework instance, initializing visibility state and child collection.
    /// <code>Offset: 0x006A1900
    /// void __thiscall UIFramework::UIFramework(UIFramework*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, void>)0x006A1900)(ref this);

    /// <summary>Destroys a UIFramework instance by releasing its child frameworks and invoking the base UIListener destructor, ensuring proper cleanup of resources.
    /// <code>Offset: 0x006A1930
    /// void __thiscall UIFramework::~UIFramework(UIFramework*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, void>)0x006A1930)(ref this);

    /// <summary>Adds the specified child UI framework element to this framework’s collection, allocating additional storage if necessary and invoking focus handling prior to insertion.
    /// <code>Offset: 0x006A19C0
    /// void __thiscall UIFramework::AddChild(UIFramework*,UIChildFramework*)</code>
    /// </summary>
    /// <param name="child">The UIChildFramework instance to add as a child of this framework.</param>
    public void AddChild(ACBindings.Internal.UIChildFramework* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, ACBindings.Internal.UIChildFramework*, void>)0x006A19C0)(ref this, child);
}

