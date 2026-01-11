namespace ACBindings.Internal;

// CryptoProviderFlags
public enum CryptoProviderFlags : byte
{
    cpfUseMachineKeyset = 0x1,
    cpfUsePerUserKeyset = 0x2,
    cpfDisableSystemDialogs = 0x4
}

