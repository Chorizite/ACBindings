namespace ACBindings.Internal;


/// <summary>Holds icon information for a game object, including base identifiers, custom overlay/underlay IDs, item type, effect flags, and references to the rendered icon graphics.</summary>
/// <remarks>IconData is initialized from an ACCWeenieObject instance and automatically renders normal and drag icons. The struct tracks whether rendering needs updating by comparing current state against new object data.</remarks>
public unsafe struct IconData
{
    // Base Classes
    public ACBindings.Internal.LongHashData BaseClass_LongHashData; // ACBindings.Internal.LongHashData

    // Child Types
    public unsafe struct IconData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IconData*, void> IconData_dtor_0; // function pointer

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

    /// <summary>Renders the normal and drag icons for a game object by querying its properties, loading textures from the database, and creating graphics surfaces for display.
    /// <code>Offset: 0x0058DFB0
    /// void __thiscall IconData::RenderIcons(IconData*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="weenObj">The object whose icon data is rendered.</param>
    public void RenderIcons(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IconData, ACBindings.Internal.ACCWeenieObject*, void>)0x0058DFB0)(ref this, weenObj);

    /// <summary>Initializes icon data for a specific object and renders its icons using the provided object reference.
    /// <code>Offset: 0x0058E7B0
    /// void __thiscall IconData::IconData(IconData*,ACCWeenieObject*,int)</code>
    /// </summary>
    /// <param name="weenObj">Object whose visual representation is to be rendered.</param>
    /// <param name="id">Unique identifier assigned to this icon data instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.ACCWeenieObject* weenObj, int id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IconData, ACBindings.Internal.ACCWeenieObject*, int, void>)0x0058E7B0)(ref this, weenObj, id);

    /// <summary>Updates this IconData's visual representation using the supplied object, rendering new icons only when the object's properties differ from the current state.
    /// <code>Offset: 0x0058E800
    /// int __thiscall IconData::UpdateIcons(IconData*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="weenObj">Object whose icon attributes are compared and used for updates.</param>
    /// <returns>Non‑zero if the icons were re-rendered; zero otherwise.</returns>
    public int UpdateIcons(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IconData, ACBindings.Internal.ACCWeenieObject*, int>)0x0058E800)(ref this, weenObj);
}

