namespace ACBindings;

// MasterStringTableGen
public unsafe struct MasterStringTableGen
{
    // Statics
    public static ACBindings.StringTableGen* s_pStringTableGen = (ACBindings.StringTableGen*)0x00837F58;

    // Methods
    // char __cdecl MasterStringTableGen::AddString(int,int,int,int,int)
    public static sbyte AddString(int a1, int a2, int a3, int a4, int a5) => ((delegate* unmanaged[Cdecl]<int, int, int, int, int, sbyte>)0x00430BC0)(a1, a2, a3, a4, a5);
}

