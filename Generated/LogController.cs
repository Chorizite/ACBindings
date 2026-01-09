namespace ACBindings;

// LogController
public unsafe struct LogController : System.IDisposable
{
    // Child Types
    // LogController::CategoryHandler
    public unsafe struct CategoryHandler
    {
        // Base Classes
        public ACBindings.IntrusiveHashData__uint__LogController_CategoryHandler_ptr BaseClass_IntrusiveHashData; // ACBindings.IntrusiveHashData__uint__LogController_CategoryHandler_ptr

        // Members
        public byte m_fEnabled;
        public ACBindings.SmartArray__Logger_ILoggingOutputHandler_ptr m_rgOutputPlugins;
        public ACBindings.SmartArray__uint m_rgContextIDs;

        // Methods
        // Logger::LoggerWriteResult __thiscall LogController::CategoryHandler::SendToOutputHandlers(LogController::CategoryHandler*,Logger::LoggingSeverity,unsigned int,const char*)
        public ACBindings.Logger.LoggerWriteResult SendToOutputHandlers(ACBindings.Logger.LoggingSeverity ls, uint lc, sbyte* i_pszMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LogController.CategoryHandler, ACBindings.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Logger.LoggerWriteResult>)0x0040E910)(ref this, ls, lc, i_pszMsg);
        // bool __thiscall LogController::CategoryHandler::RemoveAllHandlers(LogController::CategoryHandler*)
        public byte RemoveAllHandlers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LogController.CategoryHandler, byte>)0x0040F3B0)(ref this);
        // bool __thiscall LogController::CategoryHandler::AddHandler(LogController::CategoryHandler*,Logger::ILoggingOutputHandler*,unsigned int)
        public byte AddHandler(ACBindings.Logger.ILoggingOutputHandler* i_ploh, uint i_ctx) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LogController.CategoryHandler, ACBindings.Logger.ILoggingOutputHandler*, uint, byte>)0x0040F5F0)(ref this, i_ploh, i_ctx);
    }

    // Members
    public ACBindings.IntrusiveHashTable__uint__LogController_CategoryHandler_ptr m_hashHandlers;
    public uint m_LastAssignedContext;
    public ACBindings.LogController.CategoryHandler m_DefaultHandler;
    public fixed byte m_rgGloballyDisabledSeverities[6];
    public ACBindings.Logger.ITextFileOutputHandler* m_plohTextFile;
    public ACBindings.Logger.ILoggingOutputHandler* m_plohConsole;
    public ACBindings.Logger.ILoggingOutputHandler* m_plohODS;

    // Generated Constructor
    public LogController() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall LogController::LogMessage(LogController*,Logger::LoggingSeverity,unsigned int,const char*)
    public void LogMessage(ACBindings.Logger.LoggingSeverity ls, uint lc, sbyte* szMessage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LogController, ACBindings.Logger.LoggingSeverity, uint, sbyte*, void>)0x0040F070)(ref this, ls, lc, szMessage);
    // Logger::ITextFileOutputHandler* __thiscall LogController::GetTextFileOutputHandler(LogController*,bool)
    public ACBindings.Logger.ITextFileOutputHandler* GetTextFileOutputHandler(byte fPlaceFileInCurrentDirectory) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LogController, byte, ACBindings.Logger.ITextFileOutputHandler*>)0x0040F350)(ref this, fPlaceFileInCurrentDirectory);
    // void __thiscall LogController::LogController(LogController*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LogController, void>)0x0040F780)(ref this);
    // void __thiscall LogController::~LogController(LogController*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LogController, void>)0x0040F7F0)(ref this);
    // unsigned int __thiscall LogController::AddCategoryHandler(LogController*,unsigned int,Logger::ILoggingOutputHandler*)
    public uint AddCategoryHandler(uint i_lc, ACBindings.Logger.ILoggingOutputHandler* i_ploh) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LogController, uint, ACBindings.Logger.ILoggingOutputHandler*, uint>)0x0040F900)(ref this, i_lc, i_ploh);
    // void __thiscall LogController::Initialize(LogController*,bool)
    public void Initialize(byte fDefaultLogsToCurrentDirectory) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LogController, byte, void>)0x0040F990)(ref this, fDefaultLogsToCurrentDirectory);
}

