namespace ACBindings.Internal;

public unsafe struct ACSmartBox
{
    // Base Classes
    public ACBindings.Internal.SmartBox BaseClass_SmartBox; // ACBindings.Internal.SmartBox

    // Child Types
    public unsafe struct ACSmartBox_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACSmartBox*, void> ACSmartBox_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACSmartBox*, ACBindings.Internal.NetBlob*, int> IsReadyToDispatchEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACSmartBox*, ACBindings.Internal.NetBlob*, ACBindings.Internal.NetBlobProcessedStatus> DispatchSmartBoxEvent; // function pointer

        // Methods
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0055A1D0
    /// int __thiscall ACSmartBox::IsReadyToDispatchEvent(ACSmartBox*,NetBlob*)</code>
    /// </summary>
    public int IsReadyToDispatchEvent(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACSmartBox, ACBindings.Internal.NetBlob*, int>)0x0055A1D0)(ref this, blob);

    /// <summary>
    /// <code>Offset: 0x0055A210
    /// NetBlobProcessedStatus __thiscall ACSmartBox::DispatchSmartBoxEvent(ACSmartBox*,NetBlob*)</code>
    /// </summary>
    public ACBindings.Internal.NetBlobProcessedStatus DispatchSmartBoxEvent(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACSmartBox, ACBindings.Internal.NetBlob*, ACBindings.Internal.NetBlobProcessedStatus>)0x0055A210)(ref this, blob);
}

