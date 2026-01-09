namespace ACBindings;

// PrimVertex
public unsafe struct PrimVertex
{
    // Members
    public ACBindings.Vector3 m_vOrigin;
    public fixed byte m_UVs_Raw[8];
    public ACBindings.TexCoordPair* m_UVs => (ACBindings.TexCoordPair*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_UVs_Raw[0]);

    // Methods
}

