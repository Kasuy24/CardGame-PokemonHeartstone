using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    [HideInInspector]

    public Card card;

    public Text descriptionText;
    public Text manaCostText;
    public Text attackValueText;
    public Text healtValueText;
    public Text nameText;

    public Image cardImage;
    public Image attackImage;
    public Image healthImage;

    public void CardSetup(Card thisCard)
    {
        card = thisCard;
        nameText.text = card.cardName;
        descriptionText.text = card.description;

        manaCostText.text = card.manaCost.ToString();

        if (card.isCreautre)
        {
            attackValueText.text = card.attack.ToString();
            healtValueText.text = card.health.ToString();
        }
        else
        {
            attackImage.gameObject.SetActive(false);
            healthImage.gameObject.SetActive(false);
            
        }
        cardImage.sprite = card.art;
    }
}
