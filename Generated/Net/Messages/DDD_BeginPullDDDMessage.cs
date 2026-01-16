namespace ACBindings.Internal;


/// <summary>Initiates a pull operation by specifying the expected data size, the iterations to retrieve, and their corresponding keys.</summary>
public unsafe struct DDD_BeginPullDDDMessage
{
    // Base Classes
    public ACBindings.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindings.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_BeginPullDDDMessage_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DDD_BeginPullDDDMessage*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public uint m_cbDataExpected;
    public ACBindings.Internal.SmartArray___QualifiedIteration m_IterationsToDownload;
    public ACBindings.Internal.HashTable___QualifiedIteration___IterationKey m_Keys;

    // Methods
}

