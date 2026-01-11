namespace ACBindings.Internal;

public unsafe struct ShadePackage
{
    // Members
    public fixed double _val[4];

    // Generated Constructor
    public ShadePackage(double val) {
        _ConstructorInternal(val);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005A9340
    /// void __thiscall ShadePackage::ShadePackage(ShadePackage*,const long double)</code>
    /// </summary>
    public void _ConstructorInternal(double val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShadePackage, double, void>)0x005A9340)(ref this, val);

    /// <summary>
    /// <code>Offset: 0x005A9370
    /// long double __thiscall ShadePackage::GetVal(ShadePackage*,const int)</code>
    /// </summary>
    public double GetVal(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShadePackage, int, double>)0x005A9370)(ref this, index);
}

