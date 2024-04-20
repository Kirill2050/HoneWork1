using UnityEngine;

public class AK47 :  IWeapon
{

    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _shootPoint;

  

    public override void Shoot()
    {
        Instantiate(_bulletPrefab, _shootPoint.position, Quaternion.identity);
    }
}
