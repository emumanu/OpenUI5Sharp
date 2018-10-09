using Bridge;
using System;

namespace ClientScripts
{
    #region Strongly Typed Models for Views

    [External]
    [ObjectLiteral]
    public class HomeViewModel
    {
        public bool isPhone;
    }

    [External]
    [ObjectLiteral]
    public class UserLoginInfo
    {
        public string currenUser;
        public DateTime lastLogin;
    }

    #endregion

    #region Strongly Typed Models for the Alerts

    [External]
    [ObjectLiteral]
    public class AlertsModel
    {
        public Alerts alerts { get; set; }
    }

    [External]
    [ObjectLiteral]
    public class Alerts
    {
        public Notification[] notifications { get; set; }
        public Error[] errors { get; set; }
    }

    [External]
    [ObjectLiteral]
    public class Notification
    {
        public string title { get; set; }
        public string description { get; set; }
        public string date { get; set; }
        public string priority { get; set; }
        public string icon { get; set; }
    }

    [External]
    [ObjectLiteral]
    public class Error
    {
        public string title { get; set; }
        public string subTitle { get; set; }
        public string description { get; set; }
        public int counter { get; set; }
    }

    #endregion

    #region Strongly Typed Models for Charts

    [External]
    [ObjectLiteral]
    public class V
    {
        public float v;
    }

    [External]
    [ObjectLiteral]
    public class ChartData
    {
        public V[] ColumnChartData;
        public V[] ColumnChartData2;
        public V[] ComparisonChartData;
        public V[] ComparisonChartData2;
        public V[] PieChartData;
        public V[] PieChartData2;
    }

    #endregion

    #region Strongly Typed Models for the Customers

    [External]
    [ObjectLiteral]
    public class CustomersModel
    {
        public Customer[] customers { get; set; }
    }

    [External]
    [ObjectLiteral]
    public class Customer
    {
        public string name { get; set; }
        public int productId { get; set; }
        public string lastPurchase { get; set; }
        public string payment { get; set; }
        public string state { get; set; }
        public int amount { get; set; }
        public string currencyCode { get; set; }
    }

    #endregion

    #region Strongly Typed Models for the Side Content

    [External]
    [ObjectLiteral]
    public class SideContentsModel
    {
        public Navigation[] navigation { get; set; }
        public Fixednavigation[] fixedNavigation { get; set; }
        public Mastersetting[] masterSettings { get; set; }
    }

    [External]
    [ObjectLiteral]
    public class Navigation
    {
        public string title { get; set; }
        public string icon { get; set; }
        public bool expanded { get; set; }
        public string key { get; set; }
        public Item[] items { get; set; }
    }

    [External]
    [ObjectLiteral]
    public class Item
    {
        public string title { get; set; }
        public string key { get; set; }
    }

    [External]
    [ObjectLiteral]
    public class Fixednavigation
    {
        public string title { get; set; }
        public string icon { get; set; }
        public string key { get; set; }
    }

    [External]
    [ObjectLiteral]
    public class Mastersetting
    {
        public string title { get; set; }
        public string key { get; set; }
        public bool selected { get; set; }
    }

    #endregion
}
