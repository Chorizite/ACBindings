namespace ACBindings.Internal;

public unsafe struct RGBAColor
{
    // Members
    public float r;
    public float g;
    public float b;
    public float a;

    // Methods

    /// <summary>Returns a 32‑bit ARGB value packed from the RGBAColor's components scaled to [0,255].
    /// <code>Offset: 0x00424000
    /// unsigned int __thiscall RGBAColor::GetColor32(RGBAColor*)</code>
    /// </summary>
    /// <returns>The color as an unsigned int with bytes arranged as A (bits 24–31), R (16–23), G (8–15) and B (0–7).</returns>
    public uint GetColor32() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBAColor, uint>)0x00424000)(ref this);

    /// <summary>Assigns RGBA components from a packed 32-bit ARGB value, converting each byte to a floating‑point component in the range [0, 1].
    /// <code>Offset: 0x00430CD0
    /// void __thiscall RGBAColor::SetColor32(RGBAColor*,const unsigned int)</code>
    /// </summary>
    /// <param name="this">The RGBAColor instance whose color is being set.</param>
    /// <param name="color">A 32‑bit unsigned integer containing alpha, red, green, and blue bytes (most significant byte first).</param>
    public void SetColor32(uint color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBAColor, uint, void>)0x00430CD0)(ref this, color);

    /// <summary>
    /// <code>Offset: 0x0043DBE0
    /// unsigned int __cdecl RGBAColor::MakeRGBA(float,float,float,float)</code>
    /// </summary>
    public static uint MakeRGBA(float r, float g, float b, float a) => ((delegate* unmanaged[Cdecl]<float, float, float, float, uint>)0x0043DBE0)(r, g, b, a);

    /// <summary>
    /// <code>Offset: 0x00447490
    /// void __thiscall RGBAColor::CapHigh(RGBAColor*)</code>
    /// </summary>
    public void CapHigh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBAColor, void>)0x00447490)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065C360
    /// bool __thiscall RGBAColor::IsValid(RGBAColor*)</code>
    /// </summary>
    public byte IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBAColor, byte>)0x0065C360)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065C3F0
    /// void __thiscall RGBAColor::Serialize(RGBAColor*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBAColor, ACBindings.Internal.Archive*, void>)0x0065C3F0)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0065C470
    /// bool __thiscall RGBAColor::ToFileNode(RGBAColor*,PFileNode*)</code>
    /// </summary>
    public byte ToFileNode(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBAColor, ACBindings.Internal.PFileNode*, byte>)0x0065C470)(ref this, node);

    /// <summary>
    /// <code>Offset: 0x0065C4E0
    /// bool __thiscall RGBAColor::FromFileNode(RGBAColor*,const PFileNode*,bool,bool)</code>
    /// </summary>
    public byte FromFileNode(ACBindings.Internal.PFileNode* node, byte read_as_float, byte read_alpha) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBAColor, ACBindings.Internal.PFileNode*, byte, byte, byte>)0x0065C4E0)(ref this, node, read_as_float, read_alpha);
}

