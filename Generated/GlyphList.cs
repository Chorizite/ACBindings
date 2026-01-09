namespace ACBindings;

// GlyphList
public unsafe struct GlyphList : System.IDisposable
{
    // Child Types
    // GlyphList_vtbl
    public unsafe struct GlyphList_vtbl
    {
        // Members
        public System.IntPtr GlyphList_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.List__Glyph m_glyphList;
    public ACBindings.SmartArray__GlyphLine m_glyphLines;
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
    // bool __thiscall GlyphList::FindCurrentLine(GlyphList*,unsigned int,unsigned int*,unsigned int*)
    public byte FindCurrentLine(uint i_nStart, uint* o_nLine, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, uint, uint*, uint*, byte>)0x00472AB0)(ref this, i_nStart, o_nLine, o_nPos);
    // bool __thiscall GlyphList::FindLineFromY(GlyphList*,int,unsigned int*)
    public byte FindLineFromY(int i_y, uint* o_nLine) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, int, uint*, byte>)0x00472B30)(ref this, i_y, o_nLine);
    // bool __thiscall GlyphList::FindCompleteLineFromY(GlyphList*,int,unsigned int*)
    public byte FindCompleteLineFromY(int i_y, uint* o_nLine) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, int, uint*, byte>)0x00472BB0)(ref this, i_y, o_nLine);
    // bool __thiscall GlyphList::FindNextLine(GlyphList*,unsigned int,unsigned int*,unsigned int*)
    public byte FindNextLine(uint i_nStart, uint* o_nLine, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, uint, uint*, uint*, byte>)0x00472C00)(ref this, i_nStart, o_nLine, o_nPos);
    // bool __thiscall GlyphList::FindPrevLine(GlyphList*,unsigned int,unsigned int*,unsigned int*)
    public byte FindPrevLine(uint i_nStart, uint* o_nLine, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, uint, uint*, uint*, byte>)0x00472C60)(ref this, i_nStart, o_nLine, o_nPos);
    // bool __thiscall GlyphList::GetGlyphLineHeight(GlyphList*,unsigned int,int*)
    public byte GetGlyphLineHeight(uint i_nLine, int* o_nHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, uint, int*, byte>)0x00472CC0)(ref this, i_nLine, o_nHeight);
    // bool __thiscall GlyphList::GetGlyphLineWidth(GlyphList*,unsigned int,int*)
    public byte GetGlyphLineWidth(uint i_nLine, int* o_nWidth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, uint, int*, byte>)0x00472CF0)(ref this, i_nLine, o_nWidth);
    // bool __thiscall GlyphList::FindNextWord(GlyphList*,unsigned int,unsigned int*)
    public byte FindNextWord(uint i_nStart, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, uint, uint*, byte>)0x00472E40)(ref this, i_nStart, o_nPos);
    // bool __thiscall GlyphList::FindPrevWord(GlyphList*,unsigned int,unsigned int*)
    public byte FindPrevWord(uint i_nStart, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, uint, uint*, byte>)0x00472EA0)(ref this, i_nStart, o_nPos);
    // bool __thiscall GlyphList::FindPixelsFromPos(GlyphList*,unsigned int,int*)
    public byte FindPixelsFromPos(uint i_nStart, int* o_nPixels) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, uint, int*, byte>)0x00472F00)(ref this, i_nStart, o_nPixels);
    // void __thiscall GlyphList::RemoveTextTag(GlyphList*,TextTag*)
    public void RemoveTextTag(ACBindings.TextTag* pTag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, ACBindings.TextTag*, void>)0x00472F70)(ref this, pTag);
    // void*** __thiscall GlyphList::GetGlyphIterForIndex(void**,void***,int)
    public void*** GetGlyphIterForIndex(void*** a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, void***, int, void***>)0x00472FA0)(ref this, a2, a3);
    // void __thiscall GlyphList::ChangeExistingGlyphsToNewFont(GlyphList*,Font*)
    public void ChangeExistingGlyphsToNewFont(ACBindings.Font* i_pNewFont) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, ACBindings.Font*, void>)0x00472FF0)(ref this, i_pNewFont);
    // BOOL __thiscall GlyphList::Insert(GlyphList*,int,Glyph*)
    public byte Insert(int a2, ACBindings.Glyph* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, int, ACBindings.Glyph*, byte>)0x00473230)(ref this, a2, a3);
    // bool __thiscall GlyphList::FindXYFromPosition(GlyphList*,unsigned int,int*,int*)
    public byte FindXYFromPosition(uint i_nStart, int* o_x, int* o_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, uint, int*, int*, byte>)0x004732A0)(ref this, i_nStart, o_x, o_y);
    // int __thiscall GlyphList::GetGlyphIterForLine(int,int,unsigned int)
    public int GetGlyphIterForLine(int a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, int, uint, int>)0x00473310)(ref this, a2, a3);
    // void __thiscall GlyphList::Flush(GlyphList*)
    public void Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, void>)0x004733E0)(ref this);
    // unsigned int __thiscall GlyphList::Insert(GlyphList*,unsigned int,const Glyph*)
    public uint Insert(uint i_nPos, ACBindings.Glyph* i_glyph) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, uint, ACBindings.Glyph*, uint>)0x00473410)(ref this, i_nPos, i_glyph);
    // unsigned int __thiscall GlyphList::Delete(GlyphList*,unsigned int,unsigned int)
    public uint Delete(uint i_nStart, uint i_nEnd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, uint, uint, uint>)0x00473460)(ref this, i_nStart, i_nEnd);
    // int __thiscall GlyphList::AddText(GlyphList*,unsigned int,_DWORD*)
    public int AddText(uint i_nEnd, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, uint, int*, int>)0x00473550)(ref this, i_nEnd, a3);
    // bool __thiscall GlyphList::FindPosFromLineAndPixels(GlyphList*,unsigned int,unsigned int,unsigned int,unsigned int*)
    public byte FindPosFromLineAndPixels(uint i_nLine, uint i_nPixels, uint i_bFindNearestPos, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, uint, uint, uint, uint*, byte>)0x00473690)(ref this, i_nLine, i_nPixels, i_bFindNearestPos, o_nPos);
    // bool __thiscall GlyphList::InqGlyph(GlyphList*,unsigned int,Glyph*)
    public byte InqGlyph(uint i_pos, ACBindings.Glyph* o_glyph) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, uint, ACBindings.Glyph*, byte>)0x004737F0)(ref this, i_pos, o_glyph);
    // void __thiscall GlyphList::GlyphList(GlyphList*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, void>)0x00473860)(ref this);
    // void __thiscall GlyphList::~GlyphList(GlyphList*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, void>)0x004738A0)(ref this);
    // char __thiscall GlyphList::InqText(_DWORD*,unsigned int,int,volatile LONG*,wchar_t**)
    public sbyte InqText(uint a2, int a3, int* ArgList, System.IntPtr Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, uint, int, int*, System.IntPtr, sbyte>)0x00473920)(ref this, a2, a3, ArgList, Source);
    // bool __thiscall GlyphList::Recalculate(GlyphList*,int,bool,int*,int*)
    public byte Recalculate(int i_nMarginWidth, byte i_bOneLine, int* o_nWidth, int* o_nHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, int, byte, int*, int*, byte>)0x00473BC0)(ref this, i_nMarginWidth, i_bOneLine, o_nWidth, o_nHeight);
    // char __thiscall GlyphList::InqText(_DWORD*,volatile LONG*,wchar_t**)
    public sbyte InqText(int* ArgList, System.IntPtr Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlyphList, int*, System.IntPtr, sbyte>)0x00474130)(ref this, ArgList, Source);
}

