using System.Collections.Generic;
using UnityEngine;

public class ChangerWeapon : MonoBehaviour
{
    [SerializeField] private Sherif _sherif;

    [SerializeField] private List<IWeapon> _weaponsArray = new List<IWeapon>();

    private void Awake()
    {
        _sherif.SetCurrentWeapon(_weaponsArray[0]);
        SwapWeapon(_weaponsArray[0]);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _sherif.SetCurrentWeapon(_weaponsArray[0]);
            SwapWeapon(_weaponsArray[0]);
            Debug.Log("Мы нажали q");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _sherif.SetCurrentWeapon(_weaponsArray[1]);
            SwapWeapon(_weaponsArray[1]);
            Debug.Log("Мы нажали W");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            _sherif.SetCurrentWeapon(_weaponsArray[2]);
            SwapWeapon(_weaponsArray[2]);
            Debug.Log("Мы нажали E");
        }
    }

    public void SwapWeapon(IWeapon currentWeapon)
    {
        foreach (var weapon in _weaponsArray)
        {
            if (weapon == currentWeapon)
                weapon.gameObject.SetActive(true);
            else
            weapon.gameObject.SetActive(false);
        }
    }
}
