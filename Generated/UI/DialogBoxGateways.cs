namespace ACBindings;

// DialogBoxGateways
public unsafe struct DialogBoxGateways
{
    // Base Classes
    public ACBindings.CPluginManagerTemplate__DialogBoxGateway BaseClass_CPluginManagerTemplate; // ACBindings.CPluginManagerTemplate__DialogBoxGateway

    // Statics
    public static int* s_nDialogThreadPrepares = (int*)0x008183BC;
    public static int* s_nReportThreadPrepares = (int*)0x008183C0;
    public static ulong* s_qwDialogContext = (ulong*)0x00837804;
    public static ulong* s_qwReportContext = (ulong*)0x00837810;

    // Methods
    // unsigned __int64 __cdecl DialogBoxGateways::ReportThread_PrepareForDialogBox()
    public static ulong ReportThread_PrepareForDialogBox() => ((delegate* unmanaged[Cdecl]<ulong>)0x0040E560)();
    // void __cdecl DialogBoxGateways::ReportThread_DoneWithDialogBox(unsigned __int64)
    public static void ReportThread_DoneWithDialogBox(ulong context) => ((delegate* unmanaged[Cdecl]<ulong, void>)0x0040E5D0)(context);
    // unsigned __int64 __cdecl DialogBoxGateways::DialogThread_PrepareForDialogBox()
    public static ulong DialogThread_PrepareForDialogBox() => ((delegate* unmanaged[Cdecl]<ulong>)0x0040E620)();
    // void __cdecl DialogBoxGateways::DialogThread_DoneWithDialogBox(unsigned __int64)
    public static void DialogThread_DoneWithDialogBox(ulong context) => ((delegate* unmanaged[Cdecl]<ulong, void>)0x0040E690)(context);
}

