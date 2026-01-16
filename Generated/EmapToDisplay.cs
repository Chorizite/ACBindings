namespace ACBindings.Internal;


/// <summary>Offers utility functions to normalize identifiers into human‑readable display strings by converting to lowercase and replacing underscores with spaces.</summary>
/// <remarks>Manages reference counting of shared string objects during transformations.</remarks>
public unsafe struct EmapToDisplay
{
    // Methods

    /// <summary>Transforms the string referenced by the second parameter into lowercase, replacing underscore characters with spaces while updating reference counts for involved string objects. Returns non‑zero if the transformation is performed; zero otherwise.
    /// <code>Offset: 0x005AA310
    /// int __cdecl EmapToDisplay::LowerCaseRemoveUnderscores(volatile LONG*,int*)</code>
    /// </summary>
    /// <param name="a1">Reference to a source string object (volatile LONG*). If its internal flag equals 1, no changes are made.</param>
    /// <param name="a2">Pointer to an integer holding a reference to the target string. The function updates this reference and applies the transformation if necessary.</param>
    /// <returns>Non‑zero value when the conversion succeeds; zero otherwise.</returns>
    public static int LowerCaseRemoveUnderscores(int* a1, int* a2) => ((delegate* unmanaged[Cdecl]<int*, int*, int>)0x005AA310)(a1, a2);
}

