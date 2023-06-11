namespace OOPAdventure;

//virtual lets us override the action  
public abstract class Action 
{
    public virtual string Name => "";
    public virtual void Execute(string[] args) 
    {
        throw new Exception("Nothing to execute");    
    }

}