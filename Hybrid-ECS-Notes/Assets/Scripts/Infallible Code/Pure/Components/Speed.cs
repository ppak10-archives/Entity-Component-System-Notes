// ----------------------------------------------------------------------------
// Original Creator: Infallible Code (Charles Amat)
// File Developer: Peter Pak
// Description: Script to define player movement speed
// ----------------------------------------------------------------------------

using Unity.Entities;

namespace Pure.Components
{
    public struct Speed : IComponentData
    {
        public float Value;
    }
}