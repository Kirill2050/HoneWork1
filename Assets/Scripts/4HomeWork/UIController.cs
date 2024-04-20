using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject _startPanel;
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private GameObject _losePanel;

    public void SrartGame()
    {
        _startPanel.SetActive(false);
    }
    public void WinPanelActivate()
    {
        _winPanel.SetActive(true);

    }
    public void LosePanelActivate()
    {
        _losePanel.SetActive(true);
    }
    
    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }

}
