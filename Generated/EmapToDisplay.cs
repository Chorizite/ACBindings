namespace ACBindings;

// EmapToDisplay
public unsafe struct EmapToDisplay
{
    // Methods
    // int __cdecl EmapToDisplay::LowerCaseRemoveUnderscores(volatile LONG*,int*)
    public static int LowerCaseRemoveUnderscores(int* a1, int* a2) => ((delegate* unmanaged[Cdecl]<int*, int*, int>)0x005AA310)(a1, a2);
}

