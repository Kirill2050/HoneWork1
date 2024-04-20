using UnityEngine;

public class ExempleReputeTrader : MonoBehaviour
{

    [SerializeField] private Player _player;
    [SerializeField] private ReputeTrader _reputeTrader;

    [SerializeField] private GameObject _sign;

    [SerializeField] private Material _angreeMaterial;
    [SerializeField] private Material _fruitMaterial;
    [SerializeField] private Material _armorMaterial;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player.gameObject)
        {
            _player = other.gameObject.GetComponent<Player>();

            if (_player.ReputePlayer < 5)
                _reputeTrader.Trade(new VoidTrader(_angreeMaterial, _sign));

            if (_player.ReputePlayer >= 5 && _player.ReputePlayer < 10)
                _reputeTrader.Trade(new FruitTrader(_fruitMaterial, _sign));

            if (_player.ReputePlayer >= 10)
                _reputeTrader.Trade(new ArmorTrader(_armorMaterial, _sign));

            Debug.Log(_player.ReputePlayer);
        }
    }
}
