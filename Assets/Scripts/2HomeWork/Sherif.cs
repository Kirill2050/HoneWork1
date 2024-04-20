using UnityEngine;

public class Sherif : MonoBehaviour
{
    private IWeapon _currentWeapon;
   
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        } 
    }
    public void SetCurrentWeapon(IWeapon weapon) => _currentWeapon = weapon;


    public void Shoot()
    {
        _currentWeapon?.Shoot();
    }
}
