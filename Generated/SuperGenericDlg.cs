namespace ACBindings;

// SuperGenericDlg
public unsafe struct SuperGenericDlg
{
    // Child Types
    // SuperGenericDlg_vtbl
    public unsafe struct SuperGenericDlg_vtbl
    {
        // Members
        public System.IntPtr Create; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.GenericDialogTextObject* pTitle;
    public ACBindings.GenericDialogTextObject* pText;
    public ACBindings.GenericDialogTextObject* pEmailTitle;
    public ACBindings.GenericDialogTextObject* pEmailText;
    public ACBindings.PStringBase__sbyte EmailAddress;
    public byte bAllowSendEmail;
    public fixed byte Buttons_Raw[40];
    public ACBindings.PStringBase__sbyte* Buttons => (ACBindings.PStringBase__sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref Buttons_Raw[0]);
    public int nButtons;
    public int TimeoutMS;
    public int idxCancelBtn;
    public int idxButtonChosen;
    public byte bEmailSent;
    public byte bTimedOut;

    // Methods
}

