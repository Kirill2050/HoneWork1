using UnityEngine;

public enum Color
{
    White, Green, Red
}

public abstract class Sphere : MonoBehaviour
{
   
    protected Color SelfCollor;
    public Color Collor => SelfCollor;
    public abstract void Destroy();

   

}
