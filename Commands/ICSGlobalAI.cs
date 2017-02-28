using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSB_ScriptLib.Commands
{
    public interface ICSGlobal
    {
        //void cSetVar(dynamic owner, string name, object variable);

        //T cGetVar<T>(dynamic owner, string name);

        void cEnableAI(dynamic handle);

        void cDisableAI(dynamic handle);

        //void cSetCallback(dynamic owner, string name, string func);

        void cTimeout(dynamic owner, string func, int timeout);

        object cSetAIScript(string scriptpath, dynamic handle);

        object cAIScriptFunc(dynamic handle, string action, string function);

        object cSetFieldScript(dynamic map, string scriptpath);

        object cFieldScriptFunc(dynamic map, string action, string function);












        void cAIScriptSet(dynamic handle);

        void cNPCVanish(dynamic handle);










        string cGetName(dynamic handle);






        long cNowTick();

        long cNowUnix();

        int cNowSecond();




        object cDoorBuild(dynamic owner, string doorindex, int x, int y, int dir, int scale);

        void cDoorAction(dynamic owner, dynamic handle, dynamic block, string action);

        void cLinkToAll(dynamic map, string mapinx, int x, int y);

        void cLinkTo(dynamic handle, string mapinx, int x, int y);

        void cNotice(dynamic handle, string notice);

        void cNotice(dynamic map, string scriptfile, string scriptindex);





        void cMobSuicide(dynamic map);

        bool cIsObjectDead(dynamic handle);

        int cObjectCount(dynamic map, int objectype);

        void cMobDialog(dynamic map, string mobindex, string scriptfile, string scriptindex);

        object cMobRegen_Obj(string index, dynamic handle);

        object cMobRegen_XY(dynamic map, string index, int x, int y, int dir);

        void cGroupRegenInstance(dynamic map, string groupindex, int spawnlimit = 1);

        object cGetCharacter(dynamic map, string name);










        int cRandomInt();

        int cRandomInt(int end);

        int cRandomInt(int start, int end);



















        void cEffectRegen(dynamic map, string name, int x, int y, int d, int size);

        void cSetAbstate(dynamic handle, string index, int str, int keeptime);

        void cSetAbstateArea(dynamic map, string index, int str, int keeptime, int x, int y, int radius);

        void cResetAbstate(dynamic handle, string index);









        object cExecFunc(dynamic handle, string func, params object[] parameters);

        void cExecCheck(dynamic owner, string func);

        void cDebugLog(string filename, string message);

        void cAssertLog(string message);
    }
}
