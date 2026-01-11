namespace ACBindings.Internal;

public unsafe struct ArgumentParser
{
    // Child Types
    public unsafe struct ArgumentParser_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArgumentParser*, void> Usage; // function pointer
        public fixed byte gap4[12];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArgumentParser*, sbyte**, int, byte, byte> ParseArgs; // function pointer
        public fixed byte gap14[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArgumentParser*, sbyte*, byte, byte> ParseCommandLine; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArgumentParser*, ACBindings.Internal.ArgumentParser.CommandLineArgList*, void> DisplayUsage; // function pointer
        public System.IntPtr SetErrorText;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArgumentParser*, sbyte*, ACBindings.Internal.ArgumentParser.OutputTextType, void> AppendOutputText; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArgumentParser*, sbyte*, int, int, ACBindings.Internal.ArgumentParser.OutputTextType, int> AppendAndWordWrap; // function pointer
        public System.IntPtr AppendArgumentText;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArgumentParser*, void> FinishOutputText; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArgumentParser*, int> GetCharactersToWrapUsageTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArgumentParser*, ACBindings.Internal.ArgumentParser.CommandLineArgList*, void> BuildCommandLineArgs; // function pointer
        public fixed byte gap3C[4];
        public System.IntPtr EvaluateCommandLineArg;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArgumentParser*, byte> OnCommandLineEvaluationDone; // function pointer
        public System.IntPtr IsCommandLineArgument;

        // Methods
    }
    public unsafe struct CommandLineArgList : System.IDisposable
    {
        // Base Classes
        public ACBindings.Internal.SmartArray___CommandLineArg BaseClass_SmartArray; // ACBindings.Internal.SmartArray___CommandLineArg

        // Members
        public ACBindings.Internal.AutoGrowHashTable___CaseInsensitiveStringBase___PStringBase__ushort__int m_LongNamesHash;
        public ACBindings.Internal.AutoGrowHashTable__ushort__int m_ShortNamesHash;

        // Generated Constructor
        public CommandLineArgList() {
            _ConstructorInternal();
        }

        // Generated Dispose
        public void Dispose() {
            _DestructorInternal();
        }

        // Methods

