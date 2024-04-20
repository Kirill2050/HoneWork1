using UnityEngine;

public class RedSphere : Sphere
{
    private void Awake()
    {
        SelfCollor = Color.Red;
    }
    public override void Destroy()
    {
        gameObject.SetActive(false);
        Debug.Log("”ничтожен крассный шар");
    }
}
