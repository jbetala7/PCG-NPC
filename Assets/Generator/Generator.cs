using UnityEngine;
using UnityEngine.AI;

public class Generator : MonoBehaviour
{

	public int width = 20;
	public int height = 20;

	public GameObject wall;
	public GameObject player;

	public NavMeshSurface levels;

	private bool playerSpawned = false;

	// Use this for initialization
	void Start()
	{
		Generate();

		//Dynamic Navmesh

		levels.BuildNavMesh();
	}

	// Generate levels
	void Generate()
	{
		// Loop 
		for (int x = 0; x <= width; x += 2)
		{
			for (int y = 0; y <= height; y += 2)
			{
				// Randomly generale walls
				if (Random.value > .7f)
				{
					Vector3 pos = new Vector3(x - width / 2f, 0f, y - height / 2f);
					Instantiate(wall, pos, Quaternion.identity, transform);
				}
				else if (!playerSpawned)
				{
					// Spawn player
					Vector3 pos = new Vector3(x - width / 2f, 0f, y - height / 2f);
					Instantiate(player, pos, Quaternion.identity);
					playerSpawned = true;
				}
			}
		}
	}

}
