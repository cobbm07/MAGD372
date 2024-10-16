using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI typeText;

    public Image artworkImage;
    public Image cardSprite;

    public TextMeshProUGUI manaText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI defenseText;
    
    void Awake() {
        cardSprite = gameObject.GetComponent<Image>();
    }
    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;
        typeText.text = card.type;

        artworkImage.sprite = card.artwork;
        cardSprite.sprite = card.cardColorSprite;

        manaText.text = card.manaCost.ToString();
        attackText.text = card.attack.ToString();
        defenseText.text = card.defense.ToString();
    }
}
