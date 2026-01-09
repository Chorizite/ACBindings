namespace ACBindings;

// ClientAdminSystem
public unsafe struct ClientAdminSystem
{
    // Base Classes
    public ACBindings.ClientSystem BaseClass_ClientSystem; // ACBindings.ClientSystem

    // Child Types
    // ClientAdminSystem_vtbl
    public unsafe struct ClientAdminSystem_vtbl
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
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

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
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;
    public byte m_bIsBooting;

    // Methods
    // int __stdcall ClientAdminSystem::Handle_Admin__Recv_QueryPluginResponse(int,int,int,int,int)
    public static int Handle_Admin__Recv_QueryPluginResponse(int a1, int a2, int a3, int a4, int a5) => ((delegate* unmanaged[Stdcall]<int, int, int, int, int, int>)0x006B6E10)(a1, a2, a3, a4, a5);
    // unsigned int __thiscall ClientAdminSystem::Handle_Admin__Recv_QueryPluginList(ClientAdminSystem*,unsigned int)
    public uint Handle_Admin__Recv_QueryPluginList(uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientAdminSystem, uint, uint>)0x006B6E20)(ref this, context);
    // int __stdcall ClientAdminSystem::Handle_Admin__Recv_QueryPlugin(int,volatile LONG*)
    public static int Handle_Admin__Recv_QueryPlugin(int a1, int* bstrString) => ((delegate* unmanaged[Stdcall]<int, int*, int>)0x006B6EC0)(a1, bstrString);
}

