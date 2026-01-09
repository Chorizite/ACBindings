namespace ACBindings;

// D3DLevelResourceType
public unsafe struct D3DLevelResourceType
{
    // Members
    public fixed byte m_Resources_Raw[6 * 4];
    public ACBindings.RenderSurfaceD3D** m_Resources => (ACBindings.RenderSurfaceD3D**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_Resources_Raw[0]);

    // Generated Constructor
    public D3DLevelResourceType() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall D3DLevelResourceType::D3DLevelResourceType(D3DLevelResourceType*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.D3DLevelResourceType, void>)0x00696040)(ref this);
}

