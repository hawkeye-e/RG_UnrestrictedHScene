using BepInEx.Configuration;
using BepInEx.IL2CPP;
using System.Collections.Generic;
using UnityEngine;


namespace UnrestrictedHScene
{
    internal class CustomHPointData
    {
        //Key: MapID, Value: HPointData
        internal static Dictionary<int, List<HPointData>> HPointList;



        //Prepare the data list that will be added when HScene initialized
        internal static void Init()
        {
            
            HPointList = new Dictionary<int, List<HPointData>>();

            AddOfficeWorkplaceHPoints();
            AddOfficePrivateHPoints();
            AddClinicsWorkplaceHPoints();
            AddClinicsPrivateHPoints();
            AddSeminarWorkplaceHPoints();
            AddSeminarPrivateHPoints();
            AddLivehouseWorkplaceHPoints();
            AddLivehousePrivateHPoints();
            AddCasinoWorkplaceHPoints();
            AddCasinoPrivateHPoints();
            AddHomeWorkplaceHPoints();
            AddHomePrivateHPoints();

            AddCafePoints();
            AddRestaurantPoints();
            AddParkPoints();
            AddHotelPoints();

            AddAlleyWorkplacePoints();
            AddAlleyPrivatePoints();
            AddHotSpringWorkplacePoints();
            AddHotSpringPrivatePoints();
            AddSMRoomPoints();
        }

        private static void AddOfficeWorkplaceHPoints()
        {
            List<HPointData> lstOfficeWorkplace = new List<HPointData>();
            lstOfficeWorkplace.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(-35f, 0.0f, 10f), 0, new Vector3(-35f, 0.0f, 10f)));
            lstOfficeWorkplace.Add(new HPointData(901, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(14.3f, 2.0f, -56.6f), 0, new Vector3(13.3f, 6.0f, -54.0f)));
            lstOfficeWorkplace.Add(new HPointData(902, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(-15f, 0.0f, 37.6f), 0f, new Vector3(-15f, 0.0f, 39f)));
            HPointData office4PTable = new HPointData(902, Constant.HPointType.FoursomeTable, "4P_table", new Vector3(-15.6f, 0.0f, 57f), 270f, new Vector3(-17.6f, 7.0f, 57f));
            office4PTable.hideObjName = new List<string>();
            office4PTable.hideObjName.Add("p_rg_chair00_00_06");
            lstOfficeWorkplace.Add(office4PTable);

