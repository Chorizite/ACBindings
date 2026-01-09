namespace ACBindings;

// gmUIFlow
public unsafe struct gmUIFlow : System.IDisposable
{
    // Base Classes
    public ACBindings.UIFlow BaseClass_UIFlow; // ACBindings.UIFlow
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmUIFlow_vtbl
    public unsafe struct gmUIFlow_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public System.IntPtr QueueUIMode; // function pointer
        public System.IntPtr QueueUIModeWithError; // function pointer
        public System.IntPtr GetPersistantData; // function pointer
        public System.IntPtr Update; // function pointer

        // Methods
    }

    // Generated Constructor
    public gmUIFlow() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmUIFlow::gmUIFlow(gmUIFlow*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIFlow, void>)0x0047AA10)(ref this);
    // void __thiscall gmUIFlow::~gmUIFlow(gmUIFlow*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIFlow, void>)0x0047AB20)(ref this);
    // void __thiscall gmUIFlow::RecvNotice_CharacterError(gmUIFlow*,charError)
    public void RecvNotice_CharacterError(ACBindings.charError error) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIFlow, ACBindings.charError, void>)0x0047ABC0)(ref this, error);
    // void __thiscall gmUIFlow::RecvNotice_ServerDied(gmUIFlow*)
    public void RecvNotice_ServerDied() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmUIFlow, void>)0x0047ADA0)(ref this);
}

