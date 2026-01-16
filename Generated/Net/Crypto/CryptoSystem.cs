namespace ACBindings.Internal;


/// <summary>Provides cryptographic seed generation using an internal QTIsaac random‑number generator.</summary>
/// <remarks>Maintains a counter of iterations, stores the initial seed value, and holds a reference to the generator object responsible for producing pseudo‑random seeds on demand.</remarks>
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

    /// <summary>Releases the CryptoSystem's generator resource and clears the internal pointer during destruction.
    /// <code>Offset: 0x006606A0
    /// void __thiscall CryptoSystem::~CryptoSystem(CryptoSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CryptoSystem, void>)0x006606A0)(ref this);

    /// <summary>Initializes a cryptographic system, setting the iteration counter and storing the supplied seed while constructing a QTIsaac random‑number generator instance.
    /// <code>Offset: 0x00660BB0
    /// void __thiscall CryptoSystem::CryptoSystem(CryptoSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="seed">The initial value used to seed the random number generator.</param>
    public void _ConstructorInternal(uint seed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CryptoSystem, uint, void>)0x00660BB0)(ref this, seed);

    /// <summary>Returns the next cryptographic seed from the CryptoSystem instance, refilling its internal buffer when exhausted.
    /// <code>Offset: 0x00660EA0
    /// unsigned int __thiscall CryptoSystem::GetNextCryptoSeed(CryptoSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="iteration">Iteration index for the requested seed (currently unused).</param>
    /// <returns>The next unsigned integer seed value.</returns>
    public uint GetNextCryptoSeed(uint iteration) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CryptoSystem, uint, uint>)0x00660EA0)(ref this, iteration);
}

