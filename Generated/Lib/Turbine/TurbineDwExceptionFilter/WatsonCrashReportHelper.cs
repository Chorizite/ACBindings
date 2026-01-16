namespace ACBindings.Internal.TurbineDwExceptionFilter;


/// <summary>Provides a plugin prototype for Watson crash reporting within TurbineDwExceptionFilter, registering itself with the global CPluginManager upon construction and deregistering on destruction.</summary>
public unsafe struct WatsonCrashReportHelper : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.Internal.CPluginPrototype

    // Child Types
    public unsafe struct WatsonCrashReportHelper_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TurbineDwExceptionFilter.WatsonCrashReportHelper*, void> TurbineDwExceptionFilter; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TurbineDwExceptionFilter.WatsonCrashReportHelper*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TurbineDwExceptionFilter.WatsonCrashReportHelper*, ushort*, uint, int> IncludeFileInWatsonUpload; // function pointer

        // Methods
    }

    // Generated Constructor
    public WatsonCrashReportHelper() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a WatsonCrashReportHelper, removing it from both the global and local plugin managers and restoring its base class to a clean state.
    /// <code>Offset: 0x006B6C70
    /// void __thiscall TurbineDwExceptionFilter::WatsonCrashReportHelper::~WatsonCrashReportHelper(TurbineDwExceptionFilter::WatsonCrashReportHelper*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TurbineDwExceptionFilter.WatsonCrashReportHelper, void>)0x006B6C70)(ref this);

    /// <summary>Initializes a WatsonCrashReportHelper instance by setting up its plugin prototype and registering it with the global CPluginManager.
    /// <code>Offset: 0x006B6D80
    /// void __thiscall TurbineDwExceptionFilter::WatsonCrashReportHelper::WatsonCrashReportHelper(TurbineDwExceptionFilter::WatsonCrashReportHelper*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TurbineDwExceptionFilter.WatsonCrashReportHelper, void>)0x006B6D80)(ref this);
}

