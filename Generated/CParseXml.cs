namespace ACBindings.Internal;


/// <summary>Encapsulates an MSXML IXMLDOMDocument2 instance for parsing XML documents within a 32‑bit Windows application, managing COM creation and cleanup automatically.</summary>
/// <remarks>Provides Init to instantiate the DOM object and releases it in the destructor, ensuring proper reference counting.</remarks>
public unsafe struct CParseXml : System.IDisposable
{
    // Generated Constructor
    public CParseXml() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases the MSXML DOM document interface owned by the instance, ensuring proper cleanup of COM resources.
    /// <code>Offset: 0x00557E40
    /// void __thiscall CParseXml::CParseXml(CParseXml*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CParseXml, void>)0x00557E40)(ref this);

    /// <summary>Releases the underlying XML COM interface and clears its reference during object destruction.
    /// <code>Offset: 0x00557E60
    /// void __thiscall CParseXml::~CParseXml(CParseXml*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CParseXml, void>)0x00557E60)(ref this);

    /// <summary>Initializes the CParseXml object by creating an MSXML2 IXMLDOMDocument instance and preparing it for XML parsing. Returns true if initialization succeeds, otherwise false.
    /// <code>Offset: 0x00557E80
    /// bool __thiscall CParseXml::Init(CParseXml*)</code>
    /// </summary>
    /// <returns>True when the DOM document is successfully created and initialized; otherwise false.</returns>
    public byte Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CParseXml, byte>)0x00557E80)(ref this);
}

