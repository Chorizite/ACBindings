namespace ACBindings.Internal;

public unsafe struct D3DLevelResourceType
{
    // Members
    public fixed byte m_Resources_Raw[6 * 4];
    public ACBindings.Internal.RenderSurfaceD3D** m_Resources => (ACBindings.Internal.RenderSurfaceD3D**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_Resources_Raw[0]);

    // Generated Constructor
    public D3DLevelResourceType() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00696040
    /// void __thiscall D3DLevelResourceType::D3DLevelResourceType(D3DLevelResourceType*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DLevelResourceType, void>)0x00696040)(ref this);
}

