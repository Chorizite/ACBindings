namespace ACBindings;

// DDD_IterationDataMessage
public unsafe struct DDD_IterationDataMessage
{
    // Base Classes
    public ACBindings.FakeMessageData BaseClass_FakeMessageData; // ACBindings.FakeMessageData

    // Child Types
    // DDD_IterationDataMessage_vtbl
    public unsafe struct DDD_IterationDataMessage_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public uint m_cbTotalData;
    public ACBindings.MissingIteration m_IterationData;
    public ACBindings.SmartArray__DDD_DataMessage_ptr m_Data;

    // Methods
}

