using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

public class GenericHelloWorldLoader
{
    public static List<IGenericHelloWorld> GetHelloWorldImplementations()
    {
        List<IGenericHelloWorld> m_ResultList = new List<IGenericHelloWorld>();

        try
        {
            // Get the directory our exe is running from.
            string strPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            strPath = strPath.Substring(0, strPath.LastIndexOf('\\'));

            // All DLLs will be expected to be found in a helloworlds folder.
            strPath += @"\helloworlds";

            // Search for all DLLs in the folder and try to extract their interface.
            foreach (string strFile in Directory.GetFiles(strPath, "*.dll"))
            {
                // Open the class library.
                Assembly anAssembly = Assembly.LoadFrom(strFile);

                // Try to extract our IGenericHelloWorld interface, if it exists.
                foreach (Type aType in anAssembly.GetTypes())
                {
                    if (aType.GetInterface(typeof(IGenericHelloWorld).FullName) != null)
                    {
                        IGenericHelloWorld aGenericHelloWorldImplementation = (IGenericHelloWorld)Activator.CreateInstance(aType);
                        if (aGenericHelloWorldImplementation != null)
                        {
                            // We found an interface, let's add it to the list.
                            m_ResultList.Add(aGenericHelloWorldImplementation);
                        }
                    }
                }
            }
        }
        catch (Exception excep)
        {
            throw new Exception("Error, please verify a \"helloworlds\" folder exists in the same folder as the executable.", excep);
        }

        return m_ResultList;
    }
}