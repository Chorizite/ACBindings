namespace ACBindings;

// ClientMain
public unsafe struct ClientMain
{
    // Methods
    // void __cdecl ClientMain::ClientCleanUp(Client*)
    public static void ClientCleanUp(ACBindings.Client* pClient) => ((delegate* unmanaged[Cdecl]<ACBindings.Client*, void>)0x004010F0)(pClient);
    // void __cdecl ClientMain::ConfigureFPU()
    public static void ConfigureFPU() => ((delegate* unmanaged[Cdecl]<void>)0x00401120)();
}

