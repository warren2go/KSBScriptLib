using System;
using KSB_ScriptLib.Commands;

namespace KSB_ScriptLib.Structure
{
    /// <summary>
    /// Concrete class with closed definitions/variables that remain constant for each script-instance.
    /// This file is replaced with a specific implementation on the server, any customizations are ignored.
    /// This file is intended for a guide only.
    /// </summary>
    public class CSScript : CSScriptObject, ICSGlobal
    {
        public enum eScriptObjectType
        {
            INVALID = -1,
            FLAG = 0,
            DROPITEM = 1,
            PLAYER = 2,
            MINIHOUSE = 3,
            NPC = 4,
            MOB = 5,
            MAGICFIELD = 6,
            DOOR = 7,
            BANDIT = 8,
            EFFECT = 9,
            SERVANT = 10,
            MOVER = 11,
            PET = 12,
            MAX = 13,
        }

        public enum eScriptLoopType
        {
            SLT_RETURN = 0,
            SLT_BLOCK = 1,
        }

        public static int WAIT_PLAYER_MAP_LOGIN_SEC_MAX = 30000;



        public void cEnableAI(dynamic handle)
        {
            throw new NotImplementedException();
        }

        public void cDisableAI(dynamic handle)
        {
            throw new NotImplementedException();
        }

        public void cTimeout(dynamic owner, string func, int timeout)
        {
            throw new NotImplementedException();
        }

        public object cSetAIScript(string scriptpath, dynamic handle)
        {
            throw new NotImplementedException();
        }

        public object cAIScriptFunc(dynamic handle, string action, string function)
        {
            throw new NotImplementedException();
        }

        public object cSetFieldScript(dynamic map, string scriptpath)
        {
            throw new NotImplementedException();
        }

        public object cFieldScriptFunc(dynamic map, string action, string function)
        {
            throw new NotImplementedException();
        }

        public void cAIScriptSet(dynamic handle)
        {
            throw new NotImplementedException();
        }

        public void cNPCVanish(dynamic handle)
        {
            throw new NotImplementedException();
        }

        public string cGetName(dynamic handle)
        {
            throw new NotImplementedException();
        }

        public long cNowTick()
        {
            throw new NotImplementedException();
        }

        public long cNowUnix()
        {
            throw new NotImplementedException();
        }

        public int cNowSecond()
        {
            throw new NotImplementedException();
        }

        public object cDoorBuild(dynamic owner, string doorindex, int x, int y, int dir, int scale)
        {
            throw new NotImplementedException();
        }

        public void cDoorAction(dynamic owner, dynamic handle, dynamic block, string action)
        {
            throw new NotImplementedException();
        }

        public void cLinkToAll(dynamic map, string mapinx, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void cLinkTo(dynamic handle, string mapinx, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void cNotice(dynamic map, string scriptfile, string scriptindex)
        {
            throw new NotImplementedException();
        }

        public void cNotice(dynamic handle, string notice)
        {
            throw new NotImplementedException();
        }

        public void cMobSuicide(dynamic map)
        {
            throw new NotImplementedException();
        }

        public bool cIsObjectDead(dynamic handle)
        {
            throw new NotImplementedException();
        }

        public int cObjectCount(dynamic map, int objectype)
        {
            throw new NotImplementedException();
        }

        public void cMobDialog(dynamic map, string mobindex, string scriptfile, string scriptindex)
        {
            throw new NotImplementedException();
        }

        public object cMobRegen_Obj(string index, dynamic handle)
        {
            throw new NotImplementedException();
        }

        public object cMobRegen_XY(dynamic map, string index, int x, int y, int dir)
        {
            throw new NotImplementedException();
        }

        public void cGroupRegenInstance(dynamic map, string groupindex, int spawnlimit = 1)
        {
            throw new NotImplementedException();
        }

        public object cGetCharacter(dynamic map, string name)
        {
            throw new NotImplementedException();
        }

        public int cRandomInt()
        {
            throw new NotImplementedException();
        }

        public int cRandomInt(int end)
        {
            throw new NotImplementedException();
        }

        public int cRandomInt(int start, int end)
        {
            throw new NotImplementedException();
        }

        public void cEffectRegen(dynamic map, string name, int x, int y, int d, int size)
        {
            throw new NotImplementedException();
        }

        public void cSetAbstate(dynamic handle, string index, int str, int keeptime)
        {
            throw new NotImplementedException();
        }

        public void cSetAbstateArea(dynamic map, string index, int str, int keeptime, int x, int y, int radius)
        {
            throw new NotImplementedException();
        }

        public void cResetAbstate(dynamic handle, string index)
        {
            throw new NotImplementedException();
        }

        public object cExecFunc(dynamic handle, string func, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void cExecCheck(dynamic owner, string func)
        {
            throw new NotImplementedException();
        }

        public void cDebugLog(string filename, string message)
        {
            throw new NotImplementedException();
        }

        public void cAssertLog(string message)
        {
            throw new NotImplementedException();
        }
    }
}
