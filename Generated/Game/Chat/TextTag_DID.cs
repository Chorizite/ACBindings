namespace ACBindings.Internal;


/// <summary>Represents a text tag carrying a data identifier used in the application’s UI system. Handles click events by dispatching its type and associated ID, and parses start tags to populate its identifier field.</summary>
public unsafe struct TextTag_DID
{
    // Base Classes
    public ACBindings.Internal.TextTag BaseClass_TextTag; // ACBindings.Internal.TextTag

    // Child Types
    public unsafe struct TextTag_DID_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_DID*, void> TextTag_DID_dtor_0; // function pointer
        public System.IntPtr ParseEndTag;
        public System.IntPtr ParseStartTag;
        public System.IntPtr BuildEndTag;
        public System.IntPtr BuildStartTag;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_DID*, uint, byte> HandleClick; // function pointer
        public System.IntPtr BuildStartTagData;

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID m_DID;

    // Generated Constructor
    public TextTag_DID() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// Processes a click on the TextTag_DID instance by sending its type and data ID through ECM_UI.
    /// 
    /// <code>Offset: 0x00478B40
    /// bool __thiscall TextTag_DID::HandleClick(TextTag_DID*,unsigned int)</code>
    /// </summary>
    /// <param name="button">The identifier of the mouse button that triggered the event.</param>
    /// <returns>Always true, indicating the click was handled successfully.</returns>
    public byte HandleClick(uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_DID, uint, byte>)0x00478B40)(ref this, button);

    /// <summary>Initializes a TextTag_DID instance by invoking the base TextTag constructor and marking its data identifier as invalid.
    /// <code>Offset: 0x00478B60
    /// void __thiscall TextTag_DID::TextTag_DID(TextTag_DID*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_DID, void>)0x00478B60)(ref this);

    /// <summary>Parses a numeric identifier from the supplied wide‑character string and stores it in the tag’s data ID field, returning success status.
    /// <code>Offset: 0x004792D0
    /// char __thiscall TextTag_DID::ParseStartTag(wchar_t*,wchar_t*)</code>
    /// </summary>
    /// <param name="String">Pointer to this TextTag_DID instance (implicit this).</param>
    /// <param name="Stringa">Wide‑character string containing the identifier to parse.</param>
    /// <returns>Non‑zero if parsing succeeds; zero otherwise.</returns>
    public sbyte ParseStartTag(System.IntPtr Stringa) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_DID, System.IntPtr, sbyte>)0x004792D0)(ref this, Stringa);
}

