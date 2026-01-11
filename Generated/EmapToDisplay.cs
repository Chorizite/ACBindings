namespace ACBindings.Internal;

public unsafe struct EmapToDisplay
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x005AA310
    /// int __cdecl EmapToDisplay::LowerCaseRemoveUnderscores(volatile LONG*,int*)</code>
    /// </summary>
    public static int LowerCaseRemoveUnderscores(int* a1, int* a2) => ((delegate* unmanaged[Cdecl]<int*, int*, int>)0x005AA310)(a1, a2);
}

