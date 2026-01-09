namespace ACBindings;

// ShaderResourceType
public unsafe struct ShaderResourceType : System.IDisposable
{
    // Members
    public ACBindings.ShaderVersionType Version;
    public ACBindings.PStringBase__sbyte VertexShaderFunctionName;
    public ACBindings.PStringBase__sbyte PixelShaderFunctionName;
    public ACBindings.SmartBuffer BinaryVertexShaderData;
    public ACBindings.SmartBuffer BinaryPixelShaderData;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ShaderResourceType::~ShaderResourceType(ShaderResourceType*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ShaderResourceType, void>)0x0044A3F0)(ref this);
}

