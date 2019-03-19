namespace ListBuilding
{
	public class AllegianceButtonEvent : Event
	{
		public readonly Constants.Allegiances allegiance;


		//constructor
		public AllegianceButtonEvent(Constants.Allegiances algnc)
		{
			allegiance = algnc;
		}

	}
}
