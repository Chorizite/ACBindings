namespace ACBindings;

// DDD_InterrogationMessage
public unsafe struct DDD_InterrogationMessage : System.IDisposable
{
    // Base Classes
    public ACBindings.FakeMessageData BaseClass_FakeMessageData; // ACBindings.FakeMessageData

    // Child Types
    // DDD_InterrogationMessage_vtbl
    public unsafe struct DDD_InterrogationMessage_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public uint m_dwServersRegion;
    public uint m_NameRuleLanguage;
    public uint m_dwProductID;
    public ACBindings.SmartArray__uint m_SupportedLanguages;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall DDD_InterrogationMessage::~DDD_InterrogationMessage(DDD_InterrogationMessage*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DDD_InterrogationMessage, void>)0x004F8C30)(ref this);
    // void __thiscall DDD_InterrogationMessage::Serialize(DDD_InterrogationMessage*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DDD_InterrogationMessage, ACBindings.Archive*, void>)0x004F9190)(ref this, io_archive);
}

