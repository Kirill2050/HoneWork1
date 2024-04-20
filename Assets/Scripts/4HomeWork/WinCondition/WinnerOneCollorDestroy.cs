using System.Collections.Generic;
using UnityEngine;


public class WinnerOneCollorDestroy :  WinCondition
{
    private List<Sphere> _sphere = new List<Sphere>();

    private int _destroerSphere;

    private Color _needsCollor;

    private int _remainingBalls;

    private UIController _controller;

    public WinnerOneCollorDestroy(List<Sphere> sphere, Color color, UIController controller)
    {
        _sphere = sphere;
        _needsCollor = color;
        _controller = controller;
    }

    public override void CheekWinCondition(Color color)
    {
        _remainingBalls = 0;

        if(_needsCollor != color)
        {
            Loser(_controller);
        }
           


        foreach (Sphere sphere in _sphere)
        {
            if (sphere.gameObject.activeSelf == true && sphere.Collor == _needsCollor)
            {
                _remainingBalls++;
                Debug.Log("еще есть нужный шар. Осталось: " + _remainingBalls);
            }
        }
        if (_remainingBalls == 0)
        {
            Winner(_controller);
        }

    }

}
