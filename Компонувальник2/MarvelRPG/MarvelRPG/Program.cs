using DesignPatterns.Composite;

var hero = new MarvelHero("BlackWidow", 1);
var ring = new Artefact("PowerRing", 5, 50);
var necklace = new Artefact("PerlNecklace", 10, 100);

var friend = new CompositeArtifact("IronMan", 90, 7);

var glow = new Artefact("GlowOfPower", 11, 125);
var stones1 = new Artefact($"InfinityStone1", 2,  10);
var stones2 = new Artefact($"InfinityStone2", 8, 20);
var stones3 = new Artefact($"InfinityStone3", 10, 50);
friend.AddArtefact(stones1);
friend.AddArtefact(stones2);
friend.AddArtefact(stones3);


friend.AddArtefact(glow);


hero.AddArtefact(ring);
hero.AddArtefact(necklace);
hero.AddArtefact(friend);

hero.CountArtefacts();
hero.CalculateArtefactsWeight();
hero.Strike();

hero.RemoveArtefact(ring);
hero.CountArtefacts();
hero.CalculateArtefactsWeight();
hero.Strike();

