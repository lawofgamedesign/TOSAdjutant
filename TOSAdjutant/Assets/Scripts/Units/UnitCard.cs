public abstract class UnitCard {

	public int PointValue { get; private set; }
	public int Tactics { get; private set; }

	public void SetValues(int pv = 999, int tac = 0){
		PointValue = pv;
		Tactics = tac;
	}
}
