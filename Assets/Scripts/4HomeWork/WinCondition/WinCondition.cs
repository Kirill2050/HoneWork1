using UnityEngine;
public abstract class WinCondition 
{
    public abstract void CheekWinCondition(Color color);
    public void Loser(UIController controller)
    {
        Debug.Log("Ты проиграл");
        controller.LosePanelActivate();

    }
    public void Winner(UIController controller)
    {
        Debug.Log("Ты выйграл");
        controller.WinPanelActivate();

    }
   
}
