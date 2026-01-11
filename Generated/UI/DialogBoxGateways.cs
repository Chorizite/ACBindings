namespace ACBindings.Internal;

public unsafe struct DialogBoxGateways
{
    // Base Classes
    public ACBindings.Internal.CPluginManagerTemplate___DialogBoxGateway BaseClass_CPluginManagerTemplate; // ACBindings.Internal.CPluginManagerTemplate___DialogBoxGateway

    // Statics
    public static int* s_nDialogThreadPrepares = (int*)0x008183BC;
    public static ulong* s_qwDialogContext = (ulong*)0x00837808;
    public static ulong* s_qwReportContext = (ulong*)0x00837810;

    // Methods

    /// <summary>Recalculates a 64‑bit status word by invoking each gateway plugin’s cleanup routine whenever the internal prepare counter overflows. The returned value is split into two 32‑bit parts that are also cached in static globals for subsequent use.
    /// <code>Offset: 0x0040E560
    /// unsigned __int64 __cdecl DialogBoxGateways::ReportThread_PrepareForDialogBox()</code>
    /// </summary>
    /// <returns>A 64‑bit integer where the low 32 bits and high 32 bits contain the accumulated, index‑shifted bytes returned by each plugin’s cleanup routine. The result is stored in global variables dword_837814 (low part) and dword_837810 (high part).</returns>
    public static ulong ReportThread_PrepareForDialogBox() => ((delegate* unmanaged[Cdecl]<ulong>)0x0040E560)();

    /// <summary>Signals completion of a report thread’s dialog box operation; when the global counter reaches a negative value, it notifies each registered plugin via OnPluggedIn with data derived from the supplied context.
    /// <code>Offset: 0x0040E5D0
    /// void __cdecl DialogBoxGateways::ReportThread_DoneWithDialogBox(unsigned __int64)</code>
    /// </summary>
    /// <param name="context">A 64‑bit value that encodes per‑plugin data. The high 32 bits are shifted right by each plugin’s index and passed as the second argument; the i‑th bit of the lower 32 bits is extracted and placed in the low byte of the third argument to indicate a flag for that plugin.</param>
    public static void ReportThread_DoneWithDialogBox(ulong context) => ((delegate* unmanaged[Cdecl]<ulong, void>)0x0040E5D0)(context);

    /// <summary>Prepares the dialog box thread by accumulating plugin flags and tracking preparation count. Returns a 64‑bit value composed of two accumulated state values.
    /// <code>Offset: 0x0040E620
    /// unsigned __int64 __cdecl DialogBoxGateways::DialogThread_PrepareForDialogBox()</code>
    /// </summary>
    /// <returns>A 64‑bit integer containing combined state information for the dialog box thread.</returns>
    public static ulong DialogThread_PrepareForDialogBox() => ((delegate* unmanaged[Cdecl]<ulong>)0x0040E620)();

    /// <summary>Completes dialog-thread operations, updates the internal preparation counter, and notifies each registered gateway plugin of the operation’s completion status derived from the supplied context.
    /// <code>Offset: 0x0040E690
    /// void __cdecl DialogBoxGateways::DialogThread_DoneWithDialogBox(unsigned __int64)</code>
    /// </summary>
    /// <param name="context">A bitmask indicating which gateways were involved in the dialog box operation; each bit corresponds to a gateway index.</param>
    public static void DialogThread_DoneWithDialogBox(ulong context) => ((delegate* unmanaged[Cdecl]<ulong, void>)0x0040E690)(context);
}

