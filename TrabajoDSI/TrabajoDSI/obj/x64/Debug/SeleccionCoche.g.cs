﻿#pragma checksum "D:\GitHub\TrabajoDSI\TrabajoDSI\TrabajoDSI\SeleccionCoche.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "49BFDB0EE5FCFB28982EDEECADB00347"
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
    partial class SeleccionCoche : 
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
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SeleccionCoche_obj8_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISeleccionCoche_Bindings
        {
            private global::TrabajoDSI.SelectableCar dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj8;
            private global::Windows.UI.Xaml.Controls.Image obj9;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj9SourceDisabled = false;

            public SeleccionCoche_obj8_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 90 && columnNumber == 72)
                {
                    isobj9SourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 8: // SeleccionCoche.xaml line 89
                        this.obj8 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.GridViewItem)target);
                        break;
                    case 9: // SeleccionCoche.xaml line 90
                        this.obj9 = (global::Windows.UI.Xaml.Controls.Image)target;
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
                            (this.obj8.Target as global::Windows.UI.Xaml.Controls.GridViewItem).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::TrabajoDSI.SelectableCar) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ISeleccionCoche_Bindings

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
                    this.dataRoot = (global::TrabajoDSI.SelectableCar)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TrabajoDSI.SelectableCar obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_image(obj.image, phase);
                    }
                }
            }
            private void Update_image(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SeleccionCoche.xaml line 90
                    if (!isobj9SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj9, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SeleccionCoche_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISeleccionCoche_Bindings
        {
            private global::TrabajoDSI.SeleccionCoche dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj5ItemsSourceDisabled = false;

            private SeleccionCoche_obj1_BindingsTracking bindingsTracking;

            public SeleccionCoche_obj1_Bindings()
            {
                this.bindingsTracking = new SeleccionCoche_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 77 && columnNumber == 58)
                {
                    isobj5ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // SeleccionCoche.xaml line 77
                        this.obj5 = (global::Windows.UI.Xaml.Controls.GridView)target;
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

            // ISeleccionCoche_Bindings

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
                    this.dataRoot = (global::TrabajoDSI.SeleccionCoche)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TrabajoDSI.SeleccionCoche obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ListaCoches(obj.ListaCoches, phase);
                    }
                }
            }
            private void Update_ListaCoches(global::System.Collections.Generic.List<global::TrabajoDSI.SelectableCar> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // SeleccionCoche.xaml line 77
                    if (!isobj5ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj5, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class SeleccionCoche_obj1_BindingsTracking
            {
                private global::System.WeakReference<SeleccionCoche_obj1_Bindings> weakRefToBindingObj; 

                public SeleccionCoche_obj1_BindingsTracking(SeleccionCoche_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<SeleccionCoche_obj1_Bindings>(obj);
                }

                public SeleccionCoche_obj1_Bindings TryGetBindingObject()
                {
                    SeleccionCoche_obj1_Bindings bindingObject = null;
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
            case 2: // SeleccionCoche.xaml line 123
                {
                    this.ImagenCocheSeleccionado = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3: // SeleccionCoche.xaml line 120
                {
                    this.ImagenStatsCocheSeleccionado = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // SeleccionCoche.xaml line 46
                {
                    this.HacePequeñoElContenedorDeLosIconosDeLosJugadores = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5: // SeleccionCoche.xaml line 77
                {
                    this.IconosCoches = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.IconosCoches).ItemClick += this.IconosCoches_ItemClick;
                }
                break;
            case 6: // SeleccionCoche.xaml line 100
                {
                    this.ConfirmButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ConfirmButton).Click += this.ConfirmButton_Click;
                }
                break;
            case 10: // SeleccionCoche.xaml line 53
                {
                    this.IconosJugadores = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 11: // SeleccionCoche.xaml line 59
                {
                    this.JugadoresLadrones = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 12: // SeleccionCoche.xaml line 67
                {
                    this.JugadoresPolicias = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 13: // SeleccionCoche.xaml line 68
                {
                    this.Player5 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 14: // SeleccionCoche.xaml line 69
                {
                    this.Player6 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 15: // SeleccionCoche.xaml line 60
                {
                    this.Player1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 16: // SeleccionCoche.xaml line 61
                {
                    this.Player2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 17: // SeleccionCoche.xaml line 62
                {
                    this.Player3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 18: // SeleccionCoche.xaml line 63
                {
                    this.Player4 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 19: // SeleccionCoche.xaml line 41
                {
                    this.imagenBando = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 20: // SeleccionCoche.xaml line 42
                {
                    this.nombreBando = (global::Windows.UI.Xaml.Controls.Image)(target);
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
            case 1: // SeleccionCoche.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    SeleccionCoche_obj1_Bindings bindings = new SeleccionCoche_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 8: // SeleccionCoche.xaml line 89
                {                    
                    global::Windows.UI.Xaml.Controls.GridViewItem element8 = (global::Windows.UI.Xaml.Controls.GridViewItem)target;
                    SeleccionCoche_obj8_Bindings bindings = new SeleccionCoche_obj8_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element8.DataContext);
                    element8.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element8, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element8, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

