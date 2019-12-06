using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9efe5fee_3fbc_4eee_a076_eb7b940cad57
{
    class Program
    {
        static void Main(string[] args)
        {
        }

public static Agent[] RechercherAgents(Agent[] agents, CritèreAgent critères)
{
    IEnumerable<Agent> agentsFiltrés;
    agentsFiltrés = agents;

    if (critères.AgentMatricule != null)
    {
        agentsFiltrés = agentsFiltrés.Where(a => a.AgentMatricule == critères.AgentMatricule);
    }

    if (critères.Nom != null)
    {
        agentsFiltrés = agentsFiltrés.Where(a => a.Nom == critères.Nom);
    }

    if (critères.Grade != null)
    {
        agentsFiltrés = agentsFiltrés.Where(a => a.Grade == critères.Grade);
    }

    // ...

    return agentsFiltrés.ToArray();
}
    }

    class Agent
    {

    }
}
