namespace ACBindings.Internal;

public unsafe struct ClipPlane
{
    // Members
    public ACBindings.Internal.Plane* plane;
    public ACBindings.Internal.Sidedness side;

    // Generated Constructor
    public ClipPlane() {
        _ConstructorInternal();
    }
    public ClipPlane(ACBindings.Internal.Plane* plane, ACBindings.Internal.Sidedness side) {
        _ConstructorInternal(plane, side);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00535A80
    /// void __thiscall ClipPlane::ClipPlane(ClipPlane*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClipPlane, void>)0x00535A80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00535A90
    /// void __thiscall ClipPlane::ClipPlane(ClipPlane*,Plane*,Sidedness)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.Plane* plane, ACBindings.Internal.Sidedness side) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClipPlane, ACBindings.Internal.Plane*, ACBindings.Internal.Sidedness, void>)0x00535A90)(ref this, plane, side);
}

