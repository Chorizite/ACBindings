namespace ACBindings;

// DialogBoxGateway
public unsafe struct DialogBoxGateway : System.IDisposable
{
    // Base Classes
    public ACBindings.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.CPluginPrototype

    // Child Types
    // DialogBoxGateway_vtbl
    public unsafe struct DialogBoxGateway_vtbl
    {
        // Members
        public System.IntPtr DialogBoxGateway_dtor_0; // function pointer
        public System.IntPtr OnPluggedIn; // function pointer
        public System.IntPtr OnDialogBoxBegin; // function pointer
        public System.IntPtr OnDialogBoxEnd; // function pointer
        public System.IntPtr ReportThread_OnDialogBoxBegin; // function pointer
        public System.IntPtr ReportThread_OnDialogBoxEnd; // function pointer
        public System.IntPtr DialogThread_OnDialogBoxBegin; // function pointer
        public System.IntPtr DialogThread_OnDialogBoxEnd; // function pointer

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
    // void __thiscall DialogBoxGateway::~DialogBoxGateway(DialogBoxGateway*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DialogBoxGateway, void>)0x0040E6E0)(ref this);
    // DialogBoxGateway::ThisFunctionHasBeenRenamed __thiscall DialogBoxGateway::OnDialogBoxEnd(DialogBoxGateway*,bool)
    public ACBindings.DialogBoxGateway.ThisFunctionHasBeenRenamed OnDialogBoxEnd(byte formal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DialogBoxGateway, byte, ACBindings.DialogBoxGateway.ThisFunctionHasBeenRenamed>)0x0040E720)(ref this, formal);
    // bool __thiscall DialogBoxGateway::DialogThread_OnDialogBoxBegin(DialogBoxGateway*)
    public byte DialogThread_OnDialogBoxBegin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DialogBoxGateway, byte>)0x0040E730)(ref this);
    // void __thiscall DialogBoxGateway::DialogBoxGateway(DialogBoxGateway*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DialogBoxGateway, void>)0x0040E790)(ref this);
}

