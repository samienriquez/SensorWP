/* 
    Copyright (c) 2012 Microsoft Corporation.  All rights reserved.
    Use of this sample source code is subject to the terms of the Microsoft license 
    agreement under which you licensed this sample source code and is provided AS-IS.
    If you did not accept the terms of the license agreement, you are not authorized 
    to use this sample source code.  For the terms of the license, please see the 
    license agreement between you and Microsoft.
  
    To see all Code Samples for Windows Phone, visit http://go.microsoft.com/fwlink/?LinkID=219604 
  
*/
namespace sdkBluetoothA2DWP8CS.Resources {
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
    public class AppResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("sdkBluetoothA2DWP8CS.Resources.AppResources", typeof(AppResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BLUETOOTH A2D SAMPLE.
        /// </summary>
        public static string ApplicationTitle {
            get {
                return ResourceManager.GetString("ApplicationTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connect to selected.
        /// </summary>
        public static string ConnectButtonCaption {
            get {
                return ResourceManager.GetString("ConnectButtonCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Find paired devices.
        /// </summary>
        public static string FindButtonCaption {
            get {
                return ResourceManager.GetString("FindButtonCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This sample shows you how to find all paired devices, enumerate the device PeerInformation, attempt a connection to a device, and handle errors that occur. 
        ///To begin, tap &quot;Find paired devices&quot;..
        /// </summary>
        public static string InstructionsText {
            get {
                return ResourceManager.GetString("InstructionsText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bluetooth is turned off. To see the current Bluetooth settings tap &apos;ok&apos;..
        /// </summary>
        public static string Msg_BluetoothOff {
            get {
                return ResourceManager.GetString("Msg_BluetoothOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connected to {0}!.
        /// </summary>
        public static string Msg_ConnectedTo {
            get {
                return ResourceManager.GetString("Msg_ConnectedTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot run this sample in the emulator because Bluetooth is not enabled. To see the sample working, run it on a Windows Phone 8 device..
        /// </summary>
        public static string Msg_EmulatorMode {
            get {
                return ResourceManager.GetString("Msg_EmulatorMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To run this app, you must have ID_CAP_PROXIMITY enabled in WMAppManifest.xaml.
        /// </summary>
        public static string Msg_MissingCaps {
            get {
                return ResourceManager.GetString("Msg_MissingCaps", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No paired devices found.
        /// </summary>
        public static string Msg_NoPairedDevices {
            get {
                return ResourceManager.GetString("Msg_NoPairedDevices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to page name.
        /// </summary>
        public static string PageTitle {
            get {
                return ResourceManager.GetString("PageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service name to use:.
        /// </summary>
        public static string ServiceFieldPrompt {
            get {
                return ResourceManager.GetString("ServiceFieldPrompt", resourceCulture);
            }
        }
    }
}
