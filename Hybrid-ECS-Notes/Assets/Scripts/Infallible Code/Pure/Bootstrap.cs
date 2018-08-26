// ----------------------------------------------------------------------------
// Original Creator: Infallible Code (Charles Amat)
// File Developer: Peter Pak
// Description: Script to manage components
// ----------------------------------------------------------------------------

using Pure.Components;
using Unity.Entities;
using Unity.Rendering;
using Unity.Transforms;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    public float Speed;
    public Mesh Mesh;
    public Material Material;

    private void Start()
    {
        var entityManager = World.Active.GetOrCreateManager<EntityManager>();

        var playerEntity = entityManager.CreateEntity(
            ComponentType.Create<Speed>(),
            ComponentType.Create<PlayerInput>(),
            ComponentType.Create<Position>(),
            // ComponentType.Create<TransformMatrix>(),
            ComponentType.Create<MeshInstanceRenderer>());


        entityManager
            .SetComponentData(playerEntity, new Speed { Value = Speed });
        entityManager.SetSharedComponentData( playerEntity, 
            new MeshInstanceRenderer { mesh = Mesh, material = Material });
    }
}