using UnityEngine;
using UnityEngine.UI;
public class GameManagerAndUI : MonoBehaviour
{
	[SerializeField] private Text interactText;
	[Header("Panel")]
	[SerializeField] private GameObject infoPanel;
	[SerializeField] private Text textInfoPanel;
	public void Message(bool showInteractText)
	{
		interactText.text = showInteractText ? "Нажмите [F] для подробной информации" : "";
	}
	public void InfoPanelSwitch(bool state,string info)
	{
		infoPanel.gameObject.SetActive(state);
		textInfoPanel.text = info;
	}
}