            HPointList.Add(Constant.MapType.OfficeWorkplace, lstOfficeWorkplace);
        }

        private static void AddOfficePrivateHPoints()
        {
            List<HPointData> lstOfficePrivate = new List<HPointData>();
            lstOfficePrivate.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(8f, 0.0f, 18f), 0, new Vector3(8f, 0.0f, 18f)));
            lstOfficePrivate.Add(new HPointData(901, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(11.0f, 0f, 1.8f), 0, new Vector3(11.3f, 4.1f, 0f)));
            lstOfficePrivate.Add(new HPointData(902, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(-1.0f, 0.0f, 61.6f), 90f, new Vector3(2f, 0.0f, 61.6f)));

            HPointList.Add(Constant.MapType.OfficePrivate, lstOfficePrivate);
        }

        private static void AddClinicsWorkplaceHPoints()
        {
            List<HPointData> lstClinicsWorkplace = new List<HPointData>();
            lstClinicsWorkplace.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(21.0f, 0.0f, -2.0f), 270f, new Vector3(24.0f, 0.0f, 1.0f)));
            lstClinicsWorkplace.Add(new HPointData(901, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(12.7f, 0.0f, -23.7f), 115f, new Vector3(12.7f, 4.1f, -23.7f)));
            lstClinicsWorkplace.Add(new HPointData(902, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(8.0f, 0.0f, 40.1f), 90f, new Vector3(11.0f, 0.0f, 37.1f)));

            HPointList.Add(Constant.MapType.ClinicsWorkplace, lstClinicsWorkplace);
        }

        private static void AddClinicsPrivateHPoints()
        {
            List<HPointData> lstClinicsPrivate = new List<HPointData>();
            lstClinicsPrivate.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(-0.4f, 0.0f, -9.0f), 0, new Vector3(-0.4f, 0.0f, -9.0f)));
            lstClinicsPrivate.Add(new HPointData(901, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(29.7f, 0.0f, -30.0f), 0, new Vector3(26.7f, 0.0f, -30.0f)));
            lstClinicsPrivate.Add(new HPointData(902, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(-12.3f, 0.0f, -0.5f), 0, new Vector3(-12.3f, 4.2f, -1.5f)));
            lstClinicsPrivate.Add(new HPointData(903, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(44.1f, 0.0f, -15.1f), 180f, new Vector3(41.1f, 0.0f, -18.1f)));

            HPointData clinicsPrivate4PTable = new HPointData(904, Constant.HPointType.FoursomeTable, "4P_table", new Vector3(0.5f, 0.0f, -50.7f), 270f, new Vector3(0.2f, 7.0f, -49.2f));
            clinicsPrivate4PTable.hideObjName = new List<string>();
            clinicsPrivate4PTable.hideObjName.Add("p_rg_03_isu00_01");
            clinicsPrivate4PTable.hideObjName.Add("p_rg_03_isu00_00");
            lstClinicsPrivate.Add(clinicsPrivate4PTable);

            HPointList.Add(Constant.MapType.ClinicsPrivate, lstClinicsPrivate);
        }

        private static void AddSeminarWorkplaceHPoints()
        {
            List<HPointData> lstSeminarWorkplace = new List<HPointData>();
            lstSeminarWorkplace.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(-7.4f, 0.0f, 17.2f), 0, new Vector3(-10.4f, 0.0f, 17.2f)));

            HPointData seminar4PSeat = new HPointData(901, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(-14.3f, 0.0f, 0.5f), 180f, new Vector3(-9.4f, 4.0f, -4.5f));
            seminar4PSeat.moveObjects = new List<HPointData.MoveObjectInfo>();
            seminar4PSeat.moveObjects.Add(new HPointData.MoveObjectInfo("p_rg_04_isu00_01", new Vector3(-5.3f, 0.0f, 4.5f), Quaternion.AngleAxis(90f, Vector3.up).eulerAngles));
            lstSeminarWorkplace.Add(seminar4PSeat);
            
            lstSeminarWorkplace.Add(new HPointData(902, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(-0.1f, 0.0f, -43.7f), 0f, new Vector3(-0.1f, 0.0f, -41.6f)));

            HPointData seminar4PTable = new HPointData(903, Constant.HPointType.FoursomeTable, "4P_table", new Vector3(5.1f, 0.0f, 2.2f), 0, new Vector3(5.0f, 7.0f, 2.2f));
            seminar4PTable.moveObjects = new List<HPointData.MoveObjectInfo>();
            seminar4PTable.moveObjects.Add(new HPointData.MoveObjectInfo("p_rg_04_isu00_03", new Vector3(-2f, 0.0f, 0f), Quaternion.AngleAxis(0f, Vector3.up).eulerAngles));
            lstSeminarWorkplace.Add(seminar4PTable);

            HPointList.Add(Constant.MapType.SeminarWorkplace, lstSeminarWorkplace);
        }

        private static void AddSeminarPrivateHPoints()
        {
            List<HPointData> lstSeminarPrivate = new List<HPointData>();
            lstSeminarPrivate.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(-7.1f, 0.0f, -30.9f), 0, new Vector3(-4.1f, 0.0f, -29.4f)));
            lstSeminarPrivate.Add(new HPointData(901, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(6.5f, 0.0f, -14.6f), 270f, new Vector3(4.5f, 4.0f, -14.6f)));
            lstSeminarPrivate.Add(new HPointData(902, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(17.0f, 4.1f, -31.7f), 270f, new Vector3(10.1f, 4.1f, -28.7f)));

            HPointList.Add(Constant.MapType.SeminarPrivate, lstSeminarPrivate);
        }

        private static void AddLivehouseWorkplaceHPoints()
        {
            List<HPointData> lstLivehouseWorkplace = new List<HPointData>();
            lstLivehouseWorkplace.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(-1.8f, 0.0f, -3.4f), 0, new Vector3(-1.8f, 0.0f, -3.4f)));
            lstLivehouseWorkplace.Add(new HPointData(901, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(12.6f, 0.0f, -9.5f), 270f, new Vector3(9.4f, 4.0f, -10.0f)));
            lstLivehouseWorkplace.Add(new HPointData(902, Constant.HPointType.FoursomeSeat, "4P_seat2", new Vector3(12.1f, 0.0f, -19.6f), 270f, new Vector3(8.9f, 4.0f, -19.9f)));
            lstLivehouseWorkplace.Add(new HPointData(903, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(-15.6f, 0.0f, 4.8f), 90f, new Vector3(-12.6f, 0.0f, 1.8f)));

            HPointList.Add(Constant.MapType.LivehouseWorkplace, lstLivehouseWorkplace);
        }

        private static void AddLivehousePrivateHPoints()
        {
            List<HPointData> lstLivehousePrivate = new List<HPointData>();
            lstLivehousePrivate.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(-2.4f, 0.0f, 4.3f), 0, new Vector3(-2.4f, 0.0f, 1.3f)));
            lstLivehousePrivate.Add(new HPointData(902, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(-0.6f, 1.0f, 25.0f), 180f, new Vector3(-0.6f, 1.0f, 20.0f)));

            HPointList.Add(Constant.MapType.LivehousePrivate, lstLivehousePrivate);
        }

        private static void AddCasinoWorkplaceHPoints()
        {
            List<HPointData> lstCasinoWorkplace = new List<HPointData>();
            lstCasinoWorkplace.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(0.0f, 4.0f, -38.0f), 180f, new Vector3(0.0f, 4.0f, -38.0f)));
            lstCasinoWorkplace.Add(new HPointData(901, Constant.HPointType.FoursomeFloor, "4P_floor2", new Vector3(-43.6f, 0.0f, -16.8f), 90f, new Vector3(-43.6f, 0.0f, -19.8f)));
            lstCasinoWorkplace.Add(new HPointData(902, Constant.HPointType.FoursomeFloor, "4P_floor3", new Vector3(58.3f, 0.0f, -24.7f), 270f, new Vector3(58.3f, 0.0f, -27.7f)));
            lstCasinoWorkplace.Add(new HPointData(903, Constant.HPointType.FoursomeFloor, "4P_floor4", new Vector3(-1.1f, 3.0f, -115.1f), 0f, new Vector3(-1.1f, 3.0f, -118.1f)));

            lstCasinoWorkplace.Add(new HPointData(904, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(25.1f, 0.0f, -28.7f), 45f, new Vector3(28.1f, 4.0f, -28.2f)));
            lstCasinoWorkplace.Add(new HPointData(905, Constant.HPointType.FoursomeSeat, "4P_seat2", new Vector3(-23.2f, 0.0f, -27.8f), -45f, new Vector3(-26.6f, 4.0f, -27.9f)));
            lstCasinoWorkplace.Add(new HPointData(906, Constant.HPointType.FoursomeSeat, "4P_seat3", new Vector3(24.2f, 7.0f, -81.4f), 90f, new Vector3(22.7f, 7.0f, -86.3f)));
            
            lstCasinoWorkplace.Add(new HPointData(907, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(79.1f, 0.0f, -33.0f), 270f, new Vector3(76.8f, 0.0f, -33.0f)));
            lstCasinoWorkplace.Add(new HPointData(908, Constant.HPointType.FoursomeWall, "4P_wall2", new Vector3(-86.5f, 0.0f, -5.0f), 180f, new Vector3(-86.5f, 0.0f, -7.5f)));

            var casino4PTable1 = new HPointData(909, Constant.HPointType.FoursomeTable, "4P_table", new Vector3(47.7f, 0.0f, -43.1f), 270f, new Vector3(47.8f, 7.0f, -44.8f));
            casino4PTable1.hideObjName = new List<string>();
            casino4PTable1.hideObjName.Add("p_rg_08_chair01_06");
            casino4PTable1.hideObjName.Add("p_rg_08_chair01_04");
            lstCasinoWorkplace.Add(casino4PTable1);

            var casino4PTable2 = new HPointData(910, Constant.HPointType.FoursomeTable, "4P_table2", new Vector3(-11.7f, 3.0f, -100.6f), 90f, new Vector3(-13.1f, 10.0f, -99.7f));
            casino4PTable2.hideObjName = new List<string>();
            casino4PTable2.hideObjName.Add("p_rg_08_chair01_10");
            //casino4PTable2.hideObjName.Add("p_rg_08_chair01_11");
            lstCasinoWorkplace.Add(casino4PTable2);

            HPointList.Add(Constant.MapType.CasinoWorkplace, lstCasinoWorkplace);
        }

        private static void AddCasinoPrivateHPoints()
        {
            List<HPointData> lstCasinoPrivate = new List<HPointData>();
            lstCasinoPrivate.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(-75.8f, 6.6f, -41.1f), -45f, new Vector3(-75.5f, 6.8f, -39.0f)));
            lstCasinoPrivate.Add(new HPointData(901, Constant.HPointType.FoursomeFloor, "4P_floor2", new Vector3(9.9f, 0.0f, -18.6f), 90f, new Vector3(7.6f, 0.0f, -18.6f)));
            lstCasinoPrivate.Add(new HPointData(902, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(-109.1f, 0.0f, -32.6f), 90f, new Vector3(-109.1f, 4.0f, -32.6f)));
            lstCasinoPrivate.Add(new HPointData(903, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(-14.7f, 0.0f, -30.0f), 0f, new Vector3(-14.7f, 0.0f, -27.0f)));
            
            HPointList.Add(Constant.MapType.CasinoPrivate, lstCasinoPrivate);
        }

        private static void AddHomeWorkplaceHPoints()
        {
            List<HPointData> lstHomeWorkplace = new List<HPointData>();
            lstHomeWorkplace.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(-10.3f, 0.0f, 2.7f), 0, new Vector3(-12.7f, 0.0f, 1.3f)));

            HPointData home4PSeat = new HPointData(901, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(-19.2f, 0.0f, -4.5f), 90f, new Vector3(-20.8f, 4.0f, -0.4f));
            home4PSeat.moveObjects = new List<HPointData.MoveObjectInfo>();
            home4PSeat.moveObjects.Add(new HPointData.MoveObjectInfo("p_rg_10_chair00_00", new Vector3(4.6f, 0.0f, -4.2f), Quaternion.AngleAxis(90f, Vector3.up).eulerAngles));
            lstHomeWorkplace.Add(home4PSeat);

            lstHomeWorkplace.Add(new HPointData(902, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(-10.0f, 0.0f, -21.0f), 270f, new Vector3(-13.0f, 0.0f, -24.0f)));

            var home4PTable = new HPointData(903, Constant.HPointType.FoursomeTable, "4P_table", new Vector3(-22.7f, 0.0f, 4.8f), 90f, new Vector3(-23.0f, 7.0f, 6.1f));
            home4PTable.hideObjName = new List<string>();
            home4PTable.hideObjName.Add("p_rg_10_chair00_00");
            home4PTable.hideObjName.Add("p_rg_10_chair00_03");
            lstHomeWorkplace.Add(home4PTable);

            lstHomeWorkplace.Add(new HPointData(904, Constant.HPointType.Stairs, "stairs", new Vector3(14.6f, 4.2f, -41.1f), 270f, new Vector3(14.6f, 4.2f, -41.1f)));

            HPointList.Add(Constant.MapType.HomeWorkplace, lstHomeWorkplace);
        }

        private static void AddHomePrivateHPoints()
        {
            List<HPointData> lstHomePrivate = new List<HPointData>();
            lstHomePrivate.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(1.5f, 0.0f, -18.4f), 0f, new Vector3(1.3f, 0.0f, -21.3f)));
            lstHomePrivate.Add(new HPointData(901, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(11.6f, 0.0f, -9.8f), 270f, new Vector3(13.7f, 4.2f, -9.8f)));

            var home4PWall = new HPointData(902, Constant.HPointType.FoursomeWall, "4P_Wall", new Vector3(-2.3f, 0.0f, 19.0f), 180f, new Vector3(0.7f, 0.0f, 16.0f));
            home4PWall.hideObjName = new List<string>();
            home4PWall.hideObjName.Add("map_Object04");
            lstHomePrivate.Add(home4PWall);

            HPointList.Add(Constant.MapType.HomePrivate, lstHomePrivate);
        }

        private static void AddCafePoints()
        {
            List<HPointData> lstCafe = new List<HPointData>();
            lstCafe.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(12.8f, 0.0f, -23.6f), 0f, new Vector3(15.3f, 0.0f, -25.1f)));

            HPointData cafe4PSeat = new HPointData(901, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(21.1f, 0.0f, 26.3f), 225f, new Vector3(23.7f, 4.1f, 27.7f));
            cafe4PSeat.moveObjects = new List<HPointData.MoveObjectInfo>();
            cafe4PSeat.moveObjects.Add(new HPointData.MoveObjectInfo("p_rg_12_chair00_05", new Vector3(-3.7f, 0.0f, -2.9f), Quaternion.AngleAxis(225f, Vector3.up).eulerAngles));
            lstCafe.Add(cafe4PSeat);

            lstCafe.Add(new HPointData(902, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(4.2f, 0.0f, 51.9f), 180f, new Vector3(4.2f, 0.0f, 46.9f)));

            var cafe4PTable = new HPointData(903, Constant.HPointType.FoursomeTable, "4P_table", new Vector3(23.8f, 0.0f, 33.9f), 180f, new Vector3(23.8f, 7.0f, 32.6f));
            cafe4PTable.hideObjName = new List<string>();
            cafe4PTable.hideObjName.Add("p_rg_12_chair00_03");
            cafe4PTable.hideObjName.Add("p_rg_12_chair00_05");
            cafe4PTable.hideObjName.Add("p_rg_12_chair00_07");
            lstCafe.Add(cafe4PTable);

            HPointList.Add(Constant.MapType.Cafe, lstCafe);
        }

        private static void AddRestaurantPoints()
        {
            List<HPointData> lstRestaurant = new List<HPointData>();
            lstRestaurant.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(20.9f, 0.0f, -12.9f), 0f, new Vector3(20.9f, 0.0f, -12.9f)));

            HPointData restaurant4PSeat = new HPointData(901, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(46.7f, 0.0f, -12.9f), 180f, new Vector3(46.2f, 3.1f, -1.0f));
            restaurant4PSeat.moveObjects = new List<HPointData.MoveObjectInfo>();
            restaurant4PSeat.moveObjects.Add(new HPointData.MoveObjectInfo("p_rg_13_chair00_06", new Vector3(-1.0f, 1.0f, -11.9f), Quaternion.AngleAxis(135f, Vector3.up).eulerAngles));
            lstRestaurant.Add(restaurant4PSeat);

            lstRestaurant.Add(new HPointData(902, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(-27.8f, 0.0f, -4.8f), 90f, new Vector3(-24.8f, 0.0f, -4.8f)));

            var restaurant4PTable = new HPointData(903, Constant.HPointType.FoursomeTable, "4P_table", new Vector3(66.3f, 2.0f, -42.2f), 180f, new Vector3(67.0f, 9.0f, -42.8f));
            restaurant4PTable.hideObjName = new List<string>();
            restaurant4PTable.hideObjName.Add("p_rg_13_chair00_10");
            restaurant4PTable.hideObjName.Add("p_rg_13_chair00_11");
            restaurant4PTable.hideObjName.Add("table_item03");
            
            lstRestaurant.Add(restaurant4PTable);

            lstRestaurant.Add(new HPointData(904, Constant.HPointType.Stairs, "stairs", new Vector3(79.3f, -5.4f, 40.4f), 90f, new Vector3(80.0f, -4.0f, 40.4f)));

            HPointList.Add(Constant.MapType.Restaurant, lstRestaurant);
        }

        private static void AddParkPoints()
        {
            List<HPointData> lstPark = new List<HPointData>();
            lstPark.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(29.1f, 0.0f, -28.6f), 0f, new Vector3(29.1f, 0.0f, -28.6f)));
            lstPark.Add(new HPointData(901, Constant.HPointType.FoursomeFloor, "4P_floor2", new Vector3(126.4f, 0.0f, 114.7f), 0f, new Vector3(126.4f, 0.0f, 114.7f)));
            lstPark.Add(new HPointData(902, Constant.HPointType.FoursomeFloor, "4P_floor3", new Vector3(-27.5f, 0.0f, 22.2f), 90f, new Vector3(-27.5f, 0.0f, 22.2f)));

            lstPark.Add(new HPointData(903, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(48.6f, 0.0f, 45.7f), 45f, new Vector3(50.8f, 4.0f, 43.3f)));
            lstPark.Add(new HPointData(904, Constant.HPointType.FoursomeSeat, "4P_seat2", new Vector3(49.1f, 0.0f, -58.6f), 25f, new Vector3(53.2f, 4.0f, -60.1f)));
            lstPark.Add(new HPointData(905, Constant.HPointType.FoursomeSeat, "4P_seat3", new Vector3(7.2f, 0.0f, 8.0f), 225f, new Vector3(4.7f, 4.0f, 10.4f)));

            lstPark.Add(new HPointData(906, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(-70.2f, 0.0f, -4.7f), 60f, new Vector3(-66.0f, 0.0f, -4.7f )));
            lstPark.Add(new HPointData(907, Constant.HPointType.FoursomeWall, "4P_wall2", new Vector3(99.9f, 0.0f, -49.2f), 270f, new Vector3(96.9f, 0.2f, -44.2f)));

            var park4PTable = new HPointData(908, Constant.HPointType.FoursomeTable, "4P_table", new Vector3(31.3f, 0.0f, -14.1f), 135f, new Vector3(31.3f, 7.0f, -14.1f));
            park4PTable.hideObjName = new List<string>();
            park4PTable.hideObjName.Add("p_rg_14_chair00_05");
            park4PTable.hideObjName.Add("p_rg_14_chair00_06");
            park4PTable.hideObjName.Add("p_rg_14_chair00_07");
            lstPark.Add(park4PTable);

            HPointList.Add(Constant.MapType.Park, lstPark);
        }

        private static void AddHotelPoints()
        {
            List<HPointData> lstHotel = new List<HPointData>();
            lstHotel.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(9.2f, 6.2f, -39.2f), -45f, new Vector3(11.8f, 6.2f, -38.9f)));
            lstHotel.Add(new HPointData(901, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(8.8f, 0.0f, -3.2f), 0f, new Vector3(11.8f, 4.0f, -5.0f)));

            var hotel4PWall = new HPointData(902, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(35.9f, 0.0f, 7.6f), 270f, new Vector3(32.9f, 0.0f, 7.6f));
            hotel4PWall.hideObjName = new List<string>();
            hotel4PWall.hideObjName.Add("p_rg_05_maruisu00_00");
            lstHotel.Add(hotel4PWall);

            var hotel4PTable = new HPointData(903, Constant.HPointType.FoursomeTable, "4P_table", new Vector3(-6.4f, 0.0f, 7.6f), 180f, new Vector3(-12.4f, 6.8f, 7.5f));
            hotel4PTable.hideObjName = new List<string>();
            hotel4PTable.hideObjName.Add("p_rg_15_chair00_00");
            hotel4PTable.hideObjName.Add("p_rg_15_chair00_01");

            hotel4PTable.moveObjects = new List<HPointData.MoveObjectInfo>();
            hotel4PTable.moveObjects.Add(new HPointData.MoveObjectInfo("p_rg_15_table00_00", new Vector3(6.0f, 0.0f, 1.8f), Quaternion.AngleAxis(0f, Vector3.up).eulerAngles));
            lstHotel.Add(hotel4PTable);

            HPointList.Add(Constant.MapType.Hotel, lstHotel);
        }

        private static void AddAlleyWorkplacePoints()
        {
            List<HPointData> lstAlleyWorkplace = new List<HPointData>();
            lstAlleyWorkplace.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(40.6f, 0.0f, 11.7f), 0f, new Vector3(37.6f, 0.0f, 11.7f)));
            
            var alley4PSeat = new HPointData(901, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(-25.4f, 0.0f, 14.9f), 270f, new Vector3(-16.4f, 4.0f, 14.2f));
            alley4PSeat.moveObjects = new List<HPointData.MoveObjectInfo>();
            alley4PSeat.moveObjects.Add(new HPointData.MoveObjectInfo("p_rg_20_chair00_09", new Vector3(-10.2f, 0.0f, 1.0f), Quaternion.AngleAxis(0f, Vector3.up).eulerAngles));
            lstAlleyWorkplace.Add(alley4PSeat);            

            HPointList.Add(Constant.MapType.AlleyWorkplace, lstAlleyWorkplace);
        }

        private static void AddAlleyPrivatePoints()
        {
            List<HPointData> lstAlleyPrivate = new List<HPointData>();
            lstAlleyPrivate.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(-9.1f, 0.0f, -15.4f), 270f, new Vector3(-9.1f, 0.0f, -15.4f)));
            lstAlleyPrivate.Add(new HPointData(901, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(-30.0f, 0.0f, -27.5f), 0f, new Vector3(-28.9f, 4.0f, -29.4f)));
            lstAlleyPrivate.Add(new HPointData(902, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(-13.7f, 0.0f, 7.0f), 90f, new Vector3(-10.7f, 0.0f, 7.0f)));

            HPointList.Add(Constant.MapType.AlleyPrivate, lstAlleyPrivate);
        }

        private static void AddHotSpringWorkplacePoints()
        {
            List<HPointData> lstHotSpringWorkplace = new List<HPointData>();
            lstHotSpringWorkplace.Add(new HPointData(900, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(-15.1f, 0.0f, -32.9f), 90f, new Vector3(-12.1f, 0.0f, -29.9f)));
            lstHotSpringWorkplace.Add(new HPointData(901, Constant.HPointType.FoursomeWall, "4P_wall2", new Vector3(16.1f, 0.0f, -32.9f), 270f, new Vector3(13.1f, 0.0f, -29.9f)));
            lstHotSpringWorkplace.Add(new HPointData(902, Constant.HPointType.FoursomeWall, "4P_wall3", new Vector3(-57.6f, 0.0f, 50.8f), 180f, new Vector3(-60.6f, 0.0f, 47.8f)));
            lstHotSpringWorkplace.Add(new HPointData(903, Constant.HPointType.FoursomeWall, "4P_wall4", new Vector3(-50.9f, 0.0f, 62.6f), 90f, new Vector3(-47.9f, 0.0f, 59.6f)));


            //Chair is not displaying, asset not loaded for that map???
            var hotspring4PTable = new HPointData(904, Constant.HPointType.FoursomeTable, "4P_table", new Vector3(73.5f, 0.0f, 9.2f), 270f, new Vector3(73.5f, 6.7f, 8.2f));
            hotspring4PTable.hideObjName = new List<string>();
            hotspring4PTable.hideObjName.Add("p_rg_22_isu02_00");
            hotspring4PTable.hideObjName.Add("p_rg_22_isu02_02");
            hotspring4PTable.hideObjName.Add("p_rg_22_isu02_03");
            hotspring4PTable.hideObjName.Add("p_rg_20_hasi02_03");
            hotspring4PTable.motionChairID = 20;
            lstHotSpringWorkplace.Add(hotspring4PTable);

            HPointList.Add(Constant.MapType.HotSpringWorkplace, lstHotSpringWorkplace);
        }

        private static void AddHotSpringPrivatePoints()
        {
            List<HPointData> lstHotSpringPrivate = new List<HPointData>();
            lstHotSpringPrivate.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(-0.1f, 0.0f, 12.7f), 0f, new Vector3(-1.6f, 0.2f, 9.8f)));

            var hotspringPrivate4PSeat = new HPointData(901, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(-2.5f, 0.0f, -17.5f), 0f, new Vector3(-7.8f, 4.0f, -32.5f));
            hotspringPrivate4PSeat.moveObjects = new List<HPointData.MoveObjectInfo>();
            hotspringPrivate4PSeat.moveObjects.Add(new HPointData.MoveObjectInfo("p_rg_23_isu00_01", new Vector3(5.5f, 0.0f, 15.7f), Quaternion.AngleAxis(270f, Vector3.up).eulerAngles));
            lstHotSpringPrivate.Add(hotspringPrivate4PSeat);

            var hotspringPrivate4PWall = new HPointData(902, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(-33.3f, 0.0f, 21.0f), 0f, new Vector3(-33.3f, 0.0f, 27.6f));
            hotspringPrivate4PWall.hideObjName = new List<string>();
            hotspringPrivate4PWall.hideObjName.Add("p_rg_05_kago00_00");
            lstHotSpringPrivate.Add(hotspringPrivate4PWall);

            //Chair is not displaying, asset not loaded for that map???
            var hotspringPrivate4PTable = new HPointData(903, Constant.HPointType.FoursomeTable, "4P_table", new Vector3(-3.8f, 0.0f, -32.5f), 270f, new Vector3(-3.8f, 7.0f, -32.5f));
            hotspringPrivate4PTable.hideObjName = new List<string>();
            hotspringPrivate4PTable.hideObjName.Add("p_rg_23_isu00_00");
            hotspringPrivate4PTable.hideObjName.Add("p_rg_23_isu00_01");
            hotspringPrivate4PTable.motionChairID = 20;
            lstHotSpringPrivate.Add(hotspringPrivate4PTable);

            HPointList.Add(Constant.MapType.HotSpringPrivate, lstHotSpringPrivate);
        }

        private static void AddSMRoomPoints()
        {
            List<HPointData> lstSMRoom = new List<HPointData>();
            lstSMRoom.Add(new HPointData(900, Constant.HPointType.FoursomeFloor, "4P_floor", new Vector3(12.6f, 6.6f, -18.8f), 0f, new Vector3(9.6f, 6.6f, -20.3f)));
            lstSMRoom.Add(new HPointData(901, Constant.HPointType.FoursomeSeat, "4P_seat", new Vector3(47.6f, 0.0f, 23.7f), 0f, new Vector3(47.6f, 4.0f, 23.7f)));
            lstSMRoom.Add(new HPointData(902, Constant.HPointType.FoursomeWall, "4P_wall", new Vector3(33.8f, 0.0f, 14.0f), 180f, new Vector3(33.8f, 0.0f, 9.7f)));


            var SMRoom4PTable = new HPointData(903, Constant.HPointType.FoursomeTable, "4P_table", new Vector3(-12.5f, 0.0f, 33.0f), 90f, new Vector3(-11.8f, 7.0f, 33.6f));
            SMRoom4PTable.hideObjName = new List<string>();
            SMRoom4PTable.hideObjName.Add("p_rg_24_isu00_00");
            SMRoom4PTable.hideObjName.Add("p_rg_24_isu00_01");
            SMRoom4PTable.motionChairID = 20;
            lstSMRoom.Add(SMRoom4PTable);

            HPointList.Add(Constant.MapType.SMRoom, lstSMRoom);
        }

        internal static string GetHPointParentNameByGroupType(int type)
        {
            if (type == Constant.HPointType.FoursomeFloor) return "4p_floor_parent_by_mod";
            else if (type == Constant.HPointType.FoursomeSeat) return "4p_seat_parent_by_mod";
            else if (type == Constant.HPointType.FoursomeWall) return "4p_wall_parent_by_mod";
            else if (type == Constant.HPointType.FoursomeTable) return "4p_table_parent_by_mod";
            else return "custom_point_default_by_mod";
        }


        internal class HPointData
        {
            internal int hPointID;
            internal int hPointGroup;
            internal string hPointName;
            internal Vector3 position;
            internal Vector3 markerPosition;
            internal float rotation;
            internal List<string> hideObjName;
            internal List<HPointData.MoveObjectInfo> moveObjects;
            internal bool isWet = false;
            internal int motionChairID = -1;
            internal bool isSpecialHPoint = true;

            internal HPointData(int hPointID, int hPointGroup, string hPointName, Vector3 position, float rotation, Vector3 markerPosition)
            {
                this.hPointID = hPointID;
                this.hPointGroup = hPointGroup;
                this.hPointName = hPointName;
                this.position = position;
                this.rotation = rotation;
                this.markerPosition = markerPosition;
                
            }

            internal class MoveObjectInfo
            {
                internal string objectName;
                internal Vector3 position;
                internal Vector3 angle;

                internal MoveObjectInfo() { }

                internal MoveObjectInfo(string objectName, Vector3 position, Vector3 angle)
                {
                    this.objectName = objectName;
                    this.position = position;
                    this.angle = angle;
                }
            }
        }

        
    }
}
