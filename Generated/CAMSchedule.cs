namespace ACBindings.Internal;

public unsafe struct CAMSchedule
{
    // Child Types
    public unsafe struct CAMSchedule_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAMSchedule*, void> CAMSchedule_dtor_0; // function pointer

        // Methods
    }
    public unsafe struct CAdvisePacket
    {
        // Members
        public ACBindings.Internal.CAMSchedule.CAdvisePacket* m_next;
        public uint m_dwAdviseCookie;
        public long m_rtEventTime;
        public long m_rtPeriod;
        public System.IntPtr m_hNotify;
        public int m_bPeriodic;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.CAMSchedule.CAdvisePacket head;
    public ACBindings.Internal.CAMSchedule.CAdvisePacket z;
    public uint m_dwNextCookie;
    public uint m_dwAdviseCount;
    public ACBindings.Internal.CCritSec m_Serialize;
    public System.IntPtr m_ev;
    public ACBindings.Internal.CAMSchedule.CAdvisePacket* m_pAdviseCache;
    public uint m_dwCacheCount;

    // Methods
}

