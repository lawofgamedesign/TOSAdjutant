namespace ListBuilding
{
	using System.Collections.Generic;
	using UnityEngine;


	/// <summary>
	/// This class controls the list creation process. It has the only Unity built-in Start and Update functions;
	/// everything else that needs Unity's built-in functions is run through this class.
	/// </summary>


	public class ListCreationManager : MonoBehaviour
	{
		
		
		private List<AllegianceButtonBehavior> allegianceButtons = new List<AllegianceButtonBehavior>();


		/// <summary>
		/// This is the only Start function in the list creation process. 
		/// </summary>
		private void Start() {
			Services.Events = new EventManager();
			allegianceButtons = GetAllegianceButtons();
		}


		private List<AllegianceButtonBehavior> GetAllegianceButtons(){
			GameObject[] tempArray = GameObject.FindGameObjectsWithTag("Allegiance button");
			
			Debug.Assert(tempArray.Length != 0, "Did not find any allegiance buttons.");

			List<AllegianceButtonBehavior> tempList = new List<AllegianceButtonBehavior>();

			foreach (GameObject button in tempArray) {
				tempList.Add(button.GetComponent<AllegianceButtonBehavior>());
			}
			
			Debug.Assert(tempArray.Length == tempList.Count, "Did not copy allegiance buttons correctly.");

			return tempList;
		}
	}
}
