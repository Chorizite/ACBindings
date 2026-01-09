namespace ACBindings;

// TextureBasedFont
public unsafe struct TextureBasedFont
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // TextureBasedFont_vtbl
    public unsafe struct TextureBasedFont_vtbl
    {
        // Members
        public System.IntPtr TextureBasedFont_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IDClass___tagDataID m_SourceFontDID;
    public ACBindings.RenderTexture* m_pTexture;
    public ACBindings.RenderMaterial* m_pMaterial;
    public ushort m_FirstUnicodeCharacter;
    public ushort m_LastUnicodeCharacter;
    public uint m_MaxCharacterHeight;
    public uint m_HorizontalSpacing;
    public uint m_VerticalSpacing;
    public ACBindings.FixedArray__TextureBasedFontCharacter m_Characters;
    public byte m_IsReadyToRender;
    public byte m_QueuedTextUsesScaling;

    // Methods
    // bool __thiscall TextureBasedFont::SetupFontTexture(TextureBasedFont*)
    public byte SetupFontTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextureBasedFont, byte>)0x00697140)(ref this);
    // unsigned int __thiscall TextureBasedFont::ComputeTextWidth(TextureBasedFont*,const char*,const unsigned int)
    public uint ComputeTextWidth(sbyte* pText, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextureBasedFont, sbyte*, uint, uint>)0x006975A0)(ref this, pText, Flags);
    // void __thiscall TextureBasedFont::RenderText(TextureBasedFont*,const float,const float,const float,const char*,const unsigned int,const unsigned int)
    public void RenderText(float X, float Y, float Scale, sbyte* pText, uint Color32, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextureBasedFont, float, float, float, sbyte*, uint, uint, void>)0x00697770)(ref this, X, Y, Scale, pText, Color32, Flags);
    // void __thiscall TextureBasedFont::RenderText(TextureBasedFont*,const int,const int,const char*,const unsigned int,const unsigned int)
    public void RenderText(int X, int Y, sbyte* pText, uint Color32, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextureBasedFont, int, int, sbyte*, uint, uint, void>)0x00698330)(ref this, X, Y, pText, Color32, Flags);
    // bool __thiscall TextureBasedFont::InitFromFont(TextureBasedFont*,const unsigned int)
    public byte InitFromFont(uint FontID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextureBasedFont, uint, byte>)0x00698360)(ref this, FontID);
    // TResult* __cdecl TextureBasedFont::CreateFromFont(TResult*,const unsigned int,TextureBasedFont**)
    public static ACBindings.TResult* CreateFromFont(ACBindings.TResult* result, uint FontID, ACBindings.TextureBasedFont** pOutObject) => ((delegate* unmanaged[Cdecl]<ACBindings.TResult*, uint, ACBindings.TextureBasedFont**, ACBindings.TResult*>)0x006984F0)(result, FontID, pOutObject);
}

