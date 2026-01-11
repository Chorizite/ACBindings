namespace ACBindings.Internal;

public unsafe struct PrimVertex
{
    // Members
    public ACBindings.Internal.Vector3 m_vOrigin;
    public fixed byte m_UVs_Raw[8];
    public ACBindings.Internal.TexCoordPair* m_UVs => (ACBindings.Internal.TexCoordPair*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_UVs_Raw[0]);

    // Methods
}

