﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IISExpressManager.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("IISExpressManager.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap blank_icon {
            get {
                object obj = ResourceManager.GetObject("blank_icon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap browser_icon {
            get {
                object obj = ResourceManager.GetObject("browser_icon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Severe Error. It looks like your IISExpress is corrupted.
        ///Please reinstall IISExpress
        ///IISEM will close now..
        /// </summary>
        internal static string IISProcessManager_ExecuteProcess_ErrorMessage {
            get {
                return ResourceManager.GetString("IISProcessManager_ExecuteProcess_ErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Alert!.
        /// </summary>
        internal static string IISProcessManager_ExecuteProcess_ErrorMessageTitle {
            get {
                return ResourceManager.GetString("IISProcessManager_ExecuteProcess_ErrorMessageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Double click on any item to start it!.
        /// </summary>
        internal static string MainForm_Double_click_Help_Message {
            get {
                return ResourceManager.GetString("MainForm_Double_click_Help_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Abort!.
        /// </summary>
        internal static string Program_Main_Abort_Header {
            get {
                return ResourceManager.GetString("Program_Main_Abort_Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IIS Express not installed or configuration not found!.
        /// </summary>
        internal static string Program_Main_IIS_Express_not_installed_or_configuration_not_found_Message {
            get {
                return ResourceManager.GetString("Program_Main_IIS_Express_not_installed_or_configuration_not_found_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You can only have one instance of IISEM running..
        /// </summary>
        internal static string Program_Main_SingleInstance_ErrorMessage {
            get {
                return ResourceManager.GetString("Program_Main_SingleInstance_ErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning!.
        /// </summary>
        internal static string Program_Main_Warning_Header {
            get {
                return ResourceManager.GetString("Program_Main_Warning_Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap start {
            get {
                object obj = ResourceManager.GetObject("start", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap stop {
            get {
                object obj = ResourceManager.GetObject("stop", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
