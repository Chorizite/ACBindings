namespace ACBindings.Internal;


/// <summary>Represents a shadow component linked to a physics part, containing the count of clipping planes, a pointer to those planes, and contextual frame data for rendering or simulation.</summary>
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

    /// <summary>Initializes a shadow component with a defined number of clip planes and links it to a scene frame and physical part.
    /// <code>Offset: 0x006B5F90
    /// void __thiscall CShadowPart::CShadowPart(CShadowPart*,unsigned int,const Frame*,CPhysicsPart*)</code>
    /// </summary>
    /// <param name="nump">Number of clipping planes the shadow will consist of.</param>
    /// <param name="frame">Reference to the frame defining position and orientation for the shadow.</param>
    /// <param name="part">Physics part that owns or is associated with this shadow component.</param>
    public void _ConstructorInternal(uint nump, ACBindings.Internal.Frame* frame, ACBindings.Internal.CPhysicsPart* part) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CShadowPart, uint, ACBindings.Internal.Frame*, ACBindings.Internal.CPhysicsPart*, void>)0x006B5F90)(ref this, nump, frame, part);

    /// <summary>Initializes a CShadowPart instance with the given number of clip planes, plane list references, frame context, and associated physics part.
    /// <code>Offset: 0x006B5FF0
    /// void __thiscall CShadowPart::CShadowPart(CShadowPart*,unsigned int,ClipPlaneList**,const Frame*,CPhysicsPart*)</code>
    /// </summary>
    /// <param name="nump">The number of clipping planes that define this shadow part.</param>
    /// <param name="planes">An array of pointers to ClipPlaneList structures describing individual clip planes.</param>
    /// <param name="frame">The Frame providing transformation data for the shadow.</param>
    /// <param name="part">The CPhysicsPart instance associated with this shadow part.</param>
    public void _ConstructorInternal(uint nump, ACBindings.Internal.ClipPlaneList** planes, ACBindings.Internal.Frame* frame, ACBindings.Internal.CPhysicsPart* part) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CShadowPart, uint, ACBindings.Internal.ClipPlaneList**, ACBindings.Internal.Frame*, ACBindings.Internal.CPhysicsPart*, void>)0x006B5FF0)(ref this, nump, planes, frame, part);

    /// <summary>Renders the physics part associated with this shadow part, ignoring the supplied leaf index and always drawing at level 0.
    /// <code>Offset: 0x006B6010
    /// void __thiscall CShadowPart::draw(CShadowPart*,unsigned int)</code>
    /// </summary>
    /// <param name="leaf_index">The rendering leaf index that would normally be used, but is ignored in this implementation; a value of zero is passed to CPhysicsPart::Draw.</param>
    public void draw(uint leaf_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CShadowPart, uint, void>)0x006B6010)(ref this, leaf_index);

    /// <summary>Destroys a CShadowPart instance, freeing all associated clip plane lists and deallocating the planes array.
    /// <code>Offset: 0x006B6020
    /// void __thiscall CShadowPart::~CShadowPart(CShadowPart*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CShadowPart, void>)0x006B6020)(ref this);

    /// <summary>Sorts an array of pointers in ascending order based on a floating‑point key stored inside each object using insertion sort.
    /// <code>Offset: 0x006B6070
    /// int __cdecl CShadowPart::insertion_sort(int*,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the first element of the array to be sorted.</param>
    /// <param name="a2">Number of elements in the array.</param>
    /// <returns>Returns the original base address of the array after sorting (unchanged).</returns>
    public static int insertion_sort(int* a1, int a2) => ((delegate* unmanaged[Cdecl]<int*, int, int>)0x006B6070)(a1, a2);
}

