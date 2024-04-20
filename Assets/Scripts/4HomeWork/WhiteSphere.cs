using UnityEngine;

public class WhiteSphere : Sphere
{
    private void Awake()
    {
        SelfCollor = Color.White;
    }
    public override void Destroy()
    {
        gameObject.SetActive(false);
        Debug.Log("”ничтожен белый шар");
    }
}
