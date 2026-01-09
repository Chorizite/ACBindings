namespace ACBindings;

// ClientSystem
public unsafe struct ClientSystem
{
    // Base Classes
    public ACBindings.Interface BaseClass_Interface; // ACBindings.Interface
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Statics
    public static byte* s_pLogFile = (byte*)0x0086EF4C;

    // Child Types
    // ClientSystem_vtbl
    public unsafe struct ClientSystem_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr OnStartup; // function pointer
        public System.IntPtr UseTime; // function pointer
        public System.IntPtr OnBeginCharacterSession; // function pointer
        public System.IntPtr OnEndCharacterSession; // function pointer
        public System.IntPtr OnShutdown; // function pointer

        // Methods
    }

    // Methods
    // void __thiscall ClientSystem::AddTextToScroll(ClientSystem*,const char*,unsigned int,bool,unsigned int)
    public void AddTextToScroll(sbyte* i_text, uint i_ltt, byte i_sendToAPI, uint i_nOverrideDestination) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientSystem, sbyte*, uint, byte, uint, void>)0x004882F0)(ref this, i_text, i_ltt, i_sendToAPI, i_nOverrideDestination);
    // LONG __thiscall ClientSystem::AddTextToScroll(void*,int,unsigned int,char,unsigned int)
    public int AddTextToScroll(int a2, uint a3, sbyte a4, uint a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientSystem, int, uint, sbyte, uint, int>)0x004C3010)(ref this, a2, a3, a4, a5);
    // LONG __thiscall ClientSystem::AddTextToScroll(void*,const OLECHAR**,unsigned int,char,unsigned int)
    public int AddTextToScroll(System.IntPtr a2, uint i_lt, sbyte a4, uint i_idDestinationOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientSystem, System.IntPtr, uint, sbyte, uint, int>)0x005649F0)(ref this, a2, i_lt, a4, i_idDestinationOverride);
}

