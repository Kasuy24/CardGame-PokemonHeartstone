using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectionManager : MonoBehaviour {

    public GameManager instance;

    public GameObject cardPrefab;

    //public Card[] cards;
    //public Vector3[] spawnPoints;

    private int cardDisplayPosition = 0;

    private void Awake()
    {
        instance = FindObjectOfType<GameManager>();

        instance.cards.Sort(); //Ordena les cartes alfabeticament en funcio del que li hem dit a card.cs
    }

    private void Start()
    {
        int CurrentSpawn = 0;
        float xPos = 0f;
        float yPos = 2f;
        float xAmount = 3f;

        for (int i = 0; i < 11; i++)
        {
            foreach(Card card in instance.cards)
            {
                if (card.manaCost == i){
                    switch (cardDisplayPosition)
                    {
                        case 0:
                            xPos = -4.5f;
                            break;
                        case 1:
                            xPos = xPos + xAmount;
                            break;
                        case 2:
                            xPos = xPos + xAmount;
                            break;
                        case 3:
                            xPos = xPos + xAmount;
                            break;

                        default:
                            break;
                    }

                    cardDisplayPosition++;

                    if( cardDisplayPosition > 3)
                    {
                        cardDisplayPosition = 0;
                    }

                    GameObject go = Instantiate(cardPrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
                    CardDisplay display = go.GetComponent<CardDisplay>();
                    display.CardSetup(card);

                    CurrentSpawn++;

                    if (CurrentSpawn > 3)
                    {
                        yPos -= 4f;
                        CurrentSpawn = 0;
                    }
                }
            }
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
