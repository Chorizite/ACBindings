namespace ACBindings.Internal;


/// <summary>Manages creation, queuing, and lifecycle of UI dialogs within the application, coordinating callbacks, contexts, and display order.</summary>
public unsafe struct DialogFactory
{
    // Statics
    public static ACBindings.Internal.HashTable__uint___List___DialogInfo* s_hashDialogQueues = (ACBindings.Internal.HashTable__uint___List___DialogInfo*)0x00819DB0;
    public static ACBindings.Internal.HashTable__uint__void_ptr* s_hashCallbacks = (ACBindings.Internal.HashTable__uint__void_ptr*)0x00819F08;
    public static uint* s_globalContext = (uint*)0x0083E718;

    // Methods

    /// <summary>Determines whether a dialog is currently active for the specified queue identifier.
    /// <code>Offset: 0x00477460
    /// bool __cdecl DialogFactory::IsDialogOpen(unsigned int)</code>
    /// </summary>
    /// <param name="i_queueID">Identifier of the dialog queue; zero checks global state, one checks callbacks only, other values query specific callback entry.</param>
    /// <returns>True if a dialog matching the criteria is open; otherwise false.</returns>
    public static byte IsDialogOpen(uint i_queueID) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x00477460)(i_queueID);

    /// <summary>Finalizes a dialog by removing its context from internal tables, notifying the UI system to close it, and informing the owning components that focus has been lost. Cleans up any associated callbacks and deallocates resources when appropriate.
    /// <code>Offset: 0x004777C0
    /// void __cdecl DialogFactory::DialogDone(DialogInfo*)</code>
    /// </summary>
    /// <param name="i_info">The dialog information structure to be marked as complete.</param>
    public static void DialogDone(ACBindings.Internal.DialogInfo* i_info) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DialogInfo*, void>)0x004777C0)(i_info);

    /// <summary>Updates the display state of all pending dialogs by traversing internal queues and invoking each dialog’s update method when a matching queued entry exists.
    /// <code>Offset: 0x00477990
    /// void __cdecl DialogFactory::UpdatePendingDialogDisplay_()</code>
    /// </summary>
    public static void UpdatePendingDialogDisplay_() => ((delegate* unmanaged[Cdecl]<void>)0x00477990)();

    /// <summary>Resets the dialog factory by clearing all stored dialogs, queues and related hash table data.
    /// <code>Offset: 0x00477D50
    /// void __cdecl DialogFactory::Reset()</code>
    /// </summary>
    public static void Reset() => ((delegate* unmanaged[Cdecl]<void>)0x00477D50)();

    /// <summary>Creates a dialog from the supplied DialogInfo for the given queue ID, initializing its properties and ensuring only one instance per queue. If no dialog exists, constructs it, brings it to the foreground, updates pending display and notifies the UI system.
    /// <code>Offset: 0x00477ED0
    /// void __cdecl DialogFactory::CreateDialog_(const DialogInfo*,unsigned int)</code>
    /// </summary>
    /// <param name="info">Pointer to the DialogInfo describing the dialog to create.</param>
    /// <param name="queueID">Identifier selecting the callback or property collection for this dialog; zero results in no action.</param>
    public static void CreateDialog_(ACBindings.Internal.DialogInfo* info, uint queueID) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DialogInfo*, uint, void>)0x00477ED0)(info, queueID);

    /// <summary>Opens the next dialog in the specified queue, creating and displaying it if available.
    /// <code>Offset: 0x00478130
    /// void __cdecl DialogFactory::OpenNextDialog(unsigned int)</code>
    /// </summary>
    /// <param name="i_queueID">The identifier of the dialog queue to retrieve the next dialog from.</param>
    public static void OpenNextDialog(uint i_queueID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00478130)(i_queueID);

    /// <summary>Creates a UI dialog from property data, associates it with the specified parent framework, and enqueues or displays it immediately based on queue rules.
    /// <code>Offset: 0x00478290
    /// unsigned int __cdecl DialogFactory::MakeDialog(UIFramework*,const PropertyCollection*)</code>
    /// </summary>
    /// <param name="i_pcParent">Framework instance that will own the new dialog.</param>
    /// <param name="i_rcData">Collection of properties defining the dialog’s appearance, behavior, and queue information.</param>
    /// <returns>Identifier representing the global context used for the created dialog.</returns>
    public static uint MakeDialog(ACBindings.Internal.UIFramework* i_pcParent, ACBindings.Internal.PropertyCollection* i_rcData) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIFramework*, ACBindings.Internal.PropertyCollection*, uint>)0x00478290)(i_pcParent, i_rcData);

    /// <summary>Closes the dialog identified by the supplied context ID, removing it from active lists and releasing associated resources.
    /// <code>Offset: 0x00478560
    /// void __cdecl DialogFactory::CloseDialog(const unsigned int)</code>
    /// </summary>
    /// <param name="context">The unique identifier of the dialog to close.</param>
    public static void CloseDialog(uint context) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00478560)(context);

    /// <summary>Creates a dialog within the current UI context using supplied properties.
    /// <code>Offset: 0x00478810
    /// unsigned int __cdecl DialogFactory::MakeDialogInCurrentUI(const PropertyCollection*)</code>
    /// </summary>
    /// <param name="i_rcData">A pointer to a PropertyCollection containing configuration values for the dialog.</param>
    /// <returns>An unsigned int identifier representing the newly created dialog instance.</returns>
    public static uint MakeDialogInCurrentUI(ACBindings.Internal.PropertyCollection* i_rcData) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, uint>)0x00478810)(i_rcData);

    /// <summary>Creates a dialog in the current UI and records a callback for it.
    /// <code>Offset: 0x00478830
    /// unsigned int __cdecl DialogFactory::MakeCallbackDialogInCurrentUI(const PropertyCollection*,void (__cdecl*pFunc)(const PropertyCollection*))</code>
    /// </summary>
    /// <param name="i_rcData">Properties used to construct the dialog.</param>
    /// <param name="pFunc">Callback invoked when an event occurs for the created dialog.</param>
    /// <returns>The identifier of the created dialog, or zero if creation failed.</returns>
    public static uint MakeCallbackDialogInCurrentUI(ACBindings.Internal.PropertyCollection* i_rcData, delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void> pFunc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>, uint>)0x00478830)(i_rcData, pFunc);
}

