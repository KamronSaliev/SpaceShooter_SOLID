using UnityEngine;

public class UIManager : Observer
{
    [SerializeField] private GameObject _gameOverText;

    private void Start()
    {
        _gameOverText.SetActive(false);
    }

    private void ShowGameOver()
    {
        _gameOverText.SetActive(true);
    }

    public override void Notify()
    {
        ShowGameOver();
    }
}