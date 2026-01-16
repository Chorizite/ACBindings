namespace ACBindings.Internal;


/// <summary>Maintains a collection of glyphs and their layout information for text rendering, including glyph lines, maximum character capacity, and dimension caching. Supports optional top trimming and single‑line mode to control visual presentation.</summary>
public unsafe struct GlyphList : System.IDisposable
{
    // Child Types

    /// <summary>Defines the virtual function table for GlyphList objects, containing pointers to member functions such as the destructor.</summary>
    public unsafe struct GlyphList_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GlyphList*, void> GlyphList_dtor_0; // function pointer

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

    /// <summary>Finds the glyph line that contains the specified glyph index.
    /// <code>Offset: 0x00472AB0
    /// bool __thiscall GlyphList::FindCurrentLine(GlyphList*,unsigned int,unsigned int*,unsigned int*)</code>
    /// </summary>
    /// <param name="i_nStart">Index of the glyph to locate within the list.</param>
    /// <param name="o_nLine">Receives the zero‑based line number containing the glyph.</param>
    /// <param name="o_nPos">Receives the starting glyph index of that line.</param>
    /// <returns>True if the start index is valid; otherwise, false.</returns>
    public byte FindCurrentLine(uint i_nStart, uint* o_nLine, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, uint*, uint*, byte>)0x00472AB0)(ref this, i_nStart, o_nLine, o_nPos);

    /// <summary>Identifies the glyph line that contains a given vertical position.
    /// <code>Offset: 0x00472B30
    /// bool __thiscall GlyphList::FindLineFromY(GlyphList*,int,unsigned int*)</code>
    /// </summary>
    /// <param name="i_y">Y coordinate to locate within the list of lines.</param>
    /// <param name="o_nLine">Pointer receiving zero‑based index of the line containing i_y.</param>
    /// <returns>True when the line index is calculated; always true for valid input.</returns>
    public byte FindLineFromY(int i_y, uint* o_nLine) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, int, uint*, byte>)0x00472B30)(ref this, i_y, o_nLine);

    /// <summary>Determines the last complete glyph line whose cumulative height does not exceed a specified Y coordinate, returning its zero‑based index or the total number of lines when all fit.
    /// <code>Offset: 0x00472BB0
    /// bool __thiscall GlyphList::FindCompleteLineFromY(GlyphList*,int,unsigned int*)</code>
    /// </summary>
    /// <param name="i_y">The vertical position threshold used to decide which lines are fully above it.</param>
    /// <param name="o_nLine">Receives the zero‑based index of that line; set to the total number of lines if every line fits within i_y, or 0 when there are no glyphs.</param>
    /// <returns>True, indicating o_nLine was populated successfully.</returns>
    public byte FindCompleteLineFromY(int i_y, uint* o_nLine) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, int, uint*, byte>)0x00472BB0)(ref this, i_y, o_nLine);

    /// <summary>Finds the next glyph line after a given start position, updating output parameters with the resulting line number and its first glyph index.
    /// <code>Offset: 0x00472C00
    /// bool __thiscall GlyphList::FindNextLine(GlyphList*,unsigned int,unsigned int*,unsigned int*)</code>
    /// </summary>
    /// <param name="i_nStart">The starting glyph index from which to find the following line.</param>
    /// <param name="o_nLine">Pointer to store the determined line number.</param>
    /// <param name="o_nPos">Pointer to store the first glyph index of the located line.</param>
    /// <returns>Always returns true (1) indicating the operation completed.</returns>
    public byte FindNextLine(uint i_nStart, uint* o_nLine, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, uint*, uint*, byte>)0x00472C00)(ref this, i_nStart, o_nLine, o_nPos);

    /// <summary>Locates the glyph line preceding a given start index, returning its line number and initial position within that line.
    /// <code>Offset: 0x00472C60
    /// bool __thiscall GlyphList::FindPrevLine(GlyphList*,unsigned int,unsigned int*,unsigned int*)</code>
    /// </summary>
    /// <param name="i_nStart">The glyph index from which to locate the previous line.</param>
    /// <param name="o_nLine">Output parameter receiving the zero‑based index of the found line.</param>
    /// <param name="o_nPos">Output parameter receiving the starting glyph index of that line.</param>
    /// <returns>True if a line was located; always true with current implementation.</returns>
    public byte FindPrevLine(uint i_nStart, uint* o_nLine, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, uint*, uint*, byte>)0x00472C60)(ref this, i_nStart, o_nLine, o_nPos);

    /// <summary>Retrieves the height of a specified glyph line within the list, storing it in the provided output parameter.
    /// <code>Offset: 0x00472CC0
    /// bool __thiscall GlyphList::GetGlyphLineHeight(GlyphList*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="i_nLine">Index of the glyph line to query.</param>
    /// <param name="o_nHeight">Receives the retrieved height; set to 0 if the index is out of range.</param>
    /// <returns>True when the requested line exists and the height was written; false otherwise.</returns>
    public byte GetGlyphLineHeight(uint i_nLine, int* o_nHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, int*, byte>)0x00472CC0)(ref this, i_nLine, o_nHeight);

    /// <summary>Retrieves the pixel width of a specified glyph line if it exists.
    /// <code>Offset: 0x00472CF0
    /// bool __thiscall GlyphList::GetGlyphLineWidth(GlyphList*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="i_nLine">Zero‑based index of the glyph line to query.</param>
    /// <param name="o_nWidth">Output parameter receiving the line's width in pixels.</param>
    /// <returns>True when the requested line is within bounds and its width is returned; otherwise false.</returns>
    public byte GetGlyphLineWidth(uint i_nLine, int* o_nWidth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, int*, byte>)0x00472CF0)(ref this, i_nLine, o_nWidth);

    /// <summary>Locates the beginning of the next word in a glyph list from a given starting position and reports its index.
    /// <code>Offset: 0x00472E40
    /// bool __thiscall GlyphList::FindNextWord(GlyphList*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="i_nStart">Zero‑based index at which to start searching for the next word.</param>
    /// <param name="o_nPos">Receives the zero‑based index of the first character of the found word; if no further words exist, it is set to the list’s length.</param>
    /// <returns>True when the start position is within the bounds of the glyph list; otherwise false.</returns>
    public byte FindNextWord(uint i_nStart, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, uint*, byte>)0x00472E40)(ref this, i_nStart, o_nPos);

    /// <summary>Finds the index of the first glyph of the word preceding a specified position in the glyph list, storing the result through an output parameter.
    /// <code>Offset: 0x00472EA0
    /// bool __thiscall GlyphList::FindPrevWord(GlyphList*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="i_nStart">Zero‑based index up to which the search is performed; must not exceed the number of glyphs in the list.</param>
    /// <param name="o_nPos">Receives the zero‑based index of the word’s starting glyph found before <c>i_nStart</c>.</param>
    /// <returns>True if the requested position was within bounds and a result was written; otherwise false.</returns>
    public byte FindPrevWord(uint i_nStart, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, uint*, byte>)0x00472EA0)(ref this, i_nStart, o_nPos);

    /// <summary>Computes the horizontal pixel offset for a specified glyph within the list, returning true if the index is valid.
    /// <code>Offset: 0x00472F00
    /// bool __thiscall GlyphList::FindPixelsFromPos(GlyphList*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="i_nStart">Zero‑based index of the glyph whose pixel position is requested.</param>
    /// <param name="o_nPixels">Pointer to an integer that receives the calculated pixel count; set to zero when the index is out of range.</param>
    /// <returns>True if the glyph index is within bounds and the offset was computed successfully, otherwise false.</returns>
    public byte FindPixelsFromPos(uint i_nStart, int* o_nPixels) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, int*, byte>)0x00472F00)(ref this, i_nStart, o_nPixels);

    /// <summary>Removes the specified text tag from all glyphs in the list.
    /// <code>Offset: 0x00472F70
    /// void __thiscall GlyphList::RemoveTextTag(GlyphList*,TextTag*)</code>
    /// </summary>
    /// <param name="pTag">The text tag to clear; if null, no action is taken.</param>
    public void RemoveTextTag(ACBindings.Internal.TextTag* pTag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, ACBindings.Internal.TextTag*, void>)0x00472F70)(ref this, pTag);

    /// <summary>Creates a <c>ListIterator&lt;Glyph&gt;</c> positioned at glyph index <paramref name="a3"/> within the GlyphList’s internal glyph list, or an end iterator when the index exceeds the list size.
    /// <code>Offset: 0x00472FA0
    /// void*** __thiscall GlyphList::GetGlyphIterForIndex(void**,void***,int)</code>
    /// </summary>
    /// <param name="a2">The iterator structure to populate. After execution, element 0 holds a pointer to the <c>ListIterator&lt;Glyph&gt;</c> vtable, element 1 contains the current node pointer (or <c>null</c> for an end iterator), and element 2 references the <c>m_glyphList</c> member of the owning <c>GlyphList</c>.</param>
    /// <param name="a3">Zero‑based index of the desired glyph.</param>
    /// <returns>The same pointer as passed in <paramref name="a2"/>, now initialized to an iterator over the requested position.</returns>
    public void*** GetGlyphIterForIndex(void*** a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, void***, int, void***>)0x00472FA0)(ref this, a2, a3);

    /// <summary>Changes all glyphs in the list to use a new font and resets the first invalid position marker.
    /// <code>Offset: 0x00472FF0
    /// void __thiscall GlyphList::ChangeExistingGlyphsToNewFont(GlyphList*,Font*)</code>
    /// </summary>
    /// <param name="i_pNewFont">The Font instance to apply to each glyph.</param>
    public void ChangeExistingGlyphsToNewFont(ACBindings.Internal.Font* i_pNewFont) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, ACBindings.Internal.Font*, void>)0x00472FF0)(ref this, i_pNewFont);

    /// <summary>Inserts a glyph into the list at the specified index, removing any existing text tag at that position before insertion.
    /// <code>Offset: 0x00473230
    /// BOOL __thiscall GlyphList::Insert(GlyphList*,int,Glyph*)</code>
    /// </summary>
    /// <param name="index">Zero-based index where the new glyph will be inserted.</param>
    /// <param name="glyph">Pointer to the glyph to insert; must not be null.</param>
    /// <returns>True if the glyph was successfully added; otherwise false (e.g., if the list is invalid or the insertion fails).</returns>
    public byte Insert(int a2, ACBindings.Internal.Glyph* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, int, ACBindings.Internal.Glyph*, byte>)0x00473230)(ref this, a2, a3);

    /// <summary>Computes pixel‑based X and Y coordinates for the glyph at a given index within the list.
    /// <code>Offset: 0x004732A0
    /// bool __thiscall GlyphList::FindXYFromPosition(GlyphList*,unsigned int,int*,int*)</code>
    /// </summary>
    /// <param name="i_nStart">The zero‑based index of the target glyph.</param>
    /// <param name="o_x">Pointer that will receive the horizontal coordinate (in pixels) relative to the text block; set to 0 if the search fails.</param>
    /// <param name="o_y">Pointer that will receive the vertical coordinate (in pixels); set to 0 if the search fails.</param>
    /// <returns>True when the coordinates are successfully determined; otherwise false.</returns>
    public byte FindXYFromPosition(uint i_nStart, int* o_x, int* o_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, int*, int*, byte>)0x004732A0)(ref this, i_nStart, o_x, o_y);

    /// <summary>Retrieves an iterator over glyphs for the specified line index in the GlyphList. It writes the resulting ListIterator into the memory pointed to by the second argument and returns that address.
    /// <code>Offset: 0x00473310
    /// int __thiscall GlyphList::GetGlyphIterForLine(int,int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Memory location where the constructed ListIterator will be stored.</param>
    /// <param name="a3">Zero‑based index of the glyph line requested.</param>
    /// <returns>Integer pointer to the populated iterator structure; identical to the value supplied in a2.</returns>
    public int GetGlyphIterForLine(int a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, int, uint, int>)0x00473310)(ref this, a2, a3);

    /// <summary>Clears the current glyph list, resets line data, and invalidates cached measurements to prepare the object for new text rendering.
    /// <code>Offset: 0x004733E0
    /// void __thiscall GlyphList::Flush(GlyphList*)</code>
    /// </summary>
    public void Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, void>)0x004733E0)(ref this);

    /// <summary>Inserts a glyph at the specified index in the list, updating internal tracking fields as needed.
    /// <code>Offset: 0x00473410
    /// unsigned int __thiscall GlyphList::Insert(GlyphList*,unsigned int,const Glyph*)</code>
    /// </summary>
    /// <param name="i_nPos">Zero‑based position where the glyph is to be inserted; must not exceed the current number of elements.</param>
    /// <param name="i_glyph">Pointer to the glyph object to insert.</param>
    /// <returns>Zero if the index is invalid; otherwise the result from the internal iterator‑based insertion, indicating success or failure.</returns>
    public uint Insert(uint i_nPos, ACBindings.Internal.Glyph* i_glyph) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, ACBindings.Internal.Glyph*, uint>)0x00473410)(ref this, i_nPos, i_glyph);

    /// <summary>Removes glyphs between indices i_nStart and i_nEnd (exclusive) from the internal glyph list, clearing associated tags and updating the first invalid position if necessary.
    /// <code>Offset: 0x00473460
    /// unsigned int __thiscall GlyphList::Delete(GlyphList*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_nStart">The zero‑based index of the first glyph to delete.</param>
    /// <param name="i_nEnd">The one‑past‑the‑last index; glyphs with indices less than i_nEnd are considered for removal.</param>
    /// <returns>The number of glyphs that were removed from the list.</returns>
    public uint Delete(uint i_nStart, uint i_nEnd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, uint, uint>)0x00473460)(ref this, i_nStart, i_nEnd);

    /// <summary>Inserts a series of glyphs from the supplied data array into the glyph list beginning at the specified index, trimming older entries when the maximum character limit is exceeded.
    /// <code>Offset: 0x00473550
    /// int __thiscall GlyphList::AddText(GlyphList*,unsigned int,_DWORD*)</code>
    /// </summary>
    /// <param name="i_nEnd">The position in the glyph list where new glyphs should start being inserted.</param>
    /// <param name="a3">Pointer to an array that provides a base address for glyph objects and the count of glyphs to add.</param>
    /// <returns>The net number of glyphs added after any removals due to exceeding the maximum character limit.</returns>
    public int AddText(uint i_nEnd, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, int*, int>)0x00473550)(ref this, i_nEnd, a3);

    /// <summary>
    /// Finds the glyph index that corresponds to a given pixel offset within a specified line of text, optionally using half‑width boundaries for nearest matching. If the requested pixel position exceeds the current line’s width, the method locates the next valid position in the following line or at the end of the list.
    /// 
    /// <code>Offset: 0x00473690
    /// bool __thiscall GlyphList::FindPosFromLineAndPixels(GlyphList*,unsigned int,unsigned int,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="i_nLine">Zero‑based index of the line to search.</param>
    /// <param name="i_nPixels">Pixel offset within that line for which a glyph position is requested.</param>
    /// <param name="i_bFindNearestPos">
    /// When non‑zero, each glyph’s width is effectively halved when determining the nearest matching position; otherwise full glyph widths are used.
    /// </param>
    /// <param name="o_nPos">Receives the zero‑based index of the glyph that matches the requested pixel offset.</param>
    /// <returns>True if the line number is valid and a position was computed; false if the line index exceeds the available lines.</returns>
    public byte FindPosFromLineAndPixels(uint i_nLine, uint i_nPixels, uint i_bFindNearestPos, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, uint, uint, uint*, byte>)0x00473690)(ref this, i_nLine, i_nPixels, i_bFindNearestPos, o_nPos);

    /// <summary>Retrieves the glyph at the specified index from the list, copying it into the supplied Glyph object.
    /// <code>Offset: 0x004737F0
    /// bool __thiscall GlyphList::InqGlyph(GlyphList*,unsigned int,Glyph*)</code>
    /// </summary>
    /// <param name="i_pos">Zero‑based position of the desired glyph within the list.</param>
    /// <param name="o_glyph">Pointer to a Glyph instance that receives the queried glyph data.</param>
    /// <returns>True if the index is valid and the glyph was copied; otherwise false.</returns>
    public byte InqGlyph(uint i_pos, ACBindings.Internal.Glyph* o_glyph) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, ACBindings.Internal.Glyph*, byte>)0x004737F0)(ref this, i_pos, o_glyph);

    /// <summary>Initializes a GlyphList instance by setting up its internal glyph list, glyph lines buffer, and default configuration values such as maximum character count, trimming behavior, and line mode.
    /// <code>Offset: 0x00473860
    /// void __thiscall GlyphList::GlyphList(GlyphList*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, void>)0x00473860)(ref this);

    /// <summary>Releases all resources owned by a GlyphList instance, clearing its glyph collection, resetting layout metadata, and deallocating any dynamically allocated line data.
    /// <code>Offset: 0x004738A0
    /// void __thiscall GlyphList::~GlyphList(GlyphList*)</code>
    /// </summary>
    /// <param name="this">Pointer to the GlyphList object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, void>)0x004738A0)(ref this);

    /// <summary>Retrieves a substring of the text represented by this GlyphList, optionally inserting formatted arguments, and writes the result into a newly allocated wide-character string.
    /// <code>Offset: 0x00473920
    /// char __thiscall GlyphList::InqText(_DWORD*,unsigned int,int,volatile LONG*,wchar_t**)</code>
    /// </summary>
    /// <param name="a2">Zero-based index of the first character to include in the returned text.</param>
    /// <param name="a3">Maximum number of characters to retrieve; if greater than the remaining length or negative, all available characters are included.</param>
    /// <param name="ArgList">Optional pointer containing argument data used for formatting placeholder glyphs. May be null.</param>
    /// <param name="Source">Pointer to a wchar_t* that will receive the newly allocated string. Any existing string referenced by *Source is released before assignment.</param>
    /// <returns>Always returns 1, indicating successful completion.</returns>
    public sbyte InqText(uint a2, int a3, int* ArgList, System.IntPtr Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, uint, int, int*, System.IntPtr, sbyte>)0x00473920)(ref this, a2, a3, ArgList, Source);

    /// <summary>Recalculates line layout for the glyph list, wrapping text to fit within a specified width and optionally forcing a single line.
    /// <code>Offset: 0x00473BC0
    /// bool __thiscall GlyphList::Recalculate(GlyphList*,int,bool,int*,int*)</code>
    /// </summary>
    /// <param name="i_nMarginWidth">Maximum allowed width for each line before wrapping occurs.</param>
    /// <param name="i_bOneLine">If true, suppresses line breaks and places all glyphs on one line regardless of width.</param>
    /// <param name="o_nWidth">Receives the maximum width among the resulting lines after recalculation.</param>
    /// <param name="o_nHeight">Receives the total height required to display all lines after recalculation.</param>
    /// <returns>True if layout recalculation succeeded; always true in current implementation.</returns>
    public byte Recalculate(int i_nMarginWidth, byte i_bOneLine, int* o_nWidth, int* o_nHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, int, byte, int*, int*, byte>)0x00473BC0)(ref this, i_nMarginWidth, i_bOneLine, o_nWidth, o_nHeight);

    /// <summary>Retrieves the textual content represented by this GlyphList instance.
    /// <code>Offset: 0x00474130
    /// char __thiscall GlyphList::InqText(_DWORD*,volatile LONG*,wchar_t**)</code>
    /// </summary>
    /// <param name="ArgList">Optional list of arguments used during extraction; may be null if no additional parameters are required.</param>
    /// <param name="Source">Receives a pointer to a wide‑character string containing the extracted text.</param>
    /// <returns>Zero on success, non‑zero error code otherwise.</returns>
    public sbyte InqText(int* ArgList, System.IntPtr Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlyphList, int*, System.IntPtr, sbyte>)0x00474130)(ref this, ArgList, Source);
}

