namespace ACBindings;

// CAMSchedule
public unsafe struct CAMSchedule
{
    // Child Types
    // CAMSchedule_vtbl
    public unsafe struct CAMSchedule_vtbl
    {
        // Members
        public System.IntPtr CAMSchedule_dtor_0; // function pointer

        // Methods
    }
    // CAMSchedule::CAdvisePacket
    public unsafe struct CAdvisePacket
    {
        // Members
        public ACBindings.CAMSchedule.CAdvisePacket* m_next;
        public uint m_dwAdviseCookie;
        public long m_rtEventTime;
        public long m_rtPeriod;
        public System.IntPtr m_hNotify;
        public int m_bPeriodic;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.CAMSchedule.CAdvisePacket head;
    public ACBindings.CAMSchedule.CAdvisePacket z;
    public uint m_dwNextCookie;
    public uint m_dwAdviseCount;
    public ACBindings.CCritSec m_Serialize;
    public System.IntPtr m_ev;
    public ACBindings.CAMSchedule.CAdvisePacket* m_pAdviseCache;
    public uint m_dwCacheCount;

    // Methods
}

