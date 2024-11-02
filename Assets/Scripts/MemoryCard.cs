using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] SceneController controller;
    public int Id { get; private set; }
    public void SetCard(int id, Sprite image)
    {
        Id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }
    // Update is called once per frame
    void Update()
    {

    }
    [SerializeField] GameObject cardBack;
    public void OnMouseDown()
    {
        if (cardBack.activeSelf && controller.canReveal)
        {
            cardBack.SetActive(false);
            controller.CardRevealed(this);
        }
    }
    public void Unreveal()
    {
        cardBack.SetActive(true);
    }
}
