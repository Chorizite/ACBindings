namespace ACBindings.Internal;


/// <summary>Stores primary (strength, endurance, quickness, coordination, focus, self) and secondary (health, stamina, mana) attributes for a character, handling their allocation, serialization, deserialization, and cleanup.</summary>
public unsafe struct AttributeCache
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AttributeCache_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeCache*, void> AttributeCache_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeCache*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeCache*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeCache*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.Attribute* _strength;
    public ACBindings.Internal.Attribute* _endurance;
    public ACBindings.Internal.Attribute* _quickness;
    public ACBindings.Internal.Attribute* _coordination;
    public ACBindings.Internal.Attribute* _focus;
    public ACBindings.Internal.Attribute* _self;
    public ACBindings.Internal.SecondaryAttribute* _health;
    public ACBindings.Internal.SecondaryAttribute* _stamina;
    public ACBindings.Internal.SecondaryAttribute* _mana;

    // Generated Constructor
    public AttributeCache() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Releases all attribute objects stored in the cache and clears their references.
    /// <code>Offset: 0x005CD390
    /// void __thiscall AttributeCache::CleanUp(AttributeCache*)</code>
    /// </summary>
    public void CleanUp() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, void>)0x005CD390)(ref this);

    /// <summary>Retrieves the combined base and CP-derived level for a specified attribute type.
    /// <code>Offset: 0x005CD430
    /// int __thiscall AttributeCache::InqAttribute(AttributeCache*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the requested attribute (1–6).</param>
    /// <param name="retval">Pointer where the calculated level is stored on success.</param>
    /// <returns>Non‑zero if the attribute exists; zero otherwise.</returns>
    public int InqAttribute(uint stype, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, uint*, int>)0x005CD430)(ref this, stype, retval);

    /// <summary>Retrieves a secondary attribute value based on the supplied type code and stores it in the provided output parameter.
    /// <code>Offset: 0x005CD520
    /// int __thiscall AttributeCache::InqAttribute2nd(AttributeCache*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="stype">Identifier for the desired secondary attribute: 1=Health base level, 2=Health current level, 3=Stamina base level, 4=Stamina current level, 5=Mana base level, 6=Mana current level.</param>
    /// <param name="retval">Pointer to an unsigned integer where the resulting value will be written.</param>
    /// <returns>1 if the attribute exists and was written; otherwise 0.</returns>
    public int InqAttribute2nd(uint stype, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, uint*, int>)0x005CD520)(ref this, stype, retval);

    /// <summary>Initializes a new AttributeCache, assigning the virtual table pointer and setting all attribute references to nullptr.
    /// <code>Offset: 0x005CD5F0
    /// void __thiscall AttributeCache::AttributeCache(AttributeCache*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, void>)0x005CD5F0)(ref this);

    /// <summary>Retrieves the specified attribute from the cache and copies its values into the provided Attribute object.
    /// <code>Offset: 0x005CD620
    /// int __thiscall AttributeCache::InqAttribute(AttributeCache*,unsigned int,Attribute*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the attribute to retrieve (1=Strength, 2=Endurance, 3=Quickness, 4=Coordination, 5=Focus, 6=Self).</param>
    /// <param name="retval">Pointer to an Attribute structure that receives the copied data when the attribute exists.</param>
    /// <returns>Non‑zero if the requested attribute is present; zero otherwise.</returns>
    public int InqAttribute(uint stype, ACBindings.Internal.Attribute* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, ACBindings.Internal.Attribute*, int>)0x005CD620)(ref this, stype, retval);

    /// <summary>Sets or updates an Attribute in the cache based on attribute type, creating a new instance if necessary.
    /// <code>Offset: 0x005CD690
    /// int __thiscall AttributeCache::SetAttribute(AttributeCache*,unsigned int,const Attribute*)</code>
    /// </summary>
    /// <param name="stype">Identifier for which attribute slot to set (1=Strength, 2=Endurance, etc.).</param>
    /// <param name="val">The Attribute data used to initialize or update the cached value.</param>
    /// <returns>Non‑zero when the attribute is stored or updated; zero if the type identifier is unsupported.</returns>
    public int SetAttribute(uint stype, ACBindings.Internal.Attribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, ACBindings.Internal.Attribute*, int>)0x005CD690)(ref this, stype, val);

    /// <summary>Sets the initial level of a specified primary attribute, allocating an Attribute object if it does not yet exist.
    /// <code>Offset: 0x005CD860
    /// int __thiscall AttributeCache::SetAttribute(AttributeCache*,unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="stype">The attribute type identifier (1–6).</param>
    /// <param name="val">The value to assign as the attribute's initial level.</param>
    /// <returns>Returns 1 on success; returns 0 if the attribute type is unsupported.</returns>
    public int SetAttribute(uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, uint, int>)0x005CD860)(ref this, stype, val);

    /// <summary>Retrieves a secondary attribute from the cache based on the provided type identifier and copies its data into the supplied structure.
    /// <code>Offset: 0x005CDA20
    /// int __thiscall AttributeCache::InqAttribute2nd(AttributeCache*,unsigned int,SecondaryAttribute*)</code>
    /// </summary>
    /// <param name="stype">Identifier specifying which secondary attribute to retrieve (e.g., health, stamina, mana).</param>
    /// <param name="retval">Pointer to a SecondaryAttribute structure that will receive the retrieved values.</param>
    /// <returns>1 if the attribute exists and was copied successfully; otherwise 0.</returns>
    public int InqAttribute2nd(uint stype, ACBindings.Internal.SecondaryAttribute* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, ACBindings.Internal.SecondaryAttribute*, int>)0x005CDA20)(ref this, stype, retval);

    /// <summary>Sets the specified secondary attribute in the cache using the provided value.
    /// <code>Offset: 0x005CDA90
    /// int __thiscall AttributeCache::SetAttribute2nd(AttributeCache*,unsigned int,const SecondaryAttribute*)</code>
    /// </summary>
    /// <param name="stype">An identifier for the target attribute: 1–2 for health, 3–4 for stamina, 5–6 for mana.</param>
    /// <param name="val">The source SecondaryAttribute containing the levels to copy into the cache.</param>
    /// <returns>Returns 1 when the attribute is successfully set or created; returns 0 if an unsupported stype is supplied.</returns>
    public int SetAttribute2nd(uint stype, ACBindings.Internal.SecondaryAttribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, ACBindings.Internal.SecondaryAttribute*, int>)0x005CDA90)(ref this, stype, val);

    /// <summary>Sets the initial or current level of a secondary attribute in an AttributeCache, creating the attribute object if it does not yet exist.
    /// <code>Offset: 0x005CDBA0
    /// int __thiscall AttributeCache::SetAttribute2nd(AttributeCache*,unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="stype">The code identifying which secondary attribute to modify and whether to set its initialization level (1, 3, 5) or current level (2, 4, 6).</param>
    /// <param name="val">The value to assign to the selected attribute's level field.</param>
    /// <returns>Non‑zero if the attribute was successfully updated; zero if the provided stype is invalid.</returns>
    public int SetAttribute2nd(uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, uint, int>)0x005CDBA0)(ref this, stype, val);

    /// <summary>Serializes the current attribute cache into the supplied buffer and reports the total byte count required, including a 4‑byte flag header that indicates which attributes are present.
    /// <code>Offset: 0x005CDD70
    /// unsigned int __thiscall AttributeCache::Pack(AttributeCache*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location; advanced as each attribute is packed.</param>
    /// <param name="size">Maximum number of bytes available for packing. If less than the required size, only the size is computed without writing data.</param>
    /// <returns>The total number of bytes needed to pack all present attributes, including the initial flag mask.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, void**, uint, uint>)0x005CDD70)(ref this, addr, size);

    /// <summary>Deserializes attribute values from the supplied buffer into this AttributeCache instance, allocating missing attributes and freeing those marked absent by an initial presence mask.
    /// <code>Offset: 0x005CDF00
    /// int __thiscall AttributeCache::UnPack(AttributeCache*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the data buffer; updated as bytes are consumed during unpacking.</param>
    /// <param name="size">Number of bytes remaining in the buffer that may be read; if fewer than required, the function returns failure.</param>
    /// <returns>1 when all requested attributes were successfully unpacked and applied; 0 if parsing fails due to insufficient data or allocation issues.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, void**, uint, int>)0x005CDF00)(ref this, addr, size);
}

