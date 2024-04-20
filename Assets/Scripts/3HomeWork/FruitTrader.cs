using UnityEngine;

public class FruitTrader : TraderState
{

    public FruitTrader(Material material, GameObject sign)
    {
        _material = material;
        _sign = sign;
    }


    public override void Parting()
    {
        Debug.Log("Ќадеюсь вы расскажите друзь€м, про лучшую лавку города.");
    }
    public override void Trade()
    {
        Debug.Log("Ќе жалаете немного фруктиков, —ЁЁЁр?");
    }
}