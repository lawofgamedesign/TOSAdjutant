namespace ListBuilding
{
	using UnityEngine;
	using UnityEngine.UI;

	public class AllegianceButtonBehavior : MonoBehaviour
	{
		
		//////////////////////////////////////////////////////
		/// Fields
		//////////////////////////////////////////////////////
		
		//the allegiance this button represents
		[SerializeField] private Constants.Allegiances allegiance;
		
		//the color this button turns when pressed
		[SerializeField] private Color pressedColor;
		
		//the color this button is when not selected
		private readonly Color unselectedColor = Color.white;

		
		//////////////////////////////////////////////////////
		/// Fields
		//////////////////////////////////////////////////////
		
		
		public void ButtonPressed() {
			Services.Events.Fire(new AllegianceButtonEvent(allegiance));
		}


		public void Selected() {
			GetComponent<Image>().color = pressedColor;
		}


		public void Unselected() {
			GetComponent<Image>().color = unselectedColor;
		}
	}
}
