namespace ACBindings.Internal;

public unsafe struct ErrorStream
{
    // Members
    public ACBindings.Internal.PStringBase__sbyte m_strBuffer;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005557A0
    /// ErrorStream* __thiscall ErrorStream::operator&lt;&lt;(ErrorStream*,ErrorStream*(__cdecl*f)(ErrorStream*))</code>
    /// </summary>
//     public ACBindings.Internal.ErrorStream* operator____(delegate* unmanaged[Cdecl]<ACBindings.Internal.ErrorStream*, ACBindings.Internal.ErrorStream*> f) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ErrorStream, delegate* unmanaged[Cdecl]<ACBindings.Internal.ErrorStream*, ACBindings.Internal.ErrorStream*>, ACBindings.Internal.ErrorStream*>)0x005557A0)(ref this, f);

    /// <summary>
    /// <code>Offset: 0x005557B0
    /// void __thiscall ErrorStream::output(ErrorStream*)</code>
    /// </summary>
    public void output() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ErrorStream, void>)0x005557B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00555810
    /// ErrorStream* __thiscall ErrorStream::operator&lt;&lt;(ErrorStream*,const char*)</code>
    /// </summary>
//     public ACBindings.Internal.ErrorStream* operator____(sbyte* input) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ErrorStream, sbyte*, ACBindings.Internal.ErrorStream*>)0x00555810)(ref this, input);

    /// <summary>
    /// <code>Offset: 0x00555840
    /// char** __thiscall ErrorStream::operator&lt;&lt;(char**,int)</code>
    /// </summary>
//     public sbyte** operator____(int ArgList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ErrorStream, int, sbyte**>)0x00555840)(ref this, ArgList);
}

