using UnityEngine;
public abstract class WinCondition 
{
    public abstract void CheekWinCondition(Color color);
    public void Loser(UIController controller)
    {
        Debug.Log("�� ��������");
        controller.LosePanelActivate();

    }
    public void Winner(UIController controller)
    {
        Debug.Log("�� �������");
        controller.WinPanelActivate();

    }
   
}
