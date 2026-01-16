namespace ACBindings.Internal;


/// <summary>Encapsulates a stream‑packable collection of string objects, offering dynamic storage and serialization support.</summary>
public unsafe struct PSmartArray___AC1Legacy_PStringBase__sbyte
{
    // Base Classes
    public ACBindings.Internal.StreamPackObj BaseClass_StreamPackObj; // ACBindings.Internal.StreamPackObj
    public ACBindings.Internal.AC1Legacy.SmartArray___AC1Legacy_PStringBase__sbyte BaseClass_AC1Legacy_SmartArray; // ACBindings.Internal.AC1Legacy.SmartArray___AC1Legacy_PStringBase__sbyte

    // Methods

    /// <summary>Serializes or deserializes an array of PStringBase&lt;char&gt; objects by packing the element count followed by each string entry.
    /// <code>Offset: 0x005B8440
    /// int __thiscall PSmartArray&lt;AC1Legacy::PStringBase&lt;char&gt;&gt;::StreamPack(_DWORD*,STREAMTYPE,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="op">Specifies whether to pack or unpack the stream.</param>
    /// <param name="addr">Reference to the buffer used for serialization or deserialization.</param>
    /// <param name="size">Pointer to the size of the buffer; updated during packing/unpacking.</param>
    /// <returns>Returns 1 on successful processing of all elements, otherwise returns 0. If unpacking, expands the array to accommodate the incoming number of items.</returns>
    // int __thiscall PSmartArray<AC1Legacy::PStringBase<char>>::StreamPack(_DWORD*,STREAMTYPE,void**,unsigned int*) (template type method)
}

public unsafe struct PSmartArray__uint
{
    // Base Classes
    public ACBindings.Internal.StreamPackObj BaseClass_StreamPackObj; // ACBindings.Internal.StreamPackObj
    public ACBindings.Internal.AC1Legacy.SmartArray__uint BaseClass_AC1Legacy_SmartArray; // ACBindings.Internal.AC1Legacy.SmartArray__uint

    // Methods
}

