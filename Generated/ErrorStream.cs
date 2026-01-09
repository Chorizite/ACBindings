namespace ACBindings;

// ErrorStream
public unsafe struct ErrorStream
{
    // Members
    public ACBindings.PStringBase__sbyte m_strBuffer;

    // Methods
    // ErrorStream* __thiscall ErrorStream::operator<<(ErrorStream*,ErrorStream*(__cdecl*f)(ErrorStream*))
//     public ACBindings.ErrorStream* operator____(delegate* unmanaged[Cdecl]<ACBindings.ErrorStream*, ACBindings.ErrorStream*> f) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ErrorStream, delegate* unmanaged[Cdecl]<ACBindings.ErrorStream*, ACBindings.ErrorStream*>, ACBindings.ErrorStream*>)0x005557A0)(ref this, f);
    // void __thiscall ErrorStream::output(ErrorStream*)
    public void output() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ErrorStream, void>)0x005557B0)(ref this);
    // ErrorStream* __thiscall ErrorStream::operator<<(ErrorStream*,const char*)
//     public ACBindings.ErrorStream* operator____(sbyte* input) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ErrorStream, sbyte*, ACBindings.ErrorStream*>)0x00555810)(ref this, input);
    // char** __thiscall ErrorStream::operator<<(char**,int)
//     public sbyte** operator____(int ArgList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ErrorStream, int, sbyte**>)0x00555840)(ref this, ArgList);
}

