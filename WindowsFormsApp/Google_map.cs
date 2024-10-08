﻿using WindowsFormsApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GoogleMaps.LocationServices;


namespace WindowsFormsApp
{
    public partial class Google_map : Form
    {
        private GMapControl gmap;
        private GMapMarker currentMarker;
        private int id;
        private string type;
        private string comelocation;
        private string locationor;
        private bool state = false;
        public static class GlobalVariables
        {
            public static decimal Latitude { get; set; }
            public static decimal Longitude { get; set; }
        }

        public Google_map()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            try
            {
                var address = txtlocation.Text.ToString();

                // 调试输出，确认地址值
                Console.WriteLine($"Address input: {address}");
                Console.WriteLine($"Locationor value: {locationor}");

                // 检查 txtlocation.Text 是否等于 locationor 的值
                if (address.Equals(locationor, StringComparison.OrdinalIgnoreCase))
                {
                    Main.ShowMessage(Resources.Same_location);
                    return; // 直接返回，不执行后续代码
                }

                var locationService = new GoogleLocationService("Your Google map API key");
                var point = locationService.GetLatLongFromAddress(address);

                if (point != null)
                {
                    txtlatitude.Text = point.Latitude.ToString();
                    txtlongitude.Text = point.Longitude.ToString();

                    // 配置地图
                    map.DragButton = MouseButtons.Left;
                    map.MapProvider = GMapProviders.GoogleMap;
                    double lat = point.Latitude;
                    double longt = point.Longitude;
                    map.Position = new PointLatLng(lat, longt);
                    map.MinZoom = 5;
                    map.MaxZoom = 100;
                    map.Zoom = 10;

                    PointLatLng pointMap = new PointLatLng(lat, longt);
                    GMapMarker marker = new GMarkerGoogle(pointMap, GMarkerGoogleType.red_pushpin);
                    GMapOverlay markers = new GMapOverlay("markers");
                    markers.Markers.Add(marker);
                    map.Overlays.Add(markers);
                }
                else
                {
                    txtlatitude.Text = "Not found";
                    txtlongitude.Text = "Not found";
                }
            }
            catch (WebException webEx)
            {
                Main.ShowMessage($"WebException 发生: {webEx.Message}");
            }
            catch (Exception ex)
            {
                Main.ShowMessage($"发生错误: {ex.Message}");
            }
        }
        public Google_map(int id, string type,string comelocation)
        {
            InitializeComponent();
            this.id = id;
            this.type = type;
            this.comelocation = comelocation;
        }
        public Google_map(string comelocation)
        {
            InitializeComponent();
            this.comelocation = comelocation;
            txtlocation.Text = comelocation;

        }
        private void Google_map_Load(object sender, EventArgs e)
        {
            if (type == "SaleArea")
            {
                String sql = $"SELECT Location FROM SaleArea Where AreaID = {id};";
                using (var reader = Main.db.readBySql(sql))
                {
                    while (reader.Read())
                    {
                        locationor = reader.GetString(0);
                    }
                }
                txtlocation.Text = comelocation;
                if (comelocation == locationor)
                {
                    Main.ShowMessage(Resources.Location_matches_Closing_the_f);
                    state = false;
                    this.Close(); // 关闭当前表单
                    return; // 直接返回，不执行后续代码
                }
            }
        }


        private void map_Load(object sender, EventArgs e)
        {

        }

        private void map_Click(object sender, EventArgs e)
        {

        }
        public bool Getstate()
        {
            return state;
        }

        private void map_OnMapClick(PointLatLng pointClick, MouseEventArgs e)
        {
        }

        private void btncomplete_Click(object sender, EventArgs e)
        {

            // 顯示確認對話框
            if (Main.ShowYesNoDialog(Resources.aysatl))
            {
                // 嘗試將 txtlatitude 和 txtlongitude 的文本內容轉換為 decimal 類型
                try
                {
                    decimal latitude = Convert.ToDecimal(txtlatitude.Text);
                    decimal longitude = Convert.ToDecimal(txtlongitude.Text);

                    // 如果經緯度的值為 0，直接返回
                    if (latitude == 0 && longitude == 0)
                    {
                        Main.ShowYesNoDialog(Resources.The_coordinates_0_0_are_known_);
                        return;
                    }

                    // 檢查經緯度是否在有效範圍內
                    if (latitude < -90 || latitude > 90)
                    {
                        Main.ShowYesNoDialog(Resources.Latitude_must_be_between_90_an);
                        return;
                    }

                    if (longitude < -180 || longitude > 180)
                    {
                        Main.ShowYesNoDialog(Resources.Longitude_must_be_between_180_);
                        return;
                    }

                    GlobalVariables.Latitude = latitude;
                    GlobalVariables.Longitude = longitude;
                    state = true;
                    // 關閉當前窗口
                    this.Close();
                }
                catch (FormatException)
                {
                    // 處理轉換失敗的情況，例如顯示錯誤消息
                    Main.ShowYesNoDialog(Resources.Please_enter_valid_numeric_val);
                }
                catch (OverflowException)
                {
                    // 處理超出 decimal 範圍的情況
                    Main.ShowYesNoDialog(Resources.The_entered_values_are_too_lar);
                }
            }
        }

        private void txtlatitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlongitude_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
