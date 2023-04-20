namespace DesignPatterns.Composite
{
   class MarvelHero
   {
        private CompositeArtifact _artefacts = new CompositeArtifact("Hero's container", 0, 0);
        public string Name { get; private set; }

        private int _power;

        public MarvelHero(string name, int power)
        {
            this.Name = name;
            this._power = power;
        }

        public void AddArtefact(Artefact artefact)
        {
            this._artefacts.AddArtefact(artefact);
            Console.WriteLine($"Added artifact {artefact.Name}");
        }

        public void RemoveArtefact(Artefact artefact)
        {
            this._artefacts.RemoveArtefact(artefact);
            Console.WriteLine($"Removed artifact {artefact.Name}");
        }

        public void Strike()
        {
            int totalPower = this._power + this._artefacts.GetPowerBuf();
            Console.WriteLine($"{this.Name} hits with power {totalPower}");
        }

        public void CalculateArtefactsWeight()
        {
            int totalArtefactsWeight = this._artefacts.GetPowerBuf();
            Console.WriteLine($"Total artefacts weight: {totalArtefactsWeight}");
        }

        public void CountArtefacts()
        {
            int totalArtefactCount = this._artefacts.GetCount();
            Console.WriteLine($"{this.Name} has {totalArtefactCount} artefacts");
        }
    }
}
