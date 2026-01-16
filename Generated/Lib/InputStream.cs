namespace ACBindings.Internal;


/// <summary>Tracks parsing progress for an input source, handling both strings and files, while recording line, column, current character, and completion state.</summary>
public unsafe struct InputStream : System.IDisposable
{
    // Members
    public byte parsing_from_string;
    public byte keep_locked;
    public ACBindings.Internal.PStringBaseIter_Const__sbyte in_string_iter;
    public byte* in_file;
    public ushort line;
    public ushort col;
    public uint num_chars;
    public sbyte curr_char;
    public byte done;

    // Generated Constructor
    public InputStream() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Advances the input stream to the next character, updating line and column counters, incrementing the read count, and setting the done flag when the end of the source is reached.
    /// <code>Offset: 0x006BBA50
    /// char __thiscall InputStream::Next(InputStream*)</code>
    /// </summary>
    /// <returns>The character that was current before advancing; if the stream has finished, this->done will be set true.</returns>
    public sbyte Next() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InputStream, sbyte>)0x006BBA50)(ref this);

    /// <summary>Opens a file from the supplied list, initializing the InputStream for reading. If a3 is non‑null it receives the opened FILE*; otherwise the file is opened read‑only.
    /// <code>Offset: 0x006BBAE0
    /// char __thiscall InputStream::SetFile(void*,const char**,_DWORD*,unsigned int,double)</code>
    /// </summary>
    /// <param name="a2">Array of filenames to try opening.</param>
    /// <param name="a3">Optional output pointer that will receive the FILE* handle if a file is successfully opened.</param>
    /// <param name="a4">Maximum number of attempts or count of filenames in a2.</param>
    /// <param name="a5">Delay (in seconds) between successive open attempts when an attempt fails.</param>
    /// <returns>1 if a file was successfully opened and the stream initialized; 0 otherwise.</returns>
    public sbyte SetFile(sbyte** a2, int* a3, uint a4, double a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InputStream, sbyte**, int*, uint, double, sbyte>)0x006BBAE0)(ref this, a2, a3, a4, a5);

    /// <summary>Initializes a new instance of InputStream with default state, preparing it for input operations from either a file or a string. Line and column counters start at one, and the stream is marked as finished until data is provided.
    /// <code>Offset: 0x006BBC60
    /// void __thiscall InputStream::InputStream(InputStream*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InputStream, void>)0x006BBC60)(ref this);

    /// <summary>Destroys an InputStream instance, closing its associated file when not locked and resetting all parsing state.
    /// <code>Offset: 0x006BBC90
    /// void __thiscall InputStream::~InputStream(InputStream*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InputStream, void>)0x006BBC90)(ref this);
}

