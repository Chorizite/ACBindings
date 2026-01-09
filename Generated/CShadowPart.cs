namespace ACBindings;

// CShadowPart
public unsafe struct CShadowPart : System.IDisposable
{
    // Members
    public uint num_planes;
    public ACBindings.ClipPlaneList** planes;
    public ACBindings.Frame* frame;
    public ACBindings.CPhysicsPart* part;

    // Generated Constructor
    public CShadowPart(uint nump, ACBindings.Frame* frame, ACBindings.CPhysicsPart* part) {
        _ConstructorInternal(nump, frame, part);
    }
    public CShadowPart(uint nump, ACBindings.ClipPlaneList** planes, ACBindings.Frame* frame, ACBindings.CPhysicsPart* part) {
        _ConstructorInternal(nump, planes, frame, part);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CShadowPart::CShadowPart(CShadowPart*,unsigned int,const Frame*,CPhysicsPart*)
    public void _ConstructorInternal(uint nump, ACBindings.Frame* frame, ACBindings.CPhysicsPart* part) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CShadowPart, uint, ACBindings.Frame*, ACBindings.CPhysicsPart*, void>)0x006B5F90)(ref this, nump, frame, part);
    // void __thiscall CShadowPart::CShadowPart(CShadowPart*,unsigned int,ClipPlaneList**,const Frame*,CPhysicsPart*)
    public void _ConstructorInternal(uint nump, ACBindings.ClipPlaneList** planes, ACBindings.Frame* frame, ACBindings.CPhysicsPart* part) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CShadowPart, uint, ACBindings.ClipPlaneList**, ACBindings.Frame*, ACBindings.CPhysicsPart*, void>)0x006B5FF0)(ref this, nump, planes, frame, part);
    // void __thiscall CShadowPart::draw(CShadowPart*,unsigned int)
    public void draw(uint leaf_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CShadowPart, uint, void>)0x006B6010)(ref this, leaf_index);
    // void __thiscall CShadowPart::~CShadowPart(CShadowPart*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CShadowPart, void>)0x006B6020)(ref this);
    // int __cdecl CShadowPart::insertion_sort(int*,int)
    public static int insertion_sort(int* a1, int a2) => ((delegate* unmanaged[Cdecl]<int*, int, int>)0x006B6070)(a1, a2);
}

