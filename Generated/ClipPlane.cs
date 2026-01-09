namespace ACBindings;

// ClipPlane
public unsafe struct ClipPlane
{
    // Members
    public ACBindings.Plane* plane;
    public ACBindings.Sidedness side;

    // Generated Constructor
    public ClipPlane() {
        _ConstructorInternal();
    }
    public ClipPlane(ACBindings.Plane* plane, ACBindings.Sidedness side) {
        _ConstructorInternal(plane, side);
    }

    // Methods
    // void __thiscall ClipPlane::ClipPlane(ClipPlane*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClipPlane, void>)0x00535A80)(ref this);
    // void __thiscall ClipPlane::ClipPlane(ClipPlane*,Plane*,Sidedness)
    public void _ConstructorInternal(ACBindings.Plane* plane, ACBindings.Sidedness side) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClipPlane, ACBindings.Plane*, ACBindings.Sidedness, void>)0x00535A90)(ref this, plane, side);
}

