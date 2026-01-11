namespace ACBindings.Internal;

public unsafe struct DDD_InterrogationResponseMessage
{
    // Base Classes
    public ACBindings.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindings.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_InterrogationResponseMessage_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DDD_InterrogationResponseMessage*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public uint m_ClientLanguage;
    public ACBindings.Internal.CAllIterationList m_ItersWithKeys;
    public ACBindings.Internal.CAllIterationList m_ItersWithoutKeys;
    public uint m_dwFlags;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004FA2A0
    /// void __thiscall DDD_InterrogationResponseMessage::Serialize(DDD_InterrogationResponseMessage*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DDD_InterrogationResponseMessage, ACBindings.Internal.Archive*, void>)0x004FA2A0)(ref this, io_archive);
}

