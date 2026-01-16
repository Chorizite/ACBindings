namespace ACBindings.Internal;


/// <summary>Represents a material shader constant, storing its property type identifier and a reference to its runtime value for use during rendering.</summary>
public unsafe struct MaterialShaderConstant
{
    // Members
    public uint m_PropertyType;
    public ACBindings.Internal.BasePropertyValue* m_pPropertyValue;

    // Methods
}

