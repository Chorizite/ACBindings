namespace ACBindings.Internal.AC1Legacy;


/// <summary>Encodes a 3‑D rotation as four floating‑point values.</summary>
/// <remarks>Stored in an array e[4] typically representing the quaternion components (w, x, y, z).</remarks>
public unsafe struct Quaternion
{
    // Members
    public fixed float e[4];

    // Methods
}

