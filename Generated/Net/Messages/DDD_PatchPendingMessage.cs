namespace ACBindings.Internal;

public unsafe struct DDD_PatchPendingMessage
{
    // Base Classes
    public ACBindings.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindings.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_PatchPendingMessage_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DDD_PatchPendingMessage*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public uint m_nLinePosition;

    // Methods
}

