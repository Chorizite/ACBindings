namespace ACBindings;

// DDD_BeginPullDDDMessage
public unsafe struct DDD_BeginPullDDDMessage
{
    // Base Classes
    public ACBindings.FakeMessageData BaseClass_FakeMessageData; // ACBindings.FakeMessageData

    // Child Types
    // DDD_BeginPullDDDMessage_vtbl
    public unsafe struct DDD_BeginPullDDDMessage_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public uint m_cbDataExpected;
    public ACBindings.SmartArray__QualifiedIteration m_IterationsToDownload;
    public ACBindings.HashTable__QualifiedIteration__IterationKey m_Keys;

    // Methods
}

