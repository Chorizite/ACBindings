namespace ACBindings;

// RGBAColor
public unsafe struct RGBAColor
{
    // Members
    public float r;
    public float g;
    public float b;
    public float a;

    // Methods
    // unsigned int __thiscall RGBAColor::GetColor32(RGBAColor*)
    public uint GetColor32() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RGBAColor, uint>)0x00424000)(ref this);
    // void __thiscall RGBAColor::SetColor32(RGBAColor*,const unsigned int)
    public void SetColor32(uint color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RGBAColor, uint, void>)0x00430CD0)(ref this, color);
    // unsigned int __cdecl RGBAColor::MakeRGBA(float,float,float,float)
    public static uint MakeRGBA(float r, float g, float b, float a) => ((delegate* unmanaged[Cdecl]<float, float, float, float, uint>)0x0043DBE0)(r, g, b, a);
    // void __thiscall RGBAColor::CapHigh(RGBAColor*)
    public void CapHigh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RGBAColor, void>)0x00447490)(ref this);
    // bool __thiscall RGBAColor::IsValid(RGBAColor*)
    public byte IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RGBAColor, byte>)0x0065C360)(ref this);
    // void __thiscall RGBAColor::Serialize(RGBAColor*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RGBAColor, ACBindings.Archive*, void>)0x0065C3F0)(ref this, io_archive);
    // bool __thiscall RGBAColor::ToFileNode(RGBAColor*,PFileNode*)
    public byte ToFileNode(ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RGBAColor, ACBindings.PFileNode*, byte>)0x0065C470)(ref this, node);
    // bool __thiscall RGBAColor::FromFileNode(RGBAColor*,const PFileNode*,bool,bool)
    public byte FromFileNode(ACBindings.PFileNode* node, byte read_as_float, byte read_alpha) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RGBAColor, ACBindings.PFileNode*, byte, byte, byte>)0x0065C4E0)(ref this, node, read_as_float, read_alpha);
}

