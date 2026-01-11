namespace ACBindings.Internal;

public unsafe struct ClientSystem
{
    // Base Classes
    public ACBindings.Internal.Interface BaseClass_Interface; // ACBindings.Internal.Interface
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct ClientSystem_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnStartup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> UseTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnBeginCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnEndCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnShutdown; // function pointer

        // Methods
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004882F0
    /// void __thiscall ClientSystem::AddTextToScroll(ClientSystem*,const char*,unsigned int,bool,unsigned int)</code>
    /// </summary>
    public void AddTextToScroll(sbyte* i_text, uint i_ltt, byte i_sendToAPI, uint i_nOverrideDestination) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientSystem, sbyte*, uint, byte, uint, void>)0x004882F0)(ref this, i_text, i_ltt, i_sendToAPI, i_nOverrideDestination);

    /// <summary>
    /// <code>Offset: 0x004C3010
    /// LONG __thiscall ClientSystem::AddTextToScroll(void*,int,unsigned int,char,unsigned int)</code>
    /// </summary>
    public int AddTextToScroll(int a2, uint a3, sbyte a4, uint a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientSystem, int, uint, sbyte, uint, int>)0x004C3010)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x005649F0
    /// LONG __thiscall ClientSystem::AddTextToScroll(void*,const OLECHAR**,unsigned int,char,unsigned int)</code>
    /// </summary>
    public int AddTextToScroll(System.IntPtr a2, uint i_lt, sbyte a4, uint i_idDestinationOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientSystem, System.IntPtr, uint, sbyte, uint, int>)0x005649F0)(ref this, a2, i_lt, a4, i_idDestinationOverride);
}

