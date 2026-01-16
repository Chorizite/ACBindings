namespace ACBindings.Internal;


/// <summary>Assigns a name stem, creates a named mutex to guarantee a unique instance index, and stores that index internally.</summary>
public unsafe struct InstanceDiviner
{
    // Members
    public ACBindings.Internal.PStringBase__sbyte m_NameStem;
    public System.IntPtr m_hMutex;
    public uint m_Index;

    // Generated Constructor
    public InstanceDiviner(int a2, sbyte a3, int a4) {
        _ConstructorInternal(a2, a3, a4);
    }

    // Methods

    /// <summary>Creates a unique numeric index for an instance by generating a named mutex based on the object’s name stem and stores that index internally.
    /// <code>Offset: 0x0040EB80
    /// const char* __thiscall InstanceDiviner::AllocateIndex(const char**,int,int)</code>
    /// </summary>
    /// <param name="a2">Starting index to try; if zero, the search begins at 1.</param>
    /// <param name="a3">Pointer used to initialize the object's name stem when it has not been set; may be modified during execution.</param>
    /// <returns>Const char* pointing to the internally stored index value assigned to the instance.</returns>
    public sbyte* AllocateIndex(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InstanceDiviner, int, int, sbyte*>)0x0040EB80)(ref this, a2, a3);

    /// <summary>Constructs an InstanceDiviner by assigning the supplied name stem, optionally allocating an index, and managing reference counts for the shared string resources.
    /// <code>Offset: 0x0040EE10
    /// int __thiscall InstanceDiviner::InstanceDiviner(int,int,char,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a PStringBase&lt;char&gt; instance that becomes the diviner's name stem. The constructor increments its reference count upon construction.</param>
    /// <param name="a3">Flag controlling whether an index is allocated; when non‑zero AllocateIndex is invoked with a4 and the null string buffer.</param>
    /// <param name="a4">Integer parameter passed to AllocateIndex when allocating an index.</param>
    /// <returns>Pointer to the newly constructed InstanceDiviner (this).</returns>
    public int _ConstructorInternal(int a2, sbyte a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InstanceDiviner, int, sbyte, int, int>)0x0040EE10)(ref this, a2, a3, a4);
}

