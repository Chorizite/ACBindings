namespace ACBindings;

// ACSmartBox
public unsafe struct ACSmartBox
{
    // Base Classes
    public ACBindings.SmartBox BaseClass_SmartBox; // ACBindings.SmartBox

    // Child Types
    // ACSmartBox_vtbl
    public unsafe struct ACSmartBox_vtbl
    {
        // Members
        public System.IntPtr ACSmartBox_dtor_0; // function pointer
        public System.IntPtr IsReadyToDispatchEvent; // function pointer
        public System.IntPtr DispatchSmartBoxEvent; // function pointer

        // Methods
    }

    // Methods
    // int __thiscall ACSmartBox::IsReadyToDispatchEvent(ACSmartBox*,NetBlob*)
    public int IsReadyToDispatchEvent(ACBindings.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACSmartBox, ACBindings.NetBlob*, int>)0x0055A1D0)(ref this, blob);
    // NetBlobProcessedStatus __thiscall ACSmartBox::DispatchSmartBoxEvent(ACSmartBox*,NetBlob*)
    public ACBindings.NetBlobProcessedStatus DispatchSmartBoxEvent(ACBindings.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACSmartBox, ACBindings.NetBlob*, ACBindings.NetBlobProcessedStatus>)0x0055A210)(ref this, blob);
}

