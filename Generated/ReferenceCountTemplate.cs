namespace ACBindings.Internal;


/// <summary>Maintains an internal reference counter (m_cRef) to manage object lifetime and holds a vtable pointer (__vftable) for polymorphic behavior.</summary>
public unsafe struct ReferenceCountTemplate
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_cRef;

    // Methods
}

