namespace ACBindings;

// BasePropertyValue
public unsafe struct BasePropertyValue
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Methods
    // char __thiscall BasePropertyValue::InqTimeStamp(BasePropertyValue*,double*)
    public sbyte InqTimeStamp(double* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BasePropertyValue, double*, sbyte>)0x0069F990)(ref this, a2);
}

