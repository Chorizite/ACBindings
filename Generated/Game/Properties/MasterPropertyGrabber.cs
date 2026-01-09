namespace ACBindings;

// MasterPropertyGrabber
public unsafe struct MasterPropertyGrabber
{
    // Base Classes
    public ACBindings.DBObjGrabber__MasterProperty BaseClass_DBObjGrabber; // ACBindings.DBObjGrabber__MasterProperty

    // Statics
    public static ACBindings.DBObjGrabber__MasterProperty* s_spcMasterPropertyList = (ACBindings.DBObjGrabber__MasterProperty*)0x00837DB8;

    // Generated Constructor
    public MasterPropertyGrabber() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall MasterPropertyGrabber::MasterPropertyGrabber(MasterPropertyGrabber*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MasterPropertyGrabber, void>)0x00425BA0)(ref this);
}

