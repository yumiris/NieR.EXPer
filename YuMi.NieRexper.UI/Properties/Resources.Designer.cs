﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YuMi.NieRexper.UI.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("YuMi.NieRexper.UI.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to My Games.
        /// </summary>
        internal static string GamesDirectory {
            get {
                return ResourceManager.GetString("GamesDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NieR_Automata.
        /// </summary>
        internal static string SavesDirectory {
            get {
                return ResourceManager.GetString("SavesDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to N:A Saves (SlotData_*.dat)|SlotData_*.dat.
        /// </summary>
        internal static string SavesFilter {
            get {
                return ResourceManager.GetString("SavesFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AWAITING.
        /// </summary>
        internal static string StatusAwaiting {
            get {
                return ResourceManager.GetString("StatusAwaiting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SUCCESS.
        /// </summary>
        internal static string StatusSuccess {
            get {
                return ResourceManager.GetString("StatusSuccess", resourceCulture);
            }
        }
    }
}