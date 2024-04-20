using UnityEngine;

public class ArmorTrader :  TraderState
{


    public ArmorTrader(Material material, GameObject sign)
    {
        _material = material;
        _sign = sign;
    }
    public override void Parting()
    {
        Debug.Log("Очень жаль что вы уходите так рано. Я буду вас ждать.");
    }
    public override void Trade()
    {
        Debug.Log("Для таких господ у меня есть первокласная броня.");
    }
}
