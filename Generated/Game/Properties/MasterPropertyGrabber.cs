namespace ACBindings.Internal;


/// <summary>Wraps a DBObjGrabber for MasterProperty objects, enabling efficient retrieval and manipulation of master property data within the system.</summary>
public unsafe struct MasterPropertyGrabber
{
    // Base Classes
    public ACBindings.Internal.DBObjGrabber___MasterProperty BaseClass_DBObjGrabber; // ACBindings.Internal.DBObjGrabber___MasterProperty

    // Statics
    public static ACBindings.Internal.DBObjGrabber___MasterProperty* s_spcMasterPropertyList = (ACBindings.Internal.DBObjGrabber___MasterProperty*)0x00837DB8;

    // Generated Constructor
    public MasterPropertyGrabber() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a MasterPropertyGrabber instance by linking it to the singleton master property list, loading the list when needed and managing reference counts appropriately.
    /// <code>Offset: 0x00425BA0
    /// void __thiscall MasterPropertyGrabber::MasterPropertyGrabber(MasterPropertyGrabber*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MasterPropertyGrabber, void>)0x00425BA0)(ref this);
}

