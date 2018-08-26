// ----------------------------------------------------------------------------
// Original Creator: Brackey's guy (Asbjørn)
// File Developer: Peter Pak
// Description: Script to rotate cube with hybrid ECS
// ----------------------------------------------------------------------------

using UnityEngine;
using Unity.Entities;

/// <summary>
/// MonoBehaviour class used to store DATA
/// </summary>
public class Rotator : MonoBehaviour {
	public float speed; // float to store rotation speed data	
}


/// <summary>
/// ComponentSystem class used to implement BEHAVIOR which undergoes logic
/// </summary>
class RotatorSystem : ComponentSystem
{
	/// <summary>
	/// Struct components to search entities which contain both rotator and transform components
	/// </summary>
	struct Components
	{
		public Rotator rotator;
		public Transform transform;
	}

	/// <summary>
	/// protected override void which performs updates to entities
	/// </summary>
	protected override void OnUpdate()
	{
		// search through entities with given component structure
		foreach (var e in GetEntities<Components>())
		{
			// rotate cube according to entity's rotator speed
			e.transform.Rotate(0f, e.rotator.speed * Time.deltaTime, 0f);
		}
	}
}
