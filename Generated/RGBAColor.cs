namespace ACBindings.Internal;


/// <summary>Represents an RGBA color with floating‑point components for red, green, blue, and alpha, used throughout the rendering system to define colors and opacity.</summary>
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

    /// <summary>Combines normalized red, green, blue, and alpha components into a 32‑bit ARGB value.
    /// <code>Offset: 0x0043DBE0
    /// unsigned int __cdecl RGBAColor::MakeRGBA(float,float,float,float)</code>
    /// </summary>
    /// <param name="r">Red component in the range [0,1].</param>
    /// <param name="g">Green component in the range [0,1].</param>
    /// <param name="b">Blue component in the range [0,1].</param>
    /// <param name="a">Alpha component in the range [0,1].</param>
    /// <returns>32‑bit unsigned integer with alpha in the highest byte followed by red, green, and blue.</returns>
    public static uint MakeRGBA(float r, float g, float b, float a) => ((delegate* unmanaged[Cdecl]<float, float, float, float, uint>)0x0043DBE0)(r, g, b, a);

    /// <summary>Clamps each color channel (r, g, b, a) of this RGBAColor to a maximum of 1.0, modifying the object in place.
    /// <code>Offset: 0x00447490
    /// void __thiscall RGBAColor::CapHigh(RGBAColor*)</code>
    /// </summary>
    public void CapHigh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBAColor, void>)0x00447490)(ref this);

    /// <summary>Verifies that r, g, b, and a components are within the normalized range [-0.00019999999, 1.0002].
    /// <code>Offset: 0x0065C360
    /// bool __thiscall RGBAColor::IsValid(RGBAColor*)</code>
    /// </summary>
    /// <returns>True when all components lie inside the specified bounds; otherwise false.</returns>
    public byte IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBAColor, byte>)0x0065C360)(ref this);

    /// <summary>Serializes or deserializes this RGBAColor to or from an Archive, writing a 32‑bit color value when saving and reading it back when loading.
    /// <code>Offset: 0x0065C3F0
    /// void __thiscall RGBAColor::Serialize(RGBAColor*,Archive*)</code>
    /// </summary>
    /// <param name="this">The RGBAColor instance being processed.</param>
    /// <param name="io_archive">Archive that provides storage for the color data; its flags determine read/write behavior.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBAColor, ACBindings.Internal.Archive*, void>)0x0065C3F0)(ref this, io_archive);

    /// <summary>Creates sub-nodes for the red, green, blue, and alpha components of this color within the given file node.
    /// <code>Offset: 0x0065C470
    /// bool __thiscall RGBAColor::ToFileNode(RGBAColor*,PFileNode*)</code>
    /// </summary>
    /// <param name="node">File node to populate with color component values.</param>
    /// <returns>True when all four component nodes were created successfully; otherwise false.</returns>
    public byte ToFileNode(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBAColor, ACBindings.Internal.PFileNode*, byte>)0x0065C470)(ref this, node);

    /// <summary>Parses color data from a file node into an RGBAColor structure, supporting both float and integer representations and optional alpha channel extraction.
    /// <code>Offset: 0x0065C4E0
    /// bool __thiscall RGBAColor::FromFileNode(RGBAColor*,const PFileNode*,bool,bool)</code>
    /// </summary>
    /// <param name="node">The PFileNode containing the color components to read.</param>
    /// <param name="read_as_float">If true, interprets component values as floats; otherwise treats them as 0‑255 integers.</param>
    /// <param name="read_alpha">When true, expects a fourth subnode for the alpha channel; otherwise defaults alpha to 1.0.</param>
    /// <returns>True if parsing succeeds and the resulting color is valid; otherwise reports an error and returns false.</returns>
    public byte FromFileNode(ACBindings.Internal.PFileNode* node, byte read_as_float, byte read_alpha) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBAColor, ACBindings.Internal.PFileNode*, byte, byte, byte>)0x0065C4E0)(ref this, node, read_as_float, read_alpha);
}

