namespace ACBindings.Internal;


/// <summary>Encapsulates compiled shader resources, storing the shader version, entry‑point names, and binary blobs for both vertex and pixel stages.</summary>
public unsafe struct ShaderResourceType : System.IDisposable
{
    // Members
    public ACBindings.Internal.ShaderVersionType Version;
    public ACBindings.Internal.PStringBase__sbyte VertexShaderFunctionName;
    public ACBindings.Internal.PStringBase__sbyte PixelShaderFunctionName;
    public ACBindings.Internal.SmartBuffer BinaryVertexShaderData;
    public ACBindings.Internal.SmartBuffer BinaryPixelShaderData;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases the binary shader data buffers and decrements reference counts for vertex and pixel shader names, freeing associated memory when counts reach zero.
    /// <code>Offset: 0x0044A3F0
    /// void __thiscall ShaderResourceType::~ShaderResourceType(ShaderResourceType*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShaderResourceType, void>)0x0044A3F0)(ref this);
}

