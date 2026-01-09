namespace ACBindings;

// ArgumentParser
public unsafe struct ArgumentParser
{
    // Child Types
    // ArgumentParser_vtbl
    public unsafe struct ArgumentParser_vtbl
    {
        // Members
        public System.IntPtr Usage; // function pointer
        public fixed byte gap4[12];
        public System.IntPtr ParseArgs; // function pointer
        public fixed byte gap14[4];
        public System.IntPtr ParseCommandLine; // function pointer
        public System.IntPtr DisplayUsage; // function pointer
        public System.IntPtr SetErrorText;
        public System.IntPtr AppendOutputText; // function pointer
        public System.IntPtr AppendAndWordWrap; // function pointer
        public System.IntPtr AppendArgumentText;
        public System.IntPtr FinishOutputText; // function pointer
        public System.IntPtr GetCharactersToWrapUsageTo; // function pointer
        public System.IntPtr BuildCommandLineArgs; // function pointer
        public fixed byte gap3C[4];
        public System.IntPtr EvaluateCommandLineArg;
        public System.IntPtr OnCommandLineEvaluationDone; // function pointer
        public System.IntPtr IsCommandLineArgument;

        // Methods
    }
    // ArgumentParser::CommandLineArgList
    public unsafe struct CommandLineArgList : System.IDisposable
    {
        // Base Classes
        public ACBindings.SmartArray__CommandLineArg BaseClass_SmartArray; // ACBindings.SmartArray__CommandLineArg

        // Members
        public ACBindings.AutoGrowHashTable__CaseInsensitiveStringBase__PStringBase__ushort__int m_LongNamesHash;
        public ACBindings.AutoGrowHashTable__ushort__int m_ShortNamesHash;

        // Generated Constructor
        public CommandLineArgList() {
            _ConstructorInternal();
        }

        // Generated Dispose
        public void Dispose() {
            _DestructorInternal();
        }

