﻿#pragma checksum "C:\Users\Cate\documents\visual studio 2015\Projects\App1\App1\Module4.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1CB98233EAAD7B89BED174A251BA841E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class Module4 : 
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
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 2:
                {
                    this.textBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.btnSubmit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\Module4.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSubmit).Click += this.Submit_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.txtBoxItem = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.btnRefresh = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\Module4.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnRefresh).Click += this.btnRefresh_Click_1;
                    #line default
                }
                break;
            case 6:
                {
                    this.ListItems = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 7:
                {
                    this.buttonHome = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\Module4.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonHome).Click += this.buttonHome_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.txtBoxFooter = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.CheckBox element9 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 24 "..\..\..\Module4.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element9).Checked += this.CheckBoxComplete_Checked;
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

