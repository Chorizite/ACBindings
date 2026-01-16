namespace ACBindings.Internal;


/// <summary>Encapsulates a base SmartBox, extending it with specialized event dispatching and readiness logic for the AC subsystem.</summary>
public unsafe struct ACSmartBox
{
    // Base Classes
    public ACBindings.Internal.SmartBox BaseClass_SmartBox; // ACBindings.Internal.SmartBox

    // Child Types
    public unsafe struct ACSmartBox_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACSmartBox*, void> ACSmartBox_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACSmartBox*, ACBindings.Internal.NetBlob*, int> IsReadyToDispatchEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACSmartBox*, ACBindings.Internal.NetBlob*, ACBindings.Internal.NetBlobProcessedStatus> DispatchSmartBoxEvent; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Determines whether an ACSmartBox instance is prepared to process a NetBlob event. If the box has an associated player, it is always considered ready; otherwise readiness depends on the blob’s size and a specific header value.
    /// <code>Offset: 0x0055A1D0
    /// int __thiscall ACSmartBox::IsReadyToDispatchEvent(ACSmartBox*,NetBlob*)</code>
    /// </summary>
    /// <param name="blob">The network packet examined for dispatch eligibility.</param>
    /// <returns>1 if ready; 0 if not.</returns>
    public int IsReadyToDispatchEvent(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACSmartBox, ACBindings.Internal.NetBlob*, int>)0x0055A1D0)(ref this, blob);

    /// <summary>Dispatches a network blob event to the smart box, interpreting its command code and invoking appropriate handlers or queuing the blob for later processing.
    /// <code>Offset: 0x0055A210
    /// NetBlobProcessedStatus __thiscall ACSmartBox::DispatchSmartBoxEvent(ACSmartBox*,NetBlob*)</code>
    /// </summary>
    /// <param name="blob">The NetBlob containing the event data.</param>
    /// <returns>NetBlobProcessedStatus indicating whether the blob was queued, processed successfully, or failed.</returns>
    public ACBindings.Internal.NetBlobProcessedStatus DispatchSmartBoxEvent(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACSmartBox, ACBindings.Internal.NetBlob*, ACBindings.Internal.NetBlobProcessedStatus>)0x0055A210)(ref this, blob);
}

