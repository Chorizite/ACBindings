namespace ACBindings.Internal;


/// <summary>Provides an interactive debug console that captures user commands, displays log output, supports history navigation and tab completion. It manages input and output buffers, rendering windows, and integrates with the global registry for configuration variables and command callbacks.</summary>
public unsafe struct DebugConsole : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate
    public ACBindings.Internal.CInputHandler BaseClass_CInputHandler; // ACBindings.Internal.CInputHandler
    public ACBindings.Internal.NoticeHandler BaseClass_NoticeHandler; // ACBindings.Internal.NoticeHandler
    public ACBindings.Internal.IConsoleCallbackObject BaseClass_IConsoleCallbackObject; // ACBindings.Internal.IConsoleCallbackObject
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback

    // Statics
    public static ACBindings.Internal.DebugConsole** sm_pCurrentDebugConsole = (ACBindings.Internal.DebugConsole**)0x008F94A0;

    // Child Types
    public unsafe struct DebugConsole_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DebugConsole*, void> DebugConsole_dtor_0; // function pointer

        // Methods
    }

    // Members
    public byte m_WantActivateInput;
    public byte m_WantDeactivateInput;
    public byte m_IsInputActive;
    public byte m_AlwaysDrawOutput;
    public float m_BackgroundOpacity;
    public ACBindings.Internal.GlyphList* m_pInputBuffer;
    public ACBindings.Internal.GlyphList* m_pOutputBuffer;
    public byte m_OutputBufferIsDirty;
    public ACBindings.Internal.QuickWindow* m_pOutputWindow;
    public ACBindings.Internal.QuickWindow* m_pInputWindow;
    public uint m_NumOutputLines;
    public uint m_NumOutputCharactersPerLine;
    public uint m_OutputScrollPos;
    public ACBindings.Internal.PStringBaseArray__sbyte m_OutputLines;
    public uint m_NumInputCharactersPerLine;
    public uint m_InputCursorPos;
    public byte m_IsInputCursorVisible;
    public double m_LastInputCursorStateTime;
    public ACBindings.Internal.PStringBaseArray__sbyte m_InputHistory;
    public ACBindings.Internal.PStringBase__sbyte m_LastTabCompletionWord;
    public ACBindings.Internal.PStringBase__sbyte m_LastTabCompletionString;
    public int m_LastInputHistoryPos;
    public ACBindings.Internal.RenderTexture* m_pOutputBackgroundTexture;
    public ACBindings.Internal.RenderTexture* m_pInputBackgroundTexture;
    public byte m_EchoInput;

    // Generated Constructor
    public DebugConsole() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Clears the current debug console's input buffer and marks its output for redrawing.
    /// <code>Offset: 0x00690FE0
    /// bool __cdecl DebugConsole::ConsoleCommand_Clear()</code>
    /// </summary>
    /// <returns>True to indicate the command executed successfully; always true when a console is available.</returns>
    public static byte ConsoleCommand_Clear() => ((delegate* unmanaged[Cdecl]<byte>)0x00690FE0)();

    /// <summary>Updates the debug console’s input state when activation or deactivation is requested, toggling input handling and registering or deregistering the necessary callbacks accordingly.
    /// <code>Offset: 0x00691060
    /// void __thiscall DebugConsole::Think(DebugConsole*)</code>
    /// </summary>
    public void Think() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691060)(ref this);

    /// <summary>Invalidates any cached tab‑completion data by resetting the stored word and string buffers, releasing associated reference counts so that future completions regenerate fresh suggestions.
    /// <code>Offset: 0x00691120
    /// void __thiscall DebugConsole::InvalidateTabCompletion(DebugConsole*)</code>
    /// </summary>
    public void InvalidateTabCompletion() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691120)(ref this);

    /// <summary>Deletes the character immediately before the current input cursor, moves the cursor back one position, clears any stored input‑history index, and invalidates tab‑completion data.
    /// <code>Offset: 0x006911A0
    /// void __thiscall DebugConsole::InputBackspaceCharacter(DebugConsole*)</code>
    /// </summary>
    public void InputBackspaceCharacter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x006911A0)(ref this);

    /// <summary>Adjusts the console’s output buffer scroll position upward by a specified amount, clamping to valid limits and marking the buffer as dirty for repaint.
    /// <code>Offset: 0x006911D0
    /// void __thiscall DebugConsole::InputScrollOutputBufferUp(DebugConsole*,const unsigned int)</code>
    /// </summary>
    /// <param name="NumLinesToScrollUp">Number of lines to shift the output upwards.</param>
    public void InputScrollOutputBufferUp(uint NumLinesToScrollUp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, uint, void>)0x006911D0)(ref this, NumLinesToScrollUp);

    /// <summary>Scrolls the console’s output buffer downward by a given number of lines. If the view is already at or beyond the bottom, the scroll position resets to display the most recent page.
    /// <code>Offset: 0x00691200
    /// void __thiscall DebugConsole::InputScrollOutputBufferDown(DebugConsole*,const unsigned int)</code>
    /// </summary>
    /// <param name="NumLinesToScrollDown">The number of lines to move the view downwards.</param>
    public void InputScrollOutputBufferDown(uint NumLinesToScrollDown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, uint, void>)0x00691200)(ref this, NumLinesToScrollDown);

    /// <summary>Scrolls the console's output buffer to the top when its content exceeds the visible line count, marking it dirty for refresh.
    /// <code>Offset: 0x00691250
    /// void __thiscall DebugConsole::InputScrollOutputBufferToTop(DebugConsole*)</code>
    /// </summary>
    public void InputScrollOutputBufferToTop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691250)(ref this);

    /// <summary>Deletes the character at the current input cursor position in the console’s input buffer if the cursor is valid, then resets history tracking and invalidates any cached tab‑completion data.
    /// <code>Offset: 0x00691270
    /// void __thiscall DebugConsole::InputDeleteCharacter(DebugConsole*)</code>
    /// </summary>
    public void InputDeleteCharacter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691270)(ref this);

    /// <summary>Replaces the console's input buffer with glyphs representing each character from a given string, ignoring newline characters.
    /// <code>Offset: 0x006912A0
    /// int __thiscall DebugConsole::SetInputBufferContents(int,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the string whose contents will be loaded into the input buffer.</param>
    /// <returns>The original string pointer (unused by callers).</returns>
    public int SetInputBufferContents(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, int*, int>)0x006912A0)(ref this, a2);

    /// <summary>Selects the preceding entry from the console's input history and updates the current input buffer to that command. If the history is empty, no action occurs.
    /// <code>Offset: 0x00691350
    /// void __thiscall DebugConsole::SelectPreviousCommandInInputHistory(DebugConsole*)</code>
    /// </summary>
    public void SelectPreviousCommandInInputHistory() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691350)(ref this);

    /// <summary>Advances the console’s input history selection forward by one command, wrapping to the first entry when at the end or when no previous selection exists, and updates the input buffer with the selected command.
    /// <code>Offset: 0x00691390
    /// void __thiscall DebugConsole::SelectNextCommandInInputHistory(DebugConsole*)</code>
    /// </summary>
    public void SelectNextCommandInInputHistory() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691390)(ref this);

    /// <summary>Initializes the debug console by registering it with the global registry, exposing configuration variables such as AlwaysDrawOutput, EchoInput, and BackgroundOpacity, registering built‑in commands like Clear, and attaching an input action callback when available.
    /// <code>Offset: 0x006913D0
    /// bool __thiscall DebugConsole::Startup(DebugConsole*)</code>
    /// </summary>
    /// <returns>True on success (always true in this implementation).</returns>
    public byte Startup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, byte>)0x006913D0)(ref this);

    /// <summary>Shuts down the debug console by unregistering its console callback object, all related commands and variables, and detaching any notice handlers or input action callbacks from global systems.
    /// <code>Offset: 0x00691620
    /// void __thiscall DebugConsole::Shutdown(DebugConsole*)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691620)(ref this);

    /// <summary>Recalculates console dimensions, updating the number of output lines and characters per line from the output window size, setting input character width from the input window, resetting the output buffer array, and marking the output buffer dirty.
    /// <code>Offset: 0x00691770
    /// void __thiscall DebugConsole::UpdateCoordinates(DebugConsole*)</code>
    /// </summary>
    public void UpdateCoordinates() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691770)(ref this);

    /// <summary>Appends the supplied character buffer to the console's output glyph list, converting each byte into a Glyph and marking the output as dirty.
    /// <code>Offset: 0x006917C0
    /// int __thiscall DebugConsole::AppendTextToOutputBuffer(int,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a buffer containing text. The first element points to the string data, while the length is stored in the 4 bytes preceding that pointer.</param>
    /// <returns>Number of glyphs added to the output list (or zero if no text was appended).</returns>
    public int AppendTextToOutputBuffer(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, int*, int>)0x006917C0)(ref this, a2);

    /// <summary>Initializes the console output buffer by clearing existing content, ensuring the global registry is available, retrieving stored output strings from the registry, appending them to the buffer, and marking the buffer as dirty.
    /// <code>Offset: 0x00691930
    /// void __thiscall DebugConsole::InitOutputBuffer(DebugConsole*)</code>
    /// </summary>
    public void InitOutputBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691930)(ref this);

    /// <summary>Constructs a DebugConsole instance, setting up reference counting, initializing all internal state variables, allocating input/output glyph buffers, and creating the output and input QuickWindow objects for console rendering.
    /// <code>Offset: 0x00691AC0
    /// void __thiscall DebugConsole::DebugConsole(DebugConsole*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691AC0)(ref this);

    /// <summary>Destroys a DebugConsole instance by releasing owned resources such as glyph lists, quick windows, render textures, and cached strings, then resets internal state. Also clears the static current console pointer and unregisters input callbacks.
    /// <code>Offset: 0x00691C70
    /// void __thiscall DebugConsole::~DebugConsole(DebugConsole*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691C70)(ref this);

    /// <summary>Creates a new DebugConsole object, initializes it, and returns the operation result in the supplied TResult argument.
    /// <code>Offset: 0x00691DC0
    /// TResult* __cdecl DebugConsole::Create(TResult*,DebugConsole**)</code>
    /// </summary>
    /// <param name="result">Container for the HRESULT value indicating success or failure of creation.</param>
    /// <param name="pOutDebugConsole">Receives pointer to the created DebugConsole on success; set to null if initialization fails.</param>
    /// <returns>The original TResult pointer after its m_val member has been updated with the result code.</returns>
    public static ACBindings.Internal.TResult* Create(ACBindings.Internal.TResult* result, ACBindings.Internal.DebugConsole** pOutDebugConsole) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.TResult*, ACBindings.Internal.DebugConsole**, ACBindings.Internal.TResult*>)0x00691DC0)(result, pOutDebugConsole);

    /// <summary>Processes an input event for the debug console, handling actions such as command entry, history navigation, and output scrolling. Returns true when the event is consumed by the console.
    /// <code>Offset: 0x00691E60
    /// bool __thiscall DebugConsole::OnAction(DebugConsole*,const InputEvent*)</code>
    /// </summary>
    /// <param name="i_evt">The input event to process.</param>
    /// <returns>True if the console handled the event; otherwise false.</returns>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, ACBindings.Internal.InputEvent*, byte>)0x00691E60)(ref this, i_evt);

    /// <summary>Executes the current console input when Enter is pressed: parses and runs the entered command, optionally echoes it to the output, updates history, refreshes tab‑completion data, and finally clears the input buffer.
    /// <code>Offset: 0x00692080
    /// void __thiscall DebugConsole::InputEnter(DebugConsole*)</code>
    /// </summary>
    public void InputEnter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00692080)(ref this);

    /// <summary>Refreshes the console’s output buffer when marked dirty, recalculating glyph layout, handling scroll position, and updating internal output line storage for rendering.
    /// <code>Offset: 0x00692230
    /// void __thiscall DebugConsole::RefreshOutputBuffer(DebugConsole*)</code>
    /// </summary>
    public void RefreshOutputBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00692230)(ref this);

    /// <summary>Renders the debug console’s output and input areas, drawing backgrounds, text content, scroll bars, and a blinking cursor when active.
    /// <code>Offset: 0x00692470
    /// void __thiscall DebugConsole::Render(DebugConsole*)</code>
    /// </summary>
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00692470)(ref this);

    /// <summary>Completes the current console input by searching the global registry for matching command or variable names, cycling through results in the direction specified by SearchForward.
    /// <code>Offset: 0x00692B40
    /// void __thiscall DebugConsole::InputTabCompletion(DebugConsole*,const bool)</code>
    /// </summary>
    /// <param name="SearchForward">If true, advance to the next matching entry; if false, move to the previous one. The function updates the input buffer and internal completion state accordingly.</param>
    public void InputTabCompletion(byte SearchForward) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, byte, void>)0x00692B40)(ref this, SearchForward);

    /// <summary>Handles a single input character for the debug console, executing backspace, tab completion, enter submission, or inserting printable characters into the output buffer.
    /// <code>Offset: 0x00693370
    /// void __thiscall DebugConsole::CharacterHandler(DebugConsole*,wchar_t)</code>
    /// </summary>
    /// <param name="Char">The Unicode character to process.</param>
    public void CharacterHandler(System.Char Char) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, System.Char, void>)0x00693370)(ref this, Char);
}

