namespace ACBindings.Internal;


/// <summary>Stores joystick position coordinates (x, y) and incremental changes (_dx, dy) for ramping logic. Used by input handling code to smooth and limit movement speed.</summary>
public unsafe struct JOYRAMP
{
    // Members
    public int x;
    public int y;
    public uint _dx;
    public int dy;

    // Methods
}

