namespace IntelligentVacuum.Agent
{
    using System;
    using System.Collections.Generic;
    using Environments;

    public class Agent
    {
        public Agent()
        {
        }

        public AgentAction DecideAction(Room room)
        {
            AgentAction action;
            // SENSE
            bool isDirty = room.IsDirty;
            //New Instantiation of Random
            Random random = new Random();
            int randomNum = random.Next(1, 4);

            // PLAN
            if (isDirty)
            {
                action = AgentAction.CLEAN;
            }
            else
            {
                switch (randomNum)
                {
                    case 1:
                        action = AgentAction.MOVE_RIGHT;
                        break;

                    case 2:
                        action = AgentAction.MOVE_DOWN;
                        break;

                    case 3:
                        action = AgentAction.MOVE_LEFT;
                        break;

                    case 4:
                        action = AgentAction.MOVE_UP;
                        break;

                    default:
                        action = AgentAction.MOVE_RIGHT;
                        break;
                }

            }
            // ACT
            return action;

        }
    }
}
