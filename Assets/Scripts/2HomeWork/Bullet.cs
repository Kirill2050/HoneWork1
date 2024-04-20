using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void OnEnable()
    {
        Destroy(gameObject, 3f);
    }
    private void Update()
    {
        transform.position += Vector3.forward * _speed * Time.deltaTime; 
    }
}
