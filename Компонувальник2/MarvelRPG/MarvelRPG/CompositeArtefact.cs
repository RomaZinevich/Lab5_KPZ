namespace DesignPatterns.Composite
{
    class CompositeArtifact : Artefact
    {
        private List<Artefact> _nestedArtefacts = new List<Artefact>();
        public CompositeArtifact(string name, int weight, int powerBuf) : base(name, weight, powerBuf)
        {
        }

        public override int GetPowerBuf()
        {
            return this._nestedArtefacts.Aggregate(this._powerBuf, (sum, next) => sum += next.GetPowerBuf());
        }

        public override int GetWeight()
        {
            return this._nestedArtefacts.Aggregate(this._weight, (sum, next) => sum += next.GetWeight());
        }

        public void AddArtefact(Artefact artefact)
        {
            this._nestedArtefacts.Add(artefact);
        }

        public void RemoveArtefact(Artefact artefact)
        {
            this._nestedArtefacts.Remove(artefact);
        }

        public override int GetCount()
        {
            return this._nestedArtefacts.Aggregate(1, (sum, next) => sum += next.GetCount());
        }
    }
}

// Possible solutions with Count problem:
// - IsCountable flag
// - Two different classes: ArtefactContainer, CompositeArtefact