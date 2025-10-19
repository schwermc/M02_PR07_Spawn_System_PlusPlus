using UnityEngine;

public class Client : MonoBehaviour
{
    private INPC m_VNPC;
    private INPC m_CNPC;
    private INPC m_TNPC;

    void Start()
    {
        var types = new NPCType();
        m_VNPC = GetVNPC(types);
        m_CNPC = GetCNPC(types);
        m_TNPC = GetTNPC(types);
    }

    public INPC GetVNPC(NPCType type)
    {
        var npcType = new VillagersNPCFactory(type);
        return npcType.Create();
    }

    public INPC GetCNPC(NPCType type)
    {
        var npcType = new CityNPCFactory(type);
        return npcType.Create();
    }

    public INPC GetTNPC (NPCType type)
    {
        var npcType = new TownNPCFactory(type);
        return npcType.Create();
    }
}
