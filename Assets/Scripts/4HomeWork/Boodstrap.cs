using System.Collections.Generic;
using UnityEngine;

public class Boodstrap : MonoBehaviour
{
    [SerializeField]private Camera _camera;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private UIController _controller;

    private List<Sphere> _spheres = new List<Sphere>();
    private WinCondition _winCondition;

   

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.GetComponent<Sphere>())
                {
                    Sphere currentSphere = hit.collider.gameObject.GetComponent<Sphere>();
                    currentSphere.Destroy();
                    _winCondition?.CheekWinCondition(currentSphere.Collor);
                }
            }
        }
    }



    public void SetWinWhenAllDestroy()
    {
        _spawner.SpawnObjects();
        _spheres = _spawner.ObjectPool;
        _winCondition = new WinerAllDestroy(_spheres, _controller);
    }

    public void SetWinWhenDestroyRedSphere()
    {
        _spawner.SpawnObjects();
        _spheres = _spawner.ObjectPool;
        _winCondition = new WinnerOneCollorDestroy(_spheres, Color.Red, _controller);
    }

    public void SetWinWhenDestroyWhiteSphere()
    {
        _spawner.SpawnObjects();
        _spheres = _spawner.ObjectPool;
        _winCondition = new WinnerOneCollorDestroy(_spheres, Color.White, _controller);
    }

    public void SetWinWhenDestroyGreenSphere()
    {
        _spawner.SpawnObjects();
        _spheres = _spawner.ObjectPool;
        _winCondition = new WinnerOneCollorDestroy(_spheres, Color.Green, _controller);
    }

}
