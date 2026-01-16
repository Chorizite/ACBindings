namespace ACBindings.Internal;


/// <summary>Serves as the foundational type for property values, embedding reference counting to manage object lifetime. The embedded ReferenceCountTemplate tracks shared ownership across the system.</summary>
public unsafe struct BasePropertyValue
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Methods

    /// <summary>Attempts to retrieve the timestamp of this property value. The operation is currently unsupported and always fails.
    /// <code>Offset: 0x0069F990
    /// char __thiscall BasePropertyValue::InqTimeStamp(BasePropertyValue*,double*)</code>
    /// </summary>
    /// <param name="a2">Pointer intended for receiving the timestamp, but unused in current implementation.</param>
    /// <returns>Zero indicates failure or that timestamp retrieval is not supported.</returns>
    public sbyte InqTimeStamp(double* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BasePropertyValue, double*, sbyte>)0x0069F990)(ref this, a2);
}

