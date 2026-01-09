namespace ACBindings;

// CParseXml
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
    // void __thiscall CParseXml::CParseXml(CParseXml*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CParseXml, void>)0x00557E40)(ref this);
    // void __thiscall CParseXml::~CParseXml(CParseXml*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CParseXml, void>)0x00557E60)(ref this);
    // bool __thiscall CParseXml::Init(CParseXml*)
    public byte Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CParseXml, byte>)0x00557E80)(ref this);
}

