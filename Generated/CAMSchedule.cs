namespace ACBindings.Internal;


/// <summary>
/// Coordinates queued advisory packets, ensuring thread‑safe access and efficient event notification.
/// </summary>
/// <remarks>
/// Maintains a cache of advise packets, tracks next cookie values, and uses a critical section to serialize operations. An event handle signals when new packets are available.
/// </remarks>
public unsafe struct CAMSchedule
{
    // Child Types
    public unsafe struct CAMSchedule_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAMSchedule*, void> CAMSchedule_dtor_0; // function pointer

        // Methods
    }

    /// <summary>Represents a scheduled event packet that links to the next packet in a list, identifies the callback with an advise cookie, stores event time and period for periodic notifications, holds a notification handle, and flags whether it is periodic.</summary>
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

