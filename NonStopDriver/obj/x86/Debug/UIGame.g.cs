﻿#pragma checksum "C:\Users\felip\OneDrive\Desktop\Programas\GitHub\TrabajoDSI\NonStopDriver\UIGame.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7477BB7A3872EBBACAC56C4209CAE76C"
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
    partial class UIGame : 
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
            case 2: // UIGame.xaml line 11
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)this.grid).SizeChanged += this.grid_SizeChanged;
                }
                break;
            case 3: // UIGame.xaml line 18
                {
                    this.canvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 4: // UIGame.xaml line 20
                {
                    this.Barra = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5: // UIGame.xaml line 23
                {
                    this.Velocimetro = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 6: // UIGame.xaml line 26
                {
                    this.minimapa = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7: // UIGame.xaml line 29
                {
                    this.dinero = (global::Windows.UI.Xaml.Controls.Image)(target);
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
