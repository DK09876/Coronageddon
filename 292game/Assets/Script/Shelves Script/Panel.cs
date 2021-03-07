using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using Random=UnityEngine.Random;
using Object=UnityEngine.Object;

public static class ButtonExtension
{
	public static void AddEventListener<T> (this Button button, T param, Action<T> OnClick)
	{
		button.onClick.AddListener (delegate() {
			OnClick (param);
		});
	}
}

public class Panel : MonoBehaviour
{
	public Sprite[] itemsSprites;
	private int index;
	// private int bagIndex;
	// public static string itemNameBag;
	// [SerializeField] Item[] allItems;

	void Start ()
	{
		GameObject buttonTemplate = transform.GetChild(0).gameObject;
		GameObject g;
		// bagIndex = Random.Range(0,8);

		for (int i = 0; i < 9; i++) {
			g = Instantiate (buttonTemplate, transform);
			index = Random.Range (0, itemsSprites.Length);
			g.transform.GetComponent<Image>().sprite = itemsSprites[index];
			g.GetComponent<Button>().AddEventListener(i, ItemClicked);
			// if (i == bagIndex) {
			// 	itemNameBag = itemsSprites[index].name;
			// }
		}
		Destroy (buttonTemplate);
	}

	public void ItemClicked (int itemIndex)
	{
		// Debug.Log ("------------item " + itemIndex + " clicked---------------");
		// Debug.Log(transform.GetChild(itemIndex).GetComponent<Image>().sprite.name);
		// Debug.Log(itemNameBag);
	}
}
