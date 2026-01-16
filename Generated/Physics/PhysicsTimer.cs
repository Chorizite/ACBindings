namespace ACBindings.Internal;


/// <summary>Designates a timer dedicated to the physics subsystem, facilitating type‑safe handling of physics‑specific timing operations.</summary>
/// <remarks>Empty implementation acts as a marker type within the system’s timing framework.</remarks>
public unsafe struct PhysicsTimer
{
    // Statics
    public static double* curr_time = (double*)0x008EEE70;

    // Methods
}

