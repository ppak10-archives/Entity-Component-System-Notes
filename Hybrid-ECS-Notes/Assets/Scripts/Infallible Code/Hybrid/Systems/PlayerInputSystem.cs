// ----------------------------------------------------------------------------
// Original Creator: Infallible Code (Charles Amat)
// File Developer: Peter Pak
// Description: Script to define player movement systems
// ----------------------------------------------------------------------------

using Hybrid.Components;
using Unity.Entities;
using UnityEngine;

namespace Hybrid.Systems
{
    public class PlayerInputSystem : ComponentSystem
    {
        private struct Group
        {
            public PlayerInput PlayerInput;
        }

        protected override void OnUpdate()
        {
            foreach (var entity in GetEntities<Group>())
            {
                entity.PlayerInput.Horizontal = Input.GetAxis("Horizontal");
            }
        }
    }
}
