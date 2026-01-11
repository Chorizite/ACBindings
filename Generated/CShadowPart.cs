namespace ACBindings.Internal;

public unsafe struct CShadowPart : System.IDisposable
{
    // Members
    public uint num_planes;
    public ACBindings.Internal.ClipPlaneList** planes;
    public ACBindings.Internal.Frame* frame;
    public ACBindings.Internal.CPhysicsPart* part;

    // Generated Constructor
    public CShadowPart(uint nump, ACBindings.Internal.Frame* frame, ACBindings.Internal.CPhysicsPart* part) {
        _ConstructorInternal(nump, frame, part);
    }
    public CShadowPart(uint nump, ACBindings.Internal.ClipPlaneList** planes, ACBindings.Internal.Frame* frame, ACBindings.Internal.CPhysicsPart* part) {
        _ConstructorInternal(nump, planes, frame, part);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x006B5F90
    /// void __thiscall CShadowPart::CShadowPart(CShadowPart*,unsigned int,const Frame*,CPhysicsPart*)</code>
    /// </summary>
    public void _ConstructorInternal(uint nump, ACBindings.Internal.Frame* frame, ACBindings.Internal.CPhysicsPart* part) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CShadowPart, uint, ACBindings.Internal.Frame*, ACBindings.Internal.CPhysicsPart*, void>)0x006B5F90)(ref this, nump, frame, part);

    /// <summary>
    /// <code>Offset: 0x006B5FF0
    /// void __thiscall CShadowPart::CShadowPart(CShadowPart*,unsigned int,ClipPlaneList**,const Frame*,CPhysicsPart*)</code>
    /// </summary>
    public void _ConstructorInternal(uint nump, ACBindings.Internal.ClipPlaneList** planes, ACBindings.Internal.Frame* frame, ACBindings.Internal.CPhysicsPart* part) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CShadowPart, uint, ACBindings.Internal.ClipPlaneList**, ACBindings.Internal.Frame*, ACBindings.Internal.CPhysicsPart*, void>)0x006B5FF0)(ref this, nump, planes, frame, part);

    /// <summary>
    /// <code>Offset: 0x006B6010
    /// void __thiscall CShadowPart::draw(CShadowPart*,unsigned int)</code>
    /// </summary>
    public void draw(uint leaf_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CShadowPart, uint, void>)0x006B6010)(ref this, leaf_index);

    /// <summary>
    /// <code>Offset: 0x006B6020
    /// void __thiscall CShadowPart::~CShadowPart(CShadowPart*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CShadowPart, void>)0x006B6020)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B6070
    /// int __cdecl CShadowPart::insertion_sort(int*,int)</code>
    /// </summary>
    public static int insertion_sort(int* a1, int a2) => ((delegate* unmanaged[Cdecl]<int*, int, int>)0x006B6070)(a1, a2);
}

