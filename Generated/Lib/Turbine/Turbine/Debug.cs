namespace ACBindings.Turbine;

// Turbine::Debug
public unsafe struct Debug
{
    // Statics
    public static uint* DebugFlags = (uint*)0x00818338;
    public static ACBindings.Turbine.Debug* s_pDebug = (ACBindings.Turbine.Debug*)0x00818550;

    // Child Types
    // Turbine::Debug_vtbl
    public unsafe struct Debug_vtbl
    {
        // Members
        public System.IntPtr InitDebug; // function pointer

        // Methods
    }
    // Turbine::Debug::AssertIfFalseFmt
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
    // Turbine::Debug::AssertOnFailureFmtHelper
    public unsafe struct AssertOnFailureFmtHelper
    {
        // Members
        public ACBindings.TResult m_hrExpressionResult;
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
    // void __cdecl Turbine::Debug::SetDebugFlags(unsigned int,bool)
    public static void SetDebugFlags(uint Mask, byte bValueToSet) => ((delegate* unmanaged[Cdecl]<uint, byte, void>)0x00405E60)(Mask, bValueToSet);
    // unsigned int __cdecl Turbine::Debug::GetDebugFlags()
    public static uint GetDebugFlags() => ((delegate* unmanaged[Cdecl]<uint>)0x00405E80)();
    // bool __cdecl Turbine::Debug::IsDebugFlagSet(unsigned int)
    public static byte IsDebugFlagSet(uint Value) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x00405E90)(Value);
    // void __cdecl Turbine::Debug::Abort()
    public static void Abort() => ((delegate* unmanaged[Cdecl]<void>)0x00405EB0)();
    // int __cdecl Turbine::Debug::ReportException(_EXCEPTION_POINTERS*)
    public static int ReportException(System.IntPtr pep) => ((delegate* unmanaged[Cdecl]<System.IntPtr, int>)0x00405ED0)(pep);
    // void __thiscall Turbine::Debug::Debug(Turbine::Debug*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Turbine.Debug, void>)0x00405F30)(ref this);
    // unsigned int __cdecl Turbine::Debug::SetFloatingPointException(bool,unsigned int)
    public static uint SetFloatingPointException(byte fCrashOnCondition, uint conditionToCheck) => ((delegate* unmanaged[Cdecl]<byte, uint, uint>)0x00405FA0)(fCrashOnCondition, conditionToCheck);
    // char __thiscall Turbine::Debug::InitCommon(Turbine::Debug*)
    public sbyte InitCommon() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Turbine.Debug, sbyte>)0x00406220)(ref this);
    // char __cdecl Turbine::Debug::Init(const char*,const char*,unsigned int)
    public static sbyte Init(sbyte* pszProjectName, sbyte* pszProjectEmail, uint dwFlags) => ((delegate* unmanaged[Cdecl]<sbyte*, sbyte*, uint, sbyte>)0x00406300)(pszProjectName, pszProjectEmail, dwFlags);
}

