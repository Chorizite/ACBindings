namespace ACBindings;

// CommandLineArg
public unsafe struct CommandLineArg : System.IDisposable
{
    // Members
    public int ArgType;
    public sbyte ShortVersion;
    public ACBindings.PStringBase__sbyte LongVersion;
    public ACBindings.PStringBase__sbyte Description;
    public System.IntPtr VariableToModify;
    public uint ValueToStore;
    public uint UserData;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CommandLineArg::~CommandLineArg(CommandLineArg*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandLineArg, void>)0x00402280)(ref this);
}