        // Methods
        // char __thiscall ArgumentParser::CommandLineArgList::AddCmd(ArgumentParser::CommandLineArgList*,int,char,void**,void**,void*,unsigned int,unsigned int)
        public sbyte AddCmd(int a2, sbyte a3, void** a4, void** a5, System.IntPtr a6, uint a7, uint a8) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser.CommandLineArgList, int, sbyte, void**, void**, System.IntPtr, uint, uint, sbyte>)0x00402660)(ref this, a2, a3, a4, a5, a6, a7, a8);
        // int __thiscall ArgumentParser::CommandLineArgList::FindByShortCmd(ArgumentParser::CommandLineArgList*,wchar_t)
        public int FindByShortCmd(System.Char ShortCmd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser.CommandLineArgList, System.Char, int>)0x00408F80)(ref this, ShortCmd);
        // int __thiscall ArgumentParser::CommandLineArgList::FindByLongCmd(_DWORD*,_DWORD*)
        public int FindByLongCmd(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser.CommandLineArgList, int*, int>)0x004092C0)(ref this, a2);
        // char __thiscall ArgumentParser::CommandLineArgList::add(ArgumentParser::CommandLineArgList*,const CommandLineArg*)
        public sbyte add(ACBindings.CommandLineArg* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser.CommandLineArgList, ACBindings.CommandLineArg*, sbyte>)0x0040A0D0)(ref this, data);
        // void __thiscall ArgumentParser::CommandLineArgList::CommandLineArgList(ArgumentParser::CommandLineArgList*)
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser.CommandLineArgList, void>)0x0040A2B0)(ref this);
        // void __thiscall ArgumentParser::CommandLineArgList::~CommandLineArgList(ArgumentParser::CommandLineArgList*)
        public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser.CommandLineArgList, void>)0x0040A310)(ref this);
    }
    // ArgumentParser::OutputTextType
    public enum OutputTextType : byte
    {
        ottNormal = 0x0,
        ottErrorText = 0x1,
        ottShortVersion = 0x2,
        ottLongVersion = 0x3,
        ottDescription = 0x4
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.PStringBase__sbyte m_ErrorText;
    public ACBindings.PStringBase__sbyte m_CmdChars;
    public System.IntPtr m_argv;
    public int m_argc;
    public int m_CurArg;

    // Methods
    // void __thiscall ArgumentParser::AppendOutputText(ArgumentParser*,const char*,ArgumentParser::OutputTextType)
    public void AppendOutputText(sbyte* Text, ACBindings.ArgumentParser.OutputTextType i_eFormattingHint) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser, sbyte*, ACBindings.ArgumentParser.OutputTextType, void>)0x00407550)(ref this, Text, i_eFormattingHint);
    // int __thiscall ArgumentParser::ParseArgs(int*,const wchar_t*,int)
    public int ParseArgs(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser, System.IntPtr, int, int>)0x00407600)(ref this, a2, a3);
    // LONG __thiscall ArgumentParser::AppendArgumentText(_DWORD*,const char*,const char*,int)
    public int AppendArgumentText(sbyte* a2, sbyte* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser, sbyte*, sbyte*, int, int>)0x00407B50)(ref this, a2, a3, a4);
    // LONG __thiscall ArgumentParser::SetErrorText(_DWORD*,int*)
    public int SetErrorText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser, int*, int>)0x00407D30)(ref this, a2);
    // char __stdcall ArgumentParser::EvaluateCommandLineArg(_DWORD*,const char*)
    public static sbyte EvaluateCommandLineArg(int* a1, sbyte* a2) => ((delegate* unmanaged[Stdcall]<int*, sbyte*, sbyte>)0x004083F0)(a1, a2);
    // int __thiscall ArgumentParser::AppendAndWordWrap(ArgumentParser*,const char*,int,int,ArgumentParser::OutputTextType)
    public int AppendAndWordWrap(sbyte* Text, int nIndent, int iCursorX, ACBindings.ArgumentParser.OutputTextType i_eFormattingHint) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser, sbyte*, int, int, ACBindings.ArgumentParser.OutputTextType, int>)0x00408A60)(ref this, Text, nIndent, iCursorX, i_eFormattingHint);
    // char __thiscall ArgumentParser::IsCommandLineArgument(const char**,const wchar_t**,int)
    public sbyte IsCommandLineArgument(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser, System.IntPtr, int, sbyte>)0x00408CB0)(ref this, a2, a3);
    // void __thiscall ArgumentParser::DisplayUsage(ArgumentParser*,const ArgumentParser::CommandLineArgList*)
    public void DisplayUsage(ACBindings.ArgumentParser.CommandLineArgList* UnsortedArgs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser, ACBindings.ArgumentParser.CommandLineArgList*, void>)0x00409330)(ref this, UnsortedArgs);
    // char __thiscall ArgumentParser::EvaluateCommandLineArg(int*,_DWORD*,int*)
    public sbyte EvaluateCommandLineArg(int* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser, int*, int*, sbyte>)0x00409860)(ref this, a2, a3);
    // bool __thiscall ArgumentParser::ParseCommandLine(ArgumentParser*,const char*,BOOL)
    public byte ParseCommandLine(sbyte* commandline, byte fSkipArgv0) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser, sbyte*, byte, byte>)0x00409900)(ref this, commandline, fSkipArgv0);
    // char __thiscall ArgumentParser::ParseCommandLine(ArgumentParser*,const wchar_t*,int)
    public sbyte ParseCommandLine(System.IntPtr commandline, int fSkipArgv0) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser, System.IntPtr, int, sbyte>)0x00409A00)(ref this, commandline, fSkipArgv0);
    // char __thiscall ArgumentParser::ParseArgs(ArgumentParser*,char**,int,int)
    public sbyte ParseArgs(sbyte** argv, int argc, int fSkipArgv0) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser, sbyte**, int, int, sbyte>)0x00409B00)(ref this, argv, argc, fSkipArgv0);
    // void __thiscall ArgumentParser::Usage(ArgumentParser*)
    public void Usage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser, void>)0x0040A3B0)(ref this);
    // bool __thiscall ArgumentParser::ParseArgs(ArgumentParser*,wchar_t**,int,bool)
    public byte ParseArgs(System.IntPtr argv, int argc, byte fSkipArgv0) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser, System.IntPtr, int, byte, byte>)0x0040A400)(ref this, argv, argc, fSkipArgv0);
    // int __thiscall ArgumentParser::GetCharactersToWrapUsageTo(ArgumentParser*)
    public int GetCharactersToWrapUsageTo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArgumentParser, int>)0x00412B60)(ref this);
}

