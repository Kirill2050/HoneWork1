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
        Debug.Log("����� ���� ��� �� ������� ��� ����. � ���� ��� �����.");
    }
    public override void Trade()
    {
        Debug.Log("��� ����� ������ � ���� ���� ������������ �����.");
    }
}
