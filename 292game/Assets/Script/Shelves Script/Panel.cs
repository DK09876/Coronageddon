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
	[Serializable]
	public struct Item
	{
		public Sprite Icon;
	}

	public Sprite[] itemsSprites;
	private int index;
	// [SerializeField] Item[] allItems;

	void Start ()
	{
		GameObject buttonTemplate = transform.GetChild(0).gameObject;
		GameObject g;

		// int N = allItems.Length;

		for (int i = 0; i < 9; i++) {
			g = Instantiate (buttonTemplate, transform);
			index = Random.Range (0, itemsSprites.Length);
			g.transform.GetComponent<Image>().sprite = itemsSprites[index];
			g.GetComponent<Button>().AddEventListener(i, ItemClicked);
		}
		Destroy (buttonTemplate);
	}

	void ItemClicked (int itemIndex)
	{
		Debug.Log ("------------item " + itemIndex + " clicked---------------");
	}
}
