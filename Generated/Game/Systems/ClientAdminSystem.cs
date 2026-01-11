namespace ACBindings.Internal;

public unsafe struct ClientAdminSystem
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem

    // Child Types
    public unsafe struct ClientAdminSystem_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientAdminSystem*, ACBindings.Internal.ClientAdminSystem.Enum7> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClientAdminSystem::Enum10
    public enum Enum10 : uint
    {
    }
    // ClientAdminSystem::Enum4
    public enum Enum4 : uint
    {
    }
    // ClientAdminSystem::Enum6
    public enum Enum6 : uint
    {
    }
    // ClientAdminSystem::Enum7
    public enum Enum7 : uint
    {
    }
    // ClientAdminSystem::Enum8
    public enum Enum8 : uint
    {
    }
    // ClientAdminSystem::Enum9
    public enum Enum9 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public byte m_bIsBooting;

    // Methods

    /// <summary>
    /// <code>Offset: 0x006B6E10
    /// int __stdcall ClientAdminSystem::Handle_Admin__Recv_QueryPluginResponse(int,int,int,int,int)</code>
    /// </summary>
    public static int Handle_Admin__Recv_QueryPluginResponse(int a1, int a2, int a3, int a4, int a5) => ((delegate* unmanaged[Stdcall]<int, int, int, int, int, int>)0x006B6E10)(a1, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x006B6E20
    /// unsigned int __thiscall ClientAdminSystem::Handle_Admin__Recv_QueryPluginList(ClientAdminSystem*,unsigned int)</code>
    /// </summary>
    public uint Handle_Admin__Recv_QueryPluginList(uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientAdminSystem, uint, uint>)0x006B6E20)(ref this, context);

    /// <summary>
    /// <code>Offset: 0x006B6EC0
    /// int __stdcall ClientAdminSystem::Handle_Admin__Recv_QueryPlugin(int,volatile LONG*)</code>
    /// </summary>
    public static int Handle_Admin__Recv_QueryPlugin(int a1, int* bstrString) => ((delegate* unmanaged[Stdcall]<int, int*, int>)0x006B6EC0)(a1, bstrString);
}

