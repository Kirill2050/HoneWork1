using System.Collections.Generic;
using UnityEngine;




public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Sphere[] _spawnObjects;

    private List<Sphere> _objectPool = new List<Sphere>();

    public List<Sphere> ObjectPool => _objectPool;
   public void SpawnObjects()
    {
        foreach (Transform pos in _spawnPoints)
        {
            int index = Random.Range(0, _spawnObjects.Length);
            Sphere newObject = Instantiate(_spawnObjects[index],pos.position, Quaternion.identity);
            _objectPool.Add(newObject);
        }
    }
  
}
