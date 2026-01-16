namespace ACBindings.Internal;


/// <summary>Defines a rectangular view area using integer coordinates (x0, y0) for the top‑left corner and (x1, y1) for the bottom‑right corner, with a flag indicating validity of the region.</summary>
public unsafe struct View
{
    // Members
    public int x0;
    public int x1;
    public int y0;
    public int y1;
    public byte valid;

    // Methods
}

