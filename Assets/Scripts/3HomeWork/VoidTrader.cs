using UnityEngine;

public class VoidTrader :  TraderState
{

 
    public VoidTrader(Material material, GameObject sign)
    {
        _material = material;
        _sign = sign;
    }

    public override void Parting()
    {
        Debug.Log("� �� �����������...");
    }

    public override void Trade()
    {
            Debug.Log("� ���� �����... ��� ����� ��� ��");  
    }
}
