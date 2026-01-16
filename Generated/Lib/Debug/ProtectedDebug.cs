namespace ACBindings.Internal;


/// <summary>Encapsulates Turbine::Debug functionality within a protected context, facilitating safe exception handling and debug flag management for the application.</summary>
public unsafe struct ProtectedDebug
{
    // Base Classes
    public ACBindings.Internal.Turbine.Debug BaseClass_Turbine_Debug; // ACBindings.Internal.Turbine.Debug

    // Child Types
    public unsafe struct ProtectedDebug_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProtectedDebug*, byte> InitDebug; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Handles an exception filter thread by signaling completion and reporting the exception via Turbine::Debug.
    /// <code>Offset: 0x00405FF0
    /// unsigned int __stdcall ProtectedDebug::ExceptionFilterThread(void*)</code>
    /// </summary>
    /// <param name="lpParam">Pointer to a block containing the event handle to signal, a pointer to exception information, and a location for storing the report result.</param>
    /// <returns>Zero indicating successful execution of the thread routine.</returns>
    public static uint ExceptionFilterThread(System.IntPtr lpParam) => ((delegate* unmanaged[Stdcall]<System.IntPtr, uint>)0x00405FF0)(lpParam);
}

