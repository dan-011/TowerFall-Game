using System.Collections.Generic;

public enum Direction {
    NORTH,
    SOUTH,
    EAST,
    WEST,
}

public enum Material {
    CLOUD,
    GLASS,
    FRAGILE,
    CURSED,
    LEAD,
    ICE,
}

public class MaterialFactory {
    MaterialFactory() {
        factories = new Dictionary<Material, VoidMethod>();
        factories.Add(Material.CLOUD, CloudFactory);
        factories.Add(Material.GLASS, GlassFactory);
        factories.Add(Material.FRAGILE, FragileFactory);
        factories.Add(Material.CURSED, CursedFactory);
        factories.Add(Material.LEAD, LeadFactory);
        factories.Add(Material.ICE, IceFactory);
    }
    public static MaterialFactory Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new MaterialFactory();
                }
                return instance;
            }
        }
    }
    public AbstractMaterial GetMaterial(Material material) { return factories[material](); }
    private Cloud CloudFactory() { return new Cloud(); }
    private Glass GlassFactory() { return new Glass(); }
    private Fragile FragileFactory() { return new Fragile(); }
    private Cursed CursedFactory() { return new Cursed(); }
    private Lead LeadFactory() { return new Lead(); }
    private Ice IceFactory() { return new Ice(); }
    private delegate AbstractMaterial VoidMethod();
	private Dictionary<Material, VoidMethod> factories;
    private static MaterialFactory instance = null;
    private static readonly object padlock = new object();
    
}

public abstract class AbstractMaterial {
    public abstract float GetMass();
    public abstract float GetWeight();
    public abstract float GetGravityScale();
    public abstract float GetFriction();
    public abstract int GetFrameIndex();

    // need to make an evaluate direction class somewhere
    public abstract void Interact(Direction dir, Cloud other);
    public abstract void Interact(Direction dir, Glass other);
    public abstract void Interact(Direction dir, Fragile other);
    public abstract void Interact(Direction dir, Cursed other);
    public abstract void Interact(Direction dir, Lead other);
    public abstract void Interact(Direction dir, Ice other);
    
}

public class Cloud : AbstractMaterial {
    public Cloud() {}

    public override float GetMass() {
        return 1f;
    }

    public override float GetWeight()
    {
        return 9.8f;
    }

    public override float GetGravityScale()
    {
        return 1f;
    }
    public override float GetFriction() {
        return 1f;
    }
    public override int GetFrameIndex() {
        return 5;
    }
    public override void Interact(Direction dir, Cloud other) {

    }
    public override void Interact(Direction dir, Glass other) {

    }
    public override void Interact(Direction dir, Fragile other) {

    }
    public override void Interact(Direction dir, Cursed other) {

    }
    public override void Interact(Direction dir, Lead other) {

    }
    public override void Interact(Direction dir, Ice other) {

    }
}

public class Glass : AbstractMaterial {
    public Glass() {}
    public override float GetMass() {
        return 1f;
    }

    public override float GetWeight()
    {
        return 9.8f;
    }

    public override float GetGravityScale()
    {
        return 1f;
    }
    public override float GetFriction() {
        return 1f;
    }
    public override int GetFrameIndex() {
        return 2;
    }
    public override void Interact(Direction dir, Cloud other) {

    }
    public override void Interact(Direction dir, Glass other) {

    }
    public override void Interact(Direction dir, Fragile other) {

    }
    public override void Interact(Direction dir, Cursed other) {

    }
    public override void Interact(Direction dir, Lead other) {

    }
    public override void Interact(Direction dir, Ice other) {

    }
}

public class Fragile : AbstractMaterial {
    public Fragile() {}
    public override float GetMass() {
        return 1f;
    }

    public override float GetWeight()
    {
        return 9.8f;
    }

    public override float GetGravityScale()
    {
        return 1f;
    }
    public override float GetFriction() {
        return 1f;
    }
    public override int GetFrameIndex() {
        return 4;
    }
    public override void Interact(Direction dir, Cloud other) {

    }
    public override void Interact(Direction dir, Glass other) {

    }
    public override void Interact(Direction dir, Fragile other) {

    }
    public override void Interact(Direction dir, Cursed other) {

    }
    public override void Interact(Direction dir, Lead other) {

    }
    public override void Interact(Direction dir, Ice other) {

    }
}

public class Cursed : AbstractMaterial {
    public Cursed() {}
    public override float GetMass() {
        return 1f;
    }

    public override float GetWeight()
    {
        return 9.8f;
    }

    public override float GetGravityScale()
    {
        return 1f;
    }
    public override float GetFriction() {
        return 1f;
    }
    public override int GetFrameIndex() {
        return 6;
    }
    public override void Interact(Direction dir, Cloud other) {

    }
    public override void Interact(Direction dir, Glass other) {

    }
    public override void Interact(Direction dir, Fragile other) {

    }
    public override void Interact(Direction dir, Cursed other) {

    }
    public override void Interact(Direction dir, Lead other) {

    }
    public override void Interact(Direction dir, Ice other) {

    }
}

public class Lead : AbstractMaterial {
    public Lead() {}
    public override float GetMass() {
        return 1f;
    }

    public override float GetWeight()
    {
        return 9.8f;
    }

    public override float GetGravityScale()
    {
        return 1f;
    }
    public override float GetFriction() {
        return 1f;
    }
    public override int GetFrameIndex() {
        return 1;
    }
    public override void Interact(Direction dir, Cloud other) {

    }
    public override void Interact(Direction dir, Glass other) {

    }
    public override void Interact(Direction dir, Fragile other) {

    }
    public override void Interact(Direction dir, Cursed other) {

    }
    public override void Interact(Direction dir, Lead other) {

    }
    public override void Interact(Direction dir, Ice other) {

    }
}

public class Ice : AbstractMaterial {
    public Ice() {}
    public override float GetMass() {
        return 1f;
    }

    public override float GetWeight()
    {
        return 9.8f;
    }

    public override float GetGravityScale()
    {
        return 1f;
    }
    public override float GetFriction() {
        return 1f;
    }
    public override int GetFrameIndex() {
        return 3;
    }
    public override void Interact(Direction dir, Cloud other) {

    }
    public override void Interact(Direction dir, Glass other) {

    }
    public override void Interact(Direction dir, Fragile other) {

    }
    public override void Interact(Direction dir, Cursed other) {

    }
    public override void Interact(Direction dir, Lead other) {

    }
    public override void Interact(Direction dir, Ice other) {

    }
}
