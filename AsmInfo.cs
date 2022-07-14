/******************************************************************************
**  Copyright(c) 2022 ignackoo. All rights reserved.
**
**  Licensed under the MIT license.
**  See LICENSE file in the project root for full license information.
**
**  This file is a part of the C# Library AsmInfo.
** 
**  Read Assembly informations
**
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Reflection;


namespace Library
{
    public static class AsmInfo
    {
        /// <summary>
        /// Read assembly location path.
        /// </summary>
        /// <param name="assembly">Assembly.</param>
        /// <returns>Assembly location Path.</returns>
        public static string AssemblyPath(Assembly assembly)
        {
            return (Path.GetDirectoryName(assembly.Location));
        }


        /// <summary>
        /// Read assembly title.
        /// </summary>
        /// <param name="assembly">Assembly.</param>
        /// <returns>Assembly title.</returns>
        public static string Title(Assembly assembly)
        {
            return (((AssemblyTitleAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyTitleAttribute), false)).Title);
        }
        
        /// <summary>
        /// Read assembly description.
        /// </summary>
        /// <param name="assembly">Assembly.</param>
        /// <returns>Assembly description.</returns>
        public static string Description(Assembly assembly)
        {
            return (((AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyDescriptionAttribute), false)).Description);
        }

        /// <summary>
        /// Read assembly configuration.
        /// </summary>
        /// <param name="assembly">Assembly.</param>
        /// <returns>Assembly configuration.</returns>
        public static string Configuration(Assembly assembly)
        {
            return (((AssemblyConfigurationAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyConfigurationAttribute), false)).Configuration);
        }

        /// <summary>
        /// Read assembly company.
        /// </summary>
        /// <param name="assembly">Assembly.</param>
        /// <returns>Assembly company.</returns>
        public static string Company(Assembly assembly)
        {
            return (((AssemblyCompanyAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyCompanyAttribute), false)).Company);
        }

        /// <summary>
        /// Read assembly product.
        /// </summary>
        /// <param name="assembly">Assembly.</param>
        /// <returns>Assembly product.</returns>
        public static string Product(Assembly assembly)
        {
            return (((AssemblyProductAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyProductAttribute), false)).Product);
        }

        /// <summary>
        /// Read assembly copyright.
        /// </summary>
        /// <param name="assembly">Assembly.</param>
        /// <returns>Assembly copyright.</returns>
        public static string Copyright(Assembly assembly)
        {
            return (((AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyCopyrightAttribute), false)).Copyright);
        }

        /// <summary>
        /// Read assembly trademark.
        /// </summary>
        /// <param name="assembly">Assembly.</param>
        /// <returns>Assembly trademark.</returns>
        public static string Trademark(Assembly assembly)
        {
            return (((AssemblyTrademarkAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyTrademarkAttribute), false)).Trademark);
        }


        /// <summary>
        /// Read assembly culture.
        /// </summary>
        /// <param name="assembly">Assembly.</param>
        /// <returns>Assembly culture.</returns>
        public static string Culture(Assembly assembly)
        {
            AssemblyCultureAttribute cultureattribute = (AssemblyCultureAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyCultureAttribute), false);
            if (cultureattribute == null) return ("");
            return (cultureattribute.Culture);
        }


        /// <summary>
        /// Read assembly version.
        /// </summary>
        /// <param name="assembly">Assembly.</param>
        /// <returns>Assembly version.</returns>
        public static string VersionFull(Assembly assembly)
        {
            return (assembly.GetName().Version.ToString());
        }


        /// <summary>
        /// Read assembly file version.
        /// </summary>
        /// <param name="assembly">Assembly.</param>
        /// <returns>Assembly file version.</returns>
        public static string FileVersionFull(Assembly assembly)
        {
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            return (version);
        }
    }
}
