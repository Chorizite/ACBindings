namespace ACBindings.Internal;

public unsafe struct PreprocHeader
{
    // Members
    public fixed byte header_data_Raw[16];
    public ACBindings.Internal.PStringBase__sbyte* header_data => (ACBindings.Internal.PStringBase__sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref header_data_Raw[0]);

    // Methods
}

