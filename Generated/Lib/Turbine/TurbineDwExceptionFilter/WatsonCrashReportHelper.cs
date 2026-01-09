namespace ACBindings.TurbineDwExceptionFilter;

// TurbineDwExceptionFilter::WatsonCrashReportHelper
public unsafe struct WatsonCrashReportHelper : System.IDisposable
{
    // Base Classes
    public ACBindings.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.CPluginPrototype

    // Child Types
    // TurbineDwExceptionFilter::WatsonCrashReportHelper_vtbl
    public unsafe struct WatsonCrashReportHelper_vtbl
    {
        // Members
        public System.IntPtr TurbineDwExceptionFilter; // function pointer
        public System.IntPtr OnPluggedIn; // function pointer
        public System.IntPtr IncludeFileInWatsonUpload; // function pointer

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
    // void __thiscall TurbineDwExceptionFilter::WatsonCrashReportHelper::~WatsonCrashReportHelper(TurbineDwExceptionFilter::WatsonCrashReportHelper*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TurbineDwExceptionFilter.WatsonCrashReportHelper, void>)0x006B6C70)(ref this);
    // void __thiscall TurbineDwExceptionFilter::WatsonCrashReportHelper::WatsonCrashReportHelper(TurbineDwExceptionFilter::WatsonCrashReportHelper*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TurbineDwExceptionFilter.WatsonCrashReportHelper, void>)0x006B6D80)(ref this);
}

