namespace ACBindings.Internal;

// RegenerationType
public enum RegenerationType : uint
{
    Undef_RegenerationType = 0x0,
    Destruction_RegenerationType = 0x1,
    PickUp_RegenerationType = 0x2,
    Death_RegenerationType = 0x4,
    FORCE_RegenerationType_32_BIT = 0x7FFFFFFF
}

