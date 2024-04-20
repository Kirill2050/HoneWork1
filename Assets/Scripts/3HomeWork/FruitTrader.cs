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
        Debug.Log("������� �� ���������� �������, ��� ������ ����� ������.");
    }
    public override void Trade()
    {
        Debug.Log("�� ������� ������� ���������, �����?");
    }
}