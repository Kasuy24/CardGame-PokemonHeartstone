using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroDisplay: MonoBehaviour {

    public Text heroName;

    public Text healthText;
    public Text armorText;
    public Text attackText;

    public Image heroAvatar;

    private Hero myHero;


    public void HeroSetup(Hero thisHero)
    {
        myHero = thisHero;
        heroName.text = myHero.heroName;
        healthText.text = myHero.health.ToString();
        armorText.text = myHero.armor.ToString();
        attackText.text = myHero.attack.ToString();

        heroAvatar.sprite = myHero.avatar;
    }

}
