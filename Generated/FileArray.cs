namespace ACBindings.Internal;

public unsafe struct FileArray
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x006791F0
    /// IDClass&lt;_tagDataID,32,0&gt;* __cdecl FileArray::GetDID(IDClass&lt;_tagDataID,32,0&gt;*,_DWORD*,int)</code>
    /// </summary>
    public static ACBindings.Internal.IDClass____tagDataID* GetDID(ACBindings.Internal.IDClass____tagDataID* a1, int* a2, int a3) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.IDClass____tagDataID*, int*, int, ACBindings.Internal.IDClass____tagDataID*>)0x006791F0)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00679220
    /// PStringBase&lt;char&gt;* __cdecl FileArray::GetRelativeFilePath(PStringBase&lt;char&gt;*)</code>
    /// </summary>
    public static ACBindings.Internal.PStringBase__sbyte* GetRelativeFilePath(ACBindings.Internal.PStringBase__sbyte* a1) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PStringBase__sbyte*, ACBindings.Internal.PStringBase__sbyte*>)0x00679220)(a1);

    /// <summary>
    /// <code>Offset: 0x00679240
    /// PStringBase&lt;char&gt;* __cdecl FileArray::GetFileNameForDummies(PStringBase&lt;char&gt;*,int)</code>
    /// </summary>
    public static ACBindings.Internal.PStringBase__sbyte* GetFileNameForDummies(ACBindings.Internal.PStringBase__sbyte* a1, int a2) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PStringBase__sbyte*, int, ACBindings.Internal.PStringBase__sbyte*>)0x00679240)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x00679290
    /// PStringBase&lt;char&gt;* __cdecl FileArray::GetAbsoluteFilePathForDummies(PStringBase&lt;char&gt;*,int)</code>
    /// </summary>
    public static ACBindings.Internal.PStringBase__sbyte* GetAbsoluteFilePathForDummies(ACBindings.Internal.PStringBase__sbyte* a1, int a2) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PStringBase__sbyte*, int, ACBindings.Internal.PStringBase__sbyte*>)0x00679290)(a1, a2);
}

