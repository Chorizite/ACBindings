namespace ACBindings.Internal;


/// <summary>Holds metadata for a handler, including attribute flags, a type reference, a catch‑object identifier, and the address of the handler function or object.</summary>
public unsafe struct HandlerType
{
    // Members
    public int adjectives;
    public System.IntPtr pType;
    public int dispCatchObj;
    public System.IntPtr addressOfHandler;

    // Methods
}

