namespace ACBindings.Internal.TurbineDwExceptionFilter;

public unsafe struct WatsonCrashReportHelper : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.Internal.CPluginPrototype

    // Child Types
    public unsafe struct WatsonCrashReportHelper_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TurbineDwExceptionFilter.WatsonCrashReportHelper*, void> TurbineDwExceptionFilter; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TurbineDwExceptionFilter.WatsonCrashReportHelper*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TurbineDwExceptionFilter.WatsonCrashReportHelper*, ushort*, uint, int> IncludeFileInWatsonUpload; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x006B6C70
    /// void __thiscall TurbineDwExceptionFilter::WatsonCrashReportHelper::~WatsonCrashReportHelper(TurbineDwExceptionFilter::WatsonCrashReportHelper*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TurbineDwExceptionFilter.WatsonCrashReportHelper, void>)0x006B6C70)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B6D80
    /// void __thiscall TurbineDwExceptionFilter::WatsonCrashReportHelper::WatsonCrashReportHelper(TurbineDwExceptionFilter::WatsonCrashReportHelper*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TurbineDwExceptionFilter.WatsonCrashReportHelper, void>)0x006B6D80)(ref this);
}

