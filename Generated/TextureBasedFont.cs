namespace ACBindings.Internal;

public unsafe struct TextureBasedFont
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct TextureBasedFont_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureBasedFont*, void> TextureBasedFont_dtor_0; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00697140
    /// bool __thiscall TextureBasedFont::SetupFontTexture(TextureBasedFont*)</code>
    /// </summary>
    public byte SetupFontTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureBasedFont, byte>)0x00697140)(ref this);

    /// <summary>
    /// <code>Offset: 0x006975A0
    /// unsigned int __thiscall TextureBasedFont::ComputeTextWidth(TextureBasedFont*,const char*,const unsigned int)</code>
    /// </summary>
    public uint ComputeTextWidth(sbyte* pText, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureBasedFont, sbyte*, uint, uint>)0x006975A0)(ref this, pText, Flags);

    /// <summary>
    /// <code>Offset: 0x00697770
    /// void __thiscall TextureBasedFont::RenderText(TextureBasedFont*,const float,const float,const float,const char*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public void RenderText(float X, float Y, float Scale, sbyte* pText, uint Color32, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureBasedFont, float, float, float, sbyte*, uint, uint, void>)0x00697770)(ref this, X, Y, Scale, pText, Color32, Flags);

    /// <summary>
    /// <code>Offset: 0x00698330
    /// void __thiscall TextureBasedFont::RenderText(TextureBasedFont*,const int,const int,const char*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public void RenderText(int X, int Y, sbyte* pText, uint Color32, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureBasedFont, int, int, sbyte*, uint, uint, void>)0x00698330)(ref this, X, Y, pText, Color32, Flags);

    /// <summary>
    /// <code>Offset: 0x00698360
    /// bool __thiscall TextureBasedFont::InitFromFont(TextureBasedFont*,const unsigned int)</code>
    /// </summary>
    public byte InitFromFont(uint FontID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureBasedFont, uint, byte>)0x00698360)(ref this, FontID);

    /// <summary>
    /// <code>Offset: 0x006984F0
    /// TResult* __cdecl TextureBasedFont::CreateFromFont(TResult*,const unsigned int,TextureBasedFont**)</code>
    /// </summary>
    public static ACBindings.Internal.TResult* CreateFromFont(ACBindings.Internal.TResult* result, uint FontID, ACBindings.Internal.TextureBasedFont** pOutObject) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.TResult*, uint, ACBindings.Internal.TextureBasedFont**, ACBindings.Internal.TResult*>)0x006984F0)(result, FontID, pOutObject);
}

