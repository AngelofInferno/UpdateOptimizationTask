using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class TankAIBenchmark : MonoBehaviour
{
    Transform[] tanks;
    public int numberOfTanks;
    public GameObject tankPrefab;

    private UpdateManager _updateManager;
    // Start is called before the first frame update
    void Start()
    {
        _updateManager = GetComponent<UpdateManager>();
        _updateManager.Init(numberOfTanks);
        tanks = new Transform[numberOfTanks];
        for (int i = 0; i < numberOfTanks; i++)
        {
            tanks[i] = Instantiate(tankPrefab,
                new Vector3(Random.Range(-50,50), 0, Random.Range(-50,50)), Quaternion.identity).transform;
            _updateManager.AddElement(tanks[i].gameObject.GetComponent<TankMoving>());
        }
    }
}
