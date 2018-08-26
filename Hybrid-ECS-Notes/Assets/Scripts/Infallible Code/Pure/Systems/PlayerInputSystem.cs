// ----------------------------------------------------------------------------
// Original Creator: Infallible Code (Charles Amat)
// File Developer: Peter Pak
// Description: Script to define player input systems
// ----------------------------------------------------------------------------

using UnityEngine;
using Pure.Components;
using Unity.Entities;
using Unity.Jobs;

namespace Pure.Systems
{
    public class PlayerInputSystem : JobComponentSystem
    {
        private struct PlayerInputJob : IJobProcessComponentData<PlayerInput>
        {
            public float Horizontal;

            public void Execute (ref PlayerInput input)
            {
                input.Horizontal = Horizontal;
            }
        }

        protected override JobHandle OnUpdate(JobHandle inputDeps)
        {
            var job = new PlayerInputJob
            {
                Horizontal = Input.GetAxis("Horizontal")
            };

            return job.Schedule(this, 64, inputDeps);
        }
    }
}