namespace ACBindings.Internal;


/// <summary>Defines a UI window used by the profiler engine, storing the native window handle, auto-positioning flag, category type, and related quick window reference.</summary>
public unsafe struct ProfilerUIWindow
{
    // Members
    public uint m_WindowHandle;
    public byte m_AutoPositionWindow;
    public ACBindings.Internal.ProfilerTypes.CategoryType m_Category;
    public ACBindings.Internal.QuickWindow* m_pQuickWindow;

    // Methods
}

