using UnityEngine;
using UnityEngine.UI;
public class GameManagerAndUI : MonoBehaviour
{
	[Header("UI Settings")]
	public bool showInteractText;
	public Text interactText;
	
	void Update()
	{
		interactText.text = showInteractText ? "Нажмите [F] для подробной информации" : "";
	}
}
