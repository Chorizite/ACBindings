namespace ACBindings.Internal;


/// <summary>Provides utilities for handling file identifiers, dummy entries, and path resolution, enabling consistent management of missing or placeholder files within the application.</summary>
public unsafe struct FileArray
{
    // Methods

    /// <summary>Resets the supplied IDClass instance to an invalid identifier and returns it.
    /// <code>Offset: 0x006791F0
    /// IDClass&lt;_tagDataID,32,0&gt;* __cdecl FileArray::GetDID(IDClass&lt;_tagDataID,32,0&gt;*,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a1">The IDClass object whose identifier will be set to an invalid value.</param>
    /// <param name="a2">Pointer used for a condition check; its contents influence early return behavior but not the final result.</param>
    /// <param name="a3">Optional flag that may trigger an earlier return when the condition fails.</param>
    /// <returns>Reference to the modified IDClass instance.</returns>
    public static ACBindings.Internal.IDClass____tagDataID* GetDID(ACBindings.Internal.IDClass____tagDataID* a1, int* a2, int a3) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.IDClass____tagDataID*, int*, int, ACBindings.Internal.IDClass____tagDataID*>)0x006791F0)(a1, a2, a3);

    /// <summary>Assigns a null string to the provided PStringBase instance, incrementing its internal reference counter and returning the updated instance.
    /// <code>Offset: 0x00679220
    /// PStringBase&lt;char&gt;* __cdecl FileArray::GetRelativeFilePath(PStringBase&lt;char&gt;*)</code>
    /// </summary>
    /// <param name="a1">The string object to be set to an empty value.</param>
    /// <returns>The same PStringBase instance after it has been assigned a null string.</returns>
    public static ACBindings.Internal.PStringBase__sbyte* GetRelativeFilePath(ACBindings.Internal.PStringBase__sbyte* a1) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PStringBase__sbyte*, ACBindings.Internal.PStringBase__sbyte*>)0x00679220)(a1);

    /// <summary>Assigns an empty file name to the supplied PStringBase, increments its reference count, and optionally resolves a type when the identifier differs from INVALID_DID_426.
    /// <code>Offset: 0x00679240
    /// PStringBase&lt;char&gt;* __cdecl FileArray::GetFileNameForDummies(PStringBase&lt;char&gt;*,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the PStringBase instance that will receive the empty string.</param>
    /// <param name="a2">Identifier used to decide whether MasterDBMap::DivineType should be invoked; ignored if equal to INVALID_DID_426.baseclass_0.id.</param>
    /// <returns>Reference to the updated PStringBase instance.</returns>
    public static ACBindings.Internal.PStringBase__sbyte* GetFileNameForDummies(ACBindings.Internal.PStringBase__sbyte* a1, int a2) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PStringBase__sbyte*, int, ACBindings.Internal.PStringBase__sbyte*>)0x00679240)(a1, a2);

    /// <summary>Assigns a globally shared empty string reference to the supplied PStringBase instance and increments its reference count.
    /// <code>Offset: 0x00679290
    /// PStringBase&lt;char&gt;* __cdecl FileArray::GetAbsoluteFilePathForDummies(PStringBase&lt;char&gt;*,int)</code>
    /// </summary>
    /// <param name="a1">The string object to be populated with an empty path.</param>
    /// <param name="a2">Identifier passed to MasterDBMap::DivineType, used for side‑effects such as logging or bookkeeping.</param>
    /// <returns>Pointer to the modified string object (the same as a1).</returns>
    public static ACBindings.Internal.PStringBase__sbyte* GetAbsoluteFilePathForDummies(ACBindings.Internal.PStringBase__sbyte* a1, int a2) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PStringBase__sbyte*, int, ACBindings.Internal.PStringBase__sbyte*>)0x00679290)(a1, a2);
}

