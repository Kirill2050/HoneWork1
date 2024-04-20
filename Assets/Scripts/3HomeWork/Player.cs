using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField, Range(0, 10)] private int _reputePlayer;

    
    public int ReputePlayer => _reputePlayer;


  
    public void ChangeRep(int rep)
    {
        
        _reputePlayer += rep;

        if(_reputePlayer > 10)
            _reputePlayer = 10;

        if(_reputePlayer < 0)
            _reputePlayer = 0;
    }


}
