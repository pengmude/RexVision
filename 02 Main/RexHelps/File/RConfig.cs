using System;
using System.Text.RegularExpressions;
using System.Configuration;
using System.ServiceModel.Configuration;

namespace RexHelps
{
    public class RConfig
    {
        protected string strConfigFile;
        Configuration mConfig=null;
        public RConfig(string configFile)
        {
            try
            {
               Configuration mConfig = ConfigurationManager.OpenExeConfiguration(configFile);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            strConfigFile = configFile;
        }
        //依据连接串名字connectionName返回数据连接字符串  
        public string GetConnectionStringsConfig(string connectionName)
        {
            string connectionString =
                mConfig.ConnectionStrings.ConnectionStrings[connectionName].ConnectionString.ToString();
            return connectionString;
        }

        ///<summary> 
        ///更新连接字符串  
        ///</summary> 
        ///<param name="newName">连接字符串名称</param> 
        ///<param name="newConString">连接字符串内容</param> 
        ///<param name="newProviderName">数据提供程序名称</param> 
        public void UpdateConnectionStringsConfig(string newName, string newConString, string newProviderName)
        {
            bool exist = false; //记录该连接串是否已经存在  
            //如果要更改的连接串已经存在  
            if (mConfig.ConnectionStrings.ConnectionStrings[newName] != null)
            {
                exist = true;
            }
            // 如果连接串已存在，首先删除它  
            if (exist)
            {
                mConfig.ConnectionStrings.ConnectionStrings.Remove(newName);
            }
            //新建一个连接字符串实例  
            ConnectionStringSettings mySettings =
                new ConnectionStringSettings(newName, newConString, newProviderName);
            // 将新的连接串添加到配置文件中.  
            mConfig.ConnectionStrings.ConnectionStrings.Add(mySettings);
            // 保存对配置文件所作的更改  
            mConfig.Save(ConfigurationSaveMode.Modified);
            // 强制重新载入配置文件的ConnectionStrings配置节  
            ConfigurationManager.RefreshSection("ConnectionStrings");
        }

        ///<summary> 
        ///返回*.exe.mConfig文件中appSettings配置节的value项  
        ///</summary> 
        ///<param name="strKey"></param> 
        ///<returns></returns> 
        public string GetAppConfig(string strKey)
        {
            foreach (string key in mConfig.AppSettings.Settings.AllKeys)
            {
                if (key == strKey)
                {
                    return mConfig.AppSettings.Settings[strKey].Value.ToString();
                }
            }
            return null;
        }

        ///<summary>  
        ///在*.exe.mConfig文件中appSettings配置节增加一对键值对  
        ///</summary>  
        ///<param name="newKey"></param>  
        ///<param name="newValue"></param>  
        public void UpdateAppConfig(string newKey, string newValue)
        {
            bool exist = false;
            foreach (string key in mConfig.AppSettings.Settings.AllKeys)
            {
                if (key == newKey)
                {
                    exist = true;
                }
            }
            if (exist)
            {
                mConfig.AppSettings.Settings.Remove(newKey);
            }
            mConfig.AppSettings.Settings.Add(newKey, newValue);
            mConfig.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        // 修改system.serviceModel下所有服务终结点的IP地址
        public void UpdateServiceModelConfig(string serverIP)
        {
            ConfigurationSectionGroup sec = mConfig.SectionGroups["system.serviceModel"];
            ServiceModelSectionGroup serviceModelSectionGroup = sec as ServiceModelSectionGroup;
            ClientSection clientSection = serviceModelSectionGroup.Client;
            foreach (ChannelEndpointElement item in clientSection.Endpoints)
            {
                string pattern = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b";
                string address = item.Address.ToString();
                string replacement = string.Format("{0}", serverIP);
                address = Regex.Replace(address, pattern, replacement);
                item.Address = new Uri(address);
            }

            mConfig.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("system.serviceModel");
        }

        // 修改applicationSettings中App.Properties.Settings中服务的IP地址
        public void UpdateConfig(string serverIP)
        {
            ConfigurationSectionGroup sec = mConfig.SectionGroups["applicationSettings"];
            ConfigurationSection configSection = sec.Sections["DataService.Properties.Settings"];
            ClientSettingsSection clientSettingsSection = configSection as ClientSettingsSection;
            if (clientSettingsSection != null)
            {
                SettingElement element1 = clientSettingsSection.Settings.Get("DataService_SystemManagerWS_SystemManagerWS");
                if (element1 != null)
                {
                    clientSettingsSection.Settings.Remove(element1);
                    string oldValue = element1.Value.ValueXml.InnerXml;
                    element1.Value.ValueXml.InnerXml = GetNewIP(oldValue, serverIP);
                    clientSettingsSection.Settings.Add(element1);
                }

                SettingElement element2 = clientSettingsSection.Settings.Get("DataService_EquipManagerWS_EquipManagerWS");
                if (element2 != null)
                {
                    clientSettingsSection.Settings.Remove(element2);
                    string oldValue = element2.Value.ValueXml.InnerXml;
                    element2.Value.ValueXml.InnerXml = GetNewIP(oldValue, serverIP);
                    clientSettingsSection.Settings.Add(element2);
                }
            }
            mConfig.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("applicationSettings");
        }

        private string GetNewIP(string oldValue, string serverIP)
        {
            string pattern = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b";
            string replacement = string.Format("{0}", serverIP);
            string newvalue = Regex.Replace(oldValue, pattern, replacement);
            return newvalue;
        }
    }
}
