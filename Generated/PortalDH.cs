namespace ACBindings.Internal;

public unsafe struct PortalDH
{
    // Members
    public ACBindings.Internal.AC1Legacy.vlong shared_base_;
    public ACBindings.Internal.AC1Legacy.vlong shared_prime_;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005B1300
    /// int __thiscall PortalDH::Init(PortalDH*,AC1Legacy::vlong*,AC1Legacy::vlong*)</code>
    /// </summary>
    public int Init(ACBindings.Internal.AC1Legacy.vlong* shared_base, ACBindings.Internal.AC1Legacy.vlong* shared_prime) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalDH, ACBindings.Internal.AC1Legacy.vlong*, ACBindings.Internal.AC1Legacy.vlong*, int>)0x005B1300)(ref this, shared_base, shared_prime);
}

