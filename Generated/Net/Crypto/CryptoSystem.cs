namespace ACBindings.Internal;

public unsafe struct CryptoSystem : System.IDisposable
{
    // Members
    public uint lastIter_;
    public uint seed_;
    public System.IntPtr pGenerator_;

    // Generated Constructor
    public CryptoSystem(uint seed) {
        _ConstructorInternal(seed);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x006606A0
    /// void __thiscall CryptoSystem::~CryptoSystem(CryptoSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CryptoSystem, void>)0x006606A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00660BB0
    /// void __thiscall CryptoSystem::CryptoSystem(CryptoSystem*,unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(uint seed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CryptoSystem, uint, void>)0x00660BB0)(ref this, seed);

    /// <summary>
    /// <code>Offset: 0x00660EA0
    /// unsigned int __thiscall CryptoSystem::GetNextCryptoSeed(CryptoSystem*,unsigned int)</code>
    /// </summary>
    public uint GetNextCryptoSeed(uint iteration) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CryptoSystem, uint, uint>)0x00660EA0)(ref this, iteration);
}

