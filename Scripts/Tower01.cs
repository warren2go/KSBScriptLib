using KSB_ScriptLib.Structure;

namespace KSBCSScript
{
    public class Tower01 : CSScript
    {
        //--------------------------------------------------------------------------------
        //--                         Tower Of Iyzel Boss Data                           --
        //--------------------------------------------------------------------------------

        private dynamic ThresholdTable = new CSScriptObject
        (
            "SummonHP_Floor04", new CSScriptList<int>() { 800, 200 },
            "SummonHP_Floor09", new CSScriptList<int>() { 700, 200 },
            "SummonHP_Floor13", new CSScriptList<int>() { 700, 200 },
            "SummonHP_Floor19", new CSScriptList<int>() { 700, 500, 200 }
        );

        private dynamic BossSkill = new CSScriptObject
        (
            "Summon_Floor04", new CSScriptObject(
                "HP800", new CSScriptObject
                (
                    "SummonMobs", new CSScriptList<string>() { "T_Imp", "T_Imp", "T_Imp", "T_Imp", "T_GangImp", "T_GangImp", "T_GangImp", "T_GangImp" }
                ),
                "HP200", new CSScriptObject
                (
                    "SummonMobs", new CSScriptList<string>() { "T_HungryWolf", "T_HungryWolf", "T_Ratman", "T_Ratman" }
                )),

            "Summon_Floor09", new CSScriptObject(
                "HP700", new CSScriptObject
                (
                    "SummonMobs", new CSScriptList<string>() { "T_SkelArcher01", "T_SkelArcher01" }
                ),
                "HP200", new CSScriptObject
                (
                    "SummonMobs", new CSScriptList<string>() { "T_SkelWarrior", "T_SkelWarrior", "T_SkelWarrior", "T_SkelArcher02" }
                )),

            "Summon_Floor13", new CSScriptObject(
                "HP700", new CSScriptObject
                (
                    "SummonMobs", new CSScriptList<string>() { "T_OldFox", "T_OldFox", "T_OldFox", "T_OldFox", "T_DesertWolfC", "T_DesertWolfC", "T_DesertWolfC", "T_DesertWolfC" }
                ),
                "HP200", new CSScriptObject
                (
                    "SummonMobs", new CSScriptList<string>() { "T_Ghost", "T_Ghost", "T_Ghost", "T_Ghost", "T_IceViVi", "T_IceViVi", "T_IceViVi", "T_IceViVi" }
                )),

            "Summon_Floor19", new CSScriptObject(
                "HP700", new CSScriptObject
                (
                    "SummonMobs", new CSScriptList<string>() { "T_Prock", "T_Spider00", "T_Spider00", "T_Spider00", "T_Spider00" }
                ),
                "HP500", new CSScriptObject
                (
                    "SummonMobs", new CSScriptList<string>() { "T_KingCall", "T_KingCall" }
                ),
                "HP200", new CSScriptObject
                (
                    "SummonMobs", new CSScriptList<string>() { "T_FlyingStaff01", "T_FlyingStaff01", "T_IronSlime01", "T_IronSlime01" }
                ))
        );

        //--------------------------------------------------------------------------------
        //--                        Tower Of Iyzel Name Data                            --
        //--------------------------------------------------------------------------------

        private dynamic MainCSScriptPath = "Instance/Tower01";
        private dynamic MsgScriptFileDefault = "Tower01";

        private dynamic StepNameTable = new CSScriptList<dynamic>()
        {
            "Floor00",
            "Floor01",
            "Floor02",
            "Floor03",

            "Floor04",
            "Floor05",
            "Floor06",
            "Floor07",
            "Floor08",

            "Floor09",
            "Floor10",
            "Floor11",
            "Floor12",

            "Floor13",
            "Floor14",
            "Floor15",
            "Floor16",
            "Floor17",
            "Floor18"
        };

        private dynamic BossSkillNameTable = new CSScriptList<string>()
        {
            "Summon"
        };

        //--------------------------------------------------------------------------------
        //--                         Tower Of Iyzel NPC Data                            --
        //--------------------------------------------------------------------------------

