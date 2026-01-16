namespace ACBindings.Internal;


/// <summary>
///     Manages dialog boxes through plugin registration, offering hooks for beginning and completion events.
///     Acts as a gateway between the UI layer and the underlying plugin infrastructure.
/// </summary>
public unsafe struct DialogBoxGateway : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.Internal.CPluginPrototype

    // Child Types
    public unsafe struct DialogBoxGateway_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DialogBoxGateway*, void> DialogBoxGateway_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DialogBoxGateway*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DialogBoxGateway*, ACBindings.Internal.DialogBoxGateway.ThisFunctionHasBeenRenamed> OnDialogBoxBegin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DialogBoxGateway*, byte, ACBindings.Internal.DialogBoxGateway.ThisFunctionHasBeenRenamed> OnDialogBoxEnd; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DialogBoxGateway*, byte> ReportThread_OnDialogBoxBegin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DialogBoxGateway*, byte, void> ReportThread_OnDialogBoxEnd; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DialogBoxGateway*, byte> DialogThread_OnDialogBoxBegin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DialogBoxGateway*, byte, void> DialogThread_OnDialogBoxEnd; // function pointer

        // Methods
    }
    // DialogBoxGateway::ThisFunctionHasBeenRenamed
    public enum ThisFunctionHasBeenRenamed : uint
    {
    }

    // Generated Constructor
    public DialogBoxGateway() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Removes the dialog box gateway prototype from any registered plugin manager and restores its base class to the default state before object destruction.
    /// <code>Offset: 0x0040E6E0
    /// void __thiscall DialogBoxGateway::~DialogBoxGateway(DialogBoxGateway*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DialogBoxGateway, void>)0x0040E6E0)(ref this);

    /// <summary>Handles the conclusion of a dialog box, signaling completion and returning a status code.
    /// <code>Offset: 0x0040E720
    /// DialogBoxGateway::ThisFunctionHasBeenRenamed __thiscall DialogBoxGateway::OnDialogBoxEnd(DialogBoxGateway*,bool)</code>
    /// </summary>
    /// <param name="formal">True if the dialog was closed with an affirmative action (e.g., OK); otherwise false for cancellation or dismissal.</param>
    /// <returns>An integer status code; currently always zero to indicate successful termination.</returns>
    public ACBindings.Internal.DialogBoxGateway.ThisFunctionHasBeenRenamed OnDialogBoxEnd(byte formal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DialogBoxGateway, byte, ACBindings.Internal.DialogBoxGateway.ThisFunctionHasBeenRenamed>)0x0040E720)(ref this, formal);

    /// <summary>Indicates that a dialog thread did not begin successfully.
    /// <code>Offset: 0x0040E730
    /// bool __thiscall DialogBoxGateway::DialogThread_OnDialogBoxBegin(DialogBoxGateway*)</code>
    /// </summary>
    /// <param name="this">The DialogBoxGateway instance invoking the event.</param>
    /// <returns>false (always).</returns>
    public byte DialogThread_OnDialogBoxBegin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DialogBoxGateway, byte>)0x0040E730)(ref this);

    /// <summary>Constructs a DialogBoxGateway instance, initializing its plugin prototype and registering it with the global plugin manager.
    /// <code>Offset: 0x0040E790
    /// void __thiscall DialogBoxGateway::DialogBoxGateway(DialogBoxGateway*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DialogBoxGateway, void>)0x0040E790)(ref this);
}

