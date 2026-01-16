namespace ACBindings.Internal;


/// <summary>Tracks a text asset with reference counting, specifying its type and encoding format.</summary>
public unsafe struct TextTag
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct TextTag_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag*, void> TextTag_dtor_0; // function pointer
        public System.IntPtr ParseEndTag;
        public System.IntPtr ParseStartTag;
        public System.IntPtr BuildEndTag;
        public System.IntPtr BuildStartTag;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag*, uint, byte> HandleClick; // function pointer
        public System.IntPtr BuildStartTagData;

        // Methods
    }

    // Members
    public uint m_type;
    public uint m_format;

    // Generated Constructor
    public TextTag() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a new TextTag instance with default type and format, setting up reference counting and the virtual function table pointer.
    /// <code>Offset: 0x00479380
    /// void __thiscall TextTag::TextTag(TextTag*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag, void>)0x00479380)(ref this);

    /// <summary>Decrements an internal reference counter and, when it reaches zero, triggers cleanup for the TextTag instance.
    /// <code>Offset: 0x004793B0
    /// char __stdcall TextTag::ParseStartTag(int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the TextTag object whose reference count is modified.</param>
    /// <returns>Zero; indicates successful completion.</returns>
    public static sbyte ParseStartTag(int a1) => ((delegate* unmanaged[Stdcall]<int, sbyte>)0x004793B0)(a1);

    /// <summary>Constructs an XML‑style start tag for this TextTag instance and writes the formatted wide‑character string into the supplied buffer.
    /// <code>Offset: 0x004793E0
    /// char __thiscall TextTag::BuildStartTag(int*,wchar_t**)</code>
    /// </summary>
    /// <param name="a2">Pointer that will receive the newly allocated wide‑character string containing the start tag.</param>
    /// <returns>Non‑zero if the tag was successfully assembled; zero otherwise.</returns>
    public sbyte BuildStartTag(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag, System.IntPtr, sbyte>)0x004793E0)(ref this, a2);

    /// <summary>Creates a formatted end‑tag string from this TextTag's type and stores it in the supplied buffer.
    /// <code>Offset: 0x00479590
    /// char __thiscall TextTag::BuildEndTag(int*,wchar_t**)</code>
    /// </summary>
    /// <param name="a2">Pointer to receive the constructed end‑tag string, e.g., &lt;\%ls&gt; where %ls is the tag name.</param>
    /// <returns>1 if the tag was successfully generated; 0 otherwise.</returns>
    public sbyte BuildEndTag(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag, System.IntPtr, sbyte>)0x00479590)(ref this, a2);

    /// <summary>Parses a character buffer containing an end tag, verifies that it begins with '&lt;' and ends with '&gt;', maps the enclosed name to an enum value, and compares it against this TextTag's format field. Returns true when the parsed tag matches the expected type; otherwise returns false.
    /// <code>Offset: 0x00479630
    /// bool __thiscall TextTag::ParseEndTag(_DWORD*,_WORD*)</code>
    /// </summary>
    /// <param name="this">Pointer to the TextTag instance being evaluated.</param>
    /// <param name="a2">Reference‑counted buffer holding the end tag string to parse.</param>
    /// <returns>True if the buffer contains a matching end tag for this TextTag; otherwise, false.</returns>
    public byte ParseEndTag(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag, System.IntPtr, byte>)0x00479630)(ref this, a2);
}

