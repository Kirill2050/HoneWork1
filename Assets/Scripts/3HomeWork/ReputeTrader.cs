using UnityEngine;

public class ReputeTrader : MonoBehaviour
{
    private TraderState _traderState;
    public void Trade(TraderState trader)
    {
        trader?.Parting();
        _traderState = trader;
        trader.Trade();
        trader.SetSign();
    }
}
