namespace ACBindings.Internal;


/// <summary>A clip plane pairing a Plane reference with its sidedness, used to define which side of the plane is considered inside during clipping operations.</summary>
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

    /// <summary>Initializes a new ClipPlane instance by setting its plane pointer to null.
    /// <code>Offset: 0x00535A80
    /// void __thiscall ClipPlane::ClipPlane(ClipPlane*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClipPlane, void>)0x00535A80)(ref this);

    /// <summary>Initializes a ClipPlane with the specified plane and sidedness.
    /// <code>Offset: 0x00535A90
    /// void __thiscall ClipPlane::ClipPlane(ClipPlane*,Plane*,Sidedness)</code>
    /// </summary>
    /// <param name="plane">The plane defining the clipping geometry.</param>
    /// <param name="side">Specifies which side of the plane constitutes the clip region.</param>
    public void _ConstructorInternal(ACBindings.Internal.Plane* plane, ACBindings.Internal.Sidedness side) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClipPlane, ACBindings.Internal.Plane*, ACBindings.Internal.Sidedness, void>)0x00535A90)(ref this, plane, side);
}

