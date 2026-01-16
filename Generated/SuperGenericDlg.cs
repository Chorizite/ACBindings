namespace ACBindings.Internal;


/// <summary>Handles the presentation and interaction logic for generic dialogs, including optional email prompts, button configuration, timeout handling, and state tracking of user actions.</summary>
public unsafe struct SuperGenericDlg
{
    // Child Types
    public unsafe struct SuperGenericDlg_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SuperGenericDlg*, int> Create; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.GenericDialogTextObject* pTitle;
    public ACBindings.Internal.GenericDialogTextObject* pText;
    public ACBindings.Internal.GenericDialogTextObject* pEmailTitle;
    public ACBindings.Internal.GenericDialogTextObject* pEmailText;
    public ACBindings.Internal.PStringBase__sbyte EmailAddress;
    public byte bAllowSendEmail;
    public fixed byte Buttons_Raw[40];
    public ACBindings.Internal.PStringBase__sbyte* Buttons => (ACBindings.Internal.PStringBase__sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref Buttons_Raw[0]);
    public int nButtons;
    public int TimeoutMS;
    public int idxCancelBtn;
    public int idxButtonChosen;
    public byte bEmailSent;
    public byte bTimedOut;

    // Methods
}

