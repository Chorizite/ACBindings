namespace ACBindings.Internal;

public unsafe struct IconData
{
    // Base Classes
    public ACBindings.Internal.LongHashData BaseClass_LongHashData; // ACBindings.Internal.LongHashData

    // Child Types
    public unsafe struct IconData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IconData*, void> IconData_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID m_idIcon;
    public ACBindings.Internal.IDClass____tagDataID m_idCustomOverlay;
    public ACBindings.Internal.IDClass____tagDataID m_idCustomUnderlay;
    public ACBindings.Internal.ITEM_TYPE m_itemType;
    public uint m_effects;
    public ACBindings.Internal.Graphic* m_pIcon;
    public ACBindings.Internal.Graphic* m_pDragIcon;

    // Generated Constructor
    public IconData(ACBindings.Internal.ACCWeenieObject* weenObj, int id) {
        _ConstructorInternal(weenObj, id);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0058DFB0
    /// void __thiscall IconData::RenderIcons(IconData*,ACCWeenieObject*)</code>
    /// </summary>
    public void RenderIcons(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IconData, ACBindings.Internal.ACCWeenieObject*, void>)0x0058DFB0)(ref this, weenObj);

    /// <summary>
    /// <code>Offset: 0x0058E7B0
    /// void __thiscall IconData::IconData(IconData*,ACCWeenieObject*,int)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.ACCWeenieObject* weenObj, int id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IconData, ACBindings.Internal.ACCWeenieObject*, int, void>)0x0058E7B0)(ref this, weenObj, id);

    /// <summary>
    /// <code>Offset: 0x0058E800
    /// int __thiscall IconData::UpdateIcons(IconData*,ACCWeenieObject*)</code>
    /// </summary>
    public int UpdateIcons(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IconData, ACBindings.Internal.ACCWeenieObject*, int>)0x0058E800)(ref this, weenObj);
}

