namespace ACBindings.Internal;

public unsafe struct ClientMain
{
    // Methods

    /// <summary>Cleans up a Client instance by releasing its COM interfaces and performing global factory and version clean‑up tasks.
    /// <code>Offset: 0x004010F0
    /// void __cdecl ClientMain::ClientCleanUp(Client*)</code>
    /// </summary>
    /// <param name="pClient">The client to clean up; if null, the function performs only global cleanup.</param>
    public static void ClientCleanUp(ACBindings.Internal.Client* pClient) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Client*, void>)0x004010F0)(pClient);

    /// <summary>Configures the floating‑point unit’s control word and exception mask to establish a stable numeric environment for the client application.
    /// <code>Offset: 0x00401120
    /// void __cdecl ClientMain::ConfigureFPU()</code>
    /// </summary>
    public static void ConfigureFPU() => ((delegate* unmanaged[Cdecl]<void>)0x00401120)();
}

