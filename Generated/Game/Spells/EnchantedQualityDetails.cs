namespace ACBindings.Internal;


/// <summary>Represents enchanted item quality parameters, storing a base value along with multipliers and additive factors applied when quality increases or decreases.</summary>
public unsafe struct EnchantedQualityDetails
{
    // Members
    public double rRawValue;
    public double rValueIncreasingMultiplier;
    public double rValueDecreasingMultiplier;
    public double rValueIncreasingAdditive;
    public double rValueDecreasingAdditive;

    // Methods
}

