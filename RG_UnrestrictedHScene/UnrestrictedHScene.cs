using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using BepInEx.IL2CPP;
using RG.Scene;
using RG.Scene.Action.Core;
using RG.Scripts;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnrestrictedHScene
{
    [BepInProcess("RoomGirl")]
    [BepInPlugin(GUID, PluginName, Version)]
    public class UnrestrictedHScenePlugin : BasePlugin
    {
        public const string PluginName = "UnrestrictedHScene";
        public const string GUID = "hawk.RG.UnrestrictedHScene";
        public const string Version = "0.1.0";

        internal static new ManualLogSource Log;

        public override void Load()
        {
            Log = base.Log;

            UnrestrictedHScene.Config.Init(this);

            if (UnrestrictedHScene.Config.Enabled)
            {
                CustomHPointData.Init();
                Harmony.CreateAndPatchAll(typeof(Hooks), GUID);
            }
        }

        private static class Hooks
        {
            private static bool IsInitDone = false;

            //Remove the restriction of position that only set in new expansion maps
            [HarmonyPostfix]
            [HarmonyPatch(typeof(TitleScene), nameof(TitleScene.ShowBtnsBG))]
            private static void ShowBtnsBG()
            {
                if (!IsInitDone)
                {

                    for (int i = 0; i < Manager.HSceneManager.Instance.hResourceTables.LstAnimInfo.Count; i++)
                    {
                        foreach (var info in Manager.HSceneManager.Instance.hResourceTables.LstAnimInfo[i])
                        {
                            if (info.LimitMap != null)
                            {
                                if (info.LimitMap[0] >= 20)
                                    info.LimitMap[0] = -1;
                            }

                        }
                    }

                    IsInitDone = true;
                }

            }

            //[HarmonyPostfix]
            //[HarmonyPatch(typeof(RG.Scene.Action.ActionMap), nameof(RG.Scene.Action.ActionMap.InitializeActionPoint))]
            //private static void InitializeActionPoint()
            //{
            //}

            //Inject the HPoints to the map
            [HarmonyPostfix]
            [HarmonyPatch(typeof(HPointList), nameof(HPointList.Init))]
            private static void Init(HPointList __instance)
            {
                if (CustomHPointData.HPointList.ContainsKey(Manager.HSceneManager.Instance.MapID))
                {
                    Dictionary<int, HPointList.PlaceInfo> lstAddPlaceInfo = new Dictionary<int, HPointList.PlaceInfo>();

                    //special point should exists in all maps and with marker position object. we clone that and add our own custom HPoint.
                    HPoint toClone = __instance.Lst[9].HPoints[0];

                    System.Collections.Generic.List<CustomHPointData.HPointData> lstToAddPoint = CustomHPointData.HPointList[Manager.HSceneManager.Instance.MapID];
                    foreach (var pointData in lstToAddPoint)
                    {
                        if (!lstAddPlaceInfo.ContainsKey(pointData.hPointGroup))
                        {
                            //handle the point group
                            HPointList.HPointPlaceInfo info = new HPointList.HPointPlaceInfo();
                            info.HPoints = new List<HPoint>();
                            info.MarkerETC = true;
                            __instance.Lst.Add(pointData.hPointGroup, info);

                            GameObject hPointParent = Object.Instantiate(__instance._hpointGroup[0].HPoints);
                            hPointParent.name = CustomHPointData.GetHPointParentNameByGroupType(pointData.hPointGroup);
                            hPointParent.transform.DetachChildren();

                            HPointList.PlaceInfo placeInfo = new HPointList.PlaceInfo();
                            placeInfo.MarkerETC = true;
                            placeInfo.Place = pointData.hPointGroup;
                            placeInfo.HPoints = hPointParent;

                            lstAddPlaceInfo.Add(pointData.hPointGroup, placeInfo);
                        }

                        //handle the point data
                        HPoint hp = Object.Instantiate(toClone);

                        hp.ID = pointData.hPointID;
                        hp.name = pointData.hPointName;
                        hp.WetPoint = pointData.isWet;
                        hp.transform.position = pointData.position;
                        hp.transform.rotation = Quaternion.AngleAxis(pointData.rotation, Vector3.up);
                        hp.MarkerPos.position = pointData.markerPosition;
                        hp.transform.parent = lstAddPlaceInfo[pointData.hPointGroup].HPoints.transform;

                        //Fix the chair missing issue in some maps
                        if (pointData.motionChairID != -1 && hp.MotionChairIDs != null && hp.MotionChairIDs.Count > 0)
                        {
                            hp.MotionChairIDs[0] = pointData.motionChairID;
                        }

                        //Set the world objects that need to be hidden
                        if (pointData.hideObjName != null)
                        {
                            hp._hideObj = new UnhollowerBaseLib.Il2CppReferenceArray<GameObject>(pointData.hideObjName.Count);
                            hp._hideObjNames = new UnhollowerBaseLib.Il2CppStringArray(pointData.hideObjName.Count);

                            int i = 0;
                            foreach (var objName in pointData.hideObjName)
                            {
                                var obj = GameObject.Find(objName);
                                hp._hideObj[i] = obj;
                                hp._hideObjNames[i] = obj.name;
                                i++;
                            }
                        }

                        //Set the world objects that need to be moved
                        if (pointData.moveObjects != null)
                        {
                            hp._moveObjects = new UnhollowerBaseLib.Il2CppReferenceArray<HPoint.MoveObjectSet>(pointData.moveObjects.Count);
                            int i = 0;
                            foreach (var moveInfo in pointData.moveObjects)
                            {
                                HPoint.MoveObjectSet infoToAdd = new HPoint.MoveObjectSet();

                                var obj = GameObject.Find(moveInfo.objectName);
                                infoToAdd.BasePos = obj.transform.position;
                                infoToAdd.BaseRot = obj.transform.rotation.eulerAngles;
                                infoToAdd.MoveObj = obj;
                                infoToAdd.MoveObjName = moveInfo.objectName;

                                infoToAdd.OffSetInfos = new UnhollowerBaseLib.Il2CppReferenceArray<HPoint.MoveOffSetInfo>(1);
                                HPoint.MoveOffSetInfo offSetInfo = new HPoint.MoveOffSetInfo();
                                offSetInfo.Pos = moveInfo.position;
                                offSetInfo.Ang = moveInfo.angle;
                                offSetInfo.UsePos = true;
                                offSetInfo.UseAng = true;
                                infoToAdd.OffSetInfos[0] = offSetInfo;

                                hp._moveObjects[i] = infoToAdd;
                                i++;
                            }
                        }

                        __instance.Lst[pointData.hPointGroup].HPoints.Add(hp);
                    }

                    //Alter the hpoint group list
                    UnhollowerBaseLib.Il2CppReferenceArray<HPointList.PlaceInfo> newinfo = new UnhollowerBaseLib.Il2CppReferenceArray<HPointList.PlaceInfo>(__instance._hpointGroup.Length + lstAddPlaceInfo.Count);

                    for (int i = 0; i < __instance._hpointGroup.Count; i++)
                    {
                        newinfo[i] = __instance._hpointGroup[i];
                    }

                    int counter = __instance._hpointGroup.Count;
                    foreach (var placeInfo in lstAddPlaceInfo)
                    {
                        newinfo[counter] = placeInfo.Value;
                        counter++;
                    }

                    __instance._hpointGroup = newinfo;
                }
            }

        }
    }
}
