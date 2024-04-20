using UnityEngine;

public class Pistol : IWeapon
{

    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _shootPoint;
    [SerializeField, Range(0, 20)] private int _magazine;


  
    public override void Shoot()
    {
        if (_magazine <= 0)
            return;

        Instantiate(_bulletPrefab, _shootPoint.position, Quaternion.identity);
        _magazine--;
        Debug.Log("Осталось " + _magazine + " Патронов");
    }
}
