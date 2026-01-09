namespace ACBindings;

// DDD_PatchPendingMessage
public unsafe struct DDD_PatchPendingMessage
{
    // Base Classes
    public ACBindings.FakeMessageData BaseClass_FakeMessageData; // ACBindings.FakeMessageData

    // Child Types
    // DDD_PatchPendingMessage_vtbl
    public unsafe struct DDD_PatchPendingMessage_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public uint m_nLinePosition;

    // Methods
}

