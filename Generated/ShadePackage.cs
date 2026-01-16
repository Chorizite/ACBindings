namespace ACBindings.Internal;


/// <summary>A fixed‑size array of four long double values used as a lightweight container within the application.</summary>
/// <remarks>The constructor assigns a supplied value to _val[0] and then copies 24 bytes from the object itself into the remaining positions of the internal array, producing overlapping data within the structure. The GetVal method returns the element at a specified zero‑based index.</remarks>
public unsafe struct ShadePackage
{
    // Members
    public fixed double _val[4];

    // Generated Constructor
    public ShadePackage(double val) {
        _ConstructorInternal(val);
    }

    // Methods

    /// <summary>Initializes a ShadePackage by assigning the supplied value to its first array element and copying 24 bytes of the object’s own memory into subsequent slots, resulting in partially overlapping data.
    /// <code>Offset: 0x005A9340
    /// void __thiscall ShadePackage::ShadePackage(ShadePackage*,const long double)</code>
    /// </summary>
    /// <param name="val">The value assigned to the first element of the internal long double array.</param>
    public void _ConstructorInternal(double val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShadePackage, double, void>)0x005A9340)(ref this, val);

    /// <summary>Returns the element at the specified index within the internal array, clamping indices beyond the bounds to the last element.
    /// <code>Offset: 0x005A9370
    /// long double __thiscall ShadePackage::GetVal(ShadePackage*,const int)</code>
    /// </summary>
    /// <param name="index">Zero‑based position requested from the array; values greater than or equal to 4 are treated as 3.</param>
    /// <returns>The long double value at the requested position.</returns>
    public double GetVal(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShadePackage, int, double>)0x005A9370)(ref this, index);
}

