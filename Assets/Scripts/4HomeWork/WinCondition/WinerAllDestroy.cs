using System.Collections.Generic;

public class WinerAllDestroy : WinCondition
{
    private List<Sphere> _allSphere = new List<Sphere>();

    private int _destroerSphere;

    UIController _controller;
    public WinerAllDestroy(List<Sphere> allSphere, UIController controller)
    {
        _allSphere = allSphere;
        _controller = controller;
    }

    public override void CheekWinCondition(Color color)
    {
        _destroerSphere = 0;
        foreach (Sphere sphere in _allSphere)
        {
            if (sphere.gameObject.activeSelf == false)
                _destroerSphere++;
        }
        if (_destroerSphere == _allSphere.Count)
            Winner(_controller);
    }
}
