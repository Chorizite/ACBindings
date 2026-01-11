namespace ACBindings.Internal;

public unsafe struct DebugConsole : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate
    public ACBindings.Internal.CInputHandler BaseClass_CInputHandler; // ACBindings.Internal.CInputHandler
    public ACBindings.Internal.NoticeHandler BaseClass_NoticeHandler; // ACBindings.Internal.NoticeHandler
    public ACBindings.Internal.IConsoleCallbackObject BaseClass_IConsoleCallbackObject; // ACBindings.Internal.IConsoleCallbackObject
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback

    // Statics
    public static ACBindings.Internal.DebugConsole* sm_pCurrentDebugConsole = (ACBindings.Internal.DebugConsole*)0x008F94A0;

    // Child Types
    public unsafe struct DebugConsole_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DebugConsole*, void> DebugConsole_dtor_0; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00690FE0
    /// bool __cdecl DebugConsole::ConsoleCommand_Clear()</code>
    /// </summary>
    public static byte ConsoleCommand_Clear() => ((delegate* unmanaged[Cdecl]<byte>)0x00690FE0)();

    /// <summary>
    /// <code>Offset: 0x00691060
    /// void __thiscall DebugConsole::Think(DebugConsole*)</code>
    /// </summary>
    public void Think() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691060)(ref this);

    /// <summary>
    /// <code>Offset: 0x00691120
    /// void __thiscall DebugConsole::InvalidateTabCompletion(DebugConsole*)</code>
    /// </summary>
    public void InvalidateTabCompletion() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691120)(ref this);

    /// <summary>
    /// <code>Offset: 0x006911A0
    /// void __thiscall DebugConsole::InputBackspaceCharacter(DebugConsole*)</code>
    /// </summary>
    public void InputBackspaceCharacter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x006911A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006911D0
    /// void __thiscall DebugConsole::InputScrollOutputBufferUp(DebugConsole*,const unsigned int)</code>
    /// </summary>
    public void InputScrollOutputBufferUp(uint NumLinesToScrollUp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, uint, void>)0x006911D0)(ref this, NumLinesToScrollUp);

    /// <summary>
    /// <code>Offset: 0x00691200
    /// void __thiscall DebugConsole::InputScrollOutputBufferDown(DebugConsole*,const unsigned int)</code>
    /// </summary>
    public void InputScrollOutputBufferDown(uint NumLinesToScrollDown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, uint, void>)0x00691200)(ref this, NumLinesToScrollDown);

    /// <summary>
    /// <code>Offset: 0x00691250
    /// void __thiscall DebugConsole::InputScrollOutputBufferToTop(DebugConsole*)</code>
    /// </summary>
    public void InputScrollOutputBufferToTop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691250)(ref this);

    /// <summary>
    /// <code>Offset: 0x00691270
    /// void __thiscall DebugConsole::InputDeleteCharacter(DebugConsole*)</code>
    /// </summary>
    public void InputDeleteCharacter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691270)(ref this);

    /// <summary>
    /// <code>Offset: 0x006912A0
    /// int __thiscall DebugConsole::SetInputBufferContents(int,int*)</code>
    /// </summary>
    public int SetInputBufferContents(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, int*, int>)0x006912A0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00691350
    /// void __thiscall DebugConsole::SelectPreviousCommandInInputHistory(DebugConsole*)</code>
    /// </summary>
    public void SelectPreviousCommandInInputHistory() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691350)(ref this);

    /// <summary>
    /// <code>Offset: 0x00691390
    /// void __thiscall DebugConsole::SelectNextCommandInInputHistory(DebugConsole*)</code>
    /// </summary>
    public void SelectNextCommandInInputHistory() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691390)(ref this);

    /// <summary>
    /// <code>Offset: 0x006913D0
    /// bool __thiscall DebugConsole::Startup(DebugConsole*)</code>
    /// </summary>
    public byte Startup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, byte>)0x006913D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00691620
    /// void __thiscall DebugConsole::Shutdown(DebugConsole*)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691620)(ref this);

    /// <summary>
    /// <code>Offset: 0x00691770
    /// void __thiscall DebugConsole::UpdateCoordinates(DebugConsole*)</code>
    /// </summary>
    public void UpdateCoordinates() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691770)(ref this);

    /// <summary>
    /// <code>Offset: 0x006917C0
    /// int __thiscall DebugConsole::AppendTextToOutputBuffer(int,int*)</code>
    /// </summary>
    public int AppendTextToOutputBuffer(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, int*, int>)0x006917C0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00691930
    /// void __thiscall DebugConsole::InitOutputBuffer(DebugConsole*)</code>
    /// </summary>
    public void InitOutputBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691930)(ref this);

    /// <summary>
    /// <code>Offset: 0x00691AC0
    /// void __thiscall DebugConsole::DebugConsole(DebugConsole*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691AC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00691C70
    /// void __thiscall DebugConsole::~DebugConsole(DebugConsole*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00691C70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00691DC0
    /// TResult* __cdecl DebugConsole::Create(TResult*,DebugConsole**)</code>
    /// </summary>
    public static ACBindings.Internal.TResult* Create(ACBindings.Internal.TResult* result, ACBindings.Internal.DebugConsole** pOutDebugConsole) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.TResult*, ACBindings.Internal.DebugConsole**, ACBindings.Internal.TResult*>)0x00691DC0)(result, pOutDebugConsole);

    /// <summary>
    /// <code>Offset: 0x00691E60
    /// bool __thiscall DebugConsole::OnAction(DebugConsole*,const InputEvent*)</code>
    /// </summary>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, ACBindings.Internal.InputEvent*, byte>)0x00691E60)(ref this, i_evt);

    /// <summary>
    /// <code>Offset: 0x00692080
    /// void __thiscall DebugConsole::InputEnter(DebugConsole*)</code>
    /// </summary>
    public void InputEnter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00692080)(ref this);

    /// <summary>
    /// <code>Offset: 0x00692230
    /// void __thiscall DebugConsole::RefreshOutputBuffer(DebugConsole*)</code>
    /// </summary>
    public void RefreshOutputBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00692230)(ref this);

    /// <summary>
    /// <code>Offset: 0x00692470
    /// void __thiscall DebugConsole::Render(DebugConsole*)</code>
    /// </summary>
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, void>)0x00692470)(ref this);

    /// <summary>
    /// <code>Offset: 0x00692B40
    /// void __thiscall DebugConsole::InputTabCompletion(DebugConsole*,const bool)</code>
    /// </summary>
    public void InputTabCompletion(byte SearchForward) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, byte, void>)0x00692B40)(ref this, SearchForward);

    /// <summary>
    /// <code>Offset: 0x00693370
    /// void __thiscall DebugConsole::CharacterHandler(DebugConsole*,wchar_t)</code>
    /// </summary>
    public void CharacterHandler(System.Char Char) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DebugConsole, System.Char, void>)0x00693370)(ref this, Char);
}

