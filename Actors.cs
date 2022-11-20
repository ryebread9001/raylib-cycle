class Actors {

    public List<Cycle> players = new List<Cycle>();
    public Actors() {}

    public void UpdateActors() {
        foreach (Cycle bike in players) {
            bike.UpdatePos();
            bike.DrawSegments();
        }
    }

    public void AddActor(Cycle bike) {
        players.Add(bike);
    }
}