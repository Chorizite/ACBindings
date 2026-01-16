namespace ACBindings.Internal;


/// <summary>
/// Identifies a specific iteration within a data file, combining the file's unique 64‑bit identifier and the iteration sequence number.<br/>
/// Used to reference or retrieve iteration data across multiple files in the application.
/// </summary>
public unsafe struct QualifiedIteration
{
    // Members
    public ulong idDatFile;
    public int idIteration;

    // Methods
}

