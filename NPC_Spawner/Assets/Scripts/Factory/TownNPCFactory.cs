public class TownNPCFactory : AbstractNPCFactory
{
    private readonly NPCType _type;

    public TownNPCFactory(NPCType type)
    {
        _type = type;
        
    }

    public override INPC Create()
    {
        switch (_type)
        {
            case NPCType.Bartender:
                INPC bartender = new Bartender();
                return bartender;
            case NPCType.Bookkeeper:
                INPC bookkeeper = new Bookkeeper();
                return bookkeeper;
            case NPCType.Clothier:
                INPC clothier = new Clothier();
                return clothier;
            case NPCType.Hairstylist:
                INPC hairstylist = new Hairstylist();
                return hairstylist;
            case NPCType.Engineers:
                INPC engineers = new Engineers();
                return engineers;
            case NPCType.Mechanic:
                INPC mechanic = new Mechanic();
                return mechanic;
            case NPCType.Nurse:
                INPC nurse = new Nurse();
                return nurse;
        }
        return null;
    }
}
