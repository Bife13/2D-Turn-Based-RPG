using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConditionIconUI : MonoBehaviour
{
	public Image iconImage;
	public TextMeshProUGUI durationText;
	private string iconName;

	private TooltipHandler tooltipHandler;

	public void Setup(Sprite icon, int duration, string newName)
	{
		tooltipHandler = gameObject.GetComponent<TooltipHandler>();
		iconImage.sprite = icon;
		iconName = newName;
		UpdateDuration(duration);
		tooltipHandler.SetToolTipString($"{iconName} for {duration} turns");
	}

	public void UpdateDuration(int duration)
	{
		durationText.text = duration.ToString();
	}
}