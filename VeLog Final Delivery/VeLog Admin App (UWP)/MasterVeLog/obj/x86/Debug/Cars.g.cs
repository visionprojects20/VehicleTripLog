﻿#pragma checksum "C:\Users\Alex\Documents\Software Engineering Course\AA Group Project 2015-2016\MasterVeLog\MasterVeLog\Cars.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F28371F711EC9D38F02DEA5914B3F4FC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterVeLog
{
    partial class Cars : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.imgLogo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 2:
                {
                    this.imgCar = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3:
                {
                    this.lblCarsAdmin = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.cars = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 41 "..\..\..\Cars.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.cars).Tapped += this.cars_Tapped;
                    #line default
                }
                break;
            case 5:
                {
                    this.btnAddCar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\Cars.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAddCar).Click += this.btnAddCar_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.btnDeleteCar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 36 "..\..\..\Cars.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnDeleteCar).Click += this.btnDeleteCar_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.btnUpdateCar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 37 "..\..\..\Cars.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnUpdateCar).Click += this.btnUpdateCar_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.btnDeselectCar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 38 "..\..\..\Cars.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnDeselectCar).Click += this.btnDeselectCar_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.lblCarId = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.txtCarId = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11:
                {
                    this.lblCarRego = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.txtCarRego = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13:
                {
                    this.lblCarMake = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.txtCarMake = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15:
                {
                    this.lblCarModel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.txtCarModel = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 17:
                {
                    this.lblCarColour = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.txtCarColour = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 19:
                {
                    this.btnClearFilters = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\Cars.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnClearFilters).Click += this.btnClearFilters_Click;
                    #line default
                }
                break;
            case 20:
                {
                    this.btnVehicleLog = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\Cars.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnVehicleLog).Click += this.btnVehicleLog_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
