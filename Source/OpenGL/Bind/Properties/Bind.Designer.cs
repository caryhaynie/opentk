﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenTK.OpenGL.Bind.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed partial class Bind : global::System.Configuration.ApplicationSettingsBase {
        
        private static Bind defaultInstance = ((Bind)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Bind())));
        
        public static Bind Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GL")]
        public string OutputGLClass {
            get {
                return ((string)(this["OutputGLClass"]));
            }
            set {
                this["OutputGLClass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OpenTK.OpenGL")]
        public string OutputNamespace {
            get {
                return ((string)(this["OutputNamespace"]));
            }
            set {
                this["OutputNamespace"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\Source\\OpenGL\\OpenGL\\Bindings")]
        public string OutputPath {
            get {
                return ((string)(this["OutputPath"]));
            }
            set {
                this["OutputPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\Specifications")]
        public string InputPath {
            get {
                return ((string)(this["InputPath"]));
            }
            set {
                this["InputPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Platform")]
        public string OutputPlatformNamespace {
            get {
                return ((string)(this["OutputPlatformNamespace"]));
            }
            set {
                this["OutputPlatformNamespace"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Imports")]
        public string WriteInternalImportsClass {
            get {
                return ((string)(this["WriteInternalImportsClass"]));
            }
            set {
                this["WriteInternalImportsClass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Enums")]
        public string OutputEnumsClass {
            get {
                return ((string)(this["OutputEnumsClass"]));
            }
            set {
                this["OutputEnumsClass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Context")]
        public string OutputContextClass {
            get {
                return ((string)(this["OutputContextClass"]));
            }
            set {
                this["OutputContextClass"] = value;
            }
        }
    }
}
