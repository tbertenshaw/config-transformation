﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Marazt.ConfigTransformation {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Marazt.ConfigTransformation.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Config Transformation.
        /// </summary>
        public static string ApplicationCaption {
            get {
                return ResourceManager.GetString("ApplicationCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy of source file &apos;{0}&apos; to file &apos;{1}&apos; done.
        /// </summary>
        public static string CopyOfSourceFileDone {
            get {
                return ResourceManager.GetString("CopyOfSourceFileDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deletion of temporary file &apos;{0}&apos; done.
        /// </summary>
        public static string DeletionOfTemporaryFileDone {
            get {
                return ResourceManager.GetString("DeletionOfTemporaryFileDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while trasforming file &apos;{0}&apos; with transformation &apos;{1}&apos; to file &apos;{2}&apos;.
        /// </summary>
        public static string ErrorWhileTransformingFile {
            get {
                return ResourceManager.GetString("ErrorWhileTransformingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Global.
        /// </summary>
        public static string Global {
            get {
                return ResourceManager.GetString("Global", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initialize of  {0}.
        /// </summary>
        public static string InitializeOf {
            get {
                return ResourceManager.GetString("InitializeOf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid tranformation file name.
        /// </summary>
        public static string InvalidTransformationFileName {
            get {
                return ResourceManager.GetString("InvalidTransformationFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Config Transformation.
        /// </summary>
        public static string OptionsCaption {
            get {
                return ResourceManager.GetString("OptionsCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transformation of file &apos;{0}&apos; with transformation &apos;{1}&apos; to file &apos;{2}&apos; successfully done.
        /// </summary>
        public static string TransformationOfFileSuccessfullyDone {
            get {
                return ResourceManager.GetString("TransformationOfFileSuccessfullyDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while transforming file &apos;{0}&apos; with transformation &apos;{1}&apos; to file &apos;{2}&apos; .
        /// </summary>
        public static string TransformationProcessError {
            get {
                return ResourceManager.GetString("TransformationProcessError", resourceCulture);
            }
        }
    }
}
