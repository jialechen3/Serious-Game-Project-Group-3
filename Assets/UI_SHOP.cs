using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_SHOP : MonoBehaviour
{
    private Transform container;
    private Transform shopItemTemplate;


    private void Awake() {
        container = transform.Find("Container");
        shopItemTemplate = container.Find("shopItemTemplate");
        shopItemTemplate.gameObject.SetActive(false);
    }

    private void Start() {
        CreateItemButton("One Room", "$800", 1);
    }
    private void CreateItemButton(string itemName, string itemCost, int positionIdex) {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 30f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIdex);

        shopItemTransform.Find("itemName").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("costText").GetComponent<TextMeshProUGUI>().SetText(itemCost);

    }
}
