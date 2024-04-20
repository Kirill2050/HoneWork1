using UnityEngine;

public class Shotgun : IWeapon
{

    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform[] _shootPoints;
    [SerializeField, Range(0, 60)] private int _magazine;



    public override void Shoot()
    {
        foreach (Transform point in _shootPoints)
        {
            if (_magazine <= 0)
                break;

            Instantiate(_bulletPrefab, point.position, Quaternion.identity);
            _magazine--;
            
        }
        Debug.Log("Осталось " + _magazine + " Патронов");
    }
}
