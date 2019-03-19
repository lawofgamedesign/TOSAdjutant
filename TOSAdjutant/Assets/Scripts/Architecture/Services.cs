using UnityEngine;

public static class Services {

	private static EventManager events;
	public static EventManager Events
	{
		get
		{
			Debug.Assert(events != null, "No event manager. Are services being created out of order?");
			return events;
		}
		set { events = value; }
	}
}
