namespace ACBindings.Internal;


/// <summary>
/// Facilitates censorship checks by retrieving the global taboo word table, delegating validation of input data, and handling resource release automatically.
/// </summary>
public unsafe struct TabooTableAdaptor
{
    // Methods

    /// <summary>Validates an input buffer against the configured taboo word list and reports any violations.
    /// <code>Offset: 0x00683A30
    /// int __cdecl TabooTableAdaptor::CheckCensorsW(int*,unsigned int,int,int*)</code>
    /// </summary>
    /// <param name="a1">Pointer to the input data to be examined for prohibited content.</param>
    /// <param name="a2">Length of the input buffer in units of the element type pointed to by a1.</param>
    /// <param name="a3">Flag or option value that modifies how the censorship check is performed.</param>
    /// <param name="a4">Optional output parameter that receives information about detected violations.</param>
    /// <returns>Zero on success, non‑zero error code otherwise; returns 2 if no taboo table is available.</returns>
    public static int CheckCensorsW(int* a1, uint a2, int a3, int* a4) => ((delegate* unmanaged[Cdecl]<int*, uint, int, int*, int>)0x00683A30)(a1, a2, a3, a4);
}