        /// <summary>Adds a new command-line option to the list, associating it with long and short names, a description, a target variable, a default value, and user data.
        /// <code>Offset: 0x00402660
        /// char __thiscall ArgumentParser::CommandLineArgList::AddCmd(ArgumentParser::CommandLineArgList*,int,char,void**,void**,void*,unsigned int,unsigned int)</code>
        /// </summary>
        /// <param name="argType">Specifies the type of argument being added.</param>
        /// <param name="shortName">Single‑character short form for the option.</param>
        /// <param name="longNamePtr">Pointer to the long‑name string buffer; its reference count is managed automatically.</param>
        /// <param name="descriptionPtr">Pointer to the description text buffer; reference counting is handled internally.</param>
        /// <param name="variableToModify">Address of the variable that will receive the parsed value.</param>
        /// <param name="valueToStore">Default or expected value for the option if present.</param>
        /// <param name="userData">Custom data associated with this argument definition.</param>
        /// <returns>Nonzero if the command was added successfully; zero otherwise.</returns>
        public sbyte AddCmd(int a2, sbyte a3, void** a4, void** a5, System.IntPtr a6, uint a7, uint a8) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser.CommandLineArgList, int, sbyte, void**, void**, System.IntPtr, uint, uint, sbyte>)0x00402660)(ref this, a2, a3, a4, a5, a6, a7, a8);

        /// <summary>Searches the short‑name hash table for the specified command character and returns its associated index, or -1 when no match exists.
        /// <code>Offset: 0x00408F80
        /// int __thiscall ArgumentParser::CommandLineArgList::FindByShortCmd(ArgumentParser::CommandLineArgList*,wchar_t)</code>
        /// </summary>
        /// <param name="ShortCmd">The single‑character short name to locate.</param>
        /// <returns>The index of the matching argument in the internal array, or -1 if none is found.</returns>
        public int FindByShortCmd(System.Char ShortCmd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser.CommandLineArgList, System.Char, int>)0x00408F80)(ref this, ShortCmd);

        /// <summary>Searches for a long‑named command-line option within this list and returns its zero‑based index, or –1 when the name is absent.
        /// <code>Offset: 0x004092C0
        /// int __thiscall ArgumentParser::CommandLineArgList::FindByLongCmd(_DWORD*,_DWORD*)</code>
        /// </summary>
        /// <param name="this">The CommandLineArgList instance to search.</param>
        /// <param name="a2">Pointer to the reference‑counted string containing the long name of the option.</param>
        /// <returns>-1 if no matching command is found; otherwise, the index of the matched argument in the internal array.</returns>
        public int FindByLongCmd(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser.CommandLineArgList, int*, int>)0x004092C0)(ref this, a2);

        /// <summary>Adds a command line argument definition to the list if no duplicate short or long name exists, updating internal hash tables that map names to indices.
        /// <code>Offset: 0x0040A0D0
        /// char __thiscall ArgumentParser::CommandLineArgList::add(ArgumentParser::CommandLineArgList*,const CommandLineArg*)</code>
        /// </summary>
        /// <param name="this">The CommandLineArgList instance to which the argument will be added.</param>
        /// <param name="data">Pointer to a CommandLineArg structure containing the argument's metadata (short and long names, description, etc.).</param>
        /// <returns>Non-zero if the argument was added successfully; zero if an argument with the same short or long name already exists.</returns>
        public sbyte add(ACBindings.Internal.CommandLineArg* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser.CommandLineArgList, ACBindings.Internal.CommandLineArg*, sbyte>)0x0040A0D0)(ref this, data);

        /// <summary>Initializes an empty command line argument list, setting up the underlying smart array and hash tables for long and short option names.
        /// <code>Offset: 0x0040A2B0
        /// void __thiscall ArgumentParser::CommandLineArgList::CommandLineArgList(ArgumentParser::CommandLineArgList*)</code>
        /// </summary>
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser.CommandLineArgList, void>)0x0040A2B0)(ref this);

        /// <summary>Destroys a CommandLineArgList instance, releasing all allocated resources such as the command line argument array and short‑/long‑name hash tables.
        /// <code>Offset: 0x0040A310
        /// void __thiscall ArgumentParser::CommandLineArgList::~CommandLineArgList(ArgumentParser::CommandLineArgList*)</code>
        /// </summary>
        public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser.CommandLineArgList, void>)0x0040A310)(ref this);
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
    public ACBindings.Internal.PStringBase__sbyte m_ErrorText;
    public ACBindings.Internal.PStringBase__sbyte m_CmdChars;
    public System.IntPtr m_argv;
    public int m_argc;
    public int m_CurArg;

    // Methods

    /// <summary>Outputs the given text with optional formatting: error messages are bolded, short or long version texts are underlined; otherwise the text is written to standard output.
    /// <code>Offset: 0x00407550
    /// void __thiscall ArgumentParser::AppendOutputText(ArgumentParser*,const char*,ArgumentParser::OutputTextType)</code>
    /// </summary>
    /// <param name="Text">The string to display. If null or empty, nothing is printed.</param>
    /// <param name="i_eFormattingHint">Hints how to format the text (error, short, long, or default).</param>
    public void AppendOutputText(sbyte* Text, ACBindings.Internal.ArgumentParser.OutputTextType i_eFormattingHint) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser, sbyte*, ACBindings.Internal.ArgumentParser.OutputTextType, void>)0x00407550)(ref this, Text, i_eFormattingHint);

    /// <summary>Parses arguments into the ArgumentParser instance by delegating to an internal parser. If the third 32‑bit value at the address supplied in a2 is non‑zero, that value is treated as an argument count and the first value is passed; otherwise the parser uses a default command string.
    /// <code>Offset: 0x00407600
    /// int __thiscall ArgumentParser::ParseArgs(int*,const wchar_t*,int)</code>
    /// </summary>
    /// <param name="this">Pointer to the ArgumentParser object invoking this method.</param>
    /// <param name="a2">Source of argument data: interpreted either as a structure whose third dword indicates the number of arguments or, if that value is zero, treated as the address of a default command string.</param>
    /// <param name="a3">Additional parameter forwarded to the underlying parsing routine (typically context or flags).</param>
    /// <returns>Result code returned by the internal parsing function (zero on success, non‑zero otherwise).</returns>
    public int ParseArgs(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser, System.IntPtr, int, int>)0x00407600)(ref this, a2, a3);

    /// <summary>Parses argument data supplied in <paramref name="a2"/>, delegating to the appropriate virtual parsing routine based on an internal flag within the input buffer.
    /// <code>Offset: 0x00407640
    /// int __thiscall ArgumentParser::ParseArgs_1(int*,const wchar_t*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a wide‑character buffer or structure that contains the arguments. The function examines the third 32‑bit field of this buffer; if it is non‑zero, a specialized parser is invoked, otherwise a default parser is used.</param>
    /// <param name="a3">Additional value passed unchanged to the chosen parsing routine (typically flags or an index).</param>
    /// <returns>Integer status code returned by the selected parsing routine; zero conventionally indicates success.</returns>
    public int ParseArgs_1(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser, System.IntPtr, int, int>)0x00407640)(ref this, a2, a3);

    /// <summary>Formats an argument name together with its optional description and appends the result to the parser’s internal output buffer, applying proper prefixes, spacing, and a colon separator.
    /// <code>Offset: 0x00407B50
    /// LONG __thiscall ArgumentParser::AppendArgumentText(_DWORD*,const char*,const char*,int)</code>
    /// </summary>
    /// <param name="this">Pointer to the ArgumentParser instance that owns the output buffer.</param>
    /// <param name="a2">The argument identifier string (for example, an option flag such as “-f”).</param>
    /// <param name="a3">Optional help text associated with the argument; may be empty or a placeholder value.</param>
    /// <param name="a4">Reference‑counted buffer object that receives the formatted text and is updated after use.</param>
    /// <returns>The reference count of the output buffer after appending, or zero if the buffer was released.</returns>
    public int AppendArgumentText(sbyte* a2, sbyte* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser, sbyte*, sbyte*, int, int>)0x00407B50)(ref this, a2, a3, a4);

    /// <summary>Assigns a new error message to the parser while updating reference counts for the underlying string object.
    /// <code>Offset: 0x00407D30
    /// LONG __thiscall ArgumentParser::SetErrorText(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the string instance that will replace the current error text.</param>
    /// <returns>The reference count of the new error text after incrementing, or the previous pointer value when the supplied string equals the current one.</returns>
    public int SetErrorText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser, int*, int>)0x00407D30)(ref this, a2);

    /// <summary>Parses a command‑line argument based on the descriptor pointed to by the first parameter and stores the result into the location specified in that descriptor.
    /// <code>Offset: 0x004083F0
    /// char __stdcall ArgumentParser::EvaluateCommandLineArg(_DWORD*,const char*)</code>
    /// </summary>
    /// <param name="a1">Pointer to an argument descriptor whose first byte encodes the expected data type (e.g., integer, float, string, boolean) and whose fields specify where the parsed value should be written.</param>
    /// <param name="a2">C‑style string containing the raw argument value supplied on the command line.</param>
    /// <returns>Non‑zero if the argument was successfully parsed and stored; zero otherwise.</returns>
    public static sbyte EvaluateCommandLineArg(int* a1, sbyte* a2) => ((delegate* unmanaged[Stdcall]<int*, sbyte*, sbyte>)0x004083F0)(a1, a2);

    /// <summary>Appends the supplied string to the parser’s output buffer, automatically wrapping words at a configured maximum line width while indenting each new line by a specified number of spaces.
    /// <code>Offset: 0x00408A60
    /// int __thiscall ArgumentParser::AppendAndWordWrap(ArgumentParser*,const char*,int,int,ArgumentParser::OutputTextType)</code>
    /// </summary>
    /// <param name="Text">Null‑terminated C string containing the text to append.</param>
    /// <param name="nIndent">Number of space characters that precede every line in the appended block; if zero or negative, no indentation is added.</param>
    /// <param name="iCursorX">Initial cursor position (number of characters already on the current line) before appending this block; used to determine when a word would exceed the wrap limit.</param>
    /// <param name="i_eFormattingHint">Output text formatting hint passed to AppendOutputText for each character.</param>
    /// <returns>Updated cursor column after the text has been appended (the number of characters in the current line).</returns>
    public int AppendAndWordWrap(sbyte* Text, int nIndent, int iCursorX, ACBindings.Internal.ArgumentParser.OutputTextType i_eFormattingHint) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser, sbyte*, int, int, ACBindings.Internal.ArgumentParser.OutputTextType, int>)0x00408A60)(ref this, Text, nIndent, iCursorX, i_eFormattingHint);

    /// <summary>Checks if the supplied wide‑character argument begins with one of the parser’s command prefix characters and, when the flag is zero, performs special handling that may modify the argument list.
    /// <code>Offset: 0x00408CB0
    /// char __thiscall ArgumentParser::IsCommandLineArgument(const char**,const wchar_t**,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a wide‑character string representing the current command line argument.</param>
    /// <param name="a3">Flag controlling special handling; if zero, the function may alter the argument array to insert default options.</param>
    /// <returns>Non‑zero (1) when the argument is recognized as a command‑line option; otherwise 0.</returns>
    public sbyte IsCommandLineArgument(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser, System.IntPtr, int, sbyte>)0x00408CB0)(ref this, a2, a3);

    /// <summary>Displays sorted usage information for all provided command‑line arguments, including short and long option names along with their descriptions.
    /// <code>Offset: 0x00409330
    /// void __thiscall ArgumentParser::DisplayUsage(ArgumentParser*,const ArgumentParser::CommandLineArgList*)</code>
    /// </summary>
    /// <param name="UnsortedArgs">List of command‑line arguments whose usage should be displayed.</param>
    public void DisplayUsage(ACBindings.Internal.ArgumentParser.CommandLineArgList* UnsortedArgs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser, ACBindings.Internal.ArgumentParser.CommandLineArgList*, void>)0x00409330)(ref this, UnsortedArgs);

    /// <summary>Processes a command‑line argument token; if the token starts with ':', assigns its value to *a3; otherwise forwards the token to a virtual handler and returns that handler's status.
    /// <code>Offset: 0x00409860
    /// char __thiscall ArgumentParser::EvaluateCommandLineArg(int*,_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the current argument token, where the first byte indicates the token type (e.g., ':' prefix) and subsequent elements provide data for processing.</param>
    /// <param name="a3">Pointer to an integer that will be updated with a reference to a string object containing the parsed value when applicable.</param>
    /// <returns>1 if the token was handled as a key‑value pair, otherwise the status returned by the virtual handler (non‑zero typically indicates success).</returns>
    public sbyte EvaluateCommandLineArg(int* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser, int*, int*, sbyte>)0x00409860)(ref this, a2, a3);

    /// <summary>Parses a raw command line string into arguments, optionally ignoring the program name.
    /// <code>Offset: 0x00409900
    /// bool __thiscall ArgumentParser::ParseCommandLine(ArgumentParser*,const char*,BOOL)</code>
    /// </summary>
    /// <param name="commandline">The null‑terminated command line string to parse; must not be NULL.</param>
    /// <param name="fSkipArgv0">If true, skips the first argument (typically the executable name).</param>
    /// <returns>True if parsing succeeds; otherwise false and an error message is stored internally.</returns>
    public byte ParseCommandLine(sbyte* commandline, byte fSkipArgv0) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser, sbyte*, byte, byte>)0x00409900)(ref this, commandline, fSkipArgv0);

    /// <summary>Parses a wide‑character command line into an argument list, storing the result internally and optionally skipping the first argument. On failure it records an error message such as “Unmatched quote”.
    /// <code>Offset: 0x00409A00
    /// char __thiscall ArgumentParser::ParseCommandLine(ArgumentParser*,const wchar_t*,int)</code>
    /// </summary>
    /// <param name="commandline">Wide string containing the complete command line to parse.</param>
    /// <param name="fSkipArgv0">If non‑zero, omits the first argument from the resulting list (commonly the program name).</param>
    /// <returns>1 if parsing succeeded; 0 if an error occurred. In the latter case, the parser’s error text is set to describe the failure.</returns>
    public sbyte ParseCommandLine(System.IntPtr commandline, int fSkipArgv0) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser, System.IntPtr, int, sbyte>)0x00409A00)(ref this, commandline, fSkipArgv0);

    /// <summary>
    /// Parses a command line argument list, converting each C‑style string to a wide string, stores them temporarily, then forwards the array to an overridden handler for interpretation.
    /// 
    /// <code>Offset: 0x00409B00
    /// char __thiscall ArgumentParser::ParseArgs(ArgumentParser*,char**,int,int)</code>
    /// </summary>
    /// <param name="argv">Array of null‑terminated character strings containing the arguments.</param>
    /// <param name="argc">Number of elements in argv.</param>
    /// <param name="fSkipArgv0">When non‑zero, ignores the first argument (typically the executable name).</param>
    /// <returns>Non‑zero on successful parse; zero if parsing failed or an error was reported.</returns>
    public sbyte ParseArgs(sbyte** argv, int argc, int fSkipArgv0) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser, sbyte**, int, int, sbyte>)0x00409B00)(ref this, argv, argc, fSkipArgv0);

    /// <summary>Displays command‑line usage information based on the configured arguments, building a list of options, rendering help text, and completing any pending output formatting.
    /// <code>Offset: 0x0040A3B0
    /// void __thiscall ArgumentParser::Usage(ArgumentParser*)</code>
    /// </summary>
    public void Usage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser, void>)0x0040A3B0)(ref this);

    /// <summary>Parses command line arguments supplied via argv/argc, optionally skipping the program name, evaluating each against registered options and recording results.
    /// <code>Offset: 0x0040A400
    /// bool __thiscall ArgumentParser::ParseArgs(ArgumentParser*,wchar_t**,int,bool)</code>
    /// </summary>
    /// <param name="argv">Array of wide‑character strings representing the command line arguments.</param>
    /// <param name="argc">Number of elements in the argv array.</param>
    /// <param name="fSkipArgv0">If true, begins parsing from the second element (index 1), ignoring the program name at index 0.</param>
    /// <returns>True if all arguments are processed without error; false otherwise.</returns>
    public byte ParseArgs(System.IntPtr argv, int argc, byte fSkipArgv0) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser, System.IntPtr, int, byte, byte>)0x0040A400)(ref this, argv, argc, fSkipArgv0);

    /// <summary>Returns the maximum number of characters to wrap usage text at.
    /// <code>Offset: 0x00412B60
    /// int __thiscall ArgumentParser::GetCharactersToWrapUsageTo(ArgumentParser*)</code>
    /// </summary>
    /// <returns>The maximum line width used for command‑line help formatting.</returns>
    public int GetCharactersToWrapUsageTo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArgumentParser, int>)0x00412B60)(ref this);
}

