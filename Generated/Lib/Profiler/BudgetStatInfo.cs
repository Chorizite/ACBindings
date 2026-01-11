namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x005DA0F0
    /// void** __thiscall BudgetStatInfo::BudgetStatInfo(void**,void*,void*,void*,void*,void*,void*,char)</code>
    /// </summary>
    public void** _ConstructorInternal(System.IntPtr a2, System.IntPtr a3, System.IntPtr a4, System.IntPtr a5, System.IntPtr a6, System.IntPtr a7, sbyte a8) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BudgetStatInfo, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, sbyte, void**>)0x005DA0F0)(ref this, a2, a3, a4, a5, a6, a7, a8);
}

