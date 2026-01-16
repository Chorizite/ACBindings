namespace ACBindings.Internal.Turbine;


/// <summary>Turbine::Debug encapsulates the debugging subsystem state and behavior for the Turbine engine, managing debug flags, exception handling, logging initialization, and crash cleanup routines.</summary>
public unsafe struct Debug
{
    // Statics
    public static uint* DebugFlags = (uint*)0x00818338;
    public static ACBindings.Internal.Turbine.Debug** s_pDebug = (ACBindings.Internal.Turbine.Debug**)0x00818550;

    // Child Types

    /// <summary>Holds function pointers defining Turbine::Debug’s virtual interface, including initialization support for the debug subsystem.</summary>
    public unsafe struct Debug_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Turbine.Debug*, byte> InitDebug; // function pointer

        // Methods
    }

    /// <summary>Encapsulates information about a failed boolean expression in debug builds, including the source file, condition text, line number, and optional flags for formatting or handling.</summary>
    public unsafe struct AssertIfFalseFmt
    {
        // Members
        public byte m_bExpressionResult;
        public sbyte* m_szFile;
        public sbyte* m_szCondition;
        public int m_iLine;
        public uint* m_rdwFlags;

        // Methods
    }
    // Turbine::Debug::AssertionControlBits
    public enum AssertionControlBits : byte
    {
        AssertionDefaultAction = 0x1,
        AssertionIgnored = 0x2,
        AssertionLogOnly = 0x4,
        AssertionIsFatal = 0x8
    }

    /// <summary>Encapsulates information needed to report an assert failure, including the result code, source location and diagnostic flags.</summary>
    public unsafe struct AssertOnFailureFmtHelper
    {
        // Members
        public ACBindings.Internal.TResult m_hrExpressionResult;
        public sbyte* m_szFile;
        public sbyte* m_szCondition;
        public int m_iLine;
        public uint* m_rdwFlags;

        // Methods
    }
    // Turbine::Debug::DebugResponse
    public enum DebugResponse : byte
    {
        DebugResponseAbort = 0x0,
        DebugResponseDebug = 0x1,
        DebugResponseIgnoreThis = 0x2,
        DebugResponseIgnoreAll = 0x3,
        DebugResponseFatalError = 0x4,
        DebugResponseCrashReport = 0x5
    }
    // Turbine::Debug::OutputStringType
    public enum OutputStringType : byte
    {
        OutputString_File = 0x0,
        OutputString_User = 0x1,
        OutputString_UserAndFile = 0x2,
        OutputString_AssertionFailed = 0x3
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Generated Constructor
    public Debug() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Enables or disables the debug flags specified by Mask.
    /// <code>Offset: 0x00405E60
    /// void __cdecl Turbine::Debug::SetDebugFlags(unsigned int,bool)</code>
    /// </summary>
    /// <param name="Mask">Bitmask of flags to modify.</param>
    /// <param name="bValueToSet">True to set (enable) the flagged bits; false to clear them.</param>
    public static void SetDebugFlags(uint Mask, byte bValueToSet) => ((delegate* unmanaged[Cdecl]<uint, byte, void>)0x00405E60)(Mask, bValueToSet);

    /// <summary>Gets the current set of debug flags for the Turbine debugging subsystem.
    /// <code>Offset: 0x00405E80
    /// unsigned int __cdecl Turbine::Debug::GetDebugFlags()</code>
    /// </summary>
    /// <returns>An unsigned integer representing the active debug flags.</returns>
    public static uint GetDebugFlags() => ((delegate* unmanaged[Cdecl]<uint>)0x00405E80)();

    /// <summary>Checks whether the supplied debug flag mask is present in the current debug flags.
    /// <code>Offset: 0x00405E90
    /// bool __cdecl Turbine::Debug::IsDebugFlagSet(unsigned int)</code>
    /// </summary>
    /// <param name="Value">A bitmask representing one or more debug flags to query.</param>
    /// <returns>True if all bits set in Value are active; otherwise false.</returns>
    public static byte IsDebugFlagSet(uint Value) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x00405E90)(Value);

    /// <summary>Immediately terminates the application after executing registered crash cleanup routines, ensuring a clean shutdown on debug abort.
    /// <code>Offset: 0x00405EB0
    /// void __cdecl Turbine::Debug::Abort()</code>
    /// </summary>
    public static void Abort() => ((delegate* unmanaged[Cdecl]<void>)0x00405EB0)();

    /// <summary>Reports an exception to the debugging subsystem, performing crash cleanup and adjusting internal flags before delegating to any previously registered exception filter.
    /// <code>Offset: 0x00405ED0
    /// int __cdecl Turbine::Debug::ReportException(_EXCEPTION_POINTERS*)</code>
    /// </summary>
    /// <param name="pep">Pointer to an EXCEPTION_POINTERS structure containing the exception record and context information.</param>
    /// <returns>Result of the previous exception filter if one was installed; otherwise zero.</returns>
    public static int ReportException(System.IntPtr pep) => ((delegate* unmanaged[Cdecl]<System.IntPtr, int>)0x00405ED0)(pep);

    /// <summary>Initializes a Turbine::Debug instance by assigning its virtual function table pointer.
    /// <code>Offset: 0x00405F30
    /// void __thiscall Turbine::Debug::Debug(Turbine::Debug*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Turbine.Debug, void>)0x00405F30)(ref this);

    /// <summary>Configures the floating‑point unit’s exception mask based on a condition and whether to suppress crashes when that condition occurs.
    /// <code>Offset: 0x00405FA0
    /// unsigned int __cdecl Turbine::Debug::SetFloatingPointException(bool,unsigned int)</code>
    /// </summary>
    /// <param name="fCrashOnCondition">If true, disables exceptions for the specified condition; otherwise enables them.</param>
    /// <param name="conditionToCheck">Bitmask specifying which floating-point exception flags should be modified.</param>
    /// <returns>The previous floating‑point control word value before the change.</returns>
    public static uint SetFloatingPointException(byte fCrashOnCondition, uint conditionToCheck) => ((delegate* unmanaged[Cdecl]<byte, uint, uint>)0x00405FA0)(fCrashOnCondition, conditionToCheck);

    /// <summary>Initializes common debug settings based on global flags, installing an unhandled exception filter and configuring the floating‑point control word when requested.
    /// <code>Offset: 0x00406220
    /// char __thiscall Turbine::Debug::InitCommon(Turbine::Debug*)</code>
    /// </summary>
    /// <returns>Always returns true to indicate successful initialization.</returns>
    public sbyte InitCommon() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Turbine.Debug, sbyte>)0x00406220)(ref this);

    /// <summary>Initializes Turbine's debugging subsystem with project information, configures flags, sets up logging and optional emergency memory allocation.
    /// <code>Offset: 0x00406300
    /// char __cdecl Turbine::Debug::Init(const char*,const char*,unsigned int)</code>
    /// </summary>
    /// <param name="pszProjectName">Human‑readable identifier for the project used in logs and assertions.</param>
    /// <param name="pszProjectEmail">E‑mail address associated with assertion failures or log entries.</param>
    /// <param name="dwFlags">Bitmask of debug options to clear from the current configuration before initialization.</param>
    /// <returns>Result returned by the internal debug initialization routine; its interpretation is implementation‑specific.</returns>
    public static sbyte Init(sbyte* pszProjectName, sbyte* pszProjectEmail, uint dwFlags) => ((delegate* unmanaged[Cdecl]<sbyte*, sbyte*, uint, sbyte>)0x00406300)(pszProjectName, pszProjectEmail, dwFlags);
}

