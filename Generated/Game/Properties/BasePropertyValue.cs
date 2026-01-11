namespace ACBindings.Internal;

public unsafe struct BasePropertyValue
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Methods

    /// <summary>
    /// <code>Offset: 0x0069F990
    /// char __thiscall BasePropertyValue::InqTimeStamp(BasePropertyValue*,double*)</code>
    /// </summary>
    public sbyte InqTimeStamp(double* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BasePropertyValue, double*, sbyte>)0x0069F990)(ref this, a2);
}

