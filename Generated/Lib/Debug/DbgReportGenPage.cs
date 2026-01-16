namespace ACBindings.Internal;


/// <summary>Provides an interface for generating individual pages of debugging reports, exposing virtual functions through its vtable.</summary>
public unsafe struct DbgReportGenPage
{
    // Child Types
    public unsafe struct DbgReportGenPage_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DbgReportGenPage*, void> DbgReportGenPage_dtor_0; // function pointer
        public System.IntPtr GenReport;
        public System.IntPtr GetReportName;
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DbgReportGenPage*, ACBindings.Internal.DbgReportContext*, byte> ShouldReport; // function pointer

        // Methods
    }
    // DbgReportGenPage::FunctionSignatureHasChanged
    public enum FunctionSignatureHasChanged : uint
    {
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

