namespace ACBindings.Internal;

public unsafe struct TabooTableAdaptor
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x00683A30
    /// int __cdecl TabooTableAdaptor::CheckCensorsW(int*,unsigned int,int,int*)</code>
    /// </summary>
    public static int CheckCensorsW(int* a1, uint a2, int a3, int* a4) => ((delegate* unmanaged[Cdecl]<int*, uint, int, int*, int>)0x00683A30)(a1, a2, a3, a4);
}

