namespace ACBindings.Internal;


/// <summary>Core client subsystem providing UI scroll management, message routing, and plugin interaction via its IUnknown base interface and GM notice handler.</summary>
public unsafe struct ClientSystem
{
    // Base Classes
    public ACBindings.Internal.Interface BaseClass_Interface; // ACBindings.Internal.Interface
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Statics
    public static byte** s_pLogFile = (byte**)0x008712C4;

    // Child Types
    public unsafe struct ClientSystem_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnStartup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnBeginCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnEndCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnShutdown; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Adds the specified text to a scrolling display, optionally forwarding it to an external API after converting the string to Unicode. The function manages reference counting for the original string and appends the converted text to the scroll destination.
    /// <code>Offset: 0x004882F0
    /// void __thiscall ClientSystem::AddTextToScroll(ClientSystem*,const char*,unsigned int,bool,unsigned int)</code>
    /// </summary>
    /// <param name="i_text">The message string to append to the scrollable display.</param>
    /// <param name="i_ltt">Length of the input text in characters.</param>
    /// <param name="i_sendToAPI">If true, forwards the appended text to an external API after adding it.</param>
    /// <param name="i_nOverrideDestination">Optional identifier used to override the default scroll destination.</param>
    public void AddTextToScroll(sbyte* i_text, uint i_ltt, byte i_sendToAPI, uint i_nOverrideDestination) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientSystem, sbyte*, uint, byte, uint, void>)0x004882F0)(ref this, i_text, i_ltt, i_sendToAPI, i_nOverrideDestination);

    /// <summary>Adds an ANSI text string to the client system’s scrolling display, then decreases the string object's reference counter and releases it when the count reaches zero.
    /// <code>Offset: 0x004C3010
    /// LONG __thiscall ClientSystem::AddTextToScroll(void*,int,unsigned int,char,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Unused integer parameter (reserved for future use).</param>
    /// <param name="a3">Identifier of the scroll buffer or message type to which the text will be added.</param>
    /// <param name="a4">Display style or priority indicator affecting how the text appears in the scroll view.</param>
    /// <param name="a5">Pointer to an ANSI string object; the function converts it to wide‑char, adds it to the scroll view, then decrements its reference count and releases it if the count drops to zero.</param>
    /// <returns>The decremented reference count of the string object, or the value returned by the object's release routine when the count reaches zero.</returns>
    public int AddTextToScroll(int a2, uint a3, sbyte a4, uint a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientSystem, int, uint, sbyte, uint, int>)0x004C3010)(ref this, a2, a3, a4, a5);

    /// <summary>Adds a message to the client scroll display, optionally logging via AC plugin, applying censoring and timestamps, and handling long messages by writing to a log file.
    /// <code>Offset: 0x005649F0
    /// LONG __thiscall ClientSystem::AddTextToScroll(void*,const OLECHAR**,unsigned int,char,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the wide-character string to display.</param>
    /// <param name="i_lt">Message type identifier used for formatting or routing.</param>
    /// <param name="a4">Flag that triggers use of AC plugin when available; non‑zero attempts to add text via the plugin.</param>
    /// <param name="i_idDestinationOverride">Optional destination identifier override for message routing.</param>
    /// <returns>The result code from the operation; zero indicates success, non‑zero indicates an error or fallback path.</returns>
    public int AddTextToScroll(System.IntPtr a2, uint i_lt, sbyte a4, uint i_idDestinationOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientSystem, System.IntPtr, uint, sbyte, uint, int>)0x005649F0)(ref this, a2, i_lt, a4, i_idDestinationOverride);
}

