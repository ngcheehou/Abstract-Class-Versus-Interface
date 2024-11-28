
//This project shows a scenario where Abstract Class has more advantage against Interface.


#region Main program of abstract class implementation 

Warrior warrior1 = new Warrior();
Console.WriteLine($"Warrior1 intial HP: {warrior1.HP} ");
warrior1.Battle(30);
warrior1.Sleep();

Healer healer1 = new Healer();
Console.WriteLine($"Healer1 intial HP: {healer1.HP} ");
healer1.SelfHealing(30);
healer1.Sleep();
#endregion


#region Main program of Interface implementation 

WarriorOfInterface warrior2 = new WarriorOfInterface();
Console.WriteLine($"Warrior2 intial HP: {warrior2.HP} ");
warrior2.Battle(30);
warrior2.Sleep();

HealerOfInterface healer2 = new HealerOfInterface();
Console.WriteLine($"Healer2 intial HP: {healer2.HP} ");
healer2.SelfHealing(30);
healer2.Sleep();
#endregion


#region Main program of better Interface implementation 


WarriorOfInterface warrior3 = new WarriorOfInterface();
Console.WriteLine($"Warrior3 intial HP: {warrior3.HP} ");
warrior3.Battle(30);
warrior3.Sleep();

HealerOfInterface healer3 = new HealerOfInterface();
Console.WriteLine($"Healer3 intial HP: {healer3.HP} ");
healer3.SelfHealing(30);
healer3.Sleep();
#endregion


Console.ReadLine();


#region Abstract Class 
public abstract class Human
{
    public int HP { get;  set; }
    public readonly int INITIAL_HEAL_POINT=100;
    public readonly int SLEEP_RESTORE_POINT=20;

    protected Human()
    {
        HP = INITIAL_HEAL_POINT;
    }

    public abstract void LevelUp();

    public void Sleep()
    {
        HP += SLEEP_RESTORE_POINT;
        Console.WriteLine($"Hero get sleep and restore HP to: {HP}\n");
    }

    public virtual void SelfHealing(int healItem) { }

    public virtual void Battle(int damage) { }



}

public class Warrior: Human
{
    public override void LevelUp()
    {
        Console.WriteLine("Some customized level upgrading mechanism for warrior type hero");
    }

    public override void Battle(int damage)
    {
        HP -= damage;
        Console.WriteLine($"Hero take {damage} HP from battle, and current HP is {HP} ");
    }
}

public class Healer : Human
{
    public override void LevelUp()
    {
        Console.WriteLine("Some customized level upgrading mechanism for healer type hero");
    }

    public override void SelfHealing(int healItem)
    {
        HP += healItem;
        Console.WriteLine($"Hero perform self healing of {healItem} point, and current HP is {HP} ");
    }
}
#endregion 
 

#region Interface 
public interface IHuman
{
    public int HP { get; set; }
    void LevelUp();
    void Sleep();
    void Battle(int damage);
    void SelfHealing(int healItem);
}


public class WarriorOfInterface: IHuman
{
    public int HP { get; set; }
    public readonly int INITIAL_HEAL_POINT = 100;
    public readonly int SLEEP_RESTORE_POINT = 20;
    public WarriorOfInterface()
    {
        HP = INITIAL_HEAL_POINT;
    }

    public void Battle(int damage)
    {
        HP -= damage;
        Console.WriteLine($"Hero take {damage} HP from battle, and current HP is {HP} ");
    }

    
    public void SelfHealing(int healItem)
    {
        //do nothing since warrior do not have the ability to self healing
    }

    public void Sleep()
    {

        HP += SLEEP_RESTORE_POINT;
        Console.WriteLine($"Hero get sleep and restore HP to: {HP}\n");
    }

    public void LevelUp()
    {
        Console.WriteLine("Some customized level upgrading mechanism for warrior type hero");
    }

}


public class HealerOfInterface : IHuman
{
    public int HP { get; set; }
    public readonly int INITIAL_HEAL_POINT = 100;
    public readonly int SLEEP_RESTORE_POINT = 20;
    public HealerOfInterface()
    {
        HP = INITIAL_HEAL_POINT;
    }

    public void Battle(int damage)
    {
        //do nothing since healer do not have to batlle
    }


    public void SelfHealing(int healItem)
    {
        HP += healItem;
        Console.WriteLine($"Hero perform self healing of {healItem} point, and current HP is {HP} ");
    }

    public void Sleep()
    {

        HP += SLEEP_RESTORE_POINT;
        Console.WriteLine($"Hero get sleep and restore HP to: {HP}\n");
    }

    public void LevelUp()
    {
        Console.WriteLine("Some customized level upgrading mechanism for healer type hero");
    }
}


#endregion



#region Better Interface design
public interface IHuman_v2
{
    public int HP { get; set; }
    void LevelUp();
    void Sleep();
  
   
}

public interface IBattle
{
    void Battle(int damage);
}

public interface IHeal
{
    void SelfHealing(int healItem);
}


public class WarriorOfInterface_v2 : IHuman_v2, IBattle
{
    public int HP { get; set; }
    public readonly int INITIAL_HEAL_POINT = 100;
    public readonly int SLEEP_RESTORE_POINT = 20;
    public WarriorOfInterface_v2()
    {
        HP = INITIAL_HEAL_POINT;
    }

    public void Battle(int damage)
    {
        HP -= damage;
        Console.WriteLine($"Hero take {damage} HP from battle, and current HP is {HP} ");
    }
     

    public void Sleep()
    {

        HP += SLEEP_RESTORE_POINT;
        Console.WriteLine($"Hero get sleep and restore HP to: {HP}\n");
    }

    public void LevelUp()
    {
        Console.WriteLine("Some customized level upgrading mechanism for warrior type hero");
    }

}


public class HealerOfInterface_v2 : IHuman_v2, IHeal
{
    public int HP { get; set; }
    public readonly int INITIAL_HEAL_POINT = 100;
    public readonly int SLEEP_RESTORE_POINT = 20;
    public HealerOfInterface_v2()
    {
        HP = INITIAL_HEAL_POINT;
    }
     

    public void SelfHealing(int healItem)
    {
        HP += healItem;
        Console.WriteLine($"Hero perform self healing of {healItem} point, and current HP is {HP} ");
    }

    public void Sleep()
    {

        HP += SLEEP_RESTORE_POINT;
        Console.WriteLine($"Hero get sleep and restore HP to: {HP}\n");
    }

    public void LevelUp()
    {
        Console.WriteLine("Some customized level upgrading mechanism for healer type hero");
    }
}
#endregion




