namespace ACBindings.Internal;

public unsafe struct CommandLineArg : System.IDisposable
{
    // Members
    public int ArgType;
    public sbyte ShortVersion;
    public ACBindings.Internal.PStringBase__sbyte LongVersion;
    public ACBindings.Internal.PStringBase__sbyte Description;
    public System.IntPtr VariableToModify;
    public uint ValueToStore;
    public uint UserData;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Decrements reference counts for the Description and LongVersion strings, freeing their buffers when no longer referenced.
    /// <code>Offset: 0x00402280
    /// void __thiscall CommandLineArg::~CommandLineArg(CommandLineArg*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandLineArg, void>)0x00402280)(ref this);
}

