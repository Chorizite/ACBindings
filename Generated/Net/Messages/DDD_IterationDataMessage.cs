namespace ACBindings.Internal;

public unsafe struct DDD_IterationDataMessage
{
    // Base Classes
    public ACBindings.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindings.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_IterationDataMessage_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DDD_IterationDataMessage*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public uint m_cbTotalData;
    public ACBindings.Internal.MissingIteration m_IterationData;
    public ACBindings.Internal.SmartArray___DDD_DataMessage_ptr m_Data;

    // Methods
}

