﻿#pragma checksum "..\..\..\Pages\Films.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "51B96B42AB86723C516ED60777291D1DFF4A8992A33AE71A813AAE5CA332C796"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjektWPF.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ProjektWPF.Pages {
    
    
    /// <summary>
    /// Films
    /// </summary>
    public partial class Films : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 30 "..\..\..\Pages\Films.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox viewCompletedFilmsCheckbox;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Pages\Films.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox viewPendingFilmsCheckbox;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Pages\Films.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchFilmInput;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Pages\Films.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid filmsList;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjektWPF;component/pages/films.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Films.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 23 "..\..\..\Pages\Films.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addFilm);
            
            #line default
            #line hidden
            return;
            case 2:
            this.viewCompletedFilmsCheckbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 31 "..\..\..\Pages\Films.xaml"
            this.viewCompletedFilmsCheckbox.Checked += new System.Windows.RoutedEventHandler(this.viewCompletedFilms);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\Pages\Films.xaml"
            this.viewCompletedFilmsCheckbox.Unchecked += new System.Windows.RoutedEventHandler(this.viewCompletedFilms);
            
            #line default
            #line hidden
            return;
            case 3:
            this.viewPendingFilmsCheckbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 64 "..\..\..\Pages\Films.xaml"
            this.viewPendingFilmsCheckbox.Checked += new System.Windows.RoutedEventHandler(this.viewPendingFilms);
            
            #line default
            #line hidden
            
            #line 64 "..\..\..\Pages\Films.xaml"
            this.viewPendingFilmsCheckbox.Unchecked += new System.Windows.RoutedEventHandler(this.viewPendingFilms);
            
            #line default
            #line hidden
            return;
            case 4:
            this.searchFilmInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 99 "..\..\..\Pages\Films.xaml"
            this.searchFilmInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchFilm);
            
            #line default
            #line hidden
            return;
            case 5:
            this.filmsList = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 6:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Primitives.ToggleButton.CheckedEvent;
            
            #line 136 "..\..\..\Pages\Films.xaml"
            eventSetter.Handler = new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Primitives.ToggleButton.UncheckedEvent;
            
            #line 137 "..\..\..\Pages\Films.xaml"
            eventSetter.Handler = new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 7:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.PreviewMouseDoubleClickEvent;
            
            #line 153 "..\..\..\Pages\Films.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.doubleClickOnFilm);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

