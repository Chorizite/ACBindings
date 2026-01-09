namespace ACBindings;

// CryptoSystem
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
    // void __thiscall CryptoSystem::~CryptoSystem(CryptoSystem*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CryptoSystem, void>)0x006606A0)(ref this);
    // void __thiscall CryptoSystem::CryptoSystem(CryptoSystem*,unsigned int)
    public void _ConstructorInternal(uint seed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CryptoSystem, uint, void>)0x00660BB0)(ref this, seed);
    // unsigned int __thiscall CryptoSystem::GetNextCryptoSeed(CryptoSystem*,unsigned int)
    public uint GetNextCryptoSeed(uint iteration) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CryptoSystem, uint, uint>)0x00660EA0)(ref this, iteration);
}

