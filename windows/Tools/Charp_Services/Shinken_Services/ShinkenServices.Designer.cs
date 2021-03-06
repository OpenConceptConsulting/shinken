﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShinkenGeneralService {
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
    internal class ShinkenServices {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ShinkenServices() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ShinkenGeneralService.ShinkenServices", typeof(ShinkenServices).Assembly);
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
        ///   Looks up a localized string similar to Arbiter command not set in parameters of the configuration file.
        /// </summary>
        internal static string Err_ArbiterSrv_Conf_Parameters_String {
            get {
                return ResourceManager.GetString("Err_ArbiterSrv_Conf_Parameters_String", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Broker command not set in parameters of the configuration file.
        /// </summary>
        internal static string Err_BrokerSrv_Conf_Parameters_String {
            get {
                return ResourceManager.GetString("Err_BrokerSrv_Conf_Parameters_String", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to use culture {0}.
        /// </summary>
        internal static string Err_CultureUsing {
            get {
                return ResourceManager.GetString("Err_CultureUsing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception thrown,message returned is :.
        /// </summary>
        internal static string Err_ExceptionThrown {
            get {
                return ResourceManager.GetString("Err_ExceptionThrown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception thrown in GetConf() method for the service {0},message is : {1}.
        /// </summary>
        internal static string Err_GetConf {
            get {
                return ResourceManager.GetString("Err_GetConf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Python launcher (or associated command) is empty in the configuration file for the Shinken service.
        /// </summary>
        internal static string Err_Python_Launcher_Empty {
            get {
                return ResourceManager.GetString("Err_Python_Launcher_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service object not ready, message received : {0}.
        /// </summary>
        internal static string Err_ServiceObject_IsNotReady {
            get {
                return ResourceManager.GetString("Err_ServiceObject_IsNotReady", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No python path reference in the configuration file for he Shinken service.
        /// </summary>
        internal static string Err_Srv_Conf_Python {
            get {
                return ResourceManager.GetString("Err_Srv_Conf_Python", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service {0}, an exception thrown during stop sequence, message is : {1}.
        /// </summary>
        internal static string Err_SrvStopException {
            get {
                return ResourceManager.GetString("Err_SrvStopException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service {0} stopping but its state cannot be checked.
        /// </summary>
        internal static string Err_SrvStopPending {
            get {
                return ResourceManager.GetString("Err_SrvStopPending", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Service {0} exited unexpectedly.
        /// </summary>
        internal static string SrvExited {
            get {
                return ResourceManager.GetString("SrvExited", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Service {0} start with the PID {1}.
        /// </summary>
        internal static string SrvPID {
            get {
                return ResourceManager.GetString("SrvPID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Service {0} cannot start.
        /// </summary>
        internal static string SrvPID_NOK {
            get {
                return ResourceManager.GetString("SrvPID_NOK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Service {0} starting.
        /// </summary>
        internal static string SrvStarting {
            get {
                return ResourceManager.GetString("SrvStarting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Service {0} stopped.
        /// </summary>
        internal static string SrvStopped {
            get {
                return ResourceManager.GetString("SrvStopped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Service {0} stopping.
        /// </summary>
        internal static string SrvStopping {
            get {
                return ResourceManager.GetString("SrvStopping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start permission not set for the service {0},cannot start the service.
        /// </summary>
        internal static string Wrn_StartNotSet {
            get {
                return ResourceManager.GetString("Wrn_StartNotSet", resourceCulture);
            }
        }
    }
}
