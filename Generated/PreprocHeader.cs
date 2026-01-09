namespace ACBindings;

// PreprocHeader
public unsafe struct PreprocHeader
{
    // Members
    public fixed byte header_data_Raw[16];
    public ACBindings.PStringBase__sbyte* header_data => (ACBindings.PStringBase__sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref header_data_Raw[0]);

    // Methods
}

