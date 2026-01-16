namespace ACBindings.Internal;


/// <summary>Encapsulates a texture‑based font, holding the source font identifier, render surface and material, character metrics, and flags controlling rendering readiness and scaling usage.</summary>
public unsafe struct TextureBasedFont
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct TextureBasedFont_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureBasedFont*, void> TextureBasedFont_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID m_SourceFontDID;
    public ACBindings.Internal.RenderTexture* m_pTexture;
    public ACBindings.Internal.RenderMaterial* m_pMaterial;
    public ushort m_FirstUnicodeCharacter;
    public ushort m_LastUnicodeCharacter;
    public uint m_MaxCharacterHeight;
    public uint m_HorizontalSpacing;
    public uint m_VerticalSpacing;
    public ACBindings.Internal.FixedArray___TextureBasedFontCharacter m_Characters;
    public byte m_IsReadyToRender;
    public byte m_QueuedTextUsesScaling;

    // Methods

    /// <summary>Initializes the font texture from the source font data, preparing character metrics and rendering glyphs into a render texture.
    /// <code>Offset: 0x00697140
    /// bool __thiscall TextureBasedFont::SetupFontTexture(TextureBasedFont*)</code>
    /// </summary>
    /// <returns>True if the texture was successfully created and populated; otherwise false.</returns>
    public byte SetupFontTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureBasedFont, byte>)0x00697140)(ref this);

    /// <summary>Computes the pixel width of a null‑terminated string using either uniform or per‑character spacing.
    /// <code>Offset: 0x006975A0
    /// unsigned int __thiscall TextureBasedFont::ComputeTextWidth(TextureBasedFont*,const char*,const unsigned int)</code>
    /// </summary>
    /// <param name="pText">The text whose width is being measured.</param>
    /// <param name="Flags">Bitmask controlling the spacing calculation; if bit 0 is set, the method uses m_HorizontalSpacing for every character, otherwise it uses each character’s width and horizontal offsets.</param>
    /// <returns>The total width in pixels required to render the string.</returns>
    public uint ComputeTextWidth(sbyte* pText, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureBasedFont, sbyte*, uint, uint>)0x006975A0)(ref this, pText, Flags);

    /// <summary>Generates vertex data for the supplied string using the font’s glyphs, applying scaling and alignment options before appending it to a global vertex buffer for later rendering.
    /// <code>Offset: 0x00697770
    /// void __thiscall TextureBasedFont::RenderText(TextureBasedFont*,const float,const float,const float,const char*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="X">The X coordinate of the text origin in screen space.</param>
    /// <param name="Y">The Y coordinate of the text origin in screen space.</param>
    /// <param name="Scale">Uniform scale factor applied to each character; if its absolute value exceeds 0.0002, the font’s m_QueuedTextUsesScaling flag is set.</param>
    /// <param name="pText">Null‑terminated sequence of byte values that index into the font’s character array; each value selects a glyph to render.</param>
    /// <param name="Color32">32‑bit ARGB color applied uniformly to all vertices generated for this text.</param>
    /// <param name="Flags">Bitmask controlling alignment, centering and spacing. Common bits include 0x8 (horizontal center), 0x10 (half horizontal center), 0x40 (vertical center) and the lowest bit which determines whether per‑character offsets are used or the font’s global spacing is applied.</param>
    public void RenderText(float X, float Y, float Scale, sbyte* pText, uint Color32, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureBasedFont, float, float, float, sbyte*, uint, uint, void>)0x00697770)(ref this, X, Y, Scale, pText, Color32, Flags);

    /// <summary>Renders the supplied string using this font at the specified screen position, applying the given color and rendering flags.
    /// <code>Offset: 0x00698330
    /// void __thiscall TextureBasedFont::RenderText(TextureBasedFont*,const int,const int,const char*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="X">Horizontal coordinate (in pixels) where the text starts.</param>
    /// <param name="Y">Vertical coordinate (in pixels) where the text baseline is positioned.</param>
    /// <param name="pText">Null-terminated string containing Unicode or ASCII characters to render.</param>
    /// <param name="Color32">32‑bit color value applied to all glyphs; typically ARGB or RGBA format.</param>
    /// <param name="Flags">Bitmask that modifies rendering behavior (e.g., alignment, scaling).</param>
    public void RenderText(int X, int Y, sbyte* pText, uint Color32, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureBasedFont, int, int, sbyte*, uint, uint, void>)0x00698330)(ref this, X, Y, pText, Color32, Flags);

    /// <summary>Initializes this TextureBasedFont instance with the glyphs of the given font, creating the required render texture and material configuration.
    /// <code>Offset: 0x00698360
    /// bool __thiscall TextureBasedFont::InitFromFont(TextureBasedFont*,const unsigned int)</code>
    /// </summary>
    /// <param name="FontID">Identifier for the source font to load into the texture-based font system.</param>
    /// <returns>True if the texture, material, and font data were successfully prepared; otherwise, false.</returns>
    public byte InitFromFont(uint FontID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureBasedFont, uint, byte>)0x00698360)(ref this, FontID);

    /// <summary>Creates a new TextureBasedFont instance from the specified font ID and returns operation status via the TResult parameter.
    /// <code>Offset: 0x006984F0
    /// TResult* __cdecl TextureBasedFont::CreateFromFont(TResult*,const unsigned int,TextureBasedFont**)</code>
    /// </summary>
    /// <param name="result">Pointer to a TResult object that receives the result code (0 for success, error code otherwise).</param>
    /// <param name="FontID">Identifier of the source font used to generate the texture-based font.</param>
    /// <param name="pOutObject">Output pointer set to the newly allocated TextureBasedFont on success; null if creation fails.</param>
    /// <returns>The TResult pointer supplied as input, now containing the operation status code.</returns>
    public static ACBindings.Internal.TResult* CreateFromFont(ACBindings.Internal.TResult* result, uint FontID, ACBindings.Internal.TextureBasedFont** pOutObject) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.TResult*, uint, ACBindings.Internal.TextureBasedFont**, ACBindings.Internal.TResult*>)0x006984F0)(result, FontID, pOutObject);
}

