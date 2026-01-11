namespace ACBindings.Internal;

public unsafe struct LogController : System.IDisposable
{
    // Child Types
    public unsafe struct CategoryHandler
    {
        // Base Classes
        public ACBindings.Internal.IntrusiveHashData__uint___LogController_CategoryHandler_ptr BaseClass_IntrusiveHashData; // ACBindings.Internal.IntrusiveHashData__uint___LogController_CategoryHandler_ptr

        // Members
        public byte m_fEnabled;
        public ACBindings.Internal.SmartArray___Logger_ILoggingOutputHandler_ptr m_rgOutputPlugins;
        public ACBindings.Internal.SmartArray__uint m_rgContextIDs;

        // Methods

        /// <summary>Distributes a log message to each attached logging output handler, appending a newline when missing and returning the combined write result.
        /// <code>Offset: 0x0040E910
        /// Logger::LoggerWriteResult __thiscall LogController::CategoryHandler::SendToOutputHandlers(LogController::CategoryHandler*,Logger::LoggingSeverity,unsigned int,const char*)</code>
        /// </summary>
        /// <param name="this">The CategoryHandler instance whose plugins receive the message.</param>
        /// <param name="ls">Severity level of the log entry.</param>
        /// <param name="lc">Log context identifier or counter associated with the message.</param>
        /// <param name="i_pszMsg">Text of the log message to be sent.</param>
        /// <returns>LoggerWriteResult indicating whether the message was handled by at least one output plugin; returns res_NotHandled if no plugins are configured or all handlers report not handled.</returns>
        public ACBindings.Internal.Logger.LoggerWriteResult SendToOutputHandlers(ACBindings.Internal.Logger.LoggingSeverity ls, uint lc, sbyte* i_pszMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LogController.CategoryHandler, ACBindings.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindings.Internal.Logger.LoggerWriteResult>)0x0040E910)(ref this, ls, lc, i_pszMsg);

