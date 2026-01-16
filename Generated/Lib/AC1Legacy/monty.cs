namespace ACBindings.Internal.AC1Legacy;


/// <summary>Encapsulates the parameters required to perform Montgomery modular multiplication, such as the modulus, auxiliary constants, and pre‑computed values for efficient reduction.</summary>
public unsafe struct monty
{
    // Members
    public ACBindings.Internal.AC1Legacy.vlong m;
    public ACBindings.Internal.AC1Legacy.vlong n1;
    public ACBindings.Internal.AC1Legacy.vlong T;
    public ACBindings.Internal.AC1Legacy.vlong k;
    public uint N;
    public ACBindings.Internal.AC1Legacy.vlong R;
    public ACBindings.Internal.AC1Legacy.vlong R1;

    // Methods
}

