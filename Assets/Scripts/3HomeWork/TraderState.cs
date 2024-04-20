using UnityEngine;

public abstract class TraderState : MonoBehaviour
{
    protected Material _material;
    protected GameObject _sign;
    public abstract void Trade();
    public abstract void Parting();

    public void SetSign()
    {
        _sign.GetComponent<Renderer>().sharedMaterial = _material;
    }
    

}
