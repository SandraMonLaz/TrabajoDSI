﻿#pragma checksum "C:\Universidad\DSI\Trabajo final\TrabajoDSI\TrabajoDSI\TrabajoDSI\Postpartida.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0E09A8138D821896E0E3FECC408354ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrabajoDSI
{
    partial class Postpartida : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Postpartida_obj13_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPostpartida_Bindings
        {
            private global::TrabajoDSI.PlayerInfo dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj13;
            private global::Windows.UI.Xaml.Controls.Image obj14;
            private global::Windows.UI.Xaml.Controls.TextBlock obj15;
            private global::Windows.UI.Xaml.Controls.TextBlock obj16;
            private global::Windows.UI.Xaml.Controls.TextBlock obj17;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj14SourceDisabled = false;
            private static bool isobj15TextDisabled = false;
            private static bool isobj16TextDisabled = false;
            private static bool isobj17TextDisabled = false;

            public Postpartida_obj13_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 219 && columnNumber == 32)
                {
                    isobj14SourceDisabled = true;
                }
                else if (lineNumber == 220 && columnNumber == 166)
                {
                    isobj15TextDisabled = true;
                }
                else if (lineNumber == 221 && columnNumber == 165)
                {
                    isobj16TextDisabled = true;
                }
                else if (lineNumber == 222 && columnNumber == 164)
                {
                    isobj17TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 13: // Postpartida.xaml line 209
                        this.obj13 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 14: // Postpartida.xaml line 219
                        this.obj14 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 15: // Postpartida.xaml line 220
                        this.obj15 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 16: // Postpartida.xaml line 221
                        this.obj16 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 17: // Postpartida.xaml line 222
                        this.obj17 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj13.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::TrabajoDSI.PlayerInfo) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IPostpartida_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::TrabajoDSI.PlayerInfo)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TrabajoDSI.PlayerInfo obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_image(obj.image, phase);
                        this.Update_nombre(obj.nombre, phase);
                        this.Update_coche(obj.coche, phase);
                        this.Update_dinero(obj.dinero, phase);
                    }
                }
            }
            private void Update_image(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Postpartida.xaml line 219
                    if (!isobj14SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj14, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
            private void Update_nombre(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Postpartida.xaml line 220
                    if (!isobj15TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj15, obj, null);
                    }
                }
            }
            private void Update_coche(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Postpartida.xaml line 221
                    if (!isobj16TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj16, obj, null);
                    }
                }
            }
            private void Update_dinero(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Postpartida.xaml line 222
                    if (!isobj17TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj17, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Postpartida_obj19_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPostpartida_Bindings
        {
            private global::TrabajoDSI.PlayerInfo dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj19;
            private global::Windows.UI.Xaml.Controls.Image obj20;
            private global::Windows.UI.Xaml.Controls.TextBlock obj21;
            private global::Windows.UI.Xaml.Controls.TextBlock obj22;
            private global::Windows.UI.Xaml.Controls.TextBlock obj23;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj20SourceDisabled = false;
            private static bool isobj21TextDisabled = false;
            private static bool isobj22TextDisabled = false;
            private static bool isobj23TextDisabled = false;

            public Postpartida_obj19_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 120 && columnNumber == 36)
                {
                    isobj20SourceDisabled = true;
                }
                else if (lineNumber == 121 && columnNumber == 170)
                {
                    isobj21TextDisabled = true;
                }
                else if (lineNumber == 122 && columnNumber == 169)
                {
                    isobj22TextDisabled = true;
                }
                else if (lineNumber == 123 && columnNumber == 168)
                {
                    isobj23TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 19: // Postpartida.xaml line 110
                        this.obj19 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 20: // Postpartida.xaml line 120
                        this.obj20 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 21: // Postpartida.xaml line 121
                        this.obj21 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 22: // Postpartida.xaml line 122
                        this.obj22 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 23: // Postpartida.xaml line 123
                        this.obj23 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj19.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::TrabajoDSI.PlayerInfo) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IPostpartida_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::TrabajoDSI.PlayerInfo)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TrabajoDSI.PlayerInfo obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_image(obj.image, phase);
                        this.Update_nombre(obj.nombre, phase);
                        this.Update_coche(obj.coche, phase);
                        this.Update_dinero(obj.dinero, phase);
                    }
                }
            }
            private void Update_image(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Postpartida.xaml line 120
                    if (!isobj20SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj20, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
            private void Update_nombre(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Postpartida.xaml line 121
                    if (!isobj21TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj21, obj, null);
                    }
                }
            }
            private void Update_coche(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Postpartida.xaml line 122
                    if (!isobj22TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj22, obj, null);
                    }
                }
            }
            private void Update_dinero(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Postpartida.xaml line 123
                    if (!isobj23TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj23, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Postpartida_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPostpartida_Bindings
        {
            private global::TrabajoDSI.Postpartida dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj7;
            private global::Windows.UI.Xaml.Controls.ListView obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj7ItemsSourceDisabled = false;
            private static bool isobj8ItemsSourceDisabled = false;

            private Postpartida_obj1_BindingsTracking bindingsTracking;

            public Postpartida_obj1_Bindings()
            {
                this.bindingsTracking = new Postpartida_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 104 && columnNumber == 17)
                {
                    isobj7ItemsSourceDisabled = true;
                }
                else if (lineNumber == 203 && columnNumber == 49)
                {
                    isobj8ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7: // Postpartida.xaml line 103
                        this.obj7 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 8: // Postpartida.xaml line 203
                        this.obj8 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IPostpartida_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::TrabajoDSI.Postpartida)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TrabajoDSI.Postpartida obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ListaLadrones(obj.ListaLadrones, phase);
                        this.Update_ListaPolicias(obj.ListaPolicias, phase);
                    }
                }
            }
            private void Update_ListaLadrones(global::System.Collections.Generic.List<global::TrabajoDSI.PlayerInfo> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Postpartida.xaml line 103
                    if (!isobj7ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
                    }
                }
            }
            private void Update_ListaPolicias(global::System.Collections.Generic.List<global::TrabajoDSI.PlayerInfo> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Postpartida.xaml line 203
                    if (!isobj8ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj8, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class Postpartida_obj1_BindingsTracking
            {
                private global::System.WeakReference<Postpartida_obj1_Bindings> weakRefToBindingObj; 

                public Postpartida_obj1_BindingsTracking(Postpartida_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<Postpartida_obj1_Bindings>(obj);
                }

                public Postpartida_obj1_Bindings TryGetBindingObject()
                {
                    Postpartida_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                }

            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Postpartida.xaml line 18
                {
                    this.FondoDelantero = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Postpartida.xaml line 34
                {
                    this.dineroLadrones = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // Postpartida.xaml line 50
                {
                    this.NombreGanador = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5: // Postpartida.xaml line 53
                {
                    this.dineroPolicias = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6: // Postpartida.xaml line 72
                {
                    this.ButtonsMenuRematch = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9: // Postpartida.xaml line 268
                {
                    global::Windows.UI.Xaml.Controls.Grid element9 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element9).PointerExited += this.Grid_PointerExited;
                }
                break;
            case 10: // Postpartida.xaml line 276
                {
                    this.ListViewChat = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 11: // Postpartida.xaml line 292
                {
                    this.textBoxChat = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.textBoxChat).KeyDown += this.textBoxChat_KeyDown;
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.textBoxChat).PointerEntered += this.textBoxChat_PointerEntered;
                }
                break;
            case 24: // Postpartida.xaml line 77
                {
                    this.menuButton = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 25: // Postpartida.xaml line 84
                {
                    this.rematchButton = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 26: // Postpartida.xaml line 88
                {
                    this.rematchB = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.rematchB).Click += this.rematchB_Click;
                }
                break;
            case 27: // Postpartida.xaml line 81
                {
                    this.MenuB = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.MenuB).Click += this.MenuB_Click;
                }
                break;
            case 28: // Postpartida.xaml line 66
                {
                    this.Dineropolicias = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 29: // Postpartida.xaml line 47
                {
                    this.DineroLadrones = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
            switch(connectionId)
            {
            case 1: // Postpartida.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Postpartida_obj1_Bindings bindings = new Postpartida_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 13: // Postpartida.xaml line 209
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element13 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    Postpartida_obj13_Bindings bindings = new Postpartida_obj13_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element13.DataContext);
                    element13.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element13, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element13, bindings);
                }
                break;
            case 19: // Postpartida.xaml line 110
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element19 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    Postpartida_obj19_Bindings bindings = new Postpartida_obj19_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element19.DataContext);
                    element19.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element19, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element19, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

