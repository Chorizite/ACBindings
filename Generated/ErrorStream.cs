namespace ACBindings.Internal;


/// <summary>Accumulates textual diagnostics in an internal string buffer, enabling stream‑like concatenation of data before reporting. Upon invocation, the accumulated message is forwarded to the global error handler and then reset.</summary>
public unsafe struct ErrorStream
{
    // Members
    public ACBindings.Internal.PStringBase__sbyte m_strBuffer;

    // Methods

    /// <summary>Applies a manipulation function to an ErrorStream instance and returns the resulting stream.
    /// <code>Offset: 0x005557A0
    /// ErrorStream* __thiscall ErrorStream::operator&lt;&lt;(ErrorStream*,ErrorStream*(__cdecl*f)(ErrorStream*))</code>
    /// </summary>
    /// <param name="f">Function pointer that receives the current stream and returns a modified stream.</param>
    /// <returns>The stream returned by the supplied manipulation function.</returns>
//     public ACBindings.Internal.ErrorStream* operator____(delegate* unmanaged[Cdecl]<ACBindings.Internal.ErrorStream*, ACBindings.Internal.ErrorStream*> f) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ErrorStream, delegate* unmanaged[Cdecl]<ACBindings.Internal.ErrorStream*, ACBindings.Internal.ErrorStream*>, ACBindings.Internal.ErrorStream*>)0x005557A0)(ref this, f);

    /// <summary>Sends the stored error message to the error reporting system and clears the stream's internal buffer.
    /// <code>Offset: 0x005557B0
    /// void __thiscall ErrorStream::output(ErrorStream*)</code>
    /// </summary>
    public void output() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ErrorStream, void>)0x005557B0)(ref this);

    /// <summary>Appends a null‑terminated string to the error stream's internal buffer, allowing chained output operations.
    /// <code>Offset: 0x00555810
    /// ErrorStream* __thiscall ErrorStream::operator&lt;&lt;(ErrorStream*,const char*)</code>
    /// </summary>
    /// <param name="input">The C‑string to append; ignored if NULL or empty.</param>
    /// <returns>The same ErrorStream instance for further chaining.</returns>
//     public ACBindings.Internal.ErrorStream* operator____(sbyte* input) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ErrorStream, sbyte*, ACBindings.Internal.ErrorStream*>)0x00555810)(ref this, input);

    /// <summary>Appends an integer argument to the error stream in hexadecimal notation and returns the updated buffer pointer.
    /// <code>Offset: 0x00555840
    /// char** __thiscall ErrorStream::operator&lt;&lt;(char**,int)</code>
    /// </summary>
    /// <param name="ArgList">The integer value to format as hex.</param>
    /// <returns>A pointer to the modified string buffer for chaining.</returns>
//     public sbyte** operator____(int ArgList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ErrorStream, int, sbyte**>)0x00555840)(ref this, ArgList);
}

