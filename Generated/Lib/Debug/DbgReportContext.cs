namespace ACBindings.Internal;

public unsafe struct DbgReportContext : System.IDisposable
{
    // Members
    public System.IntPtr m_hProcess;
    public uint m_idThread;
    public System.IntPtr m_hThread;
    public System.IntPtr m_hModule;

    // Generated Constructor
    public DbgReportContext(System.IntPtr pep) {
        _ConstructorInternal(pep);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a DbgReportContext instance by closing its thread and process handles.
    /// <code>Offset: 0x0040E7B0
    /// void __thiscall DbgReportContext::~DbgReportContext(DbgReportContext*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DbgReportContext, void>)0x0040E7B0)(ref this);

    /// <summary>Initializes a DbgReportContext instance by recording handles to the current process, thread, and module based on an optional exception record.
    /// <code>Offset: 0x0040E7D0
    /// void __thiscall DbgReportContext::DbgReportContext(DbgReportContext*,_EXCEPTION_POINTERS*)</code>
    /// </summary>
    /// <param name="pep">An optional pointer to an _EXCEPTION_POINTERS structure; if provided, its context is used to determine the module address, otherwise the main executable module is assumed.</param>
    public void _ConstructorInternal(System.IntPtr pep) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DbgReportContext, System.IntPtr, void>)0x0040E7D0)(ref this, pep);
}

