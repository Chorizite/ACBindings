namespace ACBindings.Internal;


/// <summary>Describes capabilities of a vertex shader in Direct3D, specifying supported features and resource limits such as flow control depth and temporary registers.</summary>
public unsafe struct _D3DVSHADERCAPS2_0
{
    // Members
    public uint Caps;
    public int DynamicFlowControlDepth;
    public int NumTemps;
    public int StaticFlowControlDepth;

    // Methods
}

