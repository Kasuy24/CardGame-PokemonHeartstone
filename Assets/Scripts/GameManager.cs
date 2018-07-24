using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameManager instance;

    public List<Card> cards = new List<Card>();

    private void Awake()
    {//Funció per assegurar que només tenim un game manager actiu a la vegada
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
        //No destrueixis el Game Manager si creem una nova escena
    }

    public void LoadCollectionScene()
    {
        SceneManager.LoadScene("CollectionManager");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }
}
