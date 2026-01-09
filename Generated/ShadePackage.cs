namespace ACBindings;

// ShadePackage
public unsafe struct ShadePackage
{
    // Members
    public fixed double _val[4];

    // Generated Constructor
    public ShadePackage(double val) {
        _ConstructorInternal(val);
    }

    // Methods
    // void __thiscall ShadePackage::ShadePackage(ShadePackage*,const long double)
    public void _ConstructorInternal(double val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ShadePackage, double, void>)0x005A9340)(ref this, val);
    // long double __thiscall ShadePackage::GetVal(ShadePackage*,const int)
    public double GetVal(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ShadePackage, int, double>)0x005A9370)(ref this, index);
}

