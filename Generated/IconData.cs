namespace ACBindings;

// IconData
public unsafe struct IconData
{
    // Base Classes
    public ACBindings.LongHashData BaseClass_LongHashData; // ACBindings.LongHashData

    // Child Types
    // IconData_vtbl
    public unsafe struct IconData_vtbl
    {
        // Members
        public System.IntPtr IconData_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IDClass___tagDataID m_idIcon;
    public ACBindings.IDClass___tagDataID m_idCustomOverlay;
    public ACBindings.IDClass___tagDataID m_idCustomUnderlay;
    public ACBindings.ITEM_TYPE m_itemType;
    public uint m_effects;
    public ACBindings.Graphic* m_pIcon;
    public ACBindings.Graphic* m_pDragIcon;

    // Generated Constructor
    public IconData(ACBindings.ACCWeenieObject* weenObj, int id) {
        _ConstructorInternal(weenObj, id);
    }

    // Methods
    // void __thiscall IconData::RenderIcons(IconData*,ACCWeenieObject*)
    public void RenderIcons(ACBindings.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IconData, ACBindings.ACCWeenieObject*, void>)0x0058DFB0)(ref this, weenObj);
    // void __thiscall IconData::IconData(IconData*,ACCWeenieObject*,int)
    public void _ConstructorInternal(ACBindings.ACCWeenieObject* weenObj, int id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IconData, ACBindings.ACCWeenieObject*, int, void>)0x0058E7B0)(ref this, weenObj, id);
    // int __thiscall IconData::UpdateIcons(IconData*,ACCWeenieObject*)
    public int UpdateIcons(ACBindings.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IconData, ACBindings.ACCWeenieObject*, int>)0x0058E800)(ref this, weenObj);
}

