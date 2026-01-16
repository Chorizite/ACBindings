namespace ACBindings.Internal;


/// <summary>Captures statistical information for budget entities, including a name identifier, five graphic level thresholds, and a flag indicating whether the data is stored in memory.</summary>
public unsafe struct BudgetStatInfo
{
    // Members
    public ACBindings.Internal.PStringBase__sbyte strName;
    public fixed uint nGraphicLevel[5];
    public byte bIsMem;

    // Generated Constructor
    public BudgetStatInfo(System.IntPtr a2, System.IntPtr a3, System.IntPtr a4, System.IntPtr a5, System.IntPtr a6, System.IntPtr a7, sbyte a8) {
        _ConstructorInternal(a2, a3, a4, a5, a6, a7, a8);
    }

    // Methods

    /// <summary>Initializes a BudgetStatInfo instance with the specified name string, graphic level values, and memory flag.
    /// <code>Offset: 0x005DA0F0
    /// void** __thiscall BudgetStatInfo::BudgetStatInfo(void**,void*,void*,void*,void*,void*,void*,char)</code>
    /// </summary>
    /// <param name="a2">Pointer to the character buffer for the object's name string.</param>
    /// <param name="a3">Graphic level 0 value.</param>
    /// <param name="a4">Graphic level 1 value.</param>
    /// <param name="a5">Graphic level 2 value.</param>
    /// <param name="a6">Graphic level 3 value.</param>
    /// <param name="a7">Graphic level 4 value.</param>
    /// <param name="a8">Memory flag indicating whether the object is stored in memory.</param>
    /// <returns>Pointer to the initialized BudgetStatInfo instance.</returns>
    public void** _ConstructorInternal(System.IntPtr a2, System.IntPtr a3, System.IntPtr a4, System.IntPtr a5, System.IntPtr a6, System.IntPtr a7, sbyte a8) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BudgetStatInfo, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, sbyte, void**>)0x005DA0F0)(ref this, a2, a3, a4, a5, a6, a7, a8);
}