        private dynamic NPC_GuardChat = new CSScriptObject
        (
            "ScriptFileName", "Tower01",
            "SpeakerIndex", "EldSpeGuard01",
            "StartDialog", new CSScriptObject
            (
                "Floor00", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat0101"),
                    new CSScriptObject("Index", "Chat0102"),
                    new CSScriptObject("Index", "Chat0103"),
                 },
                 "Floor01", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat0201"),
                 },
                 "Floor02", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat0301"),
                 },
                 "Floor03", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat0401"),
                 },
                 "Floor04", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat0501"),
                    new CSScriptObject("Index", "Chat0502"),
                    new CSScriptObject("Index", "Chat0503"),
                 },
                 "Floor05", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat0601"),
                    new CSScriptObject("Index", "Chat0602"),
                 },
                 "Floor06", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat0701"),
                 },
                 "Floor07", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat0801"),
                 },
                 "Floor08", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat0901"),
                    new CSScriptObject("Index", "Chat0902"),
                 },
                 "Floor09", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat1001"),
                    new CSScriptObject("Index", "Chat1002"),
                    new CSScriptObject("Index", "Chat1003"),
                 },
                 "Floor10", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat1101"),
                 },
                 "Floor11", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat1201"),
                 },
                 "Floor12", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat1301"),
                    new CSScriptObject("Index", "Chat1302"),
                 },
                 "Floor13", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat1401"),
                    new CSScriptObject("Index", "Chat1402"),
                    new CSScriptObject("Index", "Chat1403"),
                 },
                 "Floor14", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat1501"),
                 },
                 "Floor15", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat1601"),
                    new CSScriptObject("Index", "Chat1602"),
                 },
                 "Floor16", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat1701"),
                    new CSScriptObject("Index", "Chat1702"),
                    new CSScriptObject("Index", "Chat1703"),
                 },
                 "Floor17", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat1801"),
                    new CSScriptObject("Index", "Chat1802"),
                    new CSScriptObject("Index", "Chat1803"),
                 }
            ),
            "BossBattleDialog", new CSScriptObject
            (
                 "Floor03", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat0501Boss"),
                    new CSScriptObject("Index", "Chat0502Boss"),
                 },
                 "Floor08", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat1001Boss"),
                    new CSScriptObject("Index", "Chat1002Boss"),
                 },
                 "Floor12", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat1401Boss"),
                    new CSScriptObject("Index", "Chat1402Boss"),
                 },
                 "Floor18", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat2001Boss"),
                    new CSScriptObject("Index", "Chat2002Boss"),
                    new CSScriptObject("Index", "Chat2003Boss"),
                 }
            ),
            "ClearDialog", new CSScriptObject
            (
                 "Floor18", new CSScriptList<dynamic>()
                 {
                    new CSScriptObject("Index", "Chat2001"),
                    new CSScriptObject("Index", "Chat2002"),
                    new CSScriptObject("Index", "Chat2003"),
                 }
            )
        );

        //--------------------------------------------------------------------------------
        //--                     Tower Of Iyzel Process Data                            --
        //--------------------------------------------------------------------------------

        private dynamic LinkInfo = new CSScriptObject
        (
            "ReturnMapOnGateClick", new CSScriptObject("MapIndex", "RouVal01", "x", 4664, "y", 8416),
            "ReturnMapOnClear", new CSScriptObject("MapIndex", "RouVal01", "x", 4661, "y", 8208)
        );

        private dynamic DelayTime = new CSScriptObject
        (
            "AfterInit", 10000,
            "GapDialog", 2000,
            "WaitAfterGenMob", 5000,
            "GapIDReturnNotice", 10000
        );

        private dynamic NoticeInfo = new CSScriptObject
        (
            "ScriptFileName", "Tower01",
            "IDReturn", new CSScriptList<dynamic>()
            {
                new CSScriptObject("Index", "Chat2001System"),
                new CSScriptObject("Index", null),
                new CSScriptObject("Index", null),
                new CSScriptObject("Index", "Chat2002System"),
                new CSScriptObject("Index", null),
                new CSScriptObject("Index", "Chat2003System"),
            }
        );

        private dynamic QuestMobKillInfo = new CSScriptObject
        (
            "QuestID", 2663,
            "MobIndex", "Daliy_Check_Tower01",
            "MaxKillCount", 5
        );

        //--------------------------------------------------------------------------------
        //--                      Tower Of Iyzel Regen Data                             --
        //--------------------------------------------------------------------------------

        private dynamic RegenInfo = new CSScriptObject
        (
            "Group", new CSScriptObject
            (
                "Floor00", new CSScriptList<string>() { "201", "202" },
                "Floor01", new CSScriptList<string>() { "301", "302" },
                "Floor02", new CSScriptList<string>() { "401", "402" },
                "Floor03", new CSScriptList<string>() { "501" },

                "Floor04", new CSScriptList<string>() { "601" },
                "Floor05", new CSScriptList<string>() { "701" },
                "Floor06", new CSScriptList<string>() { "801", "802" },
                "Floor07", new CSScriptList<string>() { "901", "902", "903", "904", "905", "906" },
                "Floor08", new CSScriptList<string>() { "1002" },

                "Floor09", new CSScriptList<string>() { "1101", "1102" },
                "Floor10", new CSScriptList<string>() { "1201", "1202" },
                "Floor11", new CSScriptList<string>() { "1301" },
                "Floor12", new CSScriptList<string>() { "1401", "1402" },

                "Floor13", new CSScriptList<string>() { "1501", "1502" },
                "Floor14", new CSScriptList<string>() { "1601" },
                "Floor15", new CSScriptList<string>() { "1701" },
                "Floor16", new CSScriptList<string>() { "1801" },
                "Floor17", new CSScriptList<string>() { "1901" },
                "Floor18", new CSScriptList<string>() { "2001", "2003" }
            ),
            "Mob", new CSScriptObject
            (
                "Floor03", new CSScriptObject
                (
                    "DustGolem", new CSScriptObject
                    (
                        "Index", "T_DustGolem", "x", 6776, "y", 963, "dir", 0
                    )
                ),
                "Floor08", new CSScriptObject
                (
                    "StoneGolem", new CSScriptObject
                    (
                        "Index", "T_StoneGolem", "x", 10709, "y", 9808, "dir", 0
                    )
                ),
                "Floor12", new CSScriptObject
                (
                    "PoisonGolem", new CSScriptObject
                    (
                        "Index", "T_PoisonGolem", "x", 3262, "y", 8795, "dir", 0
                    )
                ),
                "Floor18", new CSScriptObject
                (
                    "IronGolem", new CSScriptObject
                    (
                        "Index", "T_IronGolem", "x", 5013, "y", 7773, "dir", 0
                    )
                )
            ),
            "NPC", new CSScriptObject
            (
                
            ),
            "Stuff", new CSScriptObject
            (
                "Door00", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 1184, "y", 3723, "dir", 0, "Block", "DOOR00", "scale", 1000
                ),
                "Door01", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 2732, "y", 1863, "dir", 0, "Block", "DOOR01", "scale", 1000
                ),
                "Door02", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 5069, "y", 1058, "dir", 0, "Block", "DOOR02", "scale", 1000
                ),
                "Door03", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 7556, "y", 937, "dir", 0, "Block", "DOOR03", "scale", 1000
                ),
                "Door04", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 10035, "y", 951, "dir", 0, "Block", "DOOR04", "scale", 1000
                ),
                "Door05", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 10241, "y", 3883, "dir", 0, "Block", "DOOR05", "scale", 1000
                ),
                "Door06", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 11531, "y", 5975, "dir", 0, "Block", "DOOR06", "scale", 1000
                ),
                "Door07", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 11727, "y", 8426, "dir", 0, "Block", "DOOR07", "scale", 1000
                ),
                "Door08", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 10190, "y", 10335, "dir", 0, "Block", "DOOR08", "scale", 1000
                ),
                "Door09", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 8139, "y", 11611, "dir", 0, "Block", "DOOR09", "scale", 1000
                ),
                "Door10", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 5701, "y", 11825, "dir", 0, "Block", "DOOR10", "scale", 1000
                ),
                "Door11", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 3564, "y", 10499, "dir", 0, "Block", "DOOR11", "scale", 1000
                ),
                "Door12", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 3278, "y", 8097, "dir", 0, "Block", "DOOR12", "scale", 1000
                ),
                "Door13", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 3276, "y", 5629, "dir", 0, "Block", "DOOR13", "scale", 1000
                ),
                "Door14", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 5394, "y", 4529, "dir", 0, "Block", "DOOR14", "scale", 1000
                ),
                "Door15", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 7902, "y", 4434, "dir", 0, "Block", "DOOR15", "scale", 1000
                ),
                "Door16", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 8976, "y", 6493, "dir", 0, "Block", "DOOR16", "scale", 1000
                ),
                "Door17", new CSScriptObject
                (
                    "Index", "T_Gate", "x", 7003, "y", 7615, "dir", 0, "Block", "DOOR17", "scale", 1000
                ),
                "ExitGate", new CSScriptObject
                (
                    "Index", "T_Gate02", "x", 1179, "y", 7721, "dir", 0, "Block", null, "scale", 1000
                )
            )
        );

        //--------------------------------------------------------------------------------
        //--                       Tower Of Iyzel Progress Func                         --
        //--------------------------------------------------------------------------------

        private CSScriptList<dynamic> ID_StepsList = new CSScriptList<dynamic>()
        {
            new CSScriptObject("Function", "InitDungeon",  "Name", "InitDungeon"),
            new CSScriptObject("Function", "EachFloor",    "Name", "EachFloor"),
            new CSScriptObject("Function", "QuestSuccess", "Name", "QuestSuccess"),
            new CSScriptObject("Function", "QuestFailed",  "Name", "QuestFailed"),
            new CSScriptObject("Function", "ReturnToHome", "Name", "ReturnToHome"),
        };

        private dynamic ID_StepsIndexList = new CSScriptObject();

        public void InitDungeon(dynamic var)
        {
            cExecCheck(var.Owner, "InitDungeon");

            if (var["bPlayerMapLogin"] == null)
            {
                if (var.InitialSec + WAIT_PLAYER_MAP_LOGIN_SEC_MAX <= cNowTick())
                {
                    GoToFail(var);
                    return;
                }

                return;
            }

            if (var["InitDungeon"] == null)
            {
                DebugLog("Start InitDungeon");

                var.InitDungeon = new CSScriptObject();

                for (int i = 0; i <= 17; i++)
                {
                    var DoorTableIndex = "";

                    if (i < 10)
                    {
                        DoorTableIndex = "Door0" + i;
                    }
                    else
                    {
                        DoorTableIndex = "Door" + i;
                    }

                    var CurRegenDoor = RegenInfo.Stuff[DoorTableIndex];

                    if (CurRegenDoor != null)
                    {
                        //var nCurDoorHandle = cDoorBuild(var.Owner, CurRegenDoor.Index, CurRegenDoor.x, CurRegenDoor.y, CurRegenDoor.dir, CurRegenDoor.scale);

                        //if (nCurDoorHandle != null)
                        //{
                        //    cDoorAction(var.Owner, nCurDoorHandle, CurRegenDoor.Block, "close");

                        //    var["Door"][nCurDoorHandle.Handle] = CurRegenDoor;

                        //    var["Door" + (i + 1)] = nCurDoorHandle;
                        //}
                    }
                }

                var RegenExitGate = RegenInfo.Stuff.ExitGate;
                var nExitGateHandle = cDoorBuild(var.Owner, RegenExitGate.Index, RegenExitGate.x, RegenExitGate.y, RegenExitGate.dir, RegenExitGate.scale);

                if (nExitGateHandle != null)
                {
                    if (cSetAIScript(MainCSScriptPath, nExitGateHandle) == null)
                    {
                        ErrorLog("InitDungeon::cSetAIScript ( MainLuaScriptPath, nExitGateHandle ) == null");
                    }

                    if (cAIScriptFunc(nExitGateHandle, "NPCClick", "ExitGateClick") == null)
                    {
                        ErrorLog("InitDungeon::cAIScriptFunc( nExitGateHandle, \"NPCClick\", \"ExitGateClick\" ) == null");
                    }
                }

                var.InitDungeon.WaitSecDuringInit = var.CurSec + DelayTime.AfterInit;
            }

            if (var.InitDungeon.WaitSecDuringInit <= var.CurSec)
            {
                GoToNextStep(var);
                var.InitDungeon = null;
                DebugLog("End InitDungeon");
            }
        }

        public void EachFloor(dynamic var)
        {
            cExecCheck(var.Owner, "EachFloor");

            if (var["EachFloor"] == null)
            {
                var.EachFloor = new CSScriptObject();
            }

            if (var.EachFloor["StepNumber"] == null)
            {
                var.EachFloor.StepNumber = 0;
            }

            var CurStepNo = var.EachFloor.StepNumber;
            var CurStep = StepNameTable[CurStepNo];

            if (var["EachFloor" + CurStepNo] == null)
            {
                DebugLog("Start EachFloor " + CurStepNo);

                var["EachFloor" + CurStepNo] = new CSScriptObject();

                var CurStepRegen = RegenInfo.Group[CurStep];

                for (int i = 0; i < CurStepRegen.Count; i++)
                {
                    DebugLog("cGroupRegenInstance(" + var.Owner.Handle + ", " + CurStepRegen[i]);

                    cGroupRegenInstance(var.Owner, CurStepRegen[i]);
                }

                if (RegenInfo.Mob[CurStep] != null)
                {
                    var BossInfo = RegenInfo.Mob[CurStep][0];

                    if (BossInfo != null)
                    {
                        var BossHandle = cMobRegen_XY(var.Owner, BossInfo.Index, BossInfo.x, BossInfo.y, BossInfo.dir);

                        if (BossHandle != null)
                        {
                            var.Enemy[BossHandle.Handle] = BossInfo;
                            var["EachFloor" + CurStepNo][BossHandle.Handle] = BossHandle;

                            var.RoutineTime[BossHandle.Handle] = cNowTick();

                            cSetAIScript(MainCSScriptPath, BossHandle);
                            cAIScriptFunc(BossHandle, "Entrance", "BossRoutine");
                        }
                    }
                }

                var["EachFloor" + CurStepNo].StartDialogStepSec = var.CurSec;
                var["EachFloor" + CurStepNo].StartDialogStepNo = 0;
                var["EachFloor" + CurStepNo].ClearDialogStepSec = var.CurSec;
                var["EachFloor" + CurStepNo].ClearDialogStepNo = 0;
                var["EachFloor" + CurStepNo].BossBattleDialogStepSec = var.CurSec;
                var["EachFloor" + CurStepNo].BossBattleDialogStepNo = 0;

                var["EachFloor" + CurStepNo].bStartDialogEnd = false;
                var["EachFloor" + CurStepNo].bClearDialogEnd = false;
                var["EachFloor" + CurStepNo].bBossBattleDialogEnd = false;

                var["EachFloor" + CurStepNo].bMobEliminated = false;

                var["EachFloor" + CurStepNo].WaitMobGenSec = var.CurSec + DelayTime.WaitAfterGenMob;
            }

            if (NPC_GuardChat.StartDialog[CurStep] != null)
            {
                if (!var["EachFloor" + CurStepNo].bStartDialogEnd)
                {
                    if (var["EachFloor" + CurStepNo].StartDialogStepNo < NPC_GuardChat.StartDialog[CurStep].Count)
                    {
                        if (var["EachFloor" + CurStepNo].StartDialogStepSec <= var.CurSec)
                        {
                            cMobDialog(var.Owner, NPC_GuardChat.SpeakerIndex, NPC_GuardChat.ScriptFileName, NPC_GuardChat.StartDialog[CurStep][var["EachFloor" + CurStepNo].StartDialogStepNo].Index);
                            DebugLog("EachFloor" + CurStepNo + "::Index(" + NPC_GuardChat.StartDialog[CurStep][var["EachFloor" + CurStepNo].StartDialogStepNo].Index + "), StepNo(" + var["EachFloor" + CurStepNo ].StartDialogStepNo + ")");

                            ++var["EachFloor" + CurStepNo].StartDialogStepNo;
                            var["EachFloor" + CurStepNo].StartDialogStepSec = var.CurSec + DelayTime.GapDialog;
                        }

                        return;
                    }
                    else
                    {
                        var["EachFloor" + CurStepNo].bStartDialogEnd = true;
                    }
                }
            }
            else
            {
                var["EachFloor" + CurStepNo].bStartDialogEnd = true;
            }

            if (!var["EachFloor" + CurStepNo].bMobEliminated)
            {
                if (var["EachFloor" + CurStepNo].WaitMobGenSec <= var.CurSec)
                {
                    if (cObjectCount(var.Owner, eScriptObjectType.MOB.GetHashCode()) <= 0)
                    {
                        var["EachFloor" + CurStepNo].bMobEliminated = true;
                    }
                }

                return;
            }
            else
            {
                if (NPC_GuardChat.ClearDialog[CurStep] != null)
                {
                    if (!var["EachFloor" + CurStepNo].bClearDialogEnd)
                    {
                        if (var["EachFloor" + CurStepNo].ClearDialogStepNo < NPC_GuardChat.ClearDialog[CurStep].Count)
                        {
                            if (var["EachFloor" + CurStepNo].ClearDialogStepSec <= var.CurSec)
                            {
                                cMobDialog(var.Owner, NPC_GuardChat.SpeakerIndex, NPC_GuardChat.ScriptFileName, NPC_GuardChat.ClearDialog[CurStep][var["EachFloor" + CurStepNo].ClearDialogStepNo].Index);
                                DebugLog("EachFloor" + CurStepNo + "::Index(" + NPC_GuardChat.ClearDialog[CurStep][var["EachFloor" + CurStepNo].ClearDialogStepNo].Index + "), StepNo(" + var["EachFloor" + CurStepNo].ClearDialogStepNo + ")");

                                ++var["EachFloor" + CurStepNo].ClearDialogStepNo;
                                var["EachFloor" + CurStepNo].ClearDialogStepSec = var.CurSec + DelayTime.GapDialog;
                            }

                            return;
                        }
                        else
                        {
                            var["EachFloor" + CurStepNo].bClearDialogEnd = true;
                        }
                    }
                }
                else
                {
                    var["EachFloor" + CurStepNo].bClearDialogEnd = true;
                }
            }

            if (var["EachFloor" + CurStepNo].WaitMobGenSec <= var.CurSec)
            {
                if (var["EachFloor" + CurStepNo].bClearDialogEnd)
                {
                    if (!var["EachFloor" + CurStepNo].bMobEliminated)
                    {
                        return;
                    }

                    if (var["Door" + CurStepNo] != null)
                    {
                        cDoorAction(var.Owner, var["Door" + CurStepNo], var.Door[var["Door" + CurStepNo].Handle].Block, "open");
                    }

                    var["EachFloor" + CurStepNo] = null;
                    ++var.EachFloor.StepNumber;

                    DebugLog("End EachFloor " + CurStepNo);

                    if (var.EachFloor.StepNumber >= StepNameTable.Count)
                    {
                        var.EachFloor = null;
                        GoToSuccess(var);
                    }
                }
            }
        }

        public void QuestSuccess(dynamic var)
        {
            cExecCheck(var.Owner, "QuestSuccess");

            DebugLog("Start QuestSuccess");

            //cQuestMobKill_AllInMap( Var["MapIndex"], QuestMobKillInfo["QuestID"], QuestMobKillInfo["MobIndex"], QuestMobKillInfo["MaxKillCount"] )

            GoToNextStep(var);

            DebugLog("End QuestSuccess");
        }

        public void QuestFailed(dynamic var)
        {
            cExecCheck(var.Owner, "QuestFailed");

            DebugLog("Start QuestFailed");

            GoToNextStep(var);

            DebugLog("End QuestFailed");
        }

        public void ReturnToHome(dynamic var)
        {
            cExecCheck(var.Owner, "ReturnToHome");

            if (var["ReturnToHome"] == null)
            {
                DebugLog("Start ReturnToHome");
                var.ReturnToHome = new CSScriptObject();

                var.ReturnToHome.ReturnStepNo = 0;
                var.ReturnToHome.ReturnStepSec = var.CurSec;
                var.ReturnToHome.ReturnNoticeIndex = "IDReturn";
            }

            var sReturnNoticeIndex = var.ReturnToHome.ReturnNoticeIndex;

            if (var.ReturnToHome.ReturnStepNo < NoticeInfo[sReturnNoticeIndex].Count)
            {
                if (var.ReturnToHome.ReturnStepSec <= var.CurSec)
                {
                    if (NoticeInfo[sReturnNoticeIndex][var.ReturnToHome.ReturnStepNo]["Index"] != null)
                    {
                        cNotice(var.Owner, NoticeInfo.ScriptFileName, NoticeInfo[sReturnNoticeIndex][var.ReturnToHome.ReturnStepNo].Index);
                    }

                    ++var.ReturnToHome.ReturnStepNo;
                    var.ReturnToHome.ReturnStepSec = var.CurSec + DelayTime.GapIDReturnNotice;
                }

                return;
            }

            if (var.ReturnToHome.ReturnStepNo >= NoticeInfo[sReturnNoticeIndex].Count)
            {
                if (var.ReturnToHome.ReturnStepSec <= var.CurSec)
                {
                    cLinkToAll(var.Owner, LinkInfo.ReturnMapOnClear.MapIndex, LinkInfo.ReturnMapOnClear.x, LinkInfo.ReturnMapOnClear.y);

                    GoToNextStep(var);
                    var.ReturnToHome = null;

                    DebugLog("End ReturnToHome");
                }
            }
        }

        //--------------------------------------------------------------------------------
        //--                      Tower Of Iyzel Sub Functions                          --
        //--------------------------------------------------------------------------------

        public void DummyFunc(dynamic var)
        {
            cExecCheck(var.Owner, "DummyFunc");
        }

        public void GoToNextStep(dynamic var)
        {
            cExecCheck(var.Owner, "GoToNextStep");

            if (ID_StepsList == null)
            {
                ErrorLog("GoToNextStep::ID_StepsList == null");
                return;
            }

            var nNumofSteps = ID_StepsList.Count;

            if (nNumofSteps < 0)
            {
                ErrorLog("GoToNextStep::nNumofSteps < 0 == " + nNumofSteps);
                return;
            }

            if (var["StepIndexNo"] == null)
            {
                var.StepIndexNo = 0;
            }
            else if (var.StepIndexNo >= nNumofSteps)
            {
                var.StepIndexNo = null;
            }
            else if (ID_StepsList[var.StepIndexNo].Name == "QuestSuccess" || ID_StepsList[var.StepIndexNo].Name == "QuestFailed")
            {
                var.StepIndexNo = ID_StepsIndexList["ReturnToHome"];
            }
            else
            {
                ++var.StepIndexNo;
            }

            if (var["StepFunc"] == null)
            {
                var.StepFunc = "DummyFunc";
            }

            if (var.StepFunc == "DummyFunc")
            {
                var.StepFunc = ID_StepsList[0];
            }

            if (var["StepIndexNo"] != null)
            {
                var nIndex = var.StepIndexNo;

                if (nIndex < 0 || nIndex >= nNumofSteps)
                {
                    ErrorLog("GoToNextStep::var[\"StepIndexNo\"](=" + nIndex + ") is out of range(from 0 to " + nNumofSteps + ").");
                    return;
                }
                var.StepFunc = ID_StepsList[nIndex].Function;

                DebugLog("GoToNextStep::ResultStepName : " + ID_StepsList[nIndex].Name);
            }
            else
            {
                var.StepFunc = "DummyFunc";

                DebugLog("GoToNextStep::ResultStepName : ID_Finish");
            }
        }

        public void GoToSuccess(dynamic var)
        {
            cExecCheck(var.Owner, "GoToSuccess");

            var.KQLimitTime = null;

            var.StepIndexNo = ID_StepsIndexList["QuestSuccess"];

            var nIndex = var.StepIndexNo;

            if (nIndex >= 0)
            {
                var.StepFunc = ID_StepsList[nIndex].Function;
            }
            else
            {
                ErrorLog("GoToSuccess::nIndex is negative.");
                return;
            }

            DebugLog("GoToSuccess::ResultStepName : " + ID_StepsList[nIndex].Name);
        }

        public void GoToFail(dynamic var)
        {
            cExecCheck(var.Owner, "GoToFail");

            var.KQLimitTime = null;

            var.StepIndexNo = ID_StepsIndexList["QuestFailed"];

            var nIndex = var.StepIndexNo;

            if (nIndex >= 0)
            {
                var.StepFunc = ID_StepsList[nIndex].Function;
            }
            else
            {
                ErrorLog("GoToFail::nIndex is negative.");
                return;
            }

            DebugLog("GoToFail::ResultStepName : " + ID_StepsList[nIndex].Name);
        }

        public bool IsKQTimeOver(dynamic var)
        {
            cExecCheck(var.Owner, "IsKQTimeOver");

            if (var["KQLimitTime"] == null)
            {
                ErrorLog("IsKQTimeOver::var[\"KQLimitTime\"] == null");
                return false;
            }

            if (var["CurSec"] == null)
            {
                ErrorLog("IsKQTimeOver::var[\"CurSec\"] == null");
                return false;
            }

            return var.KQLimitTime < var.CurSec;
        }

        public void DebugLog(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                cAssertLog("DebugLog::message == null");
                return;
            }

            cAssertLog("Debug - " + message);
        }

        public void ErrorLog(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                cAssertLog("ErrorLog::message == null");
                return;
            }

            cAssertLog("Error - " + message);
        }

        //--------------------------------------------------------------------------------
        //--                        Tower Of Iyzel Routine                              --
        //--------------------------------------------------------------------------------

        public void PlayerMapLogin(dynamic owner, dynamic handle)
        {
            cExecCheck(owner, "PlayerMapLogin");

            if (owner == null)
            {
                DebugLog("PlayerMapLogin::owner == null");
                return;
            }

            if (handle == null)
            {
                DebugLog("PlayerMapLogin::handle == null");
                return;
            }

            dynamic var = this[owner.Handle];

            if (var == null)
            {
                DebugLog("PlayerMapLogin::var == null");
                return;
            }

            var.bPlayerMapLogin = true;

            DebugLog("PlayerMapLogin::var == true");
        }

        public void ExitGateClick(dynamic owner, dynamic player, object registnumber)
        {
            cExecCheck(owner, "ExitGateClick");

            if (owner == null)
            {
                DebugLog("ExitGateClick::owner == null");
                return;
            }

            if (player == null)
            {
                DebugLog("ExitGateClick::player == null");
                return;
            }

            cLinkTo(player, LinkInfo.ReturnMapOnGateClick.MapIndex, LinkInfo.ReturnMapOnGateClick.x, LinkInfo.ReturnMapOnGateClick.y);

            DebugLog("ExitGateClick::End");
        }

        public void BossDamaged(dynamic owner, dynamic attacker, int maxhp, int curhp, dynamic defender)
        {
            cExecCheck(owner, "BossDamaged");

            if (defender == null)
            {
                ErrorLog("BossDamaged::defender == null");
                return;
            }

            if (owner == null)
            {
                ErrorLog("BossDamaged::owner == null");
                return;
            }

            if (maxhp <= 0 || curhp <= 0)
            {
                ErrorLog("BossDamaged::maxhp/curhp Info is <= 0");
                return;
            }

            dynamic var = this[owner.Handle];

            if (var == null)
            {
                ErrorLog("BossDamaged::var == null");
                return;
            }

            if (var["Enemy"] == null)
            {
                ErrorLog("BossDamaged::var[\"Enemy\"] == null");
                return;
            }

            if (var.Enemy[defender.Handle] == null)
            {
                ErrorLog("BossDamaged::var[\"Enemy\"][" + defender + "] == null");
                return;
            }

            if (var["EachFloor"] == null)
            {
                ErrorLog("BossDamaged::var[\"EachFloor\"] == null");
                return;
            }

            if (var.EachFloor["Casting"] == null)
            {
                var.EachFloor.Casting = new CSScriptObject();
            }

            var HP_Rate = (curhp*1000)/maxhp;

            for (int i = 0; i < BossSkillNameTable.Count; i++)
            {
                if (var.EachFloor[BossSkillNameTable[i] + "PhaseNo"] == null)
                {
                    var.EachFloor[BossSkillNameTable[i] + "PhaseNo"] = 1;
                }

                if (var.EachFloor[BossSkillNameTable[i]] == null)
                {
                    var.EachFloor[BossSkillNameTable[i]] = new CSScriptObject();
                }

                var CurFloorNo = (var.EachFloor.StepNumber + 1);
                var CurFloor = StepNameTable[CurFloorNo];

                var sThresholdTableIndex = BossSkillNameTable[i] + "HP_" + CurFloor;
                var nCurPhase = var.EachFloor[BossSkillNameTable[i] + "PhaseNo"];
                var nMaxPhase = ThresholdTable[sThresholdTableIndex].Count;

                if (nCurPhase < nMaxPhase)
                {
                    long timeout = cNowTick() + 5000;

                    while (ThresholdTable[sThresholdTableIndex][nCurPhase] >= HP_Rate)
                    {
                        if (timeout <= cNowTick() || nCurPhase >= nMaxPhase)
                        {
                            break;
                        }

                        var sCurSkillIndex = "HP" + ThresholdTable[sThresholdTableIndex][nCurPhase];
                        var sBossSkillTableIndex = BossSkillNameTable[i] + "_" + CurFloor;

                        if (BossSkill[sBossSkillTableIndex][sCurSkillIndex] != null)
                        {
                            if (var.EachFloor[BossSkillNameTable[i]][nCurPhase] == null)
                            {
                                var.EachFloor[BossSkillNameTable[i]][nCurPhase] = new CSScriptObject();
                                var.EachFloor[BossSkillNameTable[i]][nCurPhase].bCasting = true;
                                var.EachFloor[BossSkillNameTable[i]][nCurPhase].sSkillTableIndex = sCurSkillIndex;
                                DebugLog("BossDamaged::SetSkillCasting-" + BossSkillNameTable[i] + " " + sCurSkillIndex + " " + nCurPhase);
                            }
                        }
                    }

                    var.EachFloor[BossSkillNameTable[i] + "PhaseNo"] = nCurPhase;
                }
            }
        }

        public object BossRoutine(dynamic owner, dynamic map)
        {
            cExecCheck(owner, "BossRoutine");

            if (map == null)
            {
                ErrorLog("BossRoutine::map == null");
                cAIScriptSet(owner);
                cNPCVanish(owner);
                return eScriptLoopType.SLT_RETURN;
            }

            var var = this[map.Handle];
            if (var == null)
            {
                ErrorLog("BossRoutine::var == null");
                cAIScriptSet(owner);
                cNPCVanish(owner);
                return eScriptLoopType.SLT_RETURN;
            }

            var.RoutineTime[owner.Handle] = cNowTick();

            if (var["Enemy"] == null)
            {
                ErrorLog("BossRoutine::var[\"Enemy\"] == null");
                cAIScriptSet(owner);
                cNPCVanish(owner);
                return eScriptLoopType.SLT_RETURN;
            }

            if (var.Enemy[owner.Handle] == null)
            {
                ErrorLog("BossRoutine::var[\"Enemy\"][" + owner.Handle + "] == null");
                cAIScriptSet(owner);
                cNPCVanish(owner);
                return eScriptLoopType.SLT_RETURN;
            }

            if (cIsObjectDead(owner))
            {
                DebugLog("BossRoutine::BossDead");
                cMobSuicide(map);

                for (int i = 0; i < BossSkillNameTable.Count; i++)
                {
                    var.EachFloor[BossSkillNameTable[i]] = null;
                    var.EachFloor[BossSkillNameTable[i] + "PhaseNo"] = null;
                }

                cAIScriptSet(owner);
                var.Enemy[owner.Handle] = null;
                return eScriptLoopType.SLT_RETURN;
            }

            if (var["EachFloor"] == null)
            {
                ErrorLog("BossRoutine::Var[\"EachFloor\"] == null");
                cAIScriptSet(owner);
                cNPCVanish(owner);
                return eScriptLoopType.SLT_RETURN;
            }

            cAIScriptFunc(owner, "MobDamaged", "BossDamaged");

            for (int i = 0; i < BossSkillNameTable.Count; i++)
            {
                if (var.EachFloor[BossSkillNameTable[i] + "PhaseNo"] != null && var.EachFloor[BossSkillNameTable[i]] != null)
                {
                    for (int j = 0; j < var.EachFloor[BossSkillNameTable[i]].Count; j++)
                    {
                        if (var.EachFloor[BossSkillNameTable[i]][j] == null)
                        {
                            break;
                        }

                        if (var.EachFloor[BossSkillNameTable[i]][j].bCasting)
                        {
                            var sCurSkillTableIndex = var.EachFloor[BossSkillNameTable[i]][j].sSkillTableIndex;

                            var CurFloorNo = (var.EachFloor.StepNumber + 1);
                            var CurFloor = StepNameTable[CurFloorNo];

                            var sBossSkillTableIndex = BossSkillNameTable[i] + "_" + CurFloor;

                            var CurSkillInfo = BossSkill[sBossSkillTableIndex][sCurSkillTableIndex];

                            if (BossSkillNameTable[i] == "Summon")
                            {
                                DebugLog("BossRoutine::StartSkillCasting-" + BossSkillNameTable[i] + " " + sCurSkillTableIndex + " " + j);

                                for (int k = 0; k < CurSkillInfo.SummonMobs.Count; k++)
                                {
                                    cMobRegen_Obj(CurSkillInfo.SummonMobs[k], owner);
                                    DebugLog("BossRoutine::CastSkill-" + BossSkillNameTable[i] + " " + sCurSkillTableIndex + " (" + k + "/" + CurSkillInfo.SummonMobs.Count  + ") :" + CurSkillInfo.SummonMobs[k]);
                                }

                                if (NPC_GuardChat.BossBattleDialog[StepNameTable[CurFloorNo - 1]] != null)
                                {
                                    cMobDialog(var.Owner, NPC_GuardChat.SpeakerIndex, NPC_GuardChat.ScriptFileName, NPC_GuardChat.BossBattleDialog[StepNameTable[CurFloorNo - 1]][j].Index);
                                }
                                else
                                {
                                    ErrorLog("BossRoutine::There is no face-cut at This Floor");
                                }

                                var.EachFloor[BossSkillNameTable[i]][j].bCasting = false;
                                DebugLog("BossRoutine::EndSkillCasting-" + BossSkillNameTable[i] + " " + sCurSkillTableIndex + " " + j);
                            }
                        }
                    }
                }
            }

            return eScriptLoopType.SLT_RETURN;
        }















        //--------------------------------------------------------------------------------
        //--                        Tower Of Iyzel Main                                 --
        //--------------------------------------------------------------------------------

        /// <summary>
        /// Invoked once during script creation - useful for global events to be executed
        /// </summary>
        /// <param name="now">Tick to represent time (CPU cycles since start-up aka milliseconds)</param>
        public void Construct(long now)
        {
            for (var i = 0; i < ID_StepsList.Count; i++)
            {
                ID_StepsIndexList[ID_StepsList[i].Name] = i;
            }
        }

        /// <summary>
        /// Invoked each time the script meets starting conditions (such as players entering the map, or gameobject spawn)
        /// </summary>
        /// <param name="owner">Owner of the script instance (such as the map, or the gameobject)</param>
        /// <param name="now">Tick to represent time (CPU cycles since start-up aka milliseconds)</param>
        public void Start(dynamic owner, long now)
        {

        }

        /// <summary>
        /// Invoked each time the script needs to be reset (such as players leaving the map, or the gameobject being despawn)
        /// It is best to clear any attributes attached to the script (eg: this[owner.Handle] = null)
        /// </summary>
        /// <param name="owner">Owner of the script instance (such as the map, or the gameobject)</param>
        /// <param name="now">Tick to represent time (CPU cycles since start-up aka milliseconds)</param>
        public void Reset(dynamic owner, long now)
        {
            this[owner.Handle] = null;
        }

        /// <summary>
        /// Invoked each time script execution has been stopped (such as cDisableAI())
        /// </summary>
        /// <param name="owner">Owner of the script instance (such as the map, or the gameobject)</param>
        /// <param name="now">Tick to represent time (CPU cycles since start-up aka milliseconds)</param>
        public void Stop(dynamic owner, long now)
        {
            
        }

        /// <summary>
        /// Not used at this stage
        /// </summary>
        /// <param name="now"></param>
        public void Destruct(long now)
        {

        }

        /// <summary>
        /// Main method to be invoked for constant loop (up to 64 times per second) - this method can be shared (eg: the map sets another object to also share the script - typically the map would have called the main at least once before the sharing object)
        /// </summary>
        /// <param name="owner">The invoking object that has called the mainloop</param>
        /// <param name="now">Tick to represent time (CPU cycles since start-up aka milliseconds)</param>
        /// <returns>Whether to block C# execution of AI after the return (such as normal AI patterns - typically blocked when complete control is intended within script)</returns>
        public object Main(dynamic owner, long now)
        {
            dynamic var = this[owner.Handle];

            if (var == null)
            {
                this[owner.Handle] = new CSScriptObject();

                var = this[owner.Handle];
                var.Owner = owner;

                var.Enemy = new CSScriptObject();
                var.Door = new CSScriptObject();
                var.RoutineTime = new CSScriptObject();

                cFieldScriptFunc(var.Owner, "MapLogin", "PlayerMapLogin");

                var.StepFunc = "DummyFunc";

                var.InitialSec = now;
                var.CurSec = now;

                GoToNextStep(var);
            }

            var.CurSec = now;

            cExecFunc(this, var.StepFunc, var);

            return eScriptLoopType.SLT_RETURN;
        }
    }
}