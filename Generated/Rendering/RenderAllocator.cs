namespace ACBindings.Internal;


/// <summary>Creates and initializes a rendering context for D3DPolyRender, preparing it for use.</summary>
/// <remarks>Call AllocateRender() to obtain a new Render instance; returns nullptr if allocation fails.</remarks>
public unsafe struct RenderAllocator
{
    // Methods

    /// <summary>Allocates and initializes a rendering context for D3DPolyRender, preparing it for use.
    /// <code>Offset: 0x0058BF30
    /// void* RenderAllocator::AllocateRender()</code>
    /// </summary>
    /// <returns>A pointer to the newly created render context; returns nullptr if memory allocation fails.</returns>
    public static System.IntPtr AllocateRender() => ((delegate* unmanaged[Cdecl]<System.IntPtr>)0x0058BF30)();
}

