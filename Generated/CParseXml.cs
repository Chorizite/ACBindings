namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00557E40
    /// void __thiscall CParseXml::CParseXml(CParseXml*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CParseXml, void>)0x00557E40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00557E60
    /// void __thiscall CParseXml::~CParseXml(CParseXml*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CParseXml, void>)0x00557E60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00557E80
    /// bool __thiscall CParseXml::Init(CParseXml*)</code>
    /// </summary>
    public byte Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CParseXml, byte>)0x00557E80)(ref this);
}

