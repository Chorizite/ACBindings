namespace ACBindings.Internal;


/// <summary>Provides administrative capabilities for client connections, extending basic client functionality with Turbine reference counting and boot state tracking.</summary>
/// <remarks>Inherits from ClientSystem; used by the system to handle admin requests such as plugin queries and manage the lifecycle of the client subsystem during boot or shutdown phases.</remarks>
public unsafe struct ClientAdminSystem
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem

    // Child Types
    public unsafe struct ClientAdminSystem_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnStartup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnBeginCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnEndCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnShutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientAdminSystem*, ACBindings.Internal.ClientAdminSystem.Enum7> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

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

    /// <summary>Handles an administrator query plugin response.
    /// <code>Offset: 0x006B6E10
    /// int __stdcall ClientAdminSystem::Handle_Admin__Recv_QueryPluginResponse(int,int,int,int,int)</code>
    /// </summary>
    /// <returns>Zero, indicating successful handling in the current implementation.</returns>
    public static int Handle_Admin__Recv_QueryPluginResponse(int a1, int a2, int a3, int a4, int a5) => ((delegate* unmanaged[Stdcall]<int, int, int, int, int, int>)0x006B6E10)(a1, a2, a3, a4, a5);

    /// <summary>Responds to an admin query for the third‑party API plugin name, returning a default message if the API is unavailable.
    /// <code>Offset: 0x006B6E20
    /// unsigned int __thiscall ClientAdminSystem::Handle_Admin__Recv_QueryPluginList(ClientAdminSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="context">Identifier used to route the response back to the requesting client.</param>
    /// <returns>Zero on completion.</returns>
    public uint Handle_Admin__Recv_QueryPluginList(uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientAdminSystem, uint, uint>)0x006B6E20)(ref this, context);

    /// <summary>
    /// Handles an admin request to query information from the ACPlugin API and dispatches the result via CM_Admin::Event_QueryPluginResponse.
    /// 
    /// <code>Offset: 0x006B6EC0
    /// int __stdcall ClientAdminSystem::Handle_Admin__Recv_QueryPlugin(int,volatile LONG*)</code>
    /// </summary>
    /// <param name="a1">Identifier or context value associated with this admin operation.</param>
    /// <param name="bstrString">Pointer to a BSTR containing the plugin name to query; the function may modify its contents to return details about the requested plugin.</param>
    /// <returns>Zero, indicating that the function executed without returning an explicit status code.</returns>
    public static int Handle_Admin__Recv_QueryPlugin(int a1, int* bstrString) => ((delegate* unmanaged[Stdcall]<int, int*, int>)0x006B6EC0)(a1, bstrString);
}

