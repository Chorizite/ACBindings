namespace ACBindings;

// DDD_InterrogationResponseMessage
public unsafe struct DDD_InterrogationResponseMessage
{
    // Base Classes
    public ACBindings.FakeMessageData BaseClass_FakeMessageData; // ACBindings.FakeMessageData

    // Child Types
    // DDD_InterrogationResponseMessage_vtbl
    public unsafe struct DDD_InterrogationResponseMessage_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public uint m_ClientLanguage;
    public ACBindings.CAllIterationList m_ItersWithKeys;
    public ACBindings.CAllIterationList m_ItersWithoutKeys;
    public uint m_dwFlags;

    // Methods
    // void __thiscall DDD_InterrogationResponseMessage::Serialize(DDD_InterrogationResponseMessage*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DDD_InterrogationResponseMessage, ACBindings.Archive*, void>)0x004FA2A0)(ref this, io_archive);
}

