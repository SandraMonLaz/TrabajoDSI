﻿#pragma checksum "C:\Users\felip\OneDrive\Desktop\Programas\GitHub\TrabajoDSI\NonStopDriver\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "93918F6A7C7D468F84C6E32BAD22C85D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NonStopDriver
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 11
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)this.grid).SizeChanged += this.grid_SizeChanged;
                }
                break;
            case 3: // MainPage.xaml line 15
                {
                    this.wideState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4: // MainPage.xaml line 20
                {
                    this.narrowState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5: // MainPage.xaml line 47
                {
                    this.map = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 6: // MainPage.xaml line 49
                {
                    this.Canvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 7: // MainPage.xaml line 65
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).PointerEntered += this.button_PointerEntered;
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).PointerExited += this.button_PointerExited;
                }
                break;
            case 8: // MainPage.xaml line 80
                {
                    this.Lugares = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 9: // MainPage.xaml line 58
                {
                    this.Policia = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

