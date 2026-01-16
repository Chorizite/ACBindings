namespace ACBindings.Internal;


/// <summary>Handles input callbacks for registered UI elements, maintaining a set of UIElement pointers and tracking the most recent input action via a timestamped serial number.</summary>
public unsafe struct UIListener : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback

    // Child Types
    public unsafe struct UIListener_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.HashSet___UIElement_ptr m_hashElementsRegisteredWith;
    public ACBindings.Internal.CTimestamp__uint m_tsSerialNumberLastListenedTo;

    // Generated Constructor
    public UIListener() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Registers this listener to receive notifications from the UI element identified by elementID for the specified messageID.
    /// <code>Offset: 0x00465F50
    /// void __thiscall UIListener::RegisterForElementMessage(UIListener*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="elementID">Identifier of the UI element to listen to.</param>
    /// <param name="messageID">Specific message type to subscribe to.</param>
    public void RegisterForElementMessage(uint elementID, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, uint, uint, void>)0x00465F50)(ref this, elementID, messageID);

    /// <summary>Stops the listener from receiving notifications of a specified message from a given UI element.
    /// <code>Offset: 0x00465F70
    /// void __thiscall UIListener::UnRegisterForElementMessage(UIListener*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="elementID">Identifier of the UI element to stop listening to.</param>
    /// <param name="messageID">Identifier of the message type to unregister from.</param>
    public void UnRegisterForElementMessage(uint elementID, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, uint, uint, void>)0x00465F70)(ref this, elementID, messageID);

    /// <summary>Registers the UIListener instance as a recipient for notifications of a given global message ID.
    /// <code>Offset: 0x00465F90
    /// void __thiscall UIListener::RegisterForGlobalMessage(UIListener*,unsigned int)</code>
    /// </summary>
    /// <param name="messageID">The identifier of the global message to listen for.</param>
    public void RegisterForGlobalMessage(uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, uint, void>)0x00465F90)(ref this, messageID);

    /// <summary>Removes the listener from receiving global notifications for the specified message identifier.
    /// <code>Offset: 0x00465FB0
    /// void __thiscall UIListener::UnRegisterForGlobalMessage(UIListener*,unsigned int)</code>
    /// </summary>
    /// <param name="messageID">The unique identifier of the message to stop listening to.</param>
    public void UnRegisterForGlobalMessage(uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, uint, void>)0x00465FB0)(ref this, messageID);

    /// <summary>
    /// Initializes the UIListener by setting up its virtual function table, preparing an empty hash set for registered UI elements, and resetting the last listened serial number timestamp to zero.
    /// 
    /// <code>Offset: 0x00466380
    /// void __thiscall UIListener::UIListener(UIListener*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, void>)0x00466380)(ref this);

    /// <summary>Destroys a UIListener instance by unregistering it from the global UI element manager, clearing its hash set of registered elements, releasing allocated bucket memory, resetting internal table state, restoring the base class vtable, and notifying ICIDM if present.
    /// <code>Offset: 0x004663B0
    /// void __thiscall UIListener::~UIListener(UIListener*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, void>)0x004663B0)(ref this);

    /// <summary>Registers the listener with a UI element by adding it to its internal set of registered elements.
    /// <code>Offset: 0x00466470
    /// void __thiscall UIListener::OnRegisteredWithElement(UIListener*,UIElement*)</code>
    /// </summary>
    /// <param name="i_pElement">The UI element that the listener is registering with.</param>
    public void OnRegisteredWithElement(ACBindings.Internal.UIElement* i_pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, ACBindings.Internal.UIElement*, void>)0x00466470)(ref this, i_pElement);

    /// <summary>Removes a UI element from the listener's registration set, freeing allocated memory when present.
    /// <code>Offset: 0x00466480
    /// void __thiscall UIListener::OnUnregisteredWithElement(UIListener*,UIElement*)</code>
    /// </summary>
    /// <param name="i_pElement">The UIElement that is being unregistered from this listener.</param>
    public void OnUnregisteredWithElement(ACBindings.Internal.UIElement* i_pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, ACBindings.Internal.UIElement*, void>)0x00466480)(ref this, i_pElement);
}

