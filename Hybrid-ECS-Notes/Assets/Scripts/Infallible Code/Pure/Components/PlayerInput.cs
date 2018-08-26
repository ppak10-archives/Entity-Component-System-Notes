// ----------------------------------------------------------------------------
// Original Creator: Infallible Code (Charles Amat)
// File Developer: Peter Pak
// Description: Script to define player input
// ----------------------------------------------------------------------------

using Unity.Entities;

namespace Pure.Components
{
    public struct PlayerInput : IComponentData
    {
        public float Horizontal;
    }
}