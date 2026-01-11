namespace ACBindings.Internal;

public unsafe struct GlyphList : System.IDisposable
{
    // Child Types
    public unsafe struct GlyphList_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GlyphList*, void> GlyphList_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.List___Glyph m_glyphList;
    public ACBindings.Internal.SmartArray___GlyphLine m_glyphLines;
    public uint m_nMaxCharacters;
    public byte m_bTrimFromTop;
    public uint m_cxLastRecalcWidth;
    public uint m_nFirstInvalidPosition;
    public byte m_bOneLine;

    // Generated Constructor
    public GlyphList() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00472AB0
    /// bool __thiscall GlyphList::FindCurrentLine(GlyphList*,unsigned int,unsigned int*,unsigned int*)</code>
    /// </summary>
    public byte FindCurrentLine(uint i_nStart, uint* o_nLine, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, uint*, uint*, byte>)0x00472AB0)(ref this, i_nStart, o_nLine, o_nPos);

    /// <summary>
    /// <code>Offset: 0x00472B30
    /// bool __thiscall GlyphList::FindLineFromY(GlyphList*,int,unsigned int*)</code>
    /// </summary>
    public byte FindLineFromY(int i_y, uint* o_nLine) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, int, uint*, byte>)0x00472B30)(ref this, i_y, o_nLine);

    /// <summary>
    /// <code>Offset: 0x00472BB0
    /// bool __thiscall GlyphList::FindCompleteLineFromY(GlyphList*,int,unsigned int*)</code>
    /// </summary>
    public byte FindCompleteLineFromY(int i_y, uint* o_nLine) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, int, uint*, byte>)0x00472BB0)(ref this, i_y, o_nLine);

    /// <summary>
    /// <code>Offset: 0x00472C00
    /// bool __thiscall GlyphList::FindNextLine(GlyphList*,unsigned int,unsigned int*,unsigned int*)</code>
    /// </summary>
    public byte FindNextLine(uint i_nStart, uint* o_nLine, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, uint*, uint*, byte>)0x00472C00)(ref this, i_nStart, o_nLine, o_nPos);

    /// <summary>
    /// <code>Offset: 0x00472C60
    /// bool __thiscall GlyphList::FindPrevLine(GlyphList*,unsigned int,unsigned int*,unsigned int*)</code>
    /// </summary>
    public byte FindPrevLine(uint i_nStart, uint* o_nLine, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, uint*, uint*, byte>)0x00472C60)(ref this, i_nStart, o_nLine, o_nPos);

    /// <summary>
    /// <code>Offset: 0x00472CC0
    /// bool __thiscall GlyphList::GetGlyphLineHeight(GlyphList*,unsigned int,int*)</code>
    /// </summary>
    public byte GetGlyphLineHeight(uint i_nLine, int* o_nHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, int*, byte>)0x00472CC0)(ref this, i_nLine, o_nHeight);

    /// <summary>
    /// <code>Offset: 0x00472CF0
    /// bool __thiscall GlyphList::GetGlyphLineWidth(GlyphList*,unsigned int,int*)</code>
    /// </summary>
    public byte GetGlyphLineWidth(uint i_nLine, int* o_nWidth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, int*, byte>)0x00472CF0)(ref this, i_nLine, o_nWidth);

    /// <summary>
    /// <code>Offset: 0x00472E40
    /// bool __thiscall GlyphList::FindNextWord(GlyphList*,unsigned int,unsigned int*)</code>
    /// </summary>
    public byte FindNextWord(uint i_nStart, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, uint*, byte>)0x00472E40)(ref this, i_nStart, o_nPos);

    /// <summary>
    /// <code>Offset: 0x00472EA0
    /// bool __thiscall GlyphList::FindPrevWord(GlyphList*,unsigned int,unsigned int*)</code>
    /// </summary>
    public byte FindPrevWord(uint i_nStart, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, uint*, byte>)0x00472EA0)(ref this, i_nStart, o_nPos);

    /// <summary>
    /// <code>Offset: 0x00472F00
    /// bool __thiscall GlyphList::FindPixelsFromPos(GlyphList*,unsigned int,int*)</code>
    /// </summary>
    public byte FindPixelsFromPos(uint i_nStart, int* o_nPixels) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, int*, byte>)0x00472F00)(ref this, i_nStart, o_nPixels);

    /// <summary>
    /// <code>Offset: 0x00472F70
    /// void __thiscall GlyphList::RemoveTextTag(GlyphList*,TextTag*)</code>
    /// </summary>
    public void RemoveTextTag(ACBindings.Internal.TextTag* pTag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, ACBindings.Internal.TextTag*, void>)0x00472F70)(ref this, pTag);

    /// <summary>
    /// <code>Offset: 0x00472FA0
    /// void*** __thiscall GlyphList::GetGlyphIterForIndex(void**,void***,int)</code>
    /// </summary>
    public void*** GetGlyphIterForIndex(void*** a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, void***, int, void***>)0x00472FA0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00472FF0
    /// void __thiscall GlyphList::ChangeExistingGlyphsToNewFont(GlyphList*,Font*)</code>
    /// </summary>
    public void ChangeExistingGlyphsToNewFont(ACBindings.Internal.Font* i_pNewFont) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, ACBindings.Internal.Font*, void>)0x00472FF0)(ref this, i_pNewFont);

    /// <summary>
    /// <code>Offset: 0x00473230
    /// BOOL __thiscall GlyphList::Insert(GlyphList*,int,Glyph*)</code>
    /// </summary>
    public byte Insert(int a2, ACBindings.Internal.Glyph* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, int, ACBindings.Internal.Glyph*, byte>)0x00473230)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004732A0
    /// bool __thiscall GlyphList::FindXYFromPosition(GlyphList*,unsigned int,int*,int*)</code>
    /// </summary>
    public byte FindXYFromPosition(uint i_nStart, int* o_x, int* o_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, int*, int*, byte>)0x004732A0)(ref this, i_nStart, o_x, o_y);

    /// <summary>
    /// <code>Offset: 0x00473310
    /// int __thiscall GlyphList::GetGlyphIterForLine(int,int,unsigned int)</code>
    /// </summary>
    public int GetGlyphIterForLine(int a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, int, uint, int>)0x00473310)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004733E0
    /// void __thiscall GlyphList::Flush(GlyphList*)</code>
    /// </summary>
    public void Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, void>)0x004733E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00473410
    /// unsigned int __thiscall GlyphList::Insert(GlyphList*,unsigned int,const Glyph*)</code>
    /// </summary>
    public uint Insert(uint i_nPos, ACBindings.Internal.Glyph* i_glyph) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, ACBindings.Internal.Glyph*, uint>)0x00473410)(ref this, i_nPos, i_glyph);

    /// <summary>
    /// <code>Offset: 0x00473460
    /// unsigned int __thiscall GlyphList::Delete(GlyphList*,unsigned int,unsigned int)</code>
    /// </summary>
    public uint Delete(uint i_nStart, uint i_nEnd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, uint, uint>)0x00473460)(ref this, i_nStart, i_nEnd);

    /// <summary>
    /// <code>Offset: 0x00473550
    /// int __thiscall GlyphList::AddText(GlyphList*,unsigned int,_DWORD*)</code>
    /// </summary>
    public int AddText(uint i_nEnd, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, int*, int>)0x00473550)(ref this, i_nEnd, a3);

    /// <summary>
    /// <code>Offset: 0x00473690
    /// bool __thiscall GlyphList::FindPosFromLineAndPixels(GlyphList*,unsigned int,unsigned int,unsigned int,unsigned int*)</code>
    /// </summary>
    public byte FindPosFromLineAndPixels(uint i_nLine, uint i_nPixels, uint i_bFindNearestPos, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, uint, uint, uint*, byte>)0x00473690)(ref this, i_nLine, i_nPixels, i_bFindNearestPos, o_nPos);

    /// <summary>
    /// <code>Offset: 0x004737F0
    /// bool __thiscall GlyphList::InqGlyph(GlyphList*,unsigned int,Glyph*)</code>
    /// </summary>
    public byte InqGlyph(uint i_pos, ACBindings.Internal.Glyph* o_glyph) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, ACBindings.Internal.Glyph*, byte>)0x004737F0)(ref this, i_pos, o_glyph);

    /// <summary>
    /// <code>Offset: 0x00473860
    /// void __thiscall GlyphList::GlyphList(GlyphList*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, void>)0x00473860)(ref this);

    /// <summary>
    /// <code>Offset: 0x004738A0
    /// void __thiscall GlyphList::~GlyphList(GlyphList*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, void>)0x004738A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00473920
    /// char __thiscall GlyphList::InqText(_DWORD*,unsigned int,int,volatile LONG*,wchar_t**)</code>
    /// </summary>
    public sbyte InqText(uint a2, int a3, int* ArgList, System.IntPtr Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, int, int*, System.IntPtr, sbyte>)0x00473920)(ref this, a2, a3, ArgList, Source);

    /// <summary>
    /// <code>Offset: 0x00473BC0
    /// bool __thiscall GlyphList::Recalculate(GlyphList*,int,bool,int*,int*)</code>
    /// </summary>
    public byte Recalculate(int i_nMarginWidth, byte i_bOneLine, int* o_nWidth, int* o_nHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, int, byte, int*, int*, byte>)0x00473BC0)(ref this, i_nMarginWidth, i_bOneLine, o_nWidth, o_nHeight);

    /// <summary>
    /// <code>Offset: 0x00474130
    /// char __thiscall GlyphList::InqText(_DWORD*,volatile LONG*,wchar_t**)</code>
    /// </summary>
    public sbyte InqText(int* ArgList, System.IntPtr Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, int*, System.IntPtr, sbyte>)0x00474130)(ref this, ArgList, Source);
}

