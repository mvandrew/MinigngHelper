using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace NiceHashAPI
{
    /// <summary>
    /// Параметры доступа к данным Nice Hash
    /// </summary>
    [DataContract]
    public class NiceHashSettings
    {
        /// <summary>
        /// API ID
        /// </summary>
        [DataMember]
        public Int32 API_Id;
        /// <summary>
        /// API Key
        /// </summary>
        [DataMember]
        public string API_Key;
        /// <summary>
        /// Ключ двухфакторной авторизации (если задан)
        /// </summary>
        [DataMember]
        public string Key_2FA;
        /// <summary>
        /// Экземпляр текущего класса
        /// </summary>
        private static NiceHashSettings _instance = null;
        /// <summary>
        /// Имя файла параметров
        /// </summary>
        public static string FILE_NAME = @"settings.xml";

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public NiceHashSettings()
        {
            // Инициализация данных
            this.API_Id = 0;
            this.API_Key = "";
            this.Key_2FA = "";
        }

        /// <summary>
        /// Индикатор досточного набора настроек для подключения
        /// </summary>
        public bool Sucsess
        {
            get
            {
                return this.API_Id > 0 && this.API_Key.Length > 0;
            }
        }

        /// <summary>
        /// Экземпляр текущего класса. При условии отсутствия, создаёт его.
        /// </summary>
        public static NiceHashSettings Instance
        {
            get
            {
                if (NiceHashSettings._instance == null)
                {
                    NiceHashSettings._instance = NiceHashSettings.LoadSettings();
                }
                return NiceHashSettings._instance;
            }
        }

        /// <summary>
        /// Загружает настройки из файла
        /// </summary>
        public static NiceHashSettings LoadSettings()
        {
            NiceHashSettings __result = new NiceHashSettings();
            FileInfo __settingsInfo = new FileInfo(NiceHashSettings.FILE_NAME);
            if (__settingsInfo.Exists)
            {
                var __ds = new DataContractSerializer(typeof(NiceHashSettings));
                using (Stream __s = File.OpenRead(NiceHashSettings.FILE_NAME))
                {
                    __result = (NiceHashSettings)__ds.ReadObject(__s);
                }
            }
            return __result;
        }

        /// <summary>
        /// Сохраняет настройки в файл
        /// </summary>
        public static bool SaveSettings(NiceHashSettings __object)
        {
            bool __result = false;
            var __ds = new DataContractSerializer(typeof(NiceHashSettings));
            try
            {
                using (Stream __s = File.Create(NiceHashSettings.FILE_NAME))
                {
                    __ds.WriteObject(__s, __object);
                    __result = true;
                }
            } catch { }
            return __result;
        }
    }
}
