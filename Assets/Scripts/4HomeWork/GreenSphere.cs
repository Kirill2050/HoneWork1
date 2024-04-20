using UnityEngine;

public class GreenSphere : Sphere
{

    private void Awake()
    {
        SelfCollor = Color.Green;
    }

    public override void Destroy()
    {
        gameObject.SetActive(false);
        Debug.Log("”ничтожен зеленый шар");

    }

}
