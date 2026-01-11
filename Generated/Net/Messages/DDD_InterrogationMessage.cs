namespace ACBindings.Internal;

public unsafe struct DDD_InterrogationMessage : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindings.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_InterrogationMessage_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DDD_InterrogationMessage*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public uint m_dwServersRegion;
    public uint m_NameRuleLanguage;
    public uint m_dwProductID;
    public ACBindings.Internal.SmartArray__uint m_SupportedLanguages;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F8C30
    /// void __thiscall DDD_InterrogationMessage::~DDD_InterrogationMessage(DDD_InterrogationMessage*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DDD_InterrogationMessage, void>)0x004F8C30)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F9190
    /// void __thiscall DDD_InterrogationMessage::Serialize(DDD_InterrogationMessage*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DDD_InterrogationMessage, ACBindings.Internal.Archive*, void>)0x004F9190)(ref this, io_archive);
}