        /// <summary>Removes all output handlers from the category handler and releases their references. Clears any associated context identifiers.
        /// <code>Offset: 0x0040F3B0
        /// bool __thiscall LogController::CategoryHandler::RemoveAllHandlers(LogController::CategoryHandler*)</code>
        /// </summary>
        /// <returns>True indicating that the removal completed successfully.</returns>
        public byte RemoveAllHandlers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LogController.CategoryHandler, byte>)0x0040F3B0)(ref this);

        /// <summary>Adds a logging output handler to the category's plugin list if it is not already present, increments its reference count, and records the context ID associated with the handler.
        /// <code>Offset: 0x0040F5F0
        /// bool __thiscall LogController::CategoryHandler::AddHandler(LogController::CategoryHandler*,Logger::ILoggingOutputHandler*,unsigned int)</code>
        /// </summary>
        /// <param name="i_ploh">The logging output handler to add.</param>
        /// <param name="i_ctx">Context identifier linked to the handler.</param>
        /// <returns>True when the handler was added successfully; otherwise false if it is already present.</returns>
        public byte AddHandler(ACBindings.Internal.Logger.ILoggingOutputHandler* i_ploh, uint i_ctx) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LogController.CategoryHandler, ACBindings.Internal.Logger.ILoggingOutputHandler*, uint, byte>)0x0040F5F0)(ref this, i_ploh, i_ctx);
    }

    // Members
    public ACBindings.Internal.IntrusiveHashTable__uint___LogController_CategoryHandler_ptr m_hashHandlers;
    public uint m_LastAssignedContext;
    public ACBindings.Internal.LogController.CategoryHandler m_DefaultHandler;
    public fixed byte m_rgGloballyDisabledSeverities[6];
    public ACBindings.Internal.Logger.ITextFileOutputHandler* m_plohTextFile;
    public ACBindings.Internal.Logger.ILoggingOutputHandler* m_plohConsole;
    public ACBindings.Internal.Logger.ILoggingOutputHandler* m_plohODS;

    // Generated Constructor
    public LogController() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Logs a message at the specified severity and context, dispatching it to any enabled handler matching the context or falling back to the default handler when none is found or disabled.
    /// <code>Offset: 0x0040F070
    /// void __thiscall LogController::LogMessage(LogController*,Logger::LoggingSeverity,unsigned int,const char*)</code>
    /// </summary>
    /// <param name="ls">Severity level of the log entry.</param>
    /// <param name="lc">Numeric identifier for the logging context or category.</param>
    /// <param name="szMessage">Text content of the log message.</param>
    public void LogMessage(ACBindings.Internal.Logger.LoggingSeverity ls, uint lc, sbyte* szMessage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LogController, ACBindings.Internal.Logger.LoggingSeverity, uint, sbyte*, void>)0x0040F070)(ref this, ls, lc, szMessage);

    /// <summary>Retrieves the log controller's text‑file output handler, creating it if necessary and incrementing its reference count.
    /// <code>Offset: 0x0040F350
    /// Logger::ITextFileOutputHandler* __thiscall LogController::GetTextFileOutputHandler(LogController*,bool)</code>
    /// </summary>
    /// <param name="fPlaceFileInCurrentDirectory">Specifies whether a new file should be placed in the current directory; used only when constructing a new handler.</param>
    /// <returns>A non‑null pointer to an ITextFileOutputHandler whose reference count has been increased for this call.</returns>
    public ACBindings.Internal.Logger.ITextFileOutputHandler* GetTextFileOutputHandler(byte fPlaceFileInCurrentDirectory) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LogController, byte, ACBindings.Internal.Logger.ITextFileOutputHandler*>)0x0040F350)(ref this, fPlaceFileInCurrentDirectory);

    /// <summary>Initializes a LogController instance by creating an empty category handler table, configuring the default handler as enabled with no output plugins or context IDs, clearing all globally disabled severities, registering the default handler in the hash table, and marking the logging segment as initialized.
    /// <code>Offset: 0x0040F780
    /// void __thiscall LogController::LogController(LogController*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LogController, void>)0x0040F780)(ref this);

    /// <summary>Destroys a LogController instance by releasing all registered handlers and cleaning up associated resources such as text file, console, ODS output handlers, default handler contexts, and internal hash table buckets.
    /// <code>Offset: 0x0040F7F0
    /// void __thiscall LogController::~LogController(LogController*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LogController, void>)0x0040F7F0)(ref this);

    /// <summary>Registers a logging output handler for the specified category, creating the category if needed, and returns a unique context identifier.
    /// <code>Offset: 0x0040F900
    /// unsigned int __thiscall LogController::AddCategoryHandler(LogController*,unsigned int,Logger::ILoggingOutputHandler*)</code>
    /// </summary>
    /// <param name="i_lc">Identifier of the log category to associate with the handler.</param>
    /// <param name="i_ploh">Output handler instance that will process log messages for this category.</param>
    /// <returns>Unique context ID assigned to the newly added handler.</returns>
    public uint AddCategoryHandler(uint i_lc, ACBindings.Internal.Logger.ILoggingOutputHandler* i_ploh) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LogController, uint, ACBindings.Internal.Logger.ILoggingOutputHandler*, uint>)0x0040F900)(ref this, i_lc, i_ploh);

    /// <summary>Initializes the log controller by creating and registering default logging handlers. A text‑file output handler is obtained based on fDefaultLogsToCurrentDirectory, and an OutputDebugString handler is created if missing; both are added to the controller’s default category handler with appropriate priorities.
    /// <code>Offset: 0x0040F990
    /// void __thiscall LogController::Initialize(LogController*,bool)</code>
    /// </summary>
    /// <param name="fDefaultLogsToCurrentDirectory">Indicates whether the text file handler should write logs to the current directory (true) or elsewhere (false).</param>
    public void Initialize(byte fDefaultLogsToCurrentDirectory) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LogController, byte, void>)0x0040F990)(ref this, fDefaultLogsToCurrentDirectory);
}

